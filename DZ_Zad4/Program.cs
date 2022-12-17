// Задача 4. Выяснить является ли число чётным
Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}
