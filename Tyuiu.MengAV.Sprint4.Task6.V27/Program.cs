using Tyuiu.MengAV.Sprint4.Task6.V27.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "6"},
{"{{HV}}", "27"},
{"{{TY}}", "Дан строковый массив данных используя класс Array подсчитайте количество элементов, длина которых меньше 7."},
{"{{TV}}", "[\"Квадрат\", \"Прямоугольник\", \"Круг\", \"Треугольник\", \"Пятиугольник\", \"Шестиугольник\", \"Восьмиугольник\"]"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

string[] array =
        {
            "Квадрат",
            "Прямоугольник",
            "Круг",
            "Треугольник",
            "Пятиугольник",
            "Шестиугольник",
            "Восьмиугольник"
        };

int result = ds.Calculate(array);
Console.WriteLine($"Количество элементов длиной меньше 7: {result}");