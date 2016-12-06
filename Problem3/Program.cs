using System;

namespace Problem3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] str = new string[Convert.ToInt32 (Console.ReadLine ())];

			for (int i = 0; i < str.Length; i++) {
				string[] summ = Console.ReadLine ().Split (' ');
				int s = Convert.ToInt32 (summ [0]) + Convert.ToInt32 (summ [1]);
				Console.Write (s + " ");
			}
		}
	}
}
