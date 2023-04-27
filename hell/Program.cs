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
            Plus(A, B);
            Minus(A, B);
            Multi(A, B);
            Del(A, B);
            DelOst(A, B);
            Expo(A, B);
        }

        static void Del(int A, int B)
        {
            float C = A / B;
            Console.WriteLine($"Операция '/': {C}");
            
        }
        static void Multi(int A, int B)
        {
            float C = A * B;
            Console.WriteLine($"Операция '*': {C}");
        }
        static void Minus(int A, int B)
        {
            float C = A - B;
            Console.WriteLine($"Операция '-': {C}");
        }
        static void Plus(int A, int B)
        {
            float C = A + B;
            Console.WriteLine($"Операция '+': {C}");
        }
        static void DelOst(int A, int B)
        {
            float C = A % B;
            Console.WriteLine($"Операция '%': {C}");
        }
        static void Expo(int A, int B)
        {
            double C = Math.Pow(A,B);
            Console.WriteLine($"Операция '^': {C}");
        }
    }
}


