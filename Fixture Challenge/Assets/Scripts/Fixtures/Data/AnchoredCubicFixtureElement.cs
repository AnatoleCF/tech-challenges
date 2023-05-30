namespace IWD.FixtureChallenge.Fixture
{
	public enum AnchorType
	{
		Default,
		Right,
		Top,
	}

	[System.Serializable]
	public class AnchoredCubicFixtureElement : CubicFixtureElement
	{

		public AnchorType Anchor = AnchorType.Default;

		public AnchoredCubicFixtureElement(AnchorType anchorType)
		{
			Anchor = anchorType;
		}

		public virtual void ApplyAnchor(CubicFixtureElement reference)
		{
			width = width == 0 ? reference.width : width;
			height = height == 0 ? reference.height : height;
			depth = depth == 0 ? reference.depth : depth;

			switch (Anchor)
			{
				case AnchorType.Right:
					x = x == 0 ? (reference.width - width) : x;
					break;

				case AnchorType.Top:
					y = y == 0 ? (reference.height - height) : y;
					break;
			}
		}
	}

}