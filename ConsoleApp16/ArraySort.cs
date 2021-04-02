

namespace MyProject
{
    public class ArraySort
    {
        public static int FoundMax2n(int[] array)
        {
            int max = 0;
            int secondmax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    secondmax = max;
                    max = array[i];
                }
                if (array[i] > secondmax && array[i] < max)
                {
                    secondmax = array[i];
                }

            }
            return secondmax;
        }
    }
}

