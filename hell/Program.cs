namespace hello
{
    class Program
    {
        static void Main()
        {
            int A, B;
            Console.WriteLine("Введите А: ");
            A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите B: ");
            B = Convert.ToInt16(Console.ReadLine());
            Minus(A, B);
        }
        static void Minus(int A, int B)
        {
            float C = A + B;
            Console.WriteLine($"Операция '-': {C}");
        }
    }
    }
}
