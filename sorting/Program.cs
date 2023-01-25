var rnd = new Random();
int [] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 5);
}

foreach (int j in array)
{
    System.Console.WriteLine(j);
}

System.Console.WriteLine();

void sorting(int[] array)
{
for (int i = 0; i < array.Length-1; i++)
{
 int min = i;

    for (int j = i+1; j < array.Length; j++)   
    {
        if (array[j] < array[min])
        {
            min = j;
        }
    }

    int box = array[i];
    array[i] = array[min];
    array[min] = box;

}
}

void printArray(int[] array) 
{
    foreach (int j in array)
    {
        System.Console.WriteLine(j);
    }
}

sorting(array);
printArray(array);