using System;
namespace PhoneBookConsole
{
    public class PhoneBook
    {
        public PhoneBook() // will manage the contact list
        {
            private List<Contact> _contacts { get; set; } // underscore indicates that it's private


            public void AddContact(Contact contact)
            {
            _contacts.Add(contact);  // all we need to do is add the contact to the list _contacts
            }
    }
}
