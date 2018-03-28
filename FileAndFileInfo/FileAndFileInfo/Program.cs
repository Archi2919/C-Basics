using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\somefile.jpg";
            File.Copy(@"C:\temp\myfile.jgp", "d:\temp\myfile.jpg", true);

            File.Delete(path);
            if (File.Exists(path))
            {

            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("..");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }

        }
    }
}
