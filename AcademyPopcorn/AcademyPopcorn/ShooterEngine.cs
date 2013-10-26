using System;
using System.Linq;

namespace AcademyPopcorn
{
    //Problem 4 - Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.
    class ShooterEngine : Engine
    {
        public ShooterEngine(IRenderer renderer, IUserInterface userInterface, int gameSpeed)
            : base(renderer, userInterface, gameSpeed) { }

        public ShooterEngine(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface) { }

        public void ShootPlayerRacket()
        {
            (this.playerRacket as ShootRacket).Shoot = true;
        }
    }
}
