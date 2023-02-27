int inpupint(string msg)
{
    System.Console.WriteLine($"{msg} >");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}
int summ(int num)
{
    int i = 0;
    while (num > 0)
    {
        i = i + num % 10;
        num = num/10;
    }
    return i;
}
int sum = inpupint("Введите число: ");
System.Console.WriteLine(summ(sum));