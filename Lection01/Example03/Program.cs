//    Сумма двух случайный чисел

int numberA = new Random().Next(1,10); //дает случайное целое число от min до max - 1
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);