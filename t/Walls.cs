﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HLine upLine = new HLine(0, mapWidth - 2, 0, '+');
            HLine downLine = new HLine(0, mapWidth - 2, mapHeight - 2, '+');
            VLine leftLine = new VLine(0, mapHeight - 2, 0, '+');
            VLine rightLine = new VLine(0, mapHeight - 2, mapWidth - 2, '+');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }


        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
