Console.WriteLine("Введите диапазон чисел");
int value1 = Convert.ToInt32(Console.ReadLine());
int value2 = Convert.ToInt32(Console.ReadLine());
if (value2 >= value1)
{
    int elems=value2 - value1;
    int[]chisla=new int[elems];
    int znach = value1;
    int result = 0;
    for (int i=0; i<elems; i++)
    {
        if (znach%2==0)
        {
            chisla[result]=znach;
            result++;
        }
     
        znach++;
    }
    for (int i = 0; i < result; i++)
        Console.WriteLine($"Результат преобразования равен: {chisla[i]} ");
}
else
{
    int elems = value1 - value2;
    int[] chisla = new int[elems];
    int znach = value2;
    int result = 0;
    for (int i = 0; i < elems; i++)
    {
        if (znach % 2 == 0)
        {
            chisla[result] = znach;
            result++;
        }
        znach++;
    }
    for (int i = 0; i < result; i++)
    Console.WriteLine($"Результат преобразования равен: {chisla[i]} ");
}

