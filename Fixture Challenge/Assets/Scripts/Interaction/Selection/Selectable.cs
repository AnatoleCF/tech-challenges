using UnityEngine;
using UnityEngine.Events;

namespace IWD.FixtureChallenge.Interaction
{

	public class Selectable : MonoBehaviour, ISelectable
	{
		protected bool isSelected = default;

		public bool IsSelected
		{
			get
			{
				return isSelected;
			}
			set
			{
				isSelected = value;
			}
		}

		public UnityEvent OnSelect = default;
		public UnityEvent OnDeselect = default;


		public void Select()
		{
			if(IsSelected)
			{
				return;
			}
			IsSelected = true;
			OnSelect?.Invoke();
		}

		public void Deselect()
		{
			if (!IsSelected)
			{
				return;
			}
			IsSelected = false;
			OnDeselect?.Invoke();
		}

	}

}