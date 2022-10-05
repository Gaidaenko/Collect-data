using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;

namespace Collect_data
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo targetFolder = new DirectoryInfo("C:\\tmp");

            if (!targetFolder.Exists)
            {
                Directory.CreateDirectory("C:\\tmp");
            }

            docx_doc.Docx_doc();
            xlsx_xls.Xlsx_xls();
            pptx_ppt.Pptx();
            txt.Txt();
            pdf.Pdf();
            

            CompressAndDelete();
      
        }

        public static void CompressAndDelete()
        {

            string sourceFolder = "C:\\tmp";            
            string zipFile = "C:\\tmp.zip";

            if (File.Exists(zipFile))
            {
                return;
            }
         
            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Directory.Delete("C:\\tmp", true);

        }
    }
}
