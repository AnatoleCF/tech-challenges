using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IWD.FixtureChallenge.Interaction
{
	public class Replaceable : Selectable, IReplaceable
	{
		public void Replace(Vector3 position)
		{
			transform.position = position;
		}
	}
}