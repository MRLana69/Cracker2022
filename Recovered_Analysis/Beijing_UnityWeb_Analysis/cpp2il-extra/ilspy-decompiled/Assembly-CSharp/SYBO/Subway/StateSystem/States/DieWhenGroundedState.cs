using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Common.Managers;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.StateSystem.States.Settings;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public class DieWhenGroundedState : State
{
	private Character _character;

	private int _frameCount;

	public DieWhenGroundedState(int id)
	{
		//IL_009c: Expected VT, but got Obj
		//IL_00a5: Expected VT, but got Obj
		//IL_00ba: Expected F4, but got I
		//IL_00ba: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got F4
		//IL_0054: Expected I, but got Obj
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (T)+10]");
		((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.InvokeOnGameEnded();
		_character = (Character)0f;
		_frameCount = 0;
	}

	public override void Enter(State fromState)
	{
		//IL_005c: Expected I4, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Id = (int)fromState;
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v13 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		CharacterRendering instance = CharacterRendering.Instance;
		obj2 = instance;
	}

	public override void OnUpdate()
	{
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController instance = SSEventsManagerController.instance;
		if (instance != null)
		{
			return;
		}
		FlyingStateSettings flyingStateSettings = ((FlyingState)null).FlyingStateSettings;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)flyingStateSettings);
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v24 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		_ = 0;
	}
}
