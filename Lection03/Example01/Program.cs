// Вид 1
void Method1()  // Метод который ничего не принимает, но выполнятет то что в него заложено
{
    Console.WriteLine("Автор Я !");
}
Method1(); // Вот так вызывается этот метод

//Вид 2
void Method2(string msg) // Метод который что-то принимает 
{
Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");// так вызывается

void Method21(string msg, int count)// тут что-то сделать несколько раз. Первый аргумент --> что сделать, второй --> сколько раз
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);// В данном случаи напечатать текст
        i++;
    }
}
Method21(count: 4, msg: "Текст" );// Можно указывать какому аргументу какое значение может быть передано, в любой последовательности.

// Вид 3
int Method3()// Метод который что-то возваращает
{
    return DateTime.Now.Year;
}
int year = Method3();// нужно то что вернул метод присвоить переменной или указать вместо переменной в поле вывода в скобках
Console.WriteLine(year);

// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
result = result + text;
i++;
    }
    return result;
}
string res = Method4(10, "asdf  ");
Console.WriteLine(res);
