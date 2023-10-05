using System;

namespace FigureCalCulation
{
	/// <summary>
	/// Круг.
	/// </summary>
	public class Circle : Figure
	{
		private double _radius;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="radius"> Радиус.</param>
		public Circle(double radius)
		{
			Radius = radius;
		}

		/// <summary>
		/// Радиус.
		/// </summary>
		public double Radius 
		{
			get => _radius;
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException(nameof(Radius));
				}

				_radius = value;
			}
		}

		/// <summary>
		/// Рассчет площади круга.
		/// </summary>
		/// <returns> Площадь.</returns>
		public override double CalculateSquare()
		{
			try
			{
				return Math.PI * Radius * Radius;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
