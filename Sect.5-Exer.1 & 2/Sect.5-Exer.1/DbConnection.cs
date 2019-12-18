using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._5_Exer._1
{
    public abstract class DbConnection
    {

        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
             
        public abstract void Open();
        public abstract void Close();
    }
}
