using System;

/*----------------------------------------
 * NAME : 036_01_Operator3
 * DESC : 할당 연산자 : =, +=, *=, -=, /=, %=
 -----------------------------------------*/
namespace _01_Operator3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 10, b = 100;

            a += 10; // a = a + 10;
            Console.WriteLine("a : {0}", a);

            a -= b;
            Console.WriteLine("a : {0}", a);

            a *= b;
            Console.WriteLine("a : {0}", a);

            b /= 3;
            Console.WriteLine("b : {0}", b);

            b %= 10;
            Console.WriteLine("b : {0}", b);
        }
    }
}
