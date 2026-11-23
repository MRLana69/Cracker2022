using System.Collections.Generic;
using Cpp2ILInjected;
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02c2: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<string> list = nodesInitialized;
		string text = name;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.List`1<System.String>>)+8C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S5_v4+4] (should have been resolved before IL gen)");
		object obj4 = default;
		if ((nint)obj4 != -1)
		{
			return;
		}
		string item = name;
		nodesInitialized.Add(item);
		object obj5 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			_ = 0;
			object obj7 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj8 == null)
				{
					goto IL_01df;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 != obj10;
			object obj11 = obj12;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_01df;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj11 = obj13;
			break;
			IL_01df:
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A029");
			return;
		}
		_ = 0;
		object obj15 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public void Add(KeyFrameAudio key)
	{
		AnimationEvent animationEvent = default;
		animationEvent._002Ector();
		animationEvent.m_MessageOptions = 0;
		AnimationState animationState = TargetAnimation.get_Item(key.clip);
		if (!(animationState != null))
		{
			return;
		}
		AnimationState animationState2 = TargetAnimation.get_Item(key.clip);
		AnimationClip clip = animationState2.clip;
		if (clip != null)
		{
			AnimationState animationState3 = TargetAnimation.get_Item(key.clip);
			AnimationClip clip2 = animationState3.clip;
			float frameRate = clip2.frameRate;
			float time = (float)key.KeyFrame / frameRate;
			animationEvent.m_Time = time;
			animationEvent.m_IntParameter = nextAudioClipIndex;
			animationEvent.m_FunctionName = "PlayKeyframeAnimation";
			if (Globals.TryAddAnimationEvent(TargetAnimation, key.clip, animationEvent))
			{
				int num = nextAudioClipIndex + 1;
				nextAudioClipIndex = num;
				AudioClipsInitialized.Add(key);
			}
		}
	}

	public virtual void PlayKeyframeAnimation(int soundIndex)
	{
		List<KeyFrameAudio> audioClipsInitialized = AudioClipsInitialized;
		if (soundIndex < audioClipsInitialized._size)
		{
			KeyFrameAudio keyFrameAudio = AudioClipsInitialized.get_Item(soundIndex);
			KeyFrameAudio.ExtraKeyframeCall callback = keyFrameAudio.Callback;
			if (keyFrameAudio.Callback != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			else
			{
				Sound sound = So.Instance.playSound(keyFrameAudio.Audio);
			}
		}
	}

	public AnimationSoundPlayer()
	{
		List<KeyFrameAudio> list = default;
		list._002Ector();
		AudioClipsInitialized = list;
		base._002Ector();
	}

	static AnimationSoundPlayer()
	{
		List<string> list = default;
		list._002Ector();
		nodesInitialized = list;
	}
}
