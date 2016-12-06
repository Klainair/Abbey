using System;

namespace Problem6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] str = Console.ReadLine ().Split (' ');
			int max = Convert.ToInt32 (str [0]);
			int min = Convert.ToInt32 (str [0]);

			for (int i = 0; i < str.Length; i++) {
				if (Convert.ToInt32 (str [i]) > max) {
					max = str [i];
				}

				if (Convert.ToInt32 (str [i]) < min) {
					min = str [i];
				}
			}

			Console.Write ("{0} {1}", max, min);
		}
	}
}
