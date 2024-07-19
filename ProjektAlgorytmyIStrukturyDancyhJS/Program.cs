namespace ProjektAlgorytmyIStrukturyDancyhJS
{
    internal class Program
    {
        static void Main()
        {
            CubicFunction cubicFunction = new CubicFunction();
            Console.Write("Podaj liczbę: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = cubicFunction.Calculate(x);
            Console.WriteLine($"Wynik funkcji sześciennej dla {x} to {result}");
        }
    }
}
}
