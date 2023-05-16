using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Калининград, улица Носова, дом 4", 25, 20,50);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Калининград, улица Носова, дом 4", 25, 20, 50,"5 этажей ");
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
