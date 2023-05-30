using UnityEngine;

namespace IWD.FixtureChallenge.Fixture
{
	[System.Serializable]
	public class CubicFixtureElement : BaseFixtureElement
	{
		public int width = default;
		public int height = default;
		public int depth = default;

		public Vector3 Size
		{
			get
			{
				return new Vector3(width, height, depth);
			}
		}


	}

}