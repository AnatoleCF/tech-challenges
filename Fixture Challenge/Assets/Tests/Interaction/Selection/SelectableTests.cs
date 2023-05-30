using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;

namespace IWD.FixtureChallenge.Interaction.Tests
{

    public class SelectableTests
    {

		[Test]
		public void Select_SetsIsSelectedToTrueAndInvokesOnSelectEvent()
		{
			// Arrange
			var selectable = new GameObject().AddComponent<Selectable>();
			bool onSelectInvoked = false;
			selectable.OnSelect = new UnityEvent();
			selectable.OnSelect.AddListener(() => onSelectInvoked = true);

			// Act
			selectable.Select();

			// Assert
			Assert.IsTrue(selectable.IsSelected);
			Assert.IsTrue(onSelectInvoked);
		}

		[Test]
		public void Deselect_SetsIsSelectedToFalseAndInvokesOnDeselectEvent()
		{
			// Arrange
			var selectable = new GameObject().AddComponent<Selectable>();
			bool onDeselectInvoked = false;
			selectable.OnDeselect = new UnityEvent();
			selectable.OnDeselect.AddListener(() => onDeselectInvoked = true);

			selectable.Select();

			// Act
			selectable.Deselect();

			// Assert
			Assert.IsFalse(selectable.IsSelected);
			Assert.IsTrue(onDeselectInvoked);
		}
	}

}