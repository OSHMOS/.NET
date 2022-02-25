using System;

/*--------------------------------------------------
 * NAME : 028_Data_Reference
 * DESC : Reference 참조 기초(두 개의 값이 서로 영향을 준다.)
 ---------------------------------------------------*/
namespace _Data_reference
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 값 형식, 모든 수치 형태
            int num = 100;
            int refNum = num;
            refNum = 1000;

            Console.WriteLine("refStr : {0}, ReferenceEquals : {1}", num, Object.ReferenceEquals(num, refNum));

            // 참조형(Reference), 값을 저장하는 것이 아닌 주소를 참조
            int[] arrNum = { 100, 200 };
            int[] refArrNum = arrNum;
            refArrNum[0] = 1000;

            Console.WriteLine("refStr : {0}, ReferenceEquals : {1}", arrNum[0], Object.ReferenceEquals(refArrNum, arrNum));
        }
    }
}
