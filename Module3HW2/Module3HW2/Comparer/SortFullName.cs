using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class SortFullName : IComparer<Contact>
    {
        public int Compare(Contact x, Contact y)
        {
            return x.FullName.CompareTo(y.FullName);
        }
    }
}
