using System;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public abstract class InGameState : State
{
	protected const float CharacterChangeTrackLength = 30f;

	protected Game _game;

	protected Character _character;

	protected CharacterCamera _characterCamera;

	public InGameState(int id)
	{
		//IL_009f: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00f2: Expected F4, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01b6: Expected VT, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008e: Expected F4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.InGameState)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4+14]");
		object obj2 = num - 0;
		float num2 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+8]");
		float num3 = num2 * 0f;
		Game game = _game;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+8]");
		game.__currentSpeed = 0f;
		object obj3 = _character + 236;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11+8]");
		_ = 0;
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this - -64;
		float num6 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float num7 = num6 + 0f;
		float f = num7 / 180f;
		int num8 = Mathf.FloorToInt(f);
		object obj7 = num8 * 180;
		obj6 = obj7;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object value = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		RouteBuilder routeBuilder = default;
		routeBuilder.OnCompletedLayingSections += (EventHandler)value;
		object obj8 = this - -64;
		((PogostickState)this).SpawnPickup((float)obj8);
	}

	public override void OnUpdate()
	{
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_02a1: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0158: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01e6: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		CharacterCamera characterCamera = _characterCamera;
		float orthographicSize = characterCamera._camera.orthographicSize;
		_ = 0f;
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<Hoverboard>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v68 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			nint num3 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v55 (Il2CppClass<Hoverboard>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v64 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier2 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v60 (CharacterModifier)+22]");
			if ((nint)0 != 0)
			{
				Game game = _game;
				float num5 = 68f + game.highSpeedFOVIncrease;
				goto IL_0330;
			}
		}
		nint num6 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v28 (Il2CppClass<Hoverboard>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v50 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier3 = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v33 (CharacterModifier)+54]");
		if ((nint)0 != 0)
		{
			nint num8 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v38 (Il2CppClass<Hoverboard>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num9 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v46 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier4 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v43 (CharacterModifier)+23]");
			if ((nint)0 != 0)
			{
				Game game2 = _game;
				float num10 = 68f + game2.speedFOVIncrease;
				goto IL_0330;
			}
		}
		_ = 68f;
		goto IL_0330;
		IL_0330:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.InGameState)+78]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		object obj9 = default;
		object obj8 = obj9 + 16;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		YieldInstruction[] list = default;
		Coroutine coroutine = CoroutineUtil.WaitForAll(list);
	}

	public virtual void HandleSwipe(SwipeDir swipeDir)
	{
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		Id = (int)swipeDir;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v26 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		bool isInstantiated = Game.IsInstantiated;
		obj2 = isInstantiated;
		object obj3 = this + 16;
		Game game = _game;
		obj3 = game._character;
		nint num3 = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v16 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 20;
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		obj5 = selectedBenchmarkIndex;
	}

	public virtual void HandleCriticalHit()
	{
		_game.DeactivateHighSpeed();
	}

	public virtual void HandleDoubleTap()
	{
	}
}
