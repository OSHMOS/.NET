using System;

/*---------------------------------------------
 * NAME : 036_Operator3
 * DESC : 산술 연산자 : ++, -- (자기 자신의 값을 바꾼다)
 ----------------------------------------------*/
namespace _Operator3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("num : {0}", num++); // 후치 연산
            Console.WriteLine("num : {0}", num);
            Console.WriteLine("num : {0}", ++num); // 전치 연산

            Console.WriteLine("num : {0}", num--); // 후치 연산
            Console.WriteLine("num : {0}", num);
            Console.WriteLine("num : {0}", --num); // 전치 연산
        }
    }
}
