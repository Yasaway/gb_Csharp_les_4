﻿// Задача 29. Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Программа выгружает массив из 8 цифр ");
int[] array = new int[8];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    int xrand = rnd.Next(0, 100);
    array[i] = xrand;
    Console.Write(array[i] + " ");
}