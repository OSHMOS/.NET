using System;

/*--------------------------------
 * NAME : 009_Data1
 * DESC : 정수 데이터 형의 최소 최대..
 ----------------------------------*/
namespace _Data2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("short min : {0} ~ short max : {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("byte min : {0} ~ byte max : {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("int min : {0} ~ int max : {1}", int.MinValue, int.MaxValue);
        }
    }
}
