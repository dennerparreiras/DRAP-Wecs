using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_29_04_TI_AED_Console
{
    public partial class ReportSelectScreen : Form
    {
        public ReportSelectScreen()
        {
            InitializeComponent();
        }

        private void UpdateStatusBar(string message)
        {
            ReportSelectScreenStatus.Text = message;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (MainScreen.IsValidDate(mtbDate.Text))
            {
                if (rbEnergyReport.Checked)
                {
                    CallReportScreen(Util.BillFactory.ENERGY);
                }
                else if (rbWaterReport.Checked)
                {
                    CallReportScreen(Util.BillFactory.WATER);
                }
            }
            else
            {
                string m = "The date field is wrong! Insert a valid date!";
                MessageBox.Show(m);
                UpdateStatusBar(MainScreen.PrintMessage(m));
            }
        }

        private void rbEnergyReport_Click(object sender, EventArgs e)
        {
            rbWaterReport.Checked = false;
        }

        private void rbWaterReport_Click(object sender, EventArgs e)
        {
            rbEnergyReport.Checked = false;
        }

        private void rbCompany_Click(object sender, EventArgs e)
        {
            if (!rbOwner.Checked)
            {
                gbOwner.Enabled = false;
                gbCompany.Enabled = true;
            }
        }

        private void rbOwner_Click(object sender, EventArgs e)
        {
            if (!rbCompany.Checked)
            {
                gbOwner.Enabled = true;
                gbCompany.Enabled = false;
            }
        }

        private void rbEnergyCompare_Click(object sender, EventArgs e)
        {
            if (!rbOwner.Checked)
                rbWaterCompare.Checked = false;
        }

        private void rbWaterCompare_Click(object sender, EventArgs e)
        {
            if (!rbOwner.Checked)
                rbEnergyCompare.Checked = false;
        }
        private void CallReportScreen(string billType)
        {
            DateTime s = DateTime.Now;
            Models.Report b = Util.Services.MakeReport(MainScreen.bills, billType, Convert.ToDateTime(mtbDate.Text));
            DateTime e = DateTime.Now;
            this.UpdateStatusBar(MainScreen.PrintMessage(s, e, "Report made!"));
            new ConsuptionReportScreen(b.Owner, b.Value, b.Consumption, b.CurrentConsumption, b.PreviousConsumption).ShowDialog();
        }
        private void CallComparationScreen(string TypeOrOwner)
        {
            DateTime s = DateTime.Now;
            Models.Comparison c = Util.Services.BuildComparison(MainScreen.bills, TypeOrOwner, Convert.ToDateTime(mtbDateEnd.Text), Convert.ToDateTime(mtbDateStart.Text));
            DateTime e = DateTime.Now;
            this.UpdateStatusBar(MainScreen.PrintMessage(s, e, "Report made!"));
            new ComparisonScreen(c.Owner, c.DateA, c.ConsumptionA, c.DateB, c.ConsumptionB, c.AbsoluteChange, c.PercentageChange).ShowDialog();
        }
        private void btCompareBills_Click(object sender, EventArgs e)
        {
            if (MainScreen.IsValidDate(mtbDateStart.Text) && MainScreen.IsValidDate(mtbDateEnd.Text))
            {
                if ((rbEnergyCompare.Checked || rbWaterCompare.Checked) && (rbCompany.Checked) || (rbOwner.Checked && mtbOwner.Text != ""))
                {
                    if (rbEnergyCompare.Checked && (rbCompany.Checked))
                    {
                        CallComparationScreen(Util.BillFactory.ENERGY);
                    }
                    if (rbWaterCompare.Checked && (rbCompany.Checked))
                    {
                        CallComparationScreen(Util.BillFactory.WATER);
                    }
                    if (rbOwner.Checked && mtbOwner.Text != "")
                    {
                        CallComparationScreen(mtbOwner.Text);
                    }
                }
            }
            else
            {
                string m = "There are empty or wrong fields.";
                MessageBox.Show(m);
                UpdateStatusBar(MainScreen.PrintMessage(m));
            }
        }

        private void btCompareBills_MouseHover(object sender, EventArgs e)
        {
            btCompareBills.BackgroundImage = Properties.Resources.ComparationBlack;
        }

        private void btCompareBills_MouseLeave(object sender, EventArgs e)
        {
            btCompareBills.BackgroundImage = Properties.Resources.Comparation;
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

        private void mtbOwner_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    btCompareBills_Click(sender, e);
                }
            }
            catch
            {
                UpdateStatusBar(MainScreen.PrintMessage("Error: trying to press Enter Key."));
            }
        }
    }
}
