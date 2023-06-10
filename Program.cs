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
    A = Math.Abs(A);
    int Numsum = 0;
    while(A != 0)
    {
        Numsum = Numsum + A%10;
        A =A/10;
    }
    Console.WriteLine(Numsum);
}

//Task25();
Task27();
