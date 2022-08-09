Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string result = "нет";
if (number % 2 == 0)
{
    result = "да";
}
Console.WriteLine(result);