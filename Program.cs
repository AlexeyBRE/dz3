Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
if (x%2==0)
{
    Console.WriteLine($"{x} кратное число");
}
if (x%2!=0)
{
     Console.WriteLine($"{x} не кратное число");
}

