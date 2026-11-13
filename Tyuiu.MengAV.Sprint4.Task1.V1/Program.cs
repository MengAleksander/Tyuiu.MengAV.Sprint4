using Tyuiu.MengAV.Sprint4.Task1.V1.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "1"},
{"{{HV}}", "1"},
{"{{TY}}", "Дан одномерный целочисленный массив на 10 элементов заполненный значениями с клавиатуры в диапазоне от 0 до 9 подсчитать сумму четных элементов массива."},
{"{{TV}}", "{8, 2, 7, 5, 0, 7, 4, 7, 5, 7}"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int[] array = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int result = ds.Calculate(array);
Console.WriteLine($"Сумма чётных элементов: {result}");