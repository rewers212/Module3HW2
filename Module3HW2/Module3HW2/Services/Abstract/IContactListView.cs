using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public interface IContactListView<TKey, TValue>
    {
        public void ShowContactList(SortedList<TKey, List<TValue>> groupСontacts);
    }
}
