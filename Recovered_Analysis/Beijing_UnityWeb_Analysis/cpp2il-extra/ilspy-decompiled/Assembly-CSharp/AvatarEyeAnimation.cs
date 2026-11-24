using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class AvatarEyeAnimation : MonoBehaviour
{
	private float blinkTime;

	private float blinkWaitTimeMax;

	private float blinkWaitTimeMin;

	private float shiftEyeHorizontalLimit;

	private float shiftEyeVerticalLimit;

	private float shiftEyeHorizontalMultiplier;

	private float shiftEyeVerticalMultiplier;

	private Transform headboneTransform;

	private GameObject testTargetPoint;

	private Vector2 maxLookOffset;

	private GameObject targetPosition;

	private Vector3 popupMenuFocusPointOffset;

	private Vector3 characterMenuFocusPointOffset;

	private Vector3 boardMenuFocusPointOffset;

	private Vector3 duelsScreenFocusPointOffset;

	private float timeToMoveFocus;

	private float timeBetweenFocusShiftMax;

	private float timeBetweenFocusShiftMin;

	private bool animate;

	private SkinnedMeshRenderer _headMesh;

	private Transform _eyeFocusOrigin;

	private Transform _eyeFocusTarget;

	private Transform _eyeSwitch;

	private Transform _blendshapeController;

	private GameObject _duelsScreensPrefab;

	private float blinkWaitEndTime;

	private float blinkEndTime;

	private float currentHorizontalLimit;

	private float currentVerticalLimit;

	private Vector3 toprunFocusPointOffset;

	private Vector3 originalPosition;

	private Vector3 originalRotation;

	private Vector3 newTargetPosition;

	private Vector3 lookToCamera;

	private Vector2 offsetVector;

	private float endTimeToShift;

	private bool useFocuPoint;

	private bool shiftToFocusBlink;

	private int _eyeMaterialID;

	private bool IsEyeControlledByAnimation
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

	public void Initialize(GameObject eyeFocus, Transform headJoint, Transform eyeSwitch, Transform eyeFocusOrigin, Transform eyeFocusTarget, Transform blendshapeController, SkinnedMeshRenderer headMesh, int eyeMaterialID)
	{
		//IL_00dc: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		_ = 0;
		Transform transform;
		if ((object)eyeFocusOrigin == null)
		{
			transform = (Transform)0;
			return;
		}
		AvatarEyeAnimation avatarEyeAnimation = null;
		avatarEyeAnimation = this;
		IntPtr intPtr = default;
		AvatarEyeAnimation avatarEyeAnimation2;
		do
		{
			object obj = (object)avatarEyeAnimation << 3;
			object obj2 = (object)eyeSwitch + obj;
			object obj3 = obj2 << 5;
			object obj4 = (object)eyeFocus + obj3;
			object obj5 = (object)avatarEyeAnimation << 3;
			object obj6 = (object)eyeSwitch + obj5;
			object obj7 = obj2 << 5;
			object obj8 = (object)eyeFocus + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v3+18]");
			object obj9 = 0;
			object obj10 = obj9 << 2;
			object obj11 = (nint)intPtr + obj10;
			object obj12 = obj11 & 0x3FFF;
			object obj13 = obj12 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S3_v8 (should have been resolved before IL gen)");
			avatarEyeAnimation2 = (AvatarEyeAnimation)(avatarEyeAnimation + 1);
		}
		while ((object)avatarEyeAnimation2 != eyeFocusOrigin);
		transform = (Transform)0;
	}

	public unsafe void DuelsScreenAnimateEyes(GameObject root, Vector3 offset)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0087: Expected Ref, but got VT
		//IL_0093: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_004e: Expected I4, but got Obj
		//IL_004e: Expected Obj, but got F4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		_ = 1;
		shiftEyeVerticalLimit = 0f;
		_ = 0;
		_ = 0;
		object obj = root + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = root + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj5);
			((AnimationState)blinkWaitTimeMin).AddMixingTransform((Transform)obj5, (byte)(int)obj6 != 0);
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
		object obj8 = this + 56;
		bool flag = ((CharacterNameEventManager)(object)this).TryGetListNumberAndIndexInExtrasList(out *(int*)root, out *(int*)offset);
		obj8 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
	}

	public void AnimateEyes(UIModelController.ModelScreen modelScreen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected Obj, but got Unknown
		//IL_0974: Expected Obj, but got I4
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected Obj, but got Unknown
		//IL_09a4: Expected I, but got Obj
		//IL_09ba: Expected Obj, but got I
		//IL_0d36: Expected Obj, but got I4
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected Obj, but got Unknown
		//IL_090e: Expected Obj, but got I4
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected Obj, but got Unknown
		//IL_0922: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v231 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)modelScreen).FindKernel(null) != 0)
		{
			object obj6 = this + 76;
			obj6 = modelScreen;
			object obj7 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+4C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v35+C]");
			obj7 = 0;
			throw new IndexOutOfRangeException();
		}
		object obj9 = this + 76;
		obj9 = 0;
		object obj10 = this + 32;
		obj10 = 0;
		throw new IndexOutOfRangeException();
	}

	public void StopAnimatingEyes()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_003d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AnimationClip> list = default;
		list._002Ector();
		object obj = this + 36;
		obj = list;
		_ = 2;
		characterMenuFocusPointOffset = (Vector3)3;
		CancelInvoke();
	}

	private void ForceBlink()
	{
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_00aa: Expected VT, but got I4
		animate = false;
		int blendShapeCount = ((Mesh)(object)_headMesh).blendShapeCount;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)blendShapeCount).FindKernel(null) != 0)
		{
			int blendShapeCount2 = ((Mesh)(object)_headMesh).blendShapeCount;
			bool canAccess = ((Mesh)blendShapeCount2).canAccess;
			if ((canAccess ? 1 : 0) > (false ? 1 : 0))
			{
				Color color = (Color)0 * 0f;
			}
		}
	}

	private void UpdateEyeBlinking()
	{
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		blinkWaitEndTime = timeSinceLevelLoad;
		float num = blinkWaitEndTime + blinkTime;
		blinkEndTime = num;
	}

	private unsafe Vector3 GetFocusPoint()
	{
		//IL_117e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1183: Expected Obj, but got Unknown
		//IL_118c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1191: Expected Obj, but got Unknown
		//IL_119a: Unknown result type (might be due to invalid IL or missing references)
		//IL_119f: Expected Obj, but got Unknown
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected Obj, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bb: Expected Obj, but got Unknown
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Expected Obj, but got Unknown
		//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d7: Expected Obj, but got Unknown
		//IL_11e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e5: Expected Obj, but got Unknown
		//IL_11ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Expected Obj, but got Unknown
		//IL_11fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1201: Expected Obj, but got Unknown
		//IL_076f: Expected I, but got Obj
		//IL_0785: Expected Obj, but got I
		//IL_1270: Expected Obj, but got I
		//IL_07b0: Expected I, but got Obj
		//IL_0800: Expected Obj, but got I
		//IL_0817: Expected VT, but got I4
		//IL_0817: Expected Obj, but got I4
		//IL_082d: Expected Obj, but got I
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected Obj, but got Unknown
		//IL_0894: Expected Obj, but got I
		//IL_08a1: Expected Obj, but got VT
		//IL_08b7: Expected VT, but got Obj
		//IL_08de: Expected I4, but got Obj
		//IL_08de: Expected Obj, but got I4
		//IL_0413: Expected I, but got Obj
		//IL_0429: Expected Obj, but got I
		//IL_08f4: Expected Obj, but got I
		//IL_0905: Expected VT, but got I4
		//IL_1238: Expected Obj, but got I
		//IL_091b: Expected Obj, but got I
		//IL_092c: Expected VT, but got I4
		//IL_0454: Expected I, but got Obj
		//IL_0acb: Expected I, but got Obj
		//IL_0ae1: Expected Obj, but got I
		//IL_0942: Expected Obj, but got I
		//IL_0953: Expected VT, but got I4
		//IL_04a4: Expected Obj, but got I
		//IL_04bb: Expected VT, but got I4
		//IL_04bb: Expected Obj, but got I4
		//IL_12a8: Expected Obj, but got I
		//IL_0961: Expected Obj, but got I4
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		//IL_09d4: Expected Obj, but got I
		//IL_09e5: Expected VT, but got I4
		//IL_04d1: Expected Obj, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_0b0c: Expected I, but got Obj
		//IL_09fb: Expected Obj, but got I
		//IL_0a0c: Expected VT, but got I4
		//IL_0538: Expected Obj, but got I
		//IL_0545: Expected Obj, but got VT
		//IL_0b5c: Expected Obj, but got I
		//IL_0b73: Expected VT, but got I4
		//IL_0b73: Expected Obj, but got I4
		//IL_0a22: Expected Obj, but got I
		//IL_0a33: Expected VT, but got I4
		//IL_055b: Expected VT, but got Obj
		//IL_0582: Expected I4, but got Obj
		//IL_0582: Expected Obj, but got I4
		//IL_0b89: Expected Obj, but got I
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected Obj, but got Unknown
		//IL_0a41: Expected Obj, but got I4
		//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Expected VT, but got Unknown
		//IL_0a9e: Expected F4, but got Obj
		//IL_0a99: Expected native int or pointer, but got VT
		//IL_0ab0: Expected F4, but got I
		//IL_0aab: Expected native int or pointer, but got VT
		//IL_0598: Expected Obj, but got I
		//IL_05a9: Expected VT, but got I4
		//IL_0bf0: Expected Obj, but got I
		//IL_0bfd: Expected Obj, but got VT
		//IL_05bf: Expected Obj, but got I
		//IL_05d0: Expected VT, but got I4
		//IL_0c13: Expected VT, but got Obj
		//IL_0c3a: Expected I4, but got Obj
		//IL_0c3a: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I
		//IL_05f7: Expected VT, but got I4
		//IL_0c50: Expected Obj, but got I
		//IL_0c61: Expected VT, but got I4
		//IL_0605: Expected Obj, but got I4
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Obj, but got Unknown
		//IL_0678: Expected Obj, but got I
		//IL_0689: Expected VT, but got I4
		//IL_0c77: Expected Obj, but got I
		//IL_0c88: Expected VT, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I
		//IL_06b0: Expected VT, but got I4
		//IL_0c9e: Expected Obj, but got I
		//IL_0caf: Expected VT, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I
		//IL_06c6: Expected Obj, but got I
		//IL_06d7: Expected VT, but got I4
		//IL_0cbd: Expected Obj, but got I4
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected Obj, but got Unknown
		//IL_0d30: Expected Obj, but got I
		//IL_0d41: Expected VT, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I
		//IL_0e27: Expected I, but got Obj
		//IL_0e3d: Expected Obj, but got I
		//IL_06e5: Expected Obj, but got I4
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected VT, but got Unknown
		//IL_0742: Expected F4, but got Obj
		//IL_073d: Expected native int or pointer, but got VT
		//IL_0754: Expected F4, but got I
		//IL_074f: Expected native int or pointer, but got VT
		//IL_0d57: Expected Obj, but got I
		//IL_0d68: Expected VT, but got I4
		//IL_01ee: Expected Obj, but got VT
		//IL_01ff: Expected VT, but got Obj
		//IL_12e0: Expected Obj, but got I
		//IL_0d7e: Expected Obj, but got I
		//IL_0d8f: Expected VT, but got I4
		//IL_022b: Expected I4, but got Obj
		//IL_022b: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I
		//IL_0e68: Expected I, but got Obj
		//IL_0d9d: Expected Obj, but got I4
		//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ded: Expected VT, but got Unknown
		//IL_0dfa: Expected F4, but got Obj
		//IL_0df5: Expected native int or pointer, but got VT
		//IL_0e0c: Expected F4, but got I
		//IL_0e07: Expected native int or pointer, but got VT
		//IL_0252: Expected VT, but got I4
		//IL_0263: Expected Obj, but got I
		//IL_0eb8: Expected Obj, but got I
		//IL_0ecf: Expected VT, but got I4
		//IL_0ecf: Expected Obj, but got I4
		//IL_0279: Expected VT, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_0ee5: Expected Obj, but got I
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected Obj, but got Unknown
		//IL_02a0: Expected VT, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I
		//IL_0f4c: Expected Obj, but got I
		//IL_0f59: Expected Obj, but got VT
		//IL_0332: Expected VT, but got I4
		//IL_0343: Expected Obj, but got I
		//IL_0f6f: Expected VT, but got Obj
		//IL_0f96: Expected I4, but got Obj
		//IL_0f96: Expected Obj, but got I4
		//IL_0359: Expected VT, but got I4
		//IL_036a: Expected Obj, but got I
		//IL_0fac: Expected Obj, but got I
		//IL_0fbd: Expected VT, but got I4
		//IL_0380: Expected VT, but got I4
		//IL_0389: Expected Obj, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected VT, but got Unknown
		//IL_03e6: Expected F4, but got Obj
		//IL_03e1: Expected native int or pointer, but got VT
		//IL_03f8: Expected F4, but got I
		//IL_03f3: Expected native int or pointer, but got VT
		//IL_0fd3: Expected Obj, but got I
		//IL_0fe4: Expected VT, but got I4
		//IL_0ffa: Expected Obj, but got I
		//IL_100b: Expected VT, but got I4
		//IL_1019: Expected Obj, but got I4
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected Obj, but got Unknown
		//IL_108c: Expected Obj, but got I
		//IL_109d: Expected VT, but got I4
		//IL_10b3: Expected Obj, but got I
		//IL_10c4: Expected VT, but got I4
		//IL_10da: Expected Obj, but got I
		//IL_10eb: Expected VT, but got I4
		//IL_10f9: Expected Obj, but got I4
		//IL_1144: Unknown result type (might be due to invalid IL or missing references)
		//IL_1149: Expected VT, but got Unknown
		//IL_1156: Expected F4, but got Obj
		//IL_1151: Expected native int or pointer, but got VT
		//IL_1168: Expected F4, but got I
		//IL_1163: Expected native int or pointer, but got VT
		object obj = default;
		Transform transform = (Transform)(obj + 136);
		object obj2 = obj + 124;
		Transform transform2 = (Transform)(obj + 112);
		Transform transform3 = (Transform)(obj + 100);
		Transform transform4 = (Transform)(obj + 88);
		Transform transform5 = (Transform)(obj + 76);
		object obj3 = obj - -64;
		Transform transform6 = (Transform)(obj + 48);
		Transform transform7 = (Transform)(obj + 32);
		Transform transform8 = (Transform)(obj + 16);
		_ = 1;
		if ((object)this == null)
		{
			goto IL_0761;
		}
		Vector3 vector = default;
		if ((nint)this != 1 && (nint)this != 2)
		{
			if ((nint)this != 3)
			{
				if ((nint)this != 4)
				{
					if ((nint)this == 5)
					{
						goto IL_0761;
					}
					if ((nint)this != 6)
					{
						if ((nint)this != 7)
						{
							if ((nint)this == 8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer = ((GameObject)0).layer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+90]");
								int layer2 = ((GameObject)0).layer;
								((Transform)layer).parentInternal = (Transform)layer2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer3 = ((GameObject)0).layer;
								object obj4 = vector + 96;
								obj2 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S2_v104+8]");
								_ = 0;
								transform = (Transform)obj2;
								Transform transform9 = transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
								((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
								Vector3 eulerAngles = transform.eulerAngles;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer4 = ((GameObject)0).layer;
								GameObject gameObject = ((Component)vector).gameObject;
								transform2.position = (Vector3)gameObject;
								transform = transform2;
								((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
								((Transform)layer4).SetSiblingIndex((int)transform);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer5 = ((GameObject)0).layer;
								transform3.localPosition = (Vector3)layer5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer6 = ((GameObject)0).layer;
								transform4.localPosition = (Vector3)layer6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer7 = ((GameObject)0).layer;
								transform5.localPosition = (Vector3)layer7;
								obj3 = 0;
								_ = 0;
								obj3 = transform3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UnityEngine.Transform)+4]");
								_ = 0;
								_ = ((UnityEngine.Object)transform5).m_CachedPtr;
								transform = (Transform)obj3;
								Transform transform10 = transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
								((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
								object obj5 = vector + 176;
								obj5 = transform;
								_ = ((UnityEngine.Object)transform).m_CachedPtr;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer8 = ((GameObject)0).layer;
								transform6.localRotation = (Quaternion)layer8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer9 = ((GameObject)0).layer;
								transform7.localRotation = (Quaternion)layer9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								int layer10 = ((GameObject)0).layer;
								transform8.localRotation = (Quaternion)layer10;
								obj = 0;
								_ = 0;
								obj = transform6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (UnityEngine.Transform)+4]");
								_ = 0;
								_ = ((UnityEngine.Object)transform8).m_CachedPtr;
								transform = (Transform)obj;
								Transform transform11 = transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
								Vector3 vector2 = vector + 188;
								((Vector3*)(nint)vector2)->x = (float)transform;
								((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
								return vector2;
							}
							if ((nint)this != 9)
							{
								if ((nint)this != 10 && (nint)this == 11)
								{
									goto IL_0abd;
								}
							}
							else
							{
								nint num = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S1_v287 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num2 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v351 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
								if (((ComputeShader)0).FindKernel(null) != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer11 = ((GameObject)0).layer;
									HierarchyUtility.ReparentByHierarchyPathType((Transform)layer11, HierarchyPathType.Root, (Vector3)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer12 = ((GameObject)0).layer;
									object obj7 = vector + 164;
									obj2 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S2_v136+8]");
									_ = 0;
									transform = (Transform)obj2;
									Transform transform12 = transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
									((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
									Vector3 localPosition = transform.localPosition;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer13 = ((GameObject)0).layer;
									GameObject gameObject2 = ((Component)vector).gameObject;
									transform2.position = (Vector3)gameObject2;
									transform = transform2;
									((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
									((Transform)layer13).SetSiblingIndex((int)transform);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer14 = ((GameObject)0).layer;
									transform3.localPosition = (Vector3)layer14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer15 = ((GameObject)0).layer;
									transform4.localPosition = (Vector3)layer15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer16 = ((GameObject)0).layer;
									transform5.localPosition = (Vector3)layer16;
									obj3 = 0;
									_ = 0;
									obj3 = transform3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UnityEngine.Transform)+4]");
									_ = 0;
									_ = ((UnityEngine.Object)transform5).m_CachedPtr;
									transform = (Transform)obj3;
									Transform transform13 = transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
									((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
									object obj8 = vector + 176;
									obj8 = transform;
									_ = ((UnityEngine.Object)transform).m_CachedPtr;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer17 = ((GameObject)0).layer;
									transform6.localRotation = (Quaternion)layer17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer18 = ((GameObject)0).layer;
									transform7.localRotation = (Quaternion)layer18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
									int layer19 = ((GameObject)0).layer;
									transform8.localRotation = (Quaternion)layer19;
									obj = 0;
									_ = 0;
									obj = transform6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (UnityEngine.Transform)+4]");
									_ = 0;
									_ = ((UnityEngine.Object)transform8).m_CachedPtr;
									transform = (Transform)obj;
									Transform transform14 = transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
									((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
									Vector3 vector3 = vector + 188;
									((Vector3*)(nint)vector3)->x = (float)transform;
									((Vector3*)(nint)vector3)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
									return vector3;
								}
							}
						}
						goto IL_1221;
					}
				}
				goto IL_0abd;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v151 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer20 = ((GameObject)0).layer;
				HierarchyUtility.ReparentByHierarchyPathType((Transform)layer20, HierarchyPathType.Root, (Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer21 = ((GameObject)0).layer;
				object obj10 = vector + 60;
				obj2 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S2_v40+8]");
				_ = 0;
				transform = (Transform)obj2;
				Transform transform15 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
				Vector3 localPosition2 = transform.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer22 = ((GameObject)0).layer;
				GameObject gameObject3 = ((Component)vector).gameObject;
				transform2.position = (Vector3)gameObject3;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				((Transform)layer22).SetSiblingIndex((int)transform);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer23 = ((GameObject)0).layer;
				transform3.localPosition = (Vector3)layer23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer24 = ((GameObject)0).layer;
				transform4.localPosition = (Vector3)layer24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer25 = ((GameObject)0).layer;
				transform5.localPosition = (Vector3)layer25;
				obj3 = 0;
				_ = 0;
				obj3 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UnityEngine.Transform)+4]");
				_ = 0;
				_ = ((UnityEngine.Object)transform5).m_CachedPtr;
				transform = (Transform)obj3;
				Transform transform16 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
				((UnityEngine.Object)transform16).m_CachedPtr = (IntPtr)0;
				object obj11 = vector + 176;
				obj11 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer26 = ((GameObject)0).layer;
				transform6.localRotation = (Quaternion)layer26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer27 = ((GameObject)0).layer;
				transform7.localRotation = (Quaternion)layer27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
				int layer28 = ((GameObject)0).layer;
				transform8.localRotation = (Quaternion)layer28;
				obj = 0;
				_ = 0;
				obj = transform6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (UnityEngine.Transform)+4]");
				_ = 0;
				_ = ((UnityEngine.Object)transform8).m_CachedPtr;
				transform = (Transform)obj;
				Transform transform17 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform17).m_CachedPtr = (IntPtr)0;
				Vector3 vector4 = vector + 188;
				((Vector3*)(nint)vector4)->x = (float)transform;
				((Vector3*)(nint)vector4)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				return vector4;
			}
		}
		goto IL_1221;
		IL_1221:
		return vector;
		IL_0761:
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v81 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer29 = ((GameObject)0).layer;
			HierarchyUtility.ReparentByHierarchyPathType((Transform)layer29, HierarchyPathType.Root, (Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer30 = ((GameObject)0).layer;
			object obj13 = vector + 72;
			obj2 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S2_v7+8]");
			_ = 0;
			transform = (Transform)obj2;
			Transform transform18 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((UnityEngine.Object)transform18).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition3 = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer31 = ((GameObject)0).layer;
			GameObject gameObject4 = ((Component)vector).gameObject;
			transform2.position = (Vector3)gameObject4;
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			((Transform)layer31).SetSiblingIndex((int)transform);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer32 = ((GameObject)0).layer;
			transform3.localPosition = (Vector3)layer32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer33 = ((GameObject)0).layer;
			transform4.localPosition = (Vector3)layer33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer34 = ((GameObject)0).layer;
			transform5.localPosition = (Vector3)layer34;
			obj3 = 0;
			_ = 0;
			obj3 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform5).m_CachedPtr;
			transform = (Transform)obj3;
			Transform transform19 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((UnityEngine.Object)transform19).m_CachedPtr = (IntPtr)0;
			object obj14 = vector + 176;
			obj14 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer35 = ((GameObject)0).layer;
			transform6.localRotation = (Quaternion)layer35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer36 = ((GameObject)0).layer;
			transform7.localRotation = (Quaternion)layer36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer37 = ((GameObject)0).layer;
			transform8.localRotation = (Quaternion)layer37;
			obj = 0;
			_ = 0;
			obj = transform6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform8).m_CachedPtr;
			transform = (Transform)obj;
			Transform transform20 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform20).m_CachedPtr = (IntPtr)0;
			Vector3 vector5 = vector + 188;
			((Vector3*)(nint)vector5)->x = (float)transform;
			((Vector3*)(nint)vector5)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			return vector5;
		}
		goto IL_1221;
		IL_0abd:
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v156 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v221 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer38 = ((GameObject)0).layer;
			HierarchyUtility.ReparentByHierarchyPathType((Transform)layer38, HierarchyPathType.Root, (Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer39 = ((GameObject)0).layer;
			object obj16 = vector + 84;
			obj2 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S2_v73+8]");
			_ = 0;
			transform = (Transform)obj2;
			Transform transform21 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((UnityEngine.Object)transform21).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition4 = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer40 = ((GameObject)0).layer;
			GameObject gameObject5 = ((Component)vector).gameObject;
			transform2.position = (Vector3)gameObject5;
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			((Transform)layer40).SetSiblingIndex((int)transform);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer41 = ((GameObject)0).layer;
			transform3.localPosition = (Vector3)layer41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer42 = ((GameObject)0).layer;
			transform4.localPosition = (Vector3)layer42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer43 = ((GameObject)0).layer;
			transform5.localPosition = (Vector3)layer43;
			obj3 = 0;
			_ = 0;
			obj3 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform5).m_CachedPtr;
			transform = (Transform)obj3;
			Transform transform22 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((UnityEngine.Object)transform22).m_CachedPtr = (IntPtr)0;
			object obj17 = vector + 176;
			obj17 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer44 = ((GameObject)0).layer;
			transform6.localRotation = (Quaternion)layer44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer45 = ((GameObject)0).layer;
			transform7.localRotation = (Quaternion)layer45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ L0_v6 (UnityEngine.Vector3)+38]");
			int layer46 = ((GameObject)0).layer;
			transform8.localRotation = (Quaternion)layer46;
			obj = 0;
			_ = 0;
			obj = transform6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform8).m_CachedPtr;
			transform = (Transform)obj;
			Transform transform23 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform23).m_CachedPtr = (IntPtr)0;
			Vector3 vector6 = vector + 188;
			((Vector3*)(nint)vector6)->x = (float)transform;
			((Vector3*)(nint)vector6)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			return vector6;
		}
		goto IL_1221;
	}

	private unsafe void ShiftFocusPoint(Vector3 focusPoint)
	{
		//IL_019d: Expected Obj, but got I
		//IL_01af: Expected Obj, but got Ref
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_01e4: Unsupported input type for neg.
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected F4, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0204: Expected F4, but got Obj
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0227: Expected F4, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_024a: Expected F4, but got I
		//IL_0013: Expected Obj, but got Ref
		//IL_001c: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got F4
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0261: Expected VT, but got Ref
		//IL_026e: Expected F4, but got Obj
		//IL_0269: Expected native int or pointer, but got VT
		//IL_0283: Expected F4, but got I
		//IL_027e: Expected native int or pointer, but got VT
		//IL_0291: Expected VT, but got Ref
		//IL_029e: Expected F4, but got Obj
		//IL_0299: Expected native int or pointer, but got VT
		//IL_02b3: Expected F4, but got I
		//IL_02ae: Expected native int or pointer, but got VT
		//IL_02c1: Expected Obj, but got Ref
		//IL_02df: Expected F4, but got Obj
		//IL_02da: Expected native int or pointer, but got VT
		//IL_02f4: Expected F4, but got I
		//IL_02ef: Expected native int or pointer, but got VT
		//IL_02fd: Expected Obj, but got VT
		//IL_0312: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00de: Expected F4, but got Obj
		//IL_00d9: Expected native int or pointer, but got VT
		//IL_00f3: Expected F4, but got I
		//IL_00ee: Expected native int or pointer, but got VT
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_0328: Expected native int or pointer, but got VT
		//IL_033a: Expected native int or pointer, but got VT
		//IL_034c: Expected Ref, but got VT
		//IL_035e: Expected F4, but got VT
		//IL_0359: Expected native int or pointer, but got VT
		//IL_0373: Expected F4, but got I
		//IL_036e: Expected native int or pointer, but got VT
		//IL_037c: Expected Obj, but got VT
		//IL_0391: Expected Obj, but got I
		//IL_018b: Expected VT, but got I4
		//IL_0142: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [focusPoint @ L1 (UnityEngine.Vector3)+38]");
		int layer = ((GameObject)0).layer;
		ref Quaternion reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 40));
		object obj2 = focusPoint + 176;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S2_v3+8]");
		_ = 0;
		object obj3 = focusPoint + 48;
		float overStretching = 0 - obj3;
		object obj4 = focusPoint + 48;
		float num = ScrollRect.RubberDelta(overStretching, (float)obj4);
		object obj5 = focusPoint + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v13+4]");
		float overStretching2 = -0;
		object obj6 = focusPoint + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v13+4]");
		float num2 = ScrollRect.RubberDelta(overStretching2, 0f);
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 28));
		obj7 = 0;
		_ = 0;
		obj7 = num;
		_ = 0f;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 52));
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, -64));
		((Vector3*)(nint)vector3)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v18+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		Vector3 vector4 = vector - vector3;
		((Vector3*)(nint)vector3)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v35+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector3).eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [focusPoint @ L1 (UnityEngine.Vector3)+38]");
		int layer2 = ((GameObject)0).layer;
		object obj10 = focusPoint + 188;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S2_v40+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		nint num5 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v43 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v56 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector3)->x = vector.x;
		((Vector3*)(nint)vector3)->z = vector.z;
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector3);
		((Vector3*)(nint)vector3)->x = (float)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 localScale = ((Transform)vector3).localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [focusPoint @ L1 (UnityEngine.Vector3)+38]");
		int layer3 = ((GameObject)0).layer;
		((Transform)(object)this).position = (Vector3)layer3;
	}

	private unsafe void ResetEyes()
	{
		//IL_0396: Expected I, but got Obj
		//IL_03ac: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I4
		//IL_00b0: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I4
		//IL_0166: Expected VT, but got Obj
		//IL_016f: Expected F4, but got Obj
		//IL_02e1: Expected Obj, but got I4
		//IL_0196: Expected VT, but got I4
		//IL_0321: Expected VT, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_02c0: Expected VT, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_eyeSwitch).FindKernel((string)null) == 0)
		{
			return;
		}
		int blendShapeCount = ((Mesh)(object)_headMesh).blendShapeCount;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)blendShapeCount).FindKernel(null) == 0)
		{
			return;
		}
		IEnumerator enumerator = ((TopRunIdleAnimation)this).PlayTRIdles();
		if (enumerator != null)
		{
			int blendShapeCount2 = ((Mesh)(object)_headMesh).blendShapeCount;
			bool canAccess = ((Mesh)blendShapeCount2).canAccess;
			if ((canAccess ? 1 : 0) > (false ? 1 : 0))
			{
				Transform transform = default;
				transform.localPosition = (Vector3)_blendshapeController;
				float num5 = PlanarRealtimeReflection.sgn((float)transform);
				float num6 = num5 * 100f;
				Color color = (Color)0 * num6;
			}
		}
		else
		{
			if (blinkWaitTimeMax < blinkWaitTimeMin)
			{
				return;
			}
			float timeSinceLevelLoad = Time.timeSinceLevelLoad;
			if (timeSinceLevelLoad < blinkWaitEndTime)
			{
				return;
			}
			float timeSinceLevelLoad2 = Time.timeSinceLevelLoad;
			if (timeSinceLevelLoad2 < blinkEndTime)
			{
				float num7 = ((Matrix4x4*)_headMesh)->get_Item(0);
				if (num7 < 1f)
				{
					int blendShapeCount3 = ((Mesh)(object)_headMesh).blendShapeCount;
					bool canAccess2 = ((Mesh)blendShapeCount3).canAccess;
					if ((canAccess2 ? 1 : 0) > (false ? 1 : 0))
					{
						Color color2 = (Color)0 * 100f;
					}
				}
				return;
			}
			int blendShapeCount4 = ((Mesh)(object)_headMesh).blendShapeCount;
			bool canAccess3 = ((Mesh)blendShapeCount4).canAccess;
			if ((canAccess3 ? 1 : 0) > (false ? 1 : 0))
			{
				Color color3 = (Color)0 * 0f;
			}
			float timeSinceLevelLoad3 = Time.timeSinceLevelLoad;
			float num8 = ScrollRect.RubberDelta(blinkWaitTimeMin, blinkWaitTimeMax);
			float num9 = timeSinceLevelLoad3 + num8;
			blinkWaitEndTime = num9;
			float num10 = blinkWaitEndTime + blinkTime;
			blinkEndTime = num10;
		}
	}

	private unsafe void UpdateGetNewFocusPoint()
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got F4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected VT, but got Unknown
		//IL_015d: Expected F4, but got Obj
		//IL_0158: Expected native int or pointer, but got VT
		//IL_016c: Expected VT, but got F4
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got VT
		//IL_00ef: Expected F4, but got Obj
		//IL_00ea: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		obj = 0f;
		_ = 0f;
		object obj3 = obj2 + 8;
		obj3 = obj;
		Vector2 vector = (Vector2)(obj2 + 24);
		((Vector2*)(nint)vector)->x = (float)obj3;
		offsetVector = (Vector2)vector.x;
		int blendShapeCount = ((Mesh)(object)_headMesh).blendShapeCount;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)blendShapeCount).FindKernel(null) != 0)
		{
			int blendShapeCount2 = ((Mesh)(object)_headMesh).blendShapeCount;
			int num3 = Mesh.DefaultDimensionForChannel((VertexAttribute)blendShapeCount2);
			if (num3 >= 2)
			{
				Material material = _headMesh.material;
				object obj5 = material + 16;
				int num4 = _eyeMaterialID << 2;
				object obj6 = obj5 + num4;
				obj2 = offsetVector;
				((Vector2*)(nint)vector)->x = (float)obj2;
				((Material)obj6).SetTextureScale("_MainTex", vector);
			}
		}
	}

	private void UpdateAnimatedEyes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004a: Expected VT, but got Obj
		AvatarEyeAnimation avatarEyeAnimation = default;
		TopRunIdleAnimation.AnimationFinishDelegate animationFinishDelegate = (TopRunIdleAnimation.AnimationFinishDelegate)(avatarEyeAnimation + 12);
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		if (timeSinceLevelLoad > endTimeToShift)
		{
			avatarEyeAnimation.ShiftFocusPoint((Vector3)this);
			animationFinishDelegate = (TopRunIdleAnimation.AnimationFinishDelegate)(object)avatarEyeAnimation;
			((Delegate)animationFinishDelegate).method_ptr = ((UnityEngine.Object)avatarEyeAnimation).m_CachedPtr;
			((TopRunIdleAnimation)this).AnimationFinished += animationFinishDelegate;
			float timeSinceLevelLoad2 = Time.timeSinceLevelLoad;
			float num = ScrollRect.RubberDelta(timeBetweenFocusShiftMin, timeBetweenFocusShiftMax);
			float num2 = timeSinceLevelLoad2 + num;
			endTimeToShift = num2;
		}
	}

	private void AnimateEyes()
	{
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_00b0: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_eyeSwitch).FindKernel((string)null) == 0)
		{
			return;
		}
		int blendShapeCount = ((Mesh)(object)_headMesh).blendShapeCount;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)blendShapeCount).FindKernel(null) != 0)
		{
			Update();
		}
	}

	private unsafe void Update()
	{
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_063a: Expected Obj, but got I4
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Expected VT, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got Unknown
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected Obj, but got Unknown
		//IL_0079: Expected VT, but got Obj
		//IL_009a: Expected VT, but got I4
		//IL_0051: Expected VT, but got Obj
		//IL_0060: Expected VT, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0666: Expected F4, but got Obj
		//IL_0661: Expected native int or pointer, but got VT
		//IL_0678: Expected F4, but got I
		//IL_0673: Expected native int or pointer, but got VT
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected VT, but got Unknown
		//IL_0693: Expected F4, but got Obj
		//IL_068e: Expected native int or pointer, but got VT
		//IL_06a5: Expected F4, but got I
		//IL_06a0: Expected native int or pointer, but got VT
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected Obj, but got Unknown
		//IL_06d1: Expected F4, but got Obj
		//IL_06cc: Expected native int or pointer, but got VT
		//IL_06e6: Expected F4, but got I
		//IL_06e1: Expected native int or pointer, but got VT
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Obj, but got Unknown
		//IL_06fe: Expected Obj, but got F4
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		//IL_0735: Expected F4, but got Obj
		//IL_0730: Expected native int or pointer, but got VT
		//IL_074a: Expected F4, but got I
		//IL_0745: Expected native int or pointer, but got VT
		//IL_0757: Expected native int or pointer, but got VT
		//IL_0769: Expected native int or pointer, but got VT
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0157: Expected F4, but got Obj
		//IL_0152: Expected native int or pointer, but got VT
		//IL_016c: Expected F4, but got I
		//IL_0167: Expected native int or pointer, but got VT
		//IL_0197: Expected I, but got Obj
		//IL_01ad: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_01d8: Expected I, but got Obj
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got F4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_02a1: Invalid comparison between Obj and F4
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected Obj, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0854: Expected I, but got Obj
		//IL_086a: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got F4
		//IL_09fa: Invalid comparison between Obj and F4
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0342: Invalid comparison between I and F4
		//IL_0435: Invalid comparison between Obj and F4
		//IL_03e1: Expected I, but got Obj
		//IL_0461: Expected F4, but got Obj
		//IL_08a0: Expected Obj, but got F4
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected Obj, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08c6: Expected F4, but got I
		//IL_08e1: Invalid comparison between I and F4
		//IL_0485: Invalid comparison between I and F4
		//IL_0933: Expected I, but got Obj
		//IL_0949: Expected Obj, but got I
		//IL_0970: Expected Obj, but got I4
		//IL_04c1: Expected I, but got Obj
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_058d: Expected Obj, but got VT
		//IL_059a: Expected F4, but got Obj
		//IL_0595: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 56;
		obj = 0;
		_ = 0;
		if (~(useFocuPoint ? 1u : 0u) == 0)
		{
			IEnumerator enumerator = ((TopRunIdleAnimation)this).PlayTRIdles();
			if (enumerator == null)
			{
				UpdateAnimatedEyes();
			}
		}
		Vector3 vector = (Vector3)(obj2 + 68);
		Transform transform = (Transform)(obj2 + 44);
		Transform transform2 = (Transform)(obj2 + 32);
		IEnumerator enumerator2 = ((TopRunIdleAnimation)this).PlayTRIdles();
		if (enumerator2 != null)
		{
			transform.position = (Vector3)_eyeFocusOrigin;
			transform2.position = (Vector3)_eyeFocusTarget;
		}
		else
		{
			transform.position = (Vector3)headboneTransform;
			int layer = targetPosition.layer;
			transform2.position = (Vector3)layer;
		}
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v129 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj2 + 80);
		((Vector3*)(nint)vector2)->x = (float)transform2;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		object obj4 = obj2 + 20;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v34+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj5 = this + 212;
		obj5 = vector2.x;
		_ = vector2.z;
		object obj6 = this + 212;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11461");
		object obj7 = this + 212;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v36+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector2)->x = vector.x;
		((Vector3*)(nint)vector2)->z = vector.z;
		Vector3 vector5 = headboneTransform.TransformPoint(vector2);
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj8 = this + 224;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Vector3 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S3_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S3_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122F0");
		object obj10 = default;
		obj8 = obj10;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj11 = obj2 + 8;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj12 = this + 224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122F0");
		IEnumerator enumerator3 = ((TopRunIdleAnimation)this).PlayTRIdles();
		if (enumerator3 == null)
		{
			object obj13 = this + 224;
			object obj14 = 0f - currentHorizontalLimit;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
			{
				useFocuPoint = false;
			}
			else
			{
				object obj15 = this + 224;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)currentHorizontalLimit))
				{
					useFocuPoint = false;
				}
				else
				{
					object obj16 = this + 224;
					object obj17 = 0f - currentVerticalLimit;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v117+4]");
					if (0 < (nint)obj17)
					{
						useFocuPoint = false;
					}
					else
					{
						object obj18 = this + 224;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S0_v121+4]");
						if (0f > currentVerticalLimit)
						{
							useFocuPoint = false;
						}
						else
						{
							useFocuPoint = true;
						}
					}
				}
			}
		}
		bool flag = shiftToFocusBlink;
		if (~(useFocuPoint ? 1u : 0u) == 0)
		{
			if (!flag)
			{
				currentHorizontalLimit = shiftEyeHorizontalLimit;
				currentVerticalLimit = shiftEyeVerticalLimit;
				UpdateEyeBlinking();
				shiftToFocusBlink = true;
			}
			object obj19 = this + 224;
			object obj20 = this + 224;
			float num5 = currentHorizontalLimit;
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v90 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S1_v138 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num8 = 0f - currentHorizontalLimit;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num8))
			{
				num5 = num8;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5))
			{
				num5 = (float)obj20;
			}
			float num9 = num5 * shiftEyeHorizontalMultiplier;
			obj19 = num9;
			object obj22 = this + 224;
			object obj23 = this + 224;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S1_v100+4]");
			float num10 = 0f;
			float num11 = 0f - currentVerticalLimit;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S1_v100+4]");
			if (0f < num11)
			{
				num10 = num11;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S1_v100+4]");
				if (0f > currentVerticalLimit)
				{
					num10 = currentVerticalLimit;
				}
			}
			float num12 = num10 * shiftEyeVerticalMultiplier;
			int blendShapeCount = ((Mesh)(object)_headMesh).blendShapeCount;
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S1_v107 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S1_v124 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)blendShapeCount).FindKernel(null) != 0)
			{
				int blendShapeCount2 = ((Mesh)(object)_headMesh).blendShapeCount;
				int num15 = Mesh.DefaultDimensionForChannel((VertexAttribute)blendShapeCount2);
				if (num15 > 1)
				{
					Material material = _headMesh.material;
					object obj25 = material + 16;
					int num16 = _eyeMaterialID << 2;
					object obj26 = obj25 + num16;
					obj2 = offsetVector;
					((Vector3*)(nint)vector2)->x = (float)obj2;
					((Material)obj26).SetTextureScale("_MainTex", (Vector2)vector2);
				}
			}
		}
		else if (flag)
		{
			UpdateGetNewFocusPoint();
			float num17 = shiftEyeHorizontalLimit - 0.1f;
			currentHorizontalLimit = num17;
			float num18 = shiftEyeVerticalLimit - 0.1f;
			currentVerticalLimit = num18;
			UpdateEyeBlinking();
			shiftToFocusBlink = false;
		}
	}

	public AvatarEyeAnimation()
	{
		if (~(animate ? 1u : 0u) == 0)
		{
			ResetEyes();
			AnimateEyes();
		}
	}
}
