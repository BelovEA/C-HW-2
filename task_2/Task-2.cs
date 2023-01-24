Console.WriteLine("Данное приложение  выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("третьей цифры нет!");
}
else
{
    Console.WriteLine("Последняя цифра заданного числа " + num + " равна: " + (num % 10));
}