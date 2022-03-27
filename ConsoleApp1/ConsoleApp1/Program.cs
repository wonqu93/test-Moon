using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("안녕! C#!");
            Console.WriteLine("C# 안녕!");

            var num1 = 1;
            var num2 = 2;

            Console.WriteLine(num1 + num2);

            var num = 1;

            Console.WriteLine("0 ~ 9 사이의 값을 입력 : ");

            var input = Console.ReadLine();

            if (num.ToString() == input)
            {
                Console.WriteLine("같은 값을 입력했습니다!");
            }
            else
            {
                Console.WriteLine("다른 값을 입력했습니다!");
            }

            Console.WriteLine("for 문 1");

            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }

            var forNum = 1;

            Console.WriteLine("for 문 2");

            for (; forNum <= 10; forNum++)
            {
                Console.WriteLine(forNum);
            }

            List<int> numberList = new List<int>();

            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);

            Console.WriteLine("foreach 문 1");

            foreach (var numm in numberList)
            {
                Console.WriteLine(numm);
            }

            Console.WriteLine("for 문 3");

            for (var indexNum = 0; indexNum < numberList.Count; indexNum++)
            {
                Console.WriteLine(numberList[indexNum]);
            }
        }
    }
}
