// Задача 29. Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

array[0] = 1;
array[1] = 2;
array[2] = 5;
array[3] = 7;
array[4] = 19;
array[5] = 6;
array[6] = 1;
array[7] = 33;

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}