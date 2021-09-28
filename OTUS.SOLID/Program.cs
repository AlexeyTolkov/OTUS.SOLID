namespace OTUS.SOLID
{
	partial class Program
	{
		static void Main(string[] args)
		{
			var game = new GameGuessTheNumber(new RandomNumberGenarator(), new ConsoleGameInterface());
			var gameLauncher = new GameLauncher(game);
			
			gameLauncher.Run();
		}
	}
}
