using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Migration;
using Data.Save;
using Kiloo.Common.Ads;
using SYBO.Common;
using UnityEngine;

namespace Cloud.Internal;

public class CloudSaveComparisonRow
{
	public CloudSaveComparisonElement id;

	public float localValue;

	public float onlineValue;

	public bool isLocalImprovement;

	public bool isOnlineImprovement;

	public unsafe CloudSaveComparisonRow(CloudSaveComparisonElement id, int localValue, int onlineValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_2809: Unknown result type (might be due to invalid IL or missing references)
		//IL_280e: Expected Ref, but got Unknown
		//IL_2820: Unknown result type (might be due to invalid IL or missing references)
		//IL_2825: Expected Ref, but got Unknown
		//IL_2837: Unknown result type (might be due to invalid IL or missing references)
		//IL_283c: Expected Ref, but got Unknown
		//IL_284e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2853: Expected Ref, but got Unknown
		//IL_2865: Unknown result type (might be due to invalid IL or missing references)
		//IL_286a: Expected Ref, but got Unknown
		//IL_287c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2881: Expected Ref, but got Unknown
		//IL_2893: Unknown result type (might be due to invalid IL or missing references)
		//IL_2898: Expected Obj, but got Unknown
		//IL_28a1: Expected Obj, but got I4
		//IL_28aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_28af: Expected Obj, but got Unknown
		//IL_28b8: Expected Obj, but got I4
		//IL_28c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c6: Expected Obj, but got Unknown
		//IL_28e2: Expected I, but got Obj
		//IL_28f8: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected Obj, but got I4
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_00c2: Expected I, but got Obj
		//IL_01c3: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got I
		//IL_0163: Expected I, but got Obj
		//IL_01b0: Expected I4, but got F4
		//IL_0264: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I
		//IL_0204: Expected I, but got Obj
		//IL_0251: Expected I4, but got F4
		//IL_0305: Expected I, but got Obj
		//IL_031b: Expected Obj, but got I
		//IL_02a5: Expected I, but got Obj
		//IL_02f2: Expected I4, but got F4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected I, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected I, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0346: Expected I, but got Obj
		//IL_0393: Expected I4, but got F4
		//IL_1dca: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 176;
		ref int reference = ref *(int*)(obj2 + 172);
		reference = ref *(int*)null;
		ref int reference2 = ref *(int*)(obj2 + 168);
		reference2 = ref *(int*)null;
		ref float reference3 = ref *(float*)(obj2 + 164);
		reference3 = ref *(float*)null;
		ref float reference4 = ref *(float*)(obj2 + 160);
		reference4 = ref *(float*)null;
		ref float reference5 = ref *(float*)(obj2 + 156);
		reference5 = ref *(float*)null;
		ref float reference6 = ref *(float*)(obj2 + 152);
		reference6 = ref *(float*)null;
		object obj3 = obj2 + 48;
		obj3 = 0;
		object obj4 = obj2 + 32;
		obj4 = 0;
		object obj5 = obj2 + 144;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v1735 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PlayerInfoMigrator.TryLoadInt((Dictionary<Key, string>)(object)this, Key.LastTopRunResultsAwardedID, out reference))
		{
			TopRunSave.pendingTopRunResultID = (string)reference;
		}
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v39 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v1729 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PlayerInfoMigrator.TryLoadInt((Dictionary<Key, string>)(object)this, Key.PendingTopRunResultsID, out reference2))
		{
			TopRunSave.pendingTopRunResultsScore = reference2;
		}
		nint num5 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v47 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v1723 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PlayerInfoMigrator.TryLoadFloat((Dictionary<Key, string>)(object)this, Key.PendingTopRunResultScore, out reference3))
		{
			TopRunSave.pendingTopRunResultsRank = (int)reference3;
		}
		nint num7 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v55 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v1717 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PlayerInfoMigrator.TryLoadFloat((Dictionary<Key, string>)(object)this, Key.PendingTopRunResultRank, out reference4))
		{
			TopRunSave.pendingTopRunResultsWeek = (int)reference4;
		}
		nint num9 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v63 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num10 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v1711 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PlayerInfoMigrator.TryLoadFloat((Dictionary<Key, string>)(object)this, Key.PendingTopRunResultWeek, out reference5))
		{
			TopRunSave.lastWeekMedalWasShown = (int)reference5;
		}
		nint num11 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v71 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v1705 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PlayerInfoMigrator.TryLoadFloat((Dictionary<Key, string>)(object)this, Key.LastWeekMedalWasShown, out reference6))
		{
			TopRunSave.pendingTopRunBeatenFriendsAward = (int)reference6;
		}
		object obj12 = obj2 + 128;
		object obj13 = obj2 + 16;
		nint num13 = (nint)(obj2 + 120);
		nint num14 = (nint)(obj2 + 112);
		object obj14 = obj2 + 104;
		object obj15 = obj2 + 96;
		object obj16 = obj2 + 88;
		object obj17 = obj2 + 80;
		object obj18 = obj2 + 72;
		object obj19 = obj2 - -64;
		object obj20 = obj2 + 56;
		object obj21 = obj2 + 40;
		object obj22;
		object obj23 = default;
		object obj24;
		if (id != CloudSaveComparisonElement.Multiplier)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj22 = obj23;
			object obj25 = default;
			obj24 = obj25;
		}
		else if (localValue != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj22 = obj23;
			object obj26 = default;
			obj24 = obj26;
		}
		else
		{
			object obj27 = 0;
			if (onlineValue == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj22 = obj23;
			object obj28 = default;
			obj24 = obj28;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj29 = default;
		if (obj22 == obj29)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj31 = default;
			object obj30 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj33 = default;
			object obj32 = obj33;
		}
		else
		{
			object obj32 = obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	public CloudSaveComparisonRow(CloudSaveComparisonElement id, float localValue, float onlineValue)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I
		//IL_002c: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		object obj = this + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Cloud.Internal.CloudSaveComparisonRow)+5C]");
		bool flag = ((SafeAnimation)0).HasAnimationState((string)id);
		obj = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Cloud.Internal.CloudSaveComparisonRow)+B8]");
		IEnumerator routine = ((AdLocation)this).WaitWhileConditionOrUntilTimedOut((Func<bool>)0, localValue);
		Coroutine coroutine = ((MonoBehaviour)this).StartCoroutine_Auto(routine);
	}
}
