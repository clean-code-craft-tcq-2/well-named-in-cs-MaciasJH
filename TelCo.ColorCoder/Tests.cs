using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.GetColor;
using static TelCo.ColorCoder.GetPairNumber;
using static TelCo.ColorCoder.WritePair;

namespace TelCo.ColorCoder
{
    public class Tests
    {
        public static void RunTest()
        {
            int pairNumber = 4;
            ColorPair testPair1 = GetColorFromPairNumber(pairNumber);
            PrintPair(4);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = GetColorFromPairNumber(pairNumber);
            PrintPair(5);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = GetColorFromPairNumber(pairNumber);
            PrintPair(23);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = GetPairNumberFromColor(testPair2);
            PrintPair(pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = GetPairNumberFromColor(testPair2);
            PrintPair(pairNumber);
            Debug.Assert(pairNumber == 6);
            Console.WriteLine("Testing was successfull, press enter to exit test...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
