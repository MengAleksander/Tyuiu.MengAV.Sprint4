using Tyuiu.MengAV.Sprint4.Task6.V27.Lib;

namespace Tyuiu.MengAV.Sprint4.Task6.V27.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void CountShortElements()
        {
            string[] array = { "Квадрат", "Круг", "Треугольник" };

            Assert.Equal(1, ds.Calculate(array));
        }

        [Fact]
        public void NoShortElements()
        {
            string[] array = { "Квадрат", "Треугольник" };

            Assert.Equal(0, ds.Calculate(array));
        }
    }
}