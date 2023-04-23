void PrinyArray(int[,] matr)
{

for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0; j < matr.GetLength(1); j++)
    {
Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
    Random rnd = new Random();
for(int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0; j < matr.GetLength(1); j++)
    {
       matr[i, j] = rnd.Next(1, 10);
    }   
}
}
int[,] matrix = new int[3, 4];
PrinyArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrinyArray(matrix);