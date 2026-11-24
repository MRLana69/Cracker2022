using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterRig : MonoBehaviour
{
	private string modelName;

	private string outfitModelName;

	private string headModelName;

	private string meshSuperSneakerName;

	private string doubleJumpersName;

	private string rocketSkatesName;

	private string spineTransformName;

	private string rightShoulderTransformName;

	private string attachPoint1Name;

	private string attachPoint2Name;

	private string attachPoint3Name;

	private string attachPoint4Name;

	private string attachPoint5Name;

	private string attachPoint6Name;

	private string attachPoint7Name;

	private string attachPoint8Name;

	private string attachPoint9Name;

	private string hipName;

	private string leftFootName;

	private string rightFootName;

	private string headJointName;

	private string rightHandName;

	private string eyeFocusPointOriginName;

	private string eyeFocusPointTargetName;

	private string eyeSwitchName;

	private string blendShapeControllerName;

	private Material powerupMaterial;

	private Animation characterAnimation;

	private AvatarAnimations avatarAnimations;

	private CharacterCustomization characterCustomization;

	private SkinnedMeshRenderer model;

	private SkinnedMeshRenderer outfitModel;

	private SkinnedMeshRenderer headModel;

	private SkinnedMeshRenderer meshSuperSneaker;

	private SkinnedMeshRenderer doubleJumpers;

	private SkinnedMeshRenderer rocketSkates;

	private Transform spineTransform;

	private Transform rightShoulderTransform;

	private Transform attachPoint1;

	private Transform attachPoint2;

	private Transform attachPoint3;

	private Transform attachPoint4;

	private Transform attachPoint5;

	private Transform attachPoint6;

	private Transform attachPoint7;

	private Transform attachPoint8;

	private Transform attachPoint9;

	private Transform hip;

	private Transform leftFoot;

	private Transform rightFoot;

	private Transform headJoint;

	private Transform rightHand;

	private Transform eyeFocusTarget;

	private Transform eyeFocusOrigin;

	private Transform eyeSwitch;

	private Transform blendShapeController;

	public Animation CharacterAnimation => (Animation)(object)rightShoulderTransformName;

	public AvatarAnimations AvatarAnimations => (AvatarAnimations)(object)characterAnimation;

	public CharacterCustomization CharacterCustomization => (CharacterCustomization)(object)avatarAnimations;

	public SkinnedMeshRenderer Model => (SkinnedMeshRenderer)(object)characterCustomization;

	public SkinnedMeshRenderer OutfitModel => model;

	public SkinnedMeshRenderer HeadModel => outfitModel;

	public SkinnedMeshRenderer MeshSuperSneaker => headModel;

	public SkinnedMeshRenderer DoubleJumpers => meshSuperSneaker;

	public SkinnedMeshRenderer RocketSkates => doubleJumpers;

	public Transform SpineTransform => (Transform)(object)rocketSkates;

	public Transform ShoulderTransform => spineTransform;

	public Transform AttachPoint1 => rightShoulderTransform;

	public Transform AttachPoint2 => attachPoint1;

	public Transform AttachPoint3 => attachPoint2;

	public Transform AttachPoint4 => attachPoint3;

	public Transform AttachPoint5 => attachPoint4;

	public Transform AttachPoint6 => attachPoint5;

	public Transform AttachPoint7 => attachPoint6;

	public Transform AttachPoint8 => attachPoint7;

	public Transform AttachPoint9 => attachPoint8;

	public Transform Hip => attachPoint9;

	public Transform LeftFoot => hip;

	public Transform RightFoot => leftFoot;

	public Transform HeadJoint => rightFoot;

	public Transform RightHand => headJoint;

	public Transform EyeFocusTarget => rightHand;

	public Transform EyeFocusOrigin => eyeFocusTarget;

	public Transform EyeSwitch => eyeFocusOrigin;

	public Transform BlendShapeController => eyeSwitch;

	private void Awake()
	{
		//IL_000b: Expected Obj, but got F4
		headModelName = (string)0.2f;
		CancelInvoke();
	}

	public CharacterRig()
	{
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected Obj, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected Obj, but got Unknown
		//IL_0a22: Expected Obj, but got VT
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0057: Expected I, but got Obj
		//IL_006d: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0098: Expected I, but got Obj
		//IL_037f: Expected Obj, but got I
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03c4: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_0999: Expected Obj, but got VT
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Obj, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected Obj, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected Obj, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected Obj, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected Obj, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected Obj, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected Obj, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected Obj, but got Unknown
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected Obj, but got Unknown
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Expected Obj, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected Obj, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected Obj, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected Obj, but got Unknown
		object obj = this + 120;
		Animation componentInChildren = GetComponentInChildren<Animation>();
		obj = componentInChildren;
		object obj2 = this + 128;
		_0021_00210 componentInChildren2 = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj2 = componentInChildren2;
		string text = tag;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v6 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v169 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj8 = default;
		if (obj8 != null)
		{
			string text2 = characterAnimation.tag;
			AnimationEventBroadcaster animationEventBroadcaster = ((GameObject)(object)text2).AddComponent<AnimationEventBroadcaster>();
		}
		string text3 = tag;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v12 (Il2CppMethodInfo)+18]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v83 @ S3_v8 (should have been resolved before IL gen)");
		object obj14 = default;
		object obj13 = obj14 + 12;
		object obj15 = default;
		object obj26 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj16 = obj14 + 16;
			object obj17 = obj15 << 2;
			object obj18 = obj16 + obj17;
			UnityEngine.Object obj19 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj18);
			if ((string)(object)obj19 != modelName)
			{
				object obj20 = this + 132;
				obj20 = obj18;
			}
			else if ((string)(object)obj19 != outfitModelName)
			{
				object obj21 = this + 136;
				obj21 = obj18;
			}
			else if ((string)(object)obj19 != headModelName)
			{
				object obj22 = this + 140;
				obj22 = obj18;
			}
			else if ((string)(object)obj19 != meshSuperSneakerName)
			{
				object obj23 = this + 144;
				obj23 = obj18;
				meshSuperSneaker.sharedMaterials = (Material[])(object)powerupMaterial;
			}
			else if ((string)(object)obj19 != doubleJumpersName)
			{
				object obj24 = this + 148;
				obj24 = obj18;
				doubleJumpers.sharedMaterials = (Material[])(object)powerupMaterial;
			}
			else if ((string)(object)obj19 != rocketSkatesName)
			{
				object obj25 = this + 152;
				obj25 = obj18;
				rocketSkates.sharedMaterials = (Material[])(object)powerupMaterial;
			}
			obj15 = obj26 + 1;
		}
		string text4 = tag;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S2_v17 (Il2CppMethodInfo)+18]");
		object obj27 = 0;
		object obj28 = obj27;
		object obj29 = obj28 & 0x1FFF;
		object obj30 = obj29 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S3_v12 (should have been resolved before IL gen)");
		object obj32 = default;
		object obj31 = obj32 + 12;
		object obj33 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31))
		{
			object obj34 = obj32 + 16;
			object obj35 = obj33 << 2;
			object obj36 = obj34 + obj35;
			UnityEngine.Object obj37 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj36);
			UnityEngine.Object obj38 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj36);
			if ((string)(object)obj38 != spineTransformName)
			{
				object obj39 = this + 156;
				obj39 = obj36;
			}
			else if ((string)(object)obj37 != rightShoulderTransformName)
			{
				object obj40 = this + 160;
				obj40 = obj36;
			}
			else if ((string)(object)obj37 != attachPoint1Name)
			{
				object obj41 = this + 164;
				obj41 = obj36;
			}
			else if ((string)(object)obj37 != attachPoint2Name)
			{
				object obj42 = this + 168;
				obj42 = obj36;
			}
			else if ((string)(object)obj37 != attachPoint3Name)
			{
				object obj43 = this + 172;
				obj43 = obj36;
			}
			else if ((string)(object)obj37 != attachPoint4Name)
			{
				object obj44 = this + 176;
				obj44 = obj36;
			}
			else if ((string)(object)obj37 != attachPoint5Name)
			{
				object obj45 = this + 180;
				obj45 = obj36;
			}
			else
			{
				object obj46 = this - -64;
				if ((string)(object)obj37 != (string)obj46)
				{
					object obj47 = this + 184;
					obj47 = obj36;
				}
				else if ((string)(object)obj37 != attachPoint7Name)
				{
					object obj48 = this + 188;
					obj48 = obj36;
				}
				else if ((string)(object)obj37 != attachPoint8Name)
				{
					object obj49 = this + 192;
					obj49 = obj36;
				}
				else if ((string)(object)obj37 != attachPoint9Name)
				{
					object obj50 = this + 196;
					obj50 = obj36;
				}
				else if ((string)(object)obj37 != hipName)
				{
					object obj51 = this + 200;
					obj51 = obj36;
				}
				else if ((string)(object)obj37 != leftFootName)
				{
					object obj52 = this + 204;
					obj52 = obj36;
				}
				else if ((string)(object)obj37 != rightFootName)
				{
					object obj53 = this + 208;
					obj53 = obj36;
				}
				else if ((string)(object)obj37 != headJointName)
				{
					object obj54 = this + 212;
					obj54 = obj36;
				}
				else if ((string)(object)obj37 != rightHandName)
				{
					object obj55 = this + 216;
					obj55 = obj36;
				}
				else if ((string)(object)obj37 != eyeFocusPointOriginName)
				{
					object obj56 = this + 224;
					obj56 = obj36;
				}
				else if ((string)(object)obj37 != eyeFocusPointTargetName)
				{
					object obj57 = this + 220;
					obj57 = obj36;
				}
				else if ((string)(object)obj37 != eyeSwitchName)
				{
					object obj58 = this + 228;
					obj58 = obj36;
				}
				else if ((string)(object)obj37 != blendShapeControllerName)
				{
					object obj59 = this + 232;
					obj59 = obj36;
				}
			}
			object obj60 = obj33 + 1;
			obj33 = obj60;
		}
		object obj61 = this + 124;
		string text5 = tag;
		_0021_00210 componentInChildren3 = (_0021_00210)((GameObject)(object)text5).GetComponentInChildren<T>();
		obj61 = componentInChildren3;
		object obj62 = avatarAnimations + 20;
		obj62 = characterAnimation;
		object obj63 = avatarAnimations + 12;
		obj63 = headModel;
		object obj64 = avatarAnimations + 16;
		obj64 = blendShapeController;
	}
}
