namespace SPTManager
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.clientMods = new System.Windows.Forms.Panel();
            this.serverModsBtn = new System.Windows.Forms.Button();
            this.clientModsBtn = new System.Windows.Forms.Button();
            this.serverInfoPanel = new System.Windows.Forms.Panel();
            this.serverMods = new System.Windows.Forms.Panel();
            this.globalFontSizeTitle = new System.Windows.Forms.Label();
            this.globalFontSizeBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.globalFontSizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clientMods
            // 
            this.clientMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clientMods.AutoScroll = true;
            this.clientMods.Location = new System.Drawing.Point(0, 0);
            this.clientMods.Name = "clientMods";
            this.clientMods.Size = new System.Drawing.Size(385, 468);
            this.clientMods.TabIndex = 0;
            // 
            // serverModsBtn
            // 
            this.serverModsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.serverModsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.serverModsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverModsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.serverModsBtn.FlatAppearance.BorderSize = 0;
            this.serverModsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.serverModsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.serverModsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverModsBtn.Location = new System.Drawing.Point(1, 471);
            this.serverModsBtn.Name = "serverModsBtn";
            this.serverModsBtn.Size = new System.Drawing.Size(162, 36);
            this.serverModsBtn.TabIndex = 1;
            this.serverModsBtn.Text = "Server mods";
            this.serverModsBtn.UseVisualStyleBackColor = false;
            this.serverModsBtn.Click += new System.EventHandler(this.serverModsBtn_Click);
            // 
            // clientModsBtn
            // 
            this.clientModsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clientModsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientModsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.clientModsBtn.FlatAppearance.BorderSize = 0;
            this.clientModsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.clientModsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.clientModsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientModsBtn.Location = new System.Drawing.Point(164, 471);
            this.clientModsBtn.Name = "clientModsBtn";
            this.clientModsBtn.Size = new System.Drawing.Size(162, 36);
            this.clientModsBtn.TabIndex = 2;
            this.clientModsBtn.Text = "Client mods";
            this.clientModsBtn.UseVisualStyleBackColor = true;
            this.clientModsBtn.Click += new System.EventHandler(this.clientModsBtn_Click);
            // 
            // serverInfoPanel
            // 
            this.serverInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverInfoPanel.Location = new System.Drawing.Point(391, 0);
            this.serverInfoPanel.Name = "serverInfoPanel";
            this.serverInfoPanel.Size = new System.Drawing.Size(524, 468);
            this.serverInfoPanel.TabIndex = 3;
            // 
            // serverMods
            // 
            this.serverMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serverMods.AutoScroll = true;
            this.serverMods.Location = new System.Drawing.Point(0, 0);
            this.serverMods.Name = "serverMods";
            this.serverMods.Size = new System.Drawing.Size(385, 468);
            this.serverMods.TabIndex = 4;
            // 
            // globalFontSizeTitle
            // 
            this.globalFontSizeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.globalFontSizeTitle.AutoSize = true;
            this.globalFontSizeTitle.Location = new System.Drawing.Point(329, 477);
            this.globalFontSizeTitle.Name = "globalFontSizeTitle";
            this.globalFontSizeTitle.Size = new System.Drawing.Size(110, 17);
            this.globalFontSizeTitle.TabIndex = 5;
            this.globalFontSizeTitle.Text = "Global font size:";
            // 
            // globalFontSizeBox
            // 
            this.globalFontSizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.globalFontSizeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.globalFontSizeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.globalFontSizeBox.ForeColor = System.Drawing.Color.LightGray;
            this.globalFontSizeBox.Location = new System.Drawing.Point(445, 478);
            this.globalFontSizeBox.Name = "globalFontSizeBox";
            this.globalFontSizeBox.Size = new System.Drawing.Size(56, 20);
            this.globalFontSizeBox.TabIndex = 6;
            this.globalFontSizeBox.ValueChanged += new System.EventHandler(this.globalFontSizeBox_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(753, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add new mod";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(927, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.globalFontSizeBox);
            this.Controls.Add(this.globalFontSizeTitle);
            this.Controls.Add(this.serverInfoPanel);
            this.Controls.Add(this.clientModsBtn);
            this.Controls.Add(this.serverModsBtn);
            this.Controls.Add(this.serverMods);
            this.Controls.Add(this.clientMods);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPT Manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.globalFontSizeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel clientMods;
        private System.Windows.Forms.Button serverModsBtn;
        private System.Windows.Forms.Button clientModsBtn;
        private System.Windows.Forms.Panel serverInfoPanel;
        private System.Windows.Forms.Panel serverMods;
        private System.Windows.Forms.Label globalFontSizeTitle;
        private System.Windows.Forms.NumericUpDown globalFontSizeBox;
        private System.Windows.Forms.Button button1;
    }
}

