using _0303人事行政局放假資料.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0303人事行政局放假資料
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] webData = File.ReadAllLines(@"D:/政府行政機關辦公日曆表.csv");
            Model1 db = new Model1(); //ado.net db
            for (int j = 1; j < webData.Length; j++)
            {
                holiday holidayItem = new holiday(); //屬性
                string[] lineStrings = webData[j].Split(',');
                //for (int k = 0; k < lineStrings.Length; k++)
                //{
                //    lineStrings[k] = lineStrings[k].Replace("\"", "");
                //}
                holidayItem.date = Convert.ToDateTime(lineStrings[0].Replace("\"", ""));
                holidayItem.name = lineStrings[1].Replace("\"", "");
                holidayItem.isHoliday = lineStrings[2].Replace("\"", "");
                holidayItem.holidayCategory = lineStrings[3].Replace("\"", "");
                holidayItem.description = lineStrings[4].Replace("\"", "");
                //db名 加入有值屬性
                db.Holidays.Add(holidayItem);
            }
            db.SaveChanges();
            Console.Write("執行成功!");
            Console.ReadKey();
        }
    }
}