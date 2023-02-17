Console.Write("Введите X Кординаты A: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y Кординаты A: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите X Кординаты B: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y Кординаты B: ");
int Y2 = int.Parse(Console.ReadLine()!);

double d = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));

Console.WriteLine($"d={d:f4}");

