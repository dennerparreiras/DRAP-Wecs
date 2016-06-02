using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_29_04_TI_AED_Console.Models
{
    /**
     * This class represent a comparison from the consumption of two dates
     * */
    class Comparison
    {
        /* Comparison owner */
        private string owner;
        /* First consmption to compare */
        private Consumption consumptionA;
        /* Second consmption to compare */
        private Consumption consumptionB;
        /* Absolute change from the period */
        private int absoluteChange;
        /* Percentage change from the period */
        private double percentageChange;

        /* Consumption class */
        private class Consumption
        {
            public DateTime date;
            public int value;

            public Consumption(DateTime date, int value)
            {
                this.date = date;
                this.value = value;
            }
        }

        /**
         * Constructor and reusable method to initialize the class
         * */
        public Comparison(string owner, DateTime dateA, int consumptionA, DateTime dateB, int consumptionB)
        {
            this.Initialize(owner, dateA, consumptionA, dateB, consumptionB);
        }

        private void Initialize(string owner, DateTime dateA, int consumptionA, DateTime dateB, int consumptionB)
        {
            this.owner = owner;
            this.consumptionA = new Consumption(dateA, consumptionA);
            this.consumptionB = new Consumption(dateB, consumptionB);
            this.absoluteChange = this.consumptionA.value - this.consumptionB.value;
            this.percentageChange = (((double)this.consumptionA.value / (double)this.consumptionB.value) - 1) * 100;
        }

        /**
         * Getters
         * */
        public string Owner
        {
            get { return this.owner; }
        }

        public string DateA
        {
            get { return this.consumptionA.date.ToString("MM/yyyy"); }
        }

        public double ConsumptionA
        {
            get { return this.consumptionA.value; }
        }

        public string DateB
        {
            get { return this.consumptionB.date.ToString("MM/yyyy"); }
        }

        public double ConsumptionB
        {
            get { return this.consumptionB.value; }
        }

        public double AbsoluteChange
        {
            get { return this.absoluteChange; }
        }

        public double PercentageChange
        {
            get { return Math.Round(this.percentageChange, 2); }
        }

        /**
         * Convert the comparison object to string
         * */
        public override string ToString()
        {
            StringBuilder compare = new StringBuilder();
            compare.AppendLine("Owner: " + this.Owner);
            compare.AppendLine("Consumption in " + this.DateA + ": " + this.ConsumptionA);
            compare.AppendLine("Consumption in " + this.DateB + ": " + this.ConsumptionB);
            compare.AppendLine("Absolute change: " + this.AbsoluteChange);
            compare.AppendLine("Percentage change (%): " + this.PercentageChange);
            return compare.ToString();
        }
    }
}
