// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int sum = 0;
int SumOfDigits(int M, int N)
{
    if (N < M)
    {
        return 1;
    }

    sum +=  N;
    SumOfDigits(M, N - 1);

    return sum;
}
Console.WriteLine("Enter M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N");
int N = Convert.ToInt32(Console.ReadLine());
SumOfDigits(M, N);
Console.WriteLine($"Sum of elements between M and N is {sum}");