using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../input.txt");
            string s = sr.ReadToEnd();
            string[] str = s.Split();
            sr.Close();

            List<int> arr = new List<int>();
            List<int> Prime = new List<int>();

            foreach(string a in str)
            {
                arr.Add(int.Parse(a));
            }
            for(int i = 0;i < arr.Count; i++)
            {
                if(IsPrime(arr[i]) == 1)
                {
                    Prime.Add(arr[i]);
                }
            }
            StreamWriter sw = new StreamWriter("../../output.txt");
            if (Prime.Count >= 1)
            {
                for (int i = 0; i < Prime.Count; i++)
                {
                    sw.Write(Prime[i] + " ");
                }
            }
            else sw.Write("No prime numbers in array");
            sw.Close();
        }
        public static int IsPrime(int num)
        {
            for(int i = 2; i <= num; i++)
            {
                if((i == num) || (i > Math.Sqrt(num)))
                {
                    return 1;
                }
                if(num % i == 0 && i != num || num == 1)
                    {
                        return 0;
                    }
            }
            return 0;
        }

    }
}
