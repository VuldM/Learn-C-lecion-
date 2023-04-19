string Method(int count, string text)
{ 
    string result = String.Empty;
for(int i = 0; i < count; i++)  // Цикл for
    {
result = result + text;
    }
    return result;
}
string res = Method(10, "asdf  ");
Console.WriteLine(res);

// Таблица умножения с помощью цикла for

for(int i = 2; i <= 9; i++)
{
    for(int j = 2; j <= 9; j++)
    {
Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
