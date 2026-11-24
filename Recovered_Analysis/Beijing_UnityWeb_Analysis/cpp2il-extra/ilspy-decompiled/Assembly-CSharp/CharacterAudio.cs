using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
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

	private Game game;

	private Dictionary<Character.StumbleType, AudioClipInfo> stumbleClips;

	public void Awake()
	{
		//IL_0010: Expected Obj, but got F4
		//IL_001b: Expected Obj, but got F4
		//IL_0026: Expected Obj, but got F4
		//IL_0031: Expected Obj, but got F4
		//IL_003c: Expected Obj, but got F4
		//IL_0047: Expected Obj, but got F4
		//IL_0052: Expected Obj, but got F4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got F4
		//IL_0071: Expected Obj, but got F4
		//IL_007c: Expected Obj, but got F4
		StumbleSound = (AudioClipInfo)0.3f;
		StumbleBushSound = (AudioClipInfo)0.3f;
		PowerupSound = (AudioClipInfo)0.4f;
		PowerdownSound = (AudioClipInfo)0.8f;
		TurboHeadstartSound = (AudioClipInfo[])1.1f;
		DodgeRight = (AudioClipInfo)0.4f;
		TeleboardDodgeRight = (AudioClipInfo)0.8f;
		object obj = this - -64;
		obj = 1.1f;
		audioStateLoop = (AudioStateLoop)1f;
		stumbleClips = (Dictionary<Character.StumbleType, AudioClipInfo>)1f;
		_ = 1f;
		_ = 1f;
		_ = 1f;
		_ = 1f;
		_ = 2f;
		_ = 0.5f;
		_ = 3f;
		_ = 4f;
		((Validator<>)(object)this)._002Ector();
	}

	private void HandleOnScoreBoostActivated(int scoreboosterTier)
	{
		//IL_0009: Expected Obj, but got I4
		((AudioSource)scoreboosterTier).Pause();
	}

	private void HandleOnTurboHeadstartInput(int version)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int num = version << 2;
		object obj = ScooreBoosterSound + num;
		object obj2 = obj + 12;
		nint num2 = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<So>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v19 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)obj2, false);
	}

	private void HandleOnChangeTrack(Character.OnChangeTrackDirection direction)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj = TurboHeadstartSound + 16;
		object obj2 = (int)direction << 2;
		object obj3 = obj + obj2;
		if (obj3 == null)
		{
			return;
		}
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<So>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)obj3, false);
	}

	private void HandleOnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
	}

	private unsafe void JetpackOnStart()
	{
		//IL_0782: Expected I, but got Obj
		//IL_0798: Expected Obj, but got I
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0281: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected Obj, but got Unknown
		//IL_07d1: Expected Obj, but got I4
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_030f: Expected I, but got Obj
		//IL_0325: Expected Obj, but got I
		//IL_02c2: Expected I, but got Obj
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_0350: Expected I, but got Obj
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected Obj, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_06a7: Expected I, but got Obj
		//IL_06bd: Expected Obj, but got I
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0846: Expected Obj, but got I4
		//IL_084a: Expected VT, but got Obj
		//IL_0852: Expected Obj, but got VT
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_088b: Expected I, but got Obj
		//IL_08a1: Expected Obj, but got I
		//IL_06e8: Expected I, but got Obj
		//IL_0735: Expected I, but got Obj
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Hoverboard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v150 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this - -64;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		obj2 = characterModifier;
		object obj3 = this + 68;
		Character component = GetComponent<Character>();
		obj3 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
		((Delegate)onChangeTrackDelegate).method_ptr = method_ptr;
		((Delegate)onChangeTrackDelegate).method = (nint)__ldftn(CharacterAudio.HandleOnChangeTrack);
		object obj4 = onChangeTrackDelegate + 16;
		obj4 = this;
		character.OnChangeTrack -= onChangeTrackDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		((Delegate)onStumbleDelegate).method_ptr = method_ptr2;
		((Delegate)onStumbleDelegate).method = (nint)__ldftn(CharacterAudio.HandleOnStumble);
		object obj5 = onStumbleDelegate + 16;
		obj5 = this;
		character.OnStumble -= onStumbleDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v93 @ S4_v4 (should have been resolved before IL gen)");
		object obj11 = this + 80;
		object obj12 = default;
		obj11 = obj12;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S4_v7+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v8+48]");
		object obj15 = 0;
		object obj16 = obj15 & 0x7FF;
		object obj17 = obj16 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v116 @ S5_v6 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S4_v12+60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v13+48]");
		object obj20 = 0;
		object obj21 = obj20 & 0x7FF;
		object obj22 = obj21 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v135 @ S5_v10 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S4_v17+60]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S4_v18+48]");
		object obj25 = 0;
		object obj26 = obj25 & 0x7FF;
		object obj27 = obj26 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v154 @ S5_v14 (should have been resolved before IL gen)");
		nint num7 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v33 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num8 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v146 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj29 = this + 76;
		bool isInstantiated = Game.IsInstantiated;
		obj29 = isInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<int> action = default;
		object obj30 = action + 16;
		obj30 = this;
		game.OnTurboHeadstartInput -= action;
		nint num10 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v42 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num11 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v142 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Delegate obj32 = default;
		obj32.method_ptr = method_ptr3;
		obj32.method = (nint)__ldftn(CharacterAudio.JetpackOnStart);
		object obj33 = obj32 + 16;
		obj33 = this;
		object obj34 = ex + 28;
		Delegate obj35 = ((Delegate)((Exception)ex)._stackTrace).CombineImpl(obj32);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj36 = default;
		obj34 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Delegate obj37 = default;
		obj37.method_ptr = method_ptr4;
		obj37.method = (nint)__ldftn(CharacterAudio.JetpackOnStop);
		object obj38 = obj37 + 16;
		obj38 = this;
		object obj39 = ex + 32;
		Delegate obj40 = ((Delegate)(object)((Exception)ex)._stackTraceString).CombineImpl(obj37);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj41 = default;
		obj39 = obj41;
		bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex2 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Delegate obj42 = default;
		obj42.method_ptr = method_ptr5;
		obj42.method = (nint)__ldftn(CharacterAudio.JetpackOnStart);
		object obj43 = obj42 + 16;
		obj43 = this;
		object obj44 = ex2 + 28;
		Delegate obj45 = ((Delegate)((Exception)ex2)._stackTrace).CombineImpl(obj42);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj46 = default;
		obj44 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Delegate obj47 = default;
		obj47.method_ptr = method_ptr6;
		obj47.method = (nint)__ldftn(CharacterAudio.JetpackOnStop);
		object obj48 = obj47 + 16;
		obj48 = this;
		object obj49 = ex2 + 32;
		Delegate obj50 = ((Delegate)(object)((Exception)ex2)._stackTraceString).CombineImpl(obj47);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj51 = default;
		obj49 = obj51;
		bool useBenchmarkRoute3 = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex3 = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr7 = 0;
		Delegate obj52 = default;
		obj52.method_ptr = method_ptr7;
		obj52.method = (nint)__ldftn(CharacterAudio.JetpackOnStart);
		object obj53 = obj52 + 16;
		obj53 = this;
		object obj54 = ex3 + 36;
		Delegate obj55 = ((Delegate)(object)((Exception)ex3)._remoteStackTraceString).CombineImpl(obj52);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj56 = default;
		obj54 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr8 = 0;
		Delegate obj57 = default;
		obj57.method_ptr = method_ptr8;
		obj57.method = (nint)__ldftn(CharacterAudio.PogostickStop);
		object obj58 = obj57 + 16;
		obj58 = this;
		object obj59 = ex3 + 44;
		Delegate obj60 = ((Delegate)((Exception)ex3)._dynamicMethods).CombineImpl(obj57);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj61 = default;
		obj59 = obj61;
		nint num12 = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v113 (Il2CppClass<Utils>)+BA]");
		object obj62 = (nint)0 & (nint)0x200;
		if (obj62 != null)
		{
			nint num13 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v138 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj63 = this + 72;
		_0021_00210 val = (_0021_00210)Utils.FindComponentInThisOrParents<T>((MonoBehaviour)1);
		obj63 = val;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num14 = 0;
		_ = 0;
		Action<int> action2 = default;
		object obj64 = action2 + 16;
		obj64 = this;
		nint num15 = (nint)typeof(SlideinPowerupHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v129 (Il2CppClass<SlideinPowerupHelper>)+BA]");
		object obj65 = (nint)0 & (nint)0x200;
		if (obj65 != null)
		{
			nint num16 = (nint)typeof(SlideinPowerupHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v134 (Il2CppClass<SlideinPowerupHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SlideinPowerupHelper.OnScoreBoostActivated -= action2;
	}

	private void JetpackOnStop()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)PowerupSound, false);
		audioStateLoop.PlayLoop((AudioSource)2);
	}

	private void PogostickStop()
	{
		//IL_0062: Expected Obj, but got I4
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		audioStateLoop.PlayLoop((AudioSource)3);
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v16 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)PowerdownSound, false);
	}

	public CharacterAudio()
	{
		PogostickStop();
	}
}
