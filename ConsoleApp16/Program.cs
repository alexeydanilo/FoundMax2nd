using System;


namespace MyProject
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            
            int [] array =  new int [] { 10, 1, 2, 4, 5, 24 , 11, 2, 14};

            int[] test = new int[] { 5, 200, 34, 2, 35, 68, 78, 344, 32 };

            int result =  ArraySort.FoundMax2n(array);
            
            Console.WriteLine($"Второе максимальное число в масиве: {result}");

            Console.ReadLine();
        }
        

    }
}
