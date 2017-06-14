using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    class VLine : Figure
    {
        public VLine(int yTop, int yBottom, int x, char ch)
        {
            pList = new List<ClassPoint>();
            for (int y = yTop; y <= yBottom; y++)
            {
                ClassPoint p = new ClassPoint(x, y, ch);
                pList.Add(p);
            }
        }

    }
}
