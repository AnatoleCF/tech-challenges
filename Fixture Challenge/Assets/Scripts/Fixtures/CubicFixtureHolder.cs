namespace IWD.FixtureChallenge.Fixture
{

	public class CubicFixtureHolder : BaseFixtureHolder<CubicFixture>
    {

		protected override void Deserialize()
		{
			base.Deserialize();
			element.ApplyAnchors();
		}

	}

}