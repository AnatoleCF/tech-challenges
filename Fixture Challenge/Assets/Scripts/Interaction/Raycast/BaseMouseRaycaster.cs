using UnityEngine;

namespace IWD.FixtureChallenge.Interaction
{

	public abstract class BaseMouseRaycaster : MonoBehaviour
	{

		// Update is called once per frame
		void Update()
		{
			if (RaycastInput())
			{
				RaycastUpdate();
			}
		}

		protected virtual bool RaycastInput()
		{
			return Input.GetMouseButtonDown(0);
		}

		protected virtual void RaycastUpdate()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				OnRaycastHit(hit);
			}
			else
			{
				OnRaycastFailed();
			}
		}

		protected abstract void OnRaycastHit(RaycastHit hit);
		protected abstract void OnRaycastFailed();

	}

}