// Имеется массив из n элементов, требуется найти элемент массива равный find.

void FillArray(int[] colection)
{
    int index = 0;
    int count = colection.Length;

    while (index < count)
    {
        colection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int index = 0;
    int count = col.Length;

    while (index < count)
    {

        if (count - index == 1)
        {
            Console.WriteLine($"{col[index]} | ");
        }
        else
        {
            Console.Write($"{col[index]} | ");
        }
        index++;
    }
}

int returnFindArray(int[] arr, int number)
{
    int result = -1;
    int index = 0;
    int count = arr.Length;

    while (index < count)
    {
        if (arr[index] == number)
        {
            result = index;
            break;
        }
        index++;
    }
    return result;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int result = returnFindArray(array, 4);
Console.WriteLine(result);