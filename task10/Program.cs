// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите, пожалуйста, трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (n > 99 && n < 1000)
{
    result = n / 10;
    result = result % 10;
    System.Console.Write("Вторая цифра этого числа - " + result);
}
else
{
    System.Console.Write("Введено не трёхзначное число");
}