//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

System.Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number)
{
    System.Console.WriteLine($"max = {first_number}");
}
else if (second_number > first_number)
{
    System.Console.WriteLine($"max = {second_number}");
}
else if (first_number == second_number)
{
    System.Console.WriteLine($"{first_number} = {second_number}");
}