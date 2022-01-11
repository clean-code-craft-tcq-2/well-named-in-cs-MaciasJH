using System;
using static TelCo.ColorCoder.WritePair;
using static TelCo.ColorCoder.Tests;
namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    /// 
    class Program
    {        
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Press enter to run tests. . .");
            Console.ReadLine();
            RunTest();
            Console.WriteLine("Color Coding Reference Manual");
            Console.WriteLine("- - - - - - - - - - - - - - - -");
            for (int pair = 1; pair < 26; pair++)
            {
                PrintPair(pair);
            }
        }
    }
}
