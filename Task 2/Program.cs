// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите первое число: "); // Запрос первого числа
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: "); // Запрос второго числа
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) // Постановка базового условия 
{
    Console.WriteLine("Максимальное число: " + a);
    Console.WriteLine("Минимальное число: " + b);
}
else if (b > a) // Ветвление
{
    Console.WriteLine("Максимальное число: " + b);
    Console.WriteLine("Минимальное число: " + a);
}
else // Если оба введенных числа равны
{
    Console.WriteLine("Введенные числа равны.");
}
