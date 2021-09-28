using System;

namespace OTUS.SOLID
{
	internal class GameLauncher
	{
		private Game _game;

		public GameLauncher(GameGuessTheNumber game)
		{
			_game = game;
		}

		internal void Run()
		{
			_game?.Play();
		}
	}
}