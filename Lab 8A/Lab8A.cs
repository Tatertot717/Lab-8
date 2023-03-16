namespace Lab_8A
{
    internal class Lab8A
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose from the following:\r\n0. Quit\r\n1. Multiply 2 numbers\r\n2. Div 2 numbers\r\n3. Mod 2 numbers");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) System.Environment.Exit(0);
                Console.WriteLine("Enter first number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = 0;
                
                switch (choice) {
                    default:
                        break;
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        c = Recursive_multiply(a,b);
                        break;
                    case 2:
                        c = Recursive_div(a,b);
                        break;
                    case 3:
                        c = Recursive_mod(a,b);
                        break;
                }
                Console.WriteLine("Answer: "+c);

            }
        }

        public static int Recursive_multiply(int a, int b) {
            if (b == 0) return 0;
            return (a + Recursive_multiply(a, b - 1));
        }

        public static int Recursive_div(int a, int b)
        {
            if (b == 0) return -1;
            if(a == b) return (1);
            if ((a-b) <= 0) return (0);

            return(Recursive_div(a-b,b) +1);
        }

        public static int Recursive_mod(int a, int b)
        {
            if (b == 0) return -1;
            if (a < b) return (a);

            return (Recursive_mod(a - b, b));
        }

    }
}