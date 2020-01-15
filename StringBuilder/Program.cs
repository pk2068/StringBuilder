using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringBuilderNamespace
{
	class Program
	{
		public static bool CompareStringsFirstTry( string A,string B,string C )
		{
			if (A + B == C)
				return true;
			else
				return false;
		}

		public static bool CompareStringsSecondTry( string A,string B,string C )
		{
			string concatStrings = A + B;
			bool result = (concatStrings.ToString().ToUpper() == C.ToUpper());
			return result;
		}

		public static bool CompareStringsThirdTry( string A,string B,string C )
		{
			StringBuilder AB = new StringBuilder(A);
			AB.Append(B);		

			bool result = ( AB.ToString().ToUpper() == C.ToUpper() );
			return result;
		}

		static void Main( string[] args )
		{
			String string1 = new string('a',14000);
			
			String string2 = new string('b',14000);
			//string1 = "kaka";
			//string2 = "caka";
			String string3 = new string('c',30000);
			string3 = string1 + string2; 


			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			Console.WriteLine(CompareStringsFirstTry(string1, string2, string3));
			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;
			string elapsedTime = String.Format("{0}",ts.TotalMilliseconds);
			Console.WriteLine("RunTime " + elapsedTime + Environment.NewLine);


			stopWatch.Reset();
			stopWatch.Start();
			Console.WriteLine(CompareStringsSecondTry(string1,string2,string3));
			stopWatch.Stop();
			ts = stopWatch.Elapsed;
			elapsedTime = String.Format("{0}", ts.TotalMilliseconds);
			Console.WriteLine("RunTime " + elapsedTime + Environment.NewLine);

			stopWatch.Reset();
			stopWatch.Start();
			stopWatch.Restart();
			stopWatch.Stop();
			Console.WriteLine(CompareStringsThirdTry(string1,string2,string3));
			stopWatch.Stop();
			ts = stopWatch.Elapsed;
			elapsedTime = String.Format("{0}",ts.TotalMilliseconds);
			Console.WriteLine("RunTime " + elapsedTime + Environment.NewLine);


		}
	}
}
