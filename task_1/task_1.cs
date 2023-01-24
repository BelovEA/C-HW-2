Console.WriteLine("Данная программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write("Укажите целое число, отличное от нуля: ");
int num = Convert.ToInt32(Console.ReadLine());
int number = num / 10;
int second_num = number % 10;
Console.WriteLine("Вторая цифра числа " + num + "  это " + second_num);

