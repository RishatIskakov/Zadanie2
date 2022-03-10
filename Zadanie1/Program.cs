int max = 0;
int min = 0;
Console.Write("Введите первое число ");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numbersB = Convert.ToInt32(Console.ReadLine());
if (numbersA > numbersB) max = numbersA;
if (numbersA > numbersB) min = numbersB;
else
{
    max = numbersB;
    min = numbersA;
}

Console.Write("Максимальное число ");
Console.WriteLine(max);
Console.Write("Минимальное число ");
Console.WriteLine(min);