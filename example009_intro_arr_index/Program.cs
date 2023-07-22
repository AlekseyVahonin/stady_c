// Имеется массив из n элементов, требуется найти элемент массива равный find.

int[] array = { 1, 2, 5, 5, 3 };
int find = 5;

int returnFindArray(int[] arr, int number)
{
    int result = -1;
    int index = 0;
    int count = arr.Length;

    while (index < count)
    {
        if(arr[index] == number)
        {
            result = index;
            break;
        }
        index++;
    }
    return result;
}
int result = returnFindArray(array, find);
Console.WriteLine(result);