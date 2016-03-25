using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;

namespace QuickSouls
{
    public partial class Form1 : Form
    {
        // Set up variables
        string SaveDir = "";
        int QSKey = 0;
        int QSKeyMod = 0;
        int QLKey = 0;
        int QLKeyMod = 0;
        bool SoundFlag = true;

        // Enable global hotkey functionality
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Sound Play
        private void playSound()
        {
            SoundPlayer Sound = new SoundPlayer(@"sound.wav");
            Sound.Play();
        }

        // Form
        public Form1()
        {
            InitializeComponent();

            // Check for config file
            if (!File.Exists(@"QuickSouls.ini"))
            {
                string[] settings = { 
                                        Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\NBGI\\DarkSouls\\"),  // Default save data path
                                        ((int)Keys.F7).ToString(),                                                                              // Default quick save hotkey
                                        ((int)Keys.None).ToString(),                                                                            // Default quick save hotkey modifier
                                        ((int)Keys.F8).ToString(),                                                                              // Default quick load hotkey
                                        ((int)Keys.None).ToString(),                                                                            // Default quick load hotkey modifier
                                        1.ToString()                                                                                            // Default sound property                     
                                    };

                using (StreamWriter defaultConfig = new StreamWriter(@"QuickSouls.ini"))
                {
                    foreach (string line in settings)
                        defaultConfig.WriteLine(line);
                }

                SaveDir = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\NBGI\\DarkSouls\\");
                QSKey = (int)Keys.F7;
                QSKeyMod = (int)Keys.None;
                QLKey = (int)Keys.F8;
                QLKeyMod = (int)Keys.None;
                SoundFlag = true;
            }
            else
            {
                StreamReader ConfigReader = new StreamReader(@"QuickSouls.ini");
                SaveDir = ConfigReader.ReadLine();
                QSKey = int.Parse(ConfigReader.ReadLine());
                QSKeyMod = int.Parse(ConfigReader.ReadLine());
                QLKey = int.Parse(ConfigReader.ReadLine());
                QLKeyMod = int.Parse(ConfigReader.ReadLine());
                SoundFlag = int.Parse(ConfigReader.ReadLine()) == 1 ? true : false;
                ConfigReader.Close();
            }

            // Fill boxes
            textBoxDir.Text = SaveDir;
            hotkeyControlQS.Hotkey = (Keys)QSKey;
            hotkeyControlQS.HotkeyModifiers = (Keys)QSKeyMod;
            hotkeyControlQL.Hotkey = (Keys)QLKey;
            hotkeyControlQL.HotkeyModifiers = (Keys)QLKeyMod;
            checkBoxSound.Checked = SoundFlag == true ? true : false;
        }

        // 'Set save directory' button
        private void buttonSetDir_Click(object sender, EventArgs e)
        {
            SaveDir = textBoxDir.Text;
            var lines = File.ReadAllLines(@"QuickSouls.ini");
            lines[0] = SaveDir;
            File.WriteAllLines(@"QuickSouls.ini", lines);

            MessageBox.Show(
                "Save directory has been set to:\n" + SaveDir,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // 'Set hotkeys' button
        private void buttonSetKey_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(@"QuickSouls.ini");
            lines[1] = ((int)hotkeyControlQS.Hotkey).ToString();
            lines[2] = ((int)hotkeyControlQS.HotkeyModifiers).ToString();
            lines[3] = ((int)hotkeyControlQL.Hotkey).ToString();
            lines[4] = ((int)hotkeyControlQL.HotkeyModifiers).ToString();
            File.WriteAllLines(@"QuickSouls.ini", lines);

            MessageBox.Show(
                "Hotkeys have been set.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Sound enable/disable
        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(@"QuickSouls.ini");
            lines[5] = checkBoxSound.Checked == true ? "1" : "0";
            File.WriteAllLines(@"QuickSouls.ini", lines);

            SoundFlag = checkBoxSound.Checked == true ? true : false;
        }

        // Register Hotkeys
        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 1, (int)hotkeyControlQS.HotkeyModifiers, (int)hotkeyControlQS.Hotkey);
            RegisterHotKey(this.Handle, 2, (int)hotkeyControlQL.HotkeyModifiers, (int)hotkeyControlQL.Hotkey);

            MessageBox.Show(
                "Hotkeys have been registered.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Execute stuff
        protected override void WndProc(ref Message m)
        {
            // Quick Save
            if (m.Msg == 0x0312 && (int)m.WParam == 1)
            {
                if (File.Exists(SaveDir + "DRAKS0005.sl2"))
                {
                    File.Copy(SaveDir + "DRAKS0005.sl2", @"quicksave.sl2", true);
                    if (SoundFlag == true)
                        playSound();
                }
            }

            // Quick Load
            if (m.Msg == 0x0312 && (int)m.WParam == 2)
            {
                if (File.Exists(@"quicksave.sl2"))
                {
                    try { 
                        File.Copy(@"quicksave.sl2", SaveDir + "DRAKS0005.sl2", true);
                        if (SoundFlag == true)
                            playSound();
                        }
                    catch { MessageBox.Show("Could not complete quick load.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
            }

            base.WndProc(ref m);
        }

        // Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Form Close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
        }
    }
}
