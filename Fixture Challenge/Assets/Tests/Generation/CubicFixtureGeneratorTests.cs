using IWD.FixtureChallenge.Fixture;
using IWD.FixtureChallenge.Fixture.Tests;
using NUnit.Framework;
using UnityEngine;

namespace IWD.FixtureChallenge.Generation.Tests
{

    public class CubicFixtureGeneratorTests
    {
		[Test]
		public void Generate_GeneratesElements()
		{
			// Arrange
			var fixture = new MockCubicFixture();
			var parent = new GameObject().transform; // Create a new parent GameObject

			var mockGenerator = ScriptableObject.CreateInstance<MockCubicFixtureGenerator>();
			mockGenerator.MockElementGenerator = ScriptableObject.CreateInstance<MockCubicElementGenerator>();

			// Act
			mockGenerator.Generate(fixture, parent);

			// Assert
			Assert.AreEqual(parent, mockGenerator.Reference);
			Assert.AreEqual(fixture.AllElements.Count, mockGenerator.GenerateCalledCount);
		}

		

	}

}