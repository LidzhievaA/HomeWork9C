// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int naturalNumbersSum = NaturalNumbersSum(numberN, numberM);
Console.Write($"M = {numberM}, N = {numberN} -> {naturalNumbersSum}");

int NaturalNumbersSum(int firstNumber, int secondNumber)
{
    if (firstNumber <= 0) firstNumber = 1;
    if (secondNumber <= 0) secondNumber = 1;
    if (firstNumber == secondNumber) return firstNumber;
    if (firstNumber < secondNumber) return firstNumber + NaturalNumbersSum(firstNumber + 1, secondNumber);
    if (firstNumber > secondNumber) return firstNumber + NaturalNumbersSum(firstNumber - 1, secondNumber);
    return firstNumber;
}