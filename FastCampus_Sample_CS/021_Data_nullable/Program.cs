using System;

/*------------------------------------------
 * NAME : 021_Data_nullable
 * DESC : nullable 데이터형 활용
 -------------------------------------------*/
namespace _Data_nullable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double? a = 3.14;
            char? b = 'a';

            int num = 10;
            int? c = num;

            bool? isFlag = null;

            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}", b);
            Console.WriteLine("c : {0}", c);

            Console.WriteLine("isFlag : {0}", isFlag);
            Console.WriteLine("isFlag HasValue : {0}", isFlag.HasValue);

            if (isFlag.HasValue) // 값을 참조하려면 반드시 null인지 체크해야 한다.
            {
                Console.WriteLine("isFlag HasValue : {0}", isFlag.Value);
            } // null값을 강제로 사용할려고 하면 오류가 난다.
        }
    }
}
