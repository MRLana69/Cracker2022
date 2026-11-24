using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.Benchmarking;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Characters;
using SYBO.Subway.UI;
using UnityEngine;
using UnityEngine.U2D;

namespace SYBO.Subway.Level;

public class MovingTrain : MonoBehaviour
{
	private Transform _characterControllerTransform;

	private float speed;

	private float trainCount;

	private static float autoPilotActivationDistance;

	private AudioClip trianPassClip;

	private static MovingTrainUpdater _updater;

	private static HashSet<MovingTrain> _activeTrains;

	private Transform _transform;

	private Transform _train;

	private BoxCollider _trainCollider;

	private Vector3 _trainColliderInitialSize;

	private TrackObject _trackObject;

	private bool _active;

	private bool _autoPilot;

	private bool _initalized;

	private float _distanceToCameraZ;

	public float Speed
	{
		get
		{
			//IL_000b: Expected Obj, but got I
			long elapsedTicks = ((Stopwatch)(nint)((UnityEngine.Object)this).m_CachedPtr).ElapsedTicks;
			float num = (float)elapsedTicks * 0.001f;
			float num2 = (float)_characterControllerTransform / num;
			object obj = (object)_transform + (object)_train;
			object obj2 = obj + (object)_trainCollider;
			float num3 = num2 / (float)obj2;
			return num3 * (float)elapsedTicks;
		}
		set
		{
			//IL_000a: Expected I, but got F4
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)value;
		}
	}

	public bool Active
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public float DistanceToCameraZ => speed;

	public static int GetActiveTrainCount()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FrameTimeAboveMetric frameTimeAboveMetric = default;
		frameTimeAboveMetric.Cleanup();
		throw new ArrayTypeMismatchException();
	}

	private void Awake()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 12;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj3 = this + 16;
		object obj4 = default;
		obj3 = obj4;
		CancelInvoke();
	}

	private void CheckInitialize()
	{
		OnDestroy();
	}

	private unsafe void OnDestroy()
	{
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected VT, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0548: Expected I, but got Obj
		//IL_055e: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I4
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_0186: Expected I4, but got Obj
		//IL_05c4: Expected F4, but got Obj
		//IL_05bf: Expected native int or pointer, but got VT
		//IL_05d9: Expected F4, but got I
		//IL_05d4: Expected native int or pointer, but got VT
		//IL_05f3: Expected F4, but got Obj
		//IL_05ee: Expected native int or pointer, but got VT
		//IL_0608: Expected F4, but got I
		//IL_0603: Expected native int or pointer, but got VT
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_033f: Expected F4, but got Obj
		//IL_033a: Expected native int or pointer, but got VT
		//IL_0354: Expected F4, but got I
		//IL_034f: Expected native int or pointer, but got VT
		//IL_035d: Expected Obj, but got VT
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_02f3: Expected I, but got Obj
		//IL_0591: Expected Obj, but got I
		//IL_0392: Expected VT, but got Obj
		//IL_039f: Expected F4, but got Obj
		//IL_039a: Expected native int or pointer, but got VT
		//IL_03b1: Expected F4, but got I
		//IL_03ac: Expected native int or pointer, but got VT
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got F4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_01f5: Expected I, but got Obj
		//IL_0225: Expected I, but got Obj
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_024b: Expected I, but got Obj
		BoxCollider boxCollider = default;
		Quaternion quaternion = (Quaternion)(boxCollider + 48);
		object obj = boxCollider + 36;
		object obj2 = boxCollider + 24;
		object obj3 = boxCollider + 12;
		if (~(_initalized ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v93 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay())
		{
			return;
		}
		nint num3 = (nint)typeof(MovingTrain);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v29 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(MovingTrain);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v87 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v87 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_updater != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"MovingTrainUpdater";
			MovingTrainUpdater movingTrainUpdater = gameObject.AddComponent<MovingTrainUpdater>();
			nint num7 = (nint)typeof(MovingTrain);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v70 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			bool flag = obj7 == null;
			nint num8 = (nint)typeof(MovingTrain);
			if (!flag)
			{
				nint num9 = (nint)typeof(MovingTrain);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v81 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num8 = (nint)typeof(MovingTrain);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num8 = (nint)typeof(MovingTrain);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ L1_v11 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+5C]");
			object obj8 = (nint)0 + (nint)4;
			obj8 = movingTrainUpdater;
			_updater.AddMovingTrain((MovingTrain)(object)trianPassClip);
		}
		object obj9 = this + 28;
		GameObject gameObject2 = base.gameObject;
		obj9 = gameObject2;
		int siblingIndex = _transform.GetSiblingIndex();
		object obj10 = this + 32;
		bool flag4 = ((SpriteAtlas)(object)_transform).CanBindTo((Sprite)null);
		obj10 = flag4;
		nint num10 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v26 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v74 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 down = Vector3.down;
		((Quaternion*)(nint)quaternion)->x = (float)obj;
		Quaternion quaternion2 = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		Quaternion quaternion3 = Quaternion.Inverse(quaternion);
		((Quaternion*)(nint)quaternion)->x = (float)obj2;
		Quaternion quaternion4 = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Quaternion*)(nint)quaternion4)->z = 0f;
		Vector3 vector = (Vector3)quaternion / 200f;
		((Quaternion*)(nint)quaternion)->x = (float)obj3;
		Quaternion quaternion5 = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Quaternion*)(nint)quaternion5)->z = 0f;
		Vector3 eulerAngles = ((Transform)quaternion).eulerAngles;
		object obj12 = this + 36;
		BoxCollider component = GetComponent<BoxCollider>();
		obj12 = component;
		boxCollider.size = (Vector3)_trainCollider;
		((Quaternion*)(nint)quaternion)->x = (float)boxCollider;
		((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)boxCollider).m_CachedPtr;
		object obj13 = this + 40;
		obj13 = quaternion.x;
		_ = quaternion.z;
		_active = false;
		object obj14 = this + 52;
		TrackObject component2 = GetComponent<TrackObject>();
		obj14 = component2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(MovingTrain.OnActivate);
		object obj15 = action + 16;
		obj15 = this;
		_trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(MovingTrain.OnDeactivate);
		object obj16 = action2 + 16;
		obj16 = this;
		_trackObject.OnDeactivate -= action2;
		OnActivate();
		_initalized = true;
	}

	private unsafe void UpdateTrainCollider()
	{
		//IL_00f3: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_trackObject).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(MovingTrain.OnActivate);
			object obj2 = action + 16;
			obj2 = this;
			_trackObject.OnDeactivate += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			bool flag = default;
			object obj3 = (flag ? 1 : 0) + 16;
			obj3 = this;
			_trackObject.PropagateActivationStateToChildren = flag;
		}
	}

	private unsafe void OnActivate()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Ref, but got Unknown
		//IL_00bc: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got F4
		//IL_0137: Expected Obj, but got Ref
		object obj = this + 40;
		object obj2 = this + 40;
		object obj3 = this + 40;
		object obj5 = default;
		object obj4 = obj5 + 12;
		obj4 = 0;
		_ = 0;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v6+4]");
		_ = 0;
		float num = 1f + speed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9+8]");
		float num2 = 0f / num;
		ref Vector3 reference = ref *(Vector3*)(obj5 + 24);
		reference = ref *(Vector3*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v14+8]");
		_ = 0;
		_trainCollider.get_center_Injected(out reference);
		obj5 = 0;
		_ = 0;
		obj5 = 0f;
		_ = 15.2f;
		float num3 = 30f * trainCount;
		float num4 = num3 + 1f;
		float num5 = 1f + speed;
		float num6 = num4 / num5;
		reference = ref *(Vector3*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector3 size = ((BoxCollider)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).size;
	}

	public unsafe void UpdateMovingTrain(float gameSpeed, float characterPositionZ, float cameraPositionZ)
	{
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected VT, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_028f: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0045: Expected F4, but got Obj
		//IL_0040: Expected native int or pointer, but got VT
		//IL_005a: Expected F4, but got I
		//IL_0055: Expected native int or pointer, but got VT
		//IL_006a: Expected native int or pointer, but got VT
		//IL_0084: Expected F4, but got I
		//IL_007f: Expected native int or pointer, but got VT
		//IL_0091: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00ea: Expected F4, but got Obj
		//IL_00e5: Expected native int or pointer, but got VT
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_010f: Expected native int or pointer, but got VT
		//IL_0129: Expected F4, but got I
		//IL_0124: Expected native int or pointer, but got VT
		//IL_0136: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_01a1: Expected I, but got Obj
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0337: Expected F4, but got Obj
		//IL_0332: Expected native int or pointer, but got VT
		//IL_034c: Expected F4, but got I
		//IL_0347: Expected native int or pointer, but got VT
		//IL_035c: Expected native int or pointer, but got VT
		//IL_0376: Expected F4, but got I
		//IL_0371: Expected native int or pointer, but got VT
		//IL_0383: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I4
		object obj = default;
		Keyframe keyframe = (Keyframe)(obj + 84);
		object obj2 = obj + 56;
		object obj3 = obj + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IntPtr intPtr = default;
		AnimationCurve.Internal_Destroy(intPtr);
		float num = gameSpeed;
		object obj4 = 1;
		while (num < characterPositionZ)
		{
			obj2 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj5 = obj4 * 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Keyframe*)(nint)keyframe)->m_Time = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Keyframe*)(nint)keyframe)->m_InTangent = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
			((Keyframe*)(nint)keyframe)->m_WeightedMode = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+18]");
			((Keyframe*)(nint)keyframe)->m_OutWeight = 0f;
			int num2 = ((AnimationCurve)(nint)intPtr).AddKey_Internal(keyframe);
			obj3 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			float num3 = num + 60f;
			object obj6 = obj4 * 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Keyframe*)(nint)keyframe)->m_Time = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Keyframe*)(nint)keyframe)->m_InTangent = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
			((Keyframe*)(nint)keyframe)->m_WeightedMode = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+18]");
			((Keyframe*)(nint)keyframe)->m_OutWeight = 0f;
			int num4 = ((AnimationCurve)(nint)intPtr).AddKey_Internal(keyframe);
			int num5 = UnityEngine.Random.RandomRangeInt(-1, 2);
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v51 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v71 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AudioClip audioClip = trianPassClip;
			obj = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			float num8 = num + 60f;
			float num9 = num8 + (float)audioClip.m_PCMReaderCallback;
			object obj8 = num5 + obj4;
			if ((nint)obj8 < 0)
			{
				obj8 = 0;
			}
			else if ((nint)obj8 > 2)
			{
				obj8 = 2;
			}
			object obj9 = obj8 * 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
			((Keyframe*)(nint)keyframe)->m_Time = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Keyframe*)(nint)keyframe)->m_InTangent = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			((Keyframe*)(nint)keyframe)->m_WeightedMode = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
			((Keyframe*)(nint)keyframe)->m_OutWeight = 0f;
			int num10 = ((AnimationCurve)(nint)intPtr).AddKey_Internal(keyframe);
			AudioClip audioClip2 = trianPassClip;
			float num11 = (float)audioClip2.m_PCMReaderCallback + 60f;
			float num12 = num + num11;
			num = num12;
			obj4 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81B6");
		YieldInstruction[] list = default;
		Coroutine coroutine = CoroutineUtil.WaitForAll(list);
	}

	public unsafe Vector3 GetTrainModelPosition()
	{
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected VT, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected VT, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0439: Expected F4, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_00be: Expected native int or pointer, but got F4
		//IL_00c9: Expected I4, but got Obj
		//IL_00c9: Expected I4, but got F4
		//IL_00c9: Expected Obj, but got VT
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got F4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0459: Expected F4, but got Obj
		//IL_0454: Expected native int or pointer, but got VT
		//IL_046e: Expected F4, but got I
		//IL_0469: Expected native int or pointer, but got VT
		//IL_047b: Expected F4, but got Obj
		//IL_0476: Expected native int or pointer, but got VT
		//IL_0490: Expected F4, but got I
		//IL_048b: Expected native int or pointer, but got VT
		//IL_04ae: Expected F4, but got Obj
		//IL_04a9: Expected native int or pointer, but got VT
		//IL_04c3: Expected F4, but got I
		//IL_04be: Expected native int or pointer, but got VT
		//IL_04cc: Expected Obj, but got VT
		//IL_0195: Expected I, but got Obj
		//IL_0211: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_0252: Expected I, but got Obj
		//IL_031c: Expected Obj, but got I4
		//IL_02bd: Expected VT, but got Obj
		//IL_02bd: Expected Obj, but got VT
		//IL_02ca: Expected native int or pointer, but got VT
		//IL_02dc: Expected native int or pointer, but got VT
		//IL_02ee: Expected Obj, but got VT
		//IL_0308: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		Vector3 vector2 = (Vector3)(obj + 36);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+24]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+C]");
		object obj5 = 0;
		float num = speed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21 (System.Single)+C]");
		bool flag = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		float num2 = 0f;
		if (!flag)
		{
			float z = default;
			Vector3 vector3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+24]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v10+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v11+C]");
				float num3 = 0f + z;
				if (!(num2 < num3))
				{
					break;
				}
				float num4 = speed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v15 (System.Single)+C]");
				int num5 = UnityEngine.Random.RandomRangeInt(0, 0);
				float num6 = speed + 16f;
				int num7 = num5 << 2;
				float num8 = num6 + (float)num7;
				Transform transform = ((LogicAssetsManager)vector3).SpawnEnvironmentSegmentLogic((EnvironmentType)((float*)(nint)num8)->m_value, (EnvironmentSequence)this);
				GameObject gameObject = transform.gameObject;
				object obj8 = 0 - _transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+2C]");
				object obj9 = obj8 * 0;
				obj2 = 0;
				_ = 0;
				obj2 = num2;
				_ = 0f;
				object obj10 = this + 32;
				obj3 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v19+8]");
				_ = 0;
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v34 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num10 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v74 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)obj2;
				Vector3 vector4 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector4)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 vector5 = vector2 - vector;
				((Vector3*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 eulerAngles = ((Transform)vector).eulerAngles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v32 (UnityEngine.Transform)+1C]");
				z = ((EnvironmentBackground)null).GetZ(0);
				if (z > float.Epsilon)
				{
					float num11 = num2 + z;
					nint num12 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v50 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num13 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v66 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (z > z)
					{
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v32 (UnityEngine.Transform)+D]");
					if ((nint)0 != 0)
					{
						MoveGameObject component = transform.GetComponent<MoveGameObject>();
						GameObject gameObject2 = transform.gameObject;
						((Transform)vector2).localPosition = (Vector3)gameObject2;
						((Vector3*)(nint)vector)->x = vector2.x;
						((Vector3*)(nint)vector)->z = vector2.z;
						((RandomizeOffset)(object)component).SetRandomOffsetsData((RandomizeOffset.RandomOffsetsData)vector);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Level.MovingTrain)+4C]");
						((List<BackgroundObject>)0).Add((BackgroundObject)(object)transform);
					}
					((CheckpointTrigger)null).Handler_OnCharacterEnter((object)transform, (EventArgs)1);
					num2 = num11;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				UnityEngine.Object obj13 = UnityEngine.Object.Instantiate((UnityEngine.Object)transform);
				throw new ArrayTypeMismatchException();
			}
		}
		Vector3 result = default;
		return result;
	}

	private void OnDeactivate()
	{
		//IL_0141: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_020e: Expected VT, but got Obj
		//IL_021c: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0285: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got F4
		//IL_00d4: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		_trainCollider.isTrigger = true;
		nint num = (nint)typeof(MovingTrain);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(MovingTrain);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v28 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v3 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v4+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v5+38]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S3_v4 (should have been resolved before IL gen)");
		_updater.RemoveMovingTrain(this);
		_active = true;
		_autoPilot = false;
		object obj7 = default;
		Transform transform = (Transform)(obj7 + 24);
		transform.position = (Vector3)_transform;
		nint num4 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v14 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v33 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = (Transform)(obj7 + 12);
		CharacterRendering instance = CharacterRendering.Instance;
		GameObject gameObject = ((Component)(object)instance._caughtAnimationState).gameObject;
		transform2.position = (Vector3)gameObject;
		obj7 = 0;
		_ = 0;
		obj7 = 0f;
		_ = 0f;
		object obj9 = (nint)((UnityEngine.Object)transform).m_CachedPtr - (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		float num6 = (float)obj9 * speed;
		Transform transform3 = (Transform)(obj7 + 36);
		transform3 = (Transform)obj7;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform3.eulerAngles;
	}

	public override int GetHashCode()
	{
		return _active ? 1 : 0;
	}

	public override bool Equals(object o)
	{
		object obj = (object)_characterControllerTransform & o;
		return obj != null;
	}

	public unsafe static void ActivateAutoPilot()
	{
		//IL_04e8: Expected I, but got Obj
		//IL_04fe: Expected Obj, but got I
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected I, but got Unknown
		//IL_0846: Expected I, but got Obj
		//IL_086b: Expected I, but got Obj
		//IL_0881: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_08bd: Expected I, but got Obj
		//IL_08d3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_090f: Expected I, but got Obj
		//IL_0925: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_058a: Expected I, but got Obj
		//IL_05a0: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0216: Expected I, but got Obj
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_0624: Expected I, but got Obj
		//IL_063a: Expected Obj, but got I
		//IL_02f1: Expected I, but got Obj
		//IL_0307: Expected Obj, but got I
		//IL_0263: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_01c9: Expected I, but got Obj
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_06be: Expected I, but got Obj
		//IL_06d4: Expected Obj, but got I
		//IL_09a7: Expected I, but got Obj
		//IL_09bd: Expected Obj, but got I
		//IL_0332: Expected I, but got Obj
		//IL_02a4: Expected I, but got Obj
		//IL_037f: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I
		//IL_0a06: Expected I, but got Obj
		//IL_0a1c: Expected Obj, but got I
		//IL_040d: Expected I, but got Obj
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_0758: Expected I, but got Obj
		//IL_076e: Expected Obj, but got I
		//IL_045a: Expected I, but got Obj
		//IL_0470: Expected Obj, but got I
		//IL_03c0: Expected I, but got Obj
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_07f2: Expected I, but got Obj
		//IL_0808: Expected Obj, but got I
		//IL_049b: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v125 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(UIScreens);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type type = Type.internal_from_handle((IntPtr)num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		nint num4 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v11 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v171 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_0 == null;
		bool flag2 = !flag;
		Func<FieldInfo, bool> predicate = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_0;
		if (!flag2)
		{
			nint num6 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v145 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v165 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num8 = 0;
			_ = 0;
			Func<FieldInfo, bool> func = default;
			object obj4 = func + 16;
			obj4 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9;
			nint num9 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v162 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = func;
			predicate = func;
		}
		IEnumerable<FieldInfo> source2 = default;
		IEnumerable<FieldInfo> source = Enumerable.Where(source2, predicate);
		nint num10 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v22 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num11 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v138 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_1 == null;
		bool flag4 = !flag3;
		Func<FieldInfo, bool> predicate2 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_1;
		if (!flag4)
		{
			nint num12 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v112 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num13 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v132 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num14 = 0;
			_ = 0;
			Func<FieldInfo, bool> func2 = default;
			object obj8 = func2 + 16;
			obj8 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9;
			nint num15 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v129 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+5C]");
			object obj9 = (nint)0 + (nint)8;
			obj9 = func2;
			predicate2 = func2;
		}
		IEnumerable<FieldInfo> source3 = Enumerable.Where(source, predicate2);
		nint num16 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v33 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num17 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v105 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_2 == null;
		bool flag6 = !flag5;
		Func<FieldInfo, object> selector = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_2;
		if (!flag6)
		{
			nint num18 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v79 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num19 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v99 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num20 = 0;
			_ = 0;
			Func<FieldInfo, object> func3 = default;
			object obj12 = func3 + 16;
			obj12 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9;
			nint num21 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v96 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+5C]");
			object obj13 = (nint)0 + (nint)12;
			obj13 = func3;
			selector = func3;
		}
		IEnumerable<object> source4 = Enumerable.Select(source3, selector);
		IEnumerable<string> source5 = Enumerable.Cast<string>(source4);
		string[] source6 = Enumerable.ToArray(source5);
		nint num22 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v26 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num23 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v119 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag7 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_3 == null;
		bool flag8 = !flag7;
		Func<string, bool> predicate3 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_3;
		if (!flag8)
		{
			nint num24 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v93 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num25 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v113 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num26 = 0;
			_ = 0;
			Func<string, bool> func4 = default;
			object obj16 = func4 + 16;
			obj16 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9;
			nint num27 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v110 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+5C]");
			object obj17 = (nint)0 + (nint)16;
			obj17 = func4;
			predicate3 = func4;
		}
		IEnumerable<string> source7 = Enumerable.Where(source6, predicate3);
		string[] popups = Enumerable.ToArray(source7);
		SubwayMemoryBenchmark._popups = popups;
		nint num28 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S0_v42 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num29 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v86 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag9 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_4 == null;
		bool flag10 = !flag9;
		Func<string, bool> predicate4 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9__14_4;
		if (!flag10)
		{
			nint num30 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v60 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num31 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S0_v80 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num32 = 0;
			_ = 0;
			Func<string, bool> func5 = default;
			object obj20 = func5 + 16;
			obj20 = SubwayMemoryBenchmark._003C_003Ec._003C_003E9;
			nint num33 = (nint)typeof(SubwayMemoryBenchmark._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v77 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark+<>c>)+5C]");
			object obj21 = (nint)0 + (nint)20;
			obj21 = func5;
			predicate4 = func5;
		}
		IEnumerable<string> source8 = Enumerable.Where(source6, predicate4);
		string[] array = Enumerable.ToArray(source8);
		nint num34 = (nint)typeof(SubwayMemoryBenchmark);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v55 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayMemoryBenchmark>)+5C]");
		object obj22 = (nint)0 + (nint)4;
		obj22 = array;
	}

	public unsafe MovingTrain()
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_0179: Expected VT, but got Obj
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected VT, but got Unknown
		//IL_0113: Expected F4, but got Obj
		//IL_010e: Expected native int or pointer, but got VT
		//IL_0128: Expected F4, but got I
		//IL_0123: Expected native int or pointer, but got VT
		//IL_0147: Expected F4, but got Obj
		//IL_0142: Expected native int or pointer, but got VT
		//IL_015c: Expected F4, but got I
		//IL_0157: Expected native int or pointer, but got VT
		//IL_0165: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(MovingTrain);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(MovingTrain);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v25 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((HashSet<T>)(object)_activeTrains).Add((T)this);
		((CharacterCollisionTrigger)(object)_updater).OnCharacterEnter += (EventHandler)(object)this;
		_active = false;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v8 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v21 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 12;
		Vector3 down = Vector3.down;
		Vector3 vector = (Vector3)(obj4 + 24);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v13+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = Quaternion.AngleAxis(-100f, vector);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
	}

	static MovingTrain()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Expected Obj, but got Unknown
		//IL_0e30: Expected Obj, but got I4
		//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e44: Expected Obj, but got Unknown
		//IL_0e4d: Expected Obj, but got I4
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e67: Expected Obj, but got Unknown
		//IL_0e83: Expected I, but got Obj
		//IL_0e99: Expected Obj, but got I
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f77: Expected Obj, but got Unknown
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_0110: Expected I, but got Obj
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_029c: Expected I, but got Obj
		//IL_02b2: Expected Obj, but got I
		//IL_0d6f: Expected Obj, but got I
		//IL_02dd: Expected I, but got Obj
		//IL_0da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected Obj, but got Unknown
		//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Expected Obj, but got Unknown
		//IL_0434: Expected I, but got Obj
		//IL_044a: Expected Obj, but got I
		//IL_0f05: Expected Obj, but got I
		//IL_0f0e: Invalid comparison between Obj and F4
		//IL_0475: Expected I, but got Obj
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Expected Obj, but got Unknown
		//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Expected Obj, but got Unknown
		//IL_0d08: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 80;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 56;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 48;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(MovingTrain);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(MovingTrain);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v257 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 12;
		object obj8 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10CBB");
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29+8]");
		_ = 0;
		object obj9 = default;
		object obj11 = default;
		object obj14 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v247 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				continue;
			}
			nint num5 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v147 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num6 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v223 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v162 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S0_v213 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num9 = (nint)typeof(MovingTrain);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S2_v33 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num10 = (nint)typeof(MovingTrain);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S2_v38 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27+8]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			object obj16 = num11 - 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)autoPilotActivationDistance))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				_ = 1;
			}
		}
		object obj17 = 63;
		object obj18 = obj17 - 11;
		object obj25;
		object obj26 = default;
		if ((nint)obj17 != 11)
		{
			if ((nint)obj18 != 1)
			{
				if ((nint)obj18 == 2 || (nint)obj18 == 3)
				{
					goto IL_0fb8;
				}
				if ((nint)obj18 != 4)
				{
					if ((nint)obj18 == 5 || (nint)obj18 == 6)
					{
						goto IL_0fb8;
					}
					if ((nint)obj18 != 7)
					{
						if ((nint)obj18 == 8 || (nint)obj18 == 9 || (nint)obj18 == 10)
						{
							goto IL_0fb8;
						}
						if ((nint)obj18 != 11)
						{
							if ((nint)obj18 == 12 || (nint)obj18 == 13 || (nint)obj18 == 14 || (nint)obj18 == 15 || (nint)obj18 == 16)
							{
								goto IL_0fb8;
							}
							if ((nint)obj18 != 17)
							{
								if ((nint)obj18 != 18)
								{
									if ((nint)obj18 != 19)
									{
										if ((nint)obj18 == 20 || (nint)obj18 == 21)
										{
											goto IL_0fb8;
										}
										if ((nint)obj18 != 22)
										{
											if ((nint)obj18 == 23 || (nint)obj18 == 24 || (nint)obj18 == 25)
											{
												goto IL_0fb8;
											}
											if ((nint)obj18 != 26)
											{
												if ((nint)obj18 == 27 || (nint)obj18 == 28 || (nint)obj18 == 29 || (nint)obj18 == 30 || (nint)obj18 == 31 || (nint)obj18 == 32 || (nint)obj18 == 33 || (nint)obj18 == 34)
												{
													goto IL_0fb8;
												}
												if ((nint)obj18 != 35)
												{
													if ((nint)obj18 != 36)
													{
														if ((nint)obj18 != 37)
														{
															if ((nint)obj18 != 38 && (nint)obj18 != 39)
															{
																if ((nint)obj18 == 40 || (nint)obj18 == 41 || (nint)obj18 == 42 || (nint)obj18 == 43 || (nint)obj18 == 44 || (nint)obj18 == 45 || (nint)obj18 == 46 || (nint)obj18 == 47)
																{
																	goto IL_0fb8;
																}
																if ((nint)obj18 != 48)
																{
																	if ((nint)obj18 != 49)
																	{
																		if ((nint)obj18 != 50 && (nint)obj18 != 51 && (nint)obj18 == 52)
																		{
																			object obj19 = obj5 + 4;
																			object obj20 = obj19 + 1;
																			obj19 = obj20;
																			object obj21 = obj20 << 2;
																			object obj22 = obj5 + obj21;
																			obj22 = 182;
																		}
																		goto IL_0fb8;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj24 = default;
																	object obj23 = obj24;
																	obj25 = obj26;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj27 = default;
																	object obj23 = obj27;
																	obj25 = obj26;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj28 = default;
																object obj23 = obj28;
																obj25 = obj26;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj29 = default;
															object obj23 = obj29;
															obj25 = obj26;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj30 = default;
														object obj23 = obj30;
														obj25 = obj26;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj31 = default;
													object obj23 = obj31;
													obj25 = obj26;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj32 = default;
												object obj23 = obj32;
												obj25 = obj26;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj33 = default;
											object obj23 = obj33;
											obj25 = obj26;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj34 = default;
										object obj23 = obj34;
										obj25 = obj26;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj35 = default;
									object obj23 = obj35;
									obj25 = obj26;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj36 = default;
								object obj23 = obj36;
								obj25 = obj26;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj37 = default;
							object obj23 = obj37;
							obj25 = obj26;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj38 = default;
						object obj23 = obj38;
						obj25 = obj26;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj39 = default;
					object obj23 = obj39;
					obj25 = obj26;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj40 = default;
				object obj23 = obj40;
				obj25 = obj26;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj41 = default;
			object obj23 = obj41;
			obj25 = obj26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj42 = default;
		if (obj25 == obj42)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0fb8;
		IL_0fb8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
			object obj43 = (nint)0 << 2;
			object obj44 = obj5 + obj43;
			if ((nint)obj44 == 182)
			{
				object obj45 = obj5 + 4;
				if ((nint)obj45 > -1)
				{
					object obj46 = obj45 + -1;
					obj45 = obj46;
				}
				return;
			}
		}
		object obj47 = default;
		if (obj47 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
