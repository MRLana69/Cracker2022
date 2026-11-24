using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Rendering;
using SYBO.Subway.Routes.Builders.Worker;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Placeholders.PrefabProviders;

public class MultiplePlaceholderPrefabProvider : PlaceholderPrefabProviderBase
{
	[Serializable]
	public class GenericSpawnInfo
	{
		public GameObject Target;

		internal float Weight;

		internal DeviceInfo.PerformanceLevel MinDevicePerformance;

		public GenericSpawnInfo()
		{
			do
			{
				bool flag = ((ModelSelectionPlaceholderLifecycle._003CCombineMeshesAsync_003Ed__12)this).MoveNext();
			}
			while (!((RouteBuilderWorker.WorkWrapper)this).Work());
		}
	}

	private static Dictionary<GameObject, GameObject> _nonRepeatableToLastPrefabDict;

	private bool _spawnWeighted;

	private bool _spawnAll;

	protected List<GenericSpawnInfo> _prefabList;

	private float _weightSum = 0f;

	private GameObject _lastSelectedObject;

	private List<GameObject> _nonRepeatablePrefabs;

	protected List<GenericSpawnInfo> _prefabPickingList;

	public ReadOnlyCollection<GenericSpawnInfo> PrefabList
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = (object)base._themeManager != null;
			return (ReadOnlyCollection<GenericSpawnInfo>)flag;
		}
	}

	internal override int PrefabCount
	{
		get
		{
			//IL_0014: Expected I4, but got Obj
			return (int)((List<T>)(object)_prefabList).System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator();
		}
	}

	protected override void Initialize()
	{
		//IL_000b: Expected Obj, but got I4
		base._themeManager = (ThemeManager)1;
		CancelInvoke();
	}

	internal override void Evaluate()
	{
		//IL_037e: Expected I, but got Obj
		//IL_0394: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0323: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0426: Expected Obj, but got VT
		//IL_011c: Expected I, but got Obj
		//IL_046e: Expected I, but got Obj
		//IL_0484: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_0523: Expected Obj, but got I4
		//IL_01e8: Expected I, but got Obj
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_0235: Expected I, but got Obj
		//IL_024b: Expected Obj, but got I
		//IL_0547: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_0276: Expected I, but got Obj
		base._002Ector();
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v98 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			int num3 = default;
			List<GameObject> list = default;
			object obj10 = default;
			while (true)
			{
				List<GenericSpawnInfo> prefabList = _prefabList;
				if (num3 >= prefabList._size)
				{
					break;
				}
				GenericSpawnInfo genericSpawnInfo = _prefabList.get_Item(num3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (System.Int32)+8]");
				if ((nint)0 < (nint)genericSpawnInfo.MinDevicePerformance)
				{
					_prefabList.RemoveAt(num3);
					continue;
				}
				num3++;
				_0021_00210 componentInChildren = (_0021_00210)genericSpawnInfo.Target.GetComponentInChildren<T>();
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v80 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)componentInChildren).FindKernel(null) == 0)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v27 (T)+C]");
				if ((nint)0 == 0)
				{
					continue;
				}
				if (_nonRepeatablePrefabs == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					list._002Ector();
					object obj3 = this + 40;
					obj3 = list;
				}
				_nonRepeatablePrefabs.Add(genericSpawnInfo.Target);
				nint num6 = (nint)typeof(MultiplePlaceholderPrefabProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v45 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(MultiplePlaceholderPrefabProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v69 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S2_v8 (Il2CppMethodInfo)+C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S2_v9+60]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S2_v10+44]");
				object obj7 = 0;
				object obj8 = obj7 & 0x1FFF;
				object obj9 = obj8 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v8 (should have been resolved before IL gen)");
				bool flag = (nint)obj10 <= -1;
				bool flag2 = !flag;
				object obj11 = 22691;
				if (flag2)
				{
					continue;
				}
				nint num9 = (nint)typeof(MultiplePlaceholderPrefabProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v55 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num10 = (nint)typeof(MultiplePlaceholderPrefabProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v63 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S4_v6 (Il2CppMethodInfo)+C]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S4_v7+60]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S4_v8+48]");
				obj11 = 0;
				object obj15 = obj11 & 0x7FF;
				object obj16 = obj15 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S5_v2 (should have been resolved before IL gen)");
			}
		}
		int num12 = 0;
		while (true)
		{
			List<GenericSpawnInfo> prefabList2 = _prefabList;
			if (num12 >= prefabList2._size)
			{
				break;
			}
			GenericSpawnInfo genericSpawnInfo2 = _prefabList.get_Item(num12);
			float weightSum = _weightSum + genericSpawnInfo2.Weight;
			_weightSum = weightSum;
			int num13 = num12 + 1;
			num12 = num13;
		}
		List<GenericSpawnInfo> prefabPickingList = _prefabPickingList;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S3_v13 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S3_v14+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S3_v15+38]");
		object obj19 = 0;
		object obj20 = obj19 & 0x1FFF;
		object obj21 = obj20 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v147 @ S4_v15 (should have been resolved before IL gen)");
	}

	internal override Transform GetPrefab(int prefabIndex)
	{
		//IL_0212: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I4
		//IL_0090: Expected I, but got Obj
		//IL_00a6: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I4
		//IL_0260: Expected I, but got Obj
		//IL_0276: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		//IL_00d1: Expected I, but got Obj
		//IL_011e: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)prefabIndex != null)
		{
			return null;
		}
		PrefabPool prefabPool2;
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v51 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)prefabIndex);
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)prefabPool != null)
			{
				UnityEngine.Object type = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
				object msg = ((IConvertible)"Placeholder on [").ToType((Type)(object)type, (IFormatProvider)(object)"] failed to get object");
				SDebug.LogFormat((string)msg, null);
				return null;
			}
			prefabPool2 = prefabPool;
		}
		else
		{
			prefabPool2 = null;
		}
		UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)prefabIndex);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		string text = ((Component)(object)prefabPool2).tag;
		bool activeInHierarchy = ((GameObject)(object)text).activeInHierarchy;
		string text2 = ((Component)(object)prefabPool2).tag;
		((GameObject)(object)text2).tag = (string)1;
		((Placeholder)(object)this).SpawnInstances((PlaceholderPrefabProviderBase)(object)prefabPool2);
		return (Transform)(object)((Component)(object)prefabPool2).tag;
	}

	private void RecomputeWeightAndPickingList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0488: Expected Obj, but got I4
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		throw new IndexOutOfRangeException();
	}

	protected virtual void RecomputePickingList()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		this._002Ector();
	}

	protected virtual bool NeedRecomputePickingList()
	{
		List<GenericSpawnInfo> prefabList = _prefabList;
		return (byte)prefabList._size != 0;
	}

	protected virtual bool CanPickPrefab(GameObject prefab)
	{
		//IL_00a6: Expected I4, but got Obj
		//IL_00b8: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_006f: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		GenericSpawnInfo genericSpawnInfo = _prefabList.get_Item((int)prefab);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (genericSpawnInfo.Target != null)
		{
			return false;
		}
		GenericSpawnInfo genericSpawnInfo2 = _prefabList.get_Item((int)prefab);
		return (byte)genericSpawnInfo2.Target.layer != 0;
	}

	private bool IsNonRepeatableSpawned(GameObject nonRepeatablePrefab)
	{
		//IL_003b: Expected I4, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		if (_nonRepeatablePrefabs != null)
		{
			List<GameObject> nonRepeatablePrefabs = _nonRepeatablePrefabs;
			if (nonRepeatablePrefabs._size != 0)
			{
				Transform prefab = ((PlaceholderPrefabProvider)this).GetPrefab((int)nonRepeatablePrefab);
				return (byte)(prefab ^ 1) != 0;
			}
			return true;
		}
		return true;
	}

	private void RecomupteWeights()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		int num = default;
		object obj2 = default;
		int num2 = default;
		while (true)
		{
			List<GenericSpawnInfo> prefabList = _prefabList;
			if (num < prefabList._size)
			{
				GenericSpawnInfo genericSpawnInfo = _prefabList.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				if (obj2 != null)
				{
					GenericSpawnInfo genericSpawnInfo2 = _prefabList.get_Item(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
				}
				num = num2 + 1;
				continue;
			}
			break;
		}
	}

	protected virtual GameObject SelectPrefab()
	{
		//IL_003a: Expected Obj, but got I4
		if (_nonRepeatablePrefabs != null)
		{
			List<GameObject> nonRepeatablePrefabs = _nonRepeatablePrefabs;
			if (nonRepeatablePrefabs._size != 0)
			{
				return (GameObject)1;
			}
		}
		return null;
	}

	public MultiplePlaceholderPrefabProvider()
	{
		int num = default;
		int num2 = default;
		while (true)
		{
			List<GenericSpawnInfo> prefabPickingList = _prefabPickingList;
			if (num < prefabPickingList._size)
			{
				GenericSpawnInfo genericSpawnInfo = _prefabPickingList.get_Item(num2);
				float weightSum = _weightSum + genericSpawnInfo.Weight;
				_weightSum = weightSum;
				num = num2 + 1;
				continue;
			}
			break;
		}
	}

	static MultiplePlaceholderPrefabProvider()
	{
		RenderQueues.TransparentOverlay = 3100;
	}
}
