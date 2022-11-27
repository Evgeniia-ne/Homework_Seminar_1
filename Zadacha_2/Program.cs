Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
{
if (number1>number2)
   {
        Console.WriteLine ($"Максимальное число {number1}, минимальное число {number2}");
    }
else
    {
    Console.WriteLine ($"Максимальное число {number2}, минимальное число {number1}");
    }
}