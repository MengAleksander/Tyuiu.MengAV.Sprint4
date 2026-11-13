using System.Data.Common;
using System.Text;
using Tyuiu.MengAV.Sprint4.Task5.V4.Lib;

DataServies ds = new DataServies();
Random random = new Random();

int[,] matrix = new int[5, 5];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        matrix[row, column] = random.Next(-4, 7);
    }
}

StringBuilder arrayBuilder = new StringBuilder();

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        arrayBuilder.Append($"{matrix[row, column],4}");
    }

    arrayBuilder.AppendLine();
}

string matrixText = arrayBuilder.ToString();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "5"},
{"{{HV}}", "4"},
{"{{TY}}", "Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне от -4 до 6. Найти количество положительных элементов."},
{"{{TV}}", matrixText}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int result = ds.Calculate(matrix);
Console.WriteLine($"Количество положительных элементов: {result}");