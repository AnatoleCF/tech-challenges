using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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