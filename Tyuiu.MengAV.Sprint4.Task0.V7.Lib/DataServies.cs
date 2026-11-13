using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MengAV.Sprint4.Task0.V7.Lib
{
    public class DataServies : ISprint4Task0V7
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;

            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    product *= element;
                }
            }

            return product;
        }
    }
}
