namespace _2015_29_04_TI_AED_Console
{
    partial class SearchScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchScreen));
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.rbBillTypeBoth = new System.Windows.Forms.RadioButton();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.rbEnergy = new System.Windows.Forms.RadioButton();
            this.gbFindBy = new System.Windows.Forms.GroupBox();
            this.rbFindByBoth = new System.Windows.Forms.RadioButton();
            this.rbOwner = new System.Windows.Forms.RadioButton();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthAndYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.mtbOwner = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCleanSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SearchStatusBar = new System.Windows.Forms.StatusStrip();
            this.SearchScreenStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbCompany.SuspendLayout();
            this.gbFindBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SearchStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCompany
            // 
            this.gbCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCompany.Controls.Add(this.rbBillTypeBoth);
            this.gbCompany.Controls.Add(this.rbWater);
            this.gbCompany.Controls.Add(this.rbEnergy);
            this.gbCompany.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompany.Location = new System.Drawing.Point(32, 15);
            this.gbCompany.Margin = new System.Windows.Forms.Padding(4);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Padding = new System.Windows.Forms.Padding(4);
            this.gbCompany.Size = new System.Drawing.Size(327, 54);
            this.gbCompany.TabIndex = 0;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Company";
            // 
            // rbBillTypeBoth
            // 
            this.rbBillTypeBoth.AutoSize = true;
            this.rbBillTypeBoth.BackColor = System.Drawing.Color.Transparent;
            this.rbBillTypeBoth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBillTypeBoth.FlatAppearance.BorderSize = 0;
            this.rbBillTypeBoth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbBillTypeBoth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBillTypeBoth.Location = new System.Drawing.Point(237, 22);
            this.rbBillTypeBoth.Margin = new System.Windows.Forms.Padding(4);
            this.rbBillTypeBoth.Name = "rbBillTypeBoth";
            this.rbBillTypeBoth.Size = new System.Drawing.Size(67, 23);
            this.rbBillTypeBoth.TabIndex = 2;
            this.rbBillTypeBoth.Text = "Both";
            this.rbBillTypeBoth.UseVisualStyleBackColor = false;
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.BackColor = System.Drawing.Color.Transparent;
            this.rbWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbWater.FlatAppearance.BorderSize = 0;
            this.rbWater.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbWater.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWater.Location = new System.Drawing.Point(132, 22);
            this.rbWater.Margin = new System.Windows.Forms.Padding(4);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(76, 23);
            this.rbWater.TabIndex = 1;
            this.rbWater.Text = "Water";
            this.rbWater.UseVisualStyleBackColor = false;
            // 
            // rbEnergy
            // 
            this.rbEnergy.AutoSize = true;
            this.rbEnergy.BackColor = System.Drawing.Color.Transparent;
            this.rbEnergy.Checked = true;
            this.rbEnergy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEnergy.FlatAppearance.BorderSize = 0;
            this.rbEnergy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbEnergy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnergy.Location = new System.Drawing.Point(29, 22);
            this.rbEnergy.Margin = new System.Windows.Forms.Padding(4);
            this.rbEnergy.Name = "rbEnergy";
            this.rbEnergy.Size = new System.Drawing.Size(83, 23);
            this.rbEnergy.TabIndex = 0;
            this.rbEnergy.TabStop = true;
            this.rbEnergy.Text = "Energy";
            this.rbEnergy.UseVisualStyleBackColor = false;
            // 
            // gbFindBy
            // 
            this.gbFindBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbFindBy.Controls.Add(this.rbFindByBoth);
            this.gbFindBy.Controls.Add(this.rbOwner);
            this.gbFindBy.Controls.Add(this.rbDate);
            this.gbFindBy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFindBy.Location = new System.Drawing.Point(32, 81);
            this.gbFindBy.Margin = new System.Windows.Forms.Padding(4);
            this.gbFindBy.Name = "gbFindBy";
            this.gbFindBy.Padding = new System.Windows.Forms.Padding(4);
            this.gbFindBy.Size = new System.Drawing.Size(327, 54);
            this.gbFindBy.TabIndex = 1;
            this.gbFindBy.TabStop = false;
            this.gbFindBy.Text = "Find by";
            // 
            // rbFindByBoth
            // 
            this.rbFindByBoth.AutoSize = true;
            this.rbFindByBoth.BackColor = System.Drawing.Color.Transparent;
            this.rbFindByBoth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFindByBoth.FlatAppearance.BorderSize = 0;
            this.rbFindByBoth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbFindByBoth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFindByBoth.Location = new System.Drawing.Point(237, 23);
            this.rbFindByBoth.Margin = new System.Windows.Forms.Padding(4);
            this.rbFindByBoth.Name = "rbFindByBoth";
            this.rbFindByBoth.Size = new System.Drawing.Size(67, 23);
            this.rbFindByBoth.TabIndex = 3;
            this.rbFindByBoth.Text = "Both";
            this.rbFindByBoth.UseVisualStyleBackColor = false;
            this.rbFindByBoth.CheckedChanged += new System.EventHandler(this.rbFindByBoth_CheckedChanged);
            // 
            // rbOwner
            // 
            this.rbOwner.AutoSize = true;
            this.rbOwner.BackColor = System.Drawing.Color.Transparent;
            this.rbOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOwner.FlatAppearance.BorderSize = 0;
            this.rbOwner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbOwner.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOwner.Location = new System.Drawing.Point(132, 23);
            this.rbOwner.Margin = new System.Windows.Forms.Padding(4);
            this.rbOwner.Name = "rbOwner";
            this.rbOwner.Size = new System.Drawing.Size(81, 23);
            this.rbOwner.TabIndex = 1;
            this.rbOwner.Text = "Owner";
            this.rbOwner.UseVisualStyleBackColor = false;
            this.rbOwner.CheckedChanged += new System.EventHandler(this.rbOwner_CheckedChanged);
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.BackColor = System.Drawing.Color.Transparent;
            this.rbDate.Checked = true;
            this.rbDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDate.FlatAppearance.BorderSize = 0;
            this.rbDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDate.Location = new System.Drawing.Point(29, 23);
            this.rbDate.Margin = new System.Windows.Forms.Padding(4);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(67, 23);
            this.rbDate.TabIndex = 0;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "Date";
            this.rbDate.UseVisualStyleBackColor = false;
            this.rbDate.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged);
            // 
            // mtbDate
            // 
            this.mtbDate.Font = new System.Drawing.Font("Verdana", 9F);
            this.mtbDate.Location = new System.Drawing.Point(96, 32);
            this.mtbDate.Margin = new System.Windows.Forms.Padding(4);
            this.mtbDate.Mask = "00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(120, 26);
            this.mtbDate.TabIndex = 3;
            this.mtbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDate_KeyPress);
            // 
            // dgvBills
            // 
            this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBills.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.owner,
            this.ownerType,
            this.monthAndYear,
            this.consumption,
            this.previousConsumption,
            this.currentConsumption,
            this.value});
            this.dgvBills.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBills.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBills.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBills.Location = new System.Drawing.Point(32, 154);
            this.dgvBills.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.Size = new System.Drawing.Size(991, 438);
            this.dgvBills.TabIndex = 5;
            // 
            // owner
            // 
            this.owner.HeaderText = "Owner";
            this.owner.Name = "owner";
            // 
            // ownerType
            // 
            this.ownerType.HeaderText = "Owner type";
            this.ownerType.Name = "ownerType";
            // 
            // monthAndYear
            // 
            this.monthAndYear.HeaderText = "Date";
            this.monthAndYear.Name = "monthAndYear";
            // 
            // consumption
            // 
            this.consumption.HeaderText = "Consumption";
            this.consumption.Name = "consumption";
            // 
            // previousConsumption
            // 
            this.previousConsumption.HeaderText = "Previous consumption";
            this.previousConsumption.Name = "previousConsumption";
            // 
            // currentConsumption
            // 
            this.currentConsumption.HeaderText = "Current consumption";
            this.currentConsumption.Name = "currentConsumption";
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Owner";
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSearch.Controls.Add(this.rbCNPJ);
            this.gbSearch.Controls.Add(this.rbCPF);
            this.gbSearch.Controls.Add(this.mtbOwner);
            this.gbSearch.Controls.Add(this.label4);
            this.gbSearch.Controls.Add(this.btCleanSearch);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.mtbDate);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(387, 15);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearch.Size = new System.Drawing.Size(636, 121);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.rbCNPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCNPJ.Enabled = false;
            this.rbCNPJ.FlatAppearance.BorderSize = 0;
            this.rbCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbCNPJ.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCNPJ.Location = new System.Drawing.Point(212, 95);
            this.rbCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(70, 23);
            this.rbCNPJ.TabIndex = 2;
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
            this.rbCPF.Enabled = false;
            this.rbCPF.FlatAppearance.BorderSize = 0;
            this.rbCPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbCPF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.Location = new System.Drawing.Point(96, 95);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(61, 23);
            this.rbCPF.TabIndex = 2;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = false;
            this.rbCPF.Click += new System.EventHandler(this.rbCPF_Click);
            // 
            // mtbOwner
            // 
            this.mtbOwner.Enabled = false;
            this.mtbOwner.Font = new System.Drawing.Font("Verdana", 9F);
            this.mtbOwner.Location = new System.Drawing.Point(96, 68);
            this.mtbOwner.Mask = "000000000-00";
            this.mtbOwner.Name = "mtbOwner";
            this.mtbOwner.Size = new System.Drawing.Size(236, 26);
            this.mtbOwner.TabIndex = 11;
            this.mtbOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbOwner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDate_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clean search";
            // 
            // btCleanSearch
            // 
            this.btCleanSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btCleanSearch.BackgroundImage = global::_2015_29_04_TI_AED_Console.Properties.Resources.Clean;
            this.btCleanSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCleanSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCleanSearch.FlatAppearance.BorderSize = 0;
            this.btCleanSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCleanSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCleanSearch.ForeColor = System.Drawing.Color.DarkOrange;
            this.btCleanSearch.Location = new System.Drawing.Point(497, 20);
            this.btCleanSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btCleanSearch.Name = "btCleanSearch";
            this.btCleanSearch.Size = new System.Drawing.Size(97, 81);
            this.btCleanSearch.TabIndex = 9;
            this.btCleanSearch.UseVisualStyleBackColor = false;
            this.btCleanSearch.Click += new System.EventHandler(this.btCleanSearch_Click);
            this.btCleanSearch.MouseLeave += new System.EventHandler(this.btCleanSearch_MouseLeave);
            this.btCleanSearch.MouseHover += new System.EventHandler(this.btCleanSearch_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btSearch.BackgroundImage = global::_2015_29_04_TI_AED_Console.Properties.Resources.Search;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.DarkOrange;
            this.btSearch.Location = new System.Drawing.Point(359, 20);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(97, 81);
            this.btSearch.TabIndex = 4;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            this.btSearch.MouseLeave += new System.EventHandler(this.btSearch_MouseLeave);
            this.btSearch.MouseHover += new System.EventHandler(this.btSearch_MouseHover);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.Red;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btClose.Location = new System.Drawing.Point(947, 602);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(76, 26);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "EXIT";
            this.btClose.UseVisualStyleBackColor = false;
            // 
            // SearchStatusBar
            // 
            this.SearchStatusBar.BackColor = System.Drawing.Color.Chocolate;
            this.SearchStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchScreenStatus});
            this.SearchStatusBar.Location = new System.Drawing.Point(0, 632);
            this.SearchStatusBar.Name = "SearchStatusBar";
            this.SearchStatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.SearchStatusBar.Size = new System.Drawing.Size(1055, 25);
            this.SearchStatusBar.TabIndex = 9;
            this.SearchStatusBar.Text = "Status Bar";
            // 
            // SearchScreenStatus
            // 
            this.SearchScreenStatus.Name = "SearchScreenStatus";
            this.SearchScreenStatus.Size = new System.Drawing.Size(270, 20);
            this.SearchScreenStatus.Text = "There are no messages to be displayed.";
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(1055, 657);
            this.Controls.Add(this.SearchStatusBar);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.gbFindBy);
            this.Controls.Add(this.gbCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search - DRAP® WECS";
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            this.gbFindBy.ResumeLayout(false);
            this.gbFindBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.SearchStatusBar.ResumeLayout(false);
            this.SearchStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCompany;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.RadioButton rbEnergy;
        private System.Windows.Forms.GroupBox gbFindBy;
        private System.Windows.Forms.RadioButton rbOwner;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthAndYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousConsumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentConsumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.RadioButton rbBillTypeBoth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCleanSearch;
        private System.Windows.Forms.StatusStrip SearchStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel SearchScreenStatus;
        private System.Windows.Forms.MaskedTextBox mtbOwner;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbFindByBoth;
    }
}