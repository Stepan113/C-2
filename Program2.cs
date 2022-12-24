Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
if (num>=1 && num<=7)
{
    if (num==6 || num==7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}
else
{
    Console.WriteLine("День введен неправильно");
} 