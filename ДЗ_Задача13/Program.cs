
/* Первый вариант решения
Console.Clear();
Console.Write("Введи любое число ");
string n = Convert.ToString(Console.ReadLine());
if (n.Length > 2)

    Console.WriteLine(n[2]);
else
    Console.Write("третьей цифры нет");

*/
Console.Clear();
Console.Write("Введи любое число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.Write("третьей цифры нет");
else
{
    do 
{
     n = n / 10;
}
while (n > 999);
int n1 = n % 10;

 Console.Write("Третья цифра " + n1);
 }