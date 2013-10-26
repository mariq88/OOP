using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Ball : MovingObject
    {
        public Ball(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { 'o' } }, "ball", speed)
        {
        }
        public override List<GameObject> Update()
        {
            //GameObject trailObject = new GameObject(this.TopLeft);
          return  base.Update();
           // return new List<GameObject>() { trailObject };
        }

        public override bool CanCollideWith(string type)
        {
            return type == "racket" || type == "block";
        }
    }
}