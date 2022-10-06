Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
char[] removeMinus = {'-'};
string positiveNumber = number.TrimStart(removeMinus);
if (positiveNumber.Length > 3)
{
    Console.WriteLine(positiveNumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}