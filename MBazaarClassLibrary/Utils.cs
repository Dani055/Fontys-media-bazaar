﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBazaarClassLibrary
{
    public static class Utils
    {
        public static string connectionString { get; } = "server=eu01-sql.pebblehost.com;database=customer_251983_database;uid=customer_251983_database;password=xenOC70490U@a!pfkl7-;";
        public static string DbDateFormat = "yyyy-MM-dd";
        public static string GetDateStringForMySQL(DateTime date)
        {
            return $"{date.Year}-{date.Month}-{date.Day}";
        }
    }
}