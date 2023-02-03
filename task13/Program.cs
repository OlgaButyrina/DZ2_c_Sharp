// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите, пожалуйста, число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<100)
{
    System.Console.Write("У данного числа нет третьей цифры");
}
else if (100<n && n<=100000)
{
    int result = n/100;
    result = result%10;
    System.Console.Write("Третья цифра введенного числа - " + result);
}
else if (100000<n && n<=1000000)
{
    int result = n/1000;
    result = result%10;
    System.Console.Write("Третья цифра введенного числа - " + result);
}
else if (1000000<n && n<=10000000)
{
    int result = n/10000;
    result = result%10;
    System.Console.Write("Третья цифра введенного числа - " + result);
}
else if (10000000<n && n<=100000000)
{
    int result = n/100000;
    result = result%10;
    System.Console.Write("Третья цифра введенного числа - " + result);
}
else if (100000000<n && n<=1000000000)
{
    int result = n/1000000;
    result = result%10;
    System.Console.Write("Третья цифра введенного числа - " + result);
}