using System;

/*-------------------------
 * NAME : 025_Data_ToString
 * DESC : ToString 기초
 --------------------------*/
namespace _Data_ToString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141593f;
            decimal c = 3.1415926535897932384626433832m;

            string strA = a.ToString(); // "100"
            string strB = b.ToString(); // "3.141593"
            string strC = c.ToString(); // "3.1415926535897932384626433832"

            Console.WriteLine("a.ToString() : {0}", strA);
            Console.WriteLine("b.ToString() : {0}", strB);
            Console.WriteLine("c.ToString() : {0}", strC);
        }
    }
}
