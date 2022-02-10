using System;

namespace _Variable2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 100; /* 선언과 동시에 초기화 가능 */
            int y = 200;
            int a = 1000, b = 2000, c;

            c = 200;

            Console.WriteLine("x : {0}", x);
            Console.WriteLine("y : " + y);
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.WriteLine("c : " + c);
        }
    }
}
