using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    class Snake : Figure
    {
        public Direction direction;


        public Snake(ClassPoint tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<ClassPoint>();
            for (int i = 0; i < lenght; i++)
            {
                ClassPoint p = new ClassPoint(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            ClassPoint tail = pList.First();
            pList.Remove(tail);
            ClassPoint head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.pointDraw();
        }

        public ClassPoint GetNextPoint()
        {
            ClassPoint head = pList.Last();
            ClassPoint nextPoint = new ClassPoint(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
            }
        }

        internal bool Eat (ClassPoint food)
        {
            ClassPoint head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.ch = head.ch;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
