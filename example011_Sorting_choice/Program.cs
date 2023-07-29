//Сортировка выбором

int[] array = { 1, 3, 4, 2, 6, 1, 2, 2, 6 };
SortingChoice(array);

void SortingChoice(int[] arr)
{
    int length = arr.Length;
    int temp = 0;

    for (int i = 0; i < length; i++)
    {
        for (int j = i; j < length; j++)
        {
            if (arr[i] < arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        Console.Write($" {arr[i]} ");
    }
}