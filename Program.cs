using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_c__advanced
{
    internal class employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public int CompareTo(object? obj)
        {
            //employee? passedemployee = (employee?)obj;
            employee? passedemployee = obj as employee;
            return this.Salary.CompareTo(passedemployee?.Salary);
        }
        public override string ToString()
        {
            return $"id = {Id} name = {Name} salary = {Salary}";
        }
    }




    public static void swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }

    public static void search<T>(T x, ref T[] arr)
    {
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(x))
            {
                index = i; break;
            }
        }
        Console.WriteLine($" {x} is index number {index}");

    }

    public static void bubble_sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - j - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) == 1)
                {
                    swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }
}










internal class generics<T> where T : IComparable
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void search<T>(T x, ref T[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(x))
                {
                    index = i; break;
                }
            }
            Console.WriteLine($" {x} is index number {index}");

        }

        public static void bubble_sort(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - j - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) == 1)
                    {
                        swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
    }
}
