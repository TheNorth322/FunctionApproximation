using FunctionApproximation.Domain;
using FunctionApproximation.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApproximation
{
    public class FunctionApproximationViewModel
    {
        private int left_border = -2;
        private int right_border = 5;
        private float step = 0.01f;
        private int length;
        public Point<float>[] points;

        public FunctionApproximationViewModel()
        {
            length = (int) Math.Floor(Math.Abs(right_border - left_border) / step + 1);
        }
        
        public void ParseConfiguration(string path)
        {
            ConfigurationParser parser = new ConfigurationParser(path);
            points = parser.Parse();
        }

        public Point<float>[] CalculateInterpolationPolynom()
        {
            int index = 0;
            InterpolationPolynom polynom = new InterpolationPolynom(this.points);
            Point<float>[] points = new Point<float>[length];

            for (float i = -2; i <= 5; i += 0.01f)
            {
                points[index] = new Point<float>(i, polynom.Calculate(i));
                index++;
            }

            return points;
        }
        public Point<float>[] CalculateLagrangePolynom()
        {
            int index = 0;
            LagrangePolynom polynom = new LagrangePolynom(this.points);
            Point<float>[] points = new Point<float>[length];

            for (float i = -2; i <= 5; i += 0.01f)
            {
                points[index] = new Point<float>(i, polynom.Calculate(i));
                index++;
            }

            return points;
        }
        public Point<float>[] CalculateNewtonPolynom()
        {
            int index = 0;
            NewtonPolynom polynom = new NewtonPolynom(this.points);
            Point<float>[] points = new Point<float>[length];

            for (float i = -2; i <= 5; i += 0.01f)
            {
                points[index] = new Point<float>(i, polynom.Calculate(i));
                index++;
            }

            return points;
        }
        
        public Point<float>[] CalculateSmoothingPolynom(int power)
        {
            int index = 0;
            SmoothingPolynom polynom = new SmoothingPolynom(this.points, power);
            Point<float>[] points = new Point<float>[length];

            for (float i = -2; i <= 5; i += 0.01f)
            {
                points[index] = new Point<float>(i, polynom.Calculate(i));
                index++;
            }

            return points;
        }

        public Point<float>[] CalculateMathcadSmoothingPolynom(int power)
        {
            Point<float>[] points = new Point<float>[length];
            int index = 0;
            PowerPolynom polynom;
           switch (power)
            {
                case 1:
                    polynom = new PowerPolynom(new float[] {0.027f, 1.541f});
                    break;
                case 2:
                    polynom = new PowerPolynom(new float[] {1.763f, 6.897f, -1.835f});
                    break;
                case 3:
                    polynom = new PowerPolynom(new float[] {-7.358f, 4.632f, 5.099f, -1.505f});
                    break;
                default:
                    polynom = new PowerPolynom(new float[] { 0 });
                    break;
            }
            
            for (float i = -2; i <= 5; i += 0.01f)
            {
                points[index] = new Point<float>(i, polynom.Calculate(i));
                index++;
            }

            return points;
        }
        public Point<float>[] CalculateMathcadInterpolationPolynom(int power)
        {
            Point<float>[] points = new Point<float>[length];
            int index = 0;
            PowerPolynom polynom = new PowerPolynom(new float[] { -36.6f, 18.75f, 30.208f, -17.75f, 2.392f });

            for (float i = -2; i <= 5; i += 0.01f)
            {
                points[index] = new Point<float>(i, polynom.Calculate(i));
                index++;
            }

            return points;
        }

    }
}
