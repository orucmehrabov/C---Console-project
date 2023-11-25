using System;

namespace UserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our application");

            // User Authentication
            Console.WriteLine("Please enter your login and password");
            string login = Console.ReadLine();
            string password = Console.ReadLine();

            // Verify login and password
            if (login == "admin" && password == "password")
            {
                Console.WriteLine("Login successful!");

                // Main Menu
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1 - Group operations");
                Console.WriteLine("2 - Student operations");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // Group operations
                        Console.WriteLine("Group operations selected");
                        // Perform group operations
                        break;
                    case 2:
                        // Student operations
                        Console.WriteLine("Student operations selected");
                        // Perform student operations
                        break;
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid login or password");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
