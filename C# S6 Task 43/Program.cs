// Task 43

Console.Clear();

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k1 * x + b1;

Console.WriteLine($"Дружище, две прямые пересекутся в точке с координатами X: {x}, Y: {y}");