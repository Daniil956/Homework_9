// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int EnterNumber(string massege)
{
    System.Console.Write(massege);
    int number = int.Parse(Console.ReadLine());
    return number;    
}

int A (int m, int n)
{
    if(m==0)return n + 1;
    if( m > 0 && n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n -1));
}

int m = EnterNumber("Enter number: ");
int n = EnterNumber("Enter number: ");
System.Console.WriteLine(A(m,n));

//Не очень понял судь задачи, потому что получаем на вход 2 числа, а по итогу выводим одно и не очень понятно как оно получается

