using NUnit.Framework;

namespace IWD.FixtureChallenge.Fixture.Tests
{

	public class CubicFixtureTests
	{
		[Test]
		public void AllElements_ReturnsCorrectList()
		{
			// Arrange
			var fixture = new MockCubicFixture();

			// Act
			var elements = fixture.AllElements;

			// Assert
			Assert.IsNotNull(elements);
			Assert.AreEqual(7, elements.Count);
			Assert.Contains(fixture.backPanel, elements);
			Assert.Contains(fixture.header, elements);
			Assert.Contains(fixture.footer, elements);
			Assert.Contains(fixture.leftSide, elements);
			Assert.Contains(fixture.rightSide, elements);
			Assert.Contains(fixture.shelves[0], elements);
			Assert.Contains(fixture.shelves[1], elements);
		}

		[Test]
		public void ApplyAnchors_AppliesAnchorsToAllElements()
		{
			// Arrange
			var fixture = new MockCubicFixture();
			var mockBackPanel = fixture.backPanel as MockAnchoredCubicFixtureElement;
			var mockElement1 = new MockAnchoredCubicFixtureElement();
			var mockElement2 = new MockAnchoredCubicFixtureElement();
			
			fixture.shelves = new MockAnchoredCubicFixtureElement[2]
			{
				mockElement1,
				mockElement2
			};

			// Act
			fixture.ApplyAnchors();

			// Assert
			Assert.IsTrue(mockBackPanel.ApplyAnchorCalled);
			Assert.AreEqual(fixture, mockBackPanel.ApplyAnchorReference);

			// AC 30/05 : (Should also be testing the other 'core' elements...)

			Assert.IsTrue(mockElement1.ApplyAnchorCalled);
			Assert.AreEqual(fixture, mockElement1.ApplyAnchorReference);
			Assert.IsTrue(mockElement2.ApplyAnchorCalled);
			Assert.AreEqual(fixture, mockElement2.ApplyAnchorReference);
		}
	}

	

}