using Cpp2ILInjected;
using SYBO.Common.Automation.Steps;

namespace SYBO.Subway.Automation.Steps;

public class ReviveStep : AutomationStep
{
	private bool _waitFrame = false;

	public override void Cleanup()
	{
		_ = 0f;
		_ = 0;
		_ = 0;
		base.IsDone__BackingField = false;
	}

	public override void Update(float unscaledDeltaTime)
	{
		//IL_05a7: Expected I, but got Obj
		//IL_05bd: Expected Obj, but got I
		//IL_06db: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_05ed: Expected Obj, but got I4
		//IL_017b: Invalid comparison between I and F4
		//IL_00e9: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0335: Invalid comparison between I and F4
		//IL_04e9: Invalid comparison between I and F4
		//IL_0293: Expected I, but got Obj
		//IL_02a9: Expected Obj, but got I
		//IL_0519: Expected I, but got Obj
		//IL_052f: Expected Obj, but got I
		//IL_044d: Expected I, but got Obj
		//IL_0463: Expected Obj, but got I
		//IL_066c: Expected Obj, but got I
		//IL_066c: Expected Obj, but got I4
		//IL_06b2: Expected Obj, but got I4
		//IL_069b: Expected Obj, but got I4
		//IL_02d4: Expected I, but got Obj
		//IL_055a: Expected I, but got Obj
		//IL_048e: Expected I, but got Obj
		//IL_0200: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_03ba: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I4
		//IL_0684: Expected Obj, but got I4
		//IL_0241: Expected I, but got Obj
		//IL_03fb: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v126 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12+8]");
		if ((nint)0 != 0)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v114 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v122 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).PayoutCelebrationReward(null);
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).DebugCloseAllPopups();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+1C]");
		if ((nint)0 != 0)
		{
			_ = 0;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+14]");
		float num5 = 0f + unscaledDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+18]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+14]");
			if (!(0f < 0.2f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+C]");
					if ((nint)0 == 1)
					{
						nint num6 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v102 (Il2CppClass<UIScreenController>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num7 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v108 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag3 = UIScreenController.ShouldShowOnlineScreen();
						bool flag4 = flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+10]");
						((UIScreenController)flag4).SwitchScreen((string)0);
					}
				}
				else
				{
					nint num8 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v87 (Il2CppClass<UIScreenController>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num9 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v93 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag5 = UIScreenController.ShouldShowOnlineScreen();
					bool flag6 = flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+10]");
					((UIScreenController)flag6).QueuePopup((string)0);
				}
				_ = 2;
				_ = 1;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+18]");
		if ((nint)0 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+14]");
			if (!(0f < 0.4f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+C]");
					if ((nint)0 == 1)
					{
						nint num10 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v68 (Il2CppClass<UIScreenController>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num11 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v74 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag7 = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag7).ClearPopupsAndScreens();
					}
				}
				else
				{
					nint num12 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v53 (Il2CppClass<UIScreenController>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num13 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v59 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag8 = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag8).DebugCloseAllPopups();
				}
				_ = 3;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+18]");
		if ((nint)0 != 3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.ReviveStep)+14]");
		if (0f < 0.6f)
		{
			return;
		}
		nint num14 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v34 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num15 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag9 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag9).DebugCloseAllPopups();
		base.IsDone__BackingField = true;
	}

	public ReviveStep()
	{
		base.IsDone__BackingField = false;
	}
}
