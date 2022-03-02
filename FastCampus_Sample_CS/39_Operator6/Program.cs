using System;

/*--------------------
 * NAME : 39_Operator6
 * DESC : 조건 연산자
 * 삼항 연산자 ('? :')
 ---------------------*/
namespace _Operator6
{
    // 복합적으로 사용하는 것은 추천하지 않는다.
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 0;
            bool result;

            result = (num == 0) ? true : false;
            Console.WriteLine("num : {0}", num);
            Console.WriteLine("(num == 0) ? true : false : {0}", result);

            result = (num > 10) ? true : false;
            Console.WriteLine("(num > 10) ? true : false : {0}", result);
        }
    }
}
