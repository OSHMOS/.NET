using System;

/*--------------------------------------
 * NAME : 49_Operator_for
 * DESC : for문
 ---------------------------------------*/
namespace _Operator_for
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int total = 0;

            for (int i = 0; i <= 10; i++)
            {
                total += i;
            }

            Console.WriteLine("total : {0}", total);
        }
    }
}
