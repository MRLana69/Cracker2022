using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Level;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Placeholders.PrefabProviders;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class SelectionPlaceholderLifecycle : PlaceholderLifecycle
{
	protected bool _spawnOnceOnStart;

	private float _spawnProbability = 1f;

	private bool _locatedInIntro;

	private bool _dontSpawnInIntro;

	private Selector _selector;

	private TrackObject _trackObject;

	public bool SpawnOnceOnStart => _spawnOnceOnStart;

	public float SpawnProbability => _spawnProbability;

	protected override void Initialize()
	{
		base.Initialize();
		Selector component = GetComponent<Selector>();
		_selector = component;
		throw new ArgumentException();
	}

	protected void Start()
	{
		if (~(_spawnOnceOnStart ? 1u : 0u) == 0 && Application.isPlaying)
		{
			SpawnInstances(spawnInChildrenLifecycles: true, spawningOnStart: true, _locatedInIntro);
		}
	}

	private void OnDestroy()
	{
		//IL_006e: Expected I, but got Obj
		//IL_009e: Expected I, but got Obj
		if (_selector != null)
		{
			throw new ArgumentException();
		}
		if (_trackObject != null)
		{
			NullReferenceException ex = new NullReferenceException();
			Action action = default;
			action._002Ector(this, (IntPtr)ex);
			_trackObject.OnActivate -= action;
			NullReferenceException ex2 = new NullReferenceException();
			Action action2 = default;
			action2._002Ector(this, (IntPtr)ex2);
			_trackObject.OnDeactivate -= action2;
		}
	}

	private void SpawnInstances(bool spawnInChildrenLifecycles = false, bool spawningOnStart = false, bool locatedInIntro = false)
	{
		//IL_0062: Expected I, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		if (!locatedInIntro || !_dontSpawnInIntro)
		{
			float value = UnityEngine.Random.value;
			if (!(_spawnProbability < value))
			{
				PlaceholderPrefabProviderBase prefabProvider = _prefabProvider;
				nint num = (nint)prefabProvider;
				object obj = prefabProvider + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S1_v5 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase>)+F4] (should have been resolved before IL gen)");
				nint num2 = (nint)this;
				object obj2 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S5_v3 (Il2CppClass<SYBO.Subway.Placeholders.SelectionPlaceholderLifecycle>)+F4] (should have been resolved before IL gen)");
			}
		}
	}

	protected virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false, bool spawningOnStart = false, bool locatedInIntro = false)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I
		Placeholder placeholder = _placeholder;
		object obj = placeholder - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S2_v3+BC] (should have been resolved before IL gen)");
		if (!spawnInChildrenLifecycles)
		{
			return;
		}
		SelectionPlaceholderLifecycle[] componentsInChildren = GetComponentsInChildren<SelectionPlaceholderLifecycle>(includeInactive: true);
		object obj2 = 0;
		while ((nint)obj2 < componentsInChildren.Length)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)componentsInChildren + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v17+10]");
			if (!((UnityEngine.Object)0 == this))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v17+10]");
				((SelectionPlaceholderLifecycle)0).SpawnInstances(spawnInChildrenLifecycles: true, spawningOnStart, locatedInIntro);
			}
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
	}

	protected virtual void GetSpawnedObjects(List<Selector> selectors)
	{
		_placeholder.GetSpawnedObjects(selectors);
	}

	protected virtual void TrackObject_OnActivate()
	{
		Activate();
	}

	protected virtual void TrackObject_OnDeactivate()
	{
		Deactivate();
		if (~(_spawnOnceOnStart ? 1u : 0u) != 0)
		{
			Despawn();
		}
	}

	private void Selector_OnPerformingSelection(List<Selector> selectors)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		if (~(_spawnOnceOnStart ? 1u : 0u) != 0)
		{
			SpawnInstances();
			object obj = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S2_v5+BC] (should have been resolved before IL gen)");
		}
	}
}
