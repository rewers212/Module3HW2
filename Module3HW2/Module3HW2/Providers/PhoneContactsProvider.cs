using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class PhoneContactsProvider
    {
        public PhoneContactsProvider()
        {
            Contacts = GetContacts();
        }

        public Contact[] Contacts { get; set; }

        private Contact[] GetContacts()
        {
            var contacts = new Contact[]
            {
                new Contact()
                {
                    FirstName = "qwe",
                    LastName = "www",
                    PhoneNumber = "1123123"
                },
                new Contact()
                {
                    FirstName = "vasdv",
                    LastName = "adsfvav",
                    PhoneNumber = "31231242"
                },
                new Contact()
                {
                    FirstName = "asdczxv",
                    LastName = "dsbsb",
                    PhoneNumber = "123123"
                },
                new Contact()
                {
                    FirstName = "фывячс",
                    LastName = "фывфыа",
                    PhoneNumber = "5678576"
                },
                new Contact()
                {
                    FirstName = "фывфыв",
                    LastName = "фывфывпиииии",
                    PhoneNumber = "123123123"
                },
                new Contact()
                {
                    FirstName = "123123",
                    LastName = "123123",
                    PhoneNumber = "987987"
                },
                new Contact()
                {
                    FirstName = "987",
                    LastName = "123123",
                    PhoneNumber = "55512122"
                }
            };
            return contacts;
        }
    }
}
