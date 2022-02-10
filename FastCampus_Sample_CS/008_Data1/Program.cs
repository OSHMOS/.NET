using System;

/*---------------------------
 * NAME : 008_Data1
 * DESC : 정수형 데이터 형태 기초
 ----------------------------*/
namespace _Data1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            sbyte a = 120;
            byte b = 255;
            short c = 30000;
            long d = 1000000000000000;
            ulong f = 100000000000000000;
            int num = 100;

            Console.WriteLine("sbyte a : {0}", a);
            Console.WriteLine("byte b : {0}", b);
            Console.WriteLine("short c : {0}", c);
            Console.WriteLine("long d : {0}", d);
            Console.WriteLine("ulong f : {0}", f);
            Console.WriteLine("int num : {0}", num);
        }
    }
}
