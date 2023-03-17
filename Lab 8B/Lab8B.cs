namespace Lab_8B
{
    internal class Lab8B
    {
        static void Main(string[] args)
        {
            Console.WriteLine(repeatNTimes("I must study recursion until it makes sense\n\r", 100));
            Console.WriteLine(); 
            Console.WriteLine("Enter the first string");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string b = Console.ReadLine();
            if (isReverse(a, b))
            {
                Console.WriteLine(a+" is the reverse of "+b);
            }
            else
            {
                Console.WriteLine(a+ " is not the reverse of "+b);
            }
        }

        public static string repeatNTimes(string a, int b)
        {
            if (b <= 0) return ("");
            if (b == 1) return a;
            return (a + repeatNTimes(a, b - 1));
        }

        public static bool isReverse(string a, string b)
        {
            if (a.Length != b.Length) return false;
            if (a.Length == 0) return true;
            if (a[0] == b[b.Length - 1])
            {
                return(isReverse(a.Substring(1), b.Substring(0, b.Length - 1)));
            }
            return false;
        }
    }
}