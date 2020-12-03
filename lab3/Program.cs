using System;

namespace lab3
{
    class Point
    {
       private int x;
       private int y;
       private char sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw(int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(sym);
            }
            catch
            {
                Console.WriteLine("Значение не может быть отрицательным");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point first = new Point();
            first.SetSym('|');
            first.Draw(-1,1);

            Point second = new Point();
            second.SetSym('+');
            second.Draw(2, 1);

            Point third = new Point();
            third.SetSym('+');
            third.Draw(3, 1);

            Point fourth = new Point();
            fourth.SetSym('|');
            fourth.Draw(1, 2);

            Point fifth = new Point();
            fifth.SetSym('+');
            fifth.Draw(4, 2);

            Point sixth = new Point();
            sixth.SetSym('|');
            sixth.Draw(1, 3);

            Point seventh = new Point();
            seventh.SetSym('+');
            seventh.Draw(2, 3);

            Point eighth = new Point();
            eighth.SetSym('+');
            eighth.Draw(3, 3);

            Point ninth = new Point();
            ninth.SetSym('|');
            ninth.Draw(1, 4);
        }
    }
}
