using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._5_Exer._1
{
    public class SqlConnection : DbConnection
    {
        private string connectionString;
        private string sqlPassword = "sql"; // use this password when prompted for SQL connection.
        private string sqlInstructions = "This is the T-SQL instruction set for this connection.\n";

        public SqlConnection (string ConnectionString)
        {
            this.connectionString = ConnectionString;

            if (connectionString != sqlPassword)
                throw new InvalidOperationException("Invalid password entered.");
        }

        public override void Open()
        {
            Console.WriteLine("Sql connection has been opened\n");
        }

        public override void Close()
        {
            Console.WriteLine("Sql connection has been closed\n");
        }

         public string GetCommand()
        {
            return sqlInstructions;
        }
    }
}
