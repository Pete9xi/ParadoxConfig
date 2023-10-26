
namespace ParadoxConfig
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxReleases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtHomeAmount = new System.Windows.Forms.TextBox();
            this.lblSetHomeAmount = new System.Windows.Forms.Label();
            this.txtHotBarMsg = new System.Windows.Forms.TextBox();
            this.lblHotBarMsg = new System.Windows.Forms.Label();
            this.txtRule1 = new System.Windows.Forms.TextBox();
            this.lblRule1 = new System.Windows.Forms.Label();
            this.txtRule2 = new System.Windows.Forms.TextBox();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.txtRule3 = new System.Windows.Forms.TextBox();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.txtRule4 = new System.Windows.Forms.TextBox();
            this.lblRule4 = new System.Windows.Forms.Label();
            this.txtRule5 = new System.Windows.Forms.TextBox();
            this.lblRule5 = new System.Windows.Forms.Label();
            this.txtBanAppeal = new System.Windows.Forms.TextBox();
            this.lblBanAppeal = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Pack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxReleases
            // 
            this.comboBoxReleases.FormattingEnabled = true;
            this.comboBoxReleases.Location = new System.Drawing.Point(204, 7);
            this.comboBoxReleases.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxReleases.Name = "comboBoxReleases";
            this.comboBoxReleases.Size = new System.Drawing.Size(141, 21);
            this.comboBoxReleases.TabIndex = 1;
            this.comboBoxReleases.SelectedIndexChanged += new System.EventHandler(this.comboBoxReleases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a release to download";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a password to be set in config.js\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(101, 332);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(333, 127);
            this.txtLog.TabIndex = 5;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(204, 33);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(141, 20);
            this.txtPrefix.TabIndex = 7;
            this.txtPrefix.Text = "!";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(12, 33);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(104, 13);
            this.lblPrefix.TabIndex = 6;
            this.lblPrefix.Text = "Set a custom Prefix?";
            // 
            // txtHomeAmount
            // 
            this.txtHomeAmount.Location = new System.Drawing.Point(204, 85);
            this.txtHomeAmount.Name = "txtHomeAmount";
            this.txtHomeAmount.Size = new System.Drawing.Size(141, 20);
            this.txtHomeAmount.TabIndex = 9;
            this.txtHomeAmount.Text = "5";
            // 
            // lblSetHomeAmount
            // 
            this.lblSetHomeAmount.AutoSize = true;
            this.lblSetHomeAmount.Location = new System.Drawing.Point(12, 85);
            this.lblSetHomeAmount.Name = "lblSetHomeAmount";
            this.lblSetHomeAmount.Size = new System.Drawing.Size(155, 26);
            this.lblSetHomeAmount.TabIndex = 8;
            this.lblSetHomeAmount.Text = "Max Amount of saved locations\r\n\r\n";
            // 
            // txtHotBarMsg
            // 
            this.txtHotBarMsg.Location = new System.Drawing.Point(204, 111);
            this.txtHotBarMsg.Name = "txtHotBarMsg";
            this.txtHotBarMsg.Size = new System.Drawing.Size(264, 20);
            this.txtHotBarMsg.TabIndex = 11;
            this.txtHotBarMsg.Text = "Hotbar is enabled (Set your message to change this)";
            // 
            // lblHotBarMsg
            // 
            this.lblHotBarMsg.AutoSize = true;
            this.lblHotBarMsg.Location = new System.Drawing.Point(12, 111);
            this.lblHotBarMsg.Name = "lblHotBarMsg";
            this.lblHotBarMsg.Size = new System.Drawing.Size(86, 13);
            this.lblHotBarMsg.TabIndex = 10;
            this.lblHotBarMsg.Text = "HotBar Message";
            // 
            // txtRule1
            // 
            this.txtRule1.Location = new System.Drawing.Point(204, 137);
            this.txtRule1.Name = "txtRule1";
            this.txtRule1.Size = new System.Drawing.Size(264, 20);
            this.txtRule1.TabIndex = 13;
            this.txtRule1.Text = "No hacking allowed.";
            // 
            // lblRule1
            // 
            this.lblRule1.AutoSize = true;
            this.lblRule1.Location = new System.Drawing.Point(12, 137);
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.Size = new System.Drawing.Size(35, 13);
            this.lblRule1.TabIndex = 12;
            this.lblRule1.Text = "Rule1";
            // 
            // txtRule2
            // 
            this.txtRule2.Location = new System.Drawing.Point(204, 163);
            this.txtRule2.Name = "txtRule2";
            this.txtRule2.Size = new System.Drawing.Size(264, 20);
            this.txtRule2.TabIndex = 15;
            this.txtRule2.Text = "Don\'t grief other players\' builds.";
            // 
            // lblRule2
            // 
            this.lblRule2.AutoSize = true;
            this.lblRule2.Location = new System.Drawing.Point(12, 163);
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.Size = new System.Drawing.Size(35, 13);
            this.lblRule2.TabIndex = 14;
            this.lblRule2.Text = "Rule2";
            // 
            // txtRule3
            // 
            this.txtRule3.Location = new System.Drawing.Point(204, 189);
            this.txtRule3.Name = "txtRule3";
            this.txtRule3.Size = new System.Drawing.Size(264, 20);
            this.txtRule3.TabIndex = 17;
            this.txtRule3.Text = "Be kind to everyone on the server.";
            // 
            // lblRule3
            // 
            this.lblRule3.AutoSize = true;
            this.lblRule3.Location = new System.Drawing.Point(12, 189);
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.Size = new System.Drawing.Size(35, 13);
            this.lblRule3.TabIndex = 16;
            this.lblRule3.Text = "Rule3";
            // 
            // txtRule4
            // 
            this.txtRule4.Location = new System.Drawing.Point(204, 215);
            this.txtRule4.Name = "txtRule4";
            this.txtRule4.Size = new System.Drawing.Size(264, 20);
            this.txtRule4.TabIndex = 19;
            this.txtRule4.Text = "Follow the staff\'s instructions";
            // 
            // lblRule4
            // 
            this.lblRule4.AutoSize = true;
            this.lblRule4.Location = new System.Drawing.Point(12, 215);
            this.lblRule4.Name = "lblRule4";
            this.lblRule4.Size = new System.Drawing.Size(35, 13);
            this.lblRule4.TabIndex = 18;
            this.lblRule4.Text = "Rule4";
            // 
            // txtRule5
            // 
            this.txtRule5.Location = new System.Drawing.Point(204, 241);
            this.txtRule5.Name = "txtRule5";
            this.txtRule5.Size = new System.Drawing.Size(264, 20);
            this.txtRule5.TabIndex = 21;
            this.txtRule5.Text = "No spamming or advertising.";
            // 
            // lblRule5
            // 
            this.lblRule5.AutoSize = true;
            this.lblRule5.Location = new System.Drawing.Point(12, 241);
            this.lblRule5.Name = "lblRule5";
            this.lblRule5.Size = new System.Drawing.Size(35, 13);
            this.lblRule5.TabIndex = 20;
            this.lblRule5.Text = "Rule5";
            // 
            // txtBanAppeal
            // 
            this.txtBanAppeal.Location = new System.Drawing.Point(204, 267);
            this.txtBanAppeal.Name = "txtBanAppeal";
            this.txtBanAppeal.Size = new System.Drawing.Size(264, 20);
            this.txtBanAppeal.TabIndex = 23;
            this.txtBanAppeal.Text = "https://discord.gg";
            // 
            // lblBanAppeal
            // 
            this.lblBanAppeal.AutoSize = true;
            this.lblBanAppeal.Location = new System.Drawing.Point(12, 267);
            this.lblBanAppeal.Name = "lblBanAppeal";
            this.lblBanAppeal.Size = new System.Drawing.Size(62, 13);
            this.lblBanAppeal.TabIndex = 22;
            this.lblBanAppeal.Text = "Ban Appeal";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(476, 448);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 13);
            this.lblVersion.TabIndex = 24;
            this.lblVersion.Text = "v1.0.0.3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 470);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtBanAppeal);
            this.Controls.Add(this.lblBanAppeal);
            this.Controls.Add(this.txtRule5);
            this.Controls.Add(this.lblRule5);
            this.Controls.Add(this.txtRule4);
            this.Controls.Add(this.lblRule4);
            this.Controls.Add(this.txtRule3);
            this.Controls.Add(this.lblRule3);
            this.Controls.Add(this.txtRule2);
            this.Controls.Add(this.lblRule2);
            this.Controls.Add(this.txtRule1);
            this.Controls.Add(this.lblRule1);
            this.Controls.Add(this.txtHotBarMsg);
            this.Controls.Add(this.lblHotBarMsg);
            this.Controls.Add(this.txtHomeAmount);
            this.Controls.Add(this.lblSetHomeAmount);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxReleases);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ParadoxConfig";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxReleases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtHomeAmount;
        private System.Windows.Forms.Label lblSetHomeAmount;
        private System.Windows.Forms.TextBox txtHotBarMsg;
        private System.Windows.Forms.Label lblHotBarMsg;
        private System.Windows.Forms.TextBox txtRule1;
        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.TextBox txtRule2;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.TextBox txtRule3;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.TextBox txtRule4;
        private System.Windows.Forms.Label lblRule4;
        private System.Windows.Forms.TextBox txtRule5;
        private System.Windows.Forms.Label lblRule5;
        private System.Windows.Forms.TextBox txtBanAppeal;
        private System.Windows.Forms.Label lblBanAppeal;
        private System.Windows.Forms.Label lblVersion;
    }
}

