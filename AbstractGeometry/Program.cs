﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

            Rectangle rectangle = new Rectangle(100, 50, 400, 50, 3, System.Drawing.Color.Red);
			rectangle.Info(e);

			Square square = new Square(75, 512, 25, 3, Color.DarkBlue);
			square.Info(e);

			Circle circle = new Circle(50, 570, 95, 3, Color.Yellow);
			circle.Info(e);

			IsoscalesTriangle i_triangle = new IsoscalesTriangle(50, 100, 500, 150, 5, Color.Green);
			i_triangle.Info(e);

			EquilateralTriangle e_triangle =
				new EquilateralTriangle(200, 650, 50, 5, Color.GreenYellow);
			e_triangle.Info(e);

			RightTriangle r_triangle =
				new RightTriangle(200, 100, 600, 300, 5, Color.Purple);
			r_triangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
