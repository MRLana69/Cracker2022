using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using SYBO.Subway.Level;
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
	}

	private static Dictionary<GameObject, GameObject> _nonRepeatableToLastPrefabDict;

	private bool _spawnWeighted;

	private bool _spawnAll;

	protected List<GenericSpawnInfo> _prefabList;

	private float _weightSum;

	private GameObject _lastSelectedObject;

	private List<GameObject> _nonRepeatablePrefabs;

	protected List<GenericSpawnInfo> _prefabPickingList;

	public ReadOnlyCollection<GenericSpawnInfo> PrefabList => _prefabList.AsReadOnly();

	internal override int PrefabCount
	{
		get
		{
			List<GenericSpawnInfo> prefabList = _prefabList;
			return prefabList._size;
		}
	}

	protected override void Initialize()
	{
		//IL_0201: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I
		base.Initialize();
		DeviceInfo instance = DeviceInfo.Instance;
		if (Application.isPlaying)
		{
			int num = 0;
			List<GameObject> list = default;
			object obj3 = default;
			while (true)
			{
				List<GenericSpawnInfo> prefabList = _prefabList;
				if (num >= prefabList._size)
				{
					break;
				}
				GenericSpawnInfo genericSpawnInfo = _prefabList.get_Item(num);
				if (genericSpawnInfo.MinDevicePerformance > instance.performanceLevel)
				{
					_prefabList.RemoveAt(num);
					continue;
				}
				int num2 = num + 1;
				SpawnSettings component = genericSpawnInfo.Target.GetComponent<SpawnSettings>();
				bool flag = component != null;
				bool flag2 = !flag;
				num = num2;
				if (flag2)
				{
					continue;
				}
				bool flag3 = (byte)(~(component.DontRepeatInMultiplePlaceholders ? 1u : 0u)) != 0;
				num = num2;
				if (!flag3)
				{
					List<GameObject> nonRepeatablePrefabs;
					if (_nonRepeatablePrefabs != null)
					{
						nonRepeatablePrefabs = _nonRepeatablePrefabs;
					}
					else
					{
						list._002Ector();
						_nonRepeatablePrefabs = list;
						nonRepeatablePrefabs = _nonRepeatablePrefabs;
					}
					nonRepeatablePrefabs.Add(genericSpawnInfo.Target);
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S3_v12 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.GameObject, UnityEngine.GameObject>>)+54]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v206 @ S3_v13+4] (should have been resolved before IL gen)");
					object obj2 = obj3 ^ -1;
					object obj4 = obj2 >> 31;
					num = num2;
					if (obj4 == null)
					{
						nint num5 = 0;
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.GameObject, UnityEngine.GameObject>>)+5C]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ S5_v6+4] (should have been resolved before IL gen)");
						num = num2;
					}
				}
			}
		}
		int num7 = 0;
		while (true)
		{
			List<GenericSpawnInfo> prefabList2 = _prefabList;
			if (num7 >= prefabList2._size)
			{
				break;
			}
			GenericSpawnInfo genericSpawnInfo2 = _prefabList.get_Item(num7);
			float weightSum = _weightSum + genericSpawnInfo2.Weight;
			_weightSum = weightSum;
			int num8 = num7 + 1;
			num7 = num8;
		}
		List<GenericSpawnInfo> prefabPickingList = _prefabPickingList;
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S4_v5 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider+GenericSpawnInfo>>)+3C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ S4_v6+4] (should have been resolved before IL gen)");
	}

	internal override void Evaluate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0409: Expected I, but got Obj
		//IL_0456: Expected I, but got Obj
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v6 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+E4] (should have been resolved before IL gen)");
		((List<T>)(object)_prefabsToSpawn).Clear();
		RecomputeWeightAndPickingList();
		List<GenericSpawnInfo> prefabPickingList = _prefabPickingList;
		if (prefabPickingList._size == 0)
		{
			return;
		}
		if (~(_spawnAll ? 1u : 0u) == 0)
		{
			int num2 = default;
			int num3 = default;
			while (true)
			{
				List<GenericSpawnInfo> prefabList = _prefabList;
				if (num2 < prefabList._size)
				{
					GenericSpawnInfo genericSpawnInfo = _prefabList.get_Item(num2);
					Transform prefabTransform = genericSpawnInfo.Target.transform;
					Transform themedPrefab = GetThemedPrefab(prefabTransform);
					_prefabsToSpawn.Add(themedPrefab);
					num2 = num3 + 1;
					continue;
				}
				break;
			}
			return;
		}
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S2_v5 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+11C] (should have been resolved before IL gen)");
		GameObject lastSelectedObject = default;
		_lastSelectedObject = lastSelectedObject;
		if (_lastSelectedObject != null)
		{
			Transform prefabTransform2 = _lastSelectedObject.transform;
			Transform themedPrefab2 = GetThemedPrefab(prefabTransform2);
			_prefabsToSpawn.Add(themedPrefab2);
		}
		if (!(_lastSelectedObject != null))
		{
			return;
		}
		List<GameObject> nonRepeatablePrefabs = _nonRepeatablePrefabs;
		if (_nonRepeatablePrefabs == null || nonRepeatablePrefabs._size == 0)
		{
			return;
		}
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_034d;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_02be;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_02be;
			IL_02be:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 != obj8;
			object obj9 = obj10;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_034d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj11;
			break;
			IL_034d:
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EBE");
			return;
		}
		_ = 0;
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	internal override Transform GetPrefab(int prefabIndex)
	{
		GenericSpawnInfo genericSpawnInfo = _prefabList.get_Item(prefabIndex);
		if (genericSpawnInfo.Target == null)
		{
			return null;
		}
		GenericSpawnInfo genericSpawnInfo2 = _prefabList.get_Item(prefabIndex);
		return genericSpawnInfo2.Target.transform;
	}

	private void RecomputeWeightAndPickingList()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+104] (should have been resolved before IL gen)");
		RecomupteWeights();
	}

	protected virtual void RecomputePickingList()
	{
		//IL_00af: Expected I, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_0036: Expected I, but got Obj
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+10C] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		((List<T>)(object)_prefabPickingList).Clear();
		int num2 = 0;
		object obj4 = default;
		while (true)
		{
			List<GenericSpawnInfo> prefabList = _prefabList;
			if (num2 < prefabList._size)
			{
				GenericSpawnInfo genericSpawnInfo = _prefabList.get_Item(num2);
				nint num3 = (nint)this;
				object obj3 = this + 88;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S2_v8 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.MultiplePlaceholderPrefabProvider>)+114] (should have been resolved before IL gen)");
				if (obj4 != null)
				{
					GenericSpawnInfo item = _prefabList.get_Item(num2);
					_prefabPickingList.Add(item);
				}
				int num4 = num2 + 1;
				num2 = num4;
				continue;
			}
			break;
		}
	}

	protected virtual bool NeedRecomputePickingList()
	{
		List<GameObject> nonRepeatablePrefabs = _nonRepeatablePrefabs;
		bool result;
		if (_nonRepeatablePrefabs != null)
		{
			result = true;
			if (nonRepeatablePrefabs._size != 0)
			{
				goto IL_0058;
			}
		}
		result = false;
		goto IL_0058;
		IL_0058:
		return result;
	}

	protected virtual bool CanPickPrefab(GameObject prefab)
	{
		List<GameObject> nonRepeatablePrefabs = _nonRepeatablePrefabs;
		bool flag = _nonRepeatablePrefabs == null;
		bool result = true;
		if (!flag)
		{
			bool flag2 = nonRepeatablePrefabs._size == 0;
			result = true;
			if (!flag2)
			{
				bool flag3 = IsNonRepeatableSpawned(prefab);
				bool flag4 = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
				result = flag4;
			}
		}
		return result;
	}

	private bool IsNonRepeatableSpawned(GameObject nonRepeatablePrefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		bool flag2 = default;
		bool result;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		bool flag5 = default;
		bool flag7 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = !flag2;
				result = flag2;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj6 != null)
									{
										result = flag2;
										break;
									}
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_01c6;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01c6;
			IL_01c6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj7 == obj8;
			bool flag4 = !flag3;
			result = flag5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 != 1;
				result = false;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag7;
			}
			_ = 0;
			object obj9 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EBE");
		return result;
	}

	private void RecomupteWeights()
	{
		_weightSum = 0f;
		int num = 0;
		while (true)
		{
			List<GenericSpawnInfo> prefabPickingList = _prefabPickingList;
			if (num < prefabPickingList._size)
			{
				GenericSpawnInfo genericSpawnInfo = _prefabPickingList.get_Item(num);
				float weightSum = _weightSum + genericSpawnInfo.Weight;
				_weightSum = weightSum;
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	protected virtual GameObject SelectPrefab()
	{
		GameObject result;
		if (~(_spawnWeighted ? 1u : 0u) == 0)
		{
			float num = UnityEngine.Random.Range(0f, _weightSum);
			int num2 = default;
			float num3 = default;
			GameObject gameObject;
			int num4 = default;
			while (true)
			{
				List<GenericSpawnInfo> prefabPickingList = _prefabPickingList;
				if (num2 < prefabPickingList._size)
				{
					GenericSpawnInfo genericSpawnInfo = _prefabPickingList.get_Item(num2);
					num3 += genericSpawnInfo.Weight;
					if (num3 > num)
					{
						gameObject = genericSpawnInfo.Target;
						break;
					}
					num2 = num4 + 1;
					continue;
				}
				gameObject = null;
				break;
			}
			if (~(_spawnWeighted ? 1u : 0u) == 0)
			{
				bool flag = gameObject == null;
				bool flag2 = !flag;
				result = gameObject;
				if (flag2)
				{
					goto IL_0173;
				}
			}
		}
		List<GenericSpawnInfo> prefabPickingList2 = _prefabPickingList;
		int index = UnityEngine.Random.Range(0, prefabPickingList2._size);
		GenericSpawnInfo genericSpawnInfo2 = _prefabPickingList.get_Item(index);
		bool flag3 = (byte)(~(_spawnWeighted ? 1u : 0u)) != 0;
		result = genericSpawnInfo2.Target;
		if (!flag3)
		{
			Transform transform = base.transform;
			string longName = Utils.GetLongName(transform);
			string text = "Failed to pick prefab based on weight and resorted on uniform choice. Something wrong at " + longName;
			result = genericSpawnInfo2.Target;
		}
		goto IL_0173;
		IL_0173:
		return result;
	}

	public MultiplePlaceholderPrefabProvider()
	{
		List<GenericSpawnInfo> list = default;
		list._002Ector();
		_prefabList = list;
		List<GenericSpawnInfo> list2 = default;
		list2._002Ector();
		_prefabPickingList = list2;
		base._002Ector();
	}

	static MultiplePlaceholderPrefabProvider()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.GameObject, UnityEngine.GameObject>>>)+4] (should have been resolved before IL gen)");
		Dictionary<GameObject, GameObject> nonRepeatableToLastPrefabDict = default;
		_nonRepeatableToLastPrefabDict = nonRepeatableToLastPrefabDict;
	}
}
