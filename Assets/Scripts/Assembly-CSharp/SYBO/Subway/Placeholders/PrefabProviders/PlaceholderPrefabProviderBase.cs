using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Placeholders.PrefabProviders;

public abstract class PlaceholderPrefabProviderBase : MonoBehaviour
{
	protected bool _initialized;

	private ThemeManager _themeManager;

	protected List<Transform> _prefabsToSpawn;

	internal List<Transform> PrefabsToSpawn => _prefabsToSpawn;

	internal abstract int PrefabCount { get; }

	private void Awake()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase>)+E4] (should have been resolved before IL gen)");
	}

	protected virtual void InitializeCheck()
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase>)+EC] (should have been resolved before IL gen)");
			_initialized = true;
		}
	}

	protected virtual void Initialize()
	{
		ThemeManager instance = ThemeManager.Instance;
		_themeManager = instance;
	}

	internal abstract void Evaluate();

	internal abstract Transform GetPrefab(int prefabIndex);

	internal unsafe Transform GetThemedPrefab(Transform prefabTransform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0067: Expected I, but got Obj
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Ref, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		nint num = (nint)this;
		object obj3 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v5 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase>)+E4] (should have been resolved before IL gen)");
		ThemeManager themeManager = _themeManager;
		Transform transform = default;
		GameObject genericPrefab = transform.gameObject;
		bool flag = themeManager._theme.TryGetThemePrefabFromGeneric(genericPrefab, out *(GameObject*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			return ((GameObject)0).transform;
		}
		Transform result = default;
		return result;
	}

	protected PlaceholderPrefabProviderBase()
	{
		List<Transform> list = default;
		list._002Ector(1);
		_prefabsToSpawn = list;
		base._002Ector();
	}
}
