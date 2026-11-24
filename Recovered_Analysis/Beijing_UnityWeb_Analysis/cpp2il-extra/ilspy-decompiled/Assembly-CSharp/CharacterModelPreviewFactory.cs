using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class CharacterModelPreviewFactory : MonoBehaviour
{
	[Serializable]
	public class ModelSetupObject
	{
		public AnimationClip ScrollbarPose;

		public AnimationClip ScrollbarHeadPose;

		public AnimationClip EventScreenPose;

		public AnimationClip NameEventScreenIdle;

		public GameObject model;

		public bool UseCustomEventScreenIdle;
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public CharacterModelPreviewFactory _003C_003E4__this;

		public Action<GameObject> onSuccess;

		internal unsafe void _003CGetEventScreenModel_003Eb__0(ModelSetupObject MSO)
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00d6: Expected Obj, but got I
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected Obj, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected Obj, but got Unknown
			//IL_0123: Expected VT, but got Obj
			//IL_0054: Expected I, but got Obj
			//IL_013a: Expected I, but got Obj
			//IL_0150: Expected Obj, but got I
			//IL_04dd: Expected Obj, but got I4
			//IL_0258: Expected I, but got Obj
			//IL_026e: Expected Obj, but got I
			//IL_017b: Expected I, but got Obj
			//IL_01e2: Expected I4, but got Obj
			//IL_0299: Expected I, but got Obj
			//IL_0300: Expected I4, but got Obj
			//IL_022e: Expected I4, but got Obj
			//IL_0324: Expected I4, but got Obj
			//IL_0245: Expected Obj, but got I4
			//IL_035f: Expected I4, but got Obj
			//IL_0371: Expected Obj, but got I4
			//IL_0395: Expected I4, but got Obj
			//IL_03ac: Expected Obj, but got I4
			//IL_03ac: Expected Obj, but got I4
			//IL_03d0: Expected I4, but got Obj
			//IL_03e2: Expected Obj, but got I4
			//IL_0406: Expected I4, but got Obj
			//IL_041d: Expected Obj, but got I4
			//IL_0441: Expected I4, but got Obj
			//IL_0453: Expected Obj, but got I4
			if (MSO != null)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)MSO.ScrollbarPose).FindKernel((string)null) == 0)
				{
					object msg = ((IConvertible)"could not find Scrollbar Pose for '").ToType((Type)(object)_003C_003E4__this, (IFormatProvider)(object)"'.");
					SDebug.LogFormat((string)msg, null);
				}
				else
				{
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v7 (Il2CppMethodInfo)+18]");
					object obj2 = 0;
					object obj3 = obj2;
					object obj4 = obj3 & 0x1FFF;
					object obj5 = obj4 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S3_v5 (should have been resolved before IL gen)");
					UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarPose);
					CharacterController characterController = default;
					CollisionFlags collisionFlags = characterController.Move((Vector3)obj6);
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if ((UnityEngine.Object)collisionFlags != null)
					{
						UnityEngine.Object obj8 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarPose);
						((AnimationState)(object)characterController).AddMixingTransform((Transform)(object)MSO.ScrollbarPose, (byte)(int)obj8 != 0);
						UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarPose);
						AnimationState animationState = ((Animation)(object)characterController).CrossFadeQueued((string)(object)animation);
						UnityEngine.Object obj9 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarPose);
						bool flag = ((Animation)(object)characterController).Play((PlayMode)obj9);
						((CharacterController)flag).height = 0f;
					}
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)MSO.ScrollbarHeadPose).FindKernel((string)null) != 0)
					{
						UnityEngine.Object obj11 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarHeadPose);
						((AnimationState)(object)characterController).AddMixingTransform((Transform)(object)MSO.ScrollbarHeadPose, (byte)(int)obj11 != 0);
						UnityEngine.Object obj12 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarHeadPose);
						bool flag2 = ((Animation)(object)characterController).Play((PlayMode)obj12);
						Vector3 point = ((RaycastHit*)null)->point;
						UnityEngine.Object obj13 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarHeadPose);
						bool flag3 = ((Animation)(object)characterController).Play((PlayMode)obj13);
						((AnimationState)flag3).time = 1f;
						UnityEngine.Object obj14 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarHeadPose);
						bool flag4 = ((Animation)(object)characterController).Play((PlayMode)obj14);
						((AnimationState)flag4).AddMixingTransform((Transform)10);
						UnityEngine.Object obj15 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarHeadPose);
						bool flag5 = ((Animation)(object)characterController).Play((PlayMode)obj15);
						((AnimationState)flag5).wrapMode = WrapMode.Once;
						UnityEngine.Object obj16 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarHeadPose);
						bool flag6 = ((Animation)(object)characterController).Play((PlayMode)obj16);
						((CharacterController)flag6).height = 0f;
						UnityEngine.Object obj17 = UnityEngine.Object.Instantiate((UnityEngine.Object)MSO.ScrollbarHeadPose);
						bool flag7 = ((Animation)(object)characterController).Play((PlayMode)obj17);
						((AnimationState)flag7).speed = 0f;
					}
					Animation.INTERNAL_CALL_Sample((Animation)(object)characterController);
				}
			}
			onSuccess(MSO.model);
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public CharacterModelPreviewFactory _003C_003E4__this;

		public Action<CharacterScreenController> onSuccess;

		internal void _003CGetCharacterEventScreenModel_003Eb__0(ModelSetupObject mso)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			//IL_0061: Expected I, but got Obj
			//IL_0077: Expected Obj, but got I
			//IL_00a2: Expected I, but got Obj
			//IL_0102: Expected I4, but got Obj
			if (mso != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v5 (Il2CppMethodInfo)+18]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj2 & 0x1FFF;
				object obj4 = obj3 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v5 (should have been resolved before IL gen)");
				CharacterModelPreviewFactory characterModelPreviewFactory = _003C_003E4__this;
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)characterModelPreviewFactory.facebookIdle).FindKernel((string)null) != 0)
				{
					CharacterModelPreviewFactory characterModelPreviewFactory2 = _003C_003E4__this;
					AnimationState animationState = default;
					animationState.AddMixingTransform((Transform)(object)characterModelPreviewFactory2.facebookIdle, (byte)(int)"facebookClip" != 0);
					AnimationState animationState2 = ((Animation)(object)animationState).CrossFadeQueued("facebookClip");
				}
			}
			onSuccess(mso.model);
		}
	}

	private GameObject characterModelPreviewPrefab;

	private CharacterAssetFactory characterAssetFactory;

	private AnimationClip facebookIdle;

	private AnimationClip defaultEventScreenPose;

	private AnimationClip defaultEnventScreenIdle;

	private Shader eventScreenShader;

	private Shader eventScreenOutfitShader;

	private float _nameEventScreenCharacterFadeFactor;

	private float _nameEventScreenShadowFadeFactor;

	private SkinnedMeshRenderer headMesh;

	private static CharacterModelPreviewFactory instance;

	public static CharacterModelPreviewFactory Instance
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0120: Expected I, but got Obj
			//IL_0136: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AssetBundleManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<AssetBundleManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AssetBundleVersionControl root = AssetBundleVersionControl.Instance;
			nint num3 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<System.IO.Path>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v12 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot((string)(object)root, "AssetBundleVersion");
			return (CharacterModelPreviewFactory)Path.SameRoot((string)flag, "AssetBundleVersionInfo");
		}
	}

	public void GetCharacterModelPreview(string name, int version, Action<GameObject> onSuccess, bool asynchronous)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_007c: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = name;
		object obj4 = onSuccess & 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		bool flag = default;
		object obj5 = (flag ? 1 : 0) + 16;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		((CharacterCustomizationProp)0).Initialize(null, flag);
	}

	public void GetEventScreenModel(string name, int version, Action<GameObject> onSuccess)
	{
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0225: Expected Obj, but got I
		//IL_00f9: Expected VT, but got I4
		//IL_00f9: Expected Obj, but got I
		//IL_014d: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterModelPreviewFactory)+90]");
		if ((UnityEngine.Object)0 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterModelPreviewFactory)+EC]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterModelPreviewFactory)+EC]");
			((AvatarEyeAnimation)0).DuelsScreenAnimateEyes((GameObject)(object)onSuccess, (Vector3)version);
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterModelPreviewFactory)+E8]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Vector3 focusPoint = ((AvatarEyeAnimation)(object)name).GetFocusPoint();
		}
	}

	public void GetFacebookScreenModel(string name, Action<GameObject> onSuccess)
	{
		//IL_026a: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I4
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I4
		//IL_01ca: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		if (((ComputeShader)(object)name).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)(object)name);
		int layer = gameObject.layer;
		((Transform)layer).parentInternal = (Transform)(object)onSuccess;
		int layer2 = gameObject.layer;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v44 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer3 = gameObject.layer;
		nint num7 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v26 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v40 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj4;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		int layer4 = gameObject.layer;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj2;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)layer4).parent = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterModelPreviewFactory)+D4]");
		((List<GameObject>)0).Add(gameObject);
	}

	public unsafe void GetCharacterEventScreenModel(string name, int version, Action<CharacterScreenController> onSuccess)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_0099: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(_003C_003Ec__DisplayClass12_0._003CGetEventScreenModel_003Eb__0);
		object obj4 = action + 16;
		obj4 = obj2;
		((CoinEarnerVideoAds)this).Init((int)name, (string)version, (string)null, (string)1, 0, action, (UIScrollView)null);
	}

	public unsafe void GetCharacterComebackScreenModel(Characters.CharacterId charId, int themeIndex, Action<CharacterScreenController> onSuccess)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(_003C_003Ec__DisplayClass14_0._003CGetCharacterEventScreenModel_003Eb__0);
		object obj4 = action + 16;
		obj4 = obj2;
		((CoinEarnerVideoAds)this).Init((int)charId, (string)themeIndex, (string)null, (string)1, 0, action, (UIScrollView)null);
	}

	public void BuildCharacter(string name, int version, bool useSpecialAsset, bool useAnimatedEyes, bool forceLOD0, Action<ModelSetupObject> onSucess, bool asynchronous = false)
	{
	}

	private void OnDestroy()
	{
		CancelInvoke();
	}

	public CharacterModelPreviewFactory()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CharacterModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterModelPreviewFactory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<CharacterModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		instance = null;
	}

	static CharacterModelPreviewFactory()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo = default;
		characterMaterialPathInfo.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Default;
		characterMaterialPathInfo.PerformanceLevel = DeviceInfo.PerformanceLevel.Low;
		object obj = characterMaterialPathInfo + 16;
		obj = "Materials/avatar_default_LOD0";
		List<CharacterMaterial.CharacterMaterialPathInfo> list = default;
		list.Add(characterMaterialPathInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo2 = default;
		characterMaterialPathInfo2.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Default;
		characterMaterialPathInfo2.PerformanceLevel = DeviceInfo.PerformanceLevel.Medium;
		object obj2 = characterMaterialPathInfo2 + 16;
		obj2 = "Materials/avatar_default_LOD1";
		list.Add(characterMaterialPathInfo2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo3 = default;
		characterMaterialPathInfo3.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Default;
		characterMaterialPathInfo3.PerformanceLevel = DeviceInfo.PerformanceLevel.High;
		object obj3 = characterMaterialPathInfo3 + 16;
		obj3 = "Materials/avatar_default_LOD2";
		list.Add(characterMaterialPathInfo3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo4 = default;
		characterMaterialPathInfo4.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Additive;
		characterMaterialPathInfo4.PerformanceLevel = DeviceInfo.PerformanceLevel.Low;
		object obj4 = characterMaterialPathInfo4 + 16;
		obj4 = "Materials/avatar_additive_LOD0";
		list.Add(characterMaterialPathInfo4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo5 = default;
		characterMaterialPathInfo5.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Additive;
		characterMaterialPathInfo5.PerformanceLevel = DeviceInfo.PerformanceLevel.Medium;
		object obj5 = characterMaterialPathInfo5 + 16;
		obj5 = "Materials/avatar_additive_LOD1";
		list.Add(characterMaterialPathInfo5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo6 = default;
		characterMaterialPathInfo6.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Additive;
		characterMaterialPathInfo6.PerformanceLevel = DeviceInfo.PerformanceLevel.High;
		object obj6 = characterMaterialPathInfo6 + 16;
		obj6 = "Materials/avatar_additive_LOD2";
		list.Add(characterMaterialPathInfo6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo7 = default;
		characterMaterialPathInfo7.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Shine;
		characterMaterialPathInfo7.PerformanceLevel = DeviceInfo.PerformanceLevel.Low;
		object obj7 = characterMaterialPathInfo7 + 16;
		obj7 = "Materials/avatar_shine_LOD0";
		list.Add(characterMaterialPathInfo7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo8 = default;
		characterMaterialPathInfo8.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Shine;
		characterMaterialPathInfo8.PerformanceLevel = DeviceInfo.PerformanceLevel.Medium;
		object obj8 = characterMaterialPathInfo8 + 16;
		obj8 = "Materials/avatar_shine_LOD1";
		list.Add(characterMaterialPathInfo8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterMaterial.CharacterMaterialPathInfo characterMaterialPathInfo9 = default;
		characterMaterialPathInfo9.ShaderType = CharacterMaterial.CharacterMaterialShaderType.Shine;
		characterMaterialPathInfo9.PerformanceLevel = DeviceInfo.PerformanceLevel.High;
		object obj9 = characterMaterialPathInfo9 + 16;
		obj9 = "Materials/avatar_shine_LOD2";
		list.Add(characterMaterialPathInfo9);
		CharacterMaterial._materialPaths = list;
	}
}
