using System;

/*------------------------------------------
 * NAME : 020_Data_enum2
 * DESC : enum 데이터형 활용
 -------------------------------------------*/
namespace _Data_enum2
{
    class MainClass
    {
        enum CHAR_STATE
        {
            IDLE, // 0
            WALK, // 1
            RUN, // 2
            DIE, // 3
        }

        enum CLICK_STATE
        {
            NONE, // 0
            CLICK = 100, // 100 번호를 직접 정할 수도 있다.
            DOUBLE_CLICK = 200, // 200
            UP, // 201 이전 숫자에서 차례대로 더해진다.
        }

        public static void Main(string[] args)
        {
            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charState, (int)charState);

            charState = CHAR_STATE.RUN;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charState, (int)charState);

            charState = CHAR_STATE.DIE;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charState, (int)charState);

            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.NONE, (int)CLICK_STATE.NONE);
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.CLICK, (int)CLICK_STATE.CLICK);
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.DOUBLE_CLICK, (int)CLICK_STATE.DOUBLE_CLICK);
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.UP, (int)CLICK_STATE.UP);
        }
    }
}
