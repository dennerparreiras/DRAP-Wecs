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
    public partial class ComparisonScreen : Form
    {
        public ComparisonScreen(string owner, string firstDate, double firstConsumption, string secondDate, double secondConsumption, double absoluteChange, double percentualChange)
        {
            InitializeComponent();

            mtbOwner.Text = owner.ToUpper();

            if (owner.ToUpper() == "ENERGY")
            {
                mtbConsuption1.Text = firstConsumption.ToString() + " kW/h";
                mtbConsuption2.Text = secondConsumption.ToString() + " kW/h";
                mtbAbsoluteChange.Text = absoluteChange.ToString() + " kW/h";
            }
            else if (owner.ToUpper() == "WATER")
            {
                mtbConsuption1.Text = firstConsumption.ToString() + " m³";
                mtbConsuption2.Text = secondConsumption.ToString() + " m³";
                mtbAbsoluteChange.Text = absoluteChange.ToString() + " m³";
            }
            else
            {
                mtbConsuption1.Text = firstConsumption.ToString();
                mtbConsuption2.Text = secondConsumption.ToString();
                mtbAbsoluteChange.Text = absoluteChange.ToString();
            }

            mtbDate1.Text = firstDate.ToString();
            mtbDate2.Text = secondDate.ToString();
            
            if (!Double.IsNaN(percentualChange))
                mtbPercentualChange.Text = percentualChange.ToString();
            else
                mtbPercentualChange.Text = "" + 0;
        }
    }
}
