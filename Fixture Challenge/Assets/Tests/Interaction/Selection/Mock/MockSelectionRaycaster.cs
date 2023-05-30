using UnityEngine;

namespace IWD.FixtureChallenge.Interaction.Tests
{

    public class MockSelectionRaycaster : SelectionRaycaster
    {
        //AC 30/05 : (We could also have those method being public in the BaseRaycaster class...)

        public void Mock_OnRaycastHit(RaycastHit hit)
        {
            OnRaycastHit(hit); 
        }

		public void Mock_OnRaycastFailed()
		{
			OnRaycastFailed();
		}
	}

}