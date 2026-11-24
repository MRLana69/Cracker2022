using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInCloudSaveMessage : UISlideInCloudSave
{
	protected override void SetupBasic()
	{
		((UISlideInAdsRemoved)(object)this)._002Ector();
	}

	protected override void SetupSpecific(CloudSaveState state)
	{
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0419: Expected I4, but got Obj
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_00fc: Expected I4, but got Obj
		//IL_010c: Expected I4, but got Obj
		//IL_00b0: Expected I, but got Obj
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_0121: Expected I4, but got Obj
		//IL_0454: Expected I4, but got Obj
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_0175: Expected I, but got Obj
		//IL_0287: Expected I, but got Obj
		//IL_029d: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I4
		//IL_049a: Expected I4, but got Obj
		//IL_04c0: Expected I4, but got Obj
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_024f: Expected I4, but got Obj
		//IL_025f: Expected I4, but got Obj
		//IL_0203: Expected I, but got Obj
		//IL_0314: Expected I4, but got Obj
		//IL_0324: Expected I4, but got Obj
		//IL_02c8: Expected I, but got Obj
		//IL_033c: Expected I, but got Obj
		//IL_0352: Expected Obj, but got I
		//IL_0274: Expected I4, but got Obj
		//IL_04fb: Expected I4, but got Obj
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got Unknown
		//IL_03c9: Expected I4, but got Obj
		//IL_03d9: Expected I4, but got Obj
		//IL_037d: Expected I, but got Obj
		switch (state)
		{
		case CloudSaveState.Disabled:
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v19 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text5 = Strings.GetDefault("CLOUDSAVE_SLIDEIN_DISCONNECT_TOP");
			_topLine.fontSize = (int)text5;
			object obj7 = this - -64;
			string text6 = Strings.GetDefault("CLOUDSAVE_SLIDEIN_DISCONNECT_BOTTOM");
			((UILabel)obj7).fontSize = (int)text6;
			_icon.fillCenter = (byte)(int)"ic_cloud" != 0;
			_accentIcon.fillCenter = (byte)(int)"ic_x_red" != 0;
			break;
		}
		case CloudSaveState.Ok:
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v24 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v41 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault("CLOUDSAVE_SLIDEIN_WELCOMEBACK_TOP");
			_topLine.fontSize = (int)text3;
			object obj4 = this - -64;
			string format = Strings.GetDefault("CLOUDSAVE_USERNAME");
			nint num5 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S2_v14 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S2_v25 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isAvailable = CloudSave.isAvailable;
			string values = string.Format(format, (object[])isAvailable);
			string text4 = string.ConcatArray((string[])(object)values, (int)"!");
			((UILabel)obj4).fontSize = (int)text4;
			_icon.fillCenter = (byte)(int)"ic_cloud" != 0;
			_accentIcon.fillCenter = (byte)(int)"ic_check" != 0;
			break;
		}
		case CloudSaveState.Error:
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v46 (Il2CppClass<Strings>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v59 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text7 = Strings.GetDefault("CLOUDSAVE_SLIDEIN_CONNECTIONERROR_TOP");
			_topLine.fontSize = (int)text7;
			object obj9 = this - -64;
			string text8 = Strings.GetDefault("CLOUDSAVE_SLIDEIN_CONNECTIONERROR_BOTTOM");
			((UILabel)obj9).fontSize = (int)text8;
			_icon.fillCenter = (byte)(int)"ic_brdrcmb_error" != 0;
			break;
		}
		case CloudSaveState.Conflict:
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v64 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v77 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("CLOUDSAVE_STATUS_CONFLICT_INFO");
			_topLine.fontSize = (int)text;
			object obj2 = this - -64;
			string text2 = Strings.GetDefault("CLOUDSAVE_SLIDEIN_CONNECTIONERROR_BOTTOM");
			((UILabel)obj2).fontSize = (int)text2;
			_icon.fillCenter = (byte)(int)"ic_brdrcmb_conflict" != 0;
			break;
		}
		}
	}

	public unsafe UISlideInCloudSaveMessage()
	{
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0308: Expected Obj, but got I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected I4, but got Unknown
		//IL_0338: Expected I4, but got Obj
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0082: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I4
		//IL_00f3: Expected I4, but got Obj
		//IL_0129: Expected Obj, but got I4
		//IL_014b: Expected I4, but got Obj
		//IL_0161: Expected Obj, but got I4
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_02ce: Expected I4, but got Obj
		//IL_02de: Expected I4, but got Obj
		//IL_0203: Expected I4, but got Obj
		//IL_01b4: Expected I, but got Obj
		//IL_026a: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v55 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 48;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj4 = (flag ? 1 : 0) + 604;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v5+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 - -64);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+8]");
		_ = 0;
		_topLine.rawPivot = pivot;
		object obj5 = obj3 + 32;
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj6 = (flag2 ? 1 : 0) + 140;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v18+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v16+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj7 = this - -64;
		object obj8 = obj3 + 16;
		bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj9 = (flag3 ? 1 : 0) + 188;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v30+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v23+8]");
		_ = 0;
		((UIWidget)obj7).rawPivot = pivot;
		bool flag4 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj10 = (flag4 ? 1 : 0) + 140;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v41+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v35 (Il2CppClass<Strings>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v51 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CLOUDSAVE_SLIDEIN_CONFLICT_RESOLVED_HEADER");
		_topLine.fontSize = (int)text;
		_icon.fillCenter = (byte)(int)"ic_cloud" != 0;
		_accentIcon.fillCenter = (byte)(int)"ic_check" != 0;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text2 = tag;
			((GameObject)(object)text2).tag = null;
			string text3 = tag;
			((GameObject)(object)text3).tag = (string)1;
		}
	}
}
