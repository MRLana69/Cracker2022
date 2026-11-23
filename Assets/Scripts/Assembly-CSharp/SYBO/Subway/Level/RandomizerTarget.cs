using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class RandomizerTarget : Selector
{
	private List<GameObject> Targets;

	public override void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_000a: Expected I, but got Obj
		if (~(base._initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v19 (Il2CppClass<SYBO.Subway.Level.RandomizerTarget>)+EC] (should have been resolved before IL gen)");
		}
		List<GameObject> targets = Targets;
		int num2 = Random.Range(0, targets._size);
		int num3 = 0;
		while (true)
		{
			List<GameObject> targets2 = Targets;
			if (num3 < targets2._size)
			{
				GameObject gameObject = Targets.get_Item(num3);
				if (num3 == num2)
				{
					objectsToVisit.Add(gameObject);
				}
				else
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
