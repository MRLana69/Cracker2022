using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UISlideInCharacterEventHelper : UISlideIn
{
	private UILabel _timerLabel;

	private UILabel _textLabel;

	private UILabel shadowLabel;

	private UISprite _slideInBackground;

	private const int NOTIFICATION_EDGE_MARGIN = 22;

	private const int MINIMUM_SLIDE_IN_WIDTH = 155;

	public Color MyColorActive;

	public Color MyColorInactive;

	public Color shadowColorActive;

	public Color shadowColorInactive;

	private string _MyColorActive;

	private string _MyColorInactive;

	private string _shadowColorActive;

	private string _shadowColorInactive;

	private void Awake()
	{
		StoreColors();
	}

	public void SetupCharacterEventLetters(int letterMask, string extraInfo)
	{
		//IL_003b: Expected I, but got Obj
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		UpdateCharacterEventWord(letterMask, extraInfo);
		AdjustSlideInNotificationWidth();
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S2_v4 (Il2CppClass<UISlideInCharacterEventHelper>)+E4] (should have been resolved before IL gen)");
	}

	private void AdjustSlideInNotificationWidth()
	{
		UILabel timerLabel = _timerLabel;
		int width = ((UIWidget)timerLabel).mWidth + 22;
		_slideInBackground.width = width;
		UISprite slideInBackground = _slideInBackground;
		if (((UIWidget)slideInBackground).mWidth <= 154)
		{
			slideInBackground.width = 155;
		}
	}

	private unsafe void StoreColors()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected VT, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected VT, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected VT, but got Unknown
		//IL_006b: Expected F4, but got I
		//IL_0066: Expected native int or pointer, but got VT
		//IL_007a: Expected F4, but got VT
		//IL_0075: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 80);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlideInCharacterEventHelper)+50]");
		_ = 0;
		_ = MyColorActive;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
		_ = 0;
		Color c = color + 48;
		string myColorActive = NGUIText.EncodeColor(c);
		_MyColorActive = myColorActive;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlideInCharacterEventHelper)+60]");
		_ = 0;
		_ = MyColorInactive;
		Color c2 = color + 32;
		string myColorInactive = NGUIText.EncodeColor(c2);
		_MyColorInactive = myColorInactive;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlideInCharacterEventHelper)+70]");
		_ = 0;
		_ = shadowColorActive;
		Color c3 = color + 16;
		string text = NGUIText.EncodeColor(c3);
		_shadowColorActive = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlideInCharacterEventHelper)+80]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)shadowColorInactive;
		string text2 = NGUIText.EncodeColor(color);
		_shadowColorInactive = text2;
	}

	private unsafe void UpdateCharacterEventWord(int letterMask, string extraInfo)
	{
		//IL_026f: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected I4, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected I4, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		char[] array = extraInfo.ToCharArray();
		object obj = letterMask + 1;
		string text = string.Empty;
		string text2 = string.Empty;
		UISlideInCharacterEventHelper uISlideInCharacterEventHelper = null;
		object obj2 = obj;
		while (array.Length > (nint)uISlideInCharacterEventHelper)
		{
			object obj3 = (object)uISlideInCharacterEventHelper << 1;
			object obj4 = (object)array + obj3;
			UISlideInCharacterEventHelper uISlideInCharacterEventHelper2 = uISlideInCharacterEventHelper;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v12+10]");
			if (uISlideInCharacterEventHelper2.IsFilteredCharacter('\0'))
			{
				object obj5 = obj2 + 1;
				obj2 = obj5;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<UISlideInCharacterEventHelper, UIntPtr>(ref uISlideInCharacterEventHelper) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				string text3 = text2 + "[" + _MyColorActive + "]";
				string text4 = text + "[" + _shadowColorActive + "]";
				text = text4;
				text2 = text3;
			}
			else
			{
				string text5 = text2 + "[" + _MyColorInactive + "]";
				string text6 = text + "[" + _shadowColorInactive + "]";
				text = text6;
				text2 = text5;
			}
			object obj6 = (object)uISlideInCharacterEventHelper << 1;
			object obj7 = (object)array + obj6;
			char c = (char)(obj7 + 16);
			string text7 = ((char*)(ushort)c)->ToString();
			string text8 = text2 + text7 + " ";
			object obj8 = (object)uISlideInCharacterEventHelper << 1;
			object obj9 = (object)array + obj8;
			char c2 = (char)(obj9 + 16);
			string text9 = ((char*)(ushort)c2)->ToString();
			string text10 = text + text9 + " ";
			UISlideInCharacterEventHelper uISlideInCharacterEventHelper3 = (UISlideInCharacterEventHelper)(uISlideInCharacterEventHelper + 1);
			text = text10;
			text2 = text8;
			uISlideInCharacterEventHelper = uISlideInCharacterEventHelper3;
		}
		if (array.Length != 0)
		{
			int length = text2._stringLength - 1;
			string text11 = text2.Substring(0, length);
			_textLabel.text = text11;
			int length2 = text._stringLength - 1;
			string text12 = text.Substring(0, length2);
			shadowLabel.text = text12;
		}
	}

	private bool IsFilteredCharacter(char newChar)
	{
		//IL_0076: Expected Obj, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		char[] fILTERED_CHARACTERS = CharacterNameEventManager.FILTERED_CHARACTERS;
		object obj = 0;
		bool flag;
		while (true)
		{
			flag = (nint)obj < fILTERED_CHARACTERS.Length;
			if (!flag)
			{
				break;
			}
			object obj2 = obj << 1;
			object obj3 = (object)fILTERED_CHARACTERS + obj2;
			char c = newChar;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v7+10]");
			if ((nint)(int)c == 0)
			{
				break;
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		return flag;
	}
}
