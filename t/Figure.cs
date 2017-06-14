using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    class Figure
    {
        protected List<ClassPoint> pList;

        public void Draw()
        {
            foreach (ClassPoint p in pList)
            {
                p.pointDraw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsHit(ClassPoint point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

