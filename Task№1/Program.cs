// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)(пользователь вводит в консоли числа через пробел и они формируют строку)
Console.Write("Enter numbers: ");
string Array = Console.ReadLine()!;
string[] numS = Array.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int count = 0;
foreach (string el in numS)
{
    int res = Int32.Parse(el);
    if (res > 0)
    {
        count++;
    } 
}
Console.WriteLine($"Числа больше нуля = {count}");














