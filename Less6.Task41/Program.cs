// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


double[] CreateArray(int size)
{
    double[] element = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число:");
        element[i] = Convert.ToDouble(Console.ReadLine());
    }
    return element;
}

int CountElements(double[] coll)
{
    int count = 0;
    for (int j = 0; j < coll.Length; j++)
    {
        if (coll[j] > 0) count++;
    }
    return count;
}

string Print(int count, double[] massiv)
{
    return ("Количество элементов больше 0: " + count);
}

 int WriteConsole()
{
    Console.Write("Задайте количество элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int n = WriteConsole();

double[] array = CreateArray(n);
int count = CountElements(array);
Console.WriteLine(Print(count, array));











































// Console.Write("Введите элементы(через пробел): ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse)!;
// int Elements(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }
// int count = Elements(array);
// Console.WriteLine($"Кол-во элементов > 0: {count}");


