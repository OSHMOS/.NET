using System;

/*-----------------------------------------------------------------
 * NAME : 029_Data_boxing
 * DESC : boxing, unboxing 기초(boxing하는 과정에서 heap영역에 메모리가 할당)
 ------------------------------------------------------------------*/
namespace _Data_boxing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // boxing과 unboxing은 최소화하는 게 좋다
            int i = 123;
            object o = i; // boxing - 무거움
            int j = (int)o; // unboxing - boxing보다 무거움
            i = 456;

            Console.WriteLine("i : {0}, o : {1}, j : {2}", i, o, j);
            Console.WriteLine("ReferenceEquals : {0}", Object.ReferenceEquals(i, o));
        }
    }
}
