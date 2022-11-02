// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое число: ");

int num = Convert.ToInt32(Console.ReadLine());

if(num>99)
{
    while (num > 1000)
    {
      num /=10;  
    }
    int result = num % 10;
    Console.WriteLine(result);
}
else
{
   Console.WriteLine("Третьей цифры нет"); 
}