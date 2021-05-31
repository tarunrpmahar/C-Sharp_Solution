using System;

namespace PartialClass
{
    public partial class Coords
    {
        private int x;
        private int y;

        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Coords
    {
        public void PrintCoords()
        {
            Console.WriteLine("Coords: {0},{1}", x, y);
        }
    }

    class TestCoords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coords myCoords = new Coords(10, 15);
            myCoords.PrintCoords();
        }
    }
}
