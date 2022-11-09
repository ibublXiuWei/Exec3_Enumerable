using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var result = Enumerable.Range(1, 10);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			var result2=Enumerable.Range(10, 6);
			foreach (var item in result2)
			{
				Console.WriteLine(item);
			}
			
		}
	}
}
