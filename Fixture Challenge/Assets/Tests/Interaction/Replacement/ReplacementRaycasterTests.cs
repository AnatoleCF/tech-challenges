using NUnit.Framework;
using UnityEngine;

namespace IWD.FixtureChallenge.Interaction.Tests
{
	public class ReplacementRaycasterTests
	{

		[Test]
		public void OnRaycastHit_WithNonSelectable_CallsDeselectAndReplaceCurrent()
		{
			// Arrange
			var raycaster = new GameObject().AddComponent<MockReplacementRaycaster>();
			raycaster.transform.position = Vector3.zero;

			var hitObject = new GameObject();
			hitObject.transform.position = Vector3.forward * 10;
			var collider = hitObject.AddComponent<BoxCollider>();
			collider.size = Vector3.one;
			collider.center = Vector3.zero;

			var replaceable = new GameObject().AddComponent<Replaceable>();

			raycaster.SetCurrentSelectable(replaceable);


			Ray ray = new Ray(raycaster.transform.position, Vector3.forward);
			RaycastHit hit;

			// Act
			if (Physics.Raycast(ray, out hit))
			{
				raycaster.Mock_OnRaycastHit(hit);
			}
			else
			{
				Assert.Fail("Raycast was unsuccessful");
			}

			// Assert
			Assert.IsNull(raycaster.CurrentSelectable);

			Assert.IsFalse(replaceable.IsSelected);
			Assert.AreEqual(hit.point, replaceable.transform.position);
		}

		[Test]
		public void ReplaceCurrent_WithReplaceable_Replaces()
		{
			// Arrange
			var raycaster = new GameObject().AddComponent<MockReplacementRaycaster>();
			var replaceable = new GameObject().AddComponent<Replaceable>();
			replaceable.transform.position = Vector3.zero;

			raycaster.SetCurrentSelectable(replaceable);

			// Act
			raycaster.Mock_ReplaceCurrent(Vector3.one);

			// Assert
			Assert.AreEqual(Vector3.one, replaceable.transform.position);
		}

		[Test]
		public void ReplaceCurrent_WithoutReplaceable_DoesNotReplace()
		{
			// Arrange
			var raycaster = new GameObject().AddComponent<MockReplacementRaycaster>();
			var selectable = new GameObject().AddComponent<Selectable>();
			selectable.transform.position = Vector3.zero;

			raycaster.SetCurrentSelectable(selectable);

			// Act
			raycaster.Mock_ReplaceCurrent(Vector3.one);

			// Assert
			Assert.AreEqual(Vector3.zero, selectable.transform.position);
		}

	}
}