namespace Assignment_11
{
    internal class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            return;
        }
        public static void BubbleSort<T>(ref T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool sorted = true;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    return;
                }
            }
        }
        static void Main(string[] args)
        {

            #region (1)
            //int[] arr = { 10, 7, 6, 8, 9, 1, 2, 5, 4, 3 };
            //BubbleSort(ref arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region (2)
            //MyClass min = new MyClass(4);
            //MyClass max = new MyClass(10);
            //Range<MyClass> range = new Range<MyClass>(min , max);
            //Console.WriteLine(range.IsInRange(new MyClass(1)));
            //Console.WriteLine(range.IsInRange(new MyClass(6)));
            //Console.WriteLine(range.IsInRange(new MyClass(12)));
            //Console.WriteLine(range.Length());
            #endregion

        }
    }
}
