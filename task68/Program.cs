// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое неотрицательное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе неотрицательное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0) Console.WriteLine("Некорректные данные! Необходимо ввести положительные числа!");
else
{
int ackermannFunction = AckermannFunction (numberM, numberN);
Console.WriteLine($" M = {numberM}, N = {numberN} -> A(M,N) = {ackermannFunction}");
}

int AckermannFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return AckermannFunction (numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction (numM - 1, AckermannFunction(numM, numN - 1));
    return 0;
}