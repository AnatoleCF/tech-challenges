using UnityEngine;

namespace IWD.FixtureChallenge.Interaction
{
	public class SelectionRaycaster : BaseMouseRaycaster
	{
		protected ISelectable currentSelectable = default;

		public ISelectable CurrentSelectable
		{
			get
			{
				return currentSelectable;
			}
		}

		protected override void OnRaycastHit(RaycastHit hit)
		{
			ISelectable selectable = hit.collider.GetComponentInParent<ISelectable>();

			if (selectable == null)
			{
				Deselect();
			}
			else
			{
				Select(selectable);
			}

		}

		protected override void OnRaycastFailed()
		{
			Deselect();
		}

		protected void Select(ISelectable selectable)
		{
			Deselect();

			currentSelectable = selectable;
			currentSelectable.Select();
		}


		protected void Deselect()
		{
			if(currentSelectable == null)
			{
				return;
			}

			currentSelectable.Deselect();
			currentSelectable = null;
		}
	}

}