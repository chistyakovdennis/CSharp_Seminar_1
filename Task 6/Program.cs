﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: "); // Запрос на ввод числа 
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) // Делится ли число на 2 с остатком?
{
    Console.WriteLine($"Число {number} является четным."); // Остаток от деления равен нулю -> число четное       
}

else
{
    Console.WriteLine($"Число {number} является нечетным."); // Остаток от деления не равен нулю -> число нечетное    
}