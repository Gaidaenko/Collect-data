using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_data
{
    class docx_doc
    {    
        public static void Docx_doc()
        {
            DirectoryInfo targetFolder = new DirectoryInfo("C:\\tmp");

            foreach (var items in file_paths.files_docx_desktop)
            {
                if (targetFolder.Exists)
                {
                    Directory.CreateDirectory("C:\\tmp\\Desktop");

                    string result = Path.GetFileName(items);
                    string copyFile = Path.Combine("C:\\tmp\\Desktop", result);
                    File.Copy(items, copyFile, true);
                }

                Console.WriteLine(items);
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
