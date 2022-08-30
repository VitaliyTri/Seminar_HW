// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int max = 0;
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    if (A > C)
    {
        max = A;
        Console.WriteLine(max);
    }
}
if (B > A)
{
    if (B > C)
    {
        max = B;
        Console.WriteLine(max);
    }
}
if (C > A)
{
    if (C > B)
    {
        max = C;
        Console.WriteLine(max);
    }
}