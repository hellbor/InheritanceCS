using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Triangle : Shape
	{
		double width;
		double height;
		public double Width
		{
			get => width;
			set => width = SizeFilter(value);
		}
		public double Height
		{
			get => height;
			set => height = SizeFilter(value);
		}
		public Triangle

			(
			double width, double height,
			int startX, int stsrtY, int lineWidth, System.Drawing.Color color
			) : base(startX, stsrtY, lineWidth, color)
		{ 
			Width = width;
			Height = height;
		}
		public override double GetArea() => (Width * Height) / 2;
		public override double GetPerimeter() => Width + 2 * Math.Sqrt(Math.Pow((Width / 2), 2) + Math.Pow(Height, 2));
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points =
			{
				new Point(StartX, StartY),
				new Point(StartX + (int)(Width / 2), StartY - (int)Height),
				new Point(StartX + (int)Width, StartY)
			};
			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
