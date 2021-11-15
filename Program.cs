using System;

namespace GenereicsProblem01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 125, 265, 235, 145, 120 };
            GenericClass<int> generic = new GenericClass<int>(arr);
            generic.PrintMax();


        }
    }
}
