using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._5_Exer._1
{
    public class DbCommand
    {
        private DbConnection connection;
        private string instruction;

        public DbCommand (DbConnection Connection, string Instruction)
        {
            connection = Connection;
            instruction = Instruction;
            Execute();
        }

        private void Execute()
        {
            connection.Open();
            Console.WriteLine(instruction);
            connection.Close();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
