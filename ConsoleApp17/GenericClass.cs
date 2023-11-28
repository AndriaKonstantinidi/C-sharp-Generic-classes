using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class GenericClass<T>
    {
        public List<T> myList;


        public GenericClass()
        {
            myList = new List<T>();
        }

        public void AddList(T item)
        {
            myList.Add(item);
        }

        public void PrintItem(T item)
        {
            Console.WriteLine(item);
        }
        public void RemoveItem(T item)
        {
            if (myList.Contains(item))
            {
                myList.Remove(item);
            }
        }
    }
}
