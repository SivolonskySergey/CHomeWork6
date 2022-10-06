namespace MyLibrary
{
    class ArraysMethods
    {
        public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static void fillArray(int[] arr, string values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                arr[i] = Convert.ToInt32(values[i]);
            }
        }
    }
}