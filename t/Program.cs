using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace t
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80 , 25);
            Walls walls = new Walls(80, 25);
            walls.Draw();

            ClassPoint p = new ClassPoint(2, 4, '*');

            Snake snake = new Snake(p, 3, Direction.DOWN);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80,25,'$');
            ClassPoint food = foodCreator.CreateFood();
            food.pointDraw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    By bye = new By();
                    bye.SayBy();
                    break;
                }

                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.pointDraw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
            }

            Console.ReadKey();
        }
        
    }

}
