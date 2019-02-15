using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        public static void Start()
        {
            string origin = @"C:\Users\Махамбет\Desktop\PP2Labs\week2\task4\path";
            string fileName = Console.ReadLine();

            origin = Path.Combine(origin, fileName);

            File.WriteAllText(origin, "len pisat comment");

            string copy = @"C:\Users\Махамбет\Desktop\PP2Labs\week2\task4\path1";
            string copyfile = Path.Combine(copy, fileName);

            File.Copy(origin, copyfile, true);
            Delete(origin);
        }

        public static void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }



        static void Main(string[] args)
        {
            Start();
        }
    }
}
