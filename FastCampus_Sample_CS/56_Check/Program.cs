using System;

namespace _Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int cnt = 0;
            for (; ;)
            {
                Console.Write("0~99사이 어떤 숫자일까요(단, 0은 나가기)");
                int num = int.Parse(Console.ReadLine());
                cnt += 1;

                if (num == 0)
                {
                    break;
                }
                else if (num > a)
                {
                    Console.WriteLine("입력한 수는 커요");
                }
                else if (num < a)
                {
                    Console.WriteLine("입력한 수는 작아요");
                }
                else
                {
                    Console.WriteLine("=== 정답입니다. ===");
                    Console.WriteLine("총 {0}번 시도", cnt);
                }
            }
            
        }
    }
}
