Console.Write("Введите число: ");
int squares = int.Parse(Console.ReadLine()!);
int index = 1;
double sum = 0;

while(index <= squares)
{
    sum = index * index;
    Console.WriteLine(sum); 
    index++;
}