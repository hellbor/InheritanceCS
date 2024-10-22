using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract internal class Triangle : Shape
	{
		public abstract double GetHeight();
		public Triangle(int StartX, int StartY, int lineWidth,Color color)
			: base(StartX, StartY, lineWidth, color) { }
		public override void Info(PaintEventArgs e)
		{
            Console.WriteLine($"Высота треугольника: {GetHeight()}");
            base.Info(e);
		}
	}
}
