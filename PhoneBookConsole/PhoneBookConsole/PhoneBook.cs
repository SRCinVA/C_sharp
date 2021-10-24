using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookConsole
{
    public class PhoneBook
    {
        // will manage the contact list
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        // underscore indicates that it's private.
        // remember to initialize these by creating a "new" object.

        private void DisplayContactDetails(Contact contact)   // a small refactoring
        {
            Console.WriteLine($"Contact {contact.Name},{contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts) // after putting the matching contacts into a list, now we just iterate over them
            {
                DisplayContactDetails(contact);
            }
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
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContacts() // no need for a parameter
        {
            DisplayContactsDetails(_contacts);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList(); // complicated syntax here ...

            // after putting the matching contacts into a list, now we just iterate over them (thsi was refactored from the for each loop elsewhere
            DisplayContactsDetails(matchingContacts);
        }

    }
}
