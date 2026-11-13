using Tyuiu.MengAV.Sprint4.Task7.V28.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "7"},
{"{{HV}}", "28"},
{"{{TY}}", "Дана строка из одноразрядных цифр. Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел."},
{"{{TV}}", "\"623351179845632\""}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

string value = "623351179845632";
int result = ds.Calculate(5, 3, value);

Console.WriteLine($"Произведение чётных чисел: {result}");