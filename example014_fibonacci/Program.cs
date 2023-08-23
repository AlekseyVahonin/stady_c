// Фибоначи рекурсивно

int Fibonacci(int number)
{
    if (number == 1 || number == 2) return 1;
    else return Fibonacci(number - 1) + Fibonacci(number - 2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}