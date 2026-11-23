using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

public class UIInput : MonoBehaviour
{
	public enum InputType
	{
		Standard,
		AutoCorrect,
		Password
	}

	public enum Validation
	{
		None,
		Integer,
		Float,
		Alphanumeric,
		Username,
		Name,
		Filename
	}

	public enum KeyboardType
	{
		Default,
		ASCIICapable,
		NumbersAndPunctuation,
		URL,
		NumberPad,
		PhonePad,
		NamePhonePad,
		EmailAddress
	}

	public enum OnReturnKey
	{
		Default,
		Submit,
		NewLine
	}

	public delegate char OnValidate(string text, int charIndex, char addedChar);

	public static UIInput current;

	public static UIInput selection;

	public UILabel label;

	public InputType inputType;

	public OnReturnKey onReturnKey;

	public KeyboardType keyboardType;

	public bool hideInput;

	[NonSerialized]
	public bool selectAllTextOnFocus = true;

	public Validation validation;

	public int characterLimit;

	public string savedAs;

	private GameObject selectOnTab;

	public Color activeTextColor = (Color)4575657222473777152L;

	public Color caretColor = (Color)4575657222473777152L;

	public Color selectionColor = (Color)4566614701407993856L;

	public List<EventDelegate> onSubmit;

	public List<EventDelegate> onChange;

	public OnValidate onValidate;

	protected string mValue;

	[NonSerialized]
	protected string mDefaultText;

	[NonSerialized]
	protected Color mDefaultColor;

	[NonSerialized]
	protected float mPosition;

	[NonSerialized]
	protected bool mDoInit;

	[NonSerialized]
	protected UIWidget.Pivot mPivot;

	[NonSerialized]
	protected bool mLoadSavedValue;

	protected static int mDrawStart;

	protected static string mLastIME = string.Empty;

	protected static TouchScreenKeyboard mKeyboard;

	private static bool mWaitForKeyboard;

	[NonSerialized]
	protected int mSelectionStart;

	[NonSerialized]
	protected int mSelectionEnd;

	[NonSerialized]
	protected UITexture mHighlight;

	[NonSerialized]
	protected UITexture mCaret;

	[NonSerialized]
	protected Texture2D mBlankTex;

	[NonSerialized]
	protected float mNextBlink;

	[NonSerialized]
	protected float mLastAlpha;

	[NonSerialized]
	protected string mCached;

	[NonSerialized]
	protected int mSelectMe;

	[NonSerialized]
	protected int mSelectTime;

	[NonSerialized]
	private UICamera mCam;

	private static int mIgnoreKey;

	public string defaultText
	{
		get
		{
			if (~(mDoInit ? 1u : 0u) == 0)
			{
				Init();
			}
			return mDefaultText;
		}
		set
		{
			if (~(mDoInit ? 1u : 0u) == 0)
			{
				Init();
			}
			mDefaultText = value;
			UpdateLabel();
		}
	}

	public bool inputShouldBeHidden
	{
		get
		{
			bool flag = (byte)(~(hideInput ? 1u : 0u)) != 0;
			bool result = false;
			if (!flag)
			{
				bool flag2 = label != null;
				bool flag3 = !flag2;
				result = false;
				if (!flag3)
				{
					UILabel uILabel = label;
					bool flag4 = uILabel.mMaxLineCount != 1;
					result = false;
					if (!flag4)
					{
						bool flag5 = inputType != InputType.Password;
						result = flag5;
					}
				}
			}
			return result;
		}
	}

	public string text
	{
		get
		{
			return value;
		}
		set
		{
			this.value = value;
		}
	}

	public string value
	{
		get
		{
			if (~(mDoInit ? 1u : 0u) == 0)
			{
				Init();
			}
			return mValue;
		}
		set
		{
			//IL_013f: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I4
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected Obj, but got Unknown
			if (~(mDoInit ? 1u : 0u) == 0)
			{
				Init();
			}
			mDrawStart = 0;
			string text = Validate(value);
			if (isSelected && mKeyboard != null && mCached != text)
			{
				mKeyboard.text = text;
				object obj = this + 176;
				obj = text;
			}
			if (!(mValue != text))
			{
				return;
			}
			mValue = text;
			mLoadSavedValue = false;
			object obj2;
			if (isSelected)
			{
				if (text != null)
				{
					obj2 = 0;
					if (text._stringLength != 0)
					{
						goto IL_01dd;
					}
				}
				obj2 = 1;
				goto IL_01dd;
			}
			SaveToPlayerPrefs(text);
			goto IL_0186;
			IL_0186:
			UpdateLabel();
			ExecuteOnChange();
			return;
			IL_01dd:
			if (obj2 != null)
			{
				mSelectionStart = 0;
			}
			else
			{
				mSelectionEnd = text._stringLength;
				mSelectionStart = text._stringLength;
			}
			goto IL_0186;
		}
	}

	public bool selected
	{
		get
		{
			return isSelected;
		}
		set
		{
			isSelected = value;
		}
	}

	public bool isSelected
	{
		get
		{
			return selection == this;
		}
		set
		{
			GameObject selectedObject;
			if (!value)
			{
				bool flag = isSelected;
				selectedObject = null;
				if (!flag)
				{
					return;
				}
			}
			else
			{
				selectedObject = gameObject;
			}
			UICamera.selectedObject = selectedObject;
		}
	}

	public int cursorPosition
	{
		get
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected Obj, but got Unknown
			//IL_009d: Expected I4, but got Obj
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected Obj, but got Unknown
			object obj;
			if (mKeyboard != null && !inputShouldBeHidden)
			{
				string text = value;
				obj = text + 8;
			}
			else
			{
				obj = this + 152;
				if (!isSelected)
				{
					string text2 = value;
					obj = text2 + 8;
				}
			}
			return (int)obj;
		}
		set
		{
			if (isSelected && (mKeyboard == null || inputShouldBeHidden))
			{
				mSelectionEnd = value;
				UpdateLabel();
			}
		}
	}

	public int selectionStart
	{
		get
		{
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected Obj, but got Unknown
			//IL_00ac: Expected I4, but got Obj
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected Obj, but got Unknown
			int result;
			if (mKeyboard != null)
			{
				bool flag = inputShouldBeHidden;
				bool flag2 = !flag;
				result = 0;
				if (flag2)
				{
					goto IL_009f;
				}
			}
			object obj;
			if (isSelected)
			{
				obj = this + 148;
			}
			else
			{
				string text = value;
				obj = text + 8;
			}
			result = (int)obj;
			goto IL_009f;
			IL_009f:
			return result;
		}
		set
		{
			if (isSelected && (mKeyboard == null || inputShouldBeHidden))
			{
				mSelectionStart = value;
				UpdateLabel();
			}
		}
	}

	public int selectionEnd
	{
		get
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected Obj, but got Unknown
			//IL_009d: Expected I4, but got Obj
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected Obj, but got Unknown
			object obj;
			if (mKeyboard != null && !inputShouldBeHidden)
			{
				string text = value;
				obj = text + 8;
			}
			else
			{
				obj = this + 152;
				if (!isSelected)
				{
					string text2 = value;
					obj = text2 + 8;
				}
			}
			return (int)obj;
		}
		set
		{
			if (isSelected && (mKeyboard == null || inputShouldBeHidden))
			{
				mSelectionEnd = value;
				UpdateLabel();
			}
		}
	}

	public UITexture caret => mCaret;

	public string Validate(string val)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_020a: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I4
		//IL_0121: Expected I, but got Obj
		object obj;
		if (val != null)
		{
			obj = 0;
			if (val._stringLength != 0)
			{
				goto IL_0236;
			}
		}
		obj = 1;
		goto IL_0236;
		IL_0236:
		if (obj != null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(val._stringLength);
		int num = default;
		char c3 = default;
		string text = default;
		int num4 = default;
		while (val._stringLength > num)
		{
			char c = val.get_Chars(num);
			OnValidate onValidate = this.onValidate;
			char c2;
			if (this.onValidate != null)
			{
				nint num2 = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S1_v23 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
				object obj2 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				c2 = c3;
			}
			else
			{
				bool flag = validation == Validation.None;
				c2 = c;
				if (!flag)
				{
					nint num3 = (nint)stringBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ S2_v14 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
					int pos = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
					char c4 = Validate(text, pos, c);
					c2 = c4;
				}
			}
			if (c2 != '\0')
			{
				StringBuilder stringBuilder2 = stringBuilder.Append(c2);
			}
			num = num4 + 1;
		}
		if (characterLimit >= 1)
		{
			object obj3 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
			if (characterLimit < (nint)obj3)
			{
				return stringBuilder.ToString(0, characterLimit);
			}
		}
		nint num5 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S1_v9 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private void Start()
	{
		//IL_00d2: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		if (selectOnTab != null)
		{
			UIKeyNavigation component = GetComponent<UIKeyNavigation>();
			if (component == null)
			{
				GameObject gameObject = base.gameObject;
				UIKeyNavigation uIKeyNavigation = gameObject.AddComponent<UIKeyNavigation>();
				uIKeyNavigation.onDown = selectOnTab;
			}
			selectOnTab = null;
		}
		if (~(mLoadSavedValue ? 1u : 0u) != 0)
		{
			goto IL_00de;
		}
		string text = savedAs;
		object obj;
		if (savedAs != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_013c;
			}
		}
		obj = 1;
		goto IL_013c;
		IL_013c:
		if (obj == null)
		{
			LoadValue();
			return;
		}
		goto IL_00de;
		IL_00de:
		string text2 = mValue.Replace("\\n", "\n");
		value = text2;
	}

	protected void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_017f: Expected F4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(mDoInit ? 1u : 0u) == 0 && label != null)
		{
			mDoInit = false;
			UILabel uILabel = label;
			mDefaultText = uILabel.mText;
			UILabel uILabel2 = label;
			mDefaultColor = ((UIWidget)uILabel2).mColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v23 (UILabel)+54]");
			_ = 0;
			if (~(uILabel2.mEncoding ? 1u : 0u) == 0)
			{
				uILabel2.mEncoding = false;
				((UIRect)uILabel2).mChanged = true;
				uILabel2.mShouldBeProcessed = true;
			}
			UILabel uILabel3 = label;
			bool flag = uILabel3.mAlignment == NGUIText.Alignment.Justified;
			bool flag2 = !flag;
			UILabel uILabel4 = uILabel3;
			if (!flag2)
			{
				uILabel3.alignment = NGUIText.Alignment.Left;
				uILabel4 = label;
			}
			mPivot = ((UIWidget)uILabel4).mPivot;
			Transform cachedTransform = uILabel4.cachedTransform;
			Vector3 localPosition = cachedTransform.localPosition;
			mPosition = (float)obj;
			UpdateLabel();
		}
	}

	protected void SaveToPlayerPrefs(string val)
	{
		//IL_004e: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		string text = savedAs;
		object obj;
		if (savedAs != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00bb;
			}
		}
		obj = 1;
		goto IL_00bb;
		IL_00e3:
		object obj2;
		if (obj2 != null)
		{
			PlayerPrefs.DeleteKey(savedAs);
		}
		else
		{
			PlayerPrefs.SetString(savedAs, val);
		}
		return;
		IL_00bb:
		if (obj != null)
		{
			return;
		}
		if (val != null)
		{
			obj2 = 0;
			if (val._stringLength != 0)
			{
				goto IL_00e3;
			}
		}
		obj2 = 1;
		goto IL_00e3;
	}

	protected virtual void OnSelect(bool isSelected)
	{
		if (isSelected)
		{
			OnSelectEvent();
		}
		else
		{
			OnDeselectEvent();
		}
	}

	protected void OnSelectEvent()
	{
		int frameCount = Time.frameCount;
		mSelectTime = frameCount;
		selection = this;
		if (~(mDoInit ? 1u : 0u) == 0)
		{
			Init();
		}
		if (label != null && NGUITools.GetActive(this))
		{
			int frameCount2 = Time.frameCount;
			mSelectMe = frameCount2;
		}
	}

	protected unsafe void OnDeselectEvent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00f9: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_0124: Expected F4, but got I
		//IL_011f: Expected native int or pointer, but got VT
		//IL_0133: Expected F4, but got VT
		//IL_012e: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		if (~(mDoInit ? 1u : 0u) == 0)
		{
			Init();
		}
		if (!(label != null) || !NGUITools.GetActive(this))
		{
			goto IL_0177;
		}
		string text = value;
		mValue = text;
		if (mKeyboard != null)
		{
			mWaitForKeyboard = false;
			mKeyboard.active = false;
			mKeyboard = null;
		}
		string text2 = mValue;
		object obj2;
		if (mValue != null)
		{
			obj2 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_01cb;
			}
		}
		obj2 = 1;
		goto IL_01cb;
		IL_0177:
		selection = null;
		UpdateLabel();
		return;
		IL_01cb:
		if (obj2 != null)
		{
			label.text = mDefaultText;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIInput)+7C]");
			((Color*)(nint)color)->b = 0f;
			((Color*)(nint)color)->r = (float)mDefaultColor;
			label.color = color;
		}
		else
		{
			label.text = mValue;
		}
		Input.imeCompositionMode = IMECompositionMode.Auto;
		RestoreLabelPivot();
		goto IL_0177;
	}

	protected unsafe virtual void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_083a: Expected Obj, but got I4
		//IL_081e: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_088a: Expected Obj, but got I4
		//IL_0985: Expected Obj, but got I4
		//IL_086e: Expected Obj, but got I4
		//IL_0969: Expected Obj, but got I4
		//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Expected VT, but got Unknown
		//IL_0643: Expected Obj, but got I4
		//IL_0627: Expected Obj, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_0466: Expected I, but got Obj
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_049b: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got I
		//IL_04bb: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cd: Expected Obj, but got Unknown
		//IL_10f6: Expected F4, but got I
		//IL_10f1: Expected native int or pointer, but got VT
		//IL_065f: Expected I, but got Obj
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_0516: Expected Obj, but got I4
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected I4, but got Unknown
		//IL_04fa: Expected Obj, but got I4
		//IL_0929: Expected I, but got Obj
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03b3: Expected I, but got Obj
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03e8: Expected Obj, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected VT, but got Unknown
		//IL_0431: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_0c7f: Expected I, but got Obj
		//IL_0c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected Obj, but got Unknown
		//IL_0e30: Expected I, but got Obj
		//IL_0e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3b: Expected Obj, but got Unknown
		object obj = default;
		Vector2 vector = (Vector2)(obj - 80);
		_ = 0;
		if (!isSelected)
		{
			return;
		}
		int frameCount = Time.frameCount;
		if (mSelectTime == frameCount)
		{
			return;
		}
		if (~(mDoInit ? 1u : 0u) == 0)
		{
			Init();
		}
		if (~(mWaitForKeyboard ? 1u : 0u) == 0)
		{
			if (mKeyboard != null && !mKeyboard.active)
			{
				return;
			}
			mWaitForKeyboard = false;
		}
		object obj2;
		if (mSelectMe != -1)
		{
			int frameCount2 = Time.frameCount;
			if (frameCount2 != mSelectMe)
			{
				mSelectMe = -1;
				string text = mValue;
				if (mValue != null)
				{
					obj2 = 0;
					if (text._stringLength != 0)
					{
						goto IL_0f46;
					}
				}
				obj2 = 1;
				goto IL_0f46;
			}
		}
		goto IL_051b;
		IL_0cef:
		UICamera.GetKeyStateFunc getKeyDown = UICamera.GetKeyDown;
		UICamera uICamera = mCam;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v932.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj3 = default;
		if (obj3 != null)
		{
			if (onReturnKey != OnReturnKey.Default)
			{
				if (onReturnKey != OnReturnKey.Submit && onReturnKey == OnReturnKey.NewLine)
				{
					goto IL_0e2b;
				}
			}
			else
			{
				UILabel uILabel = label;
				if (uILabel.mMaxLineCount != 1 && !Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
				{
					UILabel uILabel2 = label;
					if (uILabel2.mOverflow != UILabel.Overflow.ClampContent && validation == Validation.None)
					{
						goto IL_0e2b;
					}
				}
			}
			UICamera.MouseOrTouch controller = UICamera.controller;
			if (controller.current != null)
			{
				UICamera.MouseOrTouch controller2 = UICamera.controller;
				controller2.clickNotification = UICamera.ClickNotification.None;
			}
			UICamera uICamera2 = mCam;
			UICamera.currentKey = uICamera2.submitKey1;
			Submit();
		}
		goto IL_0ea0;
		IL_051b:
		string text2;
		object obj4;
		if (mKeyboard != null)
		{
			text2 = ((!mKeyboard.done && mKeyboard.active) ? mKeyboard.text : mCached);
			if (inputShouldBeHidden)
			{
				if (text2 != "|")
				{
					if (text2 != null)
					{
						obj4 = 0;
						if (text2._stringLength != 0)
						{
							goto IL_1112;
						}
					}
					obj4 = 1;
					goto IL_1112;
				}
			}
			else if (mCached != text2)
			{
				mCached = text2;
				if (!mKeyboard.done && mKeyboard.active)
				{
					value = text2;
				}
			}
			goto IL_072f;
		}
		string compositionString = Input.compositionString;
		object obj5;
		if (compositionString != null)
		{
			obj5 = 0;
			if (compositionString._stringLength != 0)
			{
				goto IL_113a;
			}
		}
		obj5 = 1;
		goto IL_113a;
		IL_11ab:
		object obj6;
		int num;
		if (obj6 != null)
		{
			num = mSelectionStart;
		}
		else
		{
			string text3 = mValue;
			num = text3._stringLength + compositionString._stringLength;
		}
		mSelectionEnd = num;
		mLastIME = compositionString;
		UpdateLabel();
		ExecuteOnChange();
		goto IL_09bf;
		IL_0e2b:
		nint num2 = (nint)this;
		object obj7 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1039 @ S2_v20 (Il2CppClass<UIInput>)+EC] (should have been resolved before IL gen)");
		goto IL_0ea0;
		IL_1112:
		if (obj4 == null)
		{
			string text4 = text2.Substring(1);
			nint num3 = (nint)this;
			object obj8 = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v506 @ S2_v60 (Il2CppClass<UIInput>)+EC] (should have been resolved before IL gen)");
		}
		else
		{
			DoBackspace();
		}
		mKeyboard.text = "|";
		goto IL_072f;
		IL_10b7:
		int height = Screen.height;
		object obj10;
		object obj9 = height - obj10;
		Input.imeCompositionMode = IMECompositionMode.On;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
		((Vector2*)(nint)vector)->x = 0f;
		Input.compositionCursorPos = vector;
		goto IL_04c0;
		IL_09bf:
		if (mCaret != null)
		{
			float unscaledTime = Time.unscaledTime;
			if (mNextBlink < unscaledTime)
			{
				float unscaledTime2 = Time.unscaledTime;
				float num4 = unscaledTime2 + 0.5f;
				mNextBlink = num4;
				bool flag = mCaret.enabled;
				bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
				mCaret.enabled = flag2;
			}
		}
		if (isSelected)
		{
			UILabel uILabel3 = label;
			if (mLastAlpha != uILabel3.finalAlpha)
			{
				UpdateLabel();
			}
		}
		if (mCam == null)
		{
			GameObject gameObject = base.gameObject;
			int layer = gameObject.layer;
			UICamera uICamera3 = UICamera.FindCameraForLayer(layer);
			mCam = uICamera3;
		}
		if (!(mCam != null))
		{
			return;
		}
		UICamera.GetKeyStateFunc getKeyDown2 = UICamera.GetKeyDown;
		UICamera uICamera4 = mCam;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v817.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj11 = default;
		if (obj11 != null)
		{
			if (onReturnKey != OnReturnKey.Default)
			{
				if (onReturnKey != OnReturnKey.Submit && onReturnKey == OnReturnKey.NewLine)
				{
					goto IL_0c7a;
				}
			}
			else
			{
				UILabel uILabel4 = label;
				if (uILabel4.mMaxLineCount != 1 && !Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
				{
					UILabel uILabel5 = label;
					if (uILabel5.mOverflow != UILabel.Overflow.ClampContent && validation == Validation.None)
					{
						goto IL_0c7a;
					}
				}
			}
			UICamera.MouseOrTouch controller3 = UICamera.controller;
			if (controller3.current != null)
			{
				UICamera.MouseOrTouch controller4 = UICamera.controller;
				controller4.clickNotification = UICamera.ClickNotification.None;
			}
			UICamera uICamera5 = mCam;
			UICamera.currentKey = uICamera5.submitKey0;
			Submit();
		}
		goto IL_0cef;
		IL_1157:
		object obj12;
		if (obj12 == null)
		{
			string inputString = Input.inputString;
			int num5 = 0;
			while (num5 < inputString._stringLength)
			{
				char c = inputString.get_Chars(num5);
				if (c >= ' ')
				{
					int num6 = c & 0xFFFC;
					if (num6 != 63232)
					{
						char c2 = (char)(int)(vector + 78);
						string text5 = ((char*)(ushort)c2)->ToString();
						nint num7 = (nint)this;
						object obj13 = this + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v748 @ S2_v48 (Il2CppClass<UIInput>)+EC] (should have been resolved before IL gen)");
					}
				}
				int num8 = num5 + 1;
				num5 = num8;
			}
		}
		goto IL_1165;
		IL_0ea0:
		UICamera uICamera6 = mCam;
		if (!uICamera6.useKeyboard)
		{
			UICamera.GetKeyStateFunc getKeyUp = UICamera.GetKeyUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1030.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj14 = default;
			if (obj14 != null)
			{
				OnKey(KeyCode.Tab);
			}
		}
		return;
		IL_072f:
		if (mKeyboard.done || !mKeyboard.active)
		{
			if (!mKeyboard.wasCanceled)
			{
				Submit();
			}
			mKeyboard = null;
			isSelected = false;
			mCached = string.Empty;
		}
		goto IL_09bf;
		IL_04c0:
		UpdateLabel();
		string inputString2 = Input.inputString;
		object obj15;
		if (inputString2 != null)
		{
			obj15 = 0;
			if (inputString2._stringLength != 0)
			{
				goto IL_1104;
			}
		}
		obj15 = 1;
		goto IL_1104;
		IL_1165:
		if (!(mLastIME != compositionString))
		{
			goto IL_09bf;
		}
		if (compositionString != null)
		{
			obj6 = 0;
			if (compositionString._stringLength != 0)
			{
				goto IL_11ab;
			}
		}
		obj6 = 1;
		goto IL_11ab;
		IL_0f46:
		int num9;
		if (obj2 != null)
		{
			num9 = 0;
		}
		else
		{
			string text6 = mValue;
			num9 = text6._stringLength;
		}
		mSelectionEnd = num9;
		mDrawStart = 0;
		int num10 = ((~(selectAllTextOnFocus ? 1u : 0u) != 0) ? mSelectionEnd : 0);
		mSelectionStart = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIInput)+38]");
		_ = 0;
		_ = activeTextColor;
		Color color = (Color)(vector + 24);
		label.color = color;
		RuntimePlatform platform = Application.platform;
		string text8;
		TouchScreenKeyboardType touchScreenKeyboardType;
		if (platform <= RuntimePlatform.MetroPlayerARM)
		{
			object obj16 = 1 << (int)platform;
			object obj17 = obj16 & 0x1C0900;
			if (obj17 != null)
			{
				string text7;
				if (inputShouldBeHidden)
				{
					TouchScreenKeyboard.hideInput = true;
					text7 = "|";
				}
				else
				{
					TouchScreenKeyboard.hideInput = false;
					if (inputType == InputType.Password)
					{
						mSelectionStart = mSelectionEnd;
						text8 = mValue;
						touchScreenKeyboardType = TouchScreenKeyboardType.Default;
						goto IL_1008;
					}
					mSelectionStart = mSelectionEnd;
					text7 = mValue;
				}
				text8 = text7;
				touchScreenKeyboardType = (TouchScreenKeyboardType)keyboardType;
				goto IL_1008;
			}
		}
		object obj20;
		if (UICamera.current != null)
		{
			Camera cachedCamera = UICamera.current.cachedCamera;
			if (cachedCamera != null)
			{
				Camera cachedCamera2 = UICamera.current.cachedCamera;
				object obj18 = vector - -64;
				UILabel uILabel6 = label;
				nint num11 = (nint)uILabel6;
				object obj19 = uILabel6 + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v894 @ S2_v76 (Il2CppClass<UILabel>)+10C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ S1_v194+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ S1_v194+10]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
				_ = 0;
				Vector3 position = (Vector3)(vector + 8);
				Vector3 vector2 = cachedCamera2.WorldToScreenPoint(position);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
				obj10 = 0;
				goto IL_10b7;
			}
		}
		object obj21 = vector - -64;
		UILabel uILabel7 = label;
		nint num12 = (nint)uILabel7;
		object obj22 = uILabel7 + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v628 @ S2_v71 (Il2CppClass<UILabel>)+10C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S1_v184+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S1_v184+10]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
		obj10 = 0;
		goto IL_10b7;
		IL_1008:
		mWaitForKeyboard = true;
		TouchScreenKeyboard touchScreenKeyboard;
		if (inputType == InputType.Password)
		{
			touchScreenKeyboard = TouchScreenKeyboard.Open(text8, touchScreenKeyboardType, autocorrection: false, multiline: false, secure: true);
		}
		else
		{
			bool autocorrection = !inputShouldBeHidden && inputType == InputType.AutoCorrect;
			UILabel uILabel8 = label;
			bool flag3 = uILabel8.mMaxLineCount == 1 || hideInput;
			bool multiline = !flag3;
			string textPlaceholder = defaultText;
			touchScreenKeyboard = TouchScreenKeyboard.Open(text8, touchScreenKeyboardType, autocorrection, multiline, secure: false, alert: false, textPlaceholder);
		}
		mKeyboard = touchScreenKeyboard;
		goto IL_04c0;
		IL_113a:
		if (obj5 != null)
		{
			string inputString3 = Input.inputString;
			if (inputString3 != null)
			{
				obj12 = 0;
				if (inputString3._stringLength != 0)
				{
					goto IL_1157;
				}
			}
			obj12 = 1;
			goto IL_1157;
		}
		goto IL_1165;
		IL_1104:
		if (obj15 != null)
		{
			return;
		}
		goto IL_051b;
		IL_0c7a:
		nint num13 = (nint)this;
		object obj23 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v989 @ S2_v25 (Il2CppClass<UIInput>)+EC] (should have been resolved before IL gen)");
		goto IL_0cef;
	}

	private void OnKey(KeyCode key)
	{
		//IL_00f3: Expected I, but got Obj
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		int frameCount = Time.frameCount;
		if (frameCount == mIgnoreKey)
		{
			return;
		}
		UICamera uICamera = mCam;
		if (key == uICamera.cancelKey0 || uICamera.cancelKey1 == key)
		{
			mIgnoreKey = frameCount;
			isSelected = false;
		}
		else if (key == KeyCode.Tab)
		{
			mIgnoreKey = frameCount;
			isSelected = false;
			UIKeyNavigation component = GetComponent<UIKeyNavigation>();
			if (component != null)
			{
				nint num = (nint)component;
				object obj = component + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S2_v6 (Il2CppClass<UIKeyNavigation>)+F4] (should have been resolved before IL gen)");
			}
		}
	}

	protected void DoBackspace()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00d4: Expected I, but got Obj
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		string text = mValue;
		object obj;
		if (mValue != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00c1;
			}
		}
		obj = 1;
		goto IL_00c1;
		IL_00c1:
		if (obj != null)
		{
			return;
		}
		if (mSelectionStart == mSelectionEnd)
		{
			if (mSelectionStart < 1)
			{
				return;
			}
			int num = mSelectionStart - 1;
			mSelectionEnd = num;
		}
		nint num2 = (nint)this;
		object obj2 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S2_v4 (Il2CppClass<UIInput>)+EC] (should have been resolved before IL gen)");
	}

	protected virtual void Insert(string text)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		//IL_03cf: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_02eb: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I4
		//IL_017a: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I4
		//IL_0352: Expected I, but got Obj
		//IL_01eb: Expected I, but got Obj
		string leftText = GetLeftText();
		string rightText = GetRightText();
		object obj = leftText._stringLength + rightText._stringLength;
		int capacity = text._stringLength + obj;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(capacity);
		StringBuilder stringBuilder2 = stringBuilder.Append(leftText);
		int num = rightText._stringLength;
		int num2 = 0;
		char c4 = default;
		string text2 = default;
		while (num2 < text._stringLength)
		{
			char c = text.get_Chars(num2);
			if (c == '\b')
			{
				DoBackspace();
			}
			else
			{
				bool flag = characterLimit >= 1;
				bool flag2 = !flag;
				char c2 = (char)num;
				if (!flag2)
				{
					num = stringBuilder.m_ChunkLength;
					object obj2 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
					object obj3 = rightText._stringLength + obj2;
					bool flag3 = characterLimit <= (nint)obj3;
					c2 = (char)stringBuilder.m_ChunkLength;
					if (flag3)
					{
						break;
					}
				}
				OnValidate onValidate = this.onValidate;
				char c3;
				if (this.onValidate != null)
				{
					nint num3 = (nint)stringBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ S1_v42 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
					object obj4 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v167.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					c2 = c;
					c3 = c4;
				}
				else
				{
					bool flag4 = validation == Validation.None;
					c3 = c;
					if (!flag4)
					{
						nint num4 = (nint)stringBuilder;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ S2_v35 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
						int pos = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
						char c5 = Validate(text2, pos, c);
						c2 = c;
						c3 = c5;
					}
				}
				bool flag5 = c3 == '\0';
				num = c2;
				if (!flag5)
				{
					StringBuilder stringBuilder3 = stringBuilder.Append(c3);
					num = c2;
				}
			}
			int num5 = num2 + 1;
			num2 = num5;
		}
		mSelectionStart = (mSelectionEnd = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength);
		int num6 = 0;
		char c8 = default;
		string text3 = default;
		while (num6 < rightText._stringLength)
		{
			char c6 = rightText.get_Chars(num6);
			OnValidate onValidate2 = this.onValidate;
			char c7;
			if (this.onValidate != null)
			{
				nint num7 = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ S1_v28 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
				object obj5 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				c7 = c8;
			}
			else
			{
				bool flag6 = validation == Validation.None;
				c7 = c6;
				if (!flag6)
				{
					nint num8 = (nint)stringBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ S2_v19 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
					int pos2 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
					char c9 = Validate(text3, pos2, c6);
					c7 = c9;
				}
			}
			if (c7 != '\0')
			{
				StringBuilder stringBuilder4 = stringBuilder.Append(c7);
			}
			int num9 = num6 + 1;
			num6 = num9;
		}
		nint num10 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ S2_v12 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string text4 = default;
		mValue = text4;
		UpdateLabel();
		ExecuteOnChange();
	}

	protected string GetLeftText()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		int num = mSelectionStart;
		string text = mValue;
		object obj;
		if (mValue != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00b2;
			}
		}
		obj = 1;
		goto IL_00b2;
		IL_00b2:
		if (obj == null)
		{
			if (mSelectionEnd <= num)
			{
				num = mSelectionEnd;
			}
			if (num > -1)
			{
				return mValue.Substring(0, num);
			}
		}
		return string.Empty;
	}

	protected string GetRightText()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		int num = mSelectionStart;
		string text = mValue;
		object obj;
		if (mValue != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00ab;
			}
		}
		obj = 1;
		goto IL_00ab;
		IL_00ab:
		if (obj == null)
		{
			if (mSelectionEnd >= num)
			{
				num = mSelectionEnd;
			}
			string text2 = mValue;
			if (num < text2._stringLength)
			{
				return text2.Substring(num);
			}
		}
		return string.Empty;
	}

	protected string GetSelection()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		string text = mValue;
		object obj;
		if (mValue != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00c9;
			}
		}
		obj = 1;
		goto IL_00c9;
		IL_00c9:
		if (obj != null || mSelectionStart == mSelectionEnd)
		{
			return string.Empty;
		}
		bool flag = mSelectionStart < mSelectionEnd;
		int num = mSelectionStart;
		if (!flag)
		{
			num = mSelectionEnd;
		}
		bool flag2 = mSelectionStart > mSelectionEnd;
		int num2 = mSelectionStart;
		if (!flag2)
		{
			num2 = mSelectionEnd;
		}
		int length = num2 - num;
		return mValue.Substring(num, length);
	}

	protected unsafe int GetCharUnderMouse()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_017d: Expected I, but got Obj
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected VT, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected VT, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected VT, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected VT, but got Unknown
		//IL_02c6: Expected native int or pointer, but got VT
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected VT, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected VT, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Ref, but got Unknown
		//IL_008f: Expected Ref, but got VT
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected VT, but got Unknown
		//IL_00cf: Expected F4, but got I
		//IL_00cf: Expected Ref, but got VT
		//IL_00fa: Expected F4, but got I
		//IL_00f5: Expected native int or pointer, but got VT
		//IL_011c: Expected F4, but got I
		//IL_0117: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 224);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		UILabel uILabel = label;
		nint num = (nint)uILabel;
		object obj2 = uILabel + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S1_v10 (Il2CppClass<UILabel>)+10C] (should have been resolved before IL gen)");
		Ray currentRay = UICamera.currentRay;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+1C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+28]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		object obj3 = vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Plane plane = (Plane)(vector + 152);
		Vector3 a = vector + 72;
		Vector3 b = vector + 56;
		Vector3 c = vector + 40;
		*(Plane*)(nint)plane = new Plane(a, b, c);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		Plane plane2 = (Plane)(vector + 176);
		Ray ray = (Ray)(vector + 16);
		if (((Plane*)plane2)->Raycast(ray, out *(float*)(vector + 196)))
		{
			Ray ray2 = (Ray)(vector + 200);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
			Vector3 point = ((Ray*)ray2)->GetPoint(0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			((Vector3*)(nint)vector)->x = 0f;
			int characterIndexAtPosition = label.GetCharacterIndexAtPosition(vector, precise: false);
			return characterIndexAtPosition + mDrawStart;
		}
		int result = default;
		return result;
	}

	protected virtual void OnPress(bool isPressed)
	{
		if (!isPressed || !isSelected || !(label != null))
		{
			return;
		}
		if (UICamera.currentScheme != UICamera.ControlScheme.Mouse)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			if (currentScheme != UICamera.ControlScheme.Touch)
			{
				return;
			}
		}
		int charUnderMouse = GetCharUnderMouse();
		selectionEnd = charUnderMouse;
		if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
		{
			selectionStart = mSelectionEnd;
		}
	}

	protected virtual void OnDrag(Vector2 delta)
	{
		if (!(label != null))
		{
			return;
		}
		if (UICamera.currentScheme != UICamera.ControlScheme.Mouse)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			if (currentScheme != UICamera.ControlScheme.Touch)
			{
				return;
			}
		}
		int charUnderMouse = GetCharUnderMouse();
		selectionEnd = charUnderMouse;
	}

	private void OnDisable()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UIInput>)+104] (should have been resolved before IL gen)");
	}

	protected virtual void Cleanup()
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I4
		if ((bool)mHighlight)
		{
			mHighlight.enabled = false;
		}
		if ((bool)mCaret)
		{
			mCaret.enabled = false;
		}
		if ((bool)mBlankTex)
		{
			object obj = this + 164;
			NGUITools.Destroy((UnityEngine.Object)obj);
			obj = 0;
		}
	}

	public void Submit()
	{
		if (NGUITools.GetActive(this))
		{
			string text = value;
			mValue = text;
			if (current == null)
			{
				current = this;
				EventDelegate.Execute(onSubmit);
				current = null;
			}
			SaveToPlayerPrefs(mValue);
		}
	}

	public unsafe void UpdateLabel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected Obj, but got Unknown
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected Obj, but got Unknown
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected Obj, but got Unknown
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd3: Expected Obj, but got Unknown
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected VT, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_0bcc: Expected Obj, but got I4
		//IL_0b37: Expected I, but got Obj
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0909: Expected I, but got Obj
		//IL_0925: Expected I, but got Obj
		//IL_07b8: Expected I, but got Obj
		//IL_07d4: Expected I, but got Obj
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected VT, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected VT, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected VT, but got Unknown
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected VT, but got Unknown
		//IL_0a07: Expected Obj, but got I
		//IL_0a17: Expected Obj, but got I
		//IL_0873: Expected I, but got Obj
		//IL_0722: Expected I, but got Obj
		//IL_060b: Expected native int or pointer, but got VT
		//IL_0623: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 128);
		if (!(label != null))
		{
			return;
		}
		if (~(mDoInit ? 1u : 0u) == 0)
		{
			Init();
		}
		bool flag = isSelected;
		string text = value;
		object obj2;
		if (text != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_0b70;
			}
		}
		obj2 = 1;
		goto IL_0b70;
		IL_04dc:
		string text2;
		label.text = text2;
		if (flag && (mKeyboard == null || inputShouldBeHidden))
		{
			int num = mSelectionStart - mDrawStart;
			int num2 = mSelectionEnd - mDrawStart;
			if (mBlankTex == null)
			{
				Texture2D texture2D = default;
				texture2D._002Ector(2, 2, TextureFormat.ARGB32, mipChain: false);
				mBlankTex = texture2D;
				int num3 = 0;
				while (true)
				{
					bool flag2 = num3 < 2;
					bool flag3 = !flag2;
					int num4 = 0;
					if (flag3)
					{
						break;
					}
					while (num4 < 2)
					{
						_ = 4575657222473777152L;
						((Color*)(nint)color)->b = 1f;
						_ = 4575657222473777152L;
						((Color*)(nint)color)->r = 1f;
						mBlankTex.SetPixel(num4, num3, color);
						int num5 = num4 + 1;
						num4 = num5;
					}
					int num6 = num3 + 1;
					num3 = num6;
				}
				mBlankTex.Apply();
			}
			bool flag4 = num == num2;
			if (!flag4)
			{
				if (mHighlight == null)
				{
					GameObject cachedGameObject = label.cachedGameObject;
					UITexture uITexture = NGUITools.AddWidget<UITexture>(cachedGameObject);
					mHighlight = uITexture;
					mHighlight.name = "Input Highlight";
					UITexture uITexture2 = mHighlight;
					nint num7 = (nint)uITexture2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v799 @ S2_v53 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
					UITexture uITexture3 = mHighlight;
					uITexture3.fillGeometry = false;
					UILabel uILabel = label;
					uITexture3.pivot = ((UIWidget)uILabel).mPivot;
					Transform cachedTransform = label.cachedTransform;
					mHighlight.SetAnchor(cachedTransform);
				}
				else
				{
					UILabel uILabel2 = label;
					mHighlight.pivot = ((UIWidget)uILabel2).mPivot;
					UITexture uITexture4 = mHighlight;
					nint num8 = (nint)uITexture4;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v635 @ S2_v44 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
					UITexture uITexture5 = mHighlight;
					nint num9 = (nint)uITexture5;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v644 @ S1_v103 (Il2CppClass<UITexture>)+1CC] (should have been resolved before IL gen)");
					mHighlight.enabled = true;
				}
			}
			if (mCaret == null)
			{
				GameObject cachedGameObject2 = label.cachedGameObject;
				UITexture uITexture6 = NGUITools.AddWidget<UITexture>(cachedGameObject2);
				mCaret = uITexture6;
				mCaret.name = "Input Caret";
				UITexture uITexture7 = mCaret;
				nint num10 = (nint)uITexture7;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v817 @ S2_v36 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
				UITexture uITexture8 = mCaret;
				uITexture8.fillGeometry = false;
				UILabel uILabel3 = label;
				uITexture8.pivot = ((UIWidget)uILabel3).mPivot;
				Transform cachedTransform2 = label.cachedTransform;
				mCaret.SetAnchor(cachedTransform2);
			}
			else
			{
				UILabel uILabel4 = label;
				mCaret.pivot = ((UIWidget)uILabel4).mPivot;
				UITexture uITexture9 = mCaret;
				nint num11 = (nint)uITexture9;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v658 @ S2_v27 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
				UITexture uITexture10 = mCaret;
				nint num12 = (nint)uITexture10;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v668 @ S1_v79 (Il2CppClass<UITexture>)+1CC] (should have been resolved before IL gen)");
				mCaret.enabled = true;
			}
			UITexture uITexture11 = mCaret;
			if (!flag4)
			{
				UITexture uITexture12 = mHighlight;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIInput)+48]");
				_ = 0;
				_ = caretColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIInput)+58]");
				_ = 0;
				_ = selectionColor;
				Color color2 = color - -64;
				Color highlightColor = color + 48;
				label.PrintOverlay(num, num2, uITexture11.geometry, uITexture12.geometry, color2, highlightColor);
				Behaviour behaviour = mHighlight;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v109 (UnityEngine.Behaviour)+8C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ S1_v69+8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ S1_v70+C]");
				bool flag5 = (nint)0 > (nint)0;
				behaviour.enabled = flag5;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIInput)+48]");
				_ = 0;
				_ = caretColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIInput)+58]");
				_ = 0;
				_ = selectionColor;
				Color color3 = color + 32;
				Color highlightColor2 = color + 16;
				label.PrintOverlay(num, num, uITexture11.geometry, null, color3, highlightColor2);
				if (mHighlight != null)
				{
					mHighlight.enabled = false;
				}
			}
			float unscaledTime = Time.unscaledTime;
			float num13 = unscaledTime + 0.5f;
			mNextBlink = num13;
			UILabel uILabel5 = label;
			mLastAlpha = uILabel5.finalAlpha;
		}
		else
		{
			nint num14 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v349 @ S1_v24 (Il2CppClass<UIInput>)+104] (should have been resolved before IL gen)");
		}
		return;
		IL_0b70:
		object obj5 = default;
		if (obj2 != null)
		{
			string compositionString = Input.compositionString;
			if (compositionString != null)
			{
				obj5 = 0;
				if (compositionString._stringLength != 0)
				{
					goto IL_0ca2;
				}
			}
			obj5 = 1;
		}
		goto IL_0ca2;
		IL_0ca2:
		string text3 = (string)(this + 48);
		string text4 = (string)(this + 116);
		object obj6 = obj5 ^ 1;
		object obj7 = obj6 | flag;
		if (obj7 == null)
		{
			text3 = text4;
		}
		_ = text3._stringLength;
		_ = text3._stringLength;
		Color color4 = color + 80;
		label.color = color4;
		if (obj5 != null)
		{
			if (flag)
			{
			}
			RestoreLabelPivot();
			text2 = string.Empty;
		}
		else
		{
			bool flag6 = inputType == InputType.Password;
			bool flag7 = !flag6;
			string text5 = text3;
			string text6 = text;
			if (!flag7)
			{
				UILabel uILabel6 = label;
				bool flag8 = uILabel6.mFont != null;
				bool flag9 = !flag8;
				text5 = "*";
				if (!flag9)
				{
					UILabel uILabel7 = label;
					BMFont bmFont = uILabel7.mFont.bmFont;
					bool flag10 = bmFont == null;
					text5 = "*";
					if (!flag10)
					{
						UILabel uILabel8 = label;
						BMFont bmFont2 = uILabel8.mFont.bmFont;
						BMGlyph glyph = bmFont2.GetGlyph(42);
						string text7 = "*";
						if (glyph == null)
						{
							text7 = "x";
						}
						text5 = text7;
					}
				}
				object obj8 = 0;
				string text8 = string.Empty;
				while (text._stringLength > (nint)obj8)
				{
					string text9 = text8 + text5;
					object obj9 = obj8 + 1;
					obj8 = obj9;
					text8 = text9;
				}
				text6 = text8;
			}
			bool flag11 = !flag;
			int num15 = 0;
			if (!flag11)
			{
				int num16 = text6._stringLength;
				int num17 = cursorPosition;
				if (num17 <= text6._stringLength)
				{
					num16 = num17;
				}
				num15 = num16;
			}
			string text10 = text6.Substring(0, num15);
			if (flag)
			{
				string compositionString2 = Input.compositionString;
				text10 += compositionString2;
			}
			int length = text6._stringLength - num15;
			string text11 = text6.Substring(num15, length);
			string text12 = text10 + text11;
			if (flag)
			{
				UILabel uILabel9 = label;
				if (uILabel9.mOverflow == UILabel.Overflow.ClampContent && uILabel9.mMaxLineCount == 1)
				{
					int num18 = uILabel9.CalculateOffsetToFit(text12);
					if (num18 == 0)
					{
						mDrawStart = 0;
						RestoreLabelPivot();
					}
					else if (num15 < mDrawStart)
					{
						mDrawStart = num15;
						SetPivotToLeft();
					}
					else if (mDrawStart > num18)
					{
						mDrawStart = num18;
						SetPivotToLeft();
					}
					else
					{
						string text13 = text12.Substring(0, num15);
						int num19 = label.CalculateOffsetToFit(text13);
						if (num19 > mDrawStart)
						{
							mDrawStart = num19;
							SetPivotToRight();
						}
					}
					bool flag12 = mDrawStart == 0;
					text2 = text12;
					if (!flag12)
					{
						int length2 = text12._stringLength - mDrawStart;
						string text14 = text12.Substring(mDrawStart, length2);
						text2 = text14;
					}
					goto IL_04dc;
				}
			}
			mDrawStart = 0;
			RestoreLabelPivot();
			text2 = text12;
		}
		goto IL_04dc;
	}

	protected void SetPivotToLeft()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Vector2 pivotOffset = NGUIMath.GetPivotOffset(mPivot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Vector2 offset = (Vector2)(obj + 8);
		UIWidget.Pivot pivot = NGUIMath.GetPivot(offset);
		label.pivot = pivot;
	}

	protected void SetPivotToRight()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Vector2 pivotOffset = NGUIMath.GetPivotOffset(mPivot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		_ = 0;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Vector2 offset = (Vector2)(obj + 8);
		UIWidget.Pivot pivot = NGUIMath.GetPivot(offset);
		label.pivot = pivot;
	}

	protected void RestoreLabelPivot()
	{
		if (label != null)
		{
			UILabel uILabel = label;
			if (mPivot != ((UIWidget)uILabel).mPivot)
			{
				uILabel.pivot = mPivot;
			}
		}
	}

	protected char Validate(string text, int pos, char ch)
	{
		//IL_0038: Expected Obj, but got I4
		//IL_097e: Expected Obj, but got I4
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_02e5: Expected Obj, but got I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_03e2: Expected Obj, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_0a0f: Expected Obj, but got I4
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected Obj, but got Unknown
		//IL_077d: Expected Obj, but got I4
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_05ab: Expected Obj, but got I4
		//IL_05e4: Expected Obj, but got I4
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected Obj, but got Unknown
		//IL_047e: Expected Obj, but got I4
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_0555: Expected Obj, but got I4
		if (validation == Validation.None || !enabled)
		{
			goto IL_09c2;
		}
		object obj = validation - 1;
		char c;
		if (validation != Validation.Integer)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj != 5)
							{
								goto IL_09b4;
							}
							if (ch <= '*')
							{
								if (ch <= '\n')
								{
									object obj2 = ch - 9;
									object obj3 = obj2 & 0xFFFF;
									if ((nint)obj3 >= 2)
									{
										goto IL_09c2;
									}
									c = '\0';
								}
								else
								{
									int num = ch | 8;
									if (num != 42)
									{
										goto IL_09c2;
									}
									c = '\0';
								}
							}
							else if (ch <= '>')
							{
								bool flag = ch == '/';
								c = '\0';
								if (!flag)
								{
									object obj4 = ch - 58;
									if ((nint)obj4 > 4 || (nint)obj4 == 3)
									{
										goto IL_09c2;
									}
									c = '\0';
								}
							}
							else
							{
								object obj5 = ch - 92;
								if ((nint)obj5 <= 4)
								{
									object obj6 = 1 << (int)obj5;
									object obj7 = obj6 & 0x15;
									if (obj7 == null)
									{
										goto IL_09c2;
									}
									c = '\0';
								}
								else
								{
									bool flag2 = ch == '|';
									c = '\0';
									if (!flag2)
									{
										goto IL_09c2;
									}
								}
							}
						}
						else
						{
							char c2;
							char c3;
							if (text._stringLength < 1)
							{
								c2 = ' ';
								c3 = '\n';
							}
							else
							{
								int num2 = text._stringLength - 1;
								if (pos <= num2)
								{
									num2 = pos;
								}
								bool flag3 = pos < 0;
								int index = 0;
								if (!flag3)
								{
									index = num2;
								}
								char c4 = text.get_Chars(index);
								bool flag4 = text._stringLength < 1;
								c2 = c4;
								c3 = '\n';
								if (!flag4)
								{
									int num3 = text._stringLength - 1;
									int num4 = pos + 1;
									if (num4 <= num3)
									{
										num3 = num4;
									}
									bool flag5 = num4 < 0;
									int index2 = 0;
									if (!flag5)
									{
										index2 = num3;
									}
									char c5 = text.get_Chars(index2);
									c2 = c4;
									c3 = c5;
								}
							}
							object obj8 = ch - 97;
							object obj9 = obj8 & 0xFFFF;
							if ((nint)obj9 <= 25)
							{
								bool flag6 = c2 != ' ';
								c = ch;
								if (!flag6)
								{
									char c6 = (char)(ch - 32);
									c = c6;
								}
							}
							else
							{
								object obj10 = ch - 65;
								object obj11 = obj10 & 0xFFFF;
								if ((nint)obj11 <= 25)
								{
									if (c2 == ' ')
									{
										goto IL_09c2;
									}
									bool flag7 = c2 == '\'';
									c = ch;
									if (!flag7)
									{
										char c7 = (char)(ch + 32);
										c = c7;
									}
								}
								else if (ch != ' ')
								{
									if (ch != '\'' || c2 == ' ' || c2 == '\'' || c3 == '\'' || text.Contains("'"))
									{
										goto IL_09b4;
									}
									c = '\'';
								}
								else
								{
									if (c2 == ' ' || c2 == '\'')
									{
										goto IL_09b4;
									}
									bool flag8 = c3 != '\'';
									char c8 = (char)((flag8 ? 1u : 0u) << 5);
									bool flag9 = c3 == ' ';
									char c9 = '\0';
									if (!flag9)
									{
										c9 = c8;
									}
									c = c9;
								}
							}
						}
					}
					else
					{
						object obj12 = ch - 65;
						object obj13 = obj12 & 0xFFFF;
						if ((nint)obj13 <= 25)
						{
							char c10 = (char)(ch + 32);
							c = c10;
						}
						else if (ch >= 'a')
						{
							if (ch > 'z')
							{
								goto IL_09b4;
							}
							c = ch;
						}
						else
						{
							object obj14 = ch - 48;
							object obj15 = obj14 & 0xFFFF;
							if ((nint)obj15 > 9)
							{
								goto IL_09b4;
							}
							c = ch;
						}
					}
				}
				else if (ch >= 'A')
				{
					if (ch < '[')
					{
						goto IL_09c2;
					}
					object obj16 = ch - 97;
					object obj17 = obj16 & 0xFFFF;
					if ((nint)obj17 > 25)
					{
						goto IL_09b4;
					}
					c = ch;
				}
				else
				{
					object obj18 = ch - 48;
					object obj19 = obj18 & 0xFFFF;
					bool flag10 = (nint)obj19 <= 9;
					c = ch;
					if (!flag10)
					{
						goto IL_09b4;
					}
				}
			}
			else if (ch >= '0')
			{
				if (ch > '9')
				{
					goto IL_09b4;
				}
				c = ch;
			}
			else if (pos == 0 && ch == '-')
			{
				if (text.Contains("-"))
				{
					goto IL_09b4;
				}
				c = '-';
			}
			else
			{
				if (ch != '.' || text.Contains("."))
				{
					goto IL_09b4;
				}
				c = '.';
			}
		}
		else if (ch >= '0')
		{
			if (ch > '9')
			{
				goto IL_09b4;
			}
			c = ch;
		}
		else
		{
			if (pos != 0 || ch != '-' || text.Contains("-"))
			{
				goto IL_09b4;
			}
			c = '-';
		}
		goto IL_09ee;
		IL_09b4:
		c = '\0';
		goto IL_09ee;
		IL_09c2:
		c = ch;
		goto IL_09ee;
		IL_09ee:
		return (char)(c & 0xFFFF);
	}

	protected void ExecuteOnChange()
	{
		if (current == null && EventDelegate.IsValid(onChange))
		{
			current = this;
			EventDelegate.Execute(onChange);
			current = null;
		}
	}

	public void RemoveFocus()
	{
		isSelected = false;
	}

	public void SaveValue()
	{
		SaveToPlayerPrefs(mValue);
	}

	public void LoadValue()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		string text = savedAs;
		object obj;
		if (savedAs != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00cb;
			}
		}
		obj = 1;
		goto IL_00cb;
		IL_00cb:
		if (obj == null)
		{
			string text2 = mValue.Replace("\\n", "\n");
			mValue = string.Empty;
			string text3 = ((!PlayerPrefs.HasKey(savedAs)) ? text2 : PlayerPrefs.GetString(savedAs));
			value = text3;
		}
	}

	public UIInput()
	{
		//IL_0083: Expected VT, but got I8
		//IL_0092: Expected VT, but got I8
		//IL_00a1: Expected VT, but got I8
		//IL_0052: Expected VT, but got I8
		_ = 4539628425447312782L;
		_ = 4561245704525185024L;
		_ = 4575657222473777152L;
		List<EventDelegate> list = default;
		list._002Ector();
		onSubmit = list;
		List<EventDelegate> list2 = default;
		list2._002Ector();
		onChange = list2;
		mDefaultText = string.Empty;
		mLoadSavedValue = true;
		mDoInit = true;
		_ = 4575657222473777152L;
		mDefaultColor = (Color)4575657222473777152L;
		mCached = string.Empty;
		mSelectMe = -1;
		base._002Ector();
	}
}
