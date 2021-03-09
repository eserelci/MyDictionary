using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Sehirler = new List<string>();
            Sehirler.Add("Ankara");
            Console.WriteLine(Sehirler.Count);
            MyList<string> Sehirler2 = new MyList<string>();
            Sehirler2.Add("Ankara");
            Console.WriteLine(Sehirler2.Count);
        }
        class MyList<T>//Generic Class
        {
            T[] Array;
            T[] TempArray;
            public MyList()
            {
                Array = new T[0];
            }
            public void Add(T item)
            {
                TempArray = Array;               
                Array = new T[Array.Length + 1];
                for (int i = 0; i < TempArray.Length; i++)
                {
                    Array[i] = TempArray[i];
                }
                Array[Array.Length -1] = item;
            }
            public int Count
            {
                get { return Array.Length; }
            }
        }
    }
}
