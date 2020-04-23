using System;
using NUnit;
using NUnit.Framework;

namespace MiddleCharactersOfString
{
	[TestFixture]
	public class MiddleCharactersOfStrings
	{
		[Test]
		public void GivenString_FourCharactersLong_ShouldReturnMiddleTwoChars()
		{
			//arrange
			var fullString = "test";
			//act
			var expected = "es";
			var actual = GetMiddleChars(fullString);
			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void GivenString_WithOddNumberOfChars_ShouldReturnMiddleChar()
		{
			//arrange
			var fullString = "testing";
			//act
			var expected = "t";
			var actual = GetMiddleChars(fullString);
			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void GivenString_WithEvenNumberOfChars_ShouldReturnMiddleTwoChars()
		{
			//arrange
			var fullString = "middle";
			//act
			var expected = "dd";
			var actual = GetMiddleChars(fullString);
			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void GivenString_WithOneChar_ShouldReturnTheSingularChar()
		{
			//arrange
			var fullString = "A";
			//act
			var expected = "A";
			var actual = GetMiddleChars(fullString);
			//Assert
			Assert.AreEqual(expected, actual);
		}

		private object GetMiddleChars(string fullString)
		{
			if (fullString.Length == 1)
				return fullString;

			return (fullString.Length % 2 == 0 && fullString.Length >= 1) 
					? fullString.Substring((fullString.Length / 2) - 1, 2) 
					: fullString.Substring((fullString.Length / 2),1);
		}
	}
}
