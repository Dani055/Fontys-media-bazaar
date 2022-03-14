﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.logic
{
    public static class Utils
    {
        public static string connectionString { get; } = "server=eu01-sql.pebblehost.com;database=customer_251983_database;uid=customer_251983_database;password=xenOC70490U@a!pfkl7-;";
        public static string DbDateFormat = "yyyy-MM-dd";

        public static void ShowError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowConfirmation(string text)
        {
           return MessageBox.Show(text, caption:"Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);          
        }

        public static string GetDateStringForMySQL(DateTime date)
        {
            return $"{date.Year}-{date.Month}-{date.Day}";
        }
    }
}
