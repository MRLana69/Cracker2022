using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Components.Utilities;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Routes;
using UnityEngine;
using UnityEngine.UI;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingObjectActivity : Activity
{
	private PlaceholderLifecycle _movingObject;

	private float _speed;

	private float _desiredSpeed;

	private Transform _initialParent;

	private RouteChunk _routeChunk;

	public float Speed
	{
		get
		{
			//IL_0027: Expected F4, but got I
			//IL_0052: Expected F4, but got I
			//IL_0052: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingObjectActivity)+34]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingObjectActivity)+30]");
			float result = 0f;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingObjectActivity)+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingObjectActivity)+3C]");
				float num2 = ScrollRect.RubberDelta((float)num, 0f);
				result = num2;
			}
			return result;
		}
	}

	protected override void Initialize()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		_ = 200f;
		_ = 400f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Collider> list = default;
		list._002Ector();
		object obj = this - -64;
		obj = list;
		((MovingCarActivity)this).Initialize();
	}

	public override void Prepare(IActivityInitializer initializer)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
	}

	protected override void Execute()
	{
		CheckInitialize();
	}

	private unsafe void UpdateCurrentChunk()
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014b: Expected VT, but got Obj
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01be: Expected F4, but got Obj
		//IL_01b9: Expected native int or pointer, but got VT
		//IL_01d3: Expected F4, but got I
		//IL_01ce: Expected native int or pointer, but got VT
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected VT, but got Unknown
		//IL_00ae: Expected F4, but got Obj
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_00c0: Expected F4, but got I
		//IL_00bb: Expected native int or pointer, but got VT
		//IL_00cd: Expected F4, but got Obj
		//IL_00c8: Expected native int or pointer, but got VT
		//IL_00e2: Expected F4, but got I
		//IL_00dd: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0105: Expected F4, but got Obj
		//IL_0100: Expected native int or pointer, but got VT
		//IL_011a: Expected F4, but got I
		//IL_0115: Expected native int or pointer, but got VT
		//IL_0123: Expected Obj, but got VT
		Stop();
		object obj = default;
		Transform transform = (Transform)(obj + 48);
		transform.localPosition = (Vector3)_transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj + 36;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj + 72);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj4 = obj + 24;
		Quaternion quaternion = Quaternion.AngleAxis(_speed, vector);
		float unscaledTime = Time.unscaledTime;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v24+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj5 = obj + 12;
		Vector3 vector2 = vector / unscaledTime;
		Vector3 vector3 = (Vector3)(obj + 60);
		((Vector3*)(nint)vector3)->x = (float)transform;
		((Vector3*)(nint)vector3)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v30+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector4 = vector3 - vector;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
	}

	public unsafe override void Stop()
	{
		//IL_0301: Expected I, but got Obj
		//IL_0317: Expected Obj, but got I
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03d9: Expected VT, but got Obj
		//IL_03d9: Expected Obj, but got I4
		//IL_0062: Invalid comparison between I and F4
		//IL_0013: Expected I, but got Obj
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_034c: Expected VT, but got Obj
		//IL_034c: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v55 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		bool isRestricted = AgeRestriction.isRestricted;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)_transform);
		float timeInDefaultRoute = ((RouteManager)(object)_routeChunk).TimeInDefaultRoute;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		bool flag = 0f < timeInDefaultRoute;
		RouteChunk routeChunk = _routeChunk;
		ComputeShader computeShader;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v19 (SYBO.Subway.Routes.RouteChunk)+48]");
			computeShader = (ComputeShader)0;
		}
		else
		{
			EnvironmentBaseKind environmentBaseKind = RouteChunk.EnvironentBaseToBaseKind((EnvironmentBase)(object)_routeChunk);
			nint num3 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v36 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v43 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRestricted2 = AgeRestriction.isRestricted;
			Vector3 gamePosition2 = ((GamePositionRoot)isRestricted2).GetGamePosition((Vector3)_transform);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			if (num5 >= 0)
			{
				return;
			}
			RouteChunk routeChunk2 = _routeChunk;
			computeShader = (ComputeShader)(object)routeChunk2.Next;
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			RouteChunk routeChunk3 = default;
			((UnityEngine.Object)routeChunk3).m_CachedPtr = cachedPtr;
			_ = 0;
			object obj6 = routeChunk3 + 16;
			obj6 = this;
			Bounds trackBounds = routeChunk3.TrackBounds;
			object obj7 = this + 40;
			obj7 = computeShader;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ L2_v4 (UnityEngine.ComputeShader)+6C]");
			if ((nint)0 != 0)
			{
				GameObject parentInternal = _routeChunk.gameObject;
				_transform.parentInternal = (Transform)(object)parentInternal;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Action action = default;
				((Delegate)action).method_ptr = method_ptr;
				((Delegate)action).method = (nint)__ldftn(MovingObjectActivity.RouteChunk_OnDeactivate);
				object obj8 = action + 16;
				obj8 = this;
				_routeChunk.OnDeactivate -= action;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	private void RouteChunk_OnDeactivate()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) == 0)
		{
			_running = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			RouteChunk routeChunk = default;
			((UnityEngine.Object)routeChunk).m_CachedPtr = cachedPtr;
			_ = 0;
			object obj = routeChunk + 16;
			obj = this;
			Bounds trackBounds = routeChunk.TrackBounds;
			_movingObject.DespawnInstances();
			nint num = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v14 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v19 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PoolManager.AddPool((PrefabPool)(object)_transform);
		}
		else
		{
			SDebug.LogFormat("Stop called on uninitialized MovingCarActivity", null);
		}
	}

	public MovingObjectActivity()
	{
		if (~(_running ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
