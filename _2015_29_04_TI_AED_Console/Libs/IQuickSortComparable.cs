using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_29_04_TI_AED_Console.Libs
{
    public interface IQuickSortComparable<T>
    {
        int QuickCompareTo(T other, string property = "", bool ascending = true);
    }
}
