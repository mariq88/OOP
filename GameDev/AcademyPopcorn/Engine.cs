using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Engine
    {
        IRenderer renderer;
        IUserInterface userInterface;
        List<GameObject> allObjects;
        List<MovingObject> movingObjects;
        List<GameObject> staticObjects;

        public Engine(IRenderer renderer, IUserInterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>(); //Ostavqme gi prazni,zaradi AddMovingObject i AddStaticObject. I 2-ta dobavqt kum vs obekti.
            Racket playerRacket;
        }

        public void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }
        public void AddObject(GameObject obj) 
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject );
            }
            else
            {
                //if (obj is Racket)
                //{
                //    this.playerRacket=obj as Ra

                //}
                this.AddStaticObject(obj);
            }
        }
        public void Run()
        {
            while (true)
            {
                List<GameObject> producedObjects = new List<GameObject>();

                
                
                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(500);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();
                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.Update());
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                    
                    //if (obj is MovingObject)
                    //{
                    //    this.AddMovingObject((MovingObject)obj);
                    //}
                    //else
                    //{
                    //    this.AddStaticObject(obj);
                    //}
                }
            }
        }
    }
}