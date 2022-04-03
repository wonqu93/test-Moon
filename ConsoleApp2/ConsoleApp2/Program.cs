using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1;

            List<int> list = new List<int>();
            list.Add(1); 
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            foreach (var numm in list)
            {
                Console.WriteLine(numm);
            }
        }
    }
}
