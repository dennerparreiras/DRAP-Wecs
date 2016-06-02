using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using _2015_29_04_TI_AED_Console.Util;
using _2015_29_04_TI_AED_Console.Libs;
using _2015_29_04_TI_AED_Console.Models;
using System.Threading;

namespace _2015_29_04_TI_AED_Console
{
    public partial class MainScreen : Form
    {
        public static Hashtable bills;

        public MainScreen()
        {
            InitializeComponent();
            bills = new Hashtable();

            //Auto import from pattern file
            // UpdateStatusBar(DirectImport());
        }

        // FormatDate and PrintMessage are methods to change the date format and returns a string to be used to update the status bar.
        public static string FormatDate(DateTime a)
        {
            return "[" + a.Month + "/" + a.Day + "/" + a.Year + " - " + a.Hour + ":" + a.Minute + ":" + a.Second + "] - ";
        }

        public static string PrintMessage(DateTime start, DateTime end, string text)
        {
            TimeSpan dt = (end.Subtract(start));
            return FormatDate(end) + text + "             [ Duration: " + dt.Hours + ":" + dt.Minutes + ":" + dt.Seconds + ":" + dt.Milliseconds + " ]             Total (milliseconds): " + dt.TotalMilliseconds;
        }
        public static string PrintMessage(string text)
        {
            return FormatDate(DateTime.Now) + text; ;
        }

        // Verify if a string of date is valid
        public static bool IsValidDate(string date)
        {
            try
            {
                string[] ValidateDate = date.Split('/');
                int m = int.Parse(ValidateDate[0]), y = int.Parse(ValidateDate[1]);
                return !((m < 1 || m > 12) || (y < 1000));
            }
            catch
            {
                return false;
            }

        }

        public static string DirectImport()
        {
            try
            {
                return ReceiveImportPath("contas.txt");
            }
            catch
            {
                return PrintMessage("Failed: Import data from file!");
            }
        }

        public static string GetPathOpenedFile()
        {
            OpenFileDialog SelectedFile = new OpenFileDialog();
            SelectedFile.ShowDialog();
            return SelectedFile.FileName;
        }

        public static string ReceiveImportPath(string path)
        {
            DateTime d = DateTime.Now;
            bills = Services.Import(path);
            DateTime n = DateTime.Now;
            return PrintMessage(d, n, "Sucessfully imported data.");

        }

        public static string ImportByFile()
        {
            try
            {
                return ReceiveImportPath(GetPathOpenedFile());
            }
            catch
            {
                return PrintMessage("Failed: Import data from file!");
            }
        }

        private void UpdateStatusBar(string message)
        {
            MainScreenStatus.Text = message;
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            UpdateStatusBar(DirectImport());
        }

        private void tsbImportFrom_Click(object sender, EventArgs e)
        {
            UpdateStatusBar(ImportByFile());
        }

        private void tsbSearchScreen_Click(object sender, EventArgs e)
        {
            if (bills.Count > 0)
                new SearchScreen().ShowDialog();
            else
            {
                MessageBox.Show("You must import bills to search.");
                UpdateStatusBar(PrintMessage("You must import bills to search."));
            }
        }

        public void RefreshTips(string txt)
        {
            Tips.Visible = true;
            Tips.Text = txt;
        }
        public void RefreshTips()
        {
            Tips.Visible = false;
        }

        private void tsbImport_MouseHover(object sender, EventArgs e)
        {
            tsbImport.Image = Properties.Resources.DirectImportWhite;
            RefreshTips("It imports all data from the pattern file.");
        }

        private void tsbImport_MouseLeave(object sender, EventArgs e)
        {
            tsbImport.Image = Properties.Resources.DirectImport;
            RefreshTips();
        }

        private void tsbImportFrom_MouseHover(object sender, EventArgs e)
        {
            tsbImportFrom.Image = Properties.Resources.ImportByFileWhite;
            RefreshTips("It imports all data from the selected file.");
        }

        private void tsbImportFrom_MouseLeave(object sender, EventArgs e)
        {
            tsbImportFrom.Image = Properties.Resources.ImportByFile;
            RefreshTips();
        }

        private void tsbSearchScreen_MouseHover(object sender, EventArgs e)
        {
            tsbSearchScreen.Image = Properties.Resources.SearchWhite;
            RefreshTips("It opens the search screen. There you may find the data you're searching.");
        }

        private void tsbSearchScreen_MouseLeave(object sender, EventArgs e)
        {
            tsbSearchScreen.Image = Properties.Resources.Search;
            RefreshTips();
        }

        private void tsbReport_MouseHover(object sender, EventArgs e)
        {
            tsbReport.Image = Properties.Resources.RelatoryWhite;
            RefreshTips("See the reports available in the system.");
        }

        private void tsbReport_MouseLeave(object sender, EventArgs e)
        {
            tsbReport.Image = Properties.Resources.Relatory;
            RefreshTips();
        }

        private void tsbAboutUs_MouseHover(object sender, EventArgs e)
        {
            tsbAboutUs.Image = Properties.Resources.AboutUsWhite;
            RefreshTips("It shows info about our AED developer team.");
        }

        private void tsbAboutUs_MouseLeave(object sender, EventArgs e)
        {
            tsbAboutUs.Image = Properties.Resources.AboutUs;
            RefreshTips();
        }

        private void tsbAboutUs_Click(object sender, EventArgs e)
        {
            new AboutUsScreen().ShowDialog();
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            if (bills.Count > 0)
                new ReportSelectScreen().ShowDialog();
            else
            {
                MessageBox.Show("You must import bills to generate a report.");
                UpdateStatusBar(PrintMessage("You must import bills to generate a report."));
            }
        }
    }
}
