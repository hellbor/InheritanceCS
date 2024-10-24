using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class RightTriangle:Triangle
	{
		double side_1;
		double side_2;
		public double Side_1
		{
			get => side_1;
			set => side_1 = SizeFilter(value);
		}
		public double Side_2
		{
			get => side_2;
			set => side_2 = SizeFilter(value);
		}
		public RightTriangle
			(
			double side_1, double side_2,
			int startX, int startY, int lineWidth, System.Drawing.Color color
			) : base(startX, startY, lineWidth, color)
		{
			Side_1 = side_1;
			Side_2 = side_2;
		}
		public override double GetHeight() => Side_2;
		public override double GetArea() => Side_1 * Side_2 / 2;
		public double GetHypotenuse() => Math.Sqrt(Side_1 * Side_1 + Side_2 * Side_2);
		public override double GetPerimeter() => Side_1 + Side_2 + GetHypotenuse();
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points = new Point[]
			{
				new Point(StartX, StartY),
				new Point(StartX, StartY + (int)Side_2),
				new Point(StartX + (int)Side_1, StartY + (int)Side_2)
			};
			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
