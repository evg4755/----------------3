int number = ReadInt("Введите число N: ");
for (int N = 1; N <= number; N++)
{ 
    Console.Write($"{N*N*N} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}