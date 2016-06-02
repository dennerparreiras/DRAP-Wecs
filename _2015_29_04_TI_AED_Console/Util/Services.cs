using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using _2015_29_04_TI_AED_Console.Models;
using _2015_29_04_TI_AED_Console.Libs;

namespace _2015_29_04_TI_AED_Console.Util
{
    /**
     * Static class to provide services.
     * */
    static class Services
    {
        /**
         * Import the bills from a txt file and return a Hashtable element
         * */
        public static Hashtable Import(string fileName)
        {
            // Check if the file exist
            if (!File.Exists(@fileName))
                throw new FileNotFoundException("File not found: " + fileName);

            Hashtable bills = new Hashtable();
            StreamReader arq = new StreamReader(@fileName);
            // Error log to show invalid bills
            StreamWriter errorLog = new StreamWriter(@"error.txt");

            string line = arq.ReadLine();
            while (line != null)
            {
                try
                {
                    if (line[0] != '#')
                    {
                        string[] billData = line.Split(';');
                        Bill bill = BillFactory.Factory(billData[0], billData[1], billData[2], int.Parse(billData[3]), int.Parse(billData[4]));

                        // Check if the hashtable already has the owner key of the bill and add the bill to the hashtable object
                        if (bills.ContainsKey(billData[1]))
                        {
                            DoubleLinkedList<Bill> billList = (DoubleLinkedList<Bill>)bills[billData[1]];
                            if (billList.Find(x => x.Owner == bill.Owner && x.MonthAndYear == bill.MonthAndYear).Length == 0)
                                billList.Add(bill);
                        }
                        else
                        {
                            DoubleLinkedList<Bill> billList = new DoubleLinkedList<Bill>();
                            billList.Add(bill);
                            bills.Add(billData[1], billList);
                        }
                    }
                    line = arq.ReadLine();
                }
                catch (Exception e)
                {
                    // Write the error
                    errorLog.WriteLine("[LOADING] Error on load of the following bill: " + line + " Exception: " + e.Message);
                }
            }
            errorLog.Close();
            arq.Close();

            return bills;
        }

        /**
         * Fild bills by a predicate
         * */
        public static DoubleLinkedList<Bill> FindBills(Hashtable bills, Predicate<Bill> match)
        {
            DoubleLinkedList<Bill> foundBills = new DoubleLinkedList<Bill>();
            // Add a range of found bills by key of the hashtable
            foreach (Object billListObj in bills.Values)
                foundBills.AddRange(((DoubleLinkedList<Bill>)billListObj).Find(match));
            return foundBills;
        }

        /**
         * Find bills by owner and sort the bills by date. The type of the bill is optional.
         * */
        public static Bill[] FindBillsByOwner(Hashtable bills, string owner, string billType = "")
        {
            DoubleLinkedList<Bill> ownerBills = new DoubleLinkedList<Bill>();
            // Check if exists the owner key
            if (bills.ContainsKey(owner))
            {
                DoubleLinkedList<Bill> billList = (DoubleLinkedList<Bill>)bills[owner];
                // Check if was provided the billType. If yes, the list of bills is filtered
                if (String.IsNullOrWhiteSpace(billType))
                    ownerBills.AddRange(billList);
                else
                    ownerBills.AddRange(billList.Find(x => x.Type == billType));
            }
            // Convert the list to array and sort the bills by date
            Bill[] ownerBillsArray = ownerBills.ToArray();
            QuickSort<Bill>.ordenar(ownerBillsArray, "MonthAndYear");
            //HeapSort<Bill>.Sort(ownerBillsArray, "MonthAndYear");
            return ownerBillsArray;
        }

        /**
         * Find bills of one month orderly by owner. The type of the bill is optional.
         * */
        public static Bill[] FindBillsOrderlyByOwner(Hashtable bills, DateTime date, string billType = "")
        {
            // Creating the predicate to find bills
            Predicate<Bill> match;
            if (String.IsNullOrWhiteSpace(billType))
                match = x => x.MonthAndYear == date;
            else
                match = x => x.Type == billType && x.MonthAndYear == date;
            // Find bills and converting to array
            Bill[] foundedBills = Services.FindBills(bills, match).ToArray();
            // Sorting the bills
            QuickSort<Bill>.ordenar(foundedBills, "Owner");
            //HeapSort<Bill>.Sort(foundedBills, "Owner");
            return foundedBills;
        }

        public static Bill[] FindBillsByOwnerAndDate(Hashtable bills, string owner, DateTime date, string billType = "")
        {
            DoubleLinkedList<Bill> ownerBills = new DoubleLinkedList<Bill>();
            if (bills.ContainsKey(owner))
            {
                DoubleLinkedList<Bill> billList = (DoubleLinkedList<Bill>)bills[owner];
                Predicate<Bill> match;
                if (String.IsNullOrWhiteSpace(billType))
                    match = x => x.MonthAndYear == date;
                else
                    match = x => x.MonthAndYear == date && x.Type == billType;
                ownerBills.AddRange(billList.Find(match));
            }
            Bill[] ownerBillsArray = ownerBills.ToArray();
            QuickSort<Bill>.ordenar(ownerBillsArray, "Type");
            //HeapSort<Bill>.Sort(ownerBillsArray, "Type");
            return ownerBillsArray;
        }

        /**
         * Make a default company report from a date
         * */
        public static Report MakeReport(Hashtable bills, string billType, DateTime date)
        {
            // Using the generic report method
            return Services.MakeReport(bills, billType, x => x.Type == billType && x.MonthAndYear == date);
        }

        /**
         * Generic method to make custom reports. Must be provided the owner and the predicate to find bills
         * */
        public static Report MakeReport(Hashtable bills, string owner, Predicate<Bill> match)
        {
            int currentConsumption = 0;
            int previousConsumption = 0;
            double totalValue = 0;

            // Find bills
            DoubleLinkedList<Bill> foundBills = Services.FindBills(bills, match);
            // Calculating the total value and total consumption
            foreach (Bill bill in foundBills)
            {
                totalValue += bill.Value;
                currentConsumption += bill.CurrentConsumption;
                previousConsumption += bill.PreviousConsumption;
            }
            // Make a new report
            return new Report(owner, totalValue, currentConsumption, previousConsumption);
        }

        /**
         * Reusable method to build a predicate
         * */
        private static Predicate<Bill> BuildPredicate(string owner, DateTime date)
        {
            // Check if the owner is a company and build the predicate
            if (owner == BillFactory.ENERGY || owner == BillFactory.WATER)
                return (x => x.Type == owner && x.MonthAndYear == date);
            else
                return (x => x.Owner == owner && x.MonthAndYear == date);
        }

        /**
         * Method to build a bills comparison  of two dates from the owner
         * */
        public static Comparison BuildComparison(Hashtable bills, string owner, DateTime firstDate, DateTime secondDate)
        {
            // Building the predicates
            Predicate<Bill> firstMatch = BuildPredicate(owner, firstDate);
            Predicate<Bill> secondMatch = BuildPredicate(owner, secondDate);

            // Make the report from the first date
            Report firstReport = Services.MakeReport(bills, owner, firstMatch);
            // Make the report from the second date
            Report secondReport = Services.MakeReport(bills, owner, secondMatch);

            // Build the comparison of two dates
            return new Comparison(owner, firstDate, firstReport.Consumption, secondDate, secondReport.Consumption);
        }
    }
}
