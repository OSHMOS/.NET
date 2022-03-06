using System;

/*--------------------------
 * NAME : 47_Operator_while
 * DESC : while 기초
 ---------------------------*/
namespace _Operator_while
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int total = 0;
            int total2 = 0;

            while(a <= 10 || b <= 10)
            {
                total = total + a++; // 1~10
                total2 = total + ++b; // 1~11
                // 전치연산과 후치연산의 차이를 볼 수 있음
            }

            Console.WriteLine("total : {0}", total);
            Console.WriteLine("total2 : {0}", total2);
        }
    }
}
