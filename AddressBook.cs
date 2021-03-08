using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        // Created public property called Contacts with a key of string and values are Contact instances
        public Dictionary<string, Contact> Contacts { get; set; } = new Dictionary<string, Contact>();

        // contact is the parameter we created when adding contact
        public void AddContact(Contact contact)
        {
            try
            {
                Contacts.Add(contact.Email, contact);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Sorry! {contact.FullName} has already been added.");
            }
        }

        // email on 24 is the same as email on 26
        public Contact GetByEmail(string email)
        {
            try
            {
                return Contacts[email];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Sorry! {email} is not in our system!");
                return null;
            }
        }
    }
}