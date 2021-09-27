using System;

namespace OTUS.SOLID
{
	class ConsoleGameInterface : IGameInterface
	{
		public int GetUserInput()
		{
			return int.Parse(Console.ReadLine()); 
		}

		public void ShowOutput(string message)
		{
			Console.WriteLine(message);
		}
	}
}
