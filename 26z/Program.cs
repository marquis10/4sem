Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    n /= 10;
    count++;
}
Console.WriteLine($"Количество символов в числе: {count}");