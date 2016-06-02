namespace _2015_29_04_TI_AED_Console
{
    partial class ReportSelectScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSelectScreen));
            this.rbWaterReport = new System.Windows.Forms.RadioButton();
            this.rbEnergyReport = new System.Windows.Forms.RadioButton();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbDateEnd = new System.Windows.Forms.MaskedTextBox();
            this.mtbDateStart = new System.Windows.Forms.MaskedTextBox();
            this.rbOwner = new System.Windows.Forms.RadioButton();
            this.rbCompany = new System.Windows.Forms.RadioButton();
            this.rbEnergyCompare = new System.Windows.Forms.RadioButton();
            this.rbWaterCompare = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDate1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbSelectDate = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDate3 = new System.Windows.Forms.Label();
            this.btCompareBills = new System.Windows.Forms.Button();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.gbselectData = new System.Windows.Forms.GroupBox();
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.gbOwner = new System.Windows.Forms.GroupBox();
            this.mtbOwner = new System.Windows.Forms.MaskedTextBox();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.ReportSelectStatusBar = new System.Windows.Forms.StatusStrip();
            this.ReportSelectScreenStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbSelectDate.SuspendLayout();
            this.gbselectData.SuspendLayout();
            this.gbCompany.SuspendLayout();
            this.gbOwner.SuspendLayout();
            this.ReportSelectStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbWaterReport
            // 
            this.rbWaterReport.AutoSize = true;
            this.rbWaterReport.BackColor = System.Drawing.Color.Transparent;
            this.rbWaterReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbWaterReport.FlatAppearance.BorderSize = 0;
            this.rbWaterReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbWaterReport.Font = new System.Drawing.Font("Verdana", 12F);
            this.rbWaterReport.Location = new System.Drawing.Point(248, 55);
            this.rbWaterReport.Margin = new System.Windows.Forms.Padding(4);
            this.rbWaterReport.Name = "rbWaterReport";
            this.rbWaterReport.Size = new System.Drawing.Size(96, 30);
            this.rbWaterReport.TabIndex = 5;
            this.rbWaterReport.Text = "Water";
            this.rbWaterReport.UseVisualStyleBackColor = false;
            this.rbWaterReport.Click += new System.EventHandler(this.rbWaterReport_Click);
            // 
            // rbEnergyReport
            // 
            this.rbEnergyReport.AutoSize = true;
            this.rbEnergyReport.BackColor = System.Drawing.Color.Transparent;
            this.rbEnergyReport.Checked = true;
            this.rbEnergyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEnergyReport.FlatAppearance.BorderSize = 0;
            this.rbEnergyReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbEnergyReport.Font = new System.Drawing.Font("Verdana", 12F);
            this.rbEnergyReport.Location = new System.Drawing.Point(103, 55);
            this.rbEnergyReport.Margin = new System.Windows.Forms.Padding(4);
            this.rbEnergyReport.Name = "rbEnergyReport";
            this.rbEnergyReport.Size = new System.Drawing.Size(107, 30);
            this.rbEnergyReport.TabIndex = 4;
            this.rbEnergyReport.TabStop = true;
            this.rbEnergyReport.Text = "Energy";
            this.rbEnergyReport.UseVisualStyleBackColor = false;
            this.rbEnergyReport.Click += new System.EventHandler(this.rbEnergyReport_Click);
            // 
            // mtbDate
            // 
            this.mtbDate.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbDate.Location = new System.Drawing.Point(248, 123);
            this.mtbDate.Margin = new System.Windows.Forms.Padding(4);
            this.mtbDate.Mask = "00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(222, 32);
            this.mtbDate.TabIndex = 6;
            this.mtbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDate_KeyPress);
            // 
            // mtbDateEnd
            // 
            this.mtbDateEnd.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbDateEnd.Location = new System.Drawing.Point(171, 98);
            this.mtbDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.mtbDateEnd.Mask = "00/0000";
            this.mtbDateEnd.Name = "mtbDateEnd";
            this.mtbDateEnd.Size = new System.Drawing.Size(109, 32);
            this.mtbDateEnd.TabIndex = 8;
            this.mtbDateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDateEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbOwner_KeyPress);
            // 
            // mtbDateStart
            // 
            this.mtbDateStart.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtbDateStart.Location = new System.Drawing.Point(171, 58);
            this.mtbDateStart.Margin = new System.Windows.Forms.Padding(4);
            this.mtbDateStart.Mask = "00/0000";
            this.mtbDateStart.Name = "mtbDateStart";
            this.mtbDateStart.Size = new System.Drawing.Size(109, 32);
            this.mtbDateStart.TabIndex = 9;
            this.mtbDateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDateStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbOwner_KeyPress);
            // 
            // rbOwner
            // 
            this.rbOwner.AutoSize = true;
            this.rbOwner.BackColor = System.Drawing.Color.Transparent;
            this.rbOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOwner.FlatAppearance.BorderSize = 0;
            this.rbOwner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbOwner.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.rbOwner.Location = new System.Drawing.Point(167, 96);
            this.rbOwner.Margin = new System.Windows.Forms.Padding(4);
            this.rbOwner.Name = "rbOwner";
            this.rbOwner.Size = new System.Drawing.Size(114, 30);
            this.rbOwner.TabIndex = 11;
            this.rbOwner.Text = "Person";
            this.rbOwner.UseVisualStyleBackColor = false;
            this.rbOwner.Click += new System.EventHandler(this.rbOwner_Click);
            // 
            // rbCompany
            // 
            this.rbCompany.AutoSize = true;
            this.rbCompany.BackColor = System.Drawing.Color.Transparent;
            this.rbCompany.Checked = true;
            this.rbCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCompany.FlatAppearance.BorderSize = 0;
            this.rbCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbCompany.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.rbCompany.Location = new System.Drawing.Point(7, 96);
            this.rbCompany.Margin = new System.Windows.Forms.Padding(4);
            this.rbCompany.Name = "rbCompany";
            this.rbCompany.Size = new System.Drawing.Size(139, 30);
            this.rbCompany.TabIndex = 12;
            this.rbCompany.TabStop = true;
            this.rbCompany.Text = "Company";
            this.rbCompany.UseVisualStyleBackColor = false;
            this.rbCompany.Click += new System.EventHandler(this.rbCompany_Click);
            // 
            // rbEnergyCompare
            // 
            this.rbEnergyCompare.AutoSize = true;
            this.rbEnergyCompare.BackColor = System.Drawing.Color.Transparent;
            this.rbEnergyCompare.Checked = true;
            this.rbEnergyCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEnergyCompare.FlatAppearance.BorderSize = 0;
            this.rbEnergyCompare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbEnergyCompare.Font = new System.Drawing.Font("Verdana", 12F);
            this.rbEnergyCompare.Location = new System.Drawing.Point(7, 17);
            this.rbEnergyCompare.Margin = new System.Windows.Forms.Padding(4);
            this.rbEnergyCompare.Name = "rbEnergyCompare";
            this.rbEnergyCompare.Size = new System.Drawing.Size(107, 30);
            this.rbEnergyCompare.TabIndex = 14;
            this.rbEnergyCompare.TabStop = true;
            this.rbEnergyCompare.Text = "Energy";
            this.rbEnergyCompare.UseVisualStyleBackColor = false;
            this.rbEnergyCompare.Click += new System.EventHandler(this.rbEnergyCompare_Click);
            // 
            // rbWaterCompare
            // 
            this.rbWaterCompare.AutoSize = true;
            this.rbWaterCompare.BackColor = System.Drawing.Color.Transparent;
            this.rbWaterCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbWaterCompare.FlatAppearance.BorderSize = 0;
            this.rbWaterCompare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbWaterCompare.Font = new System.Drawing.Font("Verdana", 12F);
            this.rbWaterCompare.Location = new System.Drawing.Point(7, 55);
            this.rbWaterCompare.Margin = new System.Windows.Forms.Padding(4);
            this.rbWaterCompare.Name = "rbWaterCompare";
            this.rbWaterCompare.Size = new System.Drawing.Size(96, 30);
            this.rbWaterCompare.TabIndex = 15;
            this.rbWaterCompare.Text = "Water";
            this.rbWaterCompare.UseVisualStyleBackColor = false;
            this.rbWaterCompare.Click += new System.EventHandler(this.rbWaterCompare_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 12F);
            this.tabControl1.Location = new System.Drawing.Point(38, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 370);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consuption Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbEnergyReport);
            this.groupBox3.Controls.Add(this.rbWaterReport);
            this.groupBox3.Controls.Add(this.labelDate1);
            this.groupBox3.Controls.Add(this.mtbDate);
            this.groupBox3.Location = new System.Drawing.Point(40, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 195);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select data";
            // 
            // labelDate1
            // 
            this.labelDate1.AutoSize = true;
            this.labelDate1.Location = new System.Drawing.Point(98, 126);
            this.labelDate1.Name = "labelDate1";
            this.labelDate1.Size = new System.Drawing.Size(132, 25);
            this.labelDate1.TabIndex = 9;
            this.labelDate1.Text = "Insert date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Generate Report";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Transparent;
            this.btSearch.BackgroundImage = global::_2015_29_04_TI_AED_Console.Properties.Resources.Relatory;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btSearch.Location = new System.Drawing.Point(645, 86);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(122, 152);
            this.btSearch.TabIndex = 7;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbSelectDate);
            this.tabPage2.Controls.Add(this.gbselectData);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare Consuption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbSelectDate
            // 
            this.gbSelectDate.Controls.Add(this.label4);
            this.gbSelectDate.Controls.Add(this.labelDate3);
            this.gbSelectDate.Controls.Add(this.btCompareBills);
            this.gbSelectDate.Controls.Add(this.labelDate2);
            this.gbSelectDate.Controls.Add(this.mtbDateStart);
            this.gbSelectDate.Controls.Add(this.mtbDateEnd);
            this.gbSelectDate.Location = new System.Drawing.Point(486, 27);
            this.gbSelectDate.Name = "gbSelectDate";
            this.gbSelectDate.Size = new System.Drawing.Size(310, 296);
            this.gbSelectDate.TabIndex = 17;
            this.gbSelectDate.TabStop = false;
            this.gbSelectDate.Text = "Select date to compare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Compare Bills";
            // 
            // labelDate3
            // 
            this.labelDate3.AutoSize = true;
            this.labelDate3.Location = new System.Drawing.Point(32, 101);
            this.labelDate3.Name = "labelDate3";
            this.labelDate3.Size = new System.Drawing.Size(110, 25);
            this.labelDate3.TabIndex = 11;
            this.labelDate3.Text = "End date:";
            // 
            // btCompareBills
            // 
            this.btCompareBills.BackColor = System.Drawing.Color.Transparent;
            this.btCompareBills.BackgroundImage = global::_2015_29_04_TI_AED_Console.Properties.Resources.Comparation;
            this.btCompareBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCompareBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCompareBills.FlatAppearance.BorderSize = 0;
            this.btCompareBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCompareBills.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompareBills.ForeColor = System.Drawing.Color.Transparent;
            this.btCompareBills.Location = new System.Drawing.Point(98, 155);
            this.btCompareBills.Margin = new System.Windows.Forms.Padding(4);
            this.btCompareBills.Name = "btCompareBills";
            this.btCompareBills.Size = new System.Drawing.Size(125, 118);
            this.btCompareBills.TabIndex = 18;
            this.btCompareBills.UseVisualStyleBackColor = false;
            this.btCompareBills.Click += new System.EventHandler(this.btCompareBills_Click);
            this.btCompareBills.MouseLeave += new System.EventHandler(this.btCompareBills_MouseLeave);
            this.btCompareBills.MouseHover += new System.EventHandler(this.btCompareBills_MouseHover);
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Location = new System.Drawing.Point(32, 61);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(123, 25);
            this.labelDate2.TabIndex = 10;
            this.labelDate2.Text = "Start date:";
            // 
            // gbselectData
            // 
            this.gbselectData.Controls.Add(this.gbCompany);
            this.gbselectData.Controls.Add(this.rbCompany);
            this.gbselectData.Controls.Add(this.rbOwner);
            this.gbselectData.Controls.Add(this.gbOwner);
            this.gbselectData.Location = new System.Drawing.Point(6, 27);
            this.gbselectData.Name = "gbselectData";
            this.gbselectData.Size = new System.Drawing.Size(474, 296);
            this.gbselectData.TabIndex = 16;
            this.gbselectData.TabStop = false;
            this.gbselectData.Text = "Select data";
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.rbEnergyCompare);
            this.gbCompany.Controls.Add(this.rbWaterCompare);
            this.gbCompany.Location = new System.Drawing.Point(0, 121);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(160, 94);
            this.gbCompany.TabIndex = 16;
            this.gbCompany.TabStop = false;
            // 
            // gbOwner
            // 
            this.gbOwner.Controls.Add(this.mtbOwner);
            this.gbOwner.Controls.Add(this.rbCNPJ);
            this.gbOwner.Controls.Add(this.rbCPF);
            this.gbOwner.Enabled = false;
            this.gbOwner.Location = new System.Drawing.Point(166, 121);
            this.gbOwner.Name = "gbOwner";
            this.gbOwner.Size = new System.Drawing.Size(293, 94);
            this.gbOwner.TabIndex = 21;
            this.gbOwner.TabStop = false;
            // 
            // mtbOwner
            // 
            this.mtbOwner.Location = new System.Drawing.Point(6, 17);
            this.mtbOwner.Mask = "000000000-00";
            this.mtbOwner.Name = "mtbOwner";
            this.mtbOwner.Size = new System.Drawing.Size(281, 32);
            this.mtbOwner.TabIndex = 21;
            this.mtbOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbOwner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbOwner_KeyPress);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.rbCNPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCNPJ.FlatAppearance.BorderSize = 0;
            this.rbCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbCNPJ.Font = new System.Drawing.Font("Verdana", 12F);
            this.rbCNPJ.Location = new System.Drawing.Point(174, 55);
            this.rbCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(86, 30);
            this.rbCNPJ.TabIndex = 19;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = false;
            this.rbCNPJ.Click += new System.EventHandler(this.rbCNPJ_Click);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.BackColor = System.Drawing.Color.Transparent;
            this.rbCPF.Checked = true;
            this.rbCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCPF.FlatAppearance.BorderSize = 0;
            this.rbCPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbCPF.Font = new System.Drawing.Font("Verdana", 12F);
            this.rbCPF.Location = new System.Drawing.Point(41, 55);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(74, 30);
            this.rbCPF.TabIndex = 20;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = false;
            this.rbCPF.Click += new System.EventHandler(this.rbCPF_Click);
            // 
            // ReportSelectStatusBar
            // 
            this.ReportSelectStatusBar.BackColor = System.Drawing.Color.Chocolate;
            this.ReportSelectStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportSelectScreenStatus});
            this.ReportSelectStatusBar.Location = new System.Drawing.Point(0, 472);
            this.ReportSelectStatusBar.Name = "ReportSelectStatusBar";
            this.ReportSelectStatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.ReportSelectStatusBar.Size = new System.Drawing.Size(885, 25);
            this.ReportSelectStatusBar.TabIndex = 17;
            this.ReportSelectStatusBar.Text = "Status Bar";
            // 
            // ReportSelectScreenStatus
            // 
            this.ReportSelectScreenStatus.Name = "ReportSelectScreenStatus";
            this.ReportSelectScreenStatus.Size = new System.Drawing.Size(270, 20);
            this.ReportSelectScreenStatus.Text = "There are no messages to be displayed.";
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
            this.btExit.Location = new System.Drawing.Point(772, 426);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(76, 26);
            this.btExit.TabIndex = 18;
            this.btExit.Text = "EXIT";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ReportSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(885, 497);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.ReportSelectStatusBar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportSelectScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Select  - DRAP® WECS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbSelectDate.ResumeLayout(false);
            this.gbSelectDate.PerformLayout();
            this.gbselectData.ResumeLayout(false);
            this.gbselectData.PerformLayout();
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            this.gbOwner.ResumeLayout(false);
            this.gbOwner.PerformLayout();
            this.ReportSelectStatusBar.ResumeLayout(false);
            this.ReportSelectStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbWaterReport;
        private System.Windows.Forms.RadioButton rbEnergyReport;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.MaskedTextBox mtbDateEnd;
        private System.Windows.Forms.MaskedTextBox mtbDateStart;
        private System.Windows.Forms.RadioButton rbOwner;
        private System.Windows.Forms.RadioButton rbCompany;
        private System.Windows.Forms.RadioButton rbEnergyCompare;
        private System.Windows.Forms.RadioButton rbWaterCompare;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelDate1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCompareBills;
        private System.Windows.Forms.GroupBox gbSelectDate;
        private System.Windows.Forms.Label labelDate3;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.GroupBox gbselectData;
        private System.Windows.Forms.StatusStrip ReportSelectStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel ReportSelectScreenStatus;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox gbCompany;
        private System.Windows.Forms.GroupBox gbOwner;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.MaskedTextBox mtbOwner;
    }
}