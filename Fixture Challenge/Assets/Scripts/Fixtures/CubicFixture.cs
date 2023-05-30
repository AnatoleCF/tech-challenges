using System.Collections.Generic;

namespace IWD.FixtureChallenge.Fixture
{
	[System.Serializable]
	public class CubicFixture : CubicFixtureElement
	{
		public AnchoredCubicFixtureElement backPanel = default;
		public AnchoredCubicFixtureElement header = default;
		public AnchoredCubicFixtureElement footer = default;
		public AnchoredCubicFixtureElement leftSide = default;
		public AnchoredCubicFixtureElement rightSide = default;
		public AnchoredCubicFixtureElement[] shelves = default;

		public List<AnchoredCubicFixtureElement> AllElements
		{
			get
			{
				var list = new List<AnchoredCubicFixtureElement> {
					backPanel,
					header,
					footer,
					leftSide,
					rightSide
				};
				if (shelves != null)
				{
					list.AddRange(shelves);
				}
				return list;
			}
		}

		public CubicFixture()
		{
			header = new AnchoredCubicFixtureElement(AnchorType.Top);
			rightSide = new AnchoredCubicFixtureElement(AnchorType.Right);
		}

		public virtual void ApplyAnchors()
		{
			foreach (var element in AllElements)
			{
				element.ApplyAnchor(this);
			}
		}
	}

}