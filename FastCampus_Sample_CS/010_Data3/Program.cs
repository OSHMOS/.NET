using System;
/*-----------------------------
 * NAME : 010_Data3
 * DESC : 데이터 형태 오류
 -------------------------------*/
namespace _Data3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 데이터 형식의 오류
            byte byteData = 255;
            sbyte sbyteData = (sbyte)byteData; // 캐스트 연산 오류

            Console.WriteLine("byteData : {0}", byteData);
            Console.WriteLine("sbyteData : {0}", sbyteData);
            Console.WriteLine("sbyte.max : {0}", sbyte.MaxValue);
        }
    }
}
