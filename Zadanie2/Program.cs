﻿int max = 0;
Console.Write("Введите первое число ");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numbersB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int numbersC = Convert.ToInt32(Console.ReadLine());
if (numbersA > max) max = numbersA;
if (numbersB > max) max = numbersB;
if (numbersC > max) max = numbersC;
Console.Write("Максимальное число ");
Console.WriteLine(max);