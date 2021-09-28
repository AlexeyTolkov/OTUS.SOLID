using System;

namespace OTUS.SOLID
{
	internal class GameGuessTheNumber : Game
	{
		public GameGuessTheNumber(
			INumberGenerator numberGenerator,
			IGameInterface gameInterface)
			: base(numberGenerator, gameInterface)
		{
		}

		public override void Play()
		{
			var currentAttempt = 1;
			while (!IsTheGameOver(currentAttempt))
			{
				ShowMessage($"Попытка {currentAttempt} из {_numberOfRetries}");
				CheckTheGuess(_gameInterface.GetPlayerInput());

				currentAttempt++;
			}
		}

		private void CheckTheGuess(int userNumber)
		{
			if (userNumber == _hiddenNumber)
			{
				_won = true;
			}
			else
			{
				if (userNumber < _hiddenNumber)
				{
					ShowMessage("Больше!");
				}

				if (userNumber > _hiddenNumber)
				{
					ShowMessage("Меньше!");
				}
			}
		}

		internal override bool IsTheGameOver(int currentAttempt)
		{
			if (!_won && currentAttempt <= _numberOfRetries)
			{
				return false;
			}
			else
			{
				ShowEndOfGameMessage();
				return true;
			}
		}
	}
}