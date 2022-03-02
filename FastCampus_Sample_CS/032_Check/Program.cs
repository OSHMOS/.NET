using System;

/*---------------------------------------------------------------
 * NAME : 032_Check
 * DESC : GetType()함수로 (int, string, float, char)형 CTS표준 출력하기
 ----------------------------------------------------------------*/
namespace _Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 100;
            string b = "AAA";
            float c = 0.123f;
            char d = 'A';
            int e = 0;

            Console.WriteLine("a : {0}, a.GetType() : {1}", a, a.GetType());
            Console.WriteLine("b : {0}, b.GetType() : {1}", b, b.GetType());
            Console.WriteLine("c : {0}, c.GetType() : {1}", c, c.GetType());
            Console.WriteLine("d : {0}, d.GetType() : {1}", d, d.GetType());
            Console.WriteLine("e : {0}, e.GetType() : {1}", e, e.GetType());
            // 궁금증 해결!
        }
    }
}
