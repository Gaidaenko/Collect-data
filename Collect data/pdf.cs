using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_data
{
    class pdf
    {
        public static void Pdf()
        {
            foreach (var items in file_paths.files_pdf_desktop)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_pdf_documets)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_pdf_downloads)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_pdf_C)
            {
                string result = items;
                Console.WriteLine(result);
            }
        }

    }
}
