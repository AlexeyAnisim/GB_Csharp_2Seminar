// Программа, которая принимает трехзначное число и показыват вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int num1 = num / 10;
    int num2 = num1%10;
    System.Console.WriteLine(num2);
}
else{
    System.Console.WriteLine("Число не трехзначное");
}