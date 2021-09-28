using System;

namespace OTUS.SOLID
{
	class ConsoleGameInterface : IGameInterface
	{
		public int GetPlayerInput()
		{
			return int.Parse(Console.ReadLine()); 
		}

		public void ShowOutput(string message)
		{
			Console.WriteLine(message);
		}
	}
}
