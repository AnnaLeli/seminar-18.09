Console.Clear();
Console.Write("Введи порядковый номер дня недели ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7)
{
    Console.Write("Нет такого дня недели. Введи порядковый номер от 1 до 7: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
     Console.Write("Yes");
else 
    Console.Write("No");