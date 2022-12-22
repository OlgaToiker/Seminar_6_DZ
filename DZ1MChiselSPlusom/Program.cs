// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел (M): ");
int m = int.Parse(Console.ReadLine()!);
int[] numbers = new int[m];
int count=0;
InputNumbers(m);

void InputNumbers(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        numbers[i] = int.Parse(Console.ReadLine()!);
    }
}

for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i]>0) count++;
    }

Console.WriteLine();
Console.Write(string.Join(", ", numbers));
Console.Write($" -> {count}");