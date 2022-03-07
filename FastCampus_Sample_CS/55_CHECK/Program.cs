using System;

namespace _CHECK
{
    class MainClass
    {
        // Random rnd = new Random();
        // rnd.Next(min, max)
        // => (min <= rnd < max)범위 중의 랜덤값
        public static void Main(string[] args)
        {
            //Console.WriteLine("a : {0} b : {1}", a, b);

            for (int i = 1; i < 6; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 100);
                int b = rnd.Next(0, 100);

                Console.WriteLine("{0} : 다음 두 수의 합은?(총 5문제)", i);
                Console.WriteLine("{0} + {1} = ??", a, b);
                int asumb = int.Parse(Console.ReadLine());

                if (asumb == (a + b))
                {
                    Console.WriteLine("== 정답 ==");
                }
                else
                {
                    Console.WriteLine("오답(정답은 : {0})", (a + b));
                }
            }
        }
    }
}
