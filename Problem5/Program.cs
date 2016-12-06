using System;
using System.Linq;

namespace Problem5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] str = new string[Convert.ToInt32(Console.ReadLine())];

			for (int i = 0; i < str.Length; i++) {
				string[] s = Console.ReadLine ().Split (' ');
				int[] m = new int[s.Length];

				for (int j = 0; j < s.Length; j++) {
					m [j] = Convert.ToInt32 (s [j]);
				}

				Console.Write (m.Min()+" ");
			}
		}
	}
}
