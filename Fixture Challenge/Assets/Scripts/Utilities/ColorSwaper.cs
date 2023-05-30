using IWD.FixtureChallenge.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwaper : MonoBehaviour
{
	private void Start()
	{
		var selectable = GetComponent<Selectable>();

		if(selectable != null)
		{
			selectable.OnSelect.AddListener(delegate
			{
				SwapColors(Color.blue);
			});

			selectable.OnDeselect.AddListener(delegate
			{
				SwapColors(Color.white);
			});
		}
	}

	public void SwapColors(Color color)
	{
		foreach (var item in GetComponentsInChildren<MeshRenderer>())
		{
			item.material.color = color;
		}
	}
}
