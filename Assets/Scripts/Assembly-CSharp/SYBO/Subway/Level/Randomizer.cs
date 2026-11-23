using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class Randomizer : Selector
{
	public override void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_000a: Expected I, but got Obj
		if (~(base._initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v18 (Il2CppClass<SYBO.Subway.Level.Randomizer>)+EC] (should have been resolved before IL gen)");
		}
		int childCount = _transform.childCount;
		int num2 = Random.Range(0, childCount);
		int num3 = 0;
		while (true)
		{
			int childCount2 = _transform.childCount;
			if (childCount2 > num3)
			{
				Transform child = _transform.GetChild(num3);
				GameObject gameObject = child.gameObject;
				if (num3 == num2)
				{
					objectsToVisit.Add(gameObject);
				}
				else if (gameObject.activeSelf)
				{
					gameObject.SetActive(value: false);
				}
				int num4 = num3 + 1;
				num3 = num4;
				continue;
			}
			break;
		}
	}
}
