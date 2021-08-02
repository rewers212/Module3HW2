using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public interface IGroupContactsService<T>
    {
        public CultureInfo CultureInfo { set; }
        public GroupType GroupType { set; }
        public SortedList<string, List<Contact>> GroupedContactList { get; }
        public void GroupAlphabetically(List<T> values);
        public void GroupAlphabetically(List<T> values, CultureInfo cultureInfo, GroupType groupingType);
    }
}
