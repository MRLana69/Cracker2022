using Cpp2ILInjected;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Placeholders.PrefabProviders;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class SpawnOnceOnStartPlaceholderLifecycle : PlaceholderLifecycle
{
	protected void Start()
	{
		if (Application.isPlaying)
		{
			SpawnInstances(spawnInChildrenLifecycles: true);
		}
	}

	private void SpawnInstances(bool spawnInChildrenLifecycles = false)
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_002f: Expected I, but got Obj
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		PlaceholderPrefabProviderBase prefabProvider = _prefabProvider;
		nint num = (nint)prefabProvider;
		object obj = prefabProvider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase>)+F4] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		object obj2 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S3_v2 (Il2CppClass<SYBO.Subway.Placeholders.SpawnOnceOnStartPlaceholderLifecycle>)+F4] (should have been resolved before IL gen)");
	}

	protected virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I
		if (_placeholder.HasSpawnedInstances)
		{
			return;
		}
		Placeholder placeholder = _placeholder;
		object obj = placeholder - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S2_v4+BC] (should have been resolved before IL gen)");
		if (!spawnInChildrenLifecycles)
		{
			return;
		}
		SpawnOnceOnStartPlaceholderLifecycle[] componentsInChildren = GetComponentsInChildren<SpawnOnceOnStartPlaceholderLifecycle>(includeInactive: true);
		object obj2 = 0;
		while ((nint)obj2 < componentsInChildren.Length)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)componentsInChildren + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v20+10]");
			if (!((Object)0 == this))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v20+10]");
				((SpawnOnceOnStartPlaceholderLifecycle)0).SpawnInstances(spawnInChildrenLifecycles: true);
			}
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
	}
}
