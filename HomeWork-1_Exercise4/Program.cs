Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int index = 1;
string count = "";
while (N>(index-1))
{
    if (index % 2 == 0)
    {
        count = count + ($"{index}, ");
    }
    index++;
}
Console.WriteLine(count);