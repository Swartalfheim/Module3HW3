namespace M3HW3
{
    public class Program
    {
        public delegate bool ResultHandler(int a, int b, int c);
        public static void Main(string[] args)
        {
            Console.Write("This program asks for three numbers, \n" +
                "after which it determines whether the product of the first two is divisible by the third number,\n" +
                "and returns true or false if the number is divisible without a remainder or not, respectively\n");
            Console.Write("enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the third number: ");
            int result = Convert.ToInt32(Console.ReadLine());
            Class2 to = new Class2();
            ResultHandler r = to.Result;
            Show(r.Invoke(first, second, result));
        }

        public static void Show(bool b)
        {
            Console.WriteLine(b);
        }
    }
}