using Tyuiu.MengAV.Sprint4.Task3.V11.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "3"},
{"{{HV}}", "11"},
{"{{TY}}", "Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 4 до 9. Подсчитайте количество нечетных элементов во всем массиве."},
{"{{TV}}", "8, 6, 9, 4, 5,\n9, 4, 8, 5, 6,\n9, 7, 9, 8, 4,\n4, 6, 5, 7, 8,\n6, 6, 7, 6, 4,"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int[,] array =
        {
            { 8, 6, 9, 4, 5 },
            { 9, 4, 8, 5, 6 },
            { 9, 7, 9, 8, 4 },
            { 4, 6, 5, 7, 8 },
            { 6, 6, 7, 6, 4 }
        };

int result = ds.Calculate(array);
Console.WriteLine($"Количество нечётных элементов: {result}");