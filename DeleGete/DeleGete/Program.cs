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
            Topla topla = delegate (int n, int m)
            {
                return n + m;
            };
            topla+=nu
        }
    }
}