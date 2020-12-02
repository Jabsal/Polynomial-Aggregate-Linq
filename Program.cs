using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	
	public static int Poly(int x, IEnumerable<int> coeffs)
    {
			var seed = 0;		
		    
            int order = coeffs.ToList().Count - 1;		          
		
			Func<int,int, int> calcAggr = (parcialResult,coeff) => 
			{
				int currentOrder = order--;
				
				var power = (int)Math.Pow(x, currentOrder);
				
				var result1 = parcialResult + coeff * power;

				return result1;
			};
				
			var result = coeffs.Aggregate(seed, calcAggr); 
           			
			return result;
    }
	
	
	public static void Main()
	{
		var coeffs = new List<int>{3,4,5};
		var gradoPoly = 2;
		
		var tempResult = Poly(gradoPoly,coeffs);
		Console.WriteLine(tempResult);
	}

}
