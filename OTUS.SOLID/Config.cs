using System.Configuration;

namespace OTUS.SOLID
{
	public class Config
	{
		public static int MinNumber
		{
			get
			{
				return int.Parse(
					ConfigurationManager.AppSettings["minValue"]);
			}
		}
		public static int MaxNumber
		{
			get
			{
				return int.Parse(
					ConfigurationManager.AppSettings["maxValue"]);
			}
		}
		public static int NumberOfRetires
		{
			get
			{
				return int.Parse(
					ConfigurationManager.AppSettings["numberOfRetries"]);
			}
		}
	}
}
