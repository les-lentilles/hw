// Программа, которая на вход приримает число (N), а на выходе показывает все чётные числа от 1 до N.

int number = new Random().Next(0, 100); 
Console.WriteLine(number);
int numbereven = 2;
if(number > 1)
{
    while(numbereven <= number)
    {Console.Write(numbereven + ", ");
    numbereven = numbereven + 2;
    }
} 

