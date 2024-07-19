namespace ProjektAlgorytmyIStrukturyDancyhJS
{
    internal class Program
    {
        static void Main()
        {
            // cubic
            CubicFunction cubicFunction = new CubicFunction();
            Console.Write("Podaj liczbę: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = cubicFunction.Calculate(x);
            Console.WriteLine($"Wynik funkcji sześciennej dla {x} to {result}");

            // polynomial
            Polynomial polynomial = new Polynomial();
            Console.Write("Podaj liczbę: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double result2 = polynomial.Calculate(x);
            Console.WriteLine($"Wynik wielomianu x^5 dla {x1} to {result2}");

            // monte carlo
            MonteCarlo monteCarlo = new MonteCarlo();
            Console.Write("Podaj liczbę iteracji: ");
            int iterations = Convert.ToInt32(Console.ReadLine());
            monteCarlo.CalculatePi(iterations);

            // sieve
            SieveOfEratosthenes sieve = new SieveOfEratosthenes();
            Console.Write("Podaj górną granicę przedziału: ");
            int n = Convert.ToInt32(Console.ReadLine());
            sieve.CalculatePrimes(n);

            // traveling 
            TravelingSalesman tsp = new TravelingSalesman();
            int[,] graph = {
            { 0, 10, 15, 20 },
            { 10, 0, 35, 25 },
            { 15, 35, 0, 30 },
            { 20, 25, 30, 0 }
            };
            int n1 = graph.GetLength(0);
            bool[] visited = new bool[n];
            visited[0] = true;
            int answer = int.MaxValue;

            answer = tsp.SolveTSP(graph, visited, 0, n1, 1, 0, answer);
            Console.WriteLine("Minimalny koszt podróży: " + answer);
        }
    }
}

