// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.Write("Введите, пожалуйста, цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
{
    System.Console.Write("Выходной день");
}
else if (n > 7 || n < 0)
{
    System.Console.Write("Такого дня недели не существует");
}
else
{
    System.Console.Write("Будний день");
}