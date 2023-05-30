using UnityEngine;

namespace IWD.FixtureChallenge.Fixture
{
	public abstract class BaseFixtureElement
	{
		public float x = default;
		public float y = default ;
		public float z = default;


		public Vector3 Position
		{
			get
			{
				return new Vector3(x, y, z);
			}
		}
	}
}