using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public interface INewList<Tkey, TValue>
    {
        public void AddContact(TValue contact);
        public void RemoveContact(TValue contact);
        public void ShowContactList();
    }
}
