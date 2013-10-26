using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    //Problem 12 - Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed.
    //You must NOT edit any existing .cs file.
    //Test the Gift and GiftBlock classes by adding them through the AcademyPopcornMain.cs file.
    class GiftBlock : Block
    {
        public const char GiftBlockSymbol = '$';

        public GiftBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = GiftBlock.GiftBlockSymbol;
        }

        public override void Update()
        {
            
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            Random rand = new Random();
            if (this.IsDestroyed)
            {
                return new Gift[] { new Gift(this.topLeft, new char[,]{{'$'}}, 1)};
            }
            return new GameObject[] { };
        }
    }
}
