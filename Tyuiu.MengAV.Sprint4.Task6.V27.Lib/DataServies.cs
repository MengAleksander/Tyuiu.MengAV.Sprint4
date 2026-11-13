using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MengAV.Sprint4.Task6.V27.Lib
{
    public class DataServies : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            string[] shortElements = Array.FindAll(
                array,
                element => element.Length < 7
            );

            return shortElements.Length;
        }
    }
}
