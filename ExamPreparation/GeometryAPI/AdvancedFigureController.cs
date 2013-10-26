using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryAPI
{
    public class AdvancedFigureController : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                    {
                        Vector3D center = Vector3D.Parse(splitFigString[1]);
                        double radius = double.Parse(splitFigString[2]);
                        this.currentFigure = new Circle(center,radius);
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D top = Vector3D.Parse(splitFigString[1]);
                        Vector3D bottom = Vector3D.Parse(splitFigString[2]);
                        double radius = double.Parse(splitFigString[3]);
                        this.currentFigure = new Cylinder(top,bottom,radius);
                        break;
                    }
               
            }
            base.ExecuteFigureCreationCommand(splitFigString);
            this.EndCommandExecuted = false;
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area":
                    {
                        var currentAsIAreaMeasurable = this.currentFigure as IAreaMeasurable;
                        if (currentAsIAreaMeasurable!=null)
                        {
                            
                            Console.WriteLine("{0:0.00}",currentAsIAreaMeasurable.GetArea());
                        }
                        //if (this.currentFigure is IAreaMeasurable) ////po-bavno e
                        //{ }
                        break;
                    }
                case "normal":
                    {
                        var currentFigure = this.currentFigure as IFlat;

                        if (currentFigure == null)
                        {
                            Console.WriteLine("undefined");
                        }
                        else
                        {
                            Console.WriteLine(((this.currentFigure as IFlat).GetNormal()).ToString());
                        }

                        break;
                    }
                case "volume":
                    {
                        var currentFigure = this.currentFigure as IVolumeMeasurable;

                        if (currentFigure == null)
                        {
                            Console.WriteLine("undefined");
                        }
                        else
                        {
                            Console.WriteLine("{0:0.00}", (this.currentFigure as IVolumeMeasurable).GetVolume());
                        }

                        break;
                    }
                case "translate":
                    {
                        Vector3D transVector = Vector3D.Parse(splitCommand[1]);
                        this.currentFigure.Translate(transVector);
                        break;
                    }
                case "rotate":
                    {
                        Vector3D center = Vector3D.Parse(splitCommand[1]);
                        double degrees = double.Parse(splitCommand[2]);
                        this.currentFigure.RotateInXY(center, degrees);
                        break;
                    }
                case "scale":
                    {
                        Vector3D center = Vector3D.Parse(splitCommand[1]);
                        double factor = double.Parse(splitCommand[2]);
                        this.currentFigure.Scale(center, factor);
                        break;
                    }
                case "center":
                    {
                        Vector3D figCenter = this.currentFigure.GetCenter();
                        Console.WriteLine(figCenter.ToString());
                        break;
                    }
                case "measure":
                    {
                        Console.WriteLine("{0:0.00}", this.currentFigure.GetPrimaryMeasure());
                        break;
                    }
            }
           // base.ExecuteFigureInstanceCommand(splitCommand);
        }
    }
}
