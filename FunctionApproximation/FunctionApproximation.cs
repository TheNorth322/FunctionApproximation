using FunctionApproximation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace FunctionApproximation
{
    public partial class FunctionApproximation : Form
    {
        FunctionApproximationViewModel viewModel;

        public FunctionApproximation()
        {
            InitializeComponent();
            filePathTextBox.Text = "config.txt";
            viewModel= new FunctionApproximationViewModel();
        }

        private void buildPlotsButton_Click(object sender, EventArgs e)
        {
            viewModel.ParseConfiguration(filePathTextBox.Text);
            BuildMathcadInterpolationPolynom(3);
            BuildInterpolationPolynom();
            BuildLagrangePolynom();
            BuildNewtonPolynom();
            for (int i = 1; i < 4; i++)
            {
                BuildMathcadSmoothingPolynom(i);
                BuildSmoothingPolynom(i);
            }
            BuildPoints();
            UpdatePointsInfo();
        }
        
        private void UpdatePointsInfo()
        {
            StringBuilder sr = new StringBuilder();

            foreach (Point<float> point in viewModel.points)
            {
                sr.Append($"({point.X}; {point.Y})\n");
            }
            pointsLabel.Text = sr.ToString();
        }

        private void BuildPoints()
        {
            BuildPlot(viewModel.points, $"Точки", ChartDashStyle.Solid, Color.LightSeaGreen, 20, SeriesChartType.Point);
        }

        private void BuildInterpolationPolynom()
        {
            Point<float>[] points = viewModel.CalculateInterpolationPolynom();
            BuildPlot(points, "Интерп.", ChartDashStyle.Solid, Color.Yellow, 15);            
        }
        private void BuildLagrangePolynom()
        {
            Point<float>[] points = viewModel.CalculateLagrangePolynom();
            BuildPlot(points, "Лагранжа", ChartDashStyle.Solid, Color.Blue, 9);            
        }
        private void BuildNewtonPolynom()
        {
            Point<float>[] points = viewModel.CalculateNewtonPolynom();
            BuildPlot(points, "Ньютона", ChartDashStyle.Solid, Color.Red, 3);            
        }
        private void BuildSmoothingPolynom(int power)
        {
            Point<float>[] points = viewModel.CalculateSmoothingPolynom(power);
            BuildPlot(points, $"Сглаж. ст. {power}", ChartDashStyle.Solid, Color.Black, 3);            
        }
        private void BuildMathcadSmoothingPolynom(int power)
        {
            Point<float>[] points = viewModel.CalculateMathcadSmoothingPolynom(power);
            BuildPlot(points, $"Mathcad Сглаж. ст. {power}", ChartDashStyle.Solid, Color.Orange, 6);            
        }
        private void BuildMathcadInterpolationPolynom(int power)
        {
            Point<float>[] points = viewModel.CalculateMathcadInterpolationPolynom(power);
            BuildPlot(points, $"Mathcad Интерп.", ChartDashStyle.Solid, Color.DarkGreen, 21);            
        }

        private void BuildPlot(Point<float>[] points, string name, ChartDashStyle style, Color color,
            int borderWidth, SeriesChartType seriesChartType = SeriesChartType.Spline)
        {
            chart1.Series.Add(name);
            chart1.Series.FindByName(name).BorderDashStyle = style;
            chart1.Series.FindByName(name).ChartType = seriesChartType;
            chart1.Series.FindByName(name).Color = color;
            chart1.Series.FindByName(name).BorderWidth = borderWidth;
            chart1.Series.FindByName(name).MarkerSize = borderWidth;


            for (int i = 0; i < points.Length - 1; i++)
                chart1.Series.FindByName(name).Points.AddXY(points[i].X, points[i].Y);
        }
    }
}
