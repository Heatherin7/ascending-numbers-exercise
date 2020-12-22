using AscendingNumbers;
using NUnit.Framework;

namespace AscendingNumbersTests
{
	public class Tests
	{
		private AscendingNumberValidator _ascendingNumbers;

		[SetUp]
		public void Setup() => _ascendingNumbers = new AscendingNumberValidator();

		[TestCase(true, 1)]
		[TestCase(true, 100)]
		[TestCase(true, 1, 2, 3)]
		[TestCase(false, 1, 2, 2, 3)]
		[TestCase(true, 4, 5, 6)]
		[TestCase(false, 10, 12, 13)]
		[TestCase(true, -2, -1, 0, 1, 2)]
		[TestCase(true, -10, -9, -8)]
		[TestCase(false, -100, -99, -97, -96)]
		[TestCase(false)]
		public void Returns_True_For_Ascending_Array(bool expectedResult, params int[] numbers)
		{
			var result = _ascendingNumbers.IsAscending(numbers);
			Assert.AreEqual(expectedResult, result);
		}
	}
}