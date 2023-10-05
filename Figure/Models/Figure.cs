using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalCulation
{
	/// <summary>
	/// Фигура.
	/// </summary>
	public abstract class Figure
	{
		/// <summary>
		/// Вычисление площади фигуры.
		/// </summary>
		/// <returns> Площадь фигуры.</returns>
		public abstract double CalculateSquare();
	}
}
