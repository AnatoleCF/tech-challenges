namespace IWD.FixtureChallenge.Fixture.Tests
{

	public class MockCubicFixture : CubicFixture
	{
		public MockCubicFixture(int shelveCount = 2)
		{
			backPanel = new MockAnchoredCubicFixtureElement();
			header = new MockAnchoredCubicFixtureElement();
			footer = new MockAnchoredCubicFixtureElement();
			rightSide = new MockAnchoredCubicFixtureElement();
			leftSide = new MockAnchoredCubicFixtureElement();

			shelves = new MockAnchoredCubicFixtureElement[2];
			for (int i = 0; i < shelveCount; i++)
			{
				shelves[i] = new MockAnchoredCubicFixtureElement();
			}
		}
	}

}