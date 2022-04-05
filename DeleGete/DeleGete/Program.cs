using System;
using System.Collections.Generic;

namespace DeleGete
{
    internal class Program
    {
        delegate bool Check(int num);
        delegate V Write<in T,in U,out V>(T str1,U str2);

        delegate int Topla(int num1, int num2);

        static void Main(string[] args)
        {

        
        //{
        //    Console.WriteLine(Sum(new int[] { 1, 2, 3, 4 }, n => n % 2 == 0));
            //Topla topla = new Topla(Top);
            //topla += Vur;
            //Console.WriteLine(topla(5,6));
            //Topla topla = delegate (int n, int m)
            // {
            //     return n + n;
            // };
            //topla += (n, m) => n - m;
            ////Console.WriteLine(topla(6,7));
            //Action<int, int> test = (n, m) => Console.WriteLine("test");
            //Predicate<int> test2 = n => n % 2 == 0;
            //Func<int, int,int> test3 = (n ,m) => n + m;
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(9);
                numbers.Add(13);
        numbers.Add(20);
            
       int num=     numbers.Find(n=>n>2);
            Console.WriteLine(num);
           List<int>nums= numbers.FindAll(n=>n>2);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }


        } 
        public static int Top(int a,int b)
        {
            return a + b;   
        }
        public static int Vur(int a,int b)
        {
            return a * b;
        }
        static int Sum (int[]arr,Predicate<int> func)
        {
            int result = 0;
            foreach (var item in arr)
            {
                if (func(item))
                {
                    result += item;
                }
            }
            return result;  
        }
  
    }
}