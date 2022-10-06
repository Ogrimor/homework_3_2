Console.WriteLine("Введите трёхзначное число: ");
string s = Console.ReadLine();
int number = int.Parse(s);
int twoLastDigit = number % 100;
int secondDigit = twoLastDigit / 10;
Console.WriteLine(secondDigit);