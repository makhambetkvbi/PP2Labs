using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public static void Spaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("    ");
        }
        public static void Folder(DirectoryInfo dir,int level)
        {
            foreach(FileInfo f in dir.GetFiles())
            {
                Spaces(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo d in dir.GetDirectories())
            {
                Spaces(level);
                Console.WriteLine(d.Name);
                Folder(d, level + 1);
            }

        }
        static void Main(string[] args)
        {
            DirectoryInfo path = new DirectoryInfo(@" C:\Users\Махамбет\Desktop\PP2Labs\week2\task3");
            Folder(path, 0);
            Console.ReadKey();
        }
    }
}
