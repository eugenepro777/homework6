/* Задача 43: Напишите программу, которая найдёт точку
 пересечения двух прямых, заданных уравнениями 
 y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
var arrayOfIndex = FillArray(4);
PrintArray(arrayOfIndex);
IntersectionPoint(arrayOfIndex);


double[] FillArray(int length)
{
    double[] array = new double[length];
    int temp = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"Введите b{temp + 1}: ");
            var b = Convert.ToDouble(Console.ReadLine());
            array[i] = b;
            temp = temp + 1;
        }
        else
        {
            Console.Write($"Введите k{temp}: ");
            var k = Convert.ToDouble(Console.ReadLine());
            array[i] = k;
        }
    }
    return array;
}


void PrintArray(double[] array)
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

void IntersectionPoint(double[] items)
{
    if ((items[1] == items[3]) && (items[0] == items[2]))
        Console.WriteLine($"Прямые совпадают");
    else if (items[1] == items[3])
        Console.WriteLine($"Прямые параллельны");
    else
    {
        var x = (items[2] - items[0]) / (items[1] - items[3]);
        var y = items[1] * x + items[0];
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"Точка пересечения: ({x}; {y})");
    }
}

