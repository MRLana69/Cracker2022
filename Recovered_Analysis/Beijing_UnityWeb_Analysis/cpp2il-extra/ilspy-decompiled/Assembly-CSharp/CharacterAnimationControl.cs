using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterAnimationControl : MonoBehaviour
{
	private AnimationClip _runAnimation;

	private AnimationClip[] _alternateRunAnimations;

	private Animation _animationComponent;

	private AnimationClip _currentAnimation;

	public AnimationClip[] AlternateRunAnimations
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterAnimationControl)+24]");
			return (AnimationClip[])0;
		}
	}

	public void Play()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		CancelInvoke();
	}

	public void Speed(float speed)
	{
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_runAnimation != null)
		{
			object obj2 = this + 12;
			Camera component = GetComponent<Camera>();
			obj2 = component;
		}
		object obj3 = _alternateRunAnimations + 16;
		bool flag = ((MonoBehaviour)(object)"TransparentFX").IsInvoking();
		object obj4 = (flag ? 1u : 0u) << 2;
		object obj5 = obj3 + obj4;
		obj5 = speed;
		Color backgroundColor = ((Camera)(object)_alternateRunAnimations).backgroundColor;
	}

	public CharacterAnimationControl()
	{
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0313: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I4
		//IL_0383: Expected VT, but got Obj
		//IL_0395: Expected I, but got Obj
		//IL_03ab: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_03d1: Expected Obj, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01b5: Expected I, but got Obj
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0218: Expected I4, but got Obj
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		string text = tag;
		CharacterModel componentInParent = ((GameObject)(object)text).GetComponentInParent<CharacterModel>();
		object obj = this + 24;
		obj = _runAnimation;
		CharacterRig characterRig = componentInParent._characterRig;
		CharacterCustomization characterCustomization = characterRig.characterCustomization;
		CharacterCustomizationBundle characterCustomizationBundle = characterCustomization._characterCustomizationBundle;
		CharacterCustomizationBundle.OutfitInfo outfit = characterCustomizationBundle._outfit;
		CharacterCustomizationBundle.AnimationEnumString highscoreAnimationName = outfit.HighscoreAnimationName;
		string value = highscoreAnimationName.Value;
		if (highscoreAnimationName.Value != null && value.m_stringLength != 0)
		{
			object obj2 = _alternateRunAnimations + 12;
			object obj3 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj4 = _alternateRunAnimations + 16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				UnityEngine.Object a = UnityEngine.Object.Instantiate((UnityEngine.Object)obj6);
				if (!string.Equals((string)(object)a, highscoreAnimationName.Value))
				{
					object obj7 = obj3 + 1;
					obj3 = obj7;
					continue;
				}
				object obj8 = this + 24;
				obj8 = obj6;
				break;
			}
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_animationComponent != null)
		{
			object obj10 = this + 20;
			string text2 = tag;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S3_v6 (Il2CppMethodInfo)+18]");
			object obj11 = 0;
			object obj12 = obj11;
			object obj13 = obj12 & 0x1FFF;
			object obj14 = obj13 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v121 @ S4_v5 (should have been resolved before IL gen)");
			object obj15 = default;
			obj10 = obj15;
		}
		UnityEngine.Object obj16 = UnityEngine.Object.Instantiate((UnityEngine.Object)_currentAnimation);
		CollisionFlags collisionFlags = ((CharacterController)(object)_animationComponent).Move((Vector3)obj16);
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)collisionFlags))
		{
			UnityEngine.Object obj18 = UnityEngine.Object.Instantiate((UnityEngine.Object)_currentAnimation);
			((AnimationState)(object)_animationComponent).AddMixingTransform((Transform)(object)_currentAnimation, (byte)(int)obj18 != 0);
		}
		UnityEngine.Object animation = UnityEngine.Object.Instantiate((UnityEngine.Object)_currentAnimation);
		AnimationState animationState = _animationComponent.CrossFadeQueued((string)(object)animation);
	}
}
