using System.Collections.Generic;
using UnityEngine;

public class DailyLetterPickup : LetterPickup
{
	public char Letter
	{
		set
		{
			_letterChar = value;
			List<Mesh> letters = Letters;
			int num = value - 65;
			if (num >= 0 && num < letters._size)
			{
				Mesh mesh = Letters.get_Item(num);
				LetterMesh.mesh = mesh;
			}
		}
	}

	private void Awake()
	{
		DailyLetterPickupManager instance = DailyLetterPickupManager.Instance;
		instance.InitializePickup(this);
	}

	protected override void OnActivate()
	{
		DailyLetterPickupManager instance = DailyLetterPickupManager.Instance;
		Letter = instance.letter;
	}
}
