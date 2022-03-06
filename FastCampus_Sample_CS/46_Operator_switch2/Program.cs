using System;

/*--------------------------------------
 * NAME : 46_Operator_switch
 * DESC : enum데이터 선언 후 switch문 사용하기
 ---------------------------------------*/
namespace _Operator_switch2
{
    class MainClass
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            TUE,
            WED,
            THU,
            FRI,
            SAT,
        }

        public static void Main(string[] args)
        {
            DAY_OF_WEEK dayOfWeek = DAY_OF_WEEK.FRI;
            string dayString = "";

            switch (dayOfWeek)
            {
                case DAY_OF_WEEK.SUN:
                    dayString = "일";
                    break;
                case DAY_OF_WEEK.MON:
                    dayString = "월";
                    break;
                case DAY_OF_WEEK.TUE:
                    dayString = "화";
                    break;
                case DAY_OF_WEEK.WED:
                    dayString = "수";
                    break;
                case DAY_OF_WEEK.THU:
                    dayString = "목";
                    break;
                case DAY_OF_WEEK.FRI:
                    dayString = "금";
                    break;
                case DAY_OF_WEEK.SAT:
                    dayString = "토";
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0}요일입니다.", dayString);
            // 빨간 줄 겁나 많은데 실행은 또 잘 됨 ?!?
        }
    }
}
