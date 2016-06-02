using _2015_29_04_TI_AED_Console.Libs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_29_04_TI_AED_Console.Models
{
    /**
     * This class represent a bill
     * */
    abstract class Bill : IQuickSortComparable<Bill>
    {
        /**
         * Constants of the owner type
         * */
        public const string COMMERCIAL = "commercial";
        public const string RESIDENTIAL = "residential";

        /* Default property to compare */
        private const string DEFAULT_COMPARATOR = "Owner";
        /* Comparer object to sort an array of bills */
        private Comparer comparator = Comparer.Default;

        /* Owner */
        private string owner;
        /* Owner type of the bill */
        private string ownerType;
        /* Bill type */
        private string type;
        /* Bill date */
        private DateTime monthAndYear;
        /* Previous consumption */
        private int previousConsumption;
        /* Current consumption */
        private int currentConsumption;
        /* Consumption */
        private int consumption;
        /* Bill value */
        private double value;

        /**
         * Constructor and reusable method to initialize the class
         * */
        public Bill(string type, string owner, string monthAndYear, int previousConsumption, int currentConsumption)
        {
            this.Initialize(type, owner, monthAndYear, previousConsumption, currentConsumption);
        }

        private void Initialize(string type, string owner, string monthAndYear, int previousConsumption, int currentConsumption)
        {
            this.type = type;
            this.owner = owner;
            string[] date = monthAndYear.Split('/');
            this.monthAndYear = new DateTime(int.Parse(date[1]), int.Parse(date[0]), 1);
            this.previousConsumption = previousConsumption;
            this.currentConsumption = currentConsumption;
            this.consumption = this.currentConsumption - this.previousConsumption;
            this.ownerType = owner.Contains('/') ? Bill.COMMERCIAL : Bill.RESIDENTIAL;
            this.value = this.CalcValue();
        }

        /**
         * This method allows you to access the properties of the object as an array, returning the property value
         * */
        public Object this[string property]
        {
            get
            {
                try
                {
                    // Return the property value
                    return typeof(Bill).GetProperty(property).GetValue(this);
                }
                catch
                {
                    throw new Exception("Property not found: " + property);
                }
            }
        }

        /**
         * This method must calculate the bill value. This method must be implemented by the children classes
         * */
        protected abstract double CalcValue();

        /**
         * Getters
         * */
        public string Type
        {
            get { return type; }
        }

        public string Owner
        {
            get { return owner; }
        }

        public DateTime MonthAndYear
        {
            get { return monthAndYear; }
        }

        public int PreviousConsumption
        {
            get { return previousConsumption; }
        }

        public int CurrentConsumption
        {
            get { return currentConsumption; }
        }

        public int Consumption
        {
            get { return consumption; }
        }

        public string OwnerType
        {
            get { return ownerType; }
        }

        public double Value
        {
            get { return this.value; }
        }

        /**
         * Convert the bill object to string
         * */
        public override string ToString()
        {
            StringBuilder bill = new StringBuilder();
            bill.AppendLine("Type: " + this.Type);
            bill.AppendLine("Owner: " + this.Owner);
            bill.AppendLine("Owner type: " + this.OwnerType);
            bill.AppendLine("Date: " + this.MonthAndYear.ToString("MM/yyyy"));
            bill.AppendLine("Previous: " + this.PreviousConsumption + " | Current: " + this.CurrentConsumption + " | Consumption: " + this.Consumption);
            bill.AppendLine("Value: " + this.Value.ToString("C"));
            return bill.ToString();
        }

        /**
         * Method implemented to use the HeapSort class to sort this object. The property and ascending parameters are optionaly
         * */
        public int HeapCompareTo(Bill other, string property = "", bool ascending = true)
        {
            // Check the property to order is not provided. If not, the property receive a default value
            if (String.IsNullOrWhiteSpace(property))
                property = Bill.DEFAULT_COMPARATOR;

            // Check the direction to compare and return the result of the comparison
            if (ascending)
                return this.comparator.Compare(this[property], other[property]);
            else
                return this.comparator.Compare(other[property], this[property]);
        }

        public int QuickCompareTo(Bill other, string property = "", bool ascending = true)
        {
            // Check the property to order is not provided. If not, the property receive a default value
            if (String.IsNullOrWhiteSpace(property))
                property = Bill.DEFAULT_COMPARATOR;

            // Check the direction to compare and return the result of the comparison
            if (ascending)
                return this.comparator.Compare(this[property], other[property]);
            else
                return this.comparator.Compare(other[property], this[property]);
        }
    }
}
