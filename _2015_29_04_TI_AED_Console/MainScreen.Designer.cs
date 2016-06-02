namespace _2015_29_04_TI_AED_Console
{
    partial class MainScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.MainScreenStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbImportFrom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearchScreen = new System.Windows.Forms.ToolStripButton();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAboutUs = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tips = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.DarkOrange;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainScreenStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 524);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.StatusBar.Size = new System.Drawing.Size(1161, 25);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // MainScreenStatus
            // 
            this.MainScreenStatus.Name = "MainScreenStatus";
            this.MainScreenStatus.Size = new System.Drawing.Size(270, 20);
            this.MainScreenStatus.Text = "There are no messages to be displayed.";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsbImport,
            this.tsbImportFrom,
            this.toolStripSeparator1,
            this.tsbSearchScreen,
            this.tsbReport,
            this.toolStripSeparator4,
            this.tsbAboutUs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1161, 71);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Image = global::_2015_29_04_TI_AED_Console.Properties.Resources.DirectImport;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(68, 68);
            this.tsbImport.Text = "Import data directly";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            this.tsbImport.MouseLeave += new System.EventHandler(this.tsbImport_MouseLeave);
            this.tsbImport.MouseHover += new System.EventHandler(this.tsbImport_MouseHover);
            // 
            // tsbImportFrom
            // 
            this.tsbImportFrom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImportFrom.Image = global::_2015_29_04_TI_AED_Console.Properties.Resources.ImportByFile;
            this.tsbImportFrom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImportFrom.Name = "tsbImportFrom";
            this.tsbImportFrom.Size = new System.Drawing.Size(68, 68);
            this.tsbImportFrom.Text = "Import data from file";
            this.tsbImportFrom.Click += new System.EventHandler(this.tsbImportFrom_Click);
            this.tsbImportFrom.MouseLeave += new System.EventHandler(this.tsbImportFrom_MouseLeave);
            this.tsbImportFrom.MouseHover += new System.EventHandler(this.tsbImportFrom_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbSearchScreen
            // 
            this.tsbSearchScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchScreen.Image = global::_2015_29_04_TI_AED_Console.Properties.Resources.Search;
            this.tsbSearchScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchScreen.Name = "tsbSearchScreen";
            this.tsbSearchScreen.Size = new System.Drawing.Size(68, 68);
            this.tsbSearchScreen.Text = "Search";
            this.tsbSearchScreen.Click += new System.EventHandler(this.tsbSearchScreen_Click);
            this.tsbSearchScreen.MouseLeave += new System.EventHandler(this.tsbSearchScreen_MouseLeave);
            this.tsbSearchScreen.MouseHover += new System.EventHandler(this.tsbSearchScreen_MouseHover);
            // 
            // tsbReport
            // 
            this.tsbReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReport.Image = global::_2015_29_04_TI_AED_Console.Properties.Resources.Relatory;
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(68, 68);
            this.tsbReport.Text = "Report";
            this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
            this.tsbReport.MouseLeave += new System.EventHandler(this.tsbReport_MouseLeave);
            this.tsbReport.MouseHover += new System.EventHandler(this.tsbReport_MouseHover);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbAboutUs
            // 
            this.tsbAboutUs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAboutUs.Image = global::_2015_29_04_TI_AED_Console.Properties.Resources.AboutUs;
            this.tsbAboutUs.ImageTransparentColor = System.Drawing.Color.DarkOrange;
            this.tsbAboutUs.Name = "tsbAboutUs";
            this.tsbAboutUs.Size = new System.Drawing.Size(68, 68);
            this.tsbAboutUs.Text = "About Us";
            this.tsbAboutUs.Click += new System.EventHandler(this.tsbAboutUs_Click);
            this.tsbAboutUs.MouseLeave += new System.EventHandler(this.tsbAboutUs_MouseLeave);
            this.tsbAboutUs.MouseHover += new System.EventHandler(this.tsbAboutUs_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tips);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 453);
            this.panel1.TabIndex = 3;
            // 
            // Tips
            // 
            this.Tips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Tips.AutoSize = true;
            this.Tips.BackColor = System.Drawing.Color.Transparent;
            this.Tips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tips.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tips.Location = new System.Drawing.Point(16, 414);
            this.Tips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tips.Name = "Tips";
            this.Tips.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tips.Size = new System.Drawing.Size(142, 26);
            this.Tips.TabIndex = 1;
            this.Tips.Text = "System tips";
            this.Tips.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tips.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1161, 453);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.StatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRAP® WECS - Water and Energy Control System";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel MainScreenStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbImportFrom;
        private System.Windows.Forms.ToolStripButton tsbSearchScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Tips;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAboutUs;
    }
}

