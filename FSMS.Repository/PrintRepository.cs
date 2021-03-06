﻿using FSMS.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Repository
{
    public class PrintRepository
    {
        public static string FileFolder = "FSMSReceipt";


        public static string WriteSimpleReciept(DifferentLog entuty,string pumpername,string CompName)
        {
            string dirname = Path.Combine(Environment.CurrentDirectory, FileFolder);
            string filename = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + pumpername.Trim().Replace(".", string.Empty) + ".txt";
            if (!Directory.Exists(dirname))
            {
                DirectoryInfo dir = Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, FileFolder));
            }

            if (!File.Exists(filename))
            {
                FileStream fs = File.Create(Path.Combine(dirname, filename));
                fs.Close();
            }

            StreamWriter sr = WriteToFIle(entuty, pumpername, dirname, filename, CompName);
            sr.Close();

            return Path.Combine(dirname, filename);
        }

        private static StreamWriter WriteToFIle(DifferentLog entuty, string pumpername, string dirname, string filename,string CompanyName)
        {
            StreamWriter sr = new StreamWriter(Path.Combine(dirname, filename));
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    WriteLine(sr, "--------Cashier Copy--------");
                }
                else {
                    WriteLine(sr, "--------Pumper Copy--------");
                }
                WriteLine(sr, "Daily Sales");
                if (CompanyName.Length > 30)
                {
                    WriteLine(sr, CompanyName.Substring(0, 30)); //"FSFS Distributors Waththala");
                }
                else {
                    WriteLine(sr, CompanyName); //"FSFS Distributors Waththala");
                }
                WriteLineRight(sr, "Pumper : " + pumpername.Trim());
                WriteLineRight(sr, "Date   : " + DateTime.Now.ToShortDateString());
                WriteLine(sr, "------------------------------");
                WriteLineRight(sr, "Cash Total   : " + String.Format("{0,15}", entuty.CashTotal.ToString()));
                WriteLineRight(sr, "Card Total   : " + String.Format("{0,15}", entuty.CardTotal.ToString()));
                WriteLineRight(sr, "Voucher Total: " + String.Format("{0,15}", entuty.VoucherTotal.ToString()));
                WriteLineRight(sr, "Expenses     : " + String.Format("{0,15}", entuty.Expenses.ToString()));
                WriteLineRight(sr, "Testing Total: " + String.Format("{0,15}", entuty.Testing.ToString()));
                WriteLineRight(sr, "------------------------------");
                WriteLineRight(sr, "System  Total: " + String.Format("{0,15}", entuty.SystemTotal.ToString()));
                WriteLineRight(sr, "Collection   : " + String.Format("{0,15}", entuty.TotalCollection.ToString()));
                WriteLineRight(sr, "Difference   : " + String.Format("{0,15}", entuty.Differences.ToString()));

                WriteLineRight(sr, String.Format(""));

                WriteLineRight(sr, String.Format("{0,-15}", "--------------") + String.Format("{0,15}", "--------------"));
                WriteLineRight(sr, String.Format("{0,-15}", pumpername.Trim()) + String.Format("{0,15}", "Cashier"));
                WriteLineRight(sr, String.Format(""));
                WriteLineRight(sr, String.Format(""));
            }
            return sr;
        }

        public static void WriteLine(StreamWriter sr,  string str) {
            int maxwidth = 30;

            string lineAlignedCenter = String.Format("{0,-27}",
                 String.Format("{0," + ((maxwidth + str.Length) / 2).ToString() + "}", str));

            sr.WriteLine(lineAlignedCenter);
        }

        public static void WriteLineRight(StreamWriter sr, string str)
        {
            

            sr.WriteLine(str);
        }

        
    }
}
