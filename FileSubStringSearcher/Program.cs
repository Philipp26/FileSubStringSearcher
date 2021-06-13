using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;

namespace FileSubStringSearcher
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для поиска в файлах:");
            var pattern = Console.ReadLine();

            var startPath = ConfigurationSettings.AppSettings["startFolder"];
            var filePathes = new List<string>();

            var getSupTreeFiles = Directory
                .GetFiles(startPath, ConfigurationSettings.AppSettings["extensions"], SearchOption.AllDirectories);

            foreach(var path in getSupTreeFiles)            
                if (File.ReadAllText(path).Contains(pattern))                
                    filePathes.Add(new FileInfo(path).FullName);

            Console.WriteLine("\r\nСписок файлов содержащих строку:");

            if (filePathes.Count == 0)
                Console.WriteLine("Не найдено");
            else
                foreach (var item in filePathes)
                    Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
