       // Факториал рекурсией

       double Factorial (int n)
       {
        // 1! = 1
        // 0! = 1
        if(n == 1) return 1;
        else return n * Factorial(n - 1);
       }
       Console.Clear();

for(int i = 1; i < 50; i++)
{
       Console.WriteLine($"{i} {Factorial(i)}"); // 1*2*3*
}