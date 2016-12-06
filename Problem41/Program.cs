using System;
using System.Linq;

//Rebuild
namespace Problem41
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = Convert.ToInt16 (Console.ReadLine ());

			for (int i = 0; i < n; i++) {
				string[] str = Console.ReadLine ().Split (' ');
				int[] m = new int[str.Length];

				for (int j = 0; j < m.Length; j++) {
					m [j] = Convert.ToInt32 (str [j]);
				}

				for (int l = 0; l < m.Length; l++) {
					if (m [l] < m.Max () && m [l] > m.Min()) {
						Console.Write (m [l] + " ");
					}
				}
					
			}
		}
	}
}
