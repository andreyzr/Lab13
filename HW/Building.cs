using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Building
    {
        int height;
        int width;
        int length;
        string address;

        int Height {get {return height;}set { height = value; }}
        int Length { get { return length; } set { length = value; } }
        int Width { get { return width; } set { width = value; } }
        string Address { get { return address; } set { address = value; } }

        public Building(string address,int height, int width, int length )
        {
            this.Height = height;
            this.Length = length;
            this.Width = width;
            this.Address = address;
        }
        public string Print()
        {
            return $"Адресс дома:{address}\nвысота,м:{height}\nширина,м:{width}\nдлинна,м:{length} ";
        }
    }
}
