using System;
using Cpp2ILInjected;
using SYBO.Subway.Placeholders.PrefabProviders;
using UnityEngine;

namespace SYBO.Subway.Placeholders.Lifecycles;

public class PlaceholderLifecycle : MonoBehaviour
{
	protected bool _initialized;

	protected PlaceholderPrefabProviderBase _prefabProvider;

	protected Placeholder _placeholder;

	public Placeholder Placeholder
	{
		get
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+DC] (should have been resolved before IL gen)");
			return _placeholder;
		}
	}

	protected void Awake()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+DC] (should have been resolved before IL gen)");
	}

	protected virtual void InitializeCheck()
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+E4] (should have been resolved before IL gen)");
			_initialized = true;
		}
	}

	protected virtual void Initialize()
	{
		//IL_00b9: Expected VT, but got Obj
		//IL_0037: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(PlaceholderPrefabProviderBase));
		Component component = GetComponent(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		PlaceholderPrefabProviderBase prefabProvider = default;
		_prefabProvider = prefabProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Placeholder));
		Component component2 = GetComponent(typeFromHandle2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Placeholder placeholder = default;
		_placeholder = placeholder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		if (_placeholder.HasSpawnedInstances)
		{
			_placeholder.DespawnInstances();
		}
	}

	public void SpawnInstancesEditor()
	{
		//IL_009a: Expected I, but got Obj
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00c1: Expected I, but got Obj
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+DC] (should have been resolved before IL gen)");
		PlaceholderPrefabProviderBase prefabProvider = _prefabProvider;
		nint num2 = (nint)prefabProvider;
		object obj2 = prefabProvider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S1_v7 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase>)+F4] (should have been resolved before IL gen)");
		if (!_placeholder.HasSpawnedInstances)
		{
			Placeholder placeholder = _placeholder;
			object obj3 = placeholder - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S2_v10+BC] (should have been resolved before IL gen)");
			PlaceholderLifecycle[] componentsInChildren = GetComponentsInChildren<PlaceholderLifecycle>(includeInactive: true);
			object obj4 = 0;
			while ((nint)obj4 < componentsInChildren.Length)
			{
				object obj5 = obj4 << 2;
				object obj6 = (object)componentsInChildren + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v21+10]");
				bool flag = (UnityEngine.Object)0 == this;
				object obj7 = obj4 + 1;
				obj4 = obj7;
			}
		}
	}

	public void DespawnInstancesEditor()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+DC] (should have been resolved before IL gen)");
		_placeholder.DespawnInstances();
	}

	public void Spawn()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002c: Expected I, but got Obj
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+DC] (should have been resolved before IL gen)");
		PlaceholderPrefabProviderBase prefabProvider = _prefabProvider;
		nint num2 = (nint)prefabProvider;
		object obj2 = prefabProvider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v6 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase>)+F4] (should have been resolved before IL gen)");
		Placeholder placeholder = _placeholder;
		object obj3 = placeholder - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v9+BC] (should have been resolved before IL gen)");
	}

	public void Despawn()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001f: Expected I, but got Obj
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+DC] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		object obj2 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v6 (Il2CppClass<SYBO.Subway.Placeholders.Lifecycles.PlaceholderLifecycle>)+EC] (should have been resolved before IL gen)");
	}

	protected virtual void DespawnInstances()
	{
		if (_placeholder.HasSpawnedInstances)
		{
			_placeholder.DespawnInstances();
		}
	}

	protected void Activate()
	{
		_placeholder.Activate();
	}

	protected void Deactivate()
	{
		_placeholder.Deactivate();
	}

	private void OnValidate()
	{
		PlaceholderLifecycle[] components = GetComponents<PlaceholderLifecycle>();
		if (components.Length >= 2)
		{
			string text = name;
			Transform transform = base.transform;
			string longName = Utils.GetLongName(transform);
			string text2 = "'" + text + "' has two PlaceholderLifecycle components at " + longName;
		}
	}
}
