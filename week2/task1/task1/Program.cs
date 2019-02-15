using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../input.txt");
            string n = sr.ReadToEnd();
            int b = n.Length;
            for(int i = 0; i < b; i++)
            {
                if (n[i] != n[b - i - 1])
                {
                    Console.WriteLine("No");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Yes");
            Console.ReadKey();
            sr.Close();
        }
    }
}
