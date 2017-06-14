using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    class ClassPoint
    {
        public int x;
        public int y;
        public char ch;
        private int v1;
        private int v2;
        private char v3;

        public ClassPoint()
        {
            Console.WriteLine("ha-ha-ha");
        }

        public ClassPoint(int _x, int _y, char _ch)
        {
            x = _x;
            y = _y;
            ch = _ch;
        }

        public ClassPoint(ClassPoint p )
        {
            x = p.x;
            y = p.y;
            ch = p.ch;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                        x += offset;
                        break;
                case Direction.LEFT:
                        x -= offset;
                        break;
                case Direction.UP:
                        y -= offset;
                        break;
                case Direction.DOWN:
                        y += offset;
                        break; 
            } 
        }

        public void pointDraw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ch);
        }

        public void Clear()
        {
            ch = ' ';
            pointDraw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + ch;
        }

        public bool IsHit(ClassPoint p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
