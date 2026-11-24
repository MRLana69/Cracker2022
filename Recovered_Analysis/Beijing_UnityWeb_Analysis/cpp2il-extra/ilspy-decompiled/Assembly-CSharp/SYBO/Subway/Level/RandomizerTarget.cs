using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Level.TrackEvents;
using UnityEngine;

namespace SYBO.Subway.Level;

public class RandomizerTarget : Selector
{
	private List<GameObject> Targets;

	public override void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_0194: Expected VT, but got Obj
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		((Activity)(object)this).Prepare((IActivityInitializer)null);
		Transform transform = default;
		transform.position = (Vector3)_transform;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v40 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float f = (float)(nint)((Object)transform).m_CachedPtr / 2000f;
		int num3 = Mathf.RoundToInt(f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.RandomizerTarget)+1C]");
		if ((nint)0 == num3)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.RandomizerTarget)+20]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.RandomizerTarget)+20]");
				objectsToVisit.Add((GameObject)0);
			}
		}
		else
		{
			List<GameObject> targets = Targets;
			int num6 = Random.RandomRangeInt(0, targets._size);
			object obj3 = this + 32;
			object obj4 = Targets + 16;
			int num7 = num6 << 2;
			object obj5 = obj4 + num7;
			obj3 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.RandomizerTarget)+20]");
			objectsToVisit.Add((GameObject)0);
		}
	}

	public RandomizerTarget()
	{
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
