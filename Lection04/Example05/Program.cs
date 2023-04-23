              // Числа Фибоначи

//f(1) = 1     
//f(2) = 1
//f(n) = f(n -1) + f(n -2)

double Fibonachy(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonachy(n - 1) + Fibonachy(n - 2);
}
Console.Clear();
for(int i = 1; i < 35; i++)
{
    Console.WriteLine($"f({i}) -> {Fibonachy(i)}");
}