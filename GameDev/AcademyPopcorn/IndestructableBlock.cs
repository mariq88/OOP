using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class IndestructableBlock : Block
    {
        public const char Symbol = '|';
        public IndestructableBlock(MatrixCoords upperLeft) : base(upperLeft)
        {
            this.body[0, 0] = IndestructableBlock.Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            //base.RespondToCollision(collisionData);
        }
    }
}
