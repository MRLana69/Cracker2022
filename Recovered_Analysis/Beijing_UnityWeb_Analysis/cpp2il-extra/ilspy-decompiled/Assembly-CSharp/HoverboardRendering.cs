using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Missions;
using SYBO.Components.Utilities.Validators;
using UnityEngine;

public class HoverboardRendering : MonoBehaviour
{
	[Serializable]
	public class AbilityAnimationList
	{
		public Hoverboard.BoardAbility ability;

		public bool prio;

		public AnimationClip defaultHoverboardAnimation;

		public AnimationPair[] runAnimations;

		public AnimationPair[] landAnimations;

		public AnimationPair[] jumpAnimations = (AnimationPair[])1;

		public AnimationPair[] hangtimeAnimations;

		public AnimationPair[] rollAnimations;

		public AnimationPair[] dodgeLeftAnimations;

		public AnimationPair[] dodgeRightAnimations;

		public AnimationPair[] grindAnimations;

		public AnimationPair[] grindLandAnimations;

		public AnimationPair[] getOnBoardAnimations;

		public AbilityAnimationList()
		{
			//IL_000b: Expected Obj, but got I4
			_ = 1;
		}
	}

	[Serializable]
	public class AnimationStringPair
	{
		public string characterAnimation;

		public string hoverboardAnimation;
	}

	[Serializable]
	public class AnimationPair
	{
		public AnimationClip characterAnimationClip;

		public AnimationClip hoverboardAnimationClip;

		public AnimationPair()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = "";
			object obj2 = this + 12;
			obj2 = "";
		}
	}

	public AnimationClip defaultHoverboardAnimation;

	public AnimationPair[] runAnimations;

	public AnimationPair[] landAnimations;

	public AnimationPair[] jumpAnimations;

	public AnimationPair[] hangtimeAnimations;

	public AnimationPair[] rollAnimations;

	public AnimationPair[] dodgeLeftAnimations;

	public AnimationPair[] dodgeRightAnimations;

	public AnimationPair[] grindAnimations;

	public AnimationPair[] grindLandAnimations;

	public AnimationPair[] getOnBoardAnimations;

	public AbilityAnimationList[] abilityAnimationLists;

	private bool hasInitializedAnimationSounds;

	public void Initialize(Animation avatarAnimation, Animation hoverboardAnimation, AbilityAnimationList defaultAbilityAnimationLists, List<AnimationClip> addedClipsList, Hoverboard.BoardAbility[] abilities)
	{
		//IL_0262: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I4
		if (((string)(object)addedClipsList).EndsWith("lightSignal"))
		{
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)32, (PersistentAwardProgress)1, (Action<Award>)(-1));
		}
		else if (!((string)(object)addedClipsList).EndsWith("bush") && !((string)(object)addedClipsList).EndsWith("powerbox"))
		{
			if (((string)(object)addedClipsList).EndsWith("ramp_side"))
			{
				StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)30, (PersistentAwardProgress)1, (Action<Award>)(-1));
				return;
			}
			if (((string)(object)addedClipsList).EndsWith("blocker_jump"))
			{
				StayInOneLaneMission instance3 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)instance3)._002Ector((AwardStaticData)33, (PersistentAwardProgress)1, (Action<Award>)(-1));
				return;
			}
			if (((string)(object)addedClipsList).EndsWith("blocker_roll"))
			{
				StayInOneLaneMission instance4 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)instance4)._002Ector((AwardStaticData)33, (PersistentAwardProgress)1, (Action<Award>)(-1));
				return;
			}
			bool flag = ((string)(object)addedClipsList).EndsWith("blocker_standard");
			StayInOneLaneMission instance5 = StayInOneLaneMission.instance;
			if (flag)
			{
				((OwnBoardsAward)(object)instance5)._002Ector((AwardStaticData)33, (PersistentAwardProgress)1, (Action<Award>)(-1));
			}
			else
			{
				((OwnBoardsAward)(object)instance5)._002Ector((AwardStaticData)30, (PersistentAwardProgress)1, (Action<Award>)(-1));
			}
		}
		else
		{
			StayInOneLaneMission instance6 = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)instance6)._002Ector((AwardStaticData)31, (PersistentAwardProgress)1, (Action<Award>)(-1));
		}
	}

	private List<string> GetNamesAddAnimationClips(AnimationPair[] abilityPairs, AnimationPair[] pairs, Animation avaterAnimation, Animation hoverboardAnimation, List<AnimationClip> addedClipsList)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Expected Obj, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_0465: Expected Obj, but got I
		//IL_0496: Expected Obj, but got I
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_022f: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02b9: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I4
		//IL_099e: Expected Obj, but got I4
		//IL_0a4c: Expected Obj, but got I
		//IL_0a61: Expected Obj, but got I
		//IL_0a9e: Expected Obj, but got I
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected Obj, but got Unknown
		//IL_0a1c: Expected Obj, but got I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_0356: Expected Obj, but got I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got I4
		//IL_0533: Expected Obj, but got I4
		//IL_0591: Expected Obj, but got I4
		//IL_066b: Expected Obj, but got I4
		//IL_06a0: Expected Obj, but got I4
		//IL_06e3: Expected Obj, but got I4
		//IL_0725: Expected Obj, but got I4
		//IL_098b: Expected Obj, but got I4
		//IL_0952: Expected Obj, but got I4
		//IL_097d: Expected Obj, but got I4
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected Obj, but got Unknown
		//IL_0835: Expected Obj, but got I4
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected Obj, but got Unknown
		//IL_086e: Expected Obj, but got I4
		//IL_08d8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F8]");
		object obj = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F8]");
		List<string> list;
		object obj36 = default;
		if ((nint)0 != 1 && (nint)obj != 1)
		{
			if ((nint)obj == 2)
			{
				object obj2 = (object)abilityPairs << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+300]");
				object obj3 = 0 + obj2;
				_ = 0;
				nint num = 0;
				object obj4 = obj3 << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F0]");
				object obj5 = 0 + obj4;
				object obj6 = obj5 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v97+1]");
				object obj7 = (nint)0 << 16;
				object obj8 = obj6 << 24;
				object obj9 = obj7 | obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v97+2]");
				object obj10 = (nint)0 << 8;
				object obj11 = obj9 | obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v97+3]");
				object obj12 = obj11 | 0;
				object obj13 = this + 16;
				AnimationPair[] array = default;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<AnimationPair[], UIntPtr>(ref array))
				{
					list = (List<string>)6;
				}
				else
				{
					object obj14 = this + 804;
					object obj15 = this + 800;
					object obj16 = obj12 + 4;
					object obj17 = 0;
					AnimationPair[] array2 = default;
					List<string> list2 = default;
					List<string> list3 = default;
					object obj23 = default;
					object obj24 = default;
					List<string> list4 = default;
					List<string> list5 = default;
					object obj29 = default;
					object obj30 = default;
					while (true)
					{
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
						{
							list = (List<string>)3;
							break;
						}
						object obj18 = obj14 - obj12;
						object obj19 = (object)array2 << 2;
						object obj20 = obj19 + 12;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
						{
							list = (List<string>)3;
							break;
						}
						object obj21 = obj16 + obj19;
						object obj22 = obj21 + obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @577C");
						if (list2 != null)
						{
							list = list2;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5849");
						if (list3 != null)
						{
							list = list3;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @58F7");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @58F7");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @584B");
						if (obj23 == obj24)
						{
							list = (List<string>)6;
							break;
						}
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
						{
							list = (List<string>)3;
							break;
						}
						object obj25 = obj23 - obj24;
						if ((nint)obj25 < 8)
						{
							list = (List<string>)3;
							break;
						}
						object obj26 = obj14 - obj12;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23))
						{
							list = (List<string>)3;
							break;
						}
						object obj27 = obj24 + obj12;
						object obj28 = obj27 + obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @577C");
						if (list4 != null)
						{
							list = list4;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5849");
						if (list5 != null)
						{
							list = list5;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @587A");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @587A");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @58F7");
						if ((nint)obj29 < 1919378028)
						{
							if ((nint)obj29 < 1785751328)
							{
								if ((nint)obj29 != 1685418085)
								{
									list = (List<string>)7;
								}
								else
								{
									if ((nint)obj17 < 4)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @587A");
										array2 = (AnimationPair[])(obj30 & 0xFFFF);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @584B");
										object obj31 = obj17 + 1;
										bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) >= System.Runtime.CompilerServices.Unsafe.As<AnimationPair[], UIntPtr>(ref array2);
										obj17 = obj31;
										if (!flag)
										{
											list = (List<string>)6;
											break;
										}
										continue;
									}
									list = (List<string>)3;
								}
							}
							else
							{
								if ((nint)obj29 == 1785751328)
								{
									goto IL_0982;
								}
								list = (List<string>)7;
							}
							goto IL_0b2d;
						}
						if ((nint)obj29 < 1953064550)
						{
							if ((nint)obj29 != 1919378028)
							{
								goto IL_0949;
							}
						}
						else if ((nint)obj29 != 1953064550)
						{
							goto IL_0949;
						}
						goto IL_0982;
						IL_0982:
						list = (List<string>)2;
						goto IL_0b2d;
						IL_0b2d:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @584B");
						break;
						IL_0949:
						list = (List<string>)7;
						goto IL_0b2d;
					}
				}
			}
			else
			{
				list = (List<string>)2;
			}
		}
		else
		{
			object obj32 = (object)abilityPairs << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+300]");
			object obj33 = 0 + obj32;
			object obj34 = this + 804;
			if (obj34 != null)
			{
				object obj35 = this + 800;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @577C");
				List<string> list6 = default;
				bool flag2 = list6 == null;
				bool flag3 = !flag2;
				list = list6;
				if (!flag3)
				{
					obj36 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+54]");
					object obj37 = (nint)0 + (nint)76;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F0]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F4]");
					object obj38 = num2 + 0;
					object obj39 = obj33 * 48;
					object obj40 = obj39 | 8;
					object obj41 = obj40 + 47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F4]");
					List<string> list7 = default;
					if ((nint)obj41 > 0)
					{
						list7 = (List<string>)3;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F0]");
						object obj42 = 0 + obj39;
						object obj43 = obj42 + 12;
						object obj44 = obj43 + -4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v61+1]");
						object obj45 = (nint)0 << 16;
						object obj46 = obj44 << 24;
						object obj47 = obj45 | obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v61+2]");
						object obj48 = (nint)0 << 8;
						object obj49 = obj47 | obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v61+3]");
						object obj50 = obj49 | 0;
						object obj51 = obj43 + 8;
						object obj52 = obj51 + -4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S1_v69+1]");
						object obj53 = (nint)0 << 16;
						object obj54 = obj52 << 24;
						object obj55 = obj53 | obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S1_v69+2]");
						object obj56 = (nint)0 << 8;
						object obj57 = obj55 | obj56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S1_v69+3]");
						object obj58 = obj57 | 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S1_v68+22]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F4]");
						if (0 < (nint)obj50)
						{
							list7 = (List<string>)3;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardRendering)+2F4]");
							object obj59 = 0 - obj50;
							object obj60 = obj59 >> 3;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60))
							{
								list7 = (List<string>)3;
							}
							else
							{
								object obj61 = (object)avaterAnimation >> 22;
								object obj62 = obj61 & 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @58F8");
							}
						}
					}
					list = list7;
				}
			}
			else
			{
				list = (List<string>)142;
			}
		}
		object obj63 = avaterAnimation & 0x500000;
		object obj64 = obj63 | (object)list;
		if (obj64 != null)
		{
			return list;
		}
		object obj65 = addedClipsList + 18;
		if ((nint)obj65 != 7)
		{
			return null;
		}
		object obj66 = this + 84;
		object obj67 = obj66;
		if (obj36 != null)
		{
			obj36 = 0;
			_ = 0;
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5765");
		List<string> list8 = default;
		if (list8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @57FA");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+12]");
			obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			addedClipsList._items = (AnimationClip[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			addedClipsList._version = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @58F9");
			object obj68 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v32+9C]");
			object obj69 = (nint)0 + (nint)4;
			object obj70 = obj69 | 1;
			obj69 = obj70;
		}
		return list8;
	}

	private void AddClipsToAnimationComp(Animation animation, AnimationClip clip, List<AnimationClip> addedClipsList)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected Obj, but got Unknown
		//IL_0a6b: Expected Obj, but got I4
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected Obj, but got Unknown
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Expected Obj, but got Unknown
		//IL_0ae1: Expected I, but got Obj
		//IL_0af7: Expected Obj, but got I
		//IL_0b26: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_01a2: Expected I, but got Obj
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_02c0: Expected I, but got Obj
		//IL_070e: Expected Obj, but got I
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected Obj, but got Unknown
		//IL_08fd: Expected I, but got Obj
		//IL_0913: Expected Obj, but got I
		//IL_0c05: Expected Obj, but got I
		//IL_0821: Expected I, but got Obj
		//IL_0837: Expected Obj, but got I
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_093e: Expected I, but got Obj
		//IL_0bd1: Expected Obj, but got I
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected Obj, but got Unknown
		//IL_09c2: Expected Obj, but got I
		//IL_09d4: Expected I, but got Obj
		//IL_09ea: Expected Obj, but got I
		//IL_0862: Expected I, but got Obj
		//IL_0c3d: Expected Obj, but got I4
		//IL_0c4a: Expected I4, but got Obj
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_08e6: Expected Obj, but got I
		//IL_0a15: Expected I, but got Obj
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_0686: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Renderer> list = default;
		list._002Ector();
		object obj5 = defaultHoverboardAnimation + 16;
		object obj6 = (object)animation << 2;
		object obj7 = obj5 + obj6;
		object obj8 = obj7;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v149 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+10]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			object obj10 = defaultHoverboardAnimation + 16;
			object obj11 = (object)animation << 2;
			object obj12 = obj10 + obj11;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v146+10]");
			HoverboardBundle hoverboardBundle = ((HoverboardModelFactory)this).RequestHoverboardInstance((string)0);
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S3_v14 (Il2CppMethodInfo)+18]");
			object obj14 = 0;
			object obj15 = obj14;
			object obj16 = obj15 & 0x1FFF;
			object obj17 = obj16 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v94 @ S4_v5 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj18 = default;
		object obj20 = default;
		object obj23 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj18 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v164 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj20 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			if ((object)clip == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num6 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v126 (Il2CppClass<Layers>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num7 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v140 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			object obj22 = obj23 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj24 = 36;
		object obj25 = obj24 - 13;
		if ((nint)obj24 != 13 && (nint)obj25 != 1)
		{
			if ((nint)obj25 != 2 && (nint)obj25 != 3)
			{
				if ((nint)obj25 == 4)
				{
					goto IL_068b;
				}
				if ((nint)obj25 != 5 && (nint)obj25 != 6 && (nint)obj25 != 7)
				{
					if ((nint)obj25 == 8 || (nint)obj25 == 9)
					{
						goto IL_068b;
					}
					if ((nint)obj25 != 10 && (nint)obj25 != 11 && (nint)obj25 != 12 && (nint)obj25 != 13)
					{
						if ((nint)obj25 == 14)
						{
							goto IL_068b;
						}
						if ((nint)obj25 != 15 && (nint)obj25 != 16 && (nint)obj25 != 17 && (nint)obj25 != 18 && (nint)obj25 != 19)
						{
							if ((nint)obj25 == 20 || (nint)obj25 == 21 || (nint)obj25 == 22)
							{
								goto IL_068b;
							}
							if ((nint)obj25 == 23)
							{
								object obj26 = obj4 + 4;
								object obj27 = obj26 + 1;
								obj26 = obj27;
								object obj28 = obj27 << 2;
								object obj29 = obj4 + obj28;
								obj29 = 149;
							}
						}
					}
				}
			}
			goto IL_0c54;
		}
		goto IL_068b;
		IL_068b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj30 = default;
		object obj31 = default;
		if (obj30 == obj31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0c54;
		IL_0c79:
		if (addedClipsList == null)
		{
			return;
		}
		object obj32 = defaultHoverboardAnimation + 16;
		object obj33 = (object)animation << 2;
		object obj34 = obj32 + obj33;
		object obj35 = obj34;
		if ((object)clip == null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v81 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v54+14]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				object obj37 = defaultHoverboardAnimation + 16;
				object obj38 = (object)animation << 2;
				object obj39 = obj37 + obj38;
				object obj40 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S1_v79+14]");
				HoverboardBundle hoverboardBundle2 = ((HoverboardModelFactory)this).RequestHoverboardInstance((string)0);
			}
			return;
		}
		nint num10 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v54+18]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			return;
		}
		object obj42 = defaultHoverboardAnimation + 16;
		object obj43 = (object)animation << 2;
		object obj44 = obj42 + obj43;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S1_v50+18]");
		HoverboardBundle hoverboardBundle3 = ((HoverboardModelFactory)this).RequestHoverboardInstance((string)0);
		nint num12 = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S1_v53 (Il2CppClass<Layers>)+BA]");
		object obj46 = (nint)0 & (nint)0x200;
		if (obj46 != null)
		{
			nint num13 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S1_v61 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool startupFinished = LoadLevelCtrl.StartupFinished;
		object obj47 = (startupFinished ? 1 : 0) - -64;
		((GameObject)(object)hoverboardBundle3).SetActive((byte)(int)obj47 != 0);
		return;
		IL_0c54:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj48 = (nint)0 << 2;
			object obj49 = obj4 + obj48;
			if ((nint)obj49 == 149)
			{
				object obj50 = obj4 + 4;
				if ((nint)obj50 > -1)
				{
					object obj51 = obj50 + -1;
					obj50 = obj51;
				}
				goto IL_0c79;
			}
		}
		object obj52 = default;
		if (obj52 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0c79;
	}

	public HoverboardRendering()
	{
		((Validator<>)(object)this)._002Ector();
	}
}
