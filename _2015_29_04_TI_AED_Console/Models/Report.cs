using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_29_04_TI_AED_Console.Models
{
    /**
     * This class represent a report of consumption
     * */
    class Report
    {
        /* Owner of the report */
        private string owner;
        /* Total value */
        private double value;
        /* Consumption */
        private int consumption;
        /* Current consumption */
        private int currentConsumption;
        /* Previous consumption */
        private int previousConsumption;

        /**
         * Constructor and reusable method to initialize the class
         * */
        public Report(string owner, double value, int currentConsumption, int previousConsumption)
        {
            this.Initialize(owner, value, currentConsumption, previousConsumption);
        }

        private void Initialize(string owner, double value, int currentConsumption, int previousConsumption)
        {
            this.owner = owner;
            this.value = value;
            this.currentConsumption = currentConsumption;
            this.previousConsumption = previousConsumption;
            this.consumption = this.currentConsumption - this.previousConsumption;
        }

        /**
         * Getters
         * */
        public string Owner
        {
            get { return this.owner; }
        }

        public double Value
        {
            get { return this.value; }
        }

        public int Consumption
        {
            get { return this.consumption; }
        }

        public int CurrentConsumption
        {
            get { return this.currentConsumption; }
        }

        public int PreviousConsumption
        {
            get { return this.previousConsumption; }
        }

        /**
         * Convert the report object to string
         * */
        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine("Owner: " + this.Owner);
            report.AppendLine("Value: " + this.Value.ToString("C"));
            report.AppendLine("Consumption: " + this.Consumption);
            report.AppendLine("Current consumption: " + this.CurrentConsumption);
            report.AppendLine("Previous consumption: " + this.PreviousConsumption);
            return report.ToString();
        }
    }
}
