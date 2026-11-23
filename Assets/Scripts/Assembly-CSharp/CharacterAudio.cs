using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Characters.States;
using UnityEngine;

public class CharacterAudio : MonoBehaviour
{
	private AudioClipInfo DodgeLeft;

	private AudioClipInfo TeleboardDodgeLeft;

	private AudioClipInfo H_Left;

	private AudioClipInfo H_Right;

	private AudioClipInfo StumbleSound;

	private AudioClipInfo StumbleBushSound;

	private AudioClipInfo StumbleSideSound;

	private AudioClipInfo PowerupSound;

	private AudioClipInfo PowerdownSound;

	private AudioClipInfo[] TurboHeadstartSound;

	private AudioClipInfo[] ScooreBoosterSound;

	public AudioClipInfo DodgeRight;

	public AudioClipInfo TeleboardDodgeRight;

	private Hoverboard hoverboard;

	private Character character;

	private AudioStateLoop audioStateLoop;

	private JetpackState _jetpackState;

	private PogoStickState _pogostickState;

	private Game game;

	private Dictionary<Character.StumbleType, AudioClipInfo> stumbleClips;

	public unsafe void Awake()
	{
		//IL_0096: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		Hoverboard instance = Hoverboard.Instance;
		hoverboard = instance;
		Character component = GetComponent<Character>();
		character = component;
		Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
		onChangeTrackDelegate._002Ector(this, (nint)__ldftn(CharacterAudio.HandleOnChangeTrack));
		character.OnChangeTrack += onChangeTrackDelegate;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		onStumbleDelegate._002Ector(this, (nint)__ldftn(CharacterAudio.HandleOnStumble));
		character.OnStumble += onStumbleDelegate;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Characters.Character+StumbleType, AudioClipInfo>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Character.StumbleType, AudioClipInfo> dictionary = default;
		stumbleClips = dictionary;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Characters.Character+StumbleType, AudioClipInfo>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Characters.Character+StumbleType, AudioClipInfo>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ S5_v9+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Characters.Character+StumbleType, AudioClipInfo>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S5_v14+4] (should have been resolved before IL gen)");
		Game instance2 = Game.Instance;
		game = instance2;
		throw new ArgumentException();
	}

	private void HandleOnScoreBoostActivated(int scoreboosterTier)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I
		object obj = scoreboosterTier - 1;
		object obj2 = obj << 2;
		object obj3 = (object)ScooreBoosterSound + obj2;
		So instance = So.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v4+10]");
		Sound sound = instance.playSound((AudioClipInfo)0);
	}

	private void HandleOnTurboHeadstartInput(int version)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got I
		int num = version << 2;
		object obj = TurboHeadstartSound + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+10]");
		if ((nint)0 != 0)
		{
			So instance = So.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+10]");
			Sound sound = instance.playSound((AudioClipInfo)0);
		}
	}

	private void HandleOnChangeTrack(Character.OnChangeTrackDirection direction)
	{
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		Hoverboard hoverboard = this.hoverboard;
		object audioClip;
		if (direction != Character.OnChangeTrackDirection.Left)
		{
			if (~(hoverboard.isActive ? 1u : 0u) != 0)
			{
				audioClip = this + 56;
			}
			else
			{
				audioClip = ((~(hoverboard.isTeleporter ? 1u : 0u) != 0 || game.IsInPogostickMode || game.IsInJetpackMode) ? ((object)(this + 24)) : ((object)(this + 60)));
			}
		}
		else if (~(hoverboard.isActive ? 1u : 0u) != 0)
		{
			audioClip = this + 12;
		}
		else
		{
			audioClip = ((~(hoverboard.isTeleporter ? 1u : 0u) != 0 || game.IsInPogostickMode || game.IsInJetpackMode) ? ((object)(this + 20)) : ((object)(this + 16)));
		}
		Sound sound = So.Instance.playSound((AudioClipInfo)audioClip);
	}

	private void HandleOnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		AudioClipInfo audioClip = stumbleClips.get_Item(stumbleType);
		Sound sound = So.Instance.playSound(audioClip);
	}

	private void JetpackOnStart()
	{
		JetpackOnStart(isHeadStart: false);
	}

	private void JetpackOnStart(bool isHeadStart)
	{
		if (!isHeadStart)
		{
			Sound sound = So.Instance.playSound(PowerupSound);
		}
		audioStateLoop.ChangeLoop(AudioState.Jetpack);
	}

	private void JetpackOnStop(bool isHeadstart)
	{
		audioStateLoop.ChangeLoop(AudioState.JetpackStop);
		Sound sound = So.Instance.playSound(PowerdownSound);
	}

	private void PogostickStop()
	{
		JetpackOnStop(isHeadstart: false);
	}
}
