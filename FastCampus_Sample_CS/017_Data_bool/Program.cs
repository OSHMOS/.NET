using System;

/*----------------------
 * NAME : 017_Data_bool
 * DESC : bool형의 기초
 -----------------------*/
namespace _Data_bool
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*--------------------
             * bool
             * 논리 데이터 형(참과 거짓)
             * 기본값은 false
             * 조건문에 자주 사용
             ---------------------*/
            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine(isTrue);
            Console.WriteLine(isFalse);

            if (isTrue == true)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
