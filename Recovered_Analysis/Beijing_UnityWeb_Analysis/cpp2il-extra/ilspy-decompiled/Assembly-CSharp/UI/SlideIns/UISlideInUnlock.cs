using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInUnlock : UISlideIn
{
	private UILabel _line1;

	private UILabel _line2;

	private Layout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_02c2: Expected Obj, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_0361: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_020f: Expected I4, but got Obj
		//IL_01c3: Expected I, but got Obj
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0341: Expected I4, but got Obj
		//IL_039e: Expected I4, but got Obj
		//IL_0125: Expected I, but got Obj
		//IL_0306: Expected Obj, but got I4
		//IL_0263: Expected I, but got Obj
		//IL_00ee: Expected I4, but got Obj
		//IL_00a2: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		if (slideIn.value < 2)
		{
			object obj = this - -64;
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v28 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 == null;
			if (slideIn.value == 1)
			{
				if (!flag)
				{
					nint num2 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v51 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string format = Strings.GetDefault("SLIDE_IN_TOPRUN_MINUTE_LEFT");
				object obj3 = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				string text2 = string.Format(format, args);
				((UILabel)obj).fontSize = (int)text2;
			}
			else
			{
				if (!flag)
				{
					nint num3 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v39 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text3 = Strings.GetDefault("SLIDE_IN_TOPRUN_ENDING_SOON");
				((UILabel)obj).fontSize = (int)text3;
			}
		}
		else
		{
			object obj4 = this - -64;
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v23 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v31 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format2 = Strings.GetDefault("SLIDE_IN_TOPRUN_MINUTES_LEFT");
			object obj3 = slideIn.value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args2 = default;
			string text4 = string.Format(format2, args2);
			((UILabel)obj4).fontSize = (int)text4;
		}
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v8 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text5 = Strings.GetDefault("TOPRUN_TITLE");
		_line1.fontSize = (int)text5;
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
