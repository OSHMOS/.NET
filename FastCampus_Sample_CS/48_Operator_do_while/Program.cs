using System;

/*--------------------------
 * NAME : 48_Operator_do_while
 * DESC : do-while
 ---------------------------*/
namespace _Operator_do_while
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int num;
            int total = 0;

            Console.WriteLine("0부터 몇까지 더할까요?");
            num = int.Parse(Console.ReadLine());

            do
            {
                total = total + a++;
            } while (a <= num); // 세미콜론 까먹지 말기!
            // do {처음에 무조건 한 번은 이 코드가 실행}
            // 그리고 while 조건에 따라서 돌아가

            Console.WriteLine("total : {0}", total);
        }
    }
}
