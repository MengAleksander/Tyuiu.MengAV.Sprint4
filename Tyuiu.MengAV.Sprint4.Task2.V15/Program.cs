using Tyuiu.MengAV.Sprint4.Task2.V15.Lib;

DataServies ds = new DataServies();
Random random = new Random();

int[] array = new int[11];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(2, 8);
}

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "2"},
{"{{HV}}", "15"},
{"{{TY}}", "Дан одномерный целочисленный массив на 11 элементов заполненный случайными в диапазоне от 2 до 7 подсчитать сумму четных элементов массива."},
{"{{TV}}", string.Join(", ", array)}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int result = ds.Calculate(array);
Console.WriteLine($"Сумма чётных элементов: {result}");