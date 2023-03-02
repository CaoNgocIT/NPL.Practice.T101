namespace NPL.Practice.T101.Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneBookManagement management = new PhoneBookManagement();
            //Loop until user exits the program
            do
            {
                //Display main menu
                MainMenu();

                //Input an option
                int option = GetValidOption();

                //Implement function based on user's option
                switch (option)
                {
                    //Exit 
                    case 0:
                        break;

                    //Add phone book
                    case 1:
                        management.AddPhoneBook();
                        break;

                    //Remove phone book
                    case 2:
                        management.RemovePhoneBook();
                        break;

                    //Sort phone book
                    case 3:
                        management.SortPhoneBook();
                        break;

                    //Find phone book
                    case 4:
                        management.FindPhoneBook();
                        break;
                }
            } while (true);
        }

        /// <summary>
        /// Display the main menu
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("--------- Menu ---------");
            Console.WriteLine("1. Add a phone book");
            Console.WriteLine("2. Remove a phone book");
            Console.WriteLine("3. Sort a list of phone book");
            Console.WriteLine("4. Find a phone book");
            Console.WriteLine("0. Exit");
        }

        /// <summary>
        /// Get a valid option
        /// </summary>
        /// <returns></returns>
        public static int GetValidOption()
        {
            int option;
            bool isValid;

            //Loop until user enters a correct option
            do
            {
                Console.Write("Enter an option: ");
                isValid = int.TryParse(Console.ReadLine(), out option);

                //Inputted option is invalid and not in range [0-4]
                if (!isValid || (option > 4 && option < 0))
                    Console.WriteLine("Option must be in [0-4]");
                else
                {
                    break;
                }
            } while (!isValid || (option > 4 && option < 0));

            return option;
        }
    }
}