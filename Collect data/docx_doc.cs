using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_data
{
    class docx_doc
    {
        public static void Docx_doc()
        {

            foreach (var items in file_paths.files_docx_desktop)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_docx_documets)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_docx_downloads)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_docx_C)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_doc_desktop)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_doc_documets)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_doc_downloads)
            {
                string result = items;
                Console.WriteLine(result);
            }

            foreach (var items in file_paths.files_doc_C)
            {
                string result = items;
                Console.WriteLine(result);
            }
        }
    }
}
