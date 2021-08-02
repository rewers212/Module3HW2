using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class NewList<TKey, TValue> : INewList<TKey, TValue>
    {
        private IGroupContactsService<TValue> _groupContactsService;
        private List<TValue> _contacts;
        private SortedList<TKey, List<TValue>> _groupContact;
        private IContactListView<TKey, TValue> _contactListView;

        public NewList(
            IGroupContactsService<TValue> groupContactsService,
            IContactListView<TKey, TValue> contactListView)
        {
            _contacts = new List<TValue>();
            _groupContactsService = groupContactsService;
            _groupContact = new SortedList<TKey, List<TValue>>();
            _contactListView = contactListView;
        }

        public void AddContact(TValue contact)
        {
            _contacts.Add(contact);
        }

        public void RemoveContact(TValue contact)
        {
            _contacts.Remove(contact);
        }

        public void ShowContactList()
        {
            _groupContactsService.GroupAlphabetically(_contacts);
            _groupContact = _groupContactsService.GroupedContactList as SortedList<TKey, List<TValue>>;
            _contactListView.ShowContactList(_groupContact);
        }
    }
}
