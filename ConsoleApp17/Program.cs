using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //    void Swap<T>(ref T a, ref  T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
            //int c = 1;
            //int d = 2;
            //Swap<int>(ref c, ref d);
            //Console.WriteLine($"int 1 {c} int 2 {d}");

            //void TestMultiGeneric<T1,T2>(T1 first, T2 second)
            //{
            //    Console.WriteLine($"{first}, {second}");
            //}
            //TestMultiGeneric<int, string>(1, "Hello");

            //GenericClass<int> genInts = new GenericClass<int>();

            //genInts.AddList(1);
            //genInts.AddList(2);
            //genInts.AddList(3);
            //genInts.PrintItem(); 

            //Console.WriteLine("<-------->");
            //genInts.RemoveItem(2);

            //genInts.PrintItem();

            //Calculator<int> numberCompare = new Calculator<int>();
            Calculator<string> stringCompare = new Calculator<string>();

            //Console.WriteLine(numberCompare.IsEqual(1, 1));

            //Console.WriteLine(numberCompare.IsBigger(1, 2));

            //Console.WriteLine(numberCompare.IsSmaller(4, 8));

            Console.WriteLine(stringCompare.IsBigger("Hello world", "Hello"));
        }
    }
}
