using System;
using Maths2;
namespace JenkinApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMaths mymath = new MyMaths();
            int a = mymath.Add(2, 3);
            int b = mymath.Multiply(3, 5);
            Console.WriteLine($"{a}.......{b}");
        }
    }
}
