//Сортировка выбором

int[] array = { 1, 3, 4, 2, 6, 1, 2, 2, 6 };
SortingChoice(array);

void SortingChoice(int[] arr)
{
    int length = arr.Length;
    int temp = 0;

    for (int i = 0; i < length; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < length; j++)
        {
            if (arr[minIndex] > arr[j])
            {
                minIndex = j;
            }
        }
        temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;

        Console.Write($" {arr[i]} ");
    }
}