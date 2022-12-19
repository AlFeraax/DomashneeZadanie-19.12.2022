// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string arrNumber = Convert.ToString(number);
if (arrNumber[3] == arrNumber[1] && arrNumber[0] == arrNumber[4])
{
    Console.WriteLine("Введенное число является полиндромом.");
}
else
{
    Console.WriteLine("Введенное число не является полиндромом.");
}