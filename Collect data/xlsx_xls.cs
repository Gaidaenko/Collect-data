using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_data
{
    class xlsx_xls
    {
        public static void Xlsx_xls()
        {
            foreach (var items in file_paths.files_xlsx_desktop)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_xlsx_documets)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_xlsx_downloads)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_xlsx_C)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_xls_desktop)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_xls_documets)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_xls_downloads)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_xls_C)
            {
                string result = items;
                Console.WriteLine(result);
            }
        }
    }
}
