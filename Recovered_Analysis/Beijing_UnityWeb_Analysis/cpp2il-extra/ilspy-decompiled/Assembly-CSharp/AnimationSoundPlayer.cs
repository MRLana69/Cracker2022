using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Monetization.FlurryPlugin;
using UnityEngine;

public class AnimationSoundPlayer : MonoBehaviour
{
	public Animation TargetAnimation;

	public List<KeyFrameAudio> AudioClips;

	private static List<string> nodesInitialized;

	private int nextAudioClipIndex;

	private List<KeyFrameAudio> AudioClipsInitialized;

	private void Start()
	{
		CancelInvoke();
	}

	public void Add(KeyFrameAudio key)
	{
		if (nextAudioClipIndex != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	public unsafe virtual void PlayKeyframeAnimation(int soundIndex)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I4
		//IL_0145: Expected I, but got F4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0171: Expected I, but got Obj
		//IL_0187: Expected Obj, but got I
		//IL_029f: Expected I4, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_01b2: Expected I, but got Obj
		//IL_021a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Animation animation = default;
		animation.Stop();
		_ = 0;
		Animation targetAnimation = TargetAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [soundIndex @ L1 (System.Int32)+8]");
		bool flag = targetAnimation.Play(PlayMode.StopSameLayer);
		if (!((TrackedReference)flag).Equals(null))
		{
			return;
		}
		Animation targetAnimation2 = TargetAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [soundIndex @ L1 (System.Int32)+8]");
		bool flag2 = targetAnimation2.Play(PlayMode.StopSameLayer);
		string text = ((AnimationState)flag2).name;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)text).FindKernel((string)null) == 0)
		{
			return;
		}
		Animation targetAnimation3 = TargetAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [soundIndex @ L1 (System.Int32)+8]");
		bool flag3 = targetAnimation3.Play(PlayMode.StopSameLayer);
		string text2 = ((AnimationState)flag3).name;
		float normalizedTime = ((AnimatorStateInfo*)text2)->normalizedTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [soundIndex @ L1 (System.Int32)+C]");
		float num3 = 0f / normalizedTime;
		((UnityEngine.Object)animation).m_CachedPtr = (IntPtr)num3;
		_ = nextAudioClipIndex;
		object obj2 = animation + 12;
		obj2 = "PlayKeyframeAnimation";
		nint num4 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S2_v13 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Animation targetAnimation4 = TargetAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [soundIndex @ L1 (System.Int32)+8]");
		if (((SocialManager)(object)targetAnimation4).CashIn((Friend)0, (int)animation) != 0)
		{
			int num6 = nextAudioClipIndex + 1;
			nextAudioClipIndex = num6;
			AudioClipsInitialized.Add((KeyFrameAudio)soundIndex);
		}
	}

	public AnimationSoundPlayer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02c4: Expected Obj, but got I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02f4: Expected I, but got Obj
		//IL_030a: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_03de: Expected Obj, but got I
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(AnimationSoundPlayer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<AnimationSoundPlayer>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(AnimationSoundPlayer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v106 (Il2CppClass<AnimationSoundPlayer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<string> list = nodesInitialized;
		UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v3+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v4+8C]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v81 @ S5_v4 (should have been resolved before IL gen)");
		object obj12 = default;
		if ((nint)obj12 != -1)
		{
			return;
		}
		nint num4 = (nint)typeof(AnimationSoundPlayer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v34 (Il2CppClass<AnimationSoundPlayer>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num5 = (nint)typeof(AnimationSoundPlayer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v100 (Il2CppClass<AnimationSoundPlayer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object item = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		nodesInitialized.Add((string)(object)item);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj14 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj14 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj15 = obj4 + 4;
		object obj16 = obj15 + 1;
		obj15 = obj16;
		object obj17 = obj16 << 2;
		object obj18 = obj4 + obj17;
		obj18 = 90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 90)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				return;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	static AnimationSoundPlayer()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AssetBundleVersionControl.DEFAULT_BUNDLES_VERSION = Globals.DEFAULT_BUNDLES_VERSION;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		nint num3 = (nint)typeof(AssetBundleVersionControl);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17 (Il2CppClass<AssetBundleVersionControl>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = text;
	}
}
