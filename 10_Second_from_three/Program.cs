/* Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
*/

int GetSecondDigit(int number)
{
    return number / 10 % 10;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >= 1000)
    Console.WriteLine("Вы ввели неправильное число");
else
    Console.WriteLine($"Вторая цифра: {GetSecondDigit(number)}");