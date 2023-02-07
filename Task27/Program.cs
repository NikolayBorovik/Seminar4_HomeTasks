// 27. Пр-ма, кот принимает на вх число и выдает сумму цифр в числе.
// 452 - 11

Console.Clear();

System.Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine());

int ProductOfDigits (int number)
{
    int sum = 0;
        for (int i = number; i > 0; i = i/10)
    {
        number = i%10;
        sum = sum + number;
       
    }
return sum;
}

if(number < 0)
{
    System.Console.WriteLine("your number < 0");
}
else
{
    System.Console.WriteLine(ProductOfDigits(number));
}

