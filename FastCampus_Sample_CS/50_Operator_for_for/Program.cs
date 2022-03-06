using System;

/*---------------------------
 * NAME : 50_Operator_for_for
 * DESC : 중첩 for
 ----------------------------*/
namespace _Operator_for_for
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, (i * j));
                    if (j == 9) Console.WriteLine();
                }
            }
        }
    }
}
