using System;

/*------------------------------
 * NAME : 041_Operator_null
 * DESC : null 병합 연산자, ??(null이면 다른 값을 리턴)
 -------------------------------*/
namespace _Operator_null
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int? a = null;
            int b = 10;
            int? c = null;
            int d = 100;
            int result;

            result = a ?? b; // 10
            Console.WriteLine("result : {0}", result);

            result = a ?? c ?? d; // 100
            Console.WriteLine("result : {0}", result);

            c = 10000;
            result = a ?? c ?? d; // 10000
            Console.WriteLine("result : {0}", result);
        }
    }
}
