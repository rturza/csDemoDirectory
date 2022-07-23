using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csDemoDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"S:\Utils\DemoDirectory");

            //var files = Directory.GetFiles(@"C:\projects\CsharpBasic", "*.sln" , SearchOption.AllDirectories);
            //foreach (var file in files)
            //    Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\projects\CsharpBasic", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists(@"S:\Utils");

            var directoryInfo = new DirectoryInfo(@"S:\Utils");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
