Console.Write ("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());


if ( x > y)
Console.WriteLine($"большее число= {x} меньшее число= {y}");

else
Console.WriteLine($"большее число= {y} меньшее число= {x}");  
