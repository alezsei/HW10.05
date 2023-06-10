int InText(string Text)
{
    Console.WriteLine(Text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task25()
{
    int A = InText("Введите основание степени");
    int B = InText("Введите степень числа");
    Console.WriteLine($"число {A} в степени {B} = {Math.Pow(A,B)}");

}

void Task27()
{
    int A = InText("Введите число");
    //A = Math.Abs(A);
    int Numsum = 0;
    while(A != 0)
    {
        Numsum = Numsum + A%10;
        A =A/10;
    }
    Console.WriteLine(Numsum);
}

void Creatarray(int[] array)
{
    for (int i = 0; i<array.Length;i++)
    {
        array[i] = new Random().Next(-15,39);
    }
}

void Printarray(int[] array)
{
    for (int i = 0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void Task29()
{
    int size = InText("Введите размер массива");
    int[]  numbers= new int[size];
    Creatarray(numbers);
    for (int i = 0; i<numbers.Length;i++)
    {
        numbers[i] = Math.Abs(numbers[i]);
        Console.Write($"{numbers[i]} ");
    }
}
Task25();
Task27();
Task29();
