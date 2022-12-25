// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int EnterNumberN (string massege)
{
    System.Console.Write(massege);
    int numberN = Int32.Parse(Console.ReadLine());
    return numberN;
}

string OutputOfNumbers(int N, int a)
{
    if(a <= N)  return $"{N}, " + OutputOfNumbers(N - 1, a); 
    else return String.Empty;
}

int N = EnterNumberN("Enter N: ");
int a = 0;
System.Console.WriteLine(OutputOfNumbers(N, a));