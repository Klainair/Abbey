using System;

namespace Problem4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] str = new string[Convert.ToInt32 (Console.ReadLine ())];

			for (int i = 0; i < str.Length; i++) {
				string[] s = Console.ReadLine ().Split(' ');

				if (Convert.ToInt32 (s [0]) < Convert.ToInt32 (s [1])) {
					Console.Write (s [0] + " ");
				} else {
					Console.Write (s [1] + " ");
				}
			}
		}
	}
}
