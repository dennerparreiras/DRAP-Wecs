using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2015_29_04_TI_AED_Console.Libs;
using _2015_29_04_TI_AED_Console.Util;
using _2015_29_04_TI_AED_Console.Models;

namespace _2015_29_04_TI_AED_Console
{
    public partial class SearchScreen : Form
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void UpdateStatusBar(string message)
        {
            SearchScreenStatus.Text = message;
        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            mtbDate.Enabled = true;
            mtbOwner.Enabled = false;
            rbCPF.Enabled = false;
            rbCNPJ.Enabled = false;
        }

        private void rbOwner_CheckedChanged(object sender, EventArgs e)
        {
            mtbDate.Enabled = false;
            mtbOwner.Enabled = true;
            rbCPF.Enabled = true;
            rbCNPJ.Enabled = true;
        }

        private void rbFindByBoth_CheckedChanged(object sender, EventArgs e)
        {
            mtbDate.Enabled = true;
            mtbOwner.Enabled = true;
            rbCPF.Enabled = true;
            rbCNPJ.Enabled = true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string error;

            if ((rbDate.Checked || rbFindByBoth.Checked) && (!MainScreen.IsValidDate(mtbDate.Text)))
            {
                error = "The date field is wrong! Insert a valid date!";
                MessageBox.Show(error);
                UpdateStatusBar(MainScreen.PrintMessage(error));
            }
            else
            {
                error = "There are empty fields.";
                try
                {
                    if ((rbDate.Checked || rbOwner.Checked || rbFindByBoth.Checked) && (rbEnergy.Checked || rbWater.Checked || rbBillTypeBoth.Checked))
                    {
                        if (rbFindByBoth.Checked)
                            this.SearchByDateAndOwner();
                        else if (rbDate.Checked)
                            this.SearchByDate();
                        else if (rbOwner.Checked)
                            this.SearchByOwner();
                    }
                    else
                    {
                        MessageBox.Show(error);
                        UpdateStatusBar(MainScreen.PrintMessage(error));
                    }
                }
                catch
                {
                    MessageBox.Show(error);
                    UpdateStatusBar(MainScreen.PrintMessage(error));
                }
            }
        }

        private string GetBillType()
        {
            string billType = "";
            if (!rbBillTypeBoth.Checked)
                billType = rbEnergy.Checked ? BillFactory.ENERGY : BillFactory.WATER;
            return billType;
        }

        private void SearchByDateAndOwner()
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(mtbOwner.Text))
                {
                    string billType = this.GetBillType();
                    string[] date = mtbDate.Text.Split('/');

                    DateTime dateTime = new DateTime(int.Parse(date[1]), int.Parse(date[0]), 1);
                    DateTime s = DateTime.Now;
                    Bill[] foundBills = Services.FindBillsByOwnerAndDate(MainScreen.bills, mtbOwner.Text, Convert.ToDateTime(mtbDate.Text), billType);
                    DateTime e = DateTime.Now;

                    UpdateStatusBar(MainScreen.PrintMessage(s, e, "Search done!"));

                    this.PopulateGrid(foundBills);
                }
                else
                {
                    string s = "There are empty fields.";
                    MessageBox.Show(s);
                    UpdateStatusBar(MainScreen.PrintMessage(s));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SearchByDate()
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(mtbDate.Text))
                {
                    string billType = this.GetBillType();
                    string[] date = mtbDate.Text.Split('/');

                    DateTime dateTime = new DateTime(int.Parse(date[1]), int.Parse(date[0]), 1);
                    DateTime s = DateTime.Now;
                    Bill[] foundBills = Services.FindBillsOrderlyByOwner(MainScreen.bills, dateTime, billType);
                    DateTime e = DateTime.Now;

                    UpdateStatusBar(MainScreen.PrintMessage(s, e, "Search done!"));

                    this.PopulateGrid(foundBills);
                }
                else
                {
                    string s = "There are empty fields.";
                    MessageBox.Show(s);
                    UpdateStatusBar(MainScreen.PrintMessage(s));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SearchByOwner()
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(mtbOwner.Text))
                {
                    string billType = this.GetBillType();
                    string owner = mtbOwner.Text;

                    DateTime s = DateTime.Now;
                    Bill[] foundBills = Services.FindBillsByOwner(MainScreen.bills, owner, billType);
                    DateTime e = DateTime.Now;

                    UpdateStatusBar(MainScreen.PrintMessage(s, e, "Search done!"));


                    this.PopulateGrid(foundBills);
                }
                else
                {
                    string s = "There are empty fields.";
                    MessageBox.Show(s);
                    UpdateStatusBar(MainScreen.PrintMessage(s));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void PopulateGrid(Bill[] foundBills)
        {
            this.ClearDgvSearch();
            foreach (Bill bill in foundBills)
                dgvBills.Rows.Add(this.FactoryRow(bill));
        }

        private DataGridViewRow FactoryRow(Bill bill)
        {
            DataGridViewRow row = (DataGridViewRow)dgvBills.Rows[0].Clone();
            row.Cells[0].Value = bill.Owner;
            row.Cells[1].Value = bill.OwnerType;
            row.Cells[2].Value = bill.MonthAndYear.ToString("MM/yyyy");
            row.Cells[3].Value = bill.Consumption;
            row.Cells[4].Value = bill.PreviousConsumption;
            row.Cells[5].Value = bill.CurrentConsumption;
            row.Cells[6].Value = bill.Value.ToString("C");
            return row;
        }

        private void btCleanSearch_Click(object sender, EventArgs e)
        {
            this.ClearDgvSearch();
        }

        private void ClearDgvSearch()
        {
            dgvBills.Rows.Clear();
        }

        private void btSearch_MouseHover(object sender, EventArgs e)
        {
            btSearch.BackgroundImage = Properties.Resources.SearchWhite;
        }

        private void btSearch_MouseLeave(object sender, EventArgs e)
        {
            btSearch.BackgroundImage = Properties.Resources.Search;
        }

        private void btCleanSearch_MouseHover(object sender, EventArgs e)
        {
            btCleanSearch.BackgroundImage = Properties.Resources.CleanWhite;
        }

        private void btCleanSearch_MouseLeave(object sender, EventArgs e)
        {
            btCleanSearch.BackgroundImage = Properties.Resources.Clean;
        }

        private void rbCPF_Click(object sender, EventArgs e)
        {
            mtbOwner.Mask = "000000000-00";
            rbCPF.Checked = true;
            rbCNPJ.Checked = false;
        }

        private void rbCNPJ_Click(object sender, EventArgs e)
        {
            mtbOwner.Mask = "00000000/0000-00";
            rbCPF.Checked = false;
            rbCNPJ.Checked = true;
        }

        private void mtbDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    btSearch_Click(sender, e);
                }
            }
            catch
            {
                UpdateStatusBar(MainScreen.PrintMessage("Error: trying to press Enter Key."));
            }
        }
    }
}
