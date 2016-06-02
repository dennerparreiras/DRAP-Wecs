using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2015_29_04_TI_AED_Console.Models;

namespace _2015_29_04_TI_AED_Console.Util
{
    /**
     * Factory Method pattern
     * This is a factory class. Implemented to factory bills.
     * */
    static class BillFactory
    {
        public const string ENERGY = "energy";
        public const string WATER = "water";

        const string ENERGY_BR = "luz";
        const string WATER_BR = "agua";

        /**
         * Return a factory bill
         * */
        public static Bill Factory(string billType, string owner, string monthAndYear, int previous, int current)
        {
            switch (billType)
            {
                case BillFactory.ENERGY_BR:
                    return new EnergyBill(owner, monthAndYear, previous, current);
                case BillFactory.WATER_BR:
                    return new WaterBill(owner, monthAndYear, previous, current);
                default:
                    throw new NotImplementedException("Bill type invalid: " + billType);
            }
        }
    }
}
