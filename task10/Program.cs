//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 456 -> 5; 782 -> 8; 918 -> 1
Console.Clear();
int number = new Random().Next(99, 1000);
int digit = number/10;

Console.WriteLine($"Число {number} Вторая цифра:{digit%10}");
