namespace _2015_29_04_TI_AED_Console
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pbSplashBackground = new System.Windows.Forms.PictureBox();
            this.ProgrBarSplash = new System.Windows.Forms.ProgressBar();
            this.TimerSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSplashBackground
            // 
            this.pbSplashBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbSplashBackground.Image")));
            this.pbSplashBackground.Location = new System.Drawing.Point(-137, -2);
            this.pbSplashBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSplashBackground.Name = "pbSplashBackground";
            this.pbSplashBackground.Size = new System.Drawing.Size(1089, 502);
            this.pbSplashBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplashBackground.TabIndex = 0;
            this.pbSplashBackground.TabStop = false;
            // 
            // ProgrBarSplash
            // 
            this.ProgrBarSplash.Location = new System.Drawing.Point(-7, 363);
            this.ProgrBarSplash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgrBarSplash.Name = "ProgrBarSplash";
            this.ProgrBarSplash.Size = new System.Drawing.Size(959, 30);
            this.ProgrBarSplash.TabIndex = 1;
            // 
            // TimerSplash
            // 
            this.TimerSplash.Enabled = true;
            this.TimerSplash.Tick += new System.EventHandler(this.TimerSplash_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 391);
            this.ControlBox = false;
            this.Controls.Add(this.ProgrBarSplash);
            this.Controls.Add(this.pbSplashBackground);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSplashBackground;
        private System.Windows.Forms.ProgressBar ProgrBarSplash;
        private System.Windows.Forms.Timer TimerSplash;
    }
}