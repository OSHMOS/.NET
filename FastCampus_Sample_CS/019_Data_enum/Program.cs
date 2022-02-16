using System;

/*------------------------------------------
 * NAME : 019_Data_enum
 * DESC : enum 데이터형 기초
 -------------------------------------------*/
namespace _Data_enum
{
    class MainClass
    {
        enum DAY_OF_WEEK
        {
            SUN, // 0
            MON, // 1
            TUE, // 2
            WED, // 3
            THU, // 4
            FRI, // 5
            SAT, // 6
        }
        // 가독성이 높다.

        public static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.MON, (int)DAY_OF_WEEK.MON);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.TUE, (int)DAY_OF_WEEK.TUE);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.WED, (int)DAY_OF_WEEK.WED);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THU, (int)DAY_OF_WEEK.THU);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.FRI, (int)DAY_OF_WEEK.FRI);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SAT, (int)DAY_OF_WEEK.SAT);
        }
    }
}
