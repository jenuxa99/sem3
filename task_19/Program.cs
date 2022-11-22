/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

void Palindrom()
{
    Console.WriteLine("Введите Ваше число");
    var numb = Convert.ToString(Console.ReadLine());
    int arr = numb.Length;
    
    if (arr == 5)
    {
        if (numb[0] == numb [4] && numb [1] == numb[3])
        {
            Console.WriteLine("Введенное число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенное число не является палиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Введенное число не пятизначное.");
    }
}
Palindrom();
