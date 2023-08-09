//Сортировка выбором

int[] array = { 1, 3, 4, 2, 6, 1, 2, 2, 7 };
SortingChoice(array);

void SortingChoice(int[] arr)
{
    int temp = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[minIndex] > arr[j]) minIndex = j;
        }

        temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;

        Console.Write($" {arr[i]} ");
    }
}