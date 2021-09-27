using System;

namespace OTUS.SOLID
{
	public class RandomNumberGenarator : INumberGenerator
	{
		private int _minNumber = Config.MinNumber;
		private int _maxNumber = Config.MaxNumber;

		public RandomNumberGenarator(int? minNumber = null, int? maxNumber = null )
		{
			_minNumber = minNumber ?? _minNumber;
			_maxNumber = maxNumber ?? _maxNumber;
		}

		public int GetNumber()
		{
			return new Random().Next(_minNumber, _maxNumber);
		}
	}
}