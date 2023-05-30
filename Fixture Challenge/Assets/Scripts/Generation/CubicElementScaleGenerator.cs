using IWD.FixtureChallenge.Fixture;
using UnityEngine;

namespace IWD.FixtureChallenge.Generation
{
	[CreateAssetMenu(menuName = "IWD/Generator/Cubic/Scale")]
	public class CubicElementScaleGenerator : CubicElementGenerator
	{
		[SerializeField]
		protected GameObject _CubePrefab = default;

		public override void Generate(CubicFixtureElement fixtureElement, Transform parent)
		{
			var element = Instantiate(_CubePrefab, parent);
			element.transform.localScale = fixtureElement.Size * ScaleFactor;
			element.transform.localPosition = fixtureElement.Position * ScaleFactor;
		}

	}

}