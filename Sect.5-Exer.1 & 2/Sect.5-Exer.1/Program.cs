using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._5_Exer._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menus menu = new Menus();
            
            while (true) 
            {
                var selection = menu.GetMainMenu();
                if (selection == 3)
                {
                    Console.WriteLine("Program closing...\n");
                    break;
                }

                var passwordEntry = menu.GetPasswordMenu();
                 
                switch (selection)
                {
                    case 1:
                        var sqlConnection = new SqlConnection(passwordEntry);
                        DbCommand sqlcommand = new DbCommand(sqlConnection, sqlConnection.GetCommand());
                        break;

                    case 2:
                        var oracleConnection = new OracleConnection(passwordEntry);
                        DbCommand oraclecommand = new DbCommand(oracleConnection, oracleConnection.GetCommand());
                        break;

                    default:
                        Console.WriteLine("Something unexpected happened with selection switch case...");
                        break;
                }
            }
        }
    }
}
