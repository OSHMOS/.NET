using System;

/*------------------------------------------------------------
 * NAME : 033_Check
 * DESC : 국어, 영어, 수학, 과학 4과목 점수를 입력 받고, 총점과 평균 보여주기
 -------------------------------------------------------------*/
namespace _Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("국어 점수 입력하세요.");
            string kg = Console.ReadLine();
            Console.Write("영어 점수 입력하세요.");
            string eg = Console.ReadLine();
            Console.Write("수학 점수 입력하세요.");
            string mg = Console.ReadLine();
            Console.Write("과학 점수 입력하세요.");
            string sg = Console.ReadLine();

            int sum = int.Parse(kg) + int.Parse(eg) + int.Parse(mg) + int.Parse(sg);
            // float avg = sum / 4;
            float fSum = Convert.ToSingle(sum);
            float avg = fSum / 4;

            Console.WriteLine("국어 : {0} 영어 : {1} 수학 : {2} 과학 : {3}", kg, eg, mg, sg);
            Console.WriteLine("총점 : {0} 평균 : {1}", sum, avg);
        }
    }
}
