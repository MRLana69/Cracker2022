using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

public class AvatarEyeAnimation : MonoBehaviour
{
	private float blinkTime = 0.15f;

	private float blinkWaitTimeMax;

	private float blinkWaitTimeMin = 0.4f;

	private float shiftEyeHorizontalLimit;

	private float shiftEyeVerticalLimit = 0.5f;

	private float shiftEyeHorizontalMultiplier;

	private float shiftEyeVerticalMultiplier = 0.1f;

	private Transform headboneTransform;

	private GameObject testTargetPoint;

	private Vector2 maxLookOffset = (Vector2)4728779609842647040L;

	private GameObject targetPosition;

	private Vector3 popupMenuFocusPointOffset = (Vector3)(-4422534830820950016L);

	private Vector3 characterMenuFocusPointOffset;

	private Vector3 boardMenuFocusPointOffset = (Vector3)(-4416905333434220544L);

	private Vector3 duelsScreenFocusPointOffset;

	private float timeToMoveFocus = 0.04f;

	private float timeBetweenFocusShiftMax;

	private float timeBetweenFocusShiftMin = 0.1f;

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

	private Vector3 toprunFocusPointOffset = (Vector3)(-4422534830829338624L);

	private Vector3 originalPosition;

	private Vector3 originalRotation;

	private Vector3 newTargetPosition;

	private Vector3 lookToCamera;

	private Vector2 offsetVector;

	private float endTimeToShift;

	private bool useFocuPoint = true;

	private bool shiftToFocusBlink;

	private int _eyeMaterialID;

	private bool IsEyeControlledByAnimation
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002e: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 localPosition = _eyeSwitch.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			return 0f > 0.5f;
		}
	}

	public void CopyAllPropertiesFrom(AvatarEyeAnimation other)
	{
		blinkTime = other.blinkTime;
		blinkWaitTimeMax = other.blinkWaitTimeMax;
		blinkWaitTimeMin = other.blinkWaitTimeMin;
		shiftEyeHorizontalLimit = other.shiftEyeHorizontalLimit;
		shiftEyeVerticalLimit = other.shiftEyeVerticalLimit;
		shiftEyeHorizontalMultiplier = other.shiftEyeHorizontalMultiplier;
		shiftEyeVerticalMultiplier = other.shiftEyeVerticalMultiplier;
		maxLookOffset = other.maxLookOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ L1 (AvatarEyeAnimation)+44]");
		_ = 0;
		popupMenuFocusPointOffset = other.popupMenuFocusPointOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ L1 (AvatarEyeAnimation)+50]");
		_ = 0;
		characterMenuFocusPointOffset = other.characterMenuFocusPointOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ L1 (AvatarEyeAnimation)+5C]");
		_ = 0;
		boardMenuFocusPointOffset = other.boardMenuFocusPointOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ L1 (AvatarEyeAnimation)+68]");
		_ = 0;
		duelsScreenFocusPointOffset = other.duelsScreenFocusPointOffset;
		timeToMoveFocus = other.timeToMoveFocus;
		timeBetweenFocusShiftMin = other.timeBetweenFocusShiftMin;
		timeBetweenFocusShiftMax = other.timeBetweenFocusShiftMax;
		animate = other.animate;
	}

	public unsafe void Initialize(GameObject eyeFocus, Transform headJoint, Transform eyeSwitch, Transform eyeFocusOrigin, Transform eyeFocusTarget, Transform blendshapeController, SkinnedMeshRenderer headMesh, int eyeMaterialID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_015b: Expected I, but got Obj
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected VT, but got Unknown
		//IL_0095: Expected F4, but got I
		//IL_0090: Expected native int or pointer, but got VT
		//IL_00b7: Expected F4, but got I
		//IL_00b2: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_headMesh = headMesh;
		_eyeSwitch = eyeSwitch;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 16;
		_eyeSwitch.localPosition = localPosition;
		_eyeFocusOrigin = eyeFocusOrigin;
		_eyeFocusTarget = eyeFocusTarget;
		_blendshapeController = blendshapeController;
		_eyeMaterialID = eyeMaterialID;
		currentHorizontalLimit = shiftEyeHorizontalLimit;
		float num3 = (blinkWaitEndTime = UnityEngine.Random.Range(blinkWaitTimeMin, blinkWaitTimeMax)) + blinkTime;
		blinkEndTime = num3;
		if (testTargetPoint != null)
		{
			targetPosition = testTargetPoint;
			Transform transform = targetPosition.transform;
			Transform transform2 = base.transform;
			Vector3 position = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.LookAt(vector);
		}
		else if (eyeFocus != null)
		{
			targetPosition = eyeFocus;
			headboneTransform = headJoint;
		}
		Transform childTransform = eyeFocus.transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Dynamic);
	}

	public void DuelsScreenAnimateEyes(GameObject root, Vector3 offset)
	{
		//IL_000f: Expected VT, but got F4
		duelsScreenFocusPointOffset = (Vector3)offset.x;
		_ = offset.z;
		_duelsScreensPrefab = root;
		AnimateEyes(UIModelController.ModelScreen.DuelResultPopup);
	}

	public unsafe void AnimateEyes(UIModelController.ModelScreen modelScreen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected VT, but got Unknown
		//IL_044f: Expected F4, but got I
		//IL_044a: Expected native int or pointer, but got VT
		//IL_0471: Expected F4, but got I
		//IL_046c: Expected native int or pointer, but got VT
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected VT, but got Unknown
		//IL_074a: Expected VT, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected VT, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected VT, but got Unknown
		//IL_07bf: Expected VT, but got I
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected VT, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected VT, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected VT, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected VT, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 256);
		animate = true;
		Transform transform10;
		Vector3 localPosition;
		Transform transform11;
		Vector3 localPosition2;
		Transform transform12;
		Vector3 localPosition3;
		Transform transform13;
		Quaternion localRotation;
		Transform transform14;
		Quaternion localRotation2;
		Transform transform15;
		Quaternion localRotation3;
		switch (modelScreen)
		{
		case UIModelController.ModelScreen.DuelResultPopup:
		{
			Transform transform19 = targetPosition.transform;
			Transform parent = _duelsScreensPrefab.transform;
			transform19.parent = parent;
			Transform transform20 = targetPosition.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+68]");
			_ = 0;
			_ = duelsScreenFocusPointOffset;
			Vector3 localPosition4 = vector + 144;
			transform20.localPosition = localPosition4;
			Transform transform21 = targetPosition.transform;
			Transform transform22 = base.transform;
			Vector3 position9 = transform22.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			_ = 0;
			Vector3 worldPosition4 = vector + 128;
			transform21.LookAt(worldPosition4);
			goto IL_06bb;
		}
		case UIModelController.ModelScreen.Popup:
			if (targetPosition != null)
			{
				Transform childTransform2 = targetPosition.transform;
				HierarchyUtility.ReparentByHierarchyPathType(childTransform2, HierarchyPathType.Root);
				Transform transform4 = targetPosition.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+44]");
				_ = 0;
				_ = popupMenuFocusPointOffset;
				Vector3 position3 = vector + 112;
				transform4.position = position3;
				Transform transform5 = targetPosition.transform;
				Transform transform6 = base.transform;
				Vector3 position4 = transform6.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
				_ = 0;
				Vector3 worldPosition2 = vector + 96;
				transform5.LookAt(worldPosition2);
				goto IL_06bb;
			}
			break;
		case UIModelController.ModelScreen.Character:
		case UIModelController.ModelScreen.CelebrationCharacterUnlock:
			if (targetPosition != null)
			{
				Transform childTransform4 = targetPosition.transform;
				HierarchyUtility.ReparentByHierarchyPathType(childTransform4, HierarchyPathType.Root);
				Transform transform16 = targetPosition.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+50]");
				_ = 0;
				_ = characterMenuFocusPointOffset;
				Vector3 position7 = vector + 16;
				transform16.position = position7;
				Transform transform17 = targetPosition.transform;
				Transform transform18 = base.transform;
				Vector3 position8 = transform18.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
				((Vector3*)(nint)vector)->x = 0f;
				transform17.LookAt(vector);
				goto IL_06bb;
			}
			break;
		case UIModelController.ModelScreen.Boards:
		case UIModelController.ModelScreen.CelebrationBoardUnlock:
		case UIModelController.ModelScreen.LimitedBoardPopup:
			if (targetPosition != null)
			{
				Transform childTransform3 = targetPosition.transform;
				HierarchyUtility.ReparentByHierarchyPathType(childTransform3, HierarchyPathType.Root);
				Transform transform7 = targetPosition.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+5C]");
				_ = 0;
				_ = boardMenuFocusPointOffset;
				Vector3 position5 = vector + 48;
				transform7.position = position5;
				Transform transform8 = targetPosition.transform;
				Transform transform9 = base.transform;
				Vector3 position6 = transform9.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
				_ = 0;
				Vector3 worldPosition3 = vector + 32;
				transform8.LookAt(worldPosition3);
				goto IL_06bb;
			}
			break;
		case UIModelController.ModelScreen.CelebrationTopRun:
			{
				if (targetPosition != null)
				{
					Transform childTransform = targetPosition.transform;
					HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Root);
					Transform transform = targetPosition.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+AC]");
					_ = 0;
					_ = toprunFocusPointOffset;
					Vector3 position = vector + 80;
					transform.position = position;
					Transform transform2 = targetPosition.transform;
					Transform transform3 = base.transform;
					Vector3 position2 = transform3.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
					_ = 0;
					Vector3 worldPosition = vector - -64;
					transform2.LookAt(worldPosition);
					goto IL_06bb;
				}
				break;
			}
			IL_06bb:
			transform10 = targetPosition.transform;
			localPosition = transform10.localPosition;
			transform11 = targetPosition.transform;
			localPosition2 = transform11.localPosition;
			transform12 = targetPosition.transform;
			localPosition3 = transform12.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			originalPosition = (Vector3)0;
			transform13 = targetPosition.transform;
			localRotation = transform13.localRotation;
			transform14 = targetPosition.transform;
			localRotation2 = transform14.localRotation;
			transform15 = targetPosition.transform;
			localRotation3 = transform15.localRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			originalRotation = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E4]");
			_ = 0;
			break;
		}
	}

	public void StopAnimatingEyes()
	{
		animate = false;
		Mesh sharedMesh = _headMesh.sharedMesh;
		if (sharedMesh != null)
		{
			Mesh sharedMesh2 = _headMesh.sharedMesh;
			int blendShapeCount = sharedMesh2.blendShapeCount;
			if (blendShapeCount >= 1)
			{
				_headMesh.SetBlendShapeWeight(0, 0f);
			}
		}
	}

	private void ForceBlink()
	{
		float num = (blinkWaitEndTime = Time.time) + blinkTime;
		blinkEndTime = num;
	}

	private void UpdateEyeBlinking()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027f: Expected F4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		if (!(_eyeSwitch != null))
		{
			return;
		}
		Mesh sharedMesh = _headMesh.sharedMesh;
		if (!(sharedMesh != null))
		{
			return;
		}
		if (!IsEyeControlledByAnimation)
		{
			if (blinkWaitTimeMax < blinkWaitTimeMin)
			{
				return;
			}
			float time = Time.time;
			if (time < blinkWaitEndTime)
			{
				return;
			}
			float time2 = Time.time;
			if (blinkEndTime > time2)
			{
				float blendShapeWeight = _headMesh.GetBlendShapeWeight(0);
				if (blendShapeWeight < 1f)
				{
					Mesh sharedMesh2 = _headMesh.sharedMesh;
					int blendShapeCount = sharedMesh2.blendShapeCount;
					if (blendShapeCount >= 1)
					{
						_headMesh.SetBlendShapeWeight(0, 100f);
					}
				}
				return;
			}
			Mesh sharedMesh3 = _headMesh.sharedMesh;
			int blendShapeCount2 = sharedMesh3.blendShapeCount;
			if (blendShapeCount2 >= 1)
			{
				_headMesh.SetBlendShapeWeight(0, 0f);
			}
			float time3 = Time.time;
			float num = UnityEngine.Random.Range(blinkWaitTimeMin, blinkWaitTimeMax);
			float num2 = (blinkWaitEndTime = time3 + num) + blinkTime;
			blinkEndTime = num2;
		}
		else
		{
			Vector3 localPosition = _blendshapeController.localPosition;
			float num3 = Math.Abs((float)obj);
			float num4 = Math.Min(num3, 1f);
			bool flag = num3 < 0.1f;
			float num5 = 0f;
			if (!flag)
			{
				num5 = num4;
			}
			float value = num5 * 100f;
			_headMesh.SetBlendShapeWeight(0, value);
		}
	}

	private unsafe Vector3 GetFocusPoint()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003e: Expected F4, but got VT
		//IL_0074: Expected F4, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected VT, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected VT, but got Unknown
		//IL_01bd: Expected F4, but got I
		//IL_01b8: Expected native int or pointer, but got VT
		//IL_01df: Expected F4, but got I
		//IL_01da: Expected native int or pointer, but got VT
		//IL_0222: Expected F4, but got I
		//IL_021d: Expected native int or pointer, but got VT
		//IL_0237: Expected F4, but got I
		//IL_0232: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 112);
		Transform transform = targetPosition.transform;
		float minInclusive = 0f - (float)maxLookOffset;
		float num = UnityEngine.Random.Range(minInclusive, (float)maxLookOffset);
		float num2 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (AvatarEyeAnimation)+34]");
		float minInclusive2 = num2 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (AvatarEyeAnimation)+34]");
		float num3 = UnityEngine.Random.Range(minInclusive2, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (AvatarEyeAnimation)+B4]");
		float num4 = 0f + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (AvatarEyeAnimation)+B8]");
		float num5 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		float num6 = (float)originalPosition + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Vector3 localPosition = (Vector3)(quaternion + 32);
		transform.localPosition = localPosition;
		Transform transform2 = targetPosition.transform;
		float num7 = (float)originalRotation * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (AvatarEyeAnimation)+C0]");
		float num8 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (AvatarEyeAnimation)+C4]");
		float num9 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform2.localRotation = quaternion;
		Transform transform3 = targetPosition.transform;
		Vector3 position = transform3.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		((Vector3*)(nint)vector)->x = 0f;
		return vector;
	}

	private void ShiftFocusPoint(Vector3 focusPoint)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = focusPoint.z;
		_ = focusPoint.x;
		Transform transform = targetPosition.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		throw new ArgumentException();
	}

	private unsafe void ResetEyes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d7: Expected VT, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00ac: Expected F4, but got VT
		//IL_00a7: Expected native int or pointer, but got VT
		//IL_00c6: Expected Obj, but got I
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		offsetVector = (Vector2)0;
		Mesh sharedMesh = _headMesh.sharedMesh;
		if (sharedMesh != null)
		{
			Mesh sharedMesh2 = _headMesh.sharedMesh;
			int subMeshCount = sharedMesh2.subMeshCount;
			if (subMeshCount >= 2)
			{
				Material[] materials = _headMesh.materials;
				int num = _eyeMaterialID << 2;
				object obj2 = materials + num;
				_ = offsetVector;
				((Vector2*)(nint)vector)->x = (float)offsetVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v28+10]");
				((Material)0).SetTextureOffset("_MainTex", vector);
			}
		}
	}

	private unsafe void UpdateGetNewFocusPoint()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005f: Expected F4, but got I
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		float time = Time.time;
		if (time > endTimeToShift)
		{
			Vector3 focusPoint = GetFocusPoint();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			ShiftFocusPoint(vector);
			float time2 = Time.time;
			float num = UnityEngine.Random.Range(timeBetweenFocusShiftMin, timeBetweenFocusShiftMax);
			float num2 = time2 + num;
			endTimeToShift = num2;
		}
	}

	private void UpdateAnimatedEyes()
	{
		if (_eyeSwitch != null)
		{
			Mesh sharedMesh = _headMesh.sharedMesh;
			if (sharedMesh != null)
			{
				AnimateEyes();
			}
		}
	}

	private unsafe void AnimateEyes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0135: Expected VT, but got I
		//IL_0152: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0099: Expected VT, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_064a: Expected Obj, but got VT
		//IL_0691: Invalid comparison between Obj and F4
		//IL_0525: Expected I, but got Obj
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected VT, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected VT, but got Unknown
		//IL_022a: Invalid comparison between VT and F4
		//IL_0589: Invalid comparison between F4 and VT
		//IL_0599: Expected VT, but got F4
		//IL_024a: Invalid comparison between VT and F4
		//IL_06ba: Invalid comparison between VT and F4
		//IL_05c2: Expected VT, but got F4
		//IL_05f0: Invalid comparison between F4 and I
		//IL_0280: Invalid comparison between I and F4
		//IL_06de: Invalid comparison between I and F4
		//IL_0340: Expected F4, but got VT
		//IL_0355: Expected F4, but got I
		//IL_02a6: Invalid comparison between I and F4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_0400: Expected F4, but got VT
		//IL_03fb: Expected native int or pointer, but got VT
		//IL_041a: Expected Obj, but got I
		object obj = default;
		Vector2 vector = (Vector2)(obj - 48);
		if (~(useFocuPoint ? 1u : 0u) == 0 && !IsEyeControlledByAnimation)
		{
			UpdateGetNewFocusPoint();
		}
		object obj3;
		Vector3 vector3;
		object obj4;
		if (IsEyeControlledByAnimation)
		{
			Vector3 position = _eyeFocusOrigin.position;
			Vector3 position2 = _eyeFocusTarget.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
			Vector3 vector2 = (Vector3)(num - 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+24]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+24]");
			object obj2 = num2 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
			obj3 = num3 - 0;
			vector3 = vector2;
			obj4 = obj2;
		}
		else
		{
			Vector3 position3 = headboneTransform.position;
			Transform transform = targetPosition.transform;
			Vector3 position4 = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
			Vector3 vector4 = (Vector3)(num4 - 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+24]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+24]");
			object obj5 = num5 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
			obj3 = num6 - 0;
			vector3 = vector4;
			obj4 = obj5;
		}
		lookToCamera = vector3;
		object obj6 = vector3 * vector3;
		object obj7 = obj4 * obj4;
		object obj8 = obj6 + obj7;
		object obj9 = obj3 * obj3;
		object obj10 = obj8 + obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+DC]");
			object obj11 = 0 / obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+D8]");
			object obj12 = 0 / obj10;
			Vector3 vector5 = lookToCamera / obj10;
			lookToCamera = vector5;
		}
		else
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v109 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v110 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			lookToCamera = Vector3.zeroVector;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+DC]");
		_ = 0;
		_ = lookToCamera;
		Vector3 direction = (Vector3)(vector + 8);
		Vector3 vector6 = headboneTransform.InverseTransformDirection(direction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @542");
		Vector2 vector7 = default;
		offsetVector = vector7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @542");
		if (!IsEyeControlledByAnimation)
		{
			float num9 = 0f - currentHorizontalLimit;
			if (offsetVector >= (object)num9 && offsetVector <= (object)currentHorizontalLimit)
			{
				float num10 = 0f - currentVerticalLimit;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+E4]");
				if (!(0f < num10))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+E4]");
					if (!(0f > currentVerticalLimit))
					{
						useFocuPoint = true;
						goto IL_02e3;
					}
				}
			}
			useFocuPoint = false;
		}
		else if (~(useFocuPoint ? 1u : 0u) == 0)
		{
			goto IL_02e3;
		}
		if (~(shiftToFocusBlink ? 1u : 0u) == 0)
		{
			ResetEyes();
			float num11 = shiftEyeHorizontalLimit - 0.1f;
			currentHorizontalLimit = num11;
			float num12 = shiftEyeVerticalLimit - 0.1f;
			currentVerticalLimit = num12;
			ForceBlink();
			shiftToFocusBlink = false;
		}
		return;
		IL_02e3:
		if (~(shiftToFocusBlink ? 1u : 0u) != 0)
		{
			currentHorizontalLimit = shiftEyeHorizontalLimit;
			ForceBlink();
			shiftToFocusBlink = true;
		}
		float num13 = 0f - currentHorizontalLimit;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)currentHorizontalLimit) < System.Runtime.CompilerServices.Unsafe.As<Vector2, UIntPtr>(ref offsetVector);
		Vector2 vector8 = (Vector2)currentHorizontalLimit;
		if (!flag)
		{
			vector8 = offsetVector;
		}
		if (offsetVector >= (object)num13)
		{
			num13 = (float)vector8;
		}
		float num14 = num13 * shiftEyeHorizontalMultiplier;
		offsetVector = (Vector2)num14;
		float num15 = currentVerticalLimit;
		float num16 = 0f - currentVerticalLimit;
		float num17 = currentVerticalLimit;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+E4]");
		if (!(num17 < 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+E4]");
			num15 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AvatarEyeAnimation)+E4]");
		if (!(0f < num16))
		{
			num16 = num15;
		}
		float num18 = num16 * shiftEyeVerticalMultiplier;
		Mesh sharedMesh = _headMesh.sharedMesh;
		if (sharedMesh != null)
		{
			Mesh sharedMesh2 = _headMesh.sharedMesh;
			int subMeshCount = sharedMesh2.subMeshCount;
			if (subMeshCount >= 2)
			{
				Material[] materials = _headMesh.materials;
				int num19 = _eyeMaterialID << 2;
				object obj13 = materials + num19;
				_ = offsetVector;
				((Vector2*)(nint)vector)->x = (float)offsetVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v78+10]");
				((Material)0).SetTextureOffset("_MainTex", vector);
			}
		}
	}

	private void Update()
	{
		if (~(animate ? 1u : 0u) == 0)
		{
			UpdateEyeBlinking();
			UpdateAnimatedEyes();
		}
	}

	public AvatarEyeAnimation()
	{
		//IL_001a: Expected VT, but got I8
		//IL_003f: Expected VT, but got I8
		//IL_004e: Expected VT, but got I8
		//IL_005d: Expected VT, but got I8
		_ = -1018691584;
		_ = -4375247034725171200L;
		_ = 4692750814996332544L;
		_ = -4375247034727137280L;
		_ = 4764808409034260480L;
		base._002Ector();
	}
}
