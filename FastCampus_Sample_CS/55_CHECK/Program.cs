using System;

namespace _CHECK
{
    class MainClass
    {
        // rnd.Next(min, max)
        // => (min <= rne < max)범위 중의 랜덤값
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100);

            Console.WriteLine("a : {0} b : {1}", a, b);
        }
    }
}
