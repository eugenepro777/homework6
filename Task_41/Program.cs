/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */
Console.Write("Введите количество чисел:\t");
int amount = Convert.ToInt32(Console.ReadLine());
int[] MyArray = FillArray(amount);
Console.WriteLine();
PrintArray(MyArray);
Console.WriteLine();
Console.Write
($"{"Количество чисел больше нуля: ",33}{GetMoreZero(MyArray)}");

int GetMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} число:\t");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}