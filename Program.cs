#region Q1
//by usinng generics
internal class generics<T> where T : IComparable
{
    public static void swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
    public static void bubble_sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[i + 1]) == 1)
                {
                    swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }
}
#endregion

#region Q2
internal class Range<T> where T : IComparable<T>
{
    public T MAX { get; set; }
    public T MIN { get; set; }
    public Range(T maximum, T minimum)
    {
        MAX = maximum;
        MIN = minimum;
    }
    public bool inrange(T num)
    {
        return num.CompareTo(MIN) >= 0 && num.CompareTo(MAX) <= 0;
    }
    public T Lenght()
    {
        dynamic max1 = MAX;
        dynamic min1 = MIN;
        return max1 - min1;
    }
}
#endregion
