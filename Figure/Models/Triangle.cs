using System;

namespace FigureCalCulation
{
	/// <summary>
	/// Треугольник.
	/// </summary>
	public class Triangle : Figure
	{
		private double _sideFirst;
		private double _sideSecond;
		private double _sideThird;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="sideFirst"> Первая сторона.</param>
		/// <param name="sideSecond"> Вторая сторона.</param>
		/// <param name="thirdSide"> Третья сторона.</param>
		public Triangle(double sideFirst, double sideSecond, double thirdSide)
		{
			SideFirst = sideFirst;
			SideSecond = sideSecond;
			ThirdSide = thirdSide;
		}

		/// <summary>
		/// Первая сторона треугольника.
		/// </summary>
		public double SideFirst
		{
			get => _sideFirst;
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException(nameof(SideFirst));
				}

				_sideFirst = value;
			}
		}

		/// <summary>
		/// Вторая сторона треугольника.
		/// </summary>
		public double SideSecond 
		{
			get => _sideSecond;
			set 
			{
				if (value <= 0)
				{
					throw new ArgumentException(nameof(SideSecond));
				}

				_sideSecond = value;
			}
		}

		/// <summary>
		/// Третья сторона треугольника.
		/// </summary>
		public double ThirdSide 
		{
			get => _sideThird;
			set 
			{
				if (value <= 0)
				{
					throw new ArgumentException(nameof(ThirdSide));
				}

				_sideThird = value;
			}
		}

		/// <summary>
		/// Рассчет площади треугольника по трем сторонам.
		/// </summary>
		/// <returns> Площадь треугольника.</returns>
		public override double CalculateSquare()
		{
			try
			{
				var perimter = CalculatePerimetr();

				return Math.Sqrt(perimter / 2 * (perimter / 2 - SideFirst) * (perimter / 2 - SideSecond) * (perimter / 2 - ThirdSide));
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Возвращает логическое значение, является ли треугольник прямоугольным.
		/// </summary>
		/// <returns> Логическое значение.</returns>
		public bool IsRightTriangle()
		{
			return (SideFirst * SideFirst + SideSecond * SideSecond == ThirdSide * ThirdSide)
				|| (SideFirst * SideFirst + ThirdSide * ThirdSide == SideSecond * SideSecond)
				|| (SideSecond * SideSecond + ThirdSide * ThirdSide == SideFirst * SideFirst);
		}

		/// <summary>
		/// Вычисление периметра треугольника.
		/// </summary>
		/// <returns> Периметр.</returns>
		private double CalculatePerimetr() => SideFirst + SideSecond + ThirdSide;
	}
}
