int[] array = new int[12];

var random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0,9);
}

foreach (int j in array)
{
    System.Console.WriteLine(j);
}

int summPositive = 0;
int summNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
         summPositive += array[i];
    }

    if (array[i] < 0)
    {
         summNegative += array[i];
    }
    
}

if (summPositive == 0)
{
    System.Console.WriteLine("В массиве нет положительных чисел");
}
else
{
    System.Console.WriteLine("Сумма положительных чисел = " + summPositive);
}

if (summNegative == 0)
{
    System.Console.WriteLine("В массиве нет отрицательных чисел чисел");
}
else
{
    System.Console.WriteLine("Сумма отрицательных чисел = " + summNegative);
}