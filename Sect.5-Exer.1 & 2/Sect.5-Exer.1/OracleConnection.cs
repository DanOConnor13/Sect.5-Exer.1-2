using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._5_Exer._1
{
    public class OracleConnection : DbConnection
    {
        private string connectionString;
        private string oraclePassword = "oracle";  // use this password when prompted for Oracle connection.
        private string oracleInstructions = "This is the Oracle instruction set for this connection.\n";


        public OracleConnection(string ConnectionString)
        {
            this.connectionString = ConnectionString;

            if (connectionString != oraclePassword)
                throw new InvalidOperationException("Invalid password entered.");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connection has been opened\n");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection has been closed\n");
        }

        public string GetCommand()
        {
            return oracleInstructions;
        }
    }
}
