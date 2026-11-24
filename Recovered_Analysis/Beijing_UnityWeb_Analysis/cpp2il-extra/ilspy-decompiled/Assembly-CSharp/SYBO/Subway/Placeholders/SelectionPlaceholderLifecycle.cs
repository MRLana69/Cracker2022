using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Cameras;
using SYBO.Subway.Level;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Placeholders.PrefabProviders;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.Routes.Builders.Worker;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class SelectionPlaceholderLifecycle : PlaceholderLifecycle
{
	protected bool _spawnOnceOnStart;

	private float _spawnProbability;

	private bool _locatedInIntro;

	private bool _dontSpawnInIntro;

	private Selector _selector;

	private TrackObject _trackObject;

	public bool SpawnOnceOnStart => _spawnOnceOnStart;

	public float SpawnProbability
	{
		get
		{
			List<RouteBuilder> buildersAbove = ((RouteBuilder)(object)this).BuildersAbove;
			return ((EnvironmentBackground)null).GetMaxBoundsSizeX((IEnumerable<MeshRenderer>)buildersAbove);
		}
	}

	protected override void Initialize()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = "promotion_id";
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	protected void Start()
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got VT
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_007c: Expected I, but got Obj
		//IL_0089: Expected I, but got Obj
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00dd: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		SpawnInstancesEditor();
		object obj = this + 36;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj = componentInChildren;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<List<Selector>> action = default;
		object obj2 = action + 16;
		obj2 = this;
		_selector.PerformingSelection -= action;
		object obj3 = this + 40;
		TrackObject component = GetComponent<TrackObject>();
		obj3 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		Action action2 = default;
		((Delegate)action2).method_ptr = (IntPtr)ex;
		((Delegate)action2).method = (IntPtr)ex;
		object obj4 = action2 + 16;
		obj4 = this;
		_trackObject.OnActivate -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex2 = new NullReferenceException();
		Action action3 = default;
		((Delegate)action3).method_ptr = (IntPtr)ex2;
		((Delegate)action3).method = (IntPtr)ex2;
		object obj5 = action3 + 16;
		obj5 = this;
		_trackObject.OnDeactivate -= action3;
	}

	private void OnDestroy()
	{
		//IL_0067: Expected VT, but got I4
		//IL_0067: Expected VT, but got I4
		//IL_0067: Expected Obj, but got I4
		if (~(_spawnOnceOnStart ? 1u : 0u) == 0 && Application.platform != RuntimePlatform.OSXEditor)
		{
			bool locatedInIntro = _locatedInIntro;
			((CharacterCamera)(object)this).SetCameraDataForcefully((CameraData)1, (Vector3)1, (Quaternion)locatedInIntro);
		}
	}

	private void SpawnInstances(bool spawnInChildrenLifecycles = false, bool spawningOnStart = false, bool locatedInIntro = false)
	{
		//IL_0017: Expected Obj, but got I4
		SpawnInstances((PlaceholderPrefabProviderBase)spawnInChildrenLifecycles, spawningOnStart, spawningOnStart: true, locatedInIntro);
	}

	protected virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false, bool spawningOnStart = false, bool locatedInIntro = false)
	{
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stack<IEnumerator> stack = default;
		object obj = stack + 8;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0xFFF;
		object obj6 = obj5 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S2_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		obj = obj7;
		stack.Push((IEnumerator)spawnInChildrenLifecycles);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MultiplePlaceholderPrefabProvider.GenericSpawnInfo genericSpawnInfo = default;
		object obj8 = genericSpawnInfo + 8;
		obj8 = stack;
		object obj9 = genericSpawnInfo + 12;
		obj9 = prefabProvider;
		genericSpawnInfo.MinDevicePerformance = (spawningOnStart ? DeviceInfo.PerformanceLevel.Medium : DeviceInfo.PerformanceLevel.Low);
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		if (obj10 != null)
		{
			((MultiplePlaceholderPrefabProvider.GenericSpawnInfo)obj10)._002Ector();
			bool flag = ((Dictionary<RouteChunk, RouteBuilderWorker.WorkWrapper>)(nint)((UnityEngine.Object)this).m_CachedPtr).Remove((RouteChunk)(object)prefabProvider);
		}
		if (locatedInIntro)
		{
			genericSpawnInfo._002Ector();
			return;
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S4_v4+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v5+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v103 @ S5_v5 (should have been resolved before IL gen)");
		Queue<RouteBuilderWorker.WorkWrapper> queue = (Queue<RouteBuilderWorker.WorkWrapper>)((!spawningOnStart) ? ((object)(Queue<RouteBuilderWorker.WorkWrapper>)_initialized) : ((object)_prefabProvider));
		queue.Enqueue((RouteBuilderWorker.WorkWrapper)(object)genericSpawnInfo);
	}

	protected virtual void GetSpawnedObjects(List<Selector> selectors)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [selectors @ L1 (System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>)+64]");
		SelectionPlaceholderLifecycle selectionPlaceholderLifecycle = (SelectionPlaceholderLifecycle)0;
	}

	protected virtual void TrackObject_OnActivate()
	{
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00f0: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		//IL_0161: Expected I, but got Obj
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_selector).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			List<GameObject> list = default;
			list._items = (GameObject[])num3;
			list._syncRoot = 0;
			object obj2 = list + 16;
			obj2 = this;
			_selector.PerformSelection(list);
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_trackObject).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = new NullReferenceException();
			Action action = default;
			((Delegate)action).method_ptr = (IntPtr)ex;
			((Delegate)action).method = (IntPtr)ex;
			object obj4 = action + 16;
			obj4 = this;
			_trackObject.OnDeactivate += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex2 = new NullReferenceException();
			bool flag = default;
			object obj5 = (flag ? 1 : 0) + 16;
			obj5 = this;
			_trackObject.PropagateActivationStateToChildren = flag;
		}
	}

	protected virtual void TrackObject_OnDeactivate()
	{
		Deactivate();
	}

	private void Selector_OnPerformingSelection(List<Selector> selectors)
	{
		_placeholder.GetTrackObjects_Cached((Transform)(object)selectors);
	}

	public SelectionPlaceholderLifecycle()
	{
		OnValidate();
		if (~(_spawnOnceOnStart ? 1u : 0u) != 0)
		{
			base.DespawnInstances();
		}
	}
}
