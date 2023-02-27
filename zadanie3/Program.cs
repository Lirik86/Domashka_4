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
int[] GenerateArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for (int i=0; i < lenght; i++)
    {
        array[i] = random.Next (min, max+1);
    }
    return array;
}
void array123(int[] array)
{
    for (int i=0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1] }");
}
int lenght = inpupint("Введите длину массива: ");
int min = inpupint("Введите диапозон в котором генирируются числа от: ");
int max = inpupint("И до: ");
int[] array = GenerateArray(lenght, min, max);
array123(array);