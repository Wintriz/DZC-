// Задача 2. По заданному номеру дня недели вывести его название
// Понедельк - 1, Вторник -2, Среда - 3, Четверг - 4, Пятница - 5, Суббота - 6, Воскресение - 7.
int n1 = 1;
int n2 = 2;
int n3 = 3;
int n4 = 4;
int n5 = 5;
int n6 = 6;
int n7 = 7;
Console.WriteLine("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if (num == n1)
{
    Console.WriteLine("Понедельник");
}
if (num == n2)
{
    Console.WriteLine("Вторник");
}
if (num == n3)
{
    Console.WriteLine("Среда");
}
if (num == n4)
{
    Console.WriteLine("Четверг");
}
if (num == n5)
{
    Console.WriteLine("Пятница");
}
if (num == n6)
{
    Console.WriteLine("Суббота");
}
if (num == n7)
{
    Console.WriteLine("Воскресение");
}
if (num > n7)
{
    Console.WriteLine("Нет такого дня недели, учи матчасть!");
}
if (num < n1)
{
    Console.WriteLine("Нет такого дня недели, учи матчасть!");
}