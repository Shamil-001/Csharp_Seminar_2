﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру: ");
int dig = Convert.ToInt32 (Console.ReadLine());

if (dig == 6 || dig == 7)
{
    System.Console.WriteLine("Да");
}
else if (dig > 7 || dig == 0)
{
    System.Console.WriteLine("Такого дня недели не сущестует");
}
else 
{
    System.Console.WriteLine("Нет");
}