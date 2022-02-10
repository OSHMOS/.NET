using System;

namespace _Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("지금 듣는 강의는 " + args[0]);
            Console.WriteLine(args[1] + "좋아요!!");

            Console.ReadKey();
        }
    }
}
