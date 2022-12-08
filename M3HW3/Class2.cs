namespace M3HW3
{
    public class Class2
    {
        public delegate int PowHandler(int x, int y);
        public int Calc(int a, int b)
        {
            Class1 en = new Class1();
            PowHandler p = en.Pow;
            return p.Invoke(a, b);
        }

        public bool Result(int a, int b, int c)
        {
            if (Calc(a, b) % c == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
