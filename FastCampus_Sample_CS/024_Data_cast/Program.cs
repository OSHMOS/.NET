using System;

/*------------------------
 * NAME : 024_Data_cast
 * DESC : cast 연산자( ) 기초 
-------------------------*/
namespace _Data_cast
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*--------------------------------------------
             * 형 변환
             * 데이터의 형식을 변경(정수->실수, 문자열->기본 데이터형)
             * 캐스트 연산자 : '()'
             * ToString()
             * Parse()
             * Convert.~
             ---------------------------------------------*/
            int num = 100;
            double dNum = (double)num; // cast 연산하지 않아도 됨
            Console.WriteLine("num : {0}, dNum: {1}", num, dNum);

            double dNum2 = 12345678912;
            int num2 = (int)dNum2; // 큰 데이터형을 작은 데이터로 변경 시 주의!!!
            Console.WriteLine("dNum2: {0}, num2 : {1}", dNum2, num2);
        }
    }
}
