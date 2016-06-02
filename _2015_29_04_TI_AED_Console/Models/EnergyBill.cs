using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2015_29_04_TI_AED_Console.Util;

namespace _2015_29_04_TI_AED_Console.Models
{
    /**
     * This class represent an energy bill
     * */
    class EnergyBill : Bill
    {
        /**
         * Constants of taxes to calculate the bill value
         * */
        const double PRICE_RATE_C = 0.41;
        const double PRICE_RATE_R = 0.46;
        const double COMMERCIAL_TAX = 1.2195;
        const double RESIDENTIAL_TAX = 1.4285;
        const double PUBLIC_ILLUMINATION = 13.25;

        /**
         * Constructor
         * */
        public EnergyBill(string owner, string monthAndYear, int previousConsumption, int currentConsumption)
            : base(BillFactory.ENERGY, owner, monthAndYear, previousConsumption, currentConsumption)
        { }

        /**
         * Method to calculate the bill value
         * */
        protected override double CalcValue()
        {
            return ((this.OwnerType == Bill.COMMERCIAL) ? this.commercialValue() : this.residentialValue()) + EnergyBill.PUBLIC_ILLUMINATION;
        }

        /**
         * Method to calculate the commercial bill value
         * */
        private double commercialValue()
        {
            return ((this.CurrentConsumption - this.PreviousConsumption) * EnergyBill.PRICE_RATE_C) * EnergyBill.COMMERCIAL_TAX;
        }

        /**
         * Method to calculate the residential bill value
         * */
        private double residentialValue()
        {
            if (this.Consumption > 90)
                return ((this.CurrentConsumption - this.PreviousConsumption) * EnergyBill.PRICE_RATE_R) * EnergyBill.RESIDENTIAL_TAX;
            else
                return ((this.CurrentConsumption - this.PreviousConsumption) * EnergyBill.PRICE_RATE_R);
        }
    }
}
