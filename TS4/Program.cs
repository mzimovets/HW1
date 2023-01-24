//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 0;

while(i < number)
{
    if ((i % 2) == 0)
    {
        System.Console.WriteLine(i + ",F");
    }
}
