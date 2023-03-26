using FunctionApproximation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            BuildInterpolationPolynom();
            BuildLagrangePolynom();
            BuildNewtonPolynom();
            for (int i = 1; i < 4; i++)
            {
                BuildSmoothingPolynom(i);
                BuildMathcadSmoothingPolynom(i);
                BuildMathcadInterpolationPolynom(i);
            }
            UpdatePointsInfo();
        }
        
        private void UpdatePointsInfo()
        {
            StringBuilder sr = new StringBuilder();
            foreach (Point<float> point in viewModel.points)
                sr.Append($"({point.X}; {point.Y})\n");
            pointsLabel.Text = sr.ToString();
        }
        private void BuildInterpolationPolynom()
        {
            Point<float>[] points = viewModel.CalculateInterpolationPolynom();
            BuildPlot(points, "interpolation", ChartDashStyle.Dash, Color.Red);            
        }
        private void BuildLagrangePolynom()
        {
            Point<float>[] points = viewModel.CalculateLagrangePolynom();
            BuildPlot(points, "lagrange", ChartDashStyle.DashDot, Color.Green);            
        }
        private void BuildNewtonPolynom()
        {
            Point<float>[] points = viewModel.CalculateNewtonPolynom();
            BuildPlot(points, "newton", ChartDashStyle.DashDotDot, Color.Blue);            
        }
        private void BuildSmoothingPolynom(int power)
        {
            Point<float>[] points = viewModel.CalculateSmoothingPolynom(power);
            BuildPlot(points, $"smoothing{power}", ChartDashStyle.Dash, Color.Black);            
        }
        private void BuildMathcadSmoothingPolynom(int power)
        {
            Point<float>[] points = viewModel.CalculateMathcadSmoothingPolynom(power);
            BuildPlot(points, $"mcSmoothing{power}", ChartDashStyle.DashDot, Color.Purple);            
        }
        private void BuildMathcadInterpolationPolynom(int power)
        {
            Point<float>[] points = viewModel.CalculateMathcadInterpolationPolynom(power);
            BuildPlot(points, $"mcInterpolation{power}", ChartDashStyle.DashDotDot, Color.Orange);            
        }
        private void BuildPlot(Point<float>[] points, string name, ChartDashStyle style, Color color)
        {
            chart1.Series.Add(name);
            chart1.Series.FindByName(name).BorderDashStyle = style;
            chart1.Series.FindByName(name).ChartType = SeriesChartType.Spline;
            chart1.Series.FindByName(name).Color = color;
            chart1.Series.FindByName(name).BorderWidth = 2;
            foreach(Point<float> point in points)
                chart1.Series.FindByName(name).Points.AddXY(point.X, point.Y);
        }
    }
}
