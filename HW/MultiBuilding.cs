using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    sealed class MultiBuilding : Building
    {
        string floors;
        string Floors { get { return floors; } set { floors = value; } }
        public MultiBuilding(string address, int height, int width, int length,  string floors)
               : base(address,height, width, length)
        {
            this.Floors = floors;
        }
        public string Print()
        {
            string result = base.Print();
            result += $"\nэтажность:{floors}";
            return result;
        }
    }
}
