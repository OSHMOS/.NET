using System;

/*---------------------------
 * NAME : 014_Data7
 * DESC : char형, string형 기초
 ----------------------------*/
namespace _Data7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // char(' ')
            char a = 'H';
            char b = 'e';
            char c = 'l';
            char d = 'l';
            char e = 'o';

            // string(" ")
            // 문자가 모여있는 (열)
            string str = "World";

            Console.Write("\0");
            Console.WriteLine("{0}{1}{2}{3}{4} {5}", a, b, c, d, e, str);
            Console.WriteLine('\0');
        }
    }
}
