namespace _2015_29_04_TI_AED_Console
{
    partial class ComparisonScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparisonScreen));
            this.btExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUnity2 = new System.Windows.Forms.Label();
            this.lbUnity1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbDate2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbConsuption2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbDate1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbAbsoluteChange = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDate1 = new System.Windows.Forms.Label();
            this.mtbPercentualChange = new System.Windows.Forms.MaskedTextBox();
            this.mtbConsuption1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbOwner = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btExit.Location = new System.Drawing.Point(767, 473);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(76, 26);
            this.btExit.TabIndex = 19;
            this.btExit.Text = "EXIT";
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.lbUnity2);
            this.panel1.Controls.Add(this.lbUnity1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mtbDate2);
            this.panel1.Controls.Add(this.mtbConsuption2);
            this.panel1.Controls.Add(this.mtbDate1);
            this.panel1.Controls.Add(this.mtbAbsoluteChange);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelDate1);
            this.panel1.Controls.Add(this.mtbPercentualChange);
            this.panel1.Controls.Add(this.mtbConsuption1);
            this.panel1.Controls.Add(this.mtbOwner);
            this.panel1.Location = new System.Drawing.Point(53, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 395);
            this.panel1.TabIndex = 32;
            // 
            // lbUnity2
            // 
            this.lbUnity2.AutoSize = true;
            this.lbUnity2.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbUnity2.Location = new System.Drawing.Point(689, 214);
            this.lbUnity2.Name = "lbUnity2";
            this.lbUnity2.Size = new System.Drawing.Size(0, 18);
            this.lbUnity2.TabIndex = 40;
            // 
            // lbUnity1
            // 
            this.lbUnity1.AutoSize = true;
            this.lbUnity1.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbUnity1.Location = new System.Drawing.Point(689, 176);
            this.lbUnity1.Name = "lbUnity1";
            this.lbUnity1.Size = new System.Drawing.Size(0, 18);
            this.lbUnity1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F);
            this.label4.Location = new System.Drawing.Point(61, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Percentage change (%)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(61, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Absolute change";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(61, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Consuption in";
            // 
            // mtbDate2
            // 
            this.mtbDate2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbDate2.BackColor = System.Drawing.Color.PeachPuff;
            this.mtbDate2.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbDate2.Location = new System.Drawing.Point(351, 173);
            this.mtbDate2.Margin = new System.Windows.Forms.Padding(4);
            this.mtbDate2.Mask = "00/0000";
            this.mtbDate2.Name = "mtbDate2";
            this.mtbDate2.Size = new System.Drawing.Size(133, 27);
            this.mtbDate2.TabIndex = 34;
            this.mtbDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbConsuption2
            // 
            this.mtbConsuption2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbConsuption2.BackColor = System.Drawing.Color.Bisque;
            this.mtbConsuption2.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbConsuption2.Location = new System.Drawing.Point(491, 173);
            this.mtbConsuption2.Name = "mtbConsuption2";
            this.mtbConsuption2.Size = new System.Drawing.Size(232, 27);
            this.mtbConsuption2.TabIndex = 33;
            this.mtbConsuption2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbDate1
            // 
            this.mtbDate1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbDate1.BackColor = System.Drawing.Color.PeachPuff;
            this.mtbDate1.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbDate1.Location = new System.Drawing.Point(351, 211);
            this.mtbDate1.Margin = new System.Windows.Forms.Padding(4);
            this.mtbDate1.Mask = "00/0000";
            this.mtbDate1.Name = "mtbDate1";
            this.mtbDate1.Size = new System.Drawing.Size(133, 27);
            this.mtbDate1.TabIndex = 32;
            this.mtbDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbAbsoluteChange
            // 
            this.mtbAbsoluteChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbAbsoluteChange.BackColor = System.Drawing.Color.Bisque;
            this.mtbAbsoluteChange.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbAbsoluteChange.Location = new System.Drawing.Point(351, 250);
            this.mtbAbsoluteChange.Name = "mtbAbsoluteChange";
            this.mtbAbsoluteChange.Size = new System.Drawing.Size(372, 27);
            this.mtbAbsoluteChange.TabIndex = 27;
            this.mtbAbsoluteChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 17F);
            this.label5.Location = new System.Drawing.Point(120, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "COMPARISON CONSUPTION REPORT";
            // 
            // labelDate1
            // 
            this.labelDate1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDate1.AutoSize = true;
            this.labelDate1.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelDate1.Location = new System.Drawing.Point(61, 134);
            this.labelDate1.Name = "labelDate1";
            this.labelDate1.Size = new System.Drawing.Size(60, 18);
            this.labelDate1.TabIndex = 20;
            this.labelDate1.Text = "Owner";
            // 
            // mtbPercentualChange
            // 
            this.mtbPercentualChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbPercentualChange.BackColor = System.Drawing.Color.Bisque;
            this.mtbPercentualChange.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbPercentualChange.Location = new System.Drawing.Point(351, 288);
            this.mtbPercentualChange.Name = "mtbPercentualChange";
            this.mtbPercentualChange.Size = new System.Drawing.Size(372, 27);
            this.mtbPercentualChange.TabIndex = 28;
            this.mtbPercentualChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbConsuption1
            // 
            this.mtbConsuption1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbConsuption1.BackColor = System.Drawing.Color.Bisque;
            this.mtbConsuption1.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbConsuption1.Location = new System.Drawing.Point(491, 211);
            this.mtbConsuption1.Name = "mtbConsuption1";
            this.mtbConsuption1.Size = new System.Drawing.Size(232, 27);
            this.mtbConsuption1.TabIndex = 26;
            this.mtbConsuption1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbOwner
            // 
            this.mtbOwner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbOwner.BackColor = System.Drawing.Color.Bisque;
            this.mtbOwner.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbOwner.Location = new System.Drawing.Point(351, 134);
            this.mtbOwner.Name = "mtbOwner";
            this.mtbOwner.Size = new System.Drawing.Size(372, 27);
            this.mtbOwner.TabIndex = 25;
            this.mtbOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComparisonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(889, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComparisonScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comparison Consuption Report - DRAP® WECS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtbAbsoluteChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDate1;
        private System.Windows.Forms.MaskedTextBox mtbPercentualChange;
        private System.Windows.Forms.MaskedTextBox mtbConsuption1;
        private System.Windows.Forms.MaskedTextBox mtbOwner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbDate2;
        private System.Windows.Forms.MaskedTextBox mtbConsuption2;
        private System.Windows.Forms.MaskedTextBox mtbDate1;
        private System.Windows.Forms.Label lbUnity2;
        private System.Windows.Forms.Label lbUnity1;
    }
}