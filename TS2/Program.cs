//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

System.Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int third_number = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[3] { first_number, second_number, third_number };
int max = numbers[0];

for (int i = 0; i < 3; ++i)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

System.Console.WriteLine($"max1 = {max}");