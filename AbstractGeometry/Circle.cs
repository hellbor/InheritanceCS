using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle:Shape,IHaveDiameter
	{
		public double radius;
		public double Radius
		{
			get => radius;
			set => radius = SizeFilter(value);
		}
		public Circle
			(
			double radius,
			int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{
			Radius = radius;
		}
		public double GetDiameter() => 2 * Radius;
		public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
		public override double GetPerimeter() => 2 * Math.PI * Radius;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, 2 * (float)Radius, 2 * (float)Radius);
			DrawDiameter(e);
		}
		public void DrawDiameter(System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.DrawLine
				(
					new Pen(Color, 1),
					StartX, StartY,
					StartX + (int)GetDiameter(), StartY + (int)GetDiameter()
				);
		}
		public override void Info(PaintEventArgs e)
		{
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Радиус круга: {Radius}");
            base.Info(e);
		}
	}
}
