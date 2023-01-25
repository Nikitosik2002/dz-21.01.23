var rnd = new Random();

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,10);
}
void print (int[] array)
{
foreach (int i in array)
{
    System.Console.WriteLine(i);
}
}

print(array);
System.Console.WriteLine();

for (int i = 0; i < array.Length - 1; i++)
{
    int max = i;
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[j] > array[max])
        {
            max = j;   
        }
    }

    int box = array[i];
    array[i] = array[max];
    array[max] = box;
}

print(array);