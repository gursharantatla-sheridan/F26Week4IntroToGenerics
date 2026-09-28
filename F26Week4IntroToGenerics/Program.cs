namespace F26Week4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing / unboxing

            int i = 5;
            object o = i;  // boxing
            i = (int)o;    // unboxing

            //string s = "hello";
            //o = s;
            //i = (int)o;

            //if (AreEqual(5.5, "hello"))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");


            int[] intArr = { 2, 3, 4, 5 };
            double[] doubleArr = { 2.2, 3.3, 4.4, 5.5 };
            char[] charArr = { 'h', 'e', 'l', 'l', 'o' };

            Console.WriteLine("\n\nint array:");
            PrintArray<int>(intArr);

            Console.WriteLine("\n\ndouble array:");
            PrintArray<double>(doubleArr);

            Console.WriteLine("\n\nchar array:");
            PrintArray<char>(charArr);
        }


        static void PrintArray<T>(T[] arr)
        {
            foreach (T i in arr)
                Console.Write(i + " ");
            Console.WriteLine("\n");
        }




        // non-generic method
        static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }

        // generic method
        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
