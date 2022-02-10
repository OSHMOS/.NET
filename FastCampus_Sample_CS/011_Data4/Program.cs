using System;

/*-------------------------------------------------------
 * NAME : 011_Data4
 * DESC : 2진수 리터럴 접두사 0b(0B), 16진수 리터럴 접두사 0x(0X)
 --------------------------------------------------------*/
namespace _Data4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 0b11111111; // 2진수 리터럴 접두사 0b 0B
            int b = 0xFF; // 16진수 리터럴 접두사 0x 0X
            int num = 255;

            Console.WriteLine("a : {0}",a);
            Console.WriteLine("b : {0}", b);
            Console.WriteLine("num : {0}", num);
        }
    }
}
