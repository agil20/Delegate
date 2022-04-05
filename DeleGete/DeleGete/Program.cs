using System;

namespace DeleGete
{
    internal class Program
    {
        delegate bool Check(int num);
        delegate void Write(string str1);
        delegate int Topla(int num1, int num2);

        static void Main(string[] args)
        {
            //Topla topla = new Topla(Top);
            //topla += Vur;
            //Console.WriteLine(topla(5,6));
            Topla topla = delegate (int n, int m)
             {
                 return n + n;
             };
            topla += (n, m) => n - m;
           
        } public static int Top(int a,int b)
        {
            return a + b;   
        }
        public static int Vur(int a,int b)
        {
            return a * b;
        }
    }
}