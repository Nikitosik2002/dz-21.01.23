
int[] array = new int[8];

int number = 1;

for (int i =0; i < array.Length; i++)
{
    System.Console.WriteLine("Введите число №" + number);
    array[i] = Convert.ToInt16(Console.ReadLine());
    number++;
}
System.Console.WriteLine("Вывод массива");

for (int i =0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}
