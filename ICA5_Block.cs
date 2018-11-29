using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA5_BlockComp
{
    class ICA5_Block : IComparable
    {
        public const int _blockSize = 1;
        public static int _compareCount = 0;
        public static SortStyle _sort;

        public Color ColorProp { set; private get; }

        public enum SortStyle
        {
            Saturation = 0,
            Brightness,
            Hue,
        };

        public ICA5_Block(Color bColor)
        {
            ColorProp = bColor;
        }

        public void Render(int xPos, int yPos, CDrawer canvas)
        {
            canvas.AddRectangle(xPos, yPos, _blockSize, _blockSize, ColorProp);
        }
        public int CompareTo(object other)
        {
            _compareCount++;
            if (!(other is ICA5_Block))
                throw new ArgumentException("Incorrect type in CompareTo");

            ICA5_Block copy = (ICA5_Block)other;

            switch (_sort)
            {       
                case SortStyle.Brightness:
                    return ColorProp.GetBrightness().CompareTo(copy.ColorProp.GetBrightness());
                case SortStyle.Hue:
                    return ColorProp.GetHue().CompareTo(copy.ColorProp.GetHue());
                default:
                    return ColorProp.GetSaturation().CompareTo(copy.ColorProp.GetSaturation());
            }
            
        }
    }
}
