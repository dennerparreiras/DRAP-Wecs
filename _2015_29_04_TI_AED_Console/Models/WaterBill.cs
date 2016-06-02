using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2015_29_04_TI_AED_Console.Util;

namespace _2015_29_04_TI_AED_Console.Models
{
    /**
     * This class represent a water bill
     * */
    class WaterBill : Bill
    {
        /* COFINS tax */
        const double COFINS = 1.03;

        /* Value range */
        const int R_RANGE_A = 10;
        const int R_RANGE_B = 15;
        const int R_RANGE_C = 20;
        const int R_RANGE_D = 40;
        const int C_RANGE_A = 10;
        const int C_RANGE_B = 40;
        const int C_RANGE_C = 100;

        /* Water constants */
        const double RW_FIXED = 10.08;
        const double RW_RANGE_A = 2.241;
        const double RW_RANGE_B = 5.447;
        const double RW_RANGE_C = 5.461;
        const double RW_RANGE_D = 5.487;
        const double RW_RANGE_E = 10.066;
        const double CW_FIXED = 25.79;
        const double CW_RANGE_A = 4.299;
        const double CW_RANGE_B = 8.221;
        const double CW_RANGE_C = 8.288;
        const double CW_RANGE_D = 8.329;

        /* Sewer constants */
        const double RS_FIXED = 5.05;
        const double RS_RANGE_A = 1.122;
        const double RS_RANGE_B = 2.724;
        const double RS_RANGE_C = 2.731;
        const double RS_RANGE_D = 2.744;
        const double RS_RANGE_E = 5.035;
        const double CS_FIXED = 12.90;
        const double CS_RANGE_A = 2.149;
        const double CS_RANGE_B = 4.111;
        const double CS_RANGE_C = 4.144;
        const double CS_RANGE_D = 4.165;

        /**
         * Constructor
         * */
        public WaterBill(string owner, string monthAndYear, int previousConsumption, int currentConsumption)
            : base(BillFactory.WATER, owner, monthAndYear, previousConsumption, currentConsumption)
        { }

        /**
        * Method to calculate the bill value
        * */
        protected override double CalcValue()
        {
            return ((this.OwnerType == Bill.COMMERCIAL) ? this.commercialValue() : this.residentialValue()) * COFINS;
        }

        /**
         * Method to calculate the commercial bill value
         * */
        private double commercialValue()
        {
            if (this.Consumption <= 6)
                return CW_FIXED + CS_FIXED;

            double total = this.CalcValueRange(((this.Consumption > C_RANGE_A) ? C_RANGE_A : this.Consumption), CW_RANGE_A, CS_RANGE_A);
            total += this.CalcValueRange(((this.Consumption > C_RANGE_B) ? (C_RANGE_B - C_RANGE_A) : (this.Consumption - C_RANGE_A)), CW_RANGE_B, CS_RANGE_B);
            total += this.CalcValueRange(((this.Consumption > C_RANGE_C) ? (C_RANGE_C - C_RANGE_B) : (this.Consumption - C_RANGE_B)), CW_RANGE_C, CS_RANGE_C);
            total += this.CalcValueRange((this.Consumption - C_RANGE_C), CW_RANGE_D, CS_RANGE_D);
            return total;
        }

        /**
         * Method to calculate the residential bill value
         * */
        private double residentialValue()
        {
            if (this.Consumption <= 6)
                return RW_FIXED + RS_FIXED;

            double total = this.CalcValueRange(((this.Consumption > R_RANGE_A) ? R_RANGE_A : this.Consumption), RW_RANGE_A, RS_RANGE_A);
            total += this.CalcValueRange(((this.Consumption > R_RANGE_B) ? (R_RANGE_B - R_RANGE_A) : (this.Consumption - R_RANGE_A)), RW_RANGE_B, RS_RANGE_B);
            total += this.CalcValueRange(((this.Consumption > R_RANGE_C) ? (R_RANGE_C - R_RANGE_B) : (this.Consumption - R_RANGE_B)), RW_RANGE_C, RS_RANGE_C);
            total += this.CalcValueRange(((this.Consumption > R_RANGE_D) ? (R_RANGE_D - R_RANGE_C) : (this.Consumption - R_RANGE_C)), RW_RANGE_D, RS_RANGE_D);
            total += this.CalcValueRange((this.Consumption - R_RANGE_D), RW_RANGE_E, RS_RANGE_E);
            return total;
        }

        /**
         * Method to calculate a value range
         * */
        private double CalcValueRange(int metrics, double water, double sewer)
        {
            if (metrics <= 0)
                return 0;
            return water * metrics + sewer * metrics;
        }
    }
}
