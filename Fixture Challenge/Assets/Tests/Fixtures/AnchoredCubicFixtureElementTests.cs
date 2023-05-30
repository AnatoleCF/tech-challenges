using NUnit.Framework;

namespace IWD.FixtureChallenge.Fixture.Tests
{

	public class AnchoredCubicFixtureElementTests
	{
		// AC 30/05 : (Should also be testing other AnchorTypes...)

		[Test]
		public void ApplyAnchor_NoOverrideValues_AppliesAnchorsCorrectly()
		{
			// Arrange
			var reference = new CubicFixtureElement
			{
				width = 10,
				height = 20,
				depth = 30
			};

			var element = new AnchoredCubicFixtureElement(AnchorType.Right)
			{
				width = 5,
				height = 5,
			};

			// Act
			element.ApplyAnchor(reference);

			// Assert
			Assert.AreEqual(5, element.width);
			Assert.AreEqual(5, element.height);
			Assert.AreEqual(30, element.depth);
			Assert.AreEqual(5, element.x);
			Assert.AreEqual(0, element.y);
			Assert.AreEqual(0, element.z);
		}

		[Test]
		public void ApplyAnchor_OverrideValues_AppliesAnchorsWithOverrides()
		{
			// Arrange
			var reference = new CubicFixtureElement
			{
				width = 10,
				height = 20,
				depth = 30
			};

			var element = new AnchoredCubicFixtureElement(AnchorType.Top)
			{
				width = 5,
				height = 5,
				depth = 5,
				x = 2,
				y = 2
			};

			// Act
			element.ApplyAnchor(reference);

			// Assert
			Assert.AreEqual(5, element.width);
			Assert.AreEqual(5, element.height);
			Assert.AreEqual(5, element.depth);
			Assert.AreEqual(2, element.x);
			Assert.AreEqual(2, element.y);
		}
	}

}