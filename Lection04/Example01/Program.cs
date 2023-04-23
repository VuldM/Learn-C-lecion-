           // Двумерные массивы
string[,] tabel = new string[2, 5];
//Sting.Empty
//tabel[0, 0] tabel[0, 1] tabel[0, 2] tabel[0, 3] tabel[0, 4]
//tabel[1, 0] tabel[1, 2] tabel[1, 2] tabel[1, 3] tabel[1, 4]

tabel[1, 2] = "слово";

for(int rows = 0; rows < 2; rows++)
{
  for(int colomns = 0; colomns < 5; colomns++) 
  {
    Console.Write($"-{tabel[rows, colomns]} -");
  }
  Console.WriteLine();
}

int[,] matrix = new int[3, 4];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}