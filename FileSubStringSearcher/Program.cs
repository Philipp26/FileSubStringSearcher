using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FileSubStringSearcher
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            var startPath = ConfigurationSettings.AppSettings["startFolder"];

            var getSupTreeFiles = Directory
                .GetFiles(startPath, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".sql"))
                .ToArray(); 


        }
    }
}
