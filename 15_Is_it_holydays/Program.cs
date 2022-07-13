/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/

bool isHolyday(int number)
{
    return (number > 5);
}

string GetNameOfDay(int number)
{
    string[] dayOfWeek = {"понедельник", "вторник", "среда", "четверг", "пятница",
        "суббота", "воскресенье"};
    return dayOfWeek[number - 1];
}

string GetTypeOfDay(int number)
{
    if (isHolyday(number)) return "ВЫХОДНОЙ!";
    else return "рабочий день ((";
}

string GetTextResult(int number)
{
    string text = $"День с порядковым номером {number} это ";
    text += $"{GetNameOfDay(number)}, и это {GetTypeOfDay(number)} ";
    return text;
}

Console.Write("Введите порядковый номер дня недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
    Console.WriteLine("Такого дня недели нет!");
else
    Console.WriteLine(GetTextResult(number));