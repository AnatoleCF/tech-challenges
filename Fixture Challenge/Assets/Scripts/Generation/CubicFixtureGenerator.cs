using IWD.FixtureChallenge.Fixture;
using UnityEngine;

namespace IWD.FixtureChallenge.Generation
{
	[CreateAssetMenu(menuName = "IWD/Generator/Cubic/Fixture")]
	public class CubicFixtureGenerator : BaseElementGenerator<CubicFixture>
	{

		[SerializeField]
		protected CubicElementGenerator _CubicElementGenerator = default;

		public override void Generate(CubicFixture fixture, Transform parent)
		{
			foreach (var item in fixture.AllElements)
			{
				_CubicElementGenerator.Generate(item, parent);
			}
		}
	}

}