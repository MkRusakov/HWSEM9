// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AckermannFunction (int M, int N)
{
    int res = 0;
    if (M == 0)
        return  res = N + 1;
    else if ((M > 0) && (N == 0))
        return res = AckermannFunction(M - 1, 1);
    else return res = AckermannFunction(M - 1, AckermannFunction(M, N - 1));
}
int res = AckermannFunction(1, 2);
Console.Write(res);
