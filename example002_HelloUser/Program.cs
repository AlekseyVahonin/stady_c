Console.Write("Введите ваше имя: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ого привет, " + userName);
}
else
{
    Console.WriteLine("Привет, " + userName);
}