//using Microsoft.AspNetCore.Http;
//using ServiceStack.Host;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Threading.Tasks;

//namespace ProcessAudit2.Helpers
//{
//    public class DownloadExternalFile : IHttpHandler
//    {
//        //  We can't directly open a network file using Javascript, eg
//        //      window.open("\\SomeNetworkPath\ExcelFile\MikesExcelFile.xls");
//        //
//        //  Instead, we need to get Javascript to call this groovy helper class which loads such a file, then sends it to the stream.  
//        //      window.open("/Handlers/DownloadExternalFile.ashx?filename=//SomeNetworkPath/ExcelFile/MikesExcelFile.xls");
//        //
//        public void ProcessRequest(HttpContext context)
//        {
//            string pathAndFilename = context.Request["filename"];               //  eg  "\\SomeNetworkPath\ExcelFile\MikesExcelFile.xls"
//            string filename = System.IO.Path.GetFileName(pathAndFilename);      //  eg  "MikesExcelFile.xls"

//            context.Response.ClearContent();

//            WebClient webClient = new WebClient();
//            using (Stream stream = webClient.OpenRead(pathAndFilename))
//            {
//                // Process image...
//                byte[] data1 = new byte[stream.Length];
//                stream.Read(data1, 0, data1.Length);

//                context.Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}", filename));
//                context.Response.BinaryWrite(data1);

//                context.Response.Flush();
//                context.Response.SuppressContent = true;
//                context.ApplicationInstance.CompleteRequest();
//            }
//        }

//        public bool IsReusable
//        {
//            get
//            {
//                return false;
//            }
//        }
//    }
