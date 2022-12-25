// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 3

Console.Clear();

int EnterNumber(string massege)
{
    System.Console.Write(massege);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumGaps(int M, int N)
{
    if (M == N+1) return 0; 
    else return SumGaps(M + 1, N) + M;
}

int M = EnterNumber("Enter M: ");
int N = EnterNumber("Enter N: ");
System.Console.WriteLine(SumGaps(M, N));