﻿using System;

/*----------------------------------------------
 * NAME : 012_Data5
 * DESC : 소수점 데이터 형의 최소 최대값..
 ------------------------------------------------*/
namespace _Data5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("float min : {0} ~ float max : {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double min : {0} ~ double max : {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal min : {0} ~ decimal max : {1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
