using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class KeyframeBehaviour : MonoBehaviour
{
	private Animation TargetAnimation;

	public ParticleSystem[] TargetObjects;

	public List<KeyFrameAction> Actions;

	public void Initialize()
	{
	}

	private void DoKeyframeAnimation(int soundIndex)
	{
		//IL_00f5: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00a6: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (KeyframeBehaviour)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+C]");
		if ((nint)0 <= (nint)soundIndex)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (KeyframeBehaviour)+18]");
		KeyFrameAudio keyFrameAudio = ((List<KeyFrameAudio>)0).get_Item(soundIndex);
		if (keyFrameAudio.Callback != null)
		{
			keyFrameAudio.Callback.EndInvoke((IAsyncResult)keyFrameAudio);
			return;
		}
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17 (Il2CppClass<So>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)keyFrameAudio.Audio, false);
	}

	public unsafe KeyframeBehaviour()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected Obj, but got Unknown
		//IL_07be: Expected Obj, but got I4
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected Obj, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_080b: Expected Obj, but got I
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected Obj, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_06fd: Expected Obj, but got I
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected Obj, but got Unknown
		//IL_089f: Expected I, but got Obj
		//IL_08b5: Expected Obj, but got I
		//IL_08fb: Expected I4, but got Obj
		//IL_08fb: Expected Obj, but got I4
		//IL_0904: Expected Obj, but got I4
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected Obj, but got Unknown
		//IL_025c: Expected I, but got Obj
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_0675: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		object obj5 = this + 12;
		string text = tag;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v112 @ S4_v7 (should have been resolved before IL gen)");
		object obj10 = default;
		obj5 = obj10;
		string text2 = TargetAnimation.tag;
		AnimationEventBroadcaster component = ((GameObject)(object)text2).GetComponent<AnimationEventBroadcaster>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		AnimationEventBroadcaster.SendDoKeyframeAnimationDelegate sendDoKeyframeAnimationDelegate = default;
		((Delegate)sendDoKeyframeAnimationDelegate).method_ptr = method_ptr;
		((Delegate)sendDoKeyframeAnimationDelegate).method = (nint)__ldftn(KeyframeBehaviour.DoKeyframeAnimation);
		object obj11 = sendDoKeyframeAnimationDelegate + 16;
		obj11 = this;
		component.SendDoKeyframeAnimation -= sendDoKeyframeAnimationDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj16 = default;
		object obj18 = default;
		object obj21 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj12 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v79+C]");
					object obj15 = 0 / obj16;
				}
				object obj17 = obj18 + 12;
				obj17 = "DoKeyframeAnimation";
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v130 (Il2CppClass<Globals>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num3 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v140 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				((KeyframeBehaviour)130).DoKeyframeAnimation((int)TargetAnimation);
				obj9 = 0;
			}
			object obj20 = obj21 + 1;
		}
		object obj22 = 35;
		object obj23 = obj22 - 8;
		if ((nint)obj22 != 8 && (nint)obj23 != 1 && (nint)obj23 != 2)
		{
			if ((nint)obj23 != 3 && (nint)obj23 != 4 && (nint)obj23 != 5 && (nint)obj23 != 6 && (nint)obj23 != 7)
			{
				if ((nint)obj23 == 8 || (nint)obj23 == 9 || (nint)obj23 == 10)
				{
					goto IL_067a;
				}
				if ((nint)obj23 != 11 && (nint)obj23 != 12 && (nint)obj23 != 13 && (nint)obj23 != 14 && (nint)obj23 != 15 && (nint)obj23 != 16 && (nint)obj23 != 17)
				{
					if ((nint)obj23 == 18 || (nint)obj23 == 19 || (nint)obj23 == 20 || (nint)obj23 == 21)
					{
						goto IL_067a;
					}
					if ((nint)obj23 != 22 && (nint)obj23 != 23 && (nint)obj23 != 24 && (nint)obj23 != 25)
					{
						if ((nint)obj23 == 26)
						{
							goto IL_067a;
						}
						if ((nint)obj23 == 27)
						{
							object obj24 = obj4 + 4;
							object obj25 = obj24 + 1;
							obj24 = obj25;
							object obj26 = obj25 << 2;
							object obj27 = obj4 + obj26;
							obj27 = 250;
						}
					}
				}
			}
			goto IL_0909;
		}
		goto IL_067a;
		IL_067a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj28 = default;
		object obj29 = default;
		if (obj28 == obj29)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0909;
		IL_0909:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj30 = (nint)0 << 2;
			object obj31 = obj4 + obj30;
			if ((nint)obj31 == 250)
			{
				object obj32 = obj4 + 4;
				if ((nint)obj32 > -1)
				{
					object obj33 = obj32 + -1;
					obj32 = obj33;
				}
				return;
			}
		}
		object obj34 = default;
		if (obj34 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
