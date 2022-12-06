// Задача 29. Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void packArray(int[] xarray)
{
    Random rnd = new Random();
    for (int i = 0; i < xarray.Length; i++)
    {
        xarray[i] = rnd.Next(0, 100);
    }
}

void printArray(int[] narray)
{
    for (int i = 0; i < narray.Length; i++)
    {
        Console.Write(narray[i] + " ");
    }
}
 
Console.WriteLine("Программа выгружает массив из 8 цифр ");
int lengthMass = 8;
int[] array = new int[lengthMass];

packArray(array);

printArray(array);