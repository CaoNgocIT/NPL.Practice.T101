namespace NPL.Practice.T101.Exercise3
{
    public class PhoneBookManagement
    {
        //Test data
        List<PhoneBook> listPhoneBook = new List<PhoneBook>()
        {
            new PhoneBook("Christine Collins", "094 732 8481", "collins@gmail.com", "UK", "Other"),
            new PhoneBook("Triston Brown", "020 383 8313", "brown@gmail.com", "US", "Family"),
            new PhoneBook("Karsyn Cooper", "092 432 6871", "cooper@gmail.com", "UK", "Friend"),
            new PhoneBook("Vincent McConnell", "013 642 3512", "vincent@gmail.com", "Germany", "Colleague"),
            new PhoneBook("Meredith English", "072 841 0091", "english@gmail.com", "Canada", "Family"),
            new PhoneBook("Marin Harvey", "017 452 4012", "harvey@gmail.com", "France", "Other"),
            new PhoneBook("Leroy Barron", "064 336 1182", "barron@gmail.com", "Italy", "Colleague"),
        };

        /// <summary>
        /// Add a new phone book
        /// </summary>
        public void AddPhoneBook()
        {
            PhoneBook phoneBook = new PhoneBook();

            Console.Write("Name: ");
            phoneBook.Name = Console.ReadLine();

            Console.Write("Phone number: ");
            phoneBook.PhoneNumber = Console.ReadLine();

            Console.Write("Address: ");
            phoneBook.Address = Console.ReadLine();

            Console.Write("Email: ");
            phoneBook.Email = Console.ReadLine();

            Console.Write("Group: ");
            phoneBook.Group = Console.ReadLine();

            listPhoneBook.Add(phoneBook);
            Console.WriteLine("Added");
            Display(listPhoneBook);
        }
        
        /// <summary>
        /// Remove a phone book by name
        /// </summary>
        public void RemovePhoneBook()
        {
            string nameToRemove;
            Console.Write("Enter a name to remove: ");
            nameToRemove = Console.ReadLine();

            //Find phone books by inputted name
            var result = listPhoneBook.Where(x => x.Name.ToLower() == nameToRemove.ToLower()).ToList();

            //No phone book is found
            if (result.Count == 0)
            {
                Console.WriteLine($"No {nameToRemove} to remove!");
            }

            //If found, remove it from the list
            else
            {
                listPhoneBook.Remove(listPhoneBook.First(x => x.Name == nameToRemove));
            }

            Display(listPhoneBook);
        }

        /// <summary>
        /// Sort the list of phone book by name
        /// </summary>
        public void SortPhoneBook()
        {
            //Sort by name ascendingly
            var result = (from r in listPhoneBook 
                              orderby r.Name 
                              select r).ToList();
            Display(result);
        }

        /// <summary>
        /// Find phone book by name
        /// </summary>
        public void FindPhoneBook()
        {
            string nameToFind;
            Console.Write("Enter a name to find: ");
            nameToFind = Console.ReadLine();

            //Find list book with inputted name
            var result = listPhoneBook.Where(x => x.Name.ToLower() == nameToFind.ToLower()).ToList();

            //No phone book is found
            if (result.Count == 0)
            {
                Console.WriteLine($"{nameToFind} not found!");
            }  

            //Display the found result
            else
            {
                Display(result);
            }
        }

        /// <summary>
        /// Display the list of phone book
        /// </summary>
        /// <param name="phoneBooks"></param>
        public void Display(List<PhoneBook> phoneBooks)
        {
            //Loop through the list of phone book
            foreach (var phone in phoneBooks)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}
