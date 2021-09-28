namespace OTUS.SOLID
{
	abstract class Game
	{
		protected int _hiddenNumber;
		protected int _numberOfRetries;
		protected IGameInterface _gameInterface;
		protected bool _won;

		public Game(
			INumberGenerator numberGenerator,
			IGameInterface gameInterface)
		{
			_hiddenNumber = numberGenerator.GetNumber();
			_numberOfRetries = Config.NumberOfRetires;
			_gameInterface = gameInterface;
			_won = false;
		}
		internal void ShowEndOfGameMessage()
		{
			if (_won)
			{
				ShowMessage("Поздравляю! Вы угадали!!");
			}
			else
			{
				ShowMessage($"Загаданное число: {_hiddenNumber}");
			}
		}

		internal void ShowMessage(string message)
		{
			_gameInterface.ShowOutput(message);
		}

		internal bool IsTheGameOver(int currentAttempt)
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