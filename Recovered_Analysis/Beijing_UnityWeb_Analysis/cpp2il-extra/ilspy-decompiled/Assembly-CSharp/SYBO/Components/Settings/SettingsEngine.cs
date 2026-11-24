using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using SYBO.Components.Base;
using SYBO.Components.BuildSizeMonitor;
using UnityEngine;
using UnityEngine.Experimental.Playables;
using UnityEngine.Playables;

namespace SYBO.Components.Settings;

public static class SettingsEngine
{
	private static readonly string _rootResourceName;

	private static readonly string _resourceLoadPath;

	private static object _loadLock;

	private static bool _isLoaded;

	private static ISettingsProvider _settingsProvider;

	public static ISettingsProvider GetSettingsProvider()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AesManaged aesManaged = default;
		aesManaged.GenerateIV();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 25;
		if (aesManaged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 25)
			{
				object obj9 = obj2 + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				goto IL_021d;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_021d;
		IL_021d:
		ISettingsProvider result = default;
		return result;
	}

	public static void Reload()
	{
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_006d: Expected Obj, but got I
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_00c4: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BaseEnvironment baseEnvironment = default;
		baseEnvironment._002Ector();
		StaticSettings.BuildSizeMonitor = (BuildSizeMonitorSettings)(object)baseEnvironment;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingAttribute debugSettingAttribute = default;
		debugSettingAttribute._002Ector();
		nint num = (nint)typeof(StaticSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15 (Il2CppClass<SYBO.Components.Settings.StaticSettings>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = debugSettingAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = (nint)typeof(StaticSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v22 (Il2CppClass<SYBO.Components.Settings.StaticSettings>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		object obj3 = default;
		obj2 = obj3;
		nint num3 = (nint)typeof(SettingsEngine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v26 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(SettingsEngine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v31 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Save();
	}

	public static void Load()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
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
		_isLoaded = false;
		Save();
	}

	public static void Save()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected Obj, but got Unknown
		//IL_06a2: Expected Obj, but got I4
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_06cc: Expected I, but got Obj
		//IL_06e2: Expected Obj, but got I
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected Obj, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected Obj, but got Unknown
		//IL_0858: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I4
		//IL_023a: Expected I, but got Obj
		//IL_0250: Expected Obj, but got I
		//IL_018a: Expected I, but got Obj
		//IL_027b: Expected I, but got Obj
		//IL_05e1: Expected Obj, but got I
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(SettingsEngine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(SettingsEngine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v276 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 20;
		object obj7 = obj2 + 16;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num3 = (nint)typeof(SettingsEngine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v70 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(SettingsEngine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v267 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		if (~(_isLoaded ? 1u : 0u) == 0)
		{
			object obj9 = obj4 + 4;
			object obj10 = obj9 + 1;
			obj9 = obj10;
			object obj11 = obj10 << 2;
			object obj12 = obj4 + obj11;
			obj12 = 145;
		}
		else
		{
			nint num5 = (nint)typeof(SettingsEngine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v78 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num6 = (nint)typeof(SettingsEngine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v247 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			_isLoaded = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			nint num7 = 0;
			_ = 0;
			object obj15 = default;
			object obj14 = obj15 + 16;
			obj14 = 0;
			nint num8 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v98 (Il2CppClass<System.Type>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S0_v234 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj7 = typeof(StaticSettings);
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj18 = default;
			object obj17 = obj18;
			object obj20 = default;
			object obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj21 = default;
			if (obj19 == obj21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
		}
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
			object obj22 = (nint)0 << 2;
			object obj23 = obj4 + obj22;
			if ((nint)obj23 == 145)
			{
				object obj24 = obj4 + 4;
				if ((nint)obj24 > -1)
				{
					object obj25 = obj24 + -1;
					obj24 = obj25;
				}
				return;
			}
		}
		object obj26 = default;
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public unsafe static void Backup()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00a6: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v15 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CameraPlayable cameraPlayable = default;
		PlayableHandle handle = ((CameraPlayable*)cameraPlayable)->GetHandle();
	}

	public static void Restore()
	{
	}

	private static string ReadFileText(string filename)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
