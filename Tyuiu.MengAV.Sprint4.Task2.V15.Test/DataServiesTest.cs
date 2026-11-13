using Tyuiu.MengAV.Sprint4.Task2.V15.Lib;

namespace Tyuiu.MengAV.Sprint4.Task2.V15.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void EvenNumbers()
        {
            int[] array = { 2, 3, 4, 7, 6, 5, 2, 3, 7, 4, 5 };

            Assert.Equal(18, ds.Calculate(array));
        }

        [Fact]
        public void NoEvenNumbers()
        {
            int[] array = { 3, 5, 7 };

            Assert.Equal(0, ds.Calculate(array));
        }
    }
}