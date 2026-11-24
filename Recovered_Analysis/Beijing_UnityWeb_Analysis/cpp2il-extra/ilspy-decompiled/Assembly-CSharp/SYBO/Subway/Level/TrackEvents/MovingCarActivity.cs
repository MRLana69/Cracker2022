using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Utility;
using SYBO.Common;
using SYBO.Components.Utilities;
using SYBO.Subway.Level.TrackEvents.CarActivities;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Routes;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarActivity : Activity
{
	private PlaceholderLifecycle _carPlaceholderLifecycle;

	private CollisionNotifier _brakingTrigger;

	private ITurnable _turnableBehaviour;

	private float _speed;

	private float Acceleration__BackingField;

	private float _desiredSpeed;

	private float _brakeStartSpeed;

	private float _brakeStartDistance;

	private bool _braking;

	private bool _carAheadMoveOpposite;

	private MovingCarActivity _carAhead;

	private Transform _carAheadTransforn;

	private BoxCollider _collider;

	private RouteChunk _routeChunk;

	public float Speed
	{
		get
		{
			//IL_0007: Expected F4, but got I4
			return _initialized ? 1 : 0;
		}
	}

	public unsafe float Acceleration
	{
		get
		{
			return _speed;
		}
		set
		{
			//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Expected I4, but got Unknown
			//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Expected Obj, but got Unknown
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Expected Obj, but got Unknown
			//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Expected Obj, but got Unknown
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e5: Expected Obj, but got Unknown
			//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I
			//IL_0044: Expected Obj, but got I
			//IL_005e: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I
			//IL_007b: Expected I4, but got Obj
			//IL_00eb: Expected Obj, but got I
			//IL_0438: Expected I4, but got Obj
			//IL_020b: Expected F4, but got I
			//IL_0219: Expected I, but got Obj
			//IL_022f: Expected Obj, but got I
			//IL_0183: Expected Obj, but got I4
			//IL_06a4: Expected Obj, but got I
			//IL_06b1: Expected I4, but got Obj
			//IL_06d0: Expected I, but got Obj
			//IL_06e6: Expected Obj, but got I
			//IL_0120: Expected Obj, but got I
			//IL_049a: Expected Obj, but got I4
			//IL_025a: Expected I, but got Obj
			//IL_0175: Expected Obj, but got I
			//IL_0196: Expected I, but got Obj
			//IL_0160: Expected Obj, but got I4
			//IL_05ea: Expected I, but got Obj
			//IL_0600: Expected Obj, but got I
			//IL_0731: Expected I, but got Obj
			//IL_0747: Expected Obj, but got I
			//IL_0633: Expected I4, but got Obj
			//IL_064d: Expected VT, but got I4
			//IL_065e: Expected I4, but got Obj
			//IL_0674: Expected Obj, but got I4
			//IL_02ed: Expected I, but got Obj
			//IL_033a: Expected I, but got Obj
			//IL_068f: Expected I4, but got Obj
			object obj = default;
			Easings.Functions functions = (Easings.Functions)(obj + 32);
			object obj2 = obj + 8;
			object obj3 = obj + 24;
			object obj4 = obj + 16;
			object obj5 = obj + 56;
			object obj6 = obj + 44;
			bool running = _running;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (System.Boolean)+C]");
			if ((nint)0 < (nint)1)
			{
				((Renderer)(object)_brakingTrigger).shadowCastingMode = ShadowCastingMode.Off;
				return;
			}
			bool running2 = _running;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v12 (System.Boolean)+8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v13+14]");
			obj2 = 0;
			bool running3 = _running;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v16 (System.Boolean)+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v17+14]");
			obj3 = 0;
			((Easings.Functions*)(int)functions)->value__ = (int)obj3;
			float num = Easings.Interpolate(value, functions);
			bool running4 = _running;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v46 (System.Boolean)+C]");
			bool flag = (nint)0 >= (nint)2;
			bool flag2 = !flag;
			float num2 = num;
			if (!flag2)
			{
				bool running5 = _running;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v81 (System.Boolean)+8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v82+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v82+8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v82+C]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S2_v23+8]");
					if (num3 == 0)
					{
						object obj11 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v82+C]");
						object obj11 = 0;
					}
				}
				else
				{
					object obj11 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v84+14]");
				obj4 = 0;
				((Easings.Functions*)(int)functions)->value__ = (int)obj4;
				float num4 = Easings.Interpolate(value, functions);
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v115 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num6 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v123 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = num > num4;
				bool flag4 = !flag3;
				bool flag5 = !flag4;
				num2 = num;
				if (!flag5)
				{
					num2 = num4;
				}
			}
			if (num2 > 0f)
			{
				float analyticsSamplingKey = AnalyticsSave.analyticsSamplingKey;
				obj2 = obj2;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float num7 = 0f;
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v37 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v76 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num10 = value - analyticsSamplingKey;
				float num11 = (float)obj2 + (float)_transform;
				if (num10 < num11)
				{
					num7 = num11;
				}
				else if (!(num10 > num7))
				{
					num7 = num10;
				}
				nint num12 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v48 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num13 = (nint)typeof(GamePositionRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v71 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isRestricted = AgeRestriction.isRestricted;
				float num14 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S1_v53 (System.Boolean)+10]");
				float angle = num14 - 0f;
				nint num15 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v79 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num16 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v95 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 back = Vector3.back;
				((Easings.Functions*)(int)functions)->value__ = (int)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				Quaternion quaternion = Quaternion.AngleAxis(angle, (Vector3)functions);
				((Easings.Functions*)(int)functions)->value__ = (int)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				Vector3 localPosition = ((Transform)functions).localPosition;
				((Renderer)(object)_brakingTrigger).shadowCastingMode = ShadowCastingMode.On;
				Material sharedMaterial = ((Renderer)(object)_brakingTrigger).sharedMaterial;
				float value2;
				if (num2 < 0f)
				{
					value2 = 0f;
				}
				else
				{
					value2 = ((!(num2 > 1f)) ? num2 : 1f);
				}
				((SkinnedMeshRenderer)(object)sharedMaterial).SetBlendShapeWeight((int)"_BackgroundCullingAlpha", value2);
			}
			else
			{
				((Renderer)(object)_brakingTrigger).shadowCastingMode = ShadowCastingMode.Off;
			}
			((Easings.Functions*)(int)functions)->value__ = (int)obj2;
			float analyticsSamplingKey2 = AnalyticsSave.analyticsSamplingKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Kiloo.Common.Utility.Easings+Functions)+4]");
			float num17 = 0f + analyticsSamplingKey2;
			float num18 = num17 + 100f;
			if (num18 < value)
			{
				((LinkedList<BackgroundCulling.CullingBlock>)_running).RemoveFirst();
			}
		}
	}

	protected override void Initialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98B2");
	}

	public override void Prepare(IActivityInitializer initializer)
	{
		Run();
	}

	protected override void Execute()
	{
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got VT
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		CheckInitialize();
		Acceleration__BackingField = 1f;
		object obj = this + 68;
		Collider component = GetComponent<Collider>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<Collider> action = default;
		object obj3 = action + 16;
		obj3 = this;
		_brakingTrigger.TriggerEnter -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<Collider> action2 = default;
		object obj4 = action2 + 16;
		obj4 = this;
		_brakingTrigger.TriggerExit -= action2;
		object obj5 = this + 32;
		string text = tag;
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)text).GetComponentInChildren<T>();
		obj5 = componentInChildren;
		if (_turnableBehaviour == null)
		{
			object obj6 = this + 32;
			string text2 = tag;
			LerpedTurn lerpedTurn = ((GameObject)(object)text2).AddComponent<LerpedTurn>();
			obj6 = lerpedTurn;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
	}

	private unsafe void UpdateCurrentChunk()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002d: Expected VT, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected VT, but got Unknown
		//IL_01f9: Expected F4, but got Obj
		//IL_01f4: Expected native int or pointer, but got VT
		//IL_020e: Expected F4, but got I
		//IL_0209: Expected native int or pointer, but got VT
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0245: Expected F4, but got Obj
		//IL_0240: Expected native int or pointer, but got VT
		//IL_025a: Expected F4, but got I
		//IL_0255: Expected native int or pointer, but got VT
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_00ea: Expected F4, but got Obj
		//IL_00e5: Expected native int or pointer, but got VT
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected VT, but got Unknown
		//IL_013b: Expected F4, but got Obj
		//IL_0136: Expected native int or pointer, but got VT
		//IL_014d: Expected F4, but got I
		//IL_0148: Expected native int or pointer, but got VT
		//IL_015a: Expected F4, but got Obj
		//IL_0155: Expected native int or pointer, but got VT
		//IL_016f: Expected F4, but got I
		//IL_016a: Expected native int or pointer, but got VT
		//IL_009e: Expected I, but got Obj
		//IL_0192: Expected F4, but got Obj
		//IL_018d: Expected native int or pointer, but got VT
		//IL_01a7: Expected F4, but got I
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_01b0: Expected Obj, but got VT
		Stop();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		if (~(_braking ? 1u : 0u) == 0)
		{
			RouteChunk_OnDeactivate();
		}
		object obj = default;
		Transform transform = (Transform)(obj + 60);
		transform.position = (Vector3)_transform;
		object obj2 = obj + 48;
		Quaternion rotation = _transform.rotation;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v51 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj + 84);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj4 = obj + 36;
		Quaternion quaternion = Quaternion.AngleAxis(_speed, vector);
		float unscaledTime = Time.unscaledTime;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v28+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj5 = obj + 24;
		Vector3 vector2 = vector / unscaledTime;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v34+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj6 = obj + 12;
		Vector3 vector3 = vector / Acceleration__BackingField;
		Vector3 vector4 = (Vector3)(obj + 72);
		((Vector3*)(nint)vector4)->x = (float)transform;
		((Vector3*)(nint)vector4)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v40+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector5 = vector4 - vector;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 localPosition = ((Transform)vector).localPosition;
	}

	private unsafe void OnTriggerEnter(Collider trigger)
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0063: Expected I, but got Obj
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		Run();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Transform parentInternal = default;
		_transform.parentInternal = parentInternal;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v51 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj3 + 32);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v14+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v20 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v47 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj3;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8685");
		float desiredSpeed = default;
		_desiredSpeed = desiredSpeed;
		_speed = _desiredSpeed;
		object obj5 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(MovingCarActivity.RouteChunk_OnDeactivate);
		object obj7 = action + 16;
		obj7 = this;
		_routeChunk.OnDeactivate -= action;
		_running = false;
		_braking = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		_carPlaceholderLifecycle.Despawn();
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
			object obj7 = this + 72;
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
				((Delegate)action).method = (nint)__ldftn(MovingCarActivity.RouteChunk_OnDeactivate);
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

	private void Brake()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_00e8: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) == 0)
		{
			_running = false;
			_braking = false;
			object obj = this + 60;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			_brakingTrigger._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			RouteChunk routeChunk = default;
			((UnityEngine.Object)routeChunk).m_CachedPtr = cachedPtr;
			_ = 0;
			object obj2 = routeChunk + 16;
			obj2 = this;
			Bounds trackBounds = routeChunk.TrackBounds;
			_carPlaceholderLifecycle.DespawnInstances();
			nint num = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v20 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v25 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
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

	private Vector3 GapStartPoint()
	{
		Component component = ((GameObject)(object)this).GetComponent((Type)(object)"TrackEventTrigger");
		if ((object)component != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
		Vector3 result = default;
		return result;
	}

	private unsafe Vector3 GapEndPoint()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0177: Expected VT, but got Obj
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0194: Expected VT, but got Obj
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got F4
		//IL_01d8: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected VT, but got Unknown
		//IL_0226: Expected F4, but got Obj
		//IL_0221: Expected native int or pointer, but got VT
		//IL_0238: Expected F4, but got I
		//IL_0233: Expected native int or pointer, but got VT
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected VT, but got Unknown
		//IL_0253: Expected F4, but got Obj
		//IL_024e: Expected native int or pointer, but got VT
		//IL_0268: Expected F4, but got I
		//IL_0263: Expected native int or pointer, but got VT
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02b1: Expected F4, but got Obj
		//IL_02ac: Expected native int or pointer, but got VT
		//IL_02c6: Expected F4, but got I
		//IL_02c1: Expected native int or pointer, but got VT
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006f: Expected VT, but got Obj
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_008c: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00c1: Expected F4, but got Obj
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00d6: Expected F4, but got I
		//IL_00d1: Expected native int or pointer, but got VT
		//IL_0108: Expected F4, but got Obj
		//IL_0103: Expected native int or pointer, but got VT
		//IL_011d: Expected F4, but got I
		//IL_0118: Expected native int or pointer, but got VT
		//IL_012a: Expected F4, but got Obj
		//IL_0125: Expected native int or pointer, but got VT
		//IL_013f: Expected F4, but got I
		//IL_013a: Expected native int or pointer, but got VT
		object obj = default;
		Transform transform = (Transform)(obj + 108);
		transform.position = (Vector3)_transform;
		BoxCollider boxCollider = (BoxCollider)(obj + 96);
		boxCollider.center = (Vector3)_collider;
		object obj2 = obj + 84;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = 0f;
		_ = ((UnityEngine.Object)boxCollider).m_CachedPtr;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v59 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj + 120);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj + 132);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v15+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj4 = obj + 72;
		Vector3 vector3 = vector - vector2;
		object obj5 = obj + 60;
		Quaternion rotation = _transform.rotation;
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v34+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj6 = obj + 36;
		Vector3 vector4 = vector2 / 0.5f;
		BoxCollider boxCollider2 = (BoxCollider)(obj + 24);
		boxCollider2.size = (Vector3)_collider;
		BoxCollider boxCollider3 = (BoxCollider)(obj + 12);
		boxCollider3.size = (Vector3)_collider;
		object obj7 = obj + 48;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v38+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v48+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		float num3 = (float)(nint)((UnityEngine.Object)boxCollider2).m_CachedPtr + (float)boxCollider3;
		Vector3 vector5 = vector2 / num3;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v32+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector6 = vector - vector2;
		Vector3 result = default;
		return result;
	}

	private unsafe void RouteChunk_OnDeactivate()
	{
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_035b: Expected I, but got Obj
		//IL_0371: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected VT, but got Unknown
		//IL_01e0: Expected F4, but got Obj
		//IL_01db: Expected native int or pointer, but got VT
		//IL_01f5: Expected F4, but got I
		//IL_01f0: Expected native int or pointer, but got VT
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected VT, but got Unknown
		//IL_0210: Expected F4, but got Obj
		//IL_020b: Expected native int or pointer, but got VT
		//IL_0225: Expected F4, but got I
		//IL_0220: Expected native int or pointer, but got VT
		//IL_024e: Expected I, but got Obj
		//IL_0264: Expected Obj, but got I
		//IL_0023: Expected I, but got Obj
		//IL_0070: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I4
		MovingCarActivity carAhead = _carAhead;
		if (~(carAhead._running ? 1u : 0u) != 0)
		{
			_braking = false;
		}
		object obj2 = default;
		object obj = obj2 + 24;
		Vector3 vector = GapEndPoint();
		MovingCarActivity movingCarActivity = (MovingCarActivity)(obj2 + 12);
		movingCarActivity.BrakingTrigger_OnEnter((Collider)(object)this);
		obj2 = movingCarActivity;
		_ = ((UnityEngine.Object)movingCarActivity).m_CachedPtr;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion quaternion = (Quaternion)(obj2 + 36);
		((Quaternion*)(nint)quaternion)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Quaternion quaternion2 = (Quaternion)(obj2 + 48);
		((Quaternion*)(nint)quaternion2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		float num3 = Quaternion.Dot(quaternion, quaternion2);
		MovingCarActivity carAhead2 = _carAhead;
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v40 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v56 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num6 = num3 / _brakeStartDistance;
		if (num6 < 0f)
		{
			num6 = 0f;
		}
		else if (num6 > 1f)
		{
			num6 = 1f;
		}
		float speed = Mathf.LerpUnclamped(carAhead2._speed, _brakeStartSpeed, num6);
		_speed = speed;
		if (_speed < 1f)
		{
			_speed = 0f;
			_braking = false;
			return;
		}
		bool flag = num3 < 1f;
		MovingCarActivity carAhead3 = _carAhead;
		float num7 = _speed - carAhead3._speed;
		bool flag2 = num7 < 1f;
		object obj5 = flag | flag2;
		if (obj5 != null)
		{
			MovingCarActivity carAhead4 = _carAhead;
			_speed = carAhead4._speed;
		}
	}

	private unsafe void BrakingTrigger_OnEnter(Collider otherCollider)
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I
		//IL_0147: Expected VT, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected VT, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected VT, but got Unknown
		//IL_0200: Expected F4, but got Obj
		//IL_01fb: Expected native int or pointer, but got VT
		//IL_0215: Expected F4, but got I
		//IL_0210: Expected native int or pointer, but got VT
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0262: Expected VT, but got I
		//IL_026f: Expected F4, but got Obj
		//IL_026a: Expected native int or pointer, but got VT
		//IL_0284: Expected F4, but got I
		//IL_027f: Expected native int or pointer, but got VT
		//IL_0296: Expected F4, but got I
		//IL_007b: Expected F4, but got Obj
		//IL_0076: Expected native int or pointer, but got VT
		//IL_0090: Expected F4, but got I
		//IL_008b: Expected native int or pointer, but got VT
		//IL_00af: Expected F4, but got Obj
		//IL_00aa: Expected native int or pointer, but got VT
		//IL_00c1: Expected F4, but got I
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00ce: Expected F4, but got Obj
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00e3: Expected F4, but got I
		//IL_00de: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [otherCollider @ L1 (UnityEngine.Collider)+39]");
		bool flag = (nint)0 != 0;
		object obj = default;
		Transform transform = (Transform)(obj + 60);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [otherCollider @ L1 (UnityEngine.Collider)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6+10]");
		transform.position = (Vector3)0;
		object obj3 = obj + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [otherCollider @ L1 (UnityEngine.Collider)+3C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10+10]");
		Quaternion rotation = ((Transform)0).rotation;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj + 72);
		BoxCollider boxCollider = (BoxCollider)(obj + 24);
		object obj6 = obj + 12;
		Vector3 vector2 = (Vector3)(obj + 84);
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj7 = obj + 36;
		float angle = ((!flag) ? (-1f) : 1f);
		Quaternion quaternion = Quaternion.AngleAxis(angle, vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [otherCollider @ L1 (UnityEngine.Collider)+44]");
		boxCollider.size = (Vector3)0;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v30+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector2 / (nint)((UnityEngine.Object)boxCollider).m_CachedPtr;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v25+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector4 = vector2 / 0.5f;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector5 = vector - vector2;
	}

	private unsafe void BrakingTrigger_OnExit(Collider otherCollider)
	{
		//IL_0203: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected VT, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected VT, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_02e7: Expected F4, but got Obj
		//IL_02e2: Expected native int or pointer, but got VT
		//IL_02fc: Expected F4, but got I
		//IL_02f7: Expected native int or pointer, but got VT
		//IL_0309: Expected F4, but got Obj
		//IL_0304: Expected native int or pointer, but got VT
		//IL_031e: Expected F4, but got I
		//IL_0319: Expected native int or pointer, but got VT
		//IL_03cc: Expected F4, but got Obj
		//IL_03c7: Expected native int or pointer, but got VT
		//IL_03e1: Expected F4, but got I
		//IL_03dc: Expected native int or pointer, but got VT
		//IL_03ee: Expected F4, but got Obj
		//IL_03e9: Expected native int or pointer, but got VT
		//IL_0400: Expected F4, but got I
		//IL_03fb: Expected native int or pointer, but got VT
		//IL_018e: Expected I, but got Obj
		MovingCarActivity componentInParent = otherCollider.GetComponentInParent<MovingCarActivity>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v70 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MovingCarActivity movingCarActivity = default;
		Quaternion quaternion = (Quaternion)(movingCarActivity + 60);
		Quaternion quaternion2 = (Quaternion)(movingCarActivity + 48);
		object obj2 = movingCarActivity + 36;
		object obj3 = movingCarActivity + 24;
		object obj4 = movingCarActivity + 12;
		if (((ComputeShader)(object)componentInParent).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (componentInParent != this)
		{
			return;
		}
		object obj6 = this + 60;
		obj6 = componentInParent;
		object obj7 = this - -64;
		GameObject gameObject = componentInParent.gameObject;
		obj7 = gameObject;
		Quaternion rotation = _transform.rotation;
		object obj8 = this - -64;
		Quaternion rotation2 = ((Transform)obj8).rotation;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v62 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Quaternion*)(nint)quaternion2)->x = (float)obj2;
		Quaternion quaternion3 = quaternion2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+8]");
		((Quaternion*)(nint)quaternion3)->z = 0f;
		((Quaternion*)(nint)quaternion)->x = (float)obj3;
		Quaternion quaternion4 = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22+8]");
		((Quaternion*)(nint)quaternion4)->z = 0f;
		float num7 = quaternion2.x * quaternion.x;
		float num8 = quaternion2.y * quaternion.y;
		float num9 = num7 + num8;
		float num10 = quaternion2.z * quaternion.z;
		float num11 = num9 + num10;
		bool carAheadMoveOpposite = num11 < 0f;
		_carAheadMoveOpposite = carAheadMoveOpposite;
		_braking = true;
		Vector3 vector = GapEndPoint();
		movingCarActivity.BrakingTrigger_OnEnter((Collider)(object)this);
		((Quaternion*)(nint)quaternion2)->x = (float)obj4;
		Quaternion quaternion5 = quaternion2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v24+8]");
		((Quaternion*)(nint)quaternion5)->z = 0f;
		((Quaternion*)(nint)quaternion)->x = (float)movingCarActivity;
		((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)movingCarActivity).m_CachedPtr;
		float brakeStartDistance = Quaternion.Dot(quaternion2, quaternion);
		_brakeStartDistance = brakeStartDistance;
		_brakeStartSpeed = _speed;
	}

	public MovingCarActivity()
	{
		if (~(_running ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
