using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_data
{
    class pdf
    {
        public static void Pdf()
        {
            DirectoryInfo targetFolder = new DirectoryInfo("C:\\tmp");

            foreach (var items in file_paths.files_pdf_desktop)
            {
                if (targetFolder.Exists)
                {
                    Directory.CreateDirectory("C:\\tmp\\Desktop");

                    string resultDesktop = Path.GetFileName(items);
                    string copyFile = Path.Combine("C:\\tmp\\Desktop", resultDesktop);
                    File.Copy(items, copyFile, true);
                }
            }

            foreach (var items in file_paths.files_pdf_documets)
            {
                if (targetFolder.Exists)
                {
                    Directory.CreateDirectory("C:\\tmp\\Documents");

                    string resultDocuments = Path.GetFileName(items);
                    string copyFile = Path.Combine("C:\\tmp\\Documents", resultDocuments);
                    File.Copy(items, copyFile, true);
                }
            }

            foreach (var items in file_paths.files_pdf_downloads)
            {
                if (targetFolder.Exists)
                {
                    Directory.CreateDirectory("C:\\tmp\\Downloads");

                    string resultDownloads = Path.GetFileName(items);
                    string copyFiles = Path.Combine("C:\\tmp\\Downloads", resultDownloads);
                    File.Copy(items, copyFiles, true);
                }
            }

            foreach (var items in file_paths.files_pdf_C)
            {
                if (targetFolder.Exists)
                {
                    Directory.CreateDirectory("C:\\tmp\\disk_C");

                    string resultC = Path.GetFileName(items);
                    string copyFiles = Path.Combine("C:\\tmp\\disk_C", resultC);
                    File.Copy(items, copyFiles, true);
                }
            }
        }

    }
}
