/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

System.Console.Clear();

int NumbersGreaterThanZero(int amountOfNumbers)
{
    int count = 0;
    int userNumber = 0;
    while (amountOfNumbers > 0)
    {
        System.Console.WriteLine("Введите число для проверки");
        userNumber = int.Parse(Console.ReadLine()!);
        if (userNumber > 0)
        {
            count++;
        }
        amountOfNumbers--;     
    }
    return count;
}




System.Console.WriteLine("Какое количество чисел вы хотите проверить");
int amountOfNumbers = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Количество чисел больше 0 - {NumbersGreaterThanZero(amountOfNumbers)}");