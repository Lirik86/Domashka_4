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
bool validate(int num)
{
    if (num <= 0)
    {
        Console.WriteLine("Вы ввели не натруальное число в степени");
        return false;
    }
    return true;
}
int Quort(int num1, int num2)
{
    int count = 1;
    for (int i = 1; i <= num2; i++)
    {
        count = count * num1;
    }
    return count;
}
int num1 = inpupint("Введите число, которое необходимо возвести в степень: ");
int num2 = inpupint("Введите степень: ");
if (validate(num2))
{
    System.Console.WriteLine(Quort(num1, num2)); 
}