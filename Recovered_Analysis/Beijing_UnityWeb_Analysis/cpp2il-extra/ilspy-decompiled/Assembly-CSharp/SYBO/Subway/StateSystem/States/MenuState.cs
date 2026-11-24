using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;

namespace SYBO.Subway.StateSystem.States;

public class MenuState : State
{
	private Game _game;

	private Character _character;

	private FollowingGuard _followingGuard;

	public MenuState(int id)
	{
		//IL_001b: Expected Obj, but got I4
		((FlyingState)this).RegisterStartHandler((Action)id);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			SetMenuCamera();
		}
	}

	public override void Enter(State fromState)
	{
		//IL_00f6: Expected I4, but got Obj
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		Id = (int)fromState;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v35 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		bool isInstantiated = Game.IsInstantiated;
		obj2 = isInstantiated;
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v31 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 16;
		CharacterRendering instance = CharacterRendering.Instance;
		obj4 = instance;
		nint num5 = (nint)typeof(FollowingGuard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v21 (Il2CppClass<FollowingGuard>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(FollowingGuard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27 (Il2CppClass<FollowingGuard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 20;
		IEnumerator enumerator = HouseKeeper.InitAuthAndCloudSave();
		obj6 = enumerator;
	}

	private void SetMenuCamera()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0023: Expected Obj, but got I
		//IL_0039: Expected I4, but got Obj
		//IL_0039: Expected Obj, but got VT
		//IL_006f: Expected Obj, but got I
		int index = default;
		int num = default;
		while (true)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.MenuState)+7C]");
			Coin coin = ((List<Coin>)0).get_Item(index);
			if (((Character)val).GetLaneFromIndex((int)coin) != TrackLane.None)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.MenuState)+7C]");
				Coin coin2 = ((List<Coin>)0).get_Item(index);
				coin2.Activate();
			}
			index = num + 1;
		}
	}
}
