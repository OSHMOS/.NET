using System;

/*----------------------------
 * NAME : 53_Operator_continue
 * DESC : continue 기
 -----------------------------*/
namespace _Operator_continue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("i : {0}", i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                total += i;
            }

            Console.WriteLine("total : {0}", total);
        }
    }
}
