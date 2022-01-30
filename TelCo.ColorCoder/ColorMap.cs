using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorMap
    {
        public Color[] colorMapMajor;
        public Color[] colorMapMinor;

        public ColorMap()
        {
            /// <summary>
            /// Array of Major colors
            /// </summary>
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };

            /// <summary>
            /// Array of minor colors
            /// </summary>
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
