using System;

namespace _Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int minGrade = 0;
            int maxGrade = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요 : ");
                int grade = int.Parse(Console.ReadLine());
                minGrade = grade;

                if (grade > maxGrade)
                {
                    maxGrade = grade;
                }
                else if (grade < minGrade)
                {
                    minGrade = grade;
                }
            }

            Console.WriteLine("최대값 : {0} 최소값 : {1}", maxGrade, minGrade);
        }
    }
}
