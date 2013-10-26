using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);

            //Problem 5 - Implement a TrailObject class. It should inherit the GameObject class and should have a
            //constructor which takes an additional "lifetime" integer.
            //The TrailObject should disappear after a "lifetime" amount of turns.
            //You must NOT edit any existing .cs file. Then test the TrailObject by adding an instance of it in the engine
            //through the AcademyPopcornMain.cs file.
                //TrailObject trail = new TrailObject(new MatrixCoords(startRow + i, i), i);
                //engine.AddObject(trail);

            //Problem 1 - Adding Indestructible ceiling!
                IndestructibleBlock currIndestrBlock = new IndestructibleBlock(new MatrixCoords(startRow - 1, i));
                engine.AddObject(currIndestrBlock);

            //Problem 9 - Test the UnpassableBlock and the UnstoppableBall by adding them to the 
            //engine in AcademyPopcornMain.cs file
                UnpassableBlock currUnpassBlock = new UnpassableBlock(new MatrixCoords(startRow - 2, i));
                engine.AddObject(currUnpassBlock);
                int fifth = (endCol - startCol)/5;
                if (i > startCol + fifth && i < endCol - fifth)
                {
                    if (i % 3 == 1)
                    {
                        currUnpassBlock = new UnpassableBlock(new MatrixCoords(startRow + 4, i));
                        engine.AddObject(currUnpassBlock);
                    }
                    else if (i % 3 == 2)
                    {
                    //Problem 12 - Test the Gift and GiftBlock classes by adding them through the AcademyPopcornMain.cs file.
                        GiftBlock giftBlock = new GiftBlock(new MatrixCoords(startRow + 4, i));
                        engine.AddObject(giftBlock);
                    }
                    else
                    {
                        ExplodingBlock explBlock = new ExplodingBlock(new MatrixCoords(startRow + 4, i), (int)(1.5 * i));
                        engine.AddObject(explBlock);
                    }
                }

            }

            //Problem 1 - Adding Indestructible sides!
            for (int i = startRow - 1; i < WorldRows; i++)
            {
                IndestructibleBlock currIndestrBlock = new IndestructibleBlock(new MatrixCoords(i, startCol - 1));
                engine.AddObject(currIndestrBlock);
                currIndestrBlock = new IndestructibleBlock(new MatrixCoords(i, endCol));
                engine.AddObject(currIndestrBlock);
            }

            //Problem 7 - Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(1, 1));
            MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(1, 1));
            engine.AddObject(theBall);

        //Problem 9 - Test the UnpassableBlock and the UnstoppableBall by adding them to the 
        //engine in AcademyPopcornMain.cs file
            //UnstopableBall killBall = new UnstopableBall(new MatrixCoords(WorldRows / 2 , endCol - 2), new MatrixCoords(-1, 1));
            //engine.AddObject(killBall);

            //Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            ShootRacket theRacket = new ShootRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            //Engine gameEngine = new Engine(renderer, keyboard);
            ShooterEngine gameEngine = new ShooterEngine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}
