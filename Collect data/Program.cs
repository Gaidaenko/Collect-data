using System;


namespace Collect_data
{
    class Program
    {  
        static void Main(string[] args)
        {
            docx_doc.Docx_doc();
            xlsx_xls.Xlsx_xls();
            pptx.Pptx();
            txt.Txt();
            pdf.Pdf();

            Console.ReadLine();

        }
    }
}
