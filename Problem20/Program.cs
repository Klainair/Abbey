using System;

namespace Problem20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine ());

			int[] m = new int[n];

			for (int i = 0; i < n; i++) {
				string str = Console.ReadLine ();
				foreach (char c in str) {
					if (c == 'a' |
						c == 'o' |
						c == 'u' |
						c == 'i' |
						c == 'e' | 
						c == 'y') {
						m [i]++;
					}
				}
											
			}

			foreach (int i in m)
				Console.Write (i + " ");
		}
	}
}
