// Задача 43. Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями        k1     b1        k2      b2
// y = k1 * x + b1, y = k2 * x + b2;    y = a * x + с    y = b * x + d
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите значение b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
Console.WriteLine($"y = {y1} ; {y2}");