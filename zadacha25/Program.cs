void stepen(int a, int b)
{   int result = 1;
    for (int i = 1; i <= b; i++)
    {
    result = result * a;
    }
    Console.WriteLine($"Ответ = {result}");
}
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
stepen(a,b);


