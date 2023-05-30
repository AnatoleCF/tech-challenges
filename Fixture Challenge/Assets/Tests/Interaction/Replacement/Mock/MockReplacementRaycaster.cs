using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IWD.FixtureChallenge.Interaction.Tests
{

    public class MockReplacementRaycaster : ReplacementRaycaster
	{
        public void SetCurrentSelectable(ISelectable selectable)
        {
            currentSelectable = selectable;
        }
		public void Mock_OnRaycastHit(RaycastHit hit)
		{
			OnRaycastHit(hit);
		}

		public void Mock_ReplaceCurrent(Vector3 position)
        {
            ReplaceCurrent(position);
        }
    }

}