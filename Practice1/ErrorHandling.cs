using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class ErrorHandling
    {
		public void Handle()
		{
			try
			{
				int[] numbers = { 1, 2, 3, 4, 5, };
				Console.WriteLine(numbers [6]);
            }
			catch (Exception)
			{
				Console.WriteLine("An Error Occurred");
			}
			finally
			{
				Console.WriteLine("Please Wait");
			}
		}
    }
}
