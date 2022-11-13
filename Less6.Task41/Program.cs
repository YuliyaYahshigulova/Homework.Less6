Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int Elements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int count = Elements(array);
Console.WriteLine($"Кол-во элементов > 0: {count}");


