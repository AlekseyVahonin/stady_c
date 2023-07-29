// Задача на поиск max из 9 чисел c массивом

int[] numbers = { 10, 12, 15, 2, 7, 15 };

int Max(int[] array)
{
    int max = array[0];
    int index = 1;
    int count = array.Length;

    while (index <= count-1)
    {
        if (max < array[index])
        {
            max = array[index];
        }
        index++;
    }
    return max;
}
int max = Max(numbers);
Console.WriteLine(max);