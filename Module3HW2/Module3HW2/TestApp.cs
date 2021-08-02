using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class TestApp
    {
        private readonly INewList<string, Contact> _contactList;

        public TestApp(
            INewList<string, Contact> contactList)
        {
            _contactList = contactList;
        }

        public void Run()
        {
            var contact1 = new Contact() { FirstName = "asdd", LastName = "gasca", PhoneNumber = "1241515235" };
            var contact2 = new Contact() { FirstName = "gbfsbsdkjhk", LastName = "ljnkjbn", PhoneNumber = "9951951" };
            var contact3 = new Contact() { FirstName = "фывфыв", LastName = "чичсичси", PhoneNumber = "65651165" };
            var contact4 = new Contact() { FirstName = "32112", LastName = "54", PhoneNumber = "621621" };
            var contact5 = new Contact() { FirstName = "апрапр", LastName = "фывфысячс", PhoneNumber = "356363546" };
            var contact6 = new Contact() { FirstName = "_енгшкегн", LastName = "злзщлзщ", PhoneNumber = "57857900" };
            var contact7 = new Contact() { FirstName = "zxczxc", LastName = "zxccc", PhoneNumber = "5678957" };
            var contact8 = new Contact() { FirstName = "фывафм", LastName = "гнпьо", PhoneNumber = "65416816" };
            var contact9 = new Contact() { FirstName = "@fgsdf", LastName = "1231", PhoneNumber = "541654" };
            var contact10 = new Contact() { FirstName = "питап", LastName = "таптсмитсм", PhoneNumber = "1926185" };

            _contactList.AddContact(contact1);
            _contactList.AddContact(contact2);
            _contactList.AddContact(contact3);
            _contactList.AddContact(contact4);
            _contactList.AddContact(contact5);
            _contactList.AddContact(contact6);
            _contactList.AddContact(contact7);
            _contactList.AddContact(contact8);
            _contactList.AddContact(contact9);
            _contactList.AddContact(contact10);

            Console.WriteLine("Contact List default settings:");
            _contactList.ShowContactList();

            Console.WriteLine();
            Console.WriteLine("Contact List \"Ru\":");
            _contactList.ShowContactList();
        }
    }
}
