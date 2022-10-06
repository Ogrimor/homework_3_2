Console.WriteLine("Введите желаемый день недели, от 1 до 7: ");
string s = Console.ReadLine();
int numberDay = int.Parse(s);
if(numberDay > 0 && numberDay < 8)
{
    if(numberDay == 6) Console.WriteLine("Yes");
    if(numberDay == 7) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}