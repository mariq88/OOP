using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Bullet : MovingObject
    {
        public Bullet(MatrixCoords topLeft, char[,] body, int speed)
            : base(topLeft, body, new MatrixCoords(-speed, 0)) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block" || otherCollisionGroupString == "indestructableBlock"
                || otherCollisionGroupString == "unPassableBlock";
        }

        public override string GetCollisionGroupString()
        {
            return "bullet";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            //if (collisionData.hitObjectsCollisionGroupStrings.Contains("racket"))
            //{
                this.IsDestroyed = true;
            //}
        }
    }
}
