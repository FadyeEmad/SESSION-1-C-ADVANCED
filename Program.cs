using demo_c__advanced;
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
#region ex swap
//int x = 20;
//int y = 30;
//Console.WriteLine(x);
//Console.WriteLine(y);
//generics<int>.swap(ref x, ref y);
//Console.WriteLine("after swap");
//Console.WriteLine(x);
//Console.WriteLine(y);
#endregion

#region ex search arr
//int[] arr = { 5, 8, 3, 4, 1, 99, 14, 13, 60, 77 };
//generics<int>.search(3, ref arr);
//generics<int>.bubble_sort(arr);
//foreach (int item in arr)
//    Console.WriteLine(item);
//Console.WriteLine("-------------");
////-------------------------------
//employee[] arr2 = new employee[]
//{
//    new employee(){Id  = 1 , Name = "fady" , Salary = 5000},
//    new employee(){Id  = 2 , Name = "hady" , Salary = 8000},
//    new employee(){Id  = 3 , Name = "hamed" , Salary = 10000},
//    new employee(){Id  = 4 , Name = "adel" , Salary = 7000},
//};
//generics<employee>.bubble_sort(arr2);
//foreach (employee item2 in arr2)
//    Console.WriteLine(item2);

#endregion

