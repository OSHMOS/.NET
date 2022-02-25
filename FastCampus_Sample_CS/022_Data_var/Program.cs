using System;

/*------------------------------------------
 * NAME : 022_Data_var
 * DESC : var 데이터형 활용
 -------------------------------------------*/
namespace _Data_var
{
    class MainClass
    {
        // 불가 : 반드시 지역변수만 사용
         //var globaleVar = 100;

        public static void Main(string[] args)
        {
            var a = 100;
            var b = 3.1415926535897932384626433832f;
            var c = 3.1415926535897932384626433832m;
            var d = 'H';
            var e = 'i';
            var f = "World!";
            var g = false;

            Console.WriteLine("type : {0}, a : {1}", a.GetType(), a);
            Console.WriteLine("type : {0}, b : {1}", b.GetType(), b);
            Console.WriteLine("type : {0}, c : {1}", c.GetType(), c);
            Console.WriteLine("type : {0}, d : {1}", d.GetType(), d);
            // 공용으로 알아보기 위해서 만든 형식으로 나올텐데 우리가 아는 형식과 같다.

            Console.WriteLine("{0}{1} {2}", d, e, f);

            // 불가 :  반드시 선언과 동시에 초기화
            // var noInitialVar;

            var num = 0;
            num = 100;

            Console.WriteLine("num : {0}", num);

            // var은 for ~ each문에서 주로 쓰인다.
            // 반복문에서 계속
            
        }
    }
}
