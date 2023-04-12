namespace PolymorphismDemo_pracctice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            arithmetic.Add();
            arithmetic.Add(10);
            arithmetic.Add(10,20);
            arithmetic.Add(20.5f,30.5f);
            arithmetic.Add(30.5f, 25);
            arithmetic.Add(40, 50.5f);
        }
    }
}