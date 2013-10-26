using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class CollisionData
    {
        public readonly MatrixCoords CollisionForceDirection;

        public CollisionData(MatrixCoords collisionForceDirection)
        {
            this.CollisionForceDirection = collisionForceDirection;
        }
    }
}