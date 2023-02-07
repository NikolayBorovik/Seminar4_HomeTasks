// 25. Цикл, кот принимает на вх два числа А и Б и возводит число А в натуральную степень Б.
// 3,5 - 243(3 в 5 степени)

Console.Clear();

System.Console.WriteLine("Enter your numberA: ");
int numberA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter your numberB: ");
int numberB = int.Parse(Console.ReadLine());

int numAPowNumB (int numberA, int numberB)
{
    int pow = numberA;
    for(int i = 1; i < numberB; i++)
    {
        pow = pow*numberA;
    }
    return pow;
}

if (numberB < 0)
{
    System.Console.WriteLine("Your number < 0.");
}
else if (numberB == 0)
{
    System.Console.WriteLine("NumberA raised to the power of the NumberB is 1");
}
else
{
    System.Console.WriteLine($"NumberA raised to the power of the NumberB is {numAPowNumB(numberA, numberB)}");
}
