//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void PrintNumbers (int M, int N)
{
    if (M > N) return;
    Console.Write($"{M} ");
    PrintNumbers(M+1,N);
}
PrintNumbers(1,99);