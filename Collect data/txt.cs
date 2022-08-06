using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_data
{
    class txt
    {
        public static void Txt()
        {
            foreach (var items in file_paths.files_txt_desktop)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_txt_documets)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_txt_downloads)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_txt_C)
            {
                string result = items;
                Console.WriteLine(result);
            }
        }
    }
}
