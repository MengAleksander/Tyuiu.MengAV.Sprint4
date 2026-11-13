using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MengAV.Sprint4.Task1.V1.Lib
{
    public class DataServies : ISprint4Task1V1
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    sum += element;
                }
            }

            return sum;
        }
    }
}
