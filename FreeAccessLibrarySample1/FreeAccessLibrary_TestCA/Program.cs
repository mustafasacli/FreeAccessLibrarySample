using FreeAccessLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeAccessLibrary_TestCA
{
    class Program
    {
        private static string
            Provdr4 = "Provider=Microsoft.Jet.Oledb.4.0; ",
            Provdr12 = "Provider=Microsoft.ACE.OLEDB.12.0; ",
            yol = "Data Source=iller.mdb; ",
            psinf = "Persist Security Info=False; ",
            user = "User Id=admin; ",
            pwd = "Jet OLEDB:Database Password=yourMdbFilePass; ";

        private static void Main(string[] args)
        {
            DataManager dtMan = new DataManager(Provdr4 + yol + psinf);
            // Password Version
            //DataManager dtMan = new DataManager(Provdr4 + yol + psinf + user + pwd);
            Stopwatch stp = new Stopwatch();
            stp.Start();

            DataTable dt = dtMan.GetResultSetOfQuery("select count(*) from iller;").Tables[0];
            stp.Stop();
            Console.WriteLine("Sonuç: " + dt.Rows[0][0].ToString());
            Console.WriteLine("Geçen zaman(ms): " + stp.ElapsedMilliseconds);
            Console.Read();
        }
    }
}
