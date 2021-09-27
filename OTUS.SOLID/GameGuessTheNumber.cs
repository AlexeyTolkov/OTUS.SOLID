using System;

namespace OTUS.SOLID
{
	internal class GameGuessTheNumber
	{
		private int _hiddenNumber;
		private int _numberOfRetries;
		private IGameInterface _gameInterface;
		private bool _won;

		public GameGuessTheNumber(
			INumberGenerator numberGenerator,
			IGameInterface gameInterface)
		{
			_hiddenNumber = numberGenerator.GetNumber();
			_numberOfRetries = Config.NumberOfRetires;
			_gameInterface = gameInterface;
			_won = false;
		}

		public void Play()
		{
			var currentAttempt = 1;
			while (!_won && currentAttempt <= _numberOfRetries)
			{
				ShowMessage($"Попытка {currentAttempt} из {_numberOfRetries}");
				
				CheckTheGuess(_gameInterface.GetUserInput());
				currentAttempt++;
			}

			IsPlayerWon();
		}

		private bool IsPlayerWon()
		{
			if (_won)
			{
				ShowMessage("Поздравляю! Вы угадали!!");
			}
			else
			{
				ShowMessage($"Загаданное число: {_hiddenNumber}");
			}

			return _won;
		}

		private void ShowMessage(string message)
		{
			_gameInterface.ShowOutput(message);
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
	}
}