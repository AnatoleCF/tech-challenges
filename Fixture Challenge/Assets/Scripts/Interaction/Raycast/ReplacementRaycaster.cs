using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IWD.FixtureChallenge.Interaction
{
	public class ReplacementRaycaster : SelectionRaycaster
	{
		protected override void OnRaycastHit(RaycastHit hit)
		{
			ISelectable selectable = hit.collider.GetComponentInParent<ISelectable>();

			if (selectable == null)
			{
				if (currentSelectable != null)
				{
					ReplaceCurrent(hit.point);
				}
				Deselect();
			}
			else
			{
				Select(selectable);
			}
		}

		protected void ReplaceCurrent(Vector3 position)
		{
			IReplaceable replaceable = currentSelectable as IReplaceable;
			if (replaceable != null)
			{
				replaceable.Replace(position);
			}
		}

	}
}