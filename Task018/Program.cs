Console.Write("Введите номер четверти: ");
int qurter = int.Parse(Console.ReadLine()!);

switch (qurter)
{
    case 1:{Console.WriteLine("Ось X > 0 и Ось Y > 0");
    break;
    }
    case 2:{Console.WriteLine("Ось X < 0 и Ось Y > 0");
    break;
    }
    case 3:{Console.WriteLine("Ось X < 0 и Ось Y < 0");
    break;
    }
    case 4:{Console.WriteLine("Ось X > 0 и Ось Y < 0");
    break;
    }
    default:{Console.WriteLine("Введён неверный номер четверти");
    break;
    }
}