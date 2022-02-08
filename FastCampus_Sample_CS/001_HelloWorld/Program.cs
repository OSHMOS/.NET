using System;
// 선언된 네임스페이스 내부 개체들에 접근

namespace _HelloWorld // 그룹, 동일한 함수 이름 사용 가능
{
    class MainClass // 필드, 메소드로 분리, 프로그램을 구성하는 기본
    {
        public static void Main(string[] args)
        /*---------------------------
         * 가장 중요한 메소드
         * 최초의 진입(Entry Point)
         * 메인 메소드가 반드시 존재
         -----------------------------*/
        {
            Console.WriteLine("Hello World!");
        }
    }
}
/* -----------------------------
 * Name : _001_HelloWorld
 * DESC : 코드 리뷰
 --------------------------------*/
