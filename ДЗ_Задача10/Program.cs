Console.Clear();

Console.Write("Введи трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 99 || n  > 1000)
{
    Console.Write("Это не трехначное число! Попробуй еще раз: ");
    n = Convert.ToInt32(Console.ReadLine());
}
    int n1 = n / 10;
    int n2 = n1 % 10;
    Console.Write(n2); 

