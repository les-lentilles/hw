// Программа, которая принимает на вход 3 числа и выдаёт максимальное из этих чисел:

int a = 10;
int b = 25;
int c = 46;
int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);


