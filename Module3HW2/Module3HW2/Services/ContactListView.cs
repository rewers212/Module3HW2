using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class ContactListView<Tkey, TValue> : IContactListView<Tkey, TValue>
    {
        public void ShowContactList(SortedList<Tkey, List<TValue>> groupСontacts)
        {
            var list = groupСontacts as SortedList<string, List<Contact>>;

            Console.WriteLine();

            foreach (var item in list)
            {
                if (item.Value.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2.FullName} {item2.PhoneNumber}");
                }
            }
        }
    }
}
