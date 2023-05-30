using NUnit.Framework;
using UnityEngine;

namespace IWD.FixtureChallenge.Interaction.Tests
{

	public class SelectionRaycasterTests
	{
		[Test]
		public void OnRaycastHit_WithSelectable_CallsSelectOnSelectable()
		{
			// Arrange
			var raycaster = new GameObject().AddComponent<MockSelectionRaycaster>();
			raycaster.transform.position = Vector3.zero;

			var hitObject = new GameObject();
			var selectable = hitObject.AddComponent<Selectable>();
			var collider = hitObject.AddComponent<BoxCollider>();
			hitObject.transform.position = Vector3.forward * 10;
			collider.size = Vector3.one;
			collider.center = Vector3.zero;

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
			Assert.AreEqual(selectable, raycaster.CurrentSelectable);
		}

		[Test]
		public void OnRaycastHit_WithoutSelectable_CallsDeselect()
		{
			// Arrange
			var raycaster = new GameObject().AddComponent<MockSelectionRaycaster>();
			raycaster.transform.position = Vector3.zero;

			var hitObject = new GameObject();
			var collider = hitObject.AddComponent<BoxCollider>();
			hitObject.transform.position = Vector3.forward * 10;
			collider.size = Vector3.one;
			collider.center = Vector3.zero;

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
		}

		[Test]
		public void OnRaycastFailed_CallsDeselect()
		{
			// Arrange
			var raycaster = new GameObject().AddComponent<MockSelectionRaycaster>();

			// Act
			raycaster.Mock_OnRaycastFailed();

			// Assert
			Assert.IsNull(raycaster.CurrentSelectable);
		}

	}

}