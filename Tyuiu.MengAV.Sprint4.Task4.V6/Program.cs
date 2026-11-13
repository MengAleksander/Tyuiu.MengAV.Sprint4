using Tyuiu.MengAV.Sprint4.Task4.V6.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "4"},
{"{{HV}}", "6"},
{"{{TY}}", "Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры в диапазоне от 4 до 9. Заменить нечетные элементы массива на 0."},
{"{{TV}}", "7, 6, 6, 6, 9,\n4, 4, 4, 9, 4,\n5, 5, 5, 6, 5,\n4, 9, 5, 9, 7,\n6, 9, 5, 6, 7,"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int[,] matrix =
        {
            { 7, 6, 6, 6, 9 },
            { 4, 4, 4, 9, 4 },
            { 5, 5, 5, 6, 5 },
            { 4, 9, 5, 9, 7 },
            { 6, 9, 5, 6, 7 }
        };

int[,] result = ds.Calculate(matrix);

for (int row = 0; row < result.GetLength(0); row++)
{
    for (int column = 0; column < result.GetLength(1); column++)
    {
        Console.Write(result[row, column] + ", ");
    }

    Console.WriteLine();
}