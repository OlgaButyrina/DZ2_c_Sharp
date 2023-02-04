// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.Write("Введите, пожалуйста, цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
{
    System.Console.Write("Выходной день");
}
else if (n >= 1 && n < 6)
{
    System.Console.Write("Будний день");
}
else
{
    System.Console.Write("Такого дня недели не существует");
}