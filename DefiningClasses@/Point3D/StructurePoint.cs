//using System.Text;

public struct Point
{
  public  static readonly Point startCoordinates = new Point(0,0,0);

    public int X { get; set; }

    public int Y { get; set; }

    public int Z { get; set; }

    public Point(int x, int y, int z) : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        ////StringBuilder sb = new StringBuilder();
        string pointAsString = string.Format("({0},{1},{2})", this.X, this.Y, this.Z);
        ////sb.AppendLine(pointAsString);
        return pointAsString;
    }
}
//\nX: {0}\nY: {1}\nZ: {2}