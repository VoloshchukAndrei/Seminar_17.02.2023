Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!);

if(number == 1)
{
    Console.WriteLine("Ось X > 0 и Ось Y > 0");
}   
else if(number == 2){
    Console.WriteLine("Ось X < 0 и Ось Y > 0");
}else if(number == 3){
    Console.WriteLine("Ось X < 0 и Ось Y < 0");
}else if(number == 4){
    Console.WriteLine("Ось X > 0 и Ось Y < 0");
}else if(number > 4){
    Console.WriteLine("Введён неверный номер четверти");
}