using System;

/*----------------------------------
 * NAME : 52_Operator_break
 * DESC : break 키워드는 중간에 끝내는 것을 의미
 -----------------------------------*/
namespace _Operator_break
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int inputNum = 0;

            while(true) // for(;;)
            {
                Console.WriteLine("(1) 구구단 중 몇 단? (2)나가기(0번 입력)");
                inputNum = int.Parse(Console.ReadLine());

                if (inputNum == 0)
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", inputNum, i, (inputNum * i));
                }
            }
        }
    }
}
