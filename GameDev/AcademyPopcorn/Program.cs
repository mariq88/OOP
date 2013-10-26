using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Program
    {
        const int WorldRows = 22;
        const int WorldCols = 40;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructableBlock borderBlockLeft = new IndestructableBlock(new MatrixCoords(row,0));
                IndestructableBlock borderBlockRight = new IndestructableBlock(new MatrixCoords(row, -1));

                engine.AddObject(borderBlockLeft);
            }
            for (int i = startCol; i < endCol; i++)
            {
             Block currBlock= new IndestructableBlock(new MatrixCoords(startRow,startCol));
                engine.AddObject(currBlock);
                
            }
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2,0),new MatrixCoords(-1,1));
            //engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows-1,WorldCols/2),6);
            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            
            
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            Engine gameEngine = new Engine(renderer, keyboard);
            Initialize(gameEngine);

            gameEngine.Run();
            //keyboard.OnLeftPressed += (sender, eventInfo) => { Console.WriteLine("You just pressed 'left'"); };
            //keyboard.OnRightPressed += (sender, eventInfo) => { Console.WriteLine("You just pressed 'right'"); };
            //while (true)
            //{
            //    keyboard.ProcessInput();
            //}
            //Block someBlock = new Block(new MatrixCoords(1, 1));
            //Block otherBlock = new Block(new MatrixCoords(0, 2));
            //Racket racket = new Racket(new MatrixCoords(9,0), 4);
            //Ball ball = new Ball(new MatrixCoords(5,5),new MatrixCoords(-1,1));
            //ConsoleRenderer renderer = new ConsoleRenderer(10, 10);
            //while (true)
            //{
            //    System.Threading.Thread.Sleep(500);
            //    renderer.ClearQueue();
            //    renderer.EnqueueForRendering(someBlock);
            //    renderer.EnqueueForRendering(otherBlock);
            //    renderer.EnqueueForRendering(racket);
            //    renderer.EnqueueForRendering(ball);
            //    renderer.RenderAll();
            //    ball.Update();
            //}
        }
    }
}