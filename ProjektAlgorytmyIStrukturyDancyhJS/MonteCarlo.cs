namespace ProjektAlgorytmyIStrukturyDancyhJS
{
    class MonteCarlo
    {
        public void CalculatePi(int iterations)
        {
            Random rand = new Random();
            int insideCircle = 0;

            for (int i = 0; i < iterations; i++)
            {
                double x = rand.NextDouble();
                double y = rand.NextDouble();

                if (x * x + y * y <= 1)
                {
                    insideCircle++;
                }
            }

            double piEstimate = (4.0 * insideCircle) / iterations;
            Console.WriteLine($"Szacowana wartość liczby Pi po {iterations} iteracjach: {piEstimate}");
        }
    }
}