using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Level.Environments;

public class EnvironmentTransitionController : Singleton<EnvironmentTransitionController>
{
	private EnvironmentKind _lastEnvironmentKind;

	private Queue<Transform> _spawnedTransitions;

	private float _firstActivePosZ;

	protected override void Awake()
	{
		base.Awake();
		throw new ArgumentException();
	}

	protected override void OnDestroy()
	{
		throw new ArrayTypeMismatchException();
	}

	private unsafe void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind environmentKind, int posZ, Route route)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02b2: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Ref, but got Unknown
		//IL_026d: Expected Obj, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		nint num = (nint)route;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v5 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
		object obj3 = default;
		if ((nint)obj3 != 1)
		{
			return;
		}
		EnvironmentKind lastEnvironmentKind = _lastEnvironmentKind;
		if (environmentKind._type == lastEnvironmentKind._type && environmentKind._density == lastEnvironmentKind._density)
		{
			return;
		}
		ThemeManager instance = ThemeManager.Instance;
		Theme theme = instance._theme;
		TransitionConfig[] environmentTransitionConfigs = theme._environmentTransitionConfigs;
		for (ref Transform reference = ref *(Transform*)null; (nint)environmentTransitionConfigs.Length > (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference); reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1))
		{
			object obj4 = (nuint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) << 2;
			object obj5 = (object)environmentTransitionConfigs + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v33+10]");
			TransitionConfig transitionConfig = (TransitionConfig)0;
			EnvironmentKind environmentKind2 = transitionConfig._environmentKind;
			EnvironmentKind lastEnvironmentKind2 = _lastEnvironmentKind;
			ref Transform reference3;
			if (environmentKind2._type == lastEnvironmentKind2._type && environmentKind2._density == lastEnvironmentKind2._density)
			{
				Game instance2 = Game.Instance;
				if (!transitionConfig.TryGetEndPrefab(environmentKind, instance2._randomGenerator, out *(Transform*)(obj + 12)))
				{
					continue;
				}
			}
			else
			{
				EnvironmentKind environmentKind3 = transitionConfig._environmentKind;
				if (environmentKind3._type != environmentKind._type || environmentKind3._density != environmentKind._density)
				{
					continue;
				}
				Game instance3 = Game.Instance;
				ref Transform reference2 = ref *(Transform*)(obj + 12);
				bool flag = transitionConfig.TryGetStartPrefab(_lastEnvironmentKind, instance3._randomGenerator, out reference2);
				bool flag2 = !flag;
				reference3 = ref reference2;
				if (flag2)
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			Spawn((Transform)0, posZ);
			reference3 = ref reference;
		}
		_lastEnvironmentKind = environmentKind;
	}

	private unsafe void Spawn(Transform prefab, int posZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00cb: Expected I, but got Obj
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_012d: Expected F4, but got I
		//IL_0128: Expected native int or pointer, but got VT
		//IL_014c: Expected F4, but got I
		//IL_0147: Expected native int or pointer, but got VT
		//IL_0085: Expected F4, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (!(prefab == null))
		{
			Transform transform = PoolManager.Spawn(prefab);
			Transform transform2 = transform.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			object obj2 = Vector3.forwardVector * posZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v26 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
			object obj3 = (nint)0 * (nint)posZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v26 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
			object obj4 = (nint)0 * (nint)posZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform2.position = vector;
			Transform transform3 = transform.transform;
			Transform parent = base.transform;
			transform3.parent = parent;
			Queue<Transform> spawnedTransitions = _spawnedTransitions;
			if (spawnedTransitions._size == 0)
			{
				_firstActivePosZ = posZ;
			}
			_spawnedTransitions.Enqueue(transform);
		}
	}

	private void Game_OnGameEnded()
	{
		EnvironmentKind none = EnvironmentKind.None;
		_lastEnvironmentKind = none;
		while (true)
		{
			Queue<Transform> spawnedTransitions = _spawnedTransitions;
			if (spawnedTransitions._size > 0)
			{
				DespawnFirstInstance();
				continue;
			}
			break;
		}
	}

	private void LateUpdate()
	{
		if (_firstActivePosZ > 0f)
		{
			Character instance = Character.Instance;
			float num = instance.z - 170f;
			if (num > _firstActivePosZ)
			{
				DespawnFirstInstance();
			}
		}
	}

	private void DespawnFirstInstance()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0089: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Transform instance = _spawnedTransitions.Dequeue();
		PoolManager.Despawn(instance);
		Queue<Transform> spawnedTransitions = _spawnedTransitions;
		float firstActivePosZ;
		if (spawnedTransitions._size < 1)
		{
			firstActivePosZ = 0f;
		}
		else
		{
			Transform transform = _spawnedTransitions.Peek();
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			firstActivePosZ = 0f;
		}
		_firstActivePosZ = firstActivePosZ;
	}

	public EnvironmentTransitionController()
	{
		EnvironmentKind none = EnvironmentKind.None;
		_lastEnvironmentKind = none;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S2_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Queue`1<UnityEngine.Transform>>>)+4] (should have been resolved before IL gen)");
		Queue<Transform> queue = default;
		Transform[] array = default;
		queue._array = array;
		_spawnedTransitions = queue;
		base._002Ector();
	}
}
