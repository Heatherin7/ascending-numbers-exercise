using System;

namespace AscendingNumbers
{
	public class AscendingNumberValidator
	{
		/// <summary>
		/// Returns true if the numbers array parameter contains a set of consecutive ascending numbers,
		/// otherwise return false.
		/// </summary>
		public bool IsAscending(int[] numbers)
		{ 
			if(numbers.Length == 0)
      {
				return false;
      }

			for (int num = 0; num < numbers.Length - 1; num++)
      {
				if (numbers[num] + 1 != numbers[num + 1])
        {
					return false;
        }
      }

			return true;
		}
	}
}
