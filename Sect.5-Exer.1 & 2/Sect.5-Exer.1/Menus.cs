using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._5_Exer._1
{
    class Menus
    {
        public int GetMainMenu()
        {
            while (true)
            {
                Console.WriteLine
                    ("Which connection type would you like to open?: \n" +
                     "1. SQL Connection\n" +
                     "2. Oracle Connection\n" +
                     "3. Exit");

                var input = Console.ReadLine();
                Console.Clear();

                if (String.IsNullOrWhiteSpace(input))
                    throw new InvalidOperationException("Entry cannot be blank.");

                try
                {
                    if ((Convert.ToInt32(input) < 1) ||
                        Convert.ToInt32(input) > 3)
                    {
                        Console.WriteLine("Invalid input. Please try again\n");
                        continue;
                    }

                    return Convert.ToInt32(input);

                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid Entry. Please try again.\n");
                    continue;
                }
            }
        }

        public string GetPasswordMenu()
        {
            Console.Clear();
            Console.WriteLine("Please enter password for this connection\n");
            var password = Console.ReadLine();
            Console.Clear();

            if (String.IsNullOrWhiteSpace(password))
                throw new InvalidOperationException("Entry cannot be blank.");

            return password;
            
        }

    }
}
