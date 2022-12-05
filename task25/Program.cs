// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3?)
// 2, 4 -> 16

Console.Write("Ведите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int VozvestiVB(int numA, int numB)
{
    int vozvb = numA;
    for (int i = 1; i < numB; i++)
    {
        vozvb = vozvb * numA; 
    }
    return vozvb;
}

if (A != 0 && B > 0)
{
    int C = VozvestiVB(A, B);
    Console.WriteLine($"Число {A} в степени {B} равно {C}");
}
else System.Console.WriteLine("Требуется ввести натуральное число!");