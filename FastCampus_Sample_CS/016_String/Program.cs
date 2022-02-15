using System;

/*-------------------------------------------
 * NAME : 016_String
 * DESC : 문자열 제어
 --------------------------------------------*/
namespace _String
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str1 = "abcdefg";
            string str2 = "hjklmn";
            string str3 = str1 + str2;
            Console.WriteLine("str1 + str2 : {0}", str3);

            string str4 = "zzz";
            string str5 = "zzz";
            Console.WriteLine("str4 == str5 : {0}", (str4 == str5));

            int x = 10;
            string str6 = str5 + " " + ":" + x;
            Console.WriteLine("str6: {0}", str6);

            string str7 = "Hello World!";
            string str8 = str7.Replace("Hello", "Hi");
            Console.WriteLine("str8 : {0}", str8);

            Console.WriteLine("str8.ToUpper() : {0}", str8.ToUpper());
            Console.WriteLine("str8.ToLower() : {0}", str8.ToLower());
        }
    }
}
