using Tyuiu.MengAV.Sprint4.Task0.V7.Lib;

namespace Tyuiu.MengAV.Sprint4.Task0.V7.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void OddNumbers()
        {
            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            Assert.Equal(178605, ds.GetMultOddArrEl(array));
        }

        [Fact]
        public void NoOddNumbers()
        {
            int[] array = { 2, 4, 6 };

            Assert.Equal(1, ds.GetMultOddArrEl(array));
        }
    }
}