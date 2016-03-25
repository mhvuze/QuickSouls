namespace QuickSouls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDir = new System.Windows.Forms.Label();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.buttonSetDir = new System.Windows.Forms.Button();
            this.labelSeperator1 = new System.Windows.Forms.Label();
            this.labelQSKey = new System.Windows.Forms.Label();
            this.labelQLKey = new System.Windows.Forms.Label();
            this.buttonSetKey = new System.Windows.Forms.Button();
            this.labelSeperator2 = new System.Windows.Forms.Label();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.hotkeyControlQL = new exscape.HotkeyControl();
            this.hotkeyControlQS = new exscape.HotkeyControl();
            this.SuspendLayout();
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(12, 13);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(148, 13);
            this.labelDir.TabIndex = 0;
            this.labelDir.Text = "Dark Souls Save Data Folder:";
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(162, 10);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(275, 20);
            this.textBoxDir.TabIndex = 1;
            // 
            // buttonSetDir
            // 
            this.buttonSetDir.Location = new System.Drawing.Point(443, 8);
            this.buttonSetDir.Name = "buttonSetDir";
            this.buttonSetDir.Size = new System.Drawing.Size(78, 23);
            this.buttonSetDir.TabIndex = 2;
            this.buttonSetDir.Text = "Set";
            this.buttonSetDir.UseVisualStyleBackColor = true;
            this.buttonSetDir.Click += new System.EventHandler(this.buttonSetDir_Click);
            // 
            // labelSeperator1
            // 
            this.labelSeperator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeperator1.Location = new System.Drawing.Point(13, 38);
            this.labelSeperator1.Name = "labelSeperator1";
            this.labelSeperator1.Size = new System.Drawing.Size(509, 2);
            this.labelSeperator1.TabIndex = 3;
            // 
            // labelQSKey
            // 
            this.labelQSKey.AutoSize = true;
            this.labelQSKey.Location = new System.Drawing.Point(13, 50);
            this.labelQSKey.Name = "labelQSKey";
            this.labelQSKey.Size = new System.Drawing.Size(98, 13);
            this.labelQSKey.TabIndex = 4;
            this.labelQSKey.Text = "Quicksave Hotkey:";
            // 
            // labelQLKey
            // 
            this.labelQLKey.AutoSize = true;
            this.labelQLKey.Location = new System.Drawing.Point(214, 50);
            this.labelQLKey.Name = "labelQLKey";
            this.labelQLKey.Size = new System.Drawing.Size(95, 13);
            this.labelQLKey.TabIndex = 6;
            this.labelQLKey.Text = "Quickload Hotkey:";
            // 
            // buttonSetKey
            // 
            this.buttonSetKey.Location = new System.Drawing.Point(443, 45);
            this.buttonSetKey.Name = "buttonSetKey";
            this.buttonSetKey.Size = new System.Drawing.Size(78, 23);
            this.buttonSetKey.TabIndex = 8;
            this.buttonSetKey.Text = "Set";
            this.buttonSetKey.UseVisualStyleBackColor = true;
            this.buttonSetKey.Click += new System.EventHandler(this.buttonSetKey_Click);
            // 
            // labelSeperator2
            // 
            this.labelSeperator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeperator2.Location = new System.Drawing.Point(12, 74);
            this.labelSeperator2.Name = "labelSeperator2";
            this.labelSeperator2.Size = new System.Drawing.Size(509, 2);
            this.labelSeperator2.TabIndex = 9;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(12, 85);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(195, 35);
            this.buttonLaunch.TabIndex = 10;
            this.buttonLaunch.Text = "Register Hotkeys";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Checked = true;
            this.checkBoxSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSound.Location = new System.Drawing.Point(213, 95);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(161, 17);
            this.checkBoxSound.TabIndex = 11;
            this.checkBoxSound.Text = "Play Sound after Save/Load";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            this.checkBoxSound.CheckedChanged += new System.EventHandler(this.checkBoxSound_CheckedChanged);
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(354, 140);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(168, 13);
            this.labelCredits.TabIndex = 12;
            this.labelCredits.Text = "QuickSouls v1.1 by MHVuze";
            // 
            // hotkeyControlQL
            // 
            this.hotkeyControlQL.Hotkey = System.Windows.Forms.Keys.F8;
            this.hotkeyControlQL.HotkeyModifiers = System.Windows.Forms.Keys.None;
            this.hotkeyControlQL.Location = new System.Drawing.Point(315, 47);
            this.hotkeyControlQL.Name = "hotkeyControlQL";
            this.hotkeyControlQL.Size = new System.Drawing.Size(90, 20);
            this.hotkeyControlQL.TabIndex = 7;
            this.hotkeyControlQL.Text = "F8";
            // 
            // hotkeyControlQS
            // 
            this.hotkeyControlQS.Hotkey = System.Windows.Forms.Keys.F7;
            this.hotkeyControlQS.HotkeyModifiers = System.Windows.Forms.Keys.None;
            this.hotkeyControlQS.Location = new System.Drawing.Point(117, 47);
            this.hotkeyControlQS.Name = "hotkeyControlQS";
            this.hotkeyControlQS.Size = new System.Drawing.Size(90, 20);
            this.hotkeyControlQS.TabIndex = 5;
            this.hotkeyControlQS.Text = "F7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 162);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.checkBoxSound);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.hotkeyControlQL);
            this.Controls.Add(this.hotkeyControlQS);
            this.Controls.Add(this.labelSeperator2);
            this.Controls.Add(this.buttonSetKey);
            this.Controls.Add(this.labelQLKey);
            this.Controls.Add(this.labelQSKey);
            this.Controls.Add(this.labelSeperator1);
            this.Controls.Add(this.buttonSetDir);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.labelDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QuickSouls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button buttonSetDir;
        private System.Windows.Forms.Label labelSeperator1;
        private System.Windows.Forms.Label labelQSKey;
        private System.Windows.Forms.Label labelQLKey;
        private System.Windows.Forms.Button buttonSetKey;
        private System.Windows.Forms.Label labelSeperator2;
        private exscape.HotkeyControl hotkeyControlQS;
        private exscape.HotkeyControl hotkeyControlQL;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.Label labelCredits;
    }
}

