using System;
using Cpp2ILInjected;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInCharacterEventHelper : UISlideIn
{
	private UILabel _textLabel;

	private UILabel _shadowLabel;

	private Layout _layout;

	private string _myColorActive;

	private string _myColorInactive;

	private string _shadowColorActive;

	private string _shadowColorInactive;

	private void Awake()
	{
		((UISlideInAdsRemoved)this)._002Ector();
	}

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0470: Expected I4, but got Obj
		//IL_0480: Expected I4, but got Obj
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01b0: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_04a0: Expected I4, but got Obj
		//IL_04b0: Expected I4, but got Obj
		//IL_005f: Expected I, but got Obj
		//IL_04c3: Expected I, but got Obj
		//IL_04d9: Expected Obj, but got I
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_0511: Expected I4, but got Obj
		//IL_0521: Expected I4, but got Obj
		//IL_0128: Expected I, but got Obj
		//IL_05a3: Expected I4, but got Obj
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0342: Expected I, but got Obj
		//IL_0358: Expected Obj, but got I
		//IL_0541: Expected I4, but got Obj
		//IL_0551: Expected I4, but got Obj
		//IL_01f1: Expected I, but got Obj
		//IL_041d: Expected Obj, but got I4
		//IL_03d0: Expected I, but got Obj
		//IL_0571: Expected I4, but got Obj
		//IL_0581: Expected I4, but got Obj
		//IL_02ba: Expected I, but got Obj
		//IL_0383: Expected I, but got Obj
		if (string.Equals((string)(object)slideIn, "pack1"))
		{
			object obj = this - -64;
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v90 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v99 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("INAPP_DATA_BUNDLE_TIER_ONE");
			((UILabel)obj).fontSize = (int)text;
			((UISprite)(object)_layout).fillCenter = (byte)(int)"icon_pack1" != 0;
		}
		else if (string.Equals((string)(object)slideIn, "pack2"))
		{
			object obj3 = this - -64;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v75 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v84 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("INAPP_DATA_BUNDLE_TIER_TWO");
			((UILabel)obj3).fontSize = (int)text2;
			((UISprite)(object)_layout).fillCenter = (byte)(int)"icon_pack2" != 0;
		}
		else if (string.Equals((string)(object)slideIn, "pack3"))
		{
			object obj5 = this - -64;
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v60 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v69 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault("INAPP_DATA_BUNDLE_TIER_THREE");
			((UILabel)obj5).fontSize = (int)text3;
			((UISprite)(object)_layout).fillCenter = (byte)(int)"icon_pack3" != 0;
		}
		else if (string.Equals((string)(object)slideIn, "pack4"))
		{
			object obj7 = this - -64;
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v45 (Il2CppClass<Strings>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v54 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("INAPP_DATA_BUNDLE_TIER_FOUR");
			((UILabel)obj7).fontSize = (int)text4;
			((UISprite)(object)_layout).fillCenter = (byte)(int)"icon_pack4" != 0;
		}
		else if (string.Equals((string)(object)slideIn, "pack5"))
		{
			object obj9 = this - -64;
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v30 (Il2CppClass<Strings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v39 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text5 = Strings.GetDefault("INAPP_DATA_BUNDLE_TIER_FIVE");
			((UILabel)obj9).fontSize = (int)text5;
			((UISprite)(object)_layout).fillCenter = (byte)(int)"icon_pack5" != 0;
		}
		nint num11 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v6 (Il2CppClass<Strings>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text6 = Strings.GetDefault("SLIDE_IN_BUNDLE_RECEIVED");
		_textLabel.fontSize = (int)text6;
		string text7 = tag;
		((GameObject)(object)text7).tag = (string)1;
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}

	private void StoreColors()
	{
		this._002Ector();
	}

	private void UpdateCharacterEventWord(int letterMask, string extraInfo)
	{
		//IL_001f: Expected VT, but got I4
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)letterMask;
		base._darkBackground = (UIWidget)(object)extraInfo;
		base.posOff = (Vector3)0;
	}

	private bool IsFilteredCharacter(char newChar)
	{
		//IL_0283: Expected I4, but got VT
		//IL_006b: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_01cc: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+8]");
		if ((nint)0 > (nint)3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+8]");
			if ((nint)0 != 7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+8]");
				object obj = -13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+8]");
				if ((nint)0 == 13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+14]");
					object obj2 = (nint)0 + (nint)(-1);
					if ((nint)obj2 < 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInCharacterEventHelper)+14]");
						return false;
					}
					return (byte)(int)base.posOff != 0;
				}
				if ((nint)obj != 1 && (nint)obj != 2 && ((nint)obj == 3 || (nint)obj == 4 || ((nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7)))
				{
					goto IL_0288;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+8]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newChar @ L1 (System.Char)+8]");
						if ((nint)0 == 3)
						{
							goto IL_0279;
						}
					}
				}
				goto IL_0288;
			}
		}
		goto IL_0279;
		IL_0288:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInCharacterEventHelper)+14]");
		return false;
		IL_0279:
		return (byte)(int)base.posOff != 0;
	}

	public UISlideInCharacterEventHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		obj = 0;
		obj = -18;
		_ = -52;
		_ = 50;
		_ = -1;
		object obj3 = obj2 + 20;
		obj3 = obj;
		object obj4 = obj2 + 24;
		obj4 = obj3;
		object obj5 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A567");
		object obj6 = default;
		obj5 = obj6;
		object obj7 = obj2 + 8;
		obj7 = 0;
		obj7 = 0;
		obj7 = -1;
		_ = -1;
		_ = -1;
		_ = -1;
		object obj8 = obj2 + 12;
		obj8 = obj7;
		obj4 = obj8;
		object obj9 = this + 76;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A567");
		object obj10 = default;
		obj9 = obj10;
		object obj11 = obj2 + 4;
		obj11 = 0;
		obj11 = 0;
		obj11 = 75;
		_ = 75;
		_ = 75;
		_ = -1;
		obj2 = obj11;
		obj4 = obj2;
		object obj12 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A567");
		object obj13 = default;
		obj12 = obj13;
		object obj14 = this + 84;
		obj14 = _shadowColorActive;
	}
}
