//InsertArray methodu yaradılır. Method parametr olaraq int tipindən array və params olaraq int-lər qəbul edir.
// Paramslardan gələn dəyərləri həmin arraya əlavə etsin və sonda dəyişilmiş hal köhnə arraya bərabər olsun
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4 };
            InsertArray(5,6,ref array);
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
        static void InsertArray(int num1 , int num2 ,ref int[] array)
        {
            int[] copy = new int[array.Length+2];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            if (copy[array.Length] == default(int) && copy[array.Length + 1] == default(int))
            {
                copy[array.Length] = num1;
                copy[array.Length+1] = num2;
            }
            array = copy;
        }
    }
}