using System;

namespace _ReadLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요.");
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);

            Console.WriteLine("입력한 수는 : {0}", num);
        }
    }
}
