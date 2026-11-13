using Tyuiu.MengAV.Sprint4.Task0.V7.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "0"},
{"{{HV}}", "7"},
{"{{TY}}", "Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчитать произведение нечетных элементов массива."},
{"{{TV}}", "{9, 8, 7, 9, 5, 4, 3, 2, 3, 7}"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

int result = ds.GetMultOddArrEl(array);
Console.WriteLine($"Произведение нечётных элементов: {result}");