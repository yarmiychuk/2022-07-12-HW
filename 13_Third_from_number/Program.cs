/* Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
*/

int GetThirdDigit(int number)
{
    while (number >= 1000)
    {
        number /= 10;
    }

    return number % 10;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    Console.WriteLine($"У числа {number} третьей цифры нет!");
else
    Console.WriteLine($"Третья цифра: {GetThirdDigit(number)}");