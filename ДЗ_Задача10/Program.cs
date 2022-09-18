Console.Clear();
Console.Write("Введи трехзначное число ");

{
    while (Convert.ToInt32(Console.ReadLine()) < 100 || Convert.ToInt32(Console.ReadLine()) > 999)
{
    Console.Write("Это не трехначное число! ");
    break;
}
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10;
int n2 = n1 % 10;
Console.Write(n2);
}