using System;

namespace Problem2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] str = new string[Convert.ToInt32 (Console.ReadLine ())];
			str = Console.ReadLine ().Split (' ');

			int summ = 0;

			for (int i = 0; i < str.Length; i++) {
				summ += Convert.ToInt32 (str [i]);
			}

			Console.WriteLine (summ);
		}
	}
}
