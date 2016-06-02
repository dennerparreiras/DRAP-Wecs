using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_29_04_TI_AED_Console.Libs
{
    public class HeapSort<T> where T : IHeapSortComparable<T>
    {
        public static void Sort(T[] A)
        {
            BuildSort(A, "", true);
        }

        public static void Sort(T[] A, string property)
        {
            BuildSort(A, property, true);
        }

        public static void Sort(T[] A, string property, bool ascending)
        {
            BuildSort(A, property, ascending);
        }

        private static void BuildSort(T[] A, string property, bool ascending)
        {
            if (A.Length == 0)
                return;
            //build the initial heap
            for (int i = (A.Length - 1) / 2; i >= 0; i--)
                Adjust(A, i, A.Length - 1, property, ascending);

            //swap root node and the last heap node
            for (int i = A.Length - 1; i >= 1; i--)
            {
                T Temp = A[0];
                A[0] = A[i];
                A[i] = Temp;
                Adjust(A, 0, i - 1, property, ascending);
            }
        }

        private static void Adjust(T[] list, int i, int len, string property, bool ascending)
        {
            T Temp = list[i];
            int j = i * 2 + 1;

            while (j <= len)
            {
                //more children
                if (j < len){
                    if (list[j].HeapCompareTo(list[j + 1], property, ascending) < 0)
                        j = j + 1;
                }
                //compare roots and the older children
                if (Temp.HeapCompareTo(list[j], property, ascending) < 0)
                {
                    list[i] = list[j];
                    i = j;
                    j = 2 * i + 1;
                }
                else
                {
                    j = len + 1;
                }
            }
            list[i] = Temp;
        }
    }
}
