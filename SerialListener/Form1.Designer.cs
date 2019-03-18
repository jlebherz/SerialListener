namespace SerialListener
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lable_connected_com2 = new System.Windows.Forms.Label();
            this.lable_connected_com1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bPort2 = new System.Windows.Forms.Button();
            this.cbBaudRate2 = new System.Windows.Forms.ComboBox();
            this.cbPort2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bPort1 = new System.Windows.Forms.Button();
            this.cbBaudRate1 = new System.Windows.Forms.ComboBox();
            this.cbPort1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbResult = new System.Windows.Forms.ListBox();
            this.bClearSent = new System.Windows.Forms.Button();
            this.use_porttrenner = new System.Windows.Forms.CheckBox();
            this.rbCR = new System.Windows.Forms.RadioButton();
            this.rbR = new System.Windows.Forms.RadioButton();
            this.gbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.rbR);
            this.gbConfig.Controls.Add(this.rbCR);
            this.gbConfig.Controls.Add(this.label8);
            this.gbConfig.Controls.Add(this.lable_connected_com2);
            this.gbConfig.Controls.Add(this.lable_connected_com1);
            this.gbConfig.Controls.Add(this.label4);
            this.gbConfig.Controls.Add(this.label5);
            this.gbConfig.Controls.Add(this.label6);
            this.gbConfig.Controls.Add(this.bPort2);
            this.gbConfig.Controls.Add(this.cbBaudRate2);
            this.gbConfig.Controls.Add(this.cbPort2);
            this.gbConfig.Controls.Add(this.label1);
            this.gbConfig.Controls.Add(this.label3);
            this.gbConfig.Controls.Add(this.label2);
            this.gbConfig.Controls.Add(this.bPort1);
            this.gbConfig.Controls.Add(this.cbBaudRate1);
            this.gbConfig.Controls.Add(this.cbPort1);
            this.gbConfig.Location = new System.Drawing.Point(13, 58);
            this.gbConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfig.Size = new System.Drawing.Size(416, 472);
            this.gbConfig.TabIndex = 1;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Serialport Config";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Zeilenende";
            // 
            // lable_connected_com2
            // 
            this.lable_connected_com2.AutoSize = true;
            this.lable_connected_com2.Location = new System.Drawing.Point(18, 331);
            this.lable_connected_com2.Name = "lable_connected_com2";
            this.lable_connected_com2.Size = new System.Drawing.Size(58, 20);
            this.lable_connected_com2.TabIndex = 14;
            this.lable_connected_com2.Text = "Closed";
            // 
            // lable_connected_com1
            // 
            this.lable_connected_com1.AutoSize = true;
            this.lable_connected_com1.Location = new System.Drawing.Point(16, 159);
            this.lable_connected_com1.Name = "lable_connected_com1";
            this.lable_connected_com1.Size = new System.Drawing.Size(58, 20);
            this.lable_connected_com1.TabIndex = 13;
            this.lable_connected_com1.Text = "Closed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Port 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Baudrate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Port:";
            // 
            // bPort2
            // 
            this.bPort2.Location = new System.Drawing.Point(296, 331);
            this.bPort2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPort2.Name = "bPort2";
            this.bPort2.Size = new System.Drawing.Size(112, 35);
            this.bPort2.TabIndex = 9;
            this.bPort2.Text = "Open";
            this.bPort2.UseVisualStyleBackColor = true;
            this.bPort2.Click += new System.EventHandler(this.bPort2_Click);
            // 
            // cbBaudRate2
            // 
            this.cbBaudRate2.FormattingEnabled = true;
            this.cbBaudRate2.Location = new System.Drawing.Point(192, 283);
            this.cbBaudRate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaudRate2.Name = "cbBaudRate2";
            this.cbBaudRate2.Size = new System.Drawing.Size(216, 28);
            this.cbBaudRate2.TabIndex = 8;
            // 
            // cbPort2
            // 
            this.cbPort2.FormattingEnabled = true;
            this.cbPort2.Location = new System.Drawing.Point(192, 242);
            this.cbPort2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPort2.Name = "cbPort2";
            this.cbPort2.Size = new System.Drawing.Size(216, 28);
            this.cbPort2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Baudrate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // bPort1
            // 
            this.bPort1.Location = new System.Drawing.Point(296, 159);
            this.bPort1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPort1.Name = "bPort1";
            this.bPort1.Size = new System.Drawing.Size(112, 35);
            this.bPort1.TabIndex = 4;
            this.bPort1.Text = "Open";
            this.bPort1.UseVisualStyleBackColor = true;
            this.bPort1.Click += new System.EventHandler(this.bPort1_Click);
            // 
            // cbBaudRate1
            // 
            this.cbBaudRate1.FormattingEnabled = true;
            this.cbBaudRate1.Location = new System.Drawing.Point(192, 111);
            this.cbBaudRate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaudRate1.Name = "cbBaudRate1";
            this.cbBaudRate1.Size = new System.Drawing.Size(216, 28);
            this.cbBaudRate1.TabIndex = 2;
            // 
            // cbPort1
            // 
            this.cbPort1.FormattingEnabled = true;
            this.cbPort1.Location = new System.Drawing.Point(192, 70);
            this.cbPort1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPort1.Name = "cbPort1";
            this.cbPort1.Size = new System.Drawing.Size(216, 28);
            this.cbPort1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 538);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 214);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1748, 35);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.dateiToolStripMenuItem.Text = "Beenden";
            this.dateiToolStripMenuItem.Click += new System.EventHandler(this.dateiToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbResult
            // 
            this.tbResult.FormattingEnabled = true;
            this.tbResult.ItemHeight = 20;
            this.tbResult.Location = new System.Drawing.Point(452, 126);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(1283, 624);
            this.tbResult.TabIndex = 20;
            // 
            // bClearSent
            // 
            this.bClearSent.Location = new System.Drawing.Point(1623, 86);
            this.bClearSent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClearSent.Name = "bClearSent";
            this.bClearSent.Size = new System.Drawing.Size(112, 35);
            this.bClearSent.TabIndex = 21;
            this.bClearSent.Text = "Clear";
            this.bClearSent.UseVisualStyleBackColor = true;
            this.bClearSent.Click += new System.EventHandler(this.bClearSent_Click);
            // 
            // use_porttrenner
            // 
            this.use_porttrenner.AutoSize = true;
            this.use_porttrenner.Location = new System.Drawing.Point(473, 69);
            this.use_porttrenner.Name = "use_porttrenner";
            this.use_porttrenner.Size = new System.Drawing.Size(196, 24);
            this.use_porttrenner.TabIndex = 22;
            this.use_porttrenner.Text = "Porttrenner verwenden";
            this.use_porttrenner.UseVisualStyleBackColor = true;
            // 
            // rbCR
            // 
            this.rbCR.AutoSize = true;
            this.rbCR.Location = new System.Drawing.Point(178, 409);
            this.rbCR.Name = "rbCR";
            this.rbCR.Size = new System.Drawing.Size(160, 24);
            this.rbCR.TabIndex = 18;
            this.rbCR.TabStop = true;
            this.rbCR.Text = "\\r Carriage Return";
            this.rbCR.UseVisualStyleBackColor = true;
            // 
            // rbR
            // 
            this.rbR.AutoSize = true;
            this.rbR.Location = new System.Drawing.Point(178, 440);
            this.rbR.Name = "rbR";
            this.rbR.Size = new System.Drawing.Size(100, 24);
            this.rbR.TabIndex = 19;
            this.rbR.TabStop = true;
            this.rbR.Text = "\\n Return";
            this.rbR.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 764);
            this.Controls.Add(this.use_porttrenner);
            this.Controls.Add(this.bClearSent);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "SerialListener by John Lebherz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bPort2;
        private System.Windows.Forms.ComboBox cbBaudRate2;
        private System.Windows.Forms.ComboBox cbPort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bPort1;
        private System.Windows.Forms.ComboBox cbBaudRate1;
        private System.Windows.Forms.ComboBox cbPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox tbResult;
        private System.Windows.Forms.Label lable_connected_com2;
        private System.Windows.Forms.Label lable_connected_com1;
        private System.Windows.Forms.Button bClearSent;
        private System.Windows.Forms.CheckBox use_porttrenner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbR;
        private System.Windows.Forms.RadioButton rbCR;
    }
}

