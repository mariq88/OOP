﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public abstract class GameObject : IRenderable, ICollidable
    {
        protected MatrixCoords topLeft;
        public MatrixCoords TopLeft
        {
            get
            {
                return new MatrixCoords(topLeft.Row, topLeft.Col);
            }

            protected set
            {
                this.topLeft = new MatrixCoords(value.Row, value.Col);
            }
        }

        public string ObjectType { get; protected set; }

        protected char[,] body;

        public bool IsDestroyed { get; protected set; }

        protected GameObject(MatrixCoords topLeft, char[,] body, string type)
        {
            this.TopLeft = topLeft;

            int imageRows = body.GetLength(0);
            int imageCols = body.GetLength(1);

            this.body = this.CopyBodyMatrix(body);

            this.ObjectType = type;

            this.IsDestroyed = false;
        }

        public abstract List<GameObject> Update();

        public virtual void RespondToCollision(CollisionData collisionData)
        {
        }

        char[,] CopyBodyMatrix(char[,] matrixToCopy)
        {
            int rows = matrixToCopy.GetLength(0);
            int cols = matrixToCopy.GetLength(1);

            char[,] result = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = matrixToCopy[row, col];
                }
            }

            return result;
        }

        public virtual char[,] GetImage()
        {
            return this.CopyBodyMatrix(this.body);
        }

        public virtual bool CanCollideWith(string type)
        {
            return this.ObjectType == type;
        }

        public virtual List<MatrixCoords> GetCollisionProfile()
        {
            List<MatrixCoords> profile = new List<MatrixCoords>();

            int bodyRows = this.body.GetLength(0);
            int bodyCols = this.body.GetLength(1);

            for (int row = 0; row < bodyRows; row++)
            {
                for (int col = 0; col < bodyCols; col++)
                {
                    profile.Add(new MatrixCoords(row + this.topLeft.Row, col + this.topLeft.Col));
                }
            }

            return profile;
        }
    }
}