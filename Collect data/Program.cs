using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_data
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string desktop = "C:\\Users\\" + Environment.UserName + "\\Desktop\\";
            string documents = "C:\\Users\\" + Environment.UserName + "\\Documents\\";
            string downloads = "C:\\Users\\" + Environment.UserName + "\\Downloads\\";
            string C = "C:\\";

            string[] files_xlsx_desktop = Directory.GetFiles(desktop, "*.xlsx", SearchOption.AllDirectories);
            string[] files_xlsx_documets = Directory.GetFiles(documents, "*.xlsx", SearchOption.AllDirectories);
            string[] files_xlsx_downloads = Directory.GetFiles(downloads, "*.xlsx", SearchOption.AllDirectories);
            string[] files_xlsx_C= Directory.GetFiles(C, "*.xlsx");

            foreach (var items in files_xlsx_desktop)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in files_xlsx_documets)
            {
                string result = items;
                Console.WriteLine(result);            
            }

            foreach (var items in files_xlsx_downloads)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in files_xlsx_C)
            {
                string result = items;
                Console.WriteLine(result);
            }


            Console.ReadLine();

        }
    }
}
