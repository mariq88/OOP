using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Racket : GameObject
    {
        public int Width { get; protected set; }

        public Racket(MatrixCoords topLeft, int width)
            : base(topLeft, new char[,] { { '=' } }, "racket")
        {
            this.Width = width;
            this.body = GetRacketBody(this.Width);
        }

        char[,] GetRacketBody(int width)
        {
            char[,] body = new char[1, width];

            for (int i = 0; i < width; i++)
            {
                body[0, i] = '=';
            }

            return body;
        }

        public void MoveLeft()
        {
            this.topLeft.Col--;
        }

        public void MoveRight()
        {
            this.topLeft.Col++;
        }

        public override List<GameObject> Update()
        {
            return new List<GameObject>();
        }
    }
}