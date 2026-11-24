using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Level.TrackEvents;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.Environments;

public class EnvironmentTransitionController : SingletonMonoBehaviour<EnvironmentTransitionController>
{
	private EnvironmentKind _lastEnvironmentKind;

	private Queue<Transform> _spawnedTransitions;

	protected override void SubclassInitialize()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 12;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	protected unsafe override void OnDestroy()
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(EnvironmentTransitionController.RouteChunk_OnEnvironmentSegmentSpawned);
		object obj2 = obj + 16;
		obj2 = this;
		Delegate obj3 = ((Delegate)RouteChunk.OnEnvironmentSegmentSpawned).CombineImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action<EnvironmentKind, int, Route> onEnvironmentSegmentSpawned = default;
		RouteChunk.OnEnvironmentSegmentSpawned = onEnvironmentSegmentSpawned;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr2;
		((Delegate)action).method = (nint)__ldftn(EnvironmentTransitionController.Game_OnGameEnded);
		object obj4 = action + 16;
		obj4 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameEnded -= action;
	}

	private void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind environmentKind, int gamePositionZ, Route route)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = environmentKind;
	}

	private void Spawn(Transform prefab, int gamePositionZ)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.EnvironmentTransitionController)+18]");
		if ((nint)0 == 0)
		{
			((TrackEvent)(object)this).TrackObject_OnActivate();
		}
	}

	private unsafe void Game_OnGameEnded()
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(EnvironmentTransitionController.RouteChunk_OnEnvironmentSegmentSpawned);
		object obj2 = obj + 16;
		obj2 = this;
		Delegate obj3 = ((Delegate)RouteChunk.OnEnvironmentSegmentSpawned).RemoveImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action<EnvironmentKind, int, Route> onEnvironmentSegmentSpawned = default;
		RouteChunk.OnEnvironmentSegmentSpawned = onEnvironmentSegmentSpawned;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr2;
		((Delegate)action).method = (nint)__ldftn(EnvironmentTransitionController.Game_OnGameEnded);
		object obj4 = action + 16;
		obj4 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v21 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v26 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnMenuScreenShown += action;
	}

	private void LateUpdate()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 16;
		GamePositionRoot instance = GamePositionRoot.Instance;
		obj2 = instance;
		while (true)
		{
			Queue<Transform> spawnedTransitions = _spawnedTransitions;
			if (spawnedTransitions._size >= 1)
			{
				this._002Ector();
				continue;
			}
			break;
		}
	}

	private void DespawnFirstInstance()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_016f: Expected VT, but got Obj
		//IL_00b8: Invalid comparison between F4 and I
		//IL_0054: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 12;
		Queue<Transform> spawnedTransitions = _spawnedTransitions;
		if (spawnedTransitions._size <= 0)
		{
			return;
		}
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v30 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		object obj3 = instance + 248;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v9+8]");
		_ = 0;
		Transform transform2 = _spawnedTransitions.Peek();
		transform.position = (Vector3)transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		float num3 = 0f - 170f;
		if (num3 > (float)(nint)((UnityEngine.Object)transform).m_CachedPtr)
		{
			this._002Ector();
		}
	}

	public EnvironmentTransitionController()
	{
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_0105: Expected Obj, but got VT
		//IL_0105: Expected Obj, but got I4
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_014f: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		_00210 val = (_00210)((Queue<T>)(object)_spawnedTransitions).Peek();
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v25 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		((GamePositionRoot)isRestricted).AddLock(val);
		nint num3 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.AddPool((PrefabPool)val);
	}
}
