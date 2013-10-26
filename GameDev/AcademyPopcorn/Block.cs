using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Block : GameObject
    {
        public Block(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '#' } }, "block")
        {

        }
        protected Block(MatrixCoords topLeft, char symbol, string type) : base(topLeft, new char[,] { { symbol } }, type) { }

        public override List<GameObject> Update()
        {
            return new List<GameObject>();
        }

        public override bool CanCollideWith(string type)
        {
            return base.CanCollideWith(type);
        }

        public override void RespondToCollision(CollisionData collisionData) //Kogato standartnata tuhla e blusnata, suob6tava,4e e destroyed
        {
            this.IsDestroyed = true;
        }
    }
}