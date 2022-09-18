Console.Clear();
Console.Write("Введи любое число ");
string n = Convert.ToString(Console.ReadLine());

if (n.Length > 2)

    Console.WriteLine(n[2]);
else
    Console.Write("третьей цифры нет");

