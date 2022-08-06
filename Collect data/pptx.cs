using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_data
{
    class pptx
    {
        public static void Pptx()
        {
            foreach (var items in file_paths.files_pptx_desktop)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_pptx_documets)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_pptx_downloads)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_pptx_C)
            {
                string result = items;
                Console.WriteLine(result);
            }
        }
    }
}
