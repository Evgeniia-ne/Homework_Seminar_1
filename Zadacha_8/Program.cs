Console.Clear();
Console.Write("Введите целое число: ");
int count = 2;
int number = int.Parse(Console.ReadLine());
while (count<number)
{
    Console.Write ($"{count} ,");
    count = count+2;
}
Console.Write ($"{number}");