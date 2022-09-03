// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumElements (int M, int N, int sum = 0)
{
    if (M > N) return sum;
    sum = ((M + N) * N) / 2;
    SumElements(M + 1, N, sum);
    return sum;
}
int sum = SumElements(1, 2);
Console.Write(sum);



