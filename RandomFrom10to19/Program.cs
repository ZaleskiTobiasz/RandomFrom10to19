namespace RandomFrom10to19
{
    class Program
    {
        static void Main(string[] args)
        {
            RNGenerator_AndChecker rng_AndChecker = new RNGenerator_AndChecker();
            if (rng_AndChecker.isItDoneAfterFstIteration())
            {

            }
            else
            {
                rng_AndChecker.ContinueWork();
            }
        }
    }
}
