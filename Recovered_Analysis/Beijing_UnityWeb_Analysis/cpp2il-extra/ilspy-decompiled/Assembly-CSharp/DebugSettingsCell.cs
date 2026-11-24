using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using WordHunt;

public class DebugSettingsCell
{
	public DebugSettingsCellType cellType;

	public DebugSetting settingType;

	public string cellTitle;

	public string cellDescription;

	public string cellFunctionName;

	public ButtonIcon cellButtonIcon;

	public bool multiSelect;

	public Action callback;

	public Dictionary<string, string> _items
	{
		get
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Dictionary<string, string> dictionary = default;
			dictionary.buckets = null;
			object obj = dictionary + 16;
			obj = this;
			return dictionary;
		}
		private set
		{
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected Obj, but got Unknown
			//IL_01e5: Expected Obj, but got I4
			//IL_01fe: Expected I, but got Obj
			//IL_0214: Expected Obj, but got I
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Expected Obj, but got Unknown
			//IL_0297: Expected Obj, but got I
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_00d0: Expected I, but got Obj
			//IL_00e6: Expected Obj, but got I
			//IL_0111: Expected I, but got Obj
			//IL_026f: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 24;
			obj = 0;
			_ = 0;
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v44 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = (string)(obj2 + 12);
			string msg = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DebugSettingsCell)+8C]");
			WordHuntManager.LogError(msg, (UnityEngine.Object)0);
			obj = text;
			_ = text.m_stringLength;
			obj2 = text;
			_ = text.m_stringLength;
			if (obj2 != null)
			{
				if ((nint)obj2 == 1)
				{
					text = (string)obj;
					string text2 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					text2.m_stringLength = 0;
					nint num3 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v15 (Il2CppClass<Strings>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v21 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string key = ((text.m_stringLength == 0) ? "DAILY_CHALLENGE_MYSTERY_BOX" : "DAILY_CHALLENGE_SUPER_MYSTERY_BOX");
					string text3 = Strings.GetDefault(key);
					((UILabel)(object)cellDescription).fontSize = (int)text3;
				}
				else
				{
					text = (string)obj;
					string text4 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					text4.m_stringLength = 0;
					obj2 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					string text5 = default;
					string msg2 = "Unhandled reward type: " + text5;
					SDebug.LogFormat(msg2, null);
				}
			}
			else
			{
				object obj5 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				int fontSize = default;
				((UILabel)(object)cellDescription).fontSize = fontSize;
			}
			_ = 0;
			_ = 0;
		}
	}

	public DebugSettingsCell()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
