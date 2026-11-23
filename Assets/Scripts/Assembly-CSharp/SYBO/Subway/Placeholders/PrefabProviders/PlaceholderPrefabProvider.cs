using Cpp2ILInjected;
using UnityEngine;

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
			return _prefab;
		}
		set
		{
			_prefab = value;
		}
	}

	internal override int PrefabCount => 1;

	internal override void Evaluate()
	{
		//IL_007d: Expected I, but got Obj
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProvider>)+E4] (should have been resolved before IL gen)");
		if (~(evaluated ? 1u : 0u) != 0)
		{
			DeviceInfo instance = DeviceInfo.Instance;
			if (MinDevicePerformance <= instance.performanceLevel)
			{
				Transform themedPrefab = GetThemedPrefab(_prefab);
				_prefabsToSpawn.Add(themedPrefab);
			}
			evaluated = true;
		}
	}

	internal override Transform GetPrefab(int prefabIndex)
	{
		return _prefab;
	}
}
