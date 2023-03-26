using FunctionApproximation.Model;
using System;
using System.IO;

namespace FunctionApproximation.Domain
{
    public class ConfigurationParser
    {
        private string path;
        public ConfigurationParser(string _path) 
        { 
            if (String.IsNullOrEmpty(_path))
                throw new ArgumentNullException(nameof(_path));
            path = _path;
        }

        public Point<float>[] Parse()
        {
            StreamReader sr = new StreamReader(path);
            string[] parsedX = sr.ReadLine().Split(' ');
            string[] parsedY = sr.ReadLine().Split(' ');
            Point<float>[] points = new Point<float>[parsedX.Length];

            for (int i = 0; i < parsedX.Length; i++)
                points[i] = new Point<float>((float) Convert.ToDouble(parsedX[i]), (float) Convert.ToDouble(parsedY[i]));  
            
            return points;
        }
    }
}
