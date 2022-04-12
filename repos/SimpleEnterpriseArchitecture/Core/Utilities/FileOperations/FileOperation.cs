using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.FileOperations
{
    public static class FileOperation
    {
        public static string ReadHtmlTemplate(string name)
        {
            string path = ServiceTool.RootPath +"\\"+ name + ".html";
            //StreamReader streamReader = new StreamReader(path);
            //string readedData=streamReader.ReadLine();
            var content=File.ReadAllText(path,Encoding.UTF8);
            return content;
        }
    }
}
