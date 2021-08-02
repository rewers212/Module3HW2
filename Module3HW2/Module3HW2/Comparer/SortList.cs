using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class SortList : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == "#" || y == "#" || x == "0-9" || y == "0-9")
            {
                return y.CompareTo(x);
            }
            else
            {
                return x.CompareTo(y);
            }
        }
    }
}