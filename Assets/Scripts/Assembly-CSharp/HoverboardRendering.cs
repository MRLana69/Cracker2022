using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
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

		public AnimationPair[] jumpAnimations;

		public AnimationPair[] hangtimeAnimations;

		public AnimationPair[] rollAnimations;

		public AnimationPair[] dodgeLeftAnimations;

		public AnimationPair[] dodgeRightAnimations;

		public AnimationPair[] grindAnimations;

		public AnimationPair[] grindLandAnimations;

		public AnimationPair[] getOnBoardAnimations;
	}

	[Serializable]
	public class AnimationStringPair
	{
		public string characterAnimation = string.Empty;

		public string hoverboardAnimation = string.Empty;
	}

	[Serializable]
	public class AnimationPair
	{
		public AnimationClip characterAnimationClip;

		public AnimationClip hoverboardAnimationClip;
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
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		//IL_067b: Expected Obj, but got I4
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected Obj, but got Unknown
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected Obj, but got Unknown
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected Obj, but got Unknown
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		//IL_0d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7a: Expected Obj, but got Unknown
		//IL_0d84: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected Obj, but got Unknown
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected Obj, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected Obj, but got Unknown
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected Obj, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected Obj, but got Unknown
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected Obj, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aec: Expected Obj, but got Unknown
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected Obj, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected Obj, but got Unknown
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5d: Expected Obj, but got Unknown
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected Obj, but got Unknown
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_0c3e: Expected Obj, but got I4
		//IL_0c83: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_0cc8: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_0524: Expected Obj, but got I
		//IL_0543: Expected Obj, but got I
		//IL_059c: Expected Obj, but got I
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		CharacterRendering instance = CharacterRendering.Instance;
		AnimationPair[] array = jumpAnimations;
		AnimationPair[] array2 = hangtimeAnimations;
		if (array.Length != array2.Length)
		{
		}
		object obj = this + 28;
		object obj2 = this + 24;
		AbilityAnimationList[] array3 = abilityAnimationLists;
		bool flag = array3.Length >= 2;
		bool flag2 = !flag;
		object obj3 = array3.Length;
		AbilityAnimationList abilityAnimationList2 = default;
		AbilityAnimationList abilityAnimationList = abilityAnimationList2;
		if (!flag2)
		{
			object obj4 = default;
			object obj11 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				object obj5 = obj4 << 2;
				object obj6 = (object)array3 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v169+10]");
				AbilityAnimationList abilityAnimationList3 = (AbilityAnimationList)0;
				if (~(abilityAnimationList3.prio ? 1u : 0u) == 0)
				{
					object obj7 = 0;
					while ((nint)obj7 < abilities.Length)
					{
						object obj8 = obj7 << 2;
						object obj9 = (object)abilities + obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S2_v70+10]");
						bool flag3 = (nint)0 == (nint)abilityAnimationList3.ability;
						AbilityAnimationList abilityAnimationList4 = abilityAnimationList3;
						if (!flag3)
						{
							abilityAnimationList4 = abilityAnimationList;
						}
						object obj10 = obj7 + 1;
						obj7 = obj10;
						abilityAnimationList = abilityAnimationList4;
					}
				}
				AbilityAnimationList abilityAnimationList5 = abilityAnimationList;
				if (abilityAnimationList3.ability == Hoverboard.BoardAbility.None)
				{
					abilityAnimationList5 = abilityAnimationList3;
				}
				obj4 = obj11 + 1;
				obj3 = array3.Length;
				abilityAnimationList = abilityAnimationList5;
			}
		}
		else
		{
			bool flag4 = array3.Length != 1;
			abilityAnimationList = abilityAnimationList2;
			if (!flag4)
			{
				object obj12 = 0;
				abilityAnimationList = abilityAnimationList2;
				while ((nint)obj12 < abilities.Length)
				{
					object obj13 = obj12 << 2;
					object obj14 = (object)abilities + obj13;
					AbilityAnimationList[] array4 = abilityAnimationLists;
					AbilityAnimationList abilityAnimationList6 = array4[0];
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v156+10]");
					if ((nint)0 == (nint)abilityAnimationList6.ability)
					{
						AbilityAnimationList[] array5 = abilityAnimationLists;
						abilityAnimationList = array5[0];
					}
					object obj15 = obj12 + 1;
					obj12 = obj15;
				}
			}
		}
		CharacterRendering.Animations animations = instance.animations;
		object pairs = this + 16;
		object obj16 = defaultAbilityAnimationLists + 20;
		AnimationPair[] array6 = runAnimations;
		if (array6.Length == 0)
		{
			pairs = obj16;
		}
		List<string> namesAddAnimationClips = GetNamesAddAnimationClips(abilityAnimationList.runAnimations, (AnimationPair[])pairs, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations.RUN = namesAddAnimationClips;
		CharacterRendering.Animations animations2 = instance.animations;
		object obj17 = this + 20;
		object obj18 = defaultAbilityAnimationLists + 24;
		AnimationPair[] array7 = landAnimations;
		object pairs2 = obj17;
		if (array7.Length == 0)
		{
			pairs2 = obj18;
		}
		List<string> namesAddAnimationClips2 = GetNamesAddAnimationClips(abilityAnimationList.landAnimations, (AnimationPair[])pairs2, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations2.LAND = namesAddAnimationClips2;
		CharacterRendering.Animations animations3 = instance.animations;
		AnimationPair[] array8 = landAnimations;
		object pairs3 = obj17;
		if (array8.Length == 0)
		{
			pairs3 = obj18;
		}
		List<string> namesAddAnimationClips3 = GetNamesAddAnimationClips(abilityAnimationList.landAnimations, (AnimationPair[])pairs3, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations3.BIG_LAND = namesAddAnimationClips3;
		CharacterRendering.Animations animations4 = instance.animations;
		AnimationPair[] array9 = landAnimations;
		object pairs4 = obj17;
		if (array9.Length == 0)
		{
			pairs4 = obj18;
		}
		List<string> namesAddAnimationClips4 = GetNamesAddAnimationClips(abilityAnimationList.landAnimations, (AnimationPair[])pairs4, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations4.SMALL_LAND = namesAddAnimationClips4;
		CharacterRendering.Animations animations5 = instance.animations;
		object obj19 = defaultAbilityAnimationLists + 28;
		AnimationPair[] array10 = jumpAnimations;
		object pairs5 = obj2;
		if (array10.Length == 0)
		{
			pairs5 = obj19;
		}
		List<string> namesAddAnimationClips5 = GetNamesAddAnimationClips(abilityAnimationList.jumpAnimations, (AnimationPair[])pairs5, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations5.JUMP = namesAddAnimationClips5;
		CharacterRendering.Animations animations6 = instance.animations;
		AnimationPair[] array11 = jumpAnimations;
		object pairs6 = obj2;
		if (array11.Length == 0)
		{
			pairs6 = obj19;
		}
		List<string> namesAddAnimationClips6 = GetNamesAddAnimationClips(abilityAnimationList.jumpAnimations, (AnimationPair[])pairs6, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations6.SMALL_JUMP = namesAddAnimationClips6;
		CharacterRendering.Animations animations7 = instance.animations;
		object obj20 = defaultAbilityAnimationLists + 32;
		AnimationPair[] array12 = hangtimeAnimations;
		object pairs7 = obj;
		if (array12.Length == 0)
		{
			pairs7 = obj20;
		}
		List<string> namesAddAnimationClips7 = GetNamesAddAnimationClips(abilityAnimationList.hangtimeAnimations, (AnimationPair[])pairs7, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations7.HANGTIME = namesAddAnimationClips7;
		CharacterRendering.Animations animations8 = instance.animations;
		object obj21 = this + 32;
		object obj22 = defaultAbilityAnimationLists + 36;
		AnimationPair[] array13 = rollAnimations;
		object pairs8 = obj21;
		if (array13.Length == 0)
		{
			pairs8 = obj22;
		}
		List<string> namesAddAnimationClips8 = GetNamesAddAnimationClips(abilityAnimationList.rollAnimations, (AnimationPair[])pairs8, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations8.ROLL = namesAddAnimationClips8;
		CharacterRendering.Animations animations9 = instance.animations;
		object pairs9 = this + 36;
		object obj23 = defaultAbilityAnimationLists + 40;
		AnimationPair[] array14 = dodgeLeftAnimations;
		if (array14.Length == 0)
		{
			pairs9 = obj23;
		}
		List<string> namesAddAnimationClips9 = GetNamesAddAnimationClips(abilityAnimationList.dodgeLeftAnimations, (AnimationPair[])pairs9, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations9.DODGE_LEFT = namesAddAnimationClips9;
		CharacterRendering.Animations animations10 = instance.animations;
		object pairs10 = this + 40;
		object obj24 = defaultAbilityAnimationLists + 44;
		AnimationPair[] array15 = dodgeRightAnimations;
		if (array15.Length == 0)
		{
			pairs10 = obj24;
		}
		List<string> namesAddAnimationClips10 = GetNamesAddAnimationClips(abilityAnimationList.dodgeRightAnimations, (AnimationPair[])pairs10, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations10.DODGE_RIGHT = namesAddAnimationClips10;
		CharacterRendering.Animations animations11 = instance.animations;
		object pairs11 = this + 44;
		object obj25 = defaultAbilityAnimationLists + 48;
		AnimationPair[] array16 = grindAnimations;
		if (array16.Length == 0)
		{
			pairs11 = obj25;
		}
		List<string> namesAddAnimationClips11 = GetNamesAddAnimationClips(abilityAnimationList.grindAnimations, (AnimationPair[])pairs11, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations11.GRIND = namesAddAnimationClips11;
		object pairs12 = this + 48;
		object obj26 = defaultAbilityAnimationLists + 52;
		AnimationPair[] array17 = grindLandAnimations;
		if (array17.Length == 0)
		{
			pairs12 = obj26;
		}
		List<string> namesAddAnimationClips12 = GetNamesAddAnimationClips(abilityAnimationList.grindLandAnimations, (AnimationPair[])pairs12, avatarAnimation, hoverboardAnimation, addedClipsList);
		CharacterRendering.Animations animations12 = instance.animations;
		object pairs13 = this + 52;
		object obj27 = defaultAbilityAnimationLists + 56;
		AnimationPair[] array18 = getOnBoardAnimations;
		if (array18.Length == 0)
		{
			pairs13 = obj27;
		}
		List<string> namesAddAnimationClips13 = GetNamesAddAnimationClips(abilityAnimationList.getOnBoardAnimations, (AnimationPair[])pairs13, avatarAnimation, hoverboardAnimation, addedClipsList);
		animations12.GET_ON_BOARD = namesAddAnimationClips13;
		if (hoverboardAnimation != null)
		{
			string newName = defaultHoverboardAnimation.name;
			hoverboardAnimation.AddClip(defaultHoverboardAnimation, newName);
		}
		if (defaultHoverboardAnimation != null)
		{
			CharacterRendering.Animations animations13 = instance.animations;
			string dEFAULT_HOVERBOARD_ANIMATION = defaultHoverboardAnimation.name;
			animations13.DEFAULT_HOVERBOARD_ANIMATION = dEFAULT_HOVERBOARD_ANIMATION;
		}
		if (hasInitializedAnimationSounds)
		{
			return;
		}
		object obj28 = abilityAnimationList + 36;
		object obj29 = abilityAnimationList + 24;
		hasInitializedAnimationSounds = true;
		RunnerAnimPlayer componentInChildren = instance.GetComponentInChildren<RunnerAnimPlayer>();
		componentInChildren.InitializeHoverboardClips();
		object obj30 = abilityAnimationList + 28;
		if (abilityAnimationList.jumpAnimations == null)
		{
			obj30 = obj2;
		}
		object obj31 = obj30;
		object obj32 = 0;
		KeyFrameAudio keyFrameAudio = default;
		KeyFrameAudio keyFrameAudio2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S0_v77+C]");
			if (0 <= (nint)obj32)
			{
				break;
			}
			object obj33 = obj32 << 2;
			object obj34 = obj31 + obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S0_v129+10]");
			object obj35 = 0;
			keyFrameAudio.KeyFrame = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S0_v130+8]");
			string clip = ((UnityEngine.Object)0).name;
			keyFrameAudio.clip = clip;
			keyFrameAudio.Audio = componentInChildren.h_kick;
			componentInChildren.Add(keyFrameAudio);
			keyFrameAudio2.KeyFrame = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S0_v130+8]");
			string clip2 = ((UnityEngine.Object)0).name;
			keyFrameAudio2.clip = clip2;
			keyFrameAudio2.Audio = componentInChildren.h_long;
			componentInChildren.Add(keyFrameAudio2);
			object obj36 = obj32 + 1;
			obj32 = obj36;
		}
		if (obj29 == null)
		{
			obj29 = obj17;
		}
		object obj37 = obj29;
		object obj38 = 0;
		KeyFrameAudio keyFrameAudio3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S0_v85+C]");
			if (0 <= (nint)obj38)
			{
				break;
			}
			object obj39 = obj38 << 2;
			object obj40 = obj37 + obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ S0_v117+10]");
			object obj41 = 0;
			keyFrameAudio3.KeyFrame = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v118+8]");
			string clip3 = ((UnityEngine.Object)0).name;
			keyFrameAudio3.clip = clip3;
			keyFrameAudio3.Audio = componentInChildren.h_kick;
			componentInChildren.Add(keyFrameAudio3);
			object obj42 = obj38 + 1;
			obj38 = obj42;
		}
		if (obj28 == null)
		{
			obj28 = obj21;
		}
		object obj43 = obj28;
		object obj44 = 0;
		KeyFrameAudio keyFrameAudio4 = default;
		KeyFrameAudio keyFrameAudio5 = default;
		while (true)
		{
			object obj45 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S0_v93+C]");
			if ((nint)obj45 < 0)
			{
				object obj46 = obj44 << 2;
				object obj47 = obj43 + obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ S0_v99+10]");
				object obj48 = 0;
				keyFrameAudio4.KeyFrame = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S0_v100+8]");
				string clip4 = ((UnityEngine.Object)0).name;
				keyFrameAudio4.clip = clip4;
				keyFrameAudio4.Audio = componentInChildren.h_roll;
				componentInChildren.Add(keyFrameAudio4);
				keyFrameAudio5.KeyFrame = 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S0_v100+8]");
				string clip5 = ((UnityEngine.Object)0).name;
				keyFrameAudio5.clip = clip5;
				keyFrameAudio5.Audio = componentInChildren.h_miniKick;
				componentInChildren.Add(keyFrameAudio5);
				object obj49 = obj44 + 1;
				obj44 = obj49;
				continue;
			}
			break;
		}
	}

	private List<string> GetNamesAddAnimationClips(AnimationPair[] abilityPairs, AnimationPair[] pairs, Animation avaterAnimation, Animation hoverboardAnimation, List<AnimationClip> addedClipsList)
	{
		//IL_0055: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I
		List<string> list = default;
		list._002Ector();
		AnimationPair[] array;
		if (abilityPairs != null)
		{
			array = abilityPairs;
			if (abilityPairs.Length != 0)
			{
				goto IL_01fa;
			}
		}
		array = pairs;
		goto IL_01fa;
		IL_01fa:
		HoverboardRendering hoverboardRendering = null;
		while (true)
		{
			if (array.Length > (nint)hoverboardRendering)
			{
				object obj = (object)hoverboardRendering << 2;
				object obj2 = (object)array + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v17+10]");
				object obj3 = 0;
				if (avaterAnimation != null)
				{
					HoverboardRendering hoverboardRendering2 = hoverboardRendering;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v18+8]");
					hoverboardRendering2.AddClipsToAnimationComp(avaterAnimation, (AnimationClip)0, addedClipsList);
				}
				if (hoverboardAnimation != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v18+C]");
					if ((UnityEngine.Object)0 != null)
					{
						HoverboardRendering hoverboardRendering3 = hoverboardRendering;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v18+C]");
						hoverboardRendering3.AddClipsToAnimationComp(hoverboardAnimation, (AnimationClip)0, null);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v18+8]");
				if (!((UnityEngine.Object)0 != null))
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v18+8]");
				string item = ((UnityEngine.Object)0).name;
				list.Add(item);
				HoverboardRendering hoverboardRendering4 = (HoverboardRendering)(hoverboardRendering + 1);
				hoverboardRendering = hoverboardRendering4;
				continue;
			}
			return list;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Exception ex = default;
		ex._002Ector("character cannot be null.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (List<string>)(object)ex;
	}

	private void AddClipsToAnimationComp(Animation animation, AnimationClip clip, List<AnimationClip> addedClipsList)
	{
		if (!(clip != null))
		{
			return;
		}
		if (addedClipsList != null)
		{
			if (addedClipsList.Contains(clip))
			{
				return;
			}
			addedClipsList.Add(clip);
		}
		string newName = clip.name;
		animation.AddClip(clip, newName);
	}
}
