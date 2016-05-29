using System;

namespace Sample
{
	class Fibonaci
	{
		private static int MAX_TO_FIND = 50;

		private long[] results = new long[MAX_TO_FIND];

		public static void Main (string[] args)
		{
			Fibonaci fibonaci = new Fibonaci ();
			Console.WriteLine ("Fibonaci");
			for (int i = 0; i < MAX_TO_FIND; i++) {
				Console.Write ("of " + i + ": ");
				long result = fibonaci.fib (i);
				Console.WriteLine (result);
			}
		}

		private long fib(int n)
		{
			if (n == 0 || n == 1) {
				results [n] = n;
				return n;
			} else {
				long result = results [n - 2] + results [n - 1];
				results [n] = result;
				return result;
			}
		}
	}
}
