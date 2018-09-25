using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment1
{
    public class Rectangle
    {
      
        private int length;
        private int width;

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public Rectangle()
        {
        }

        public int GetLength()
        {
            return Length;
        }
        public int SetLength(int length)
        {
            this.Length = length;
            return this.Length;

        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.Width = width;
            return this.Width;
        }
        public int GetPerimeter()
        {
            return (Length * 2) + (Width * 2);
        }
        public int GetArea()
        {
            return Length * Width;
        }
    }
}
