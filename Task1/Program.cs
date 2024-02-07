namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] Nums = new int[5];
        for ( int i = 0; i < 5; i++)
        {
            Console.WriteLine("Введите число с индексом : " + i);
            Nums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Вы ввели следующие числа: ");
        foreach(int num in Nums)
        {
            Console.WriteLine(num);
        }
    }
}

