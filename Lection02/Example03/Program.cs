int[] array = {1, 12, 31 , 54, 15, 16, 17, 88, 90, 54};

int n = array.Length;
int find = 54;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // Прервать выполнения цикла
    }
    index++;
}