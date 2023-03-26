using FunctionApproximation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionApproximation
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FunctionApproximation());
            Point<float>[] points = new Point<float>[5]
            {
                new Point<float>(-1, -5),
                new Point<float>(1, -3),
                new Point<float>(2, 18),
                new Point<float>(3, 6),
                new Point<float>(4, -2),
            };

            InterpolationPolynom interpolationPolynom = new InterpolationPolynom(points);
            LagrangePolynom lagrangePolynom = new LagrangePolynom(points);
            NewtonPolynom newtonPolynom = new NewtonPolynom(points);
            SmoothingPolynom smoothingPolynom1 = new SmoothingPolynom(points, 1);
            SmoothingPolynom smoothingPolynom2 = new SmoothingPolynom(points, 2);
            SmoothingPolynom smoothingPolynom3 = new SmoothingPolynom(points, 3);

            for (float i = 0; i < 5; i += 0.5f)
            {
                Console.WriteLine($"{i}: {interpolationPolynom.Calculate(i)} {lagrangePolynom.Calculate(i)} {newtonPolynom.Calculate(i)}");
                Console.WriteLine($"{i}: {smoothingPolynom1.Calculate(i)} {smoothingPolynom2.Calculate(i)} {smoothingPolynom3.Calculate(i)}");
            }
        }
    }
}
