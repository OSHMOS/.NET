using System;

/*-----------------------------------------------------
 * NAME : 013_Data6
 * DESC : 부동 소수점 데이터형의 기초, 리터럴 접미사(f(F), m(M))
 ------------------------------------------------------*/
namespace _Data6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float a = 3.1415926535897932384626433832f;
            Console.WriteLine("a: {0}", a);

            double b = 3.1415926535897932384626433832;
            Console.WriteLine("b: {0}", b);

            decimal c = 3.1415926535897932384626433832m;
            Console.WriteLine("c: {0}", c);
        }
    }
}
