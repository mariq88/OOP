using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    //Problem 11 - Implement a Gift class. It should be a moving object, which always falls down.
    //The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket.
    //You must NOT edit any existing .cs file.
    class Gift : MovingObject
    {
        public Gift(MatrixCoords topLeft, char[,] body, int speed)
            : base(topLeft, body, new MatrixCoords(speed, 0)) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override string GetCollisionGroupString()
        {
            return "gift";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains("racket"))
            {
                this.IsDestroyed = true;
            }
        }
    }
}
