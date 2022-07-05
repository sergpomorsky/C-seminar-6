// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел M");
int M = Convert.ToInt32(Console.ReadLine());
int[]array = new int [M];
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите {i+1}-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
for(int i = 0; i < array.Length; i++)
if (array[i] > 0)
{
    sum = sum + 1;
}
Console.WriteLine($"Чисел больше 0 = {sum}");
