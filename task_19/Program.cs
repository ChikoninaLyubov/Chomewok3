// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
bool pal (string? number)
{
    bool result = int.TryParse(number, out int num);
    result = num > 9999 ? true : false;
    return result;
}

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
string reverseNumber = "";

for (int i = number.Length - 1; i >= 0; i-- )
{
    reverseNumber += number[i]; 
}

Console.WriteLine(number == reverseNumber ? $"Да, {number} - палиндром" : $"Нет, {number} - не палиндром");

