namespace IWD.FixtureChallenge.Fixture.Tests
{
	public class MockAnchoredCubicFixtureElement : AnchoredCubicFixtureElement
	{
		public bool ApplyAnchorCalled { get; private set; }
		public CubicFixtureElement ApplyAnchorReference { get; private set; }

		public MockAnchoredCubicFixtureElement() : base(AnchorType.Default)
		{
		}

		public override void ApplyAnchor(CubicFixtureElement reference)
		{
			ApplyAnchorCalled = true;
			ApplyAnchorReference = reference;
		}
	} 
}