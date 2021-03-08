namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Add public property full name
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}