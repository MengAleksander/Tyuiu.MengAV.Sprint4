using Tyuiu.MengAV.Sprint4.Task1.V1.Lib;

namespace Tyuiu.MengAV.Sprint4.Task1.V1.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void EvenNumbers()
        {
            int[] array = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };

            Assert.Equal(14, ds.Calculate(array));
        }

        [Fact]
        public void NoEvenNumbers()
        {
            int[] array = { 1, 3, 5 };

            Assert.Equal(0, ds.Calculate(array));
        }
    }
}