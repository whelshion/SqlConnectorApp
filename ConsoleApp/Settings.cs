using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Settings
    {
        public string MySqlConnString { get; set; }
        public string MsSqlConnString { get; set; }
        public string OracleConnString { get; set; }
        public string QueryString { get; set; }
        public string NonQueryString { get; set; }
    }
}
