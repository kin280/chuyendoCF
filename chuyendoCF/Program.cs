internal class Program
{
    private static void Main(string[] args)
    {
        int choise = -1;

        while (choise != 0)
        {
            Console.WriteLine("nhap lua chon");
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 0:
                    {
                        Environment.Exit(0);

                    }
                    break;
                case 1:
                    {
                        Console.WriteLine(CF());
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine(FC());
                    }
                    break;
                default:
                    {
                        Console.WriteLine("nhap lai");
                    }
                    break;
            }
        }
    }

    static int CF()
    {
        Console.WriteLine("nhap do C:");
        int ch = int.Parse(Console.ReadLine());
        int fa = 9 / 5 * ch + 32;
        Console.WriteLine(fa);
        return fa;
    }

    static int FC()
    {
        Console.WriteLine("nhap do F:");
        int fa = int.Parse(Console.ReadLine());
        int ch = 5 / 9 * (fa - 32);
        Console.WriteLine(ch);
        return ch;
    }
}