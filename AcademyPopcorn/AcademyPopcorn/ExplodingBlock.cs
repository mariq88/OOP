using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock : Block
    {
        public new const char ExploadBlockSymbol = '*';
        private int lifeTime;

        public ExplodingBlock(MatrixCoords upperLeft, int lifeTime)
            : base(upperLeft)
        {
            this.body[0, 0] = ExplodingBlock.ExploadBlockSymbol;
            this.lifeTime = lifeTime;
        }

        public override void Update()
        {
            if (--this.lifeTime == 0)
            {
                this.IsDestroyed = true;
            }
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.lifeTime == 0)
            {
                return new UnstopableBall[] { new UnstopableBall(this.topLeft, new MatrixCoords(-1,1)), 
                    new UnstopableBall(this.topLeft, new MatrixCoords(-1,-1))};
            }
            return new GameObject[] { };
        }
    }
}
