namespace FreeAccessLibrary_TestWFA
{
    internal class Configuration
    {
        private static string
            Provdr4 = "Provider=Microsoft.Jet.Oledb.4.0; ",
            Provdr12 = "Provider=Microsoft.ACE.OLEDB.12.0; ",
            yol = "Data Source=persons.mdb; ",
            psinf = "Persist Security Info=False; ",
            user = "User Id=admin; ",
            pwd = "Jet OLEDB:Database Password=yourMdbFilePass; ";

        public static string ConnectionString
        {
            get
            {
                string conn_str = Provdr4 + yol + psinf;
                return conn_str;
            }
        }
    }
}