using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class PathStorage
    {
        public static void SavePath(Path path) 
        {
            using (StreamWriter writer = new StreamWriter(@"../../Paths.txt"))
            {
                foreach (var line in path.Paths)
                {
                    writer.WriteLine(line);
                }
            }
        }

        public static Path LoadPath()
        {
            Path loadPath = new Path();
            using (StreamReader reader = new StreamReader(@"Paths.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    String line = reader.ReadLine();
                    string[] splittedLines = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    loadPath.AddPoints(new Point(int.Parse(splittedLines[0]), int.Parse(splittedLines[1]), int.Parse(splittedLines[2])));
                }
                return loadPath;
            }
        }
    }
}