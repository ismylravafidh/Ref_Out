//Ədədlərdən ibarət arrayın ən kiçik və ən böyük elementinin yerini dəyişən method yazın.
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayMinToMax(2, 3, 1, 4, 5, 19, 6, 22, 10);
        }
        static void ArrayMinToMax(params  int[] array)
        {
            int MinValue = array[0];
            int MaxValue = array[0];
            int MinValueIndex = 0;
            int MaxValueIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < MinValue)
                {
                    MinValue = array[i];
                    MinValueIndex = i;
                }
                if (array[i] > MaxValue)
                {
                    MaxValue = array[i];
                    MaxValueIndex = i;
                }
            }
            for (int i = 0;i < array.Length; i++)
            {
                array[MinValueIndex] = MaxValue;
                array[MaxValueIndex] = MinValue;
                Console.WriteLine(array[i]);
            }
        }
    }
}