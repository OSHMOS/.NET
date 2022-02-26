using System;

/*---------------------------------------------------------
 * NAME : 037_Operator4
 * DESC : 관< 연산자 : <, >, <=, >=, ==, != (피연산자의 비교(bool)
 ----------------------------------------------------------*/
namespace _Operator4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool result;
            int a = 100;
            int b = 1000;

            result = (a == b); // false
            Console.WriteLine("(a == b) : {0}", result);

            result = (a != b); // true
            Console.WriteLine("(a != b) : {0}", result);

            result = (a > b); // false
            Console.WriteLine("(a == b) : {0}", result);

            result = (a < b); // true
            Console.WriteLine("(a == b) : {0}", result);

            result = (a >= b); // false
            Console.WriteLine("(a == b) : {0}", result);

            result = (a <= b); // true
            Console.WriteLine("(a == b) : {0}", result);
        }
    }
}
