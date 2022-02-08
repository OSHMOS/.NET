using System;

namespace _HelloWorld3
{
    class MainClass
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(" static void Main(string[] args)");
        //}

        //public static void Main()
        //{
        //    Console.WriteLine("static void Main");
        //}

        //public static int Main()
        //{
        //    Console.WriteLine("static int Main");
        //    return 0;
        //}

        public static int Main(string[] args)
        {
            Console.WriteLine("AA{0} BB{1}", "aa", "bb"); // 줄바꿈 포함
            Console.Write("{0}{1}{2}", 1, 2, 3); // 줄바꿈 없음
            Console.WriteLine("static int Main(string[] args)");
            return 0;
        }
    }
}
/*----------------------------
 * 함수가 가지는 특성
 -----------------------------*/
