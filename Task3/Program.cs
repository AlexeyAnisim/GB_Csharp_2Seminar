// Программа, определяющая по цифре является ли день выходным
Console.WriteLine("Введите произвольное число");

int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{case 1:
     Console.WriteLine("Понедельник - не выходной");
     break;
case 2:
     Console.WriteLine("Вторник - не выходной");
     break;
case 3:
     Console.WriteLine("Среда - не выходной");
     break;
case 4:
     Console.WriteLine("Четверг - не выходной");
     break;
case 5:
     Console.WriteLine("Пятница - не выходной");
     break;
case 6:
     Console.WriteLine("Суббота - выходной");
     break;
case 7:
     Console.WriteLine("Воскресение - выходной");
     break;
default:        
    Console.WriteLine("Это не день недели"); 
    break; 
}