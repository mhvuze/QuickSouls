using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;
using GlobalHook;
using System.Collections.Generic;

namespace QuickSouls
{
    public partial class Form1 : Form
    {
        globalKeyboardHook globalHook = new globalKeyboardHook();

        // Set up variables
        string SaveDir = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\NBGI\\DarkSouls\\");
        int QSKey = (int)Keys.F7;
        int QSKeyMod = (int)Keys.None;
        int QLKey = (int)Keys.F8;
        int QLKeyMod = (int)Keys.None;
        bool SoundFlag = true;
        int GameID = 1;

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
        }

        // Set Dark Souls: PTDE defaults
        private void buttonPTDE_Click(object sender, EventArgs e)
        {
            textBoxDir.Text = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\NBGI\\DarkSouls\\");
            GameID = 1;
            SaveDir = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\NBGI\\DarkSouls\\");

            var lines = File.ReadAllLines(@"QuickSouls.ini");
            lines[0] = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\NBGI\\DarkSouls\\");
            lines[6] = GameID.ToString();
            File.WriteAllLines(@"QuickSouls.ini", lines);
        }

        // Set Dark Souls 2 defaults
        private void buttonDS2_Click(object sender, EventArgs e)
        {
            // Try to figure out unique ID without user input
            string DS2Dir = Path.Combine(Environment.ExpandEnvironmentVariables("%appdata%"), "DarkSoulsII\\");
            if (!Directory.Exists(DS2Dir)) Directory.CreateDirectory(DS2Dir);
            List<string> subfolders = new List<string>(Directory.EnumerateDirectories(DS2Dir));
            string DS2Id = subfolders.Count == 1 ? subfolders[0].Substring(subfolders[0].LastIndexOf("\\") + 1) + "\\" : "paste-your-id-here-and-set\\";

            if (subfolders.Count > 1) { MessageBox.Show("Could not determine unique ID automatically, please add it in the path field on your own.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            // Proceed as usual
            textBoxDir.Text = DS2Dir + DS2Id;
            GameID = 2;
            SaveDir = DS2Dir + DS2Id;

            var lines = File.ReadAllLines(@"QuickSouls.ini");
            lines[0] = DS2Dir + DS2Id;
            lines[6] = GameID.ToString();
            File.WriteAllLines(@"QuickSouls.ini", lines);

            // ***REMOVE LATER***
            MessageBox.Show("This has not been tested yet and is merely based on a theoretical approach. Do not forget to insert the unique ID from the savedata path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Set Dark Souls 2: SOTFS defaults
        private void buttonSOTFS_Click(object sender, EventArgs e)
        {
            // Try to figure out unique ID without user input
            string DS2Dir = Path.Combine(Environment.ExpandEnvironmentVariables("%appdata%"), "DarkSoulsII\\");
            if (!Directory.Exists(DS2Dir)) Directory.CreateDirectory(DS2Dir);
            List<string> subfolders = new List<string>(Directory.EnumerateDirectories(DS2Dir));
            string DS2Id = subfolders.Count == 1 ? subfolders[0].Substring(subfolders[0].LastIndexOf("\\") + 1) + "\\" : "paste-your-id-here-and-set\\";

            if (subfolders.Count > 1) { MessageBox.Show("Could not determine unique ID automatically, please add it in the path field on your own.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            // Proceed as usual
            textBoxDir.Text = DS2Dir + DS2Id;
            GameID = 3;
            SaveDir = DS2Dir + DS2Id;

            var lines = File.ReadAllLines(@"QuickSouls.ini");
            lines[0] = DS2Dir + DS2Id;
            lines[6] = GameID.ToString();
            File.WriteAllLines(@"QuickSouls.ini", lines);

            // ***REMOVE LATER***
            MessageBox.Show("This has not been tested yet and is merely based on a theoretical approach. Do not forget to insert the unique ID from the savedata path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Set Dark Souls 3 defaults
        private void buttonDS3_Click(object sender, EventArgs e)
        {
            // Try to figure out unique ID without user input
            string DS3Dir = Path.Combine(Environment.ExpandEnvironmentVariables("%appdata%"), "DarkSoulsIII\\");
            if (!Directory.Exists(DS3Dir)) Directory.CreateDirectory(DS3Dir);
            List<string> subfolders = new List<string>(Directory.EnumerateDirectories(DS3Dir));
            string DS3Id = subfolders.Count == 1 ? subfolders[0].Substring(subfolders[0].LastIndexOf("\\") + 1) + "\\" : "paste-your-id-here-and-set\\";

            if (subfolders.Count > 1) { MessageBox.Show("Could not determine unique ID automatically, please add it in the path field on your own.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            // Proceed as usual
            textBoxDir.Text = DS3Dir + DS3Id;
            GameID = 4;
            SaveDir = DS3Dir + DS3Id;

            var lines = File.ReadAllLines(@"QuickSouls.ini");
            lines[0] = DS3Dir + DS3Id;
            lines[6] = GameID.ToString();
            File.WriteAllLines(@"QuickSouls.ini", lines);
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
            globalHook.HookedKeys.Add(hotkeyControlQS.Hotkey);
            globalHook.HookedKeys.Add(hotkeyControlQL.Hotkey);

            globalHook.KeyDown += new KeyEventHandler(SaveFunctions);

            buttonLaunch.Enabled = false;
            buttonStop.Enabled = true;

            MessageBox.Show(
                "Hotkeys have been registered.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Unregister Hotkeys
        private void buttonStop_Click(object sender, EventArgs e)
        {
            globalHook.KeyDown -= new KeyEventHandler(SaveFunctions);

            globalHook.HookedKeys.Remove(hotkeyControlQS.Hotkey);
            globalHook.HookedKeys.Remove(hotkeyControlQL.Hotkey);

            buttonLaunch.Enabled = true;
            buttonStop.Enabled = false;

            MessageBox.Show(
                "Hotkeys have been unregistered.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Execute stuff 
        private void SaveFunctions(object sender, KeyEventArgs e)
        {
            // Save
            if (e.KeyCode == hotkeyControlQS.Hotkey)
            {
                // Dark Souls: PTDE
                if (GameID == 1 && File.Exists(SaveDir + "DRAKS0005.sl2"))
                {
                    File.Copy(SaveDir + "DRAKS0005.sl2", @"quicksave_ptde.sl2", true);
                    if (SoundFlag == true)
                        playSound();
                }

                // Dark Souls 2
                if (GameID == 2 && File.Exists(SaveDir + "DARKSII0000.sl2"))
                {
                    File.Copy(SaveDir + "DARKSII0000.sl2", @"quicksave_ds2.sl2", true);
                    if (SoundFlag == true)
                        playSound();
                }

                // Dark Souls 2: SOTFS
                if (GameID == 3 && File.Exists(SaveDir + "DS2SOFS0000.sl2"))
                {
                    File.Copy(SaveDir + "DS2SOFS0000.sl2", @"quicksave_sotfs.sl2", true);
                    if (SoundFlag == true)
                        playSound();
                }

                // Dark Souls 3
                if (GameID == 4 && File.Exists(SaveDir + "DS30000.sl2"))
                {
                    File.Copy(SaveDir + "DS30000.sl2", @"quicksave_ds3.sl2", true);
                    if (SoundFlag == true)
                        playSound();
                }
            }

            // Load
            if (e.KeyCode == hotkeyControlQL.Hotkey)
            {
                // Dark Souls: PTDE
                if (GameID == 1 && File.Exists(@"quicksave_ptde.sl2"))
                {
                    try
                    {
                        File.Copy(@"quicksave_ptde.sl2", SaveDir + "DRAKS0005.sl2", true);
                        if (SoundFlag == true)
                            playSound();
                    }
                    catch { MessageBox.Show("Could not complete quick load.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }

                // Dark Souls 2
                if (GameID == 2 && File.Exists(@"quicksave_ds2.sl2"))
                {
                    try
                    {
                        File.Copy(@"quicksave_ds2.sl2", SaveDir + "DARKSII0000.sl2", true);
                        if (SoundFlag == true)
                            playSound();
                    }
                    catch { MessageBox.Show("Could not complete quick load.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }

                // Dark Souls 2: SOTFS
                if (GameID == 3 && File.Exists(@"quicksave_sotfs.sl2"))
                {
                    try
                    {
                        File.Copy(@"quicksave_sotfs.sl2", SaveDir + "DS2SOFS0000.sl2", true);
                        if (SoundFlag == true)
                            playSound();
                    }
                    catch { MessageBox.Show("Could not complete quick load.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }

                // Dark Souls 3
                if (GameID == 4 && File.Exists(@"quicksave_ds3.sl2"))
                {
                    try
                    {
                        File.Copy(@"quicksave_ds3.sl2", SaveDir + "DS30000.sl2", true);
                        if (SoundFlag == true)
                            playSound();
                    }
                    catch { MessageBox.Show("Could not complete quick load.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
            }

            e.Handled = true;
        }

        // Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Check for config file
            if (!File.Exists(@"QuickSouls.ini"))
            {
                string[] settings = { 
                                        Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\NBGI\\DarkSouls\\"),  // Default save data path
                                        ((int)Keys.F7).ToString(),                                                                              // Default quick save hotkey
                                        ((int)Keys.None).ToString(),                                                                            // Default quick save hotkey modifier
                                        ((int)Keys.F8).ToString(),                                                                              // Default quick load hotkey
                                        ((int)Keys.None).ToString(),                                                                            // Default quick load hotkey modifier
                                        1.ToString(),                                                                                           // Default sound property
                                        1.ToString()                                                                                            // Default game ID (1 = DS:PTDE; 2 = DS2; 3 = DS2:SOTFS; 4 = DS3)
                                    };

                using (StreamWriter defaultConfig = new StreamWriter(@"QuickSouls.ini"))
                {
                    foreach (string line in settings)
                        defaultConfig.WriteLine(line);
                }
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
                GameID = int.Parse(ConfigReader.ReadLine());
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

        // Form Close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalHook.unhook();
        }
    }
}
