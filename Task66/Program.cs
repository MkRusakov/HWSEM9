// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumElements (int M, int N)
{
    int sum = M + (N - M);
    if (M > N - 1) return sum;
    SumElements(M + 1, N);
    return sum;
}
int sum = SumElements(1, 5);
Console.Write(sum);


