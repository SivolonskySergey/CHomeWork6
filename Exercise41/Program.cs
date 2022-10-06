
void BiggerThanZero(int amount)
{
    int count = 0;
    for(int i = 0; i < amount; i++)
    {
        Console.Write("Введите число: ");
        Console.WriteLine();

        int digitFromUser = Convert.ToInt32(Console.ReadLine());
        if(digitFromUser > 0) 
        {
            count+=1;
        }
    }
    Console.Write($"Количество чисел больше нуля - {count}");
    Console.WriteLine();
}
BiggerThanZero(6);