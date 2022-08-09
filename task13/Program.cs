// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (number > 0)

  if (numberText.Length > 2)
  {
   Console.WriteLine("третья цифра -> " + numberText[2]);
  }
  else 
  {
    Console.WriteLine("-> третьей цифры нет");
  }
else
{
  if (numberText.Length > 2)
  {
   Console.WriteLine("третья цифра -> " + numberText[3]);
  }
  else 
  {
    Console.WriteLine("-> третьей цифры нет");
  }
}
