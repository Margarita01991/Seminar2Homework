//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 6 -> да; 7 -> да; 1 -> нет
Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 7)

    if (N >= 6)
    {
        Console.WriteLine("да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
else
{
    Console.WriteLine("ошибка ввода");
}