using System;
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

	public Animation CharacterAnimation => characterAnimation;

	public AvatarAnimations AvatarAnimations => avatarAnimations;

	public CharacterCustomization CharacterCustomization => characterCustomization;

	public SkinnedMeshRenderer Model => model;

	public SkinnedMeshRenderer OutfitModel => outfitModel;

	public SkinnedMeshRenderer HeadModel => headModel;

	public SkinnedMeshRenderer MeshSuperSneaker => meshSuperSneaker;

	public SkinnedMeshRenderer DoubleJumpers => doubleJumpers;

	public SkinnedMeshRenderer RocketSkates => rocketSkates;

	public Transform SpineTransform => spineTransform;

	public Transform ShoulderTransform => rightShoulderTransform;

	public Transform AttachPoint1 => attachPoint1;

	public Transform AttachPoint2 => attachPoint2;

	public Transform AttachPoint3 => attachPoint3;

	public Transform AttachPoint4 => attachPoint4;

	public Transform AttachPoint5 => attachPoint5;

	public Transform AttachPoint6 => attachPoint6;

	public Transform AttachPoint7 => attachPoint7;

	public Transform AttachPoint8 => attachPoint8;

	public Transform AttachPoint9 => attachPoint9;

	public Transform Hip => hip;

	public Transform LeftFoot => leftFoot;

	public Transform RightFoot => rightFoot;

	public Transform HeadJoint => headJoint;

	public Transform RightHand => rightHand;

	public Transform EyeFocusTarget => eyeFocusTarget;

	public Transform EyeFocusOrigin => eyeFocusOrigin;

	public Transform EyeSwitch => eyeSwitch;

	public Transform BlendShapeController => blendShapeController;

	private void Awake()
	{
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_03fd: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_0755: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I
		Animation componentInChildren = GetComponentInChildren<Animation>();
		characterAnimation = componentInChildren;
		CharacterCustomization component = GetComponent<CharacterCustomization>();
		characterCustomization = component;
		GameObject gameObject = base.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj = default;
		if (obj == null)
		{
			GameObject gameObject2 = characterAnimation.gameObject;
			AnimationEventBroadcaster animationEventBroadcaster = gameObject2.AddComponent<AnimationEventBroadcaster>();
		}
		GameObject gameObject3 = base.gameObject;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S3_v7 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj2 = default;
		object obj5 = default;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v17+C]");
			if (0 <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = obj5 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v149+10]");
			string text = ((UnityEngine.Object)0).name;
			if (text == modelName)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v149+10]");
				model = (SkinnedMeshRenderer)0;
			}
			else if (text == outfitModelName)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v149+10]");
				outfitModel = (SkinnedMeshRenderer)0;
			}
			else if (text == headModelName)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v149+10]");
				headModel = (SkinnedMeshRenderer)0;
			}
			else if (text == meshSuperSneakerName)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v149+10]");
				meshSuperSneaker = (SkinnedMeshRenderer)0;
				meshSuperSneaker.material = powerupMaterial;
			}
			else if (text == doubleJumpersName)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v149+10]");
				doubleJumpers = (SkinnedMeshRenderer)0;
				doubleJumpers.material = powerupMaterial;
			}
			else if (text == rocketSkatesName)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v149+10]");
				rocketSkates = (SkinnedMeshRenderer)0;
				rocketSkates.material = powerupMaterial;
			}
			obj2 = obj6 + 1;
		}
		object obj7 = this + 156;
		object obj8 = this + 160;
		object obj9 = this + 164;
		object obj10 = this + 168;
		object obj11 = this + 172;
		object obj12 = this + 176;
		object obj13 = this + 180;
		object obj14 = this + 184;
		object obj15 = this + 188;
		object obj16 = this + 192;
		object obj17 = this + 196;
		object obj18 = this + 200;
		object obj19 = this + 204;
		object obj20 = this + 208;
		object obj21 = this + 212;
		object obj22 = this + 216;
		object obj23 = this + 224;
		object obj24 = this + 220;
		object obj25 = this + 228;
		object obj26 = this + 232;
		GameObject gameObject4 = base.gameObject;
		nint num5 = 0;
		nint num6 = 0;
		IntPtr intPtr3 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ S3_v11 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj27 = 0;
		object obj30 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v64+C]");
			if (0 <= (nint)obj27)
			{
				break;
			}
			object obj28 = obj27 << 2;
			object obj29 = obj30 + obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v78+10]");
			string text2 = ((UnityEngine.Object)0).name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v78+10]");
			string text3 = ((UnityEngine.Object)0).name;
			bool flag = text3 != spineTransformName;
			object obj31 = obj7;
			if (flag)
			{
				bool flag2 = text2 != rightShoulderTransformName;
				obj31 = obj8;
				if (flag2)
				{
					bool flag3 = text2 != attachPoint1Name;
					obj31 = obj9;
					if (flag3)
					{
						bool flag4 = text2 != attachPoint2Name;
						obj31 = obj10;
						if (flag4)
						{
							bool flag5 = text2 != attachPoint3Name;
							obj31 = obj11;
							if (flag5)
							{
								bool flag6 = text2 != attachPoint4Name;
								obj31 = obj12;
								if (flag6)
								{
									bool flag7 = text2 != attachPoint5Name;
									obj31 = obj13;
									if (flag7)
									{
										bool flag8 = text2 != attachPoint6Name;
										obj31 = obj14;
										if (flag8)
										{
											bool flag9 = text2 != attachPoint7Name;
											obj31 = obj15;
											if (flag9)
											{
												bool flag10 = text2 != attachPoint8Name;
												obj31 = obj16;
												if (flag10)
												{
													bool flag11 = text2 != attachPoint9Name;
													obj31 = obj17;
													if (flag11)
													{
														bool flag12 = text2 != hipName;
														obj31 = obj18;
														if (flag12)
														{
															bool flag13 = text2 != leftFootName;
															obj31 = obj19;
															if (flag13)
															{
																bool flag14 = text2 != rightFootName;
																obj31 = obj20;
																if (flag14)
																{
																	bool flag15 = text2 != headJointName;
																	obj31 = obj21;
																	if (flag15)
																	{
																		bool flag16 = text2 != rightHandName;
																		obj31 = obj22;
																		if (flag16)
																		{
																			bool flag17 = text2 != eyeFocusPointOriginName;
																			obj31 = obj23;
																			if (flag17)
																			{
																				bool flag18 = text2 != eyeFocusPointTargetName;
																				obj31 = obj24;
																				if (flag18)
																				{
																					bool flag19 = text2 != eyeSwitchName;
																					obj31 = obj25;
																					if (flag19)
																					{
																						bool flag20 = text2 == blendShapeControllerName;
																						bool flag21 = !flag20;
																						obj31 = obj26;
																						if (flag21)
																						{
																							goto IL_0832;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v78+10]");
			obj31 = 0;
			goto IL_0832;
			IL_0832:
			object obj32 = obj27 + 1;
			obj27 = obj32;
		}
		GameObject gameObject5 = base.gameObject;
		AvatarAnimations component2 = gameObject5.GetComponent<AvatarAnimations>();
		this.avatarAnimations = component2;
		AvatarAnimations avatarAnimations = this.avatarAnimations;
		avatarAnimations._target = characterAnimation;
		AvatarAnimations avatarAnimations2 = this.avatarAnimations;
		avatarAnimations2._head = headModel;
		AvatarAnimations avatarAnimations3 = this.avatarAnimations;
		avatarAnimations3._blendshapeController = blendShapeController;
	}
}
