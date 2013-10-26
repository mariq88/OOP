using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public static class CollisionDispatcher
    {
        public static void HandleCollisions(List<MovingObject> movingObjects, List<GameObject> staticObjects)
        {
            HandleMovingWithStaticCollisions(movingObjects, staticObjects);
        }

        private static void HandleMovingWithStaticCollisions(List<MovingObject> movingObjects, List<GameObject> staticObjects)
        {
            foreach (var obj in movingObjects)
            {
                int verticalIndex = VerticalCollisionIndex(obj, staticObjects);
                int horizontalIndex = VerticalCollisionIndex(obj, staticObjects);

                MatrixCoords movingCollisionForceDirection = new MatrixCoords(0, 0);

                if (verticalIndex != -1)
                {
                    movingCollisionForceDirection.Row = -obj.Speed.Row;
                    staticObjects[verticalIndex].RespondToCollision(new CollisionData(new MatrixCoords(obj.Speed.Row, 0)));
                }

                if (horizontalIndex != -1)
                {
                    movingCollisionForceDirection.Col = -obj.Speed.Col;
                    staticObjects[horizontalIndex].RespondToCollision(new CollisionData(new MatrixCoords(0, obj.Speed.Col)));
                }

                int diagonalIndex = -1;
                if (horizontalIndex == -1 && verticalIndex == -1)
                {
                    diagonalIndex = DiagonalCollisionIndex(obj, staticObjects);
                    if (diagonalIndex != -1)
                    {
                        movingCollisionForceDirection.Row = -obj.Speed.Row;
                        movingCollisionForceDirection.Col = -obj.Speed.Col;
                        staticObjects[verticalIndex].RespondToCollision(new CollisionData(new MatrixCoords(obj.Speed.Row, 0)));
                        staticObjects[horizontalIndex].RespondToCollision(new CollisionData(new MatrixCoords(0, obj.Speed.Col)));
                    }
                }
            }
        }

        public static int VerticalCollisionIndex(MovingObject moving, List<GameObject> objects)
        {
            List<MatrixCoords> profile = moving.GetCollisionProfile();

            List<MatrixCoords> verticalProfile = new List<MatrixCoords>();

            foreach (var coord in profile)
            {
                verticalProfile.Add(new MatrixCoords(coord.Row + moving.Speed.Row, coord.Col));
            }

            int collisionIndex = GetCollisionIndex(moving, objects, verticalProfile);

            return collisionIndex;
        }

        public static int HorizontalCollisionIndex(MovingObject moving, List<GameObject> objects)
        {
            List<MatrixCoords> profile = moving.GetCollisionProfile();

            List<MatrixCoords> horizontalProfile = new List<MatrixCoords>();

            foreach (var coord in profile)
            {
                horizontalProfile.Add(new MatrixCoords(coord.Row, coord.Col + moving.Speed.Col));
            }

            int collisionIndex = GetCollisionIndex(moving, objects, horizontalProfile);

            return collisionIndex;
        }

        public static int DiagonalCollisionIndex(MovingObject moving, List<GameObject> objects)
        {
            List<MatrixCoords> profile = moving.GetCollisionProfile();

            List<MatrixCoords> horizontalProfile = new List<MatrixCoords>();

            foreach (var coord in profile)
            {
                horizontalProfile.Add(new MatrixCoords(coord.Row + moving.Speed.Row, coord.Col + moving.Speed.Col));
            }

            int collisionIndex = GetCollisionIndex(moving, objects, horizontalProfile);

            return collisionIndex;
        }

        private static int GetCollisionIndex(MovingObject moving, ICollection<GameObject> objects, List<MatrixCoords> movingProfile)
        {
            int collisionIndex = 0;

            foreach (var obj in objects)
            {
                if (moving.CanCollideWith(obj.ObjectType) || obj.CanCollideWith(moving.ObjectType))
                {
                    List<MatrixCoords> objProfile = obj.GetCollisionProfile();

                    if (ProfilesIntersect(movingProfile, objProfile))
                    {
                        return collisionIndex;
                    }
                }

                collisionIndex++;
            }

            return -1;
        }

        private static bool ProfilesIntersect(List<MatrixCoords> firstProfile, List<MatrixCoords> secondProfile)
        {
            foreach (var firstCoord in firstProfile)
            {
                foreach (var secondCoord in secondProfile)
                {
                    if (firstCoord.Equals(secondCoord))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}