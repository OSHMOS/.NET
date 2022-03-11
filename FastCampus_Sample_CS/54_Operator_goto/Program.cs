using System;

/*------------------------
 * NAME : 54_Operator_goto
 * DESC : goto 기초, 반복문의 흐름을 제어
 -------------------------*/
namespace _Operator_goto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("{0}", i);
                if(i == 5)
                {
                    goto AA;
                }
                //Console.WriteLine("{0}", i);
                if (i == 7)
                {
                    goto BB;
                }
            }

        AA:
            Console.WriteLine("goto AA");
        BB:
            Console.WriteLine("goto BB");
        }
    }
}
