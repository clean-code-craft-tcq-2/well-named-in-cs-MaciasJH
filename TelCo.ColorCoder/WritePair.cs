using System;
using static TelCo.ColorCoder.GetColor;

namespace TelCo.ColorCoder
{
    class WritePair
    {
        public static void PrintPair(int pairNumber)
        {
            ColorPair colorPair = GetColorFromPairNumber(pairNumber);
            Console.WriteLine("Pair Number: {0}, Colors: {1}, {2}\n", pairNumber, colorPair.majorColor.Name, colorPair.minorColor.Name);
        }
    }
}
