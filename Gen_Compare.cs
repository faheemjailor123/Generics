using System;

namespace GenereicsProblem01
{
    class Program
    {
        static void Main(string[] args)
        {
            

            GenericClass<int> myObj= new GenericClass<int>(20, 35,55);
            GenericClass<double> myObj1 = new GenericClass<double>(55.265, 35.0, 55.256);
            GenericClass<string> myObj2 = new GenericClass<string>("abc","xyz","pqr");

            Console.WriteLine(myObj.MaxValue());
            Console.WriteLine(myObj1.MaxValue());
            Console.WriteLine(myObj2.MaxValue());

        }
    }
}
