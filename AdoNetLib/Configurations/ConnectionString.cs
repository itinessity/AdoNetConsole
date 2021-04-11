using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetLib.Configurations
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Data Source=.\SQLEXPRESS;Database=testing;Trusted_Connection=True;";
    }
}
