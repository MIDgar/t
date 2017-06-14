using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    class HLine : Figure
    {
        public HLine(int xLeft, int xRight, int y, char ch)
        {
            pList = new List<ClassPoint>();
            for (int x = xLeft; x <= xRight; x++)
            {
                ClassPoint p = new ClassPoint(x,y,ch);
                pList.Add(p);
            }
        }


    }
}
