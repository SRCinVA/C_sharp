using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookConsole
{
    public class PhoneBook
    {
        // will manage the contact list
        private List<Contact> _contacts { get; set; } // underscore indicates that it's private
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact {contact.Name},{contact.Number}");
        }


        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);  // all we need to do is add the contact to the list _contacts
        }


        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);  // note the labda expression to make sure the numbes match

            // the contact could be null or some specific contact
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else  // otherwise the contact exists, so we'll display it
            {
                Console.WriteLine($"Contact {contact.Name},{contact.Number}");
            }
        }

        public void DisplayAllContacts() // no need for a parameter
        {
            // iterate over every item in the Contacts list
            foreach (var contact in _contacts)
            {
                Console.WriteLine($"Contact {contact.Name},{contact.Number}");
            }
        }


    }
}
