using IWD.FixtureChallenge.Fixture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IWD.FixtureChallenge.Generation
{
	public abstract class BaseElementGenerator<T> : ScriptableObject where T : BaseFixtureElement
	{
		public virtual float ScaleFactor
		{
			get
			{
				return .001f;
			}
		}

		public abstract void Generate(T fixtureElement, Transform parent);
	}

}