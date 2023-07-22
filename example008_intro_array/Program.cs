// Задача на поиск max из 9 чисел

int a1 = 12; int a4 = 10; int a7 = 13;
int a2 = 45; int a5 = 9;  int a8 = 17;
int a3 = 65; int a6 = 8;  int a9 = 19;

int Max(int number1, int number2, int number3)
{
    int max = number1;

    if (max < number2){max = number2;}
    if (max < number3){max = number3;}
    return max;
}
int max = Max(Max(a1, a2, a3), Max(a4, a5, a6), Max(a7, a8, a9));
Console.WriteLine(max);