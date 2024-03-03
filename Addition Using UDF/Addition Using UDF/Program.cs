using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Addition_Using_UDF
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter No1:- ");
            int i = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter No2:- ");
            int j = int.Parse(System.Console.ReadLine());

            int k = sum(i, j);
            System.Console.WriteLine("Sum Of Two Numbers are:- " + k);

            k = Sub(i,j);
            System.Console.WriteLine("Substraction Of Two Numbers are:- " + k);

            k = mul(i,j);
            System.Console.WriteLine("Muliplication Of Two Numbers are:- " + k);

            k = div(i,j);
            System.Console.WriteLine("Divison Of Two Numbers are:- " + k);
            System.Console.ReadLine();
        }

        static int sum(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int mul(int a, int b)
        {
            return a * b;
        }

        static int div(int a, int b)
        {
            return a / b;
        }
    }
}
