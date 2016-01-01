using System;
using GSeriesColorizer;

namespace GSeriesColorizerCmd
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var rg = new RedGreen();

            Console.WriteLine("GSDK Version v{0}", rg.GetVersion());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
