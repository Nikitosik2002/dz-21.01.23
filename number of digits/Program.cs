System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

string digits = number.ToString();

System.Console.Write("Коливчество цифр в числе = ");
System.Console.WriteLine(digits.Length-1 + 1);
