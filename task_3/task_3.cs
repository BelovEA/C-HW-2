Console.WriteLine("Данная программа, принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Укажите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 7 || num == 6)
{
    Console.WriteLine("адихаем");
}
else
{
    Console.WriteLine("опять работать :(");
}

//all