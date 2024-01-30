namespace Mean_Square_Error
{
    internal class Program
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            return firstArray.Zip(secondArray, (a, b) => (a - b) * (a - b))
                     .Average();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solution(new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }));
        }
    }
}