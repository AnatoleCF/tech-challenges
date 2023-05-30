using NUnit.Framework;
using UnityEngine;

namespace IWD.FixtureChallenge.Interaction.Tests
{

    public class ReplaceableTests
    {
		[Test]
		public void Replace_ChangesTransformPosition()
		{
			// Arrange
			var replaceable = new GameObject().AddComponent<Replaceable>();
			var initialPosition = new Vector3(1, 2, 3);
			var replacementPosition = new Vector3(4, 5, 6);
			replaceable.transform.position = initialPosition;

			// Act
			replaceable.Replace(replacementPosition);

			// Assert
			Assert.AreEqual(replacementPosition, replaceable.transform.position);
		}
	}

}