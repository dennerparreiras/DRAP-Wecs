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
    public partial class ConsuptionReportScreen : Form
    {
        public ConsuptionReportScreen(string Owner, double Value, int Consuption, int CurrentCons, int PreviousCons)
        {
            InitializeComponent();

            if (Owner.ToUpper() == "ENERGY")
            {
                mtbConsuption.Text = Consuption.ToString() + " kW/h";
                mtbCurrentConsuption.Text = CurrentCons.ToString() + " kW/h";
                mtbPreviousConsuption.Text = PreviousCons.ToString() + " kW/h";
            }
            else if (Owner.ToUpper() == "WATER")
            {
                mtbConsuption.Text = Consuption.ToString() + " m³";
                mtbCurrentConsuption.Text = CurrentCons.ToString() + " m³";
                mtbPreviousConsuption.Text = PreviousCons.ToString() + " m³";
            }
            else
            {
                mtbConsuption.Text = Consuption.ToString();
                mtbCurrentConsuption.Text = CurrentCons.ToString();
                mtbPreviousConsuption.Text = PreviousCons.ToString();
            }

            mtbOwner.Text = Owner.ToUpper();
            mtbValue.Text = Value.ToString("C");
        }
    }
}
