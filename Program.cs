// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// а= 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int max = 0;
int min = 0;
Console.WriteLine("Введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое цисло");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
max = numberA;
min = numberB;
}
else
{
min = numberA;
max = numberB;
}
Console.WriteLine($"Наименьшее число {min}, наибольшее число {max}");

