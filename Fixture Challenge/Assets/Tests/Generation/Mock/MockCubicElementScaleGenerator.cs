using UnityEngine;

namespace IWD.FixtureChallenge.Generation.Tests
{

    public class MockCubicElementScaleGenerator : CubicElementScaleGenerator
	{
        public MockCubicElementScaleGenerator() {
			_CubePrefab = new GameObject();
		}
    }

}