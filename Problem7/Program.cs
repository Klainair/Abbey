using System;

namespace Problem7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] str = Console.ReadLine ().Split (' ');

			for (int i = 1; i < str.Length; i++) {
				Console.Write (Math.Round((Convert.ToDouble(str[i])-32)*5/9) + " ");
			}
		}
	}
}
