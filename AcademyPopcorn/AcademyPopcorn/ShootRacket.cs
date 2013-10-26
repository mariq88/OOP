using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    //Problem 13 - Implement a shoot ability for the player racket. The ability should only be activated when a Gift object falls
    //on the racket. The shot objects should be a new class (e.g. Bullet) and should destroy normal Block objects
    //(and be destroyed on collision with any block). Use the engine and ShootPlayerRacket method you implemented in task 4,
    //but don't add items in any of the engine lists through the ShootPlayerRacket method. Also don't edit the Racket.cs file.
    //Hint: you should have a ShootingRacket class and override its ProduceObjects method.
    class ShootRacket : Racket
    {
        private int bullets = 0;
        public bool Shoot { get; set; }

        public ShootRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width) 
        {
            Shoot = false;
        }


        public override void Update()
        {
            Console.WriteLine("Bullets available: {0}", this.bullets);
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return base.CanCollideWith(otherCollisionGroupString) || otherCollisionGroupString == "gift";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains("unStopableBall")) this.IsDestroyed = true;
            if(collisionData.hitObjectsCollisionGroupStrings.Contains("gift")) this.bullets++;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.Shoot && this.bullets > 0)
            {
                this.Shoot = false;
                this.bullets--;
                return new Bullet[] {new Bullet(this.topLeft, new char[,]{{'^'}}, 1) };
            }
            return base.ProduceObjects();
        }
    }
}
