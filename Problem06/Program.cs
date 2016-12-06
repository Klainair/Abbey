using System;

namespace Problem06
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = Convert.ToInt32 (Console.ReadLine ());

			for (int i = 0; i < n; i++) {
				string[] str = Console.ReadLine ().Split (' ');

				Console.Write (Math.Round (Convert.ToDecimal (str [0]) / Convert.ToDecimal (str [1])) + " ");
			}
		}
	}
}
