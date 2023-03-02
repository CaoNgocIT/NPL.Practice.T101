using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace NPL.Practice.T101.Exercise3
{
    public class PhoneBook
    {
        public string Name { get; set; }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (!value.IsValidPhoneNumber())
                    throw new Exception("Input value is not correct");
                phoneNumber = value;
            }
        }

        public string Email { get; set; }

        public string Address { get; set; }

        private string group;

        public string Group
        {
            get { return group; }
            set
            {
                if (!value.IsValidGroup())
                    throw new Exception("Input value is not correct");
                group = value;
            }
        }

        public PhoneBook()
        {
        }

        public PhoneBook(string name, string phoneNumber, string email, string address, string group)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Group = group;
        }

        public override string? ToString()
        {
            return string.Format("{0,-20} {1,-15} {2,-25} {3,-20} {4,-20}", Name, PhoneNumber, Email, Address, Group);
        }
    }
}
