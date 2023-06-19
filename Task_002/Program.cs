// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int reversNum = 0;
while (num > 99)
{
    int digit = num % 10;
    reversNum = reversNum * 10 + digit;
    num /= 10;
   
}
// System.Console.WriteLine(reversNum);

if (reversNum / 10 > 0)
{
   int resalt = reversNum % 10;
   System.Console.WriteLine(resalt); 
}
else if (num / 100 > 0)
{
    int resalt = num % 10;
    System.Console.WriteLine(resalt);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}