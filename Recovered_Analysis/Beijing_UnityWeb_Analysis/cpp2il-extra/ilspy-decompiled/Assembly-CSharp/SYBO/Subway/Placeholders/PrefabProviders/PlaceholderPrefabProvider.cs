using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Visuals;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Themes;
using UnityEngine;
using UnityEngine.UI;

namespace SYBO.Subway.Placeholders.PrefabProviders;

public class PlaceholderPrefabProvider : PlaceholderPrefabProviderBase
{
	protected Transform _prefab;

	public DeviceInfo.PerformanceLevel MinDevicePerformance;

	protected bool evaluated;

	public Transform Prefab
	{
		get
		{
			//IL_0015: Expected F4, but got I4
			//IL_0168: Expected Obj, but got I
			//IL_0197: Expected Obj, but got I
			//IL_02b2: Expected Obj, but got I
			//IL_00cb: Expected I, but got Obj
			//IL_00e1: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_01e4: Expected I, but got Obj
			//IL_01fa: Expected Obj, but got I
			//IL_010c: Expected I, but got Obj
			//IL_031a: Expected I4, but got Obj
			//IL_0225: Expected I, but got Obj
			Object obj2;
			if ((object)_prefab != null)
			{
				float num = ScrollRect.RubberDelta(0f, (float)(evaluated ? 1 : 0));
				int num2 = 0;
				float num4 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProvider)+2C]");
					object obj = 0;
					int num3 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v24+C]");
					bool flag = (nint)num3 >= (nint)0;
					obj2 = null;
					if (flag)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProvider)+2C]");
					MultiplePlaceholderPrefabProvider.GenericSpawnInfo genericSpawnInfo = ((List<MultiplePlaceholderPrefabProvider.GenericSpawnInfo>)0).get_Item(num2);
					num4 += genericSpawnInfo.Weight;
					if (!(num < num4))
					{
						int num5 = num2 + 1;
						num2 = num5;
						continue;
					}
					obj2 = genericSpawnInfo.Target;
					break;
				}
			}
			else
			{
				obj2 = null;
			}
			Transform result;
			if ((object)_prefab != null)
			{
				nint num6 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!(obj2 != null))
				{
					result = (Transform)obj2;
					goto IL_02fa;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProvider)+2C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v8+C]");
			int index = Random.RandomRangeInt(0, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProvider)+2C]");
			MultiplePlaceholderPrefabProvider.GenericSpawnInfo genericSpawnInfo2 = ((List<MultiplePlaceholderPrefabProvider.GenericSpawnInfo>)0).get_Item(index);
			bool flag2 = (object)_prefab == null;
			result = (Transform)(object)genericSpawnInfo2.Target;
			if (!flag2)
			{
				GameObject components = gameObject;
				nint num8 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S2_v9 (Il2CppClass<Utils>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S2_v16 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string longNameList = Utils.GetLongNameList((Component[])(object)components);
				string msg = string.ConcatArray((string[])(object)"Failed to pick prefab based on weight and resorted on uniform choice. Something wrong at ", (int)longNameList);
				SDebug.LogFormat(msg, null);
				result = (Transform)(object)genericSpawnInfo2.Target;
			}
			goto IL_02fa;
			IL_02fa:
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			ThemeManager themeManager = (ThemeManager)(value & 1);
			base._themeManager = themeManager;
		}
	}

	internal override int PrefabCount
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_prefab;
		}
	}

	internal override void Evaluate()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<MultiplePlaceholderPrefabProvider.GenericSpawnInfo> list = default;
		list._002Ector();
		object obj = this + 28;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<MultiplePlaceholderPrefabProvider.GenericSpawnInfo> list2 = default;
		list2._002Ector();
		object obj2 = this + 44;
		obj2 = list2;
		((ModelSelectionPlaceholderLifecycle)(object)this).Initialize();
	}

	internal override Transform GetPrefab(int prefabIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I4
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I
		//IL_04cd: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_011c: Expected I, but got Obj
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(MultiplePlaceholderPrefabProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v91 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(MultiplePlaceholderPrefabProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v130 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				nint num3 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v106 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v123 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 != null)
				{
					object obj9 = obj4 + 4;
					object obj10 = obj9 + 1;
					obj9 = obj10;
					object obj11 = obj10 << 2;
					object obj12 = obj4 + obj11;
					obj12 = 72;
					break;
				}
				continue;
			}
			object obj13 = obj4 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj4 + obj15;
			obj16 = 70;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj4 + obj17;
			if ((nint)obj18 == 72)
			{
				object obj19 = obj4 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_04c7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj4 + obj21;
			if ((nint)obj22 == 70)
			{
				object obj23 = obj4 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_04c7;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04c7;
		IL_04c7:
		return (Transform)1;
	}

	public PlaceholderPrefabProvider()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		if (~(evaluated ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v23 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (System.Int32)+8]");
		if ((nint)0 >= (nint)MinDevicePerformance)
		{
			IEnumerator item = ((ModelSelectionPlaceholderLifecycle)(object)this).CombineMeshesAsync((IList<CombineableMesh>)_prefab);
			_prefabsToSpawn.Add((Transform)item);
		}
		evaluated = true;
	}
}
