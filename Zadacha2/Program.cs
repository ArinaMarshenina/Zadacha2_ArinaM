Console.WriteLine("Введите 2 числа"); //нужно ввести два числа
int a, b;
Console.WriteLine("Введите первое число - "); //вводим первое число
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - "); //вводим второе число
b = Convert.ToInt32(Console.ReadLine());

bool first = a > b;  //условие 1
bool second = a == b; //условие 2
bool third = a < b; //условие 3
 
if (first) 
{
    Console.WriteLine($"Число {a} больше чем {b}"); //если первое условие
}
 else if (second)
{
    Console.WriteLine($"Числа {a} и {b} равны"); //если второе условие
}
else
{
   Console.WriteLine($"Число {b} больше чем {a}"); //если третье условие
};