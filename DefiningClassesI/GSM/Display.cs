using System;
using System.Linq;
using System.Text;

public class Display
{
    private string numberOfColors; ////problem 1
    private float size; ////problem 1
    ////constructors
    public Display(float size):this(size, null) ////problem 2
    {
        //this.numberOfColors = null;
        //this.size = 0;
    }

    public Display(float size,string colors) ////problem 2
    {
        this.size = size;
        this.numberOfColors = colors;
    }

    //public Display(string colors, float size) : this(colors) ////problem 2
    //{
    //    this.size = size;
    //}

    ////properties
    public string Colors ////problem 5
    {
        get
        {
            return this.numberOfColors;
        }

        set
        {
            this.numberOfColors = value;
        }
    }

    public float Size ////problem 5
    {
        get
        {
            return this.size;
        }

        set
        {
            this.size = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(this.size.ToString());
        sb.AppendLine(this.numberOfColors);
        return sb.ToString();
    }
}