using System;
using System.IO;

namespace Collect_data
{
    class Program
    {
        public static string targetPath = "C:\\tmp";
        static void Main(string[] args)
        {
            DirectoryInfo targetFolder = new DirectoryInfo("C:\\tmp");

            if (!targetFolder.Exists)
            {
                Directory.CreateDirectory("C:\\tmp");
            }

            docx_doc.Docx_doc();
            xlsx_xls.Xlsx_xls();
            pptx.Pptx();
            txt.Txt();
            pdf.Pdf();

            Console.ReadLine();

        }
    }
}
