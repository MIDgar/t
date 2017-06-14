using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char ch;

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char ch)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.ch = ch;
        }

        public ClassPoint CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new ClassPoint(x, y, ch);
        }
    }
}
