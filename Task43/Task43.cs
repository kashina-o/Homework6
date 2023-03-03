//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double k1 = Input("Введите k1: ");
double b1 = Input("Введите b1: ");
double k2 = Input("Введите k2: ");
double b2 = Input("Введите b2: ");
double x = 0;
double y = 0;

if(k1 == k2 && b1 == b2)
{
Console.WriteLine("Прямые совпадают");
}
else 
{
    if (k1 == k2)
    Console.WriteLine("Прямые параллельны");
    else
    x = (b1 - b2) / (k2 - k1);
    y = k2 * x + b2;
}
Console.WriteLine($"Точка пересечения: ({x};{y})");
