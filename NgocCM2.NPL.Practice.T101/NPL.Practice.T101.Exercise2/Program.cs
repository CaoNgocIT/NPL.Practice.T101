namespace NPL.Practice.T101.Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>
            {
                "Ngo Viet Hung",
                "Le Thanh Nga",
                "Nguyen Van Hung",
                "Cao Minh Ngoc",
                "Tran Duc Lam",
                "Pham Ngoc Huy"
            };

            //Generate email from eployee list
            List<string> emails = GenerateEmailAddress(employees);

            //Loop to display emails
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
        }

        /// <summary>
        /// Generate email from employee list
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        static private List<string> GenerateEmailAddress(List<string> employees)
        {
            Dictionary<string, int> emailDictionary = new Dictionary<string, int>();
            List<string> emails = new List<string>();

            //Loop through all employee's names in the list
            foreach (string employee in employees)
            {
                //Split the full name by white space
                string[] names = employee.Split(' ');

                //Get the first letter in first name
                string firstName = names[0].Substring(0, 1).ToLower();

                //Get the first letter in middle name
                string middleName = names[1].Substring(0, 1).ToLower();

                //Get the last name
                string lastName = names[names.Length - 1].ToLower();

                //Concat names into an email with domain "@fsoft.com.vn"
                string email = $"{lastName}{firstName}{middleName}@fsoft.com.vn";

                //If an email already exists in dictionary, increase the count of it and append that number after its name-part
                if (emailDictionary.ContainsKey(email))
                {
                    int count = emailDictionary[email] + 1;
                    emailDictionary[email] = count;
                    email = $"{lastName}{firstName}{middleName}{count}@fsoft.com.vn";
                }
                else
                {
                    emailDictionary[email] = 1;
                }
                emails.Add(email);
            }
            return emails;
        }
    }
}
