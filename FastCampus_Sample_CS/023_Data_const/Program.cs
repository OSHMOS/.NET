using System;

/*-----------------------------------
 * NAME : 023_Data_const
 * DESC : const 데이터형 기초 
 ------------------------------------*/
namespace _Data_const
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 일반적으로 상수는 대문자로 쓴다.
            const int MIN = 0;
            const int MAX = 100;

            Console.WriteLine("MIN : {0} ~ MAX : {1}", MIN, MAX);

            // MAX = 1000; // 오류(프로그램 중간에 변경 불가)
            // 상수의 장점 : 코드를 고칠 때 한 부분만 고치면 돼서 편하다.
        }
    }
}
