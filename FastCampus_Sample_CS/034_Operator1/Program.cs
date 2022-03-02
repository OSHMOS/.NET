using System;

/*---------------------------------------------------
 * NAME : 034_Operator1
 * DESC : 산술 연산자 : +, -, *, /, % (모든 수치 데이터 형태)
 ----------------------------------------------------*/
namespace _Operator1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("c : {0}", c);

            Console.WriteLine("100 - 10 = " + (100 - 10));

            int d = a / b;
            Console.WriteLine("d : {0}", d);

            int e = a * (b + c);
            Console.WriteLine("e: {0}", e);

            int f = (a + b) % 2;
            Console.WriteLine("f : {0}", f);
        }
    }
}
