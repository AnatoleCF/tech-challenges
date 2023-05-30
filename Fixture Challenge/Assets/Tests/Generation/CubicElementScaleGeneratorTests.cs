
using IWD.FixtureChallenge.Fixture;
using NUnit.Framework;
using UnityEngine;

namespace IWD.FixtureChallenge.Generation.Tests
{

    public class CubicElementScaleGeneratorTests
    {
		[Test]
		public void Generate_SetsScaleAndPositionOfInstantiatedCube()
		{
			// Arrange
			var fixtureElement = new CubicFixtureElement
			{
				x = 3,
				y = 3,
				z = 3,
				width = 2,
				height = 2,
				depth= 2
			};
			var parent = new GameObject().transform;

			var generator = new MockCubicElementScaleGenerator();


			// Act
			generator.Generate(fixtureElement, parent);

			// Assert
			var instantiatedCube = parent.GetChild(0);
			Assert.AreEqual(fixtureElement.Size * generator.ScaleFactor, instantiatedCube.localScale);
			Assert.AreEqual(fixtureElement.Position * generator.ScaleFactor, instantiatedCube.localPosition);
		}
	}

}