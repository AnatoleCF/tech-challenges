using IWD.FixtureChallenge.Fixture;
using NUnit.Framework;
using UnityEngine;

namespace IWD.FixtureChallenge.Generation.Tests
{

	public class MockCubicFixtureGenerator : CubicFixtureGenerator
	{
		public Transform Reference { get; private set; }
		public int GenerateCalledCount { get; private set; }

		public MockCubicElementGenerator MockElementGenerator
		{
			get
			{
				return _CubicElementGenerator as MockCubicElementGenerator;
			}

			set
			{
				_CubicElementGenerator = value;
			}
		}

		public override void Generate(CubicFixture fixture, Transform parent)
		{
			Reference = parent;
			foreach (var item in fixture.AllElements)
			{
				GenerateCalledCount++;
				_CubicElementGenerator.Generate(item, parent);
			}
		}
	} 
}