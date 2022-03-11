using System;

/*-------------------------------------
 * NAME : 44_Operator_Branch3
 * DESC : 조건문에 &&, || 연산자 이용하기 기초
 --------------------------------------*/
namespace _Operator_Branch3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool isA = false;
            bool isB = true;
            bool isC = true;
            bool isD = false;

            if(isA && isB) // false && true => false
            {
                Console.WriteLine("false && true => false"); // X
            }

            if(isB && isC) // true && true => true
            {
                Console.WriteLine("true && true => true"); // O
            }

            if(isC || isD) // true || flase => true
            {
                Console.WriteLine("true || false => true"); // O
            }

            if(2 > 1 && 3 < 4 || 1 > 2) //=>(true && true) => true || false => true
            {
                Console.WriteLine("true && false || false => true"); // O
            }
        }
    }
}
