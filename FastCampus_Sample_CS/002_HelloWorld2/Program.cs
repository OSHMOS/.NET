using System;

namespace _HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*---------------------------
                * 가장 중요한 메소드
                * 최초의 진입(Entry Point)
                * 메인 메소드가 반드시 존재
            -----------------------------*/
            if (args.Length > 0)
            {
                Console.WriteLine("Hello World: " + args[0]);
            }
            else
            {
                Console.WriteLine("Hello World: args.Length = 0");
            }

            Console.ReadKey();
        }
    }
}
