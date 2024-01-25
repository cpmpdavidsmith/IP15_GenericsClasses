using System;
using System.Collections.Generic;

namespace Demo
{
    //Generic Class
    public class GenericClass<T>
    {
        private T[] array;
        public GenericClass(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }

    }
    class Program
    {
        //The main function
        static void Main(string[] args)
        {
            GenericClass<int> gn = new GenericClass<int>(3);
            gn.setItem(1, 1);
            gn.setItem(2, 2);
            gn.setItem(3, 3);

            Console.WriteLine("Item number one is " + gn.getItem(1));
            Console.WriteLine("Item number two " + gn.getItem(2));
            Console.WriteLine("Item number three " + gn.getItem(3));

            GenericClass<string> gn1 = new GenericClass<string>(1);
            gn1.setItem(1, "cookie");

            Console.WriteLine("Item number 1 is " + gn1.getItem(1));

            Console.Read();
        }
    }

}