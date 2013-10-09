using System;
using System.Collections.Generic;
using System.Text;

namespace OpenNIWrapper
{
    public struct Rectangle
    {
        public int X, Y;
        public int Width, Height;

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
