using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyPopcorn
{
    //Problem 6 - Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects.
    //Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way
    //as the normal ball. You must NOT edit any existing .cs file.

    class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed) { }

        protected override void UpdatePosition()
        {
            base.UpdatePosition();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            return new GameObject[] { new TrailObject(this.TopLeft, 3) };
        }
    }
}
