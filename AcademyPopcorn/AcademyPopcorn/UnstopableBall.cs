using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyPopcorn
{
    //Problem 8 - Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off UnpassableBlocks and will
    //destroy any other block it passes through. The UnpassableBlock should be indestructible.
    //Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.
    class UnstopableBall : MeteoriteBall
    {
        public UnstopableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed) { }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            return new GameObject[] { new TrailObject(this.TopLeft, new char[,] {{'*'}}, 5) };
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unPassableBlock";
        }

        public override string GetCollisionGroupString()
        {
            return "unStopableBall";
        }
    }
}
