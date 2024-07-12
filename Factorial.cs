using System;

class Factorial
{
    public static void Main(String[] args)
    {
        int InputNumber, Fact = 1;
        Console.WriteLine("Enter the number: ");
        InputNumber = Convert.ToInt32(Console.ReadLine());

        if (InputNumber == 0 || InputNumber == 1)
        {
            Fact = 1;
        }
        else
        {
            for (int i = InputNumber; i > 0; i--)
            {
                Fact = Fact * i;
            }
        }
        
        Console.WriteLine("Factorial of " + InputNumber + " is: " + Fact);
        Console.ReadLine();
    }
}
