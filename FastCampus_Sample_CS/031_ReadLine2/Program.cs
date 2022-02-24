using System;

namespace _ReadLine2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("첫 번째 정수를 입력하세요.");
            string str1 = Console.ReadLine();
            Console.Write("첫 번째 정수를 입력하세요.");
            string str2 = Console.ReadLine();

            // 무조건 형 변환!!!
            int num1 = int.Parse(str1);
            int num2 = Convert.ToInt32(str2);

            int sum = num1 + num2; // 두 수의 
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        }
    }
}
