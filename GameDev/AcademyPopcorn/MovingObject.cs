using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class MovingObject : GameObject
    {
        public MatrixCoords Speed { get; protected set; }

        event EventHandler OnMove;

        public MovingObject(MatrixCoords topLeft, char[,] body, string type, MatrixCoords speed)
            : base(topLeft, body, type)
        {
            this.Speed = speed;
        }

        protected virtual void UpdatePosition()
        {
            this.TopLeft += this.Speed;
            if (this.OnMove!=null)
            {
                this.OnMove(this, new EventArgs()); //
            }
            
        }

        public override List<GameObject> Update()
        {
             this.UpdatePosition();
            
           
            return new List<GameObject>();
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.CollisionForceDirection.Row * this.Speed.Row < 0)
            {
                this.Speed.Row *= -1;
            }
            if (collisionData.CollisionForceDirection.Col * this.Speed.Col < 0)
            {
                this.Speed.Col *= -1;
            }
        }
    }
}