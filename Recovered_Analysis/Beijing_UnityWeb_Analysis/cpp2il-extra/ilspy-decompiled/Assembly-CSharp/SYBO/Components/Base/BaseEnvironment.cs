using Cpp2ILInjected;
using SYBO.Components.Settings;

namespace SYBO.Components.Base;

public class BaseEnvironment
{
	private static bool _isRunningUnitTests;

	public static bool IsRunningUnitTests
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SettingsEngine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SettingsEngine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)SettingsEngine._settingsProvider != 0;
		}
	}

	public BaseEnvironment()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = "";
		object obj2 = this + 12;
		obj2 = "";
		object obj3 = this + 16;
		obj3 = "http://build.sybogames.local:8080";
	}

	static BaseEnvironment()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		SettingsEngine._rootResourceName = "SyboSettings";
		nint num = (nint)typeof(SettingsEngine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = "Settings/{0}";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = (nint)typeof(SettingsEngine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v16 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		object obj3 = default;
		obj2 = obj3;
		SettingsEngine._isLoaded = false;
		nint num3 = (nint)typeof(SettingsEngine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v23 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+5C]");
		object obj4 = (nint)0 + (nint)16;
		obj4 = 0;
	}
}
