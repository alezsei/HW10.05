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


Task25();