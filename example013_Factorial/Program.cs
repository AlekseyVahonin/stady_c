// Факториал рекурсивно

int Factorial(int number)
{
    if (number == 1) return 1;
    else return number * Factorial(number - 1);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Factorial(i));
}
