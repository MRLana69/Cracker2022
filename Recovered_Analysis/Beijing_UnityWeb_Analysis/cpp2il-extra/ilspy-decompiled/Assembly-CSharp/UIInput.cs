using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using InAppPurchase;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;
using UnityEngine.Rendering;

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
	public bool selectAllTextOnFocus;

	public bool submitOnUnselect;

	public Validation validation;

	public int characterLimit;

	public string savedAs;

	private GameObject selectOnTab;

	public Color activeTextColor;

	public Color caretColor;

	public Color selectionColor;

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
	protected NGUIText.Alignment mAlignment;

	[NonSerialized]
	protected bool mLoadSavedValue;

	protected static int mDrawStart;

	protected static string mLastIME;

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
	protected bool mStarted;

	[NonSerialized]
	private UIInputOnGUI mOnGUI;

	[NonSerialized]
	private UICamera mCam;

	[NonSerialized]
	private bool mEllipsis;

	private static int mIgnoreKey;

	[NonSerialized]
	public Action onUpArrow;

	[NonSerialized]
	public Action onDownArrow;

	public string defaultText
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0094: Expected Obj, but got VT
			//IL_00b2: Expected Obj, but got I4
			//IL_00cf: Expected I, but got Obj
			//IL_00e5: Expected Obj, but got I
			UIInput uIInput = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)uIInput.savedAs))
					{
						uIInput = (UIInput)(object)savedAs;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					Font dynamicFont = ((UIFont)(object)uIInput).dynamicFont;
					if ((object)dynamicFont != null)
					{
						string[] fontNames = ((Font)uIInput.activeTextColor).fontNames;
						int renderQueue = ((Material)(object)fontNames).renderQueue;
						return (string)renderQueue;
					}
					return null;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_0034: Expected VT, but got Obj
			if (((UILabel)this).GetCharacterIndexAtPosition((Vector3)value, false) != 0)
			{
				UIAtlas atlas = ((UIFont)this).atlas;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
			}
			((UIFont)this).UpdateUVRect();
		}
	}

	public Color defaultColor
	{
		get
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004f: Expected Obj, but got VT
			//IL_002e: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+88]");
			Color color = default;
			if ((nint)0 != 0)
			{
				((UIInput)color).OnSelectEvent();
			}
			object obj = color + 112;
			obj = this;
			((UIInput)color).ExecuteOnChange();
			return color;
		}
		set
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_002e: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+88]");
			if ((nint)0 != 0)
			{
				((UIInput)value).OnSelectEvent();
			}
			object obj = value + 116;
			UIInput uIInput = (UIInput)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v3+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public bool inputShouldBeHidden
	{
		get
		{
			//IL_002b: Expected I4, but got Obj
			if (~(mDoInit ? 1u : 0u) == 0)
			{
				OnSelectEvent();
			}
			return (byte)(int)mDefaultText != 0;
		}
	}

	public unsafe string text
	{
		get
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_00f3: Expected Obj, but got I4
			if (~(hideInput ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)label).FindKernel((string)null) != 0)
				{
					UILabel uILabel = label;
					if (uILabel.mMaxLineCount != 1)
					{
						return null;
					}
					bool flag = inputType != InputType.Password;
					return (string)flag;
				}
				return null;
			}
			return null;
		}
		set
		{
			//IL_000d: Expected I4, but got Obj
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			//IL_002f: Expected Obj, but got I4
			//IL_007b: Expected I4, but got Obj
			UIWidget.Pivot pivot = default;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)value;
			_ = value.m_stringLength;
			object obj = this + 116;
			obj = ((UIWidget.Pivot*)(int)pivot)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UIWidget+Pivot)+8]");
			_ = 0;
			if (cursorPosition == 0)
			{
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)value;
				_ = value.m_stringLength;
				label.rawPivot = pivot;
			}
		}
	}

	public string value
	{
		get
		{
			//IL_000a: Expected Obj, but got I4
			return (string)selected;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			selected = (byte)(int)value != 0;
		}
	}

	public bool selected
	{
		get
		{
			//IL_002b: Expected I4, but got Obj
			if (~(mDoInit ? 1u : 0u) == 0)
			{
				OnSelectEvent();
			}
			return (byte)(int)mValue != 0;
		}
		set
		{
			((UILabel)this).ProcessText(value, true);
		}
	}

	public bool isSelected
	{
		get
		{
			return (byte)cursorPosition != 0;
		}
		set
		{
			cursorPosition = (value ? 1 : 0);
		}
	}

	public int cursorPosition
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIInput>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIInput);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UIInput>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (selection != this) ? 1 : 0;
		}
		set
		{
			//IL_001d: Expected I, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_00d2: Expected I, but got Obj
			//IL_00e8: Expected Obj, but got I
			//IL_005e: Expected I, but got Obj
			//IL_0113: Expected I, but got Obj
			if (value != 0)
			{
				string touch = tag;
				nint num = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v8 (Il2CppClass<UICamera>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v13 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.Raycast((UICamera.MouseOrTouch)(object)touch);
			}
			else
			{
				if (cursorPosition == 0)
				{
					return;
				}
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v10 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.Raycast(null);
			}
		}
	}

	public int selectionStart
	{
		get
		{
			if (cursorPosition != 0)
			{
				return mSelectionEnd;
			}
			bool flag = selected;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (System.Boolean)+8]");
			return 0;
		}
		set
		{
			if (cursorPosition != 0)
			{
				mSelectionEnd = value;
				ExecuteOnChange();
			}
		}
	}

	public int selectionEnd
	{
		get
		{
			if (cursorPosition != 0)
			{
				return mSelectionStart;
			}
			bool flag = selected;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (System.Boolean)+8]");
			return 0;
		}
		set
		{
			if (cursorPosition != 0)
			{
				mSelectionStart = value;
				ExecuteOnChange();
			}
		}
	}

	public UITexture caret
	{
		get
		{
			//IL_0050: Expected Obj, but got I
			//IL_0031: Expected Obj, but got I4
			if (cursorPosition != 0)
			{
				return (UITexture)mSelectionEnd;
			}
			bool flag = selected;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (System.Boolean)+8]");
			return (UITexture)0;
		}
	}

	public void Set(string value, bool notify = true)
	{
		//IL_000f: Expected VT, but got Obj
		//IL_003e: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		int characterIndexAtPosition = ((UILabel)this).GetCharacterIndexAtPosition((Vector3)value, false);
		if (characterIndexAtPosition != 0)
		{
			object obj = characterIndexAtPosition + 8;
			obj = notify;
		}
		((UIFont)this).UpdateUVRect();
	}

	public string Validate(string val)
	{
		//IL_004d: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		if (val == null || val.m_stringLength == 0)
		{
			return null;
		}
		bool isValid = ((UIFont)this).isValid;
		if (string.Equals(val, (string)isValid))
		{
			return (string)1;
		}
		UIAtlas atlas = ((UIFont)this).atlas;
		int num = 0;
		while (true)
		{
			if (num >= (nint)atlas.material)
			{
				return null;
			}
			UIAtlas atlas2 = ((UIFont)this).atlas;
			BMSymbol bMSymbol = ((List<BMSymbol>)(object)atlas2).get_Item(num);
			if (string.Equals(val, bMSymbol.spriteName))
			{
				break;
			}
			int num2 = num + 1;
			num = num2;
		}
		return (string)1;
	}

	public void Start()
	{
		//IL_0057: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got F4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		object obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0f;
		_ = 1f;
		_ = 1f;
		object obj2 = obj + 16;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj3 = this + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BMGlyph bMGlyph = default;
		bMGlyph._002Ector();
		object obj4 = this + 32;
		obj4 = bMGlyph;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj5 = this + 44;
		object obj6 = default;
		obj5 = obj6;
		_ = 16;
		object obj7 = this - -64;
		obj7 = -1;
		_ = -1;
		CancelInvoke();
	}

	protected void Init()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0221: Expected I4, but got Obj
		//IL_0221: Expected I4, but got Obj
		//IL_022f: Expected I4, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I4
		//IL_02f7: Expected I, but got Obj
		//IL_030d: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_0172: Expected I, but got Obj
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		if (~(mStarted ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)selectOnTab).FindKernel((string)null) != 0)
		{
			UIKeyNavigation component = GetComponent<UIKeyNavigation>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (component != null)
			{
				string text = tag;
				UIKeyNavigation uIKeyNavigation = ((GameObject)(object)text).AddComponent<UIKeyNavigation>();
				object obj3 = uIKeyNavigation + 20;
				obj3 = selectOnTab;
			}
			object obj4 = this + 44;
			obj4 = 0;
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v35 (Il2CppClass<NGUITools>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v38 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		if (~(mLoadSavedValue ? 1u : 0u) == 0)
		{
			string text2 = savedAs;
			if (savedAs != null && text2.m_stringLength != 0)
			{
				this._002Ector();
				goto IL_0234;
			}
		}
		string text3 = mValue.Remove((int)"\\n", (int)"\n");
		selected = (byte)(int)text3 != 0;
		goto IL_0234;
		IL_0234:
		mStarted = true;
	}

	protected void SaveToPlayerPrefs(string val)
	{
		//IL_0031: Expected I4, but got Obj
		if (cursorPosition != 0)
		{
			mSelectionEnd = (int)val;
			ExecuteOnChange();
		}
	}

	protected virtual void OnSelect(bool isSelected)
	{
		//IL_00b2: Expected Obj, but got I4
		string text = savedAs;
		if (savedAs != null && text.m_stringLength != 0)
		{
			bool flag;
			if (isSelected)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isSelected @ L1 (System.Boolean)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				((PropertyAttribute)(object)savedAs)._002Ector();
			}
			else
			{
				((TooltipAttribute)(object)savedAs)._002Ector((string)isSelected);
			}
		}
	}

	protected void OnSelectEvent()
	{
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0254: Expected VT, but got Obj
		//IL_0263: Expected F4, but got Obj
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01e0: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 16);
		if (~(mDoInit ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)label).FindKernel((string)null) == 0)
		{
			return;
		}
		mDoInit = false;
		object obj3 = this + 112;
		UILabel uILabel = label;
		obj3 = uILabel.mText;
		object obj4 = label + 80;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v18+8]");
		_ = 0;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		object obj5 = this + 116;
		obj5 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		UILabel uILabel2 = label;
		bool mOverflowEllipsis = uILabel2.mOverflowEllipsis;
		mEllipsis = mOverflowEllipsis;
		UILabel uILabel3 = label;
		if (uILabel3.mAlignment == NGUIText.Alignment.Justified)
		{
			label.applyGradient = true;
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v40 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v46 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogWarningFormat("Input fields using labels with justified alignment are not supported at this time", (object[])(object)this);
		}
		UILabel uILabel4 = label;
		mAlignment = uILabel4.mAlignment;
		Camera anchorCamera = label.anchorCamera;
		transform.localPosition = (Vector3)anchorCamera;
		mPosition = (float)transform;
		ExecuteOnChange();
	}

	protected void OnDeselectEvent()
	{
		//IL_029c: Expected I, but got Obj
		//IL_02b2: Expected Obj, but got I
		//IL_02cf: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_0196: Expected I, but got Obj
		//IL_01e3: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0224: Expected I, but got Obj
		int renderedFrameCount = Time.renderedFrameCount;
		mSelectTime = renderedFrameCount;
		nint num = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<UIInput>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(UIInput);
		if (!flag)
		{
			nint num3 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v41 (Il2CppClass<UIInput>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(UIInput);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(UIInput);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ L1_v2 (Il2CppClass<UIInput>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = this;
		if (~(mDoInit ? 1u : 0u) == 0)
		{
			OnSelectEvent();
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)label).FindKernel((string)null) != 0)
		{
			UILabel uILabel = label;
			bool mOverflowEllipsis = uILabel.mOverflowEllipsis;
			mEllipsis = mOverflowEllipsis;
			label.overflowWidth = 0;
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)label).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num8 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v26 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v33 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.GetActive((GameObject)(object)this))
		{
			int renderedFrameCount2 = Time.renderedFrameCount;
			mSelectMe = renderedFrameCount2;
		}
	}

	protected unsafe virtual void Update()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected I4, but got Unknown
		//IL_03ec: Expected I, but got Obj
		//IL_0402: Expected Obj, but got I
		//IL_041f: Expected I, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_047f: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I4
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_02f6: Expected I, but got Obj
		//IL_0326: Expected I, but got Obj
		//IL_01a3: Expected I, but got Obj
		//IL_034c: Expected I, but got Obj
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I4
		//IL_02c4: Expected I4, but got Obj
		//IL_0260: Expected I4, but got Obj
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_028d: Expected I4, but got Obj
		if (~(mDoInit ? 1u : 0u) == 0)
		{
			OnSelectEvent();
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)label).FindKernel((string)null) != 0)
		{
			bool overflowWidth = mEllipsis;
			label.overflowWidth = (overflowWidth ? 1 : 0);
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 16);
		if (((ComputeShader)(object)label).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v40 (Il2CppClass<NGUITools>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v65 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.GetActive((GameObject)(object)this))
			{
				object obj5 = this + 108;
				bool flag = selected;
				obj5 = flag;
				string text = mValue;
				if (mValue == null || text.m_stringLength == 0)
				{
					label.fontSize = (int)mDefaultText;
					object obj6 = this + 116;
					obj3 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S2_v14+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					label.rawPivot = pivot;
				}
				else
				{
					label.fontSize = (int)mValue;
				}
				Vector2 compositionCursorPos = Input.compositionCursorPos;
				label.applyGradient = (byte)mAlignment != 0;
			}
		}
		nint num7 = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v20 (Il2CppClass<UIInput>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		bool flag2 = obj7 == null;
		nint num8 = (nint)typeof(UIInput);
		if (!flag2)
		{
			nint num9 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v33 (Il2CppClass<UIInput>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num8 = (nint)typeof(UIInput);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num8 = (nint)typeof(UIInput);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ L1_v3 (Il2CppClass<UIInput>)+5C]");
		object obj8 = (nint)0 + (nint)4;
		obj8 = 0;
		ExecuteOnChange();
		if (~(submitOnUnselect ? 1u : 0u) == 0)
		{
			UpdateLabel();
		}
	}

	private void OnKey(KeyCode key)
	{
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01b8: Expected I, but got Obj
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_0373: Expected Obj, but got I4
		//IL_0246: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		if (key != KeyCode.None)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)label).FindKernel((string)null) != 0)
			{
				UILabel uILabel = label;
				if (~(uILabel.mEncoding ? 1u : 0u) == 0)
				{
					uILabel.mEncoding = false;
					((UIRect)uILabel).mChanged = true;
					uILabel.mShouldBeProcessed = true;
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mOnGUI != null)
			{
				object obj3 = this + 192;
				string text = tag;
				UIInputOnGUI uIInputOnGUI = ((GameObject)(object)text).AddComponent<UIInputOnGUI>();
				obj3 = uIInputOnGUI;
			}
			OnDeselectEvent();
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mOnGUI).FindKernel((string)null) != 0)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(mOnGUI);
			object obj6 = this + 192;
			obj6 = 0;
		}
		Update();
	}

	protected unsafe void DoBackspace()
	{
		//IL_14b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b7: Expected I4, but got Unknown
		//IL_14c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c5: Expected Obj, but got Unknown
		//IL_14ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d3: Expected Obj, but got Unknown
		//IL_14dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e1: Expected Obj, but got Unknown
		//IL_14ea: Expected Obj, but got I4
		//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f8: Expected Obj, but got Unknown
		//IL_1501: Expected Obj, but got I4
		//IL_150a: Unknown result type (might be due to invalid IL or missing references)
		//IL_150f: Expected Obj, but got Unknown
		//IL_1518: Expected Obj, but got I4
		//IL_181f: Expected I, but got Obj
		//IL_1835: Expected Obj, but got I
		//IL_0bd9: Expected I, but got Obj
		//IL_0bef: Expected Obj, but got I
		//IL_0aa8: Expected I, but got Obj
		//IL_0c1a: Expected I, but got Obj
		//IL_1598: Expected I, but got Obj
		//IL_15ae: Expected Obj, but got I
		//IL_1941: Expected I, but got Obj
		//IL_1957: Expected Obj, but got I
		//IL_0153: Expected I, but got Obj
		//IL_1982: Expected I, but got Obj
		//IL_1998: Expected Obj, but got I
		//IL_0d38: Expected I, but got Obj
		//IL_189e: Expected I, but got Obj
		//IL_18b4: Expected Obj, but got I
		//IL_18d1: Expected I, but got Obj
		//IL_15db: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e0: Expected Obj, but got Unknown
		//IL_1602: Expected I4, but got Obj
		//IL_162c: Expected I, but got Obj
		//IL_1642: Expected Obj, but got I
		//IL_0cd0: Expected Obj, but got I4
		//IL_1e05: Expected Obj, but got I
		//IL_1e0d: Expected Obj, but got I4
		//IL_0563: Expected Obj, but got I4
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected Obj, but got Unknown
		//IL_166d: Expected I, but got Obj
		//IL_1683: Expected Obj, but got I
		//IL_0e2f: Expected I, but got Obj
		//IL_0da1: Expected I, but got Obj
		//IL_0db7: Expected Obj, but got I
		//IL_0b70: Expected I, but got Obj
		//IL_0ba0: Expected I, but got Obj
		//IL_185b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1860: Expected Obj, but got Unknown
		//IL_01bd: Expected I, but got Obj
		//IL_19bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c0: Expected Obj, but got Unknown
		//IL_19c9: Expected Obj, but got I4
		//IL_19d5: Expected Obj, but got I4
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03d7: Expected I4, but got Obj
		//IL_03f1: Expected Obj, but got I4
		//IL_020a: Expected I, but got Obj
		//IL_0de2: Expected I, but got Obj
		//IL_0bc6: Expected I, but got Obj
		//IL_1793: Expected I, but got Obj
		//IL_17a9: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_1a3b: Expected I, but got Obj
		//IL_1a51: Expected Obj, but got I
		//IL_1d3e: Expected I4, but got Obj
		//IL_1d54: Expected VT, but got I4
		//IL_1d86: Expected Obj, but got I
		//IL_16bc: Expected I, but got Obj
		//IL_16d2: Expected Obj, but got I
		//IL_1e96: Expected Obj, but got I4
		//IL_0465: Expected I4, but got Obj
		//IL_0411: Expected I, but got Obj
		//IL_16f9: Expected Obj, but got I4
		//IL_0298: Expected I, but got Obj
		//IL_0f19: Expected I, but got Obj
		//IL_02e5: Expected I, but got Obj
		//IL_1036: Expected I, but got Obj
		//IL_104c: Expected Obj, but got I
		//IL_0332: Expected I, but got Obj
		//IL_0348: Expected Obj, but got I
		//IL_1aa6: Expected I, but got Obj
		//IL_1abc: Expected Obj, but got I
		//IL_1184: Expected I, but got Obj
		//IL_119a: Expected Obj, but got I
		//IL_173b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1740: Expected Obj, but got Unknown
		//IL_1762: Expected I4, but got Obj
		//IL_177c: Expected VT, but got I4
		//IL_177c: Expected Obj, but got I4
		//IL_1077: Expected I, but got Obj
		//IL_1b97: Expected Obj, but got I4
		//IL_0f95: Expected I, but got Obj
		//IL_0fab: Expected Obj, but got I
		//IL_0373: Expected I, but got Obj
		//IL_1b17: Expected I, but got Obj
		//IL_1b2d: Expected Obj, but got I
		//IL_10aa: Expected I, but got Obj
		//IL_11c5: Expected I, but got Obj
		//IL_1a7d: Expected Obj, but got I4
		//IL_10dd: Expected I, but got Obj
		//IL_10f3: Expected Obj, but got I
		//IL_12c8: Expected I, but got Obj
		//IL_12de: Expected Obj, but got I
		//IL_0fd6: Expected I, but got Obj
		//IL_1151: Expected I, but got Obj
		//IL_1be1: Expected I, but got Obj
		//IL_1bf7: Expected Obj, but got I
		//IL_111e: Expected I, but got Obj
		//IL_1309: Expected I, but got Obj
		//IL_1227: Expected I, but got Obj
		//IL_123d: Expected Obj, but got I
		//IL_1c52: Expected I, but got Obj
		//IL_1c68: Expected Obj, but got I
		//IL_133c: Expected I, but got Obj
		//IL_1433: Expected I, but got Obj
		//IL_1449: Expected Obj, but got I
		//IL_1bb8: Expected Obj, but got I4
		//IL_136f: Expected I, but got Obj
		//IL_1385: Expected Obj, but got I
		//IL_1cc5: Expected Obj, but got I4
		//IL_1268: Expected I, but got Obj
		//IL_13e3: Expected I, but got Obj
		//IL_1474: Expected I, but got Obj
		//IL_13b0: Expected I, but got Obj
		//IL_14a4: Expected Obj, but got I4
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj - -64);
		object obj2 = obj + 16;
		object obj3 = obj + 32;
		object obj4 = obj + 40;
		obj4 = 0;
		object obj5 = obj + 80;
		obj5 = 0;
		object obj6 = obj + 48;
		obj6 = 0;
		_ = 0;
		if (cursorPosition == 0)
		{
			return;
		}
		int renderedFrameCount = Time.renderedFrameCount;
		if (mSelectTime == renderedFrameCount)
		{
			return;
		}
		if (~(mDoInit ? 1u : 0u) == 0)
		{
			OnSelectEvent();
		}
		if (mSelectMe != -1)
		{
			int renderedFrameCount2 = Time.renderedFrameCount;
			if (mSelectMe != renderedFrameCount2)
			{
				mSelectMe = -1;
				string text = mValue;
				int num;
				if (mValue == null || text.m_stringLength == 0)
				{
					num = 0;
				}
				else
				{
					string text2 = mValue;
					num = text2.m_stringLength;
				}
				mSelectionEnd = num;
				nint num2 = (nint)typeof(UIInput);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v325 (Il2CppClass<UIInput>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num3 = (nint)typeof(UIInput);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v433 (Il2CppClass<UIInput>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				mDrawStart = 0;
				int num4 = ((~(selectAllTextOnFocus ? 1u : 0u) != 0) ? mSelectionEnd : 0);
				mSelectionStart = num4;
				object obj8 = this + 48;
				obj2 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S2_v49+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				label.rawPivot = pivot;
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v335 (Il2CppClass<UICamera>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v427 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v343 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v423 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)UICamera.current).FindKernel((string)null) != 0)
				{
					nint num9 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v386 (Il2CppClass<UICamera>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num10 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v417 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UICamera.IsPartOfUI((GameObject)(object)UICamera.current);
					nint num11 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S1_v238 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num12 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ S1_v260 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)flag).FindKernel(null) != 0)
					{
						nint num13 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ S0_v397 (Il2CppClass<UICamera>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num14 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S0_v412 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag2 = UICamera.IsPartOfUI((GameObject)(object)UICamera.current);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj15 = default;
						object obj14 = obj15 + 16;
						obj2 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ S1_v247+8]");
						_ = 0;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
						_ = 0;
						Vector3 vector = ((Camera)flag2).WorldToViewportPoint((Vector3)pivot);
						obj6 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						goto IL_1785;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj17 = default;
				object obj16 = obj17 + 16;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S1_v227+8]");
				_ = 0;
				obj6 = ((UIWidget.Pivot*)(int)pivot)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIWidget+Pivot)+8]");
				_ = 0;
				goto IL_1785;
			}
		}
		goto IL_1545;
		IL_1408:
		UICamera uICamera = mCam;
		if (uICamera.useKeyboard)
		{
			return;
		}
		nint num15 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ S0_v92 (Il2CppClass<UICamera>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num16 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ S0_v102 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.GetKeyUp.EndInvoke((IAsyncResult)9))
		{
			Insert((string)9);
		}
		return;
		IL_1292:
		bool flag3;
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		else
		{
			nint num17 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S0_v110 (Il2CppClass<UICamera>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num18 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ S0_v137 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch controller = UICamera.controller;
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)controller.current).FindKernel((string)null) != 0)
			{
				nint num21 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ S0_v125 (Il2CppClass<UICamera>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num22 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ S0_v132 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch controller2 = UICamera.controller;
				controller2.clickNotification = UICamera.ClickNotification.None;
			}
			nint num23 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ S1_v71 (Il2CppClass<UICamera>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num24 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ S1_v77 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray currentRay = UICamera.currentRay;
			UpdateLabel();
		}
		goto IL_1408;
		IL_1785:
		nint num25 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S0_v352 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num26 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S0_v376 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+8]");
		_ = 0;
		Vector3 vector2 = (Vector2)pivot;
		obj4 = obj2;
		int sleepTimeout = Screen.sleepTimeout;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		object obj24 = (nint)sleepTimeout - (nint)0;
		Vector2 compositionCursorPos = Input.compositionCursorPos;
		obj3 = obj4;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Input.get_mousePosition_Injected(out *(Vector3*)(int)pivot);
		ExecuteOnChange();
		bool flag4;
		if (Input.imeCompositionMode != IMECompositionMode.Auto)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S0_v370 (UnityEngine.IMECompositionMode)+8]");
			flag4 = (nint)0 == 0;
		}
		else
		{
			flag4 = true;
		}
		if (!flag4)
		{
			goto IL_1545;
		}
		return;
		IL_1176:
		nint num27 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ S0_v79 (Il2CppClass<UICamera>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num28 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v161 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera uICamera2 = mCam;
		if (UICamera.GetKeyDown.EndInvoke((IAsyncResult)uICamera2.submitKey1))
		{
			goto IL_1292;
		}
		UICamera uICamera3 = mCam;
		if (uICamera3.submitKey1 == KeyCode.Return)
		{
			nint num29 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S0_v148 (Il2CppClass<UICamera>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num30 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ S0_v156 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UICamera.GetKeyDown.EndInvoke((IAsyncResult)271))
			{
				goto IL_1292;
			}
		}
		goto IL_1408;
		IL_1545:
		bool mousePresent = Input.mousePresent;
		bool flag5;
		if (mousePresent)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v36 (System.Boolean)+8]");
			flag5 = (nint)0 == 0;
		}
		else
		{
			flag5 = true;
		}
		if (flag5)
		{
			bool flag6;
			if (Input.imeCompositionMode != IMECompositionMode.Auto)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v290 (UnityEngine.IMECompositionMode)+8]");
				flag6 = (nint)0 == 0;
			}
			else
			{
				flag6 = true;
			}
			if (!flag6)
			{
				IMECompositionMode imeCompositionMode = Input.imeCompositionMode;
				char[] array = null;
				while (true)
				{
					char[] array2 = array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v294 (UnityEngine.IMECompositionMode)+8]");
					if ((nint)array2 >= 0)
					{
						break;
					}
					string[] array3 = ((string)imeCompositionMode).Split(array);
					obj5 = array3;
					object obj27 = array3 & 0xFFFF;
					if ((nint)obj27 >= 32)
					{
						object obj28 = (object)array3 << 16;
						object obj29 = obj28 >> 16;
						object obj30 = obj29 - -2304;
						if ((nint)obj29 != -2304 && (nint)obj30 != 1 && (nint)obj30 != 2 && (nint)obj30 != 3 && ((nint)obj30 == 4 || (nint)obj30 == 5 || (nint)obj30 == 6 || (nint)obj30 == 7 || (nint)obj30 == 8 || (nint)obj30 == 9 || (nint)obj30 == 10 || (nint)obj30 == 11 || (nint)obj30 == 12 || (nint)obj30 == 13 || (nint)obj30 == 14 || (nint)obj30 == 15 || (nint)obj30 == 16 || (nint)obj30 == 17 || (nint)obj30 == 18 || (nint)obj30 == 19 || (nint)obj30 == 20 || (nint)obj30 == 21 || (nint)obj30 == 22 || (nint)obj30 == 23 || (nint)obj30 == 24 || (nint)obj30 == 25 || (nint)obj30 == 26 || (nint)obj30 == 27 || (nint)obj30 == 28 || (nint)obj30 == 29 || (nint)obj30 == 30 || (nint)obj30 == 31 || (nint)obj30 == 32 || (nint)obj30 == 33 || (nint)obj30 == 34 || (nint)obj30 == 35 || (nint)obj30 == 36 || (nint)obj30 == 37 || (nint)obj30 == 38 || (nint)obj30 == 39 || (nint)obj30 != 40))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						}
					}
					char[] array4 = (char[])(array + 1);
					array = array4;
				}
			}
		}
		nint num31 = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v40 (Il2CppClass<UIInput>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num32 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v283 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mLastIME.get_Chars(mousePresent ? 1 : 0) != '\0')
		{
			bool flag7;
			if (mousePresent)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v36 (System.Boolean)+8]");
				flag7 = (nint)0 == 0;
			}
			else
			{
				flag7 = true;
			}
			int num33;
			if (flag7)
			{
				num33 = mSelectionStart;
			}
			else
			{
				string text3 = mValue;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v36 (System.Boolean)+8]");
				num33 = (int)((nint)0 + (nint)text3.m_stringLength);
			}
			mSelectionEnd = num33;
			nint num34 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v268 (Il2CppClass<UIInput>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			bool flag8 = obj32 == null;
			nint num35 = (nint)typeof(UIInput);
			if (!flag8)
			{
				nint num36 = (nint)typeof(UIInput);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v277 (Il2CppClass<UIInput>)+74]");
				bool flag9 = (nint)0 == 0;
				bool flag10 = !flag9;
				num35 = (nint)typeof(UIInput);
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num35 = (nint)typeof(UIInput);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ L1_v46 (Il2CppClass<UIInput>)+5C]");
			object obj33 = (nint)0 + (nint)12;
			obj33 = mousePresent;
			ExecuteOnChange();
			RemoveFocus();
		}
		nint num37 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num38 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v150 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mCaret).FindKernel((string)null) != 0)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			if (mNextBlink < unscaledDeltaTime)
			{
				float unscaledDeltaTime2 = Time.unscaledDeltaTime;
				float num39 = unscaledDeltaTime2 + 0.5f;
				mNextBlink = num39;
				bool flag11 = mCaret.isActiveAndEnabled;
				string text4 = (string)((flag11 ? 1 : 0) ^ 1);
				mCaret.tag = text4;
			}
		}
		if (cursorPosition != 0)
		{
			UILabel uILabel = label;
			if (mLastAlpha != uILabel.finalAlpha)
			{
				ExecuteOnChange();
			}
		}
		nint num40 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num41 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S1_v133 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mCam != null)
		{
			string text5 = tag;
			bool activeSelf = ((GameObject)(object)text5).activeSelf;
			nint num42 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ S0_v246 (Il2CppClass<UICamera>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num43 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S0_v252 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj37 = this + 196;
			int direction = UICamera.GetDirection((string)activeSelf);
			obj37 = direction;
		}
		nint num44 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		if (obj38 != null)
		{
			nint num45 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S1_v123 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mCam).FindKernel((string)null) == 0)
		{
			return;
		}
		UILabel uILabel2 = label;
		if (uILabel2.mMaxLineCount != 1)
		{
			bool flag12 = Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.RightControl);
			bool flag13 = flag12;
			bool flag14 = !flag12;
			bool flag15 = onReturnKey == OnReturnKey.Submit;
			bool flag16 = !flag15;
			flag3 = flag14;
			if (!flag16)
			{
				flag3 = flag13;
			}
		}
		else
		{
			flag3 = false;
		}
		nint num46 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ S0_v69 (Il2CppClass<UICamera>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num47 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ S0_v220 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera uICamera4 = mCam;
		if (UICamera.GetKeyDown.EndInvoke((IAsyncResult)uICamera4.submitKey0))
		{
			goto IL_1000;
		}
		UICamera uICamera5 = mCam;
		if (uICamera5.submitKey0 == KeyCode.Return)
		{
			nint num48 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ S0_v207 (Il2CppClass<UICamera>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num49 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ S0_v215 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UICamera.GetKeyDown.EndInvoke((IAsyncResult)271))
			{
				goto IL_1000;
			}
		}
		goto IL_1176;
		IL_1000:
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		else
		{
			nint num50 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ S0_v169 (Il2CppClass<UICamera>)+BA]");
			object obj41 = (nint)0 & (nint)0x200;
			if (obj41 != null)
			{
				nint num51 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ S0_v196 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch controller3 = UICamera.controller;
			nint num52 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S1_v92 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			if (obj42 != null)
			{
				nint num53 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)controller3.current).FindKernel((string)null) != 0)
			{
				nint num54 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ S0_v184 (Il2CppClass<UICamera>)+BA]");
				object obj43 = (nint)0 & (nint)0x200;
				if (obj43 != null)
				{
					nint num55 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ S0_v191 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch controller4 = UICamera.controller;
				controller4.clickNotification = UICamera.ClickNotification.None;
			}
			nint num56 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ S1_v99 (Il2CppClass<UICamera>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num57 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ S1_v105 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray currentRay2 = UICamera.currentRay;
			UpdateLabel();
		}
		goto IL_1176;
	}

	public unsafe virtual bool ProcessEvent(Event ev)
	{
		//IL_0056: Expected Obj, but got I
		//IL_0035: Expected I4, but got Obj
		//IL_01d3: Expected Obj, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I4
		//IL_021c: Expected I4, but got Obj
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_014f: Expected I4, but got Obj
		//IL_0173: Expected I4, but got Obj
		//IL_0161: Expected Obj, but got I4
		if (ev == null || ev.m_Ptr == (IntPtr)0)
		{
			return (byte)(int)"" != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector((string)(nint)ev.m_Ptr);
		char[] array = default;
		string[] array4 = default;
		string text = default;
		char[] array5 = default;
		while ((nint)array < (nint)ev.m_Ptr)
		{
			string[] array2 = ((string)(object)ev).Split(array);
			string[] array3;
			if (onValidate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BD6");
				array3 = array4;
			}
			else
			{
				bool flag = validation == Validation.None;
				array3 = array2;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					bool flag2 = ((UILabel)this).Wrap(text, out *(string*)(stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset), (int)array2);
					array3 = (string[])flag2;
				}
			}
			object obj2 = array3 & 0xFFFF;
			if (obj2 != null)
			{
				StringBuilder stringBuilder2 = stringBuilder.Append((int)array3);
			}
			array = (char[])(array5 + 1);
		}
		if (characterLimit >= 1)
		{
			object obj3 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
			if ((nint)obj3 > characterLimit)
			{
				StringBuilder stringBuilder3 = stringBuilder.Append('\0', characterLimit);
				return (byte)(int)stringBuilder3 != 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	protected virtual void Insert(string text)
	{
		//IL_02d6: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01e3: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_03cf: Expected I, but got Obj
		//IL_03e5: Expected Obj, but got I
		//IL_0224: Expected I, but got Obj
		//IL_0196: Expected I, but got Obj
		//IL_0271: Expected I, but got Obj
		int renderedFrameCount = Time.renderedFrameCount;
		nint num = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UIInput>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v84 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mIgnoreKey == renderedFrameCount)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v80 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mCam).FindKernel((string)null) != 0)
		{
			UICamera uICamera = mCam;
			if ((nint)uICamera.cancelKey0 != (nint)text)
			{
				UICamera uICamera2 = mCam;
				if ((nint)uICamera2.cancelKey1 != (nint)text)
				{
					goto IL_0361;
				}
			}
			nint num5 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v63 (Il2CppClass<UIInput>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UIInput);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v70 (Il2CppClass<UIInput>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mIgnoreKey = renderedFrameCount;
			cursorPosition = 0;
			return;
		}
		goto IL_0361;
		IL_0361:
		if ((nint)text != 9)
		{
			return;
		}
		nint num7 = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v30 (Il2CppClass<UIInput>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v51 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mIgnoreKey = renderedFrameCount;
		cursorPosition = 0;
		UIKeyNavigation component = GetComponent<UIKeyNavigation>();
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	protected string GetLeftText()
	{
		return (string)(object)mCaret;
	}

	protected unsafe string GetRightText()
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_012c: Expected Obj, but got I
		//IL_0152: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I4
		//IL_009b: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Vector2 vector = default;
		object obj = vector + 16;
		obj = mSelectionStart;
		object obj2 = vector + 20;
		obj2 = mSelectionEnd;
		object obj3 = vector + 24;
		string text = mValue;
		obj3 = text.m_stringLength;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = ((Vector2*)vector)->ToString();
		bool flag = (nint)text2 < 0;
		string text3 = mValue;
		bool flag2 = mValue == null || text3.m_stringLength == 0;
		object obj5 = flag | flag2;
		if (obj5 != null)
		{
			return "";
		}
		return mValue.InternalSubString(0, (int)text2);
	}

	protected string GetSelection()
	{
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I4
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = mSelectionStart <= mSelectionEnd;
		bool flag2 = !flag;
		char[] array = (char[])mSelectionStart;
		if (!flag2)
		{
			array = (char[])mSelectionEnd;
		}
		string text = mValue;
		if (mValue != null && text.m_stringLength != 0)
		{
			string text2 = mValue;
			if ((nint)array < text2.m_stringLength)
			{
				return mValue.Trim(array);
			}
		}
		return "";
	}

	protected int GetCharUnderMouse()
	{
		//IL_0129: Expected I4, but got Obj
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_009b: Expected I, but got Obj
		//IL_01f1: Expected I4, but got Obj
		string text = mValue;
		bool flag = mValue == null || text.m_stringLength == 0;
		if (!flag && mSelectionStart != mSelectionEnd)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3;
			int startIndex;
			if (mSelectionStart < mSelectionEnd)
			{
				num3 = mSelectionStart;
				startIndex = mSelectionStart;
			}
			else
			{
				num3 = mSelectionEnd;
				startIndex = mSelectionEnd;
			}
			int num4 = mSelectionStart;
			if (mSelectionStart <= mSelectionEnd)
			{
				num4 = mSelectionEnd;
			}
			int length = num4 - num3;
			string text2 = mValue.InternalSubString(startIndex, length);
			return (int)text2;
		}
		return (int)"";
	}

	protected unsafe virtual void OnPress(bool isPressed)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_030b: Expected I4, but got Obj
		//IL_01df: Expected I4, but got Obj
		//IL_032f: Expected I4, but got Obj
		//IL_031c: Expected Obj, but got I4
		//IL_0203: Expected I4, but got Obj
		//IL_01f1: Expected Obj, but got I4
		string rightText = GetRightText();
		string text = GetSelection();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = text.m_stringLength + rightText.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+8]");
		string text2 = (string)(0 + obj);
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(text2);
		StringBuilder stringBuilder2 = stringBuilder.AppendLine(rightText);
		char[] array = null;
		string[] array5 = default;
		string text3 = default;
		while (true)
		{
			char[] array2 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+8]");
			if ((nint)array2 >= 0)
			{
				break;
			}
			string[] array3 = ((string)isPressed).Split(array);
			object obj2 = array3 & 0xFFFF;
			if ((nint)obj2 == 8)
			{
				OnDisable();
			}
			else
			{
				if (characterLimit >= 1)
				{
					object obj3 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
					object obj4 = text.m_stringLength + obj3;
					if ((nint)obj4 >= characterLimit)
					{
						break;
					}
				}
				string[] array4;
				if (onValidate != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj5 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BD6");
					array4 = array5;
				}
				else
				{
					bool flag = validation == Validation.None;
					array4 = array3;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						bool flag2 = ((UILabel)this).Wrap(text3, out *(string*)(stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset), (int)array3);
						array4 = (string[])flag2;
					}
				}
				object obj6 = array4 & 0xFFFF;
				if (obj6 != null)
				{
					StringBuilder stringBuilder3 = stringBuilder.Append((int)array4);
				}
			}
			char[] array6 = (char[])(array + 1);
			array = array6;
		}
		int num = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
		mSelectionStart = num;
		mSelectionEnd = mSelectionStart;
		char[] array7 = null;
		string[] array10 = default;
		string text4 = default;
		while ((nint)array7 < text.m_stringLength)
		{
			string[] array8 = text.Split(array7);
			string[] array9;
			if (onValidate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj7 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BD6");
				array9 = array10;
			}
			else
			{
				bool flag3 = validation == Validation.None;
				array9 = array8;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					bool flag4 = ((UILabel)this).Wrap(text4, out *(string*)(stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset), (int)array8);
					array9 = (string[])flag4;
				}
			}
			object obj8 = array9 & 0xFFFF;
			if (obj8 != null)
			{
				StringBuilder stringBuilder4 = stringBuilder.Append((int)array9);
			}
			char[] array11 = (char[])(array7 + 1);
			array7 = array11;
		}
		object obj9 = this + 108;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj10 = default;
		obj9 = obj10;
		ExecuteOnChange();
		RemoveFocus();
	}

	protected virtual void OnDrag(Vector2 delta)
	{
		//IL_026d: Invalid comparison between VT and I4
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_0197: Expected I, but got Obj
		if (delta == (Vector2)(object)0 || cursorPosition == 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)label).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v13 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v40 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentKey != KeyCode.None)
		{
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (Il2CppClass<UICamera>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v36 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KeyCode currentKey = UICamera.currentKey;
			if (currentKey != (KeyCode)1)
			{
				return;
			}
		}
		int finalFontSize = ((UILabel)this).finalFontSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A1D1");
		if (!Input.GetKeyUp(KeyCode.LeftShift) && !Input.GetKeyUp(KeyCode.RightShift))
		{
			selectionEnd = mSelectionEnd;
		}
	}

	private void OnDisable()
	{
		string text = mValue;
		if (mValue == null || text.m_stringLength == 0)
		{
			return;
		}
		if (mSelectionStart == mSelectionEnd)
		{
			if (mSelectionStart < 1)
			{
				return;
			}
			int num = mSelectionEnd - 1;
			mSelectionEnd = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	protected virtual void Cleanup()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public void Submit()
	{
		//IL_022c: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_0151: Expected I, but got Obj
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I4
		//IL_01df: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mHighlight))
		{
			mHighlight.tag = null;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mCaret))
		{
			mCaret.tag = null;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mBlankTex))
		{
			return;
		}
		nint num7 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v24 (Il2CppClass<NGUITools>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v31 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.DestroyChildren((Transform)(object)mBlankTex);
		object obj5 = this + 164;
		obj5 = 0;
	}

	public void UpdateLabel()
	{
		//IL_0234: Expected I, but got Obj
		//IL_024a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0275: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I
		//IL_00be: Expected I, but got Obj
		//IL_02b4: Expected I4, but got Obj
		//IL_010b: Expected I, but got Obj
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_02cd: Expected I, but got Obj
		//IL_02e3: Expected Obj, but got I
		//IL_0199: Expected I, but got Obj
		//IL_01e6: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!NGUITools.GetActive((GameObject)(object)this))
		{
			return;
		}
		object obj2 = this + 108;
		bool flag = selected;
		obj2 = flag;
		nint num3 = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<UIInput>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v44 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (current != null)
		{
			nint num7 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v27 (Il2CppClass<UIInput>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(UIInput);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v38 (Il2CppClass<UIInput>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			current = this;
			nint num9 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v21 (Il2CppClass<EventDelegate>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v27 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Localization.dictionary = (Dictionary<string, string[]>)(object)onSubmit;
			current = null;
		}
		OnSelect((byte)(int)mValue != 0);
	}

	protected char Validate(string text, int pos, char ch)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_013b: Expected I4, but got Obj
		//IL_014c: Expected I4, but got Obj
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		GameObject gameObject = selectOnTab;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (UnityEngine.GameObject)+C]");
		char result;
		if ((nint)0 != 0)
		{
			object obj = ch - pos;
			int num2 = default;
			int num3 = default;
			while (true)
			{
				int num = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (UnityEngine.GameObject)+C]");
				if ((nint)num >= (nint)0)
				{
					result = '\0';
					break;
				}
				BMSymbol bMSymbol = ((List<BMSymbol>)(object)selectOnTab).get_Item(num2);
				if (bMSymbol.mLength == 0)
				{
					string sequence = bMSymbol.sequence;
					bMSymbol.mLength = sequence.m_stringLength;
				}
				bool flag = bMSymbol.mLength == 0;
				bool flag2 = (nint)obj < bMSymbol.mLength;
				object obj2 = flag | flag2;
				if (obj2 == null)
				{
					char[] array = null;
					while ((nint)array < bMSymbol.mLength)
					{
						char[] separator = (char[])(array + pos);
						string[] array2 = text.Split(separator);
						object obj3 = array2 & 0xFFFF;
						string[] array3 = bMSymbol.sequence.Split(array);
						object obj4 = array3 & 0xFFFF;
						if (obj3 != obj4)
						{
							goto IL_01ea;
						}
						char[] array4 = (char[])(array + 1);
						array = array4;
					}
					Material material = ((UIFont)this).material;
					string text2 = ((ByteReader)(object)bMSymbol).ReadLine((byte)(int)material != 0);
					result = (char)(int)bMSymbol;
					if (text2 != null)
					{
						break;
					}
				}
				goto IL_01ea;
				IL_01ea:
				num2 = num3 + 1;
			}
		}
		else
		{
			result = '\0';
		}
		return result;
	}

	protected unsafe void ExecuteOnChange()
	{
		//IL_1316: Unknown result type (might be due to invalid IL or missing references)
		//IL_131b: Expected Obj, but got Unknown
		//IL_1324: Expected Obj, but got I4
		//IL_1338: Expected I, but got Obj
		//IL_134e: Expected Obj, but got I
		//IL_18fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1900: Expected I4, but got Unknown
		//IL_1909: Unknown result type (might be due to invalid IL or missing references)
		//IL_190e: Expected I4, but got Unknown
		//IL_1917: Unknown result type (might be due to invalid IL or missing references)
		//IL_191c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02ad: Expected I4, but got Obj
		//IL_02c7: Expected Obj, but got I4
		//IL_02e1: Expected I4, but got Obj
		//IL_0351: Expected I, but got Obj
		//IL_0367: Expected Obj, but got I
		//IL_05c5: Expected Obj, but got I4
		//IL_1420: Expected I4, but got Obj
		//IL_151b: Expected Obj, but got I4
		//IL_152c: Expected I4, but got Obj
		//IL_04e3: Expected I, but got Obj
		//IL_04f9: Expected Obj, but got I
		//IL_1437: Expected Obj, but got I4
		//IL_1440: Expected I4, but got Obj
		//IL_0392: Expected I, but got Obj
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0236: Expected I4, but got Obj
		//IL_0250: Expected Obj, but got I4
		//IL_026a: Expected I4, but got Obj
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0136: Expected I4, but got Obj
		//IL_0150: Expected Obj, but got I4
		//IL_016a: Expected I4, but got Obj
		//IL_155b: Expected I, but got Obj
		//IL_1571: Expected Obj, but got I
		//IL_0405: Expected I4, but got Obj
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01c0: Expected I4, but got Obj
		//IL_01da: Expected Obj, but got I4
		//IL_01f4: Expected I4, but got Obj
		//IL_196c: Expected I4, but got Obj
		//IL_0524: Expected I, but got Obj
		//IL_030a: Expected I4, but got Obj
		//IL_0ada: Expected I, but got Obj
		//IL_14d2: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04b4: Expected I4, but got Obj
		//IL_043d: Expected Obj, but got I4
		//IL_0b36: Expected I, but got Obj
		//IL_0b4c: Expected Obj, but got I
		//IL_0469: Expected I4, but got Obj
		//IL_1733: Expected Obj, but got I4
		//IL_1743: Expected Obj, but got I4
		//IL_1751: Expected I, but got Obj
		//IL_1767: Expected Obj, but got I
		//IL_0b77: Expected I, but got Obj
		//IL_066e: Expected I, but got Obj
		//IL_0684: Expected Obj, but got I
		//IL_0480: Expected I4, but got Obj
		//IL_0bc4: Expected I, but got Obj
		//IL_181c: Expected I, but got Obj
		//IL_1832: Expected Obj, but got I
		//IL_0c2a: Expected VT, but got I4
		//IL_0d2c: Expected I, but got Obj
		//IL_0d42: Expected Obj, but got I
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected Obj, but got Unknown
		//IL_1615: Expected I, but got Obj
		//IL_162b: Expected Obj, but got I
		//IL_09a5: Expected I, but got Obj
		//IL_15ab: Expected I, but got Obj
		//IL_15c1: Expected Obj, but got I
		//IL_0f06: Expected I, but got Obj
		//IL_06e2: Expected I, but got Obj
		//IL_1087: Expected Obj, but got I4
		//IL_0f62: Expected I, but got Obj
		//IL_0f78: Expected Obj, but got I
		//IL_0e1a: Expected I, but got Obj
		//IL_0e30: Expected Obj, but got I
		//IL_0d6d: Expected I, but got Obj
		//IL_0a4c: Expected I, but got Obj
		//IL_0a62: Expected Obj, but got I
		//IL_09f2: Expected I, but got Obj
		//IL_1890: Unknown result type (might be due to invalid IL or missing references)
		//IL_1895: Expected Obj, but got Unknown
		//IL_18b6: Expected I4, but got Obj
		//IL_1855: Unknown result type (might be due to invalid IL or missing references)
		//IL_185a: Expected Obj, but got Unknown
		//IL_187b: Expected I4, but got Obj
		//IL_0c5c: Expected VT, but got I4
		//IL_171d: Expected I4, but got Obj
		//IL_0a39: Expected I4, but got Obj
		//IL_07aa: Expected I, but got Obj
		//IL_11fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1201: Expected Obj, but got Unknown
		//IL_121c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1221: Expected Obj, but got Unknown
		//IL_1243: Expected I4, but got Obj
		//IL_125d: Expected I4, but got Obj
		//IL_1297: Expected Obj, but got I4
		//IL_0fa3: Expected I, but got Obj
		//IL_0e5b: Expected I, but got Obj
		//IL_0df3: Expected Obj, but got I4
		//IL_178d: Invalid comparison between VT and I4
		//IL_0a8d: Expected I, but got Obj
		//IL_0899: Expected I, but got Obj
		//IL_08af: Expected Obj, but got I
		//IL_07f7: Expected I, but got Obj
		//IL_080d: Expected Obj, but got I
		//IL_0753: Expected I, but got Obj
		//IL_12c7: Expected Obj, but got I4
		//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ba: Expected Obj, but got Unknown
		//IL_10d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10da: Expected Obj, but got Unknown
		//IL_10fc: Expected I4, but got Obj
		//IL_1116: Expected I4, but got Obj
		//IL_1148: Expected Obj, but got I4
		//IL_1156: Expected I, but got Obj
		//IL_116c: Expected Obj, but got I
		//IL_08da: Expected I, but got Obj
		//IL_0838: Expected I, but got Obj
		//IL_1197: Expected I, but got Obj
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected VT, but got Unknown
		//IL_090d: Expected I, but got Obj
		//IL_0923: Expected Obj, but got I
		//IL_094e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v420 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 - -64);
		PurchaseResult purchaseResult = (PurchaseResult)(obj2 + 48);
		object obj4 = obj2 + 16;
		if (((ComputeShader)(object)label).FindKernel((string)null) == 0)
		{
			return;
		}
		if (~(mDoInit ? 1u : 0u) == 0)
		{
			OnSelectEvent();
		}
		int num3 = cursorPosition;
		bool flag = selected;
		bool flag2;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		int fontSize;
		if (flag2)
		{
			bool flag3;
			if (Input.mousePresent)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v379 (System.Boolean)+8]");
				flag3 = (nint)0 == 0;
			}
			else
			{
				flag3 = true;
			}
			if (flag3)
			{
				string text;
				if (num3 != 0)
				{
					object obj5 = this + 48;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v299+8]");
					_ = 0;
					obj = ((UIWidget.Pivot*)(int)pivot)->value__;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (UIWidget+Pivot)+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					label.rawPivot = pivot;
					text = "";
				}
				else
				{
					object obj6 = this + 116;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v285+8]");
					_ = 0;
					obj = ((UIWidget.Pivot*)(int)pivot)->value__;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (UIWidget+Pivot)+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					label.rawPivot = pivot;
					text = mDefaultText;
				}
				label.applyGradient = (byte)mAlignment != 0;
				fontSize = (int)text;
				goto IL_13be;
			}
			object obj7 = this + 48;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v313+8]");
			_ = 0;
			obj = ((UIWidget.Pivot*)(int)pivot)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (UIWidget+Pivot)+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			label.rawPivot = pivot;
		}
		else
		{
			object obj8 = this + 48;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S2_v104+8]");
			_ = 0;
			obj = ((UIWidget.Pivot*)(int)pivot)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (UIWidget+Pivot)+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			label.rawPivot = pivot;
		}
		bool flag8;
		if (inputType == InputType.Password)
		{
			UILabel uILabel = label;
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S2_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S2_v99 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num6 = ((ComputeShader)(object)uILabel.mFont).FindKernel((string)null);
			bool flag4 = num6 == 0;
			int totalLength = (int)"*";
			if (!flag4)
			{
				UILabel uILabel2 = label;
				int texWidth = uILabel2.mFont.texWidth;
				bool flag5 = texWidth == 0;
				totalLength = (int)"*";
				if (!flag5)
				{
					UILabel uILabel3 = label;
					int texWidth2 = uILabel3.mFont.texWidth;
					int kerning = ((BMGlyph)texWidth2).GetKerning(42);
					bool flag6 = kerning == 0;
					bool flag7 = !flag6;
					totalLength = (int)"*";
					if (!flag7)
					{
						totalLength = (int)"x";
					}
				}
			}
			object obj10 = 0;
			flag8 = (byte)(int)"" != 0;
			while (true)
			{
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34 (System.Boolean)+8]");
				if ((nint)obj11 < 0)
				{
					string text2 = string.ConcatArray((string[])flag8, totalLength);
					object obj12 = obj10 + 1;
					obj10 = obj12;
					flag8 = (byte)(int)text2 != 0;
					continue;
				}
				break;
			}
		}
		else
		{
			flag8 = flag;
		}
		string values2;
		int num11;
		if (num3 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A1C1");
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v353 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v361 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ L3_v16 (System.Boolean)+8]");
			int num9 = default;
			int length;
			int num10;
			if ((nint)0 < (nint)num9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ L3_v16 (System.Boolean)+8]");
				length = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ L3_v16 (System.Boolean)+8]");
				num10 = 0;
			}
			else
			{
				length = num9;
				num10 = num9;
			}
			string values = ((string)flag8).InternalSubString(0, length);
			bool mousePresent = Input.mousePresent;
			string text3 = string.ConcatArray((string[])(object)values, mousePresent ? 1 : 0);
			values2 = text3;
			num11 = num10;
		}
		else
		{
			string text4 = ((string)flag8).InternalSubString(0, 0);
			values2 = text4;
			num11 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ L3_v16 (System.Boolean)+8]");
		int length2 = (int)(-num11);
		string text5 = ((string)flag8).InternalSubString(num11, length2);
		string text6 = string.ConcatArray((string[])(object)values2, (int)text5);
		if (num3 != 0)
		{
			UILabel uILabel4 = label;
			if (uILabel4.mOverflow == UILabel.Overflow.ClampContent)
			{
				UILabel uILabel5 = label;
				if (uILabel5.mMaxLineCount == 1)
				{
					int num12 = UIPanel.CompareFunc((UIPanel)(object)label, (UIPanel)(object)text6);
					nint num13 = (nint)typeof(UIInput);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v220 (Il2CppClass<UIInput>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					bool flag9 = obj14 == null;
					if (num12 != 0)
					{
						if (!flag9)
						{
							nint num14 = (nint)typeof(UIInput);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v339 (Il2CppClass<UIInput>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag10 = num11 < mDrawStart;
						nint num15 = (nint)typeof(UIInput);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ S1_v221 (Il2CppClass<UIInput>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						bool flag11 = obj15 == null;
						if (flag10)
						{
							if (!flag11)
							{
								nint num16 = (nint)typeof(UIInput);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S0_v334 (Il2CppClass<UIInput>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							mDrawStart = num11;
							label.applyGradient = true;
						}
						else
						{
							if (!flag11)
							{
								nint num17 = (nint)typeof(UIInput);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S0_v321 (Il2CppClass<UIInput>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (num12 < mDrawStart)
							{
								nint num18 = (nint)typeof(UIInput);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ S0_v308 (Il2CppClass<UIInput>)+BA]");
								object obj16 = (nint)0 & (nint)0x200;
								if (obj16 != null)
								{
									nint num19 = (nint)typeof(UIInput);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ S0_v316 (Il2CppClass<UIInput>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								mDrawStart = num12;
								label.applyGradient = true;
							}
							else
							{
								string b = text6.InternalSubString(0, num11);
								int num20 = UIPanel.CompareFunc((UIPanel)(object)label, (UIPanel)(object)b);
								nint num21 = (nint)typeof(UIInput);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ S0_v282 (Il2CppClass<UIInput>)+BA]");
								object obj17 = (nint)0 & (nint)0x200;
								if (obj17 != null)
								{
									nint num22 = (nint)typeof(UIInput);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S0_v302 (Il2CppClass<UIInput>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (num20 > mDrawStart)
								{
									nint num23 = (nint)typeof(UIInput);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ S0_v289 (Il2CppClass<UIInput>)+BA]");
									object obj18 = (nint)0 & (nint)0x200;
									if (obj18 != null)
									{
										nint num24 = (nint)typeof(UIInput);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ S0_v297 (Il2CppClass<UIInput>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									mDrawStart = num20;
									label.applyGradient = true;
								}
							}
						}
					}
					else
					{
						if (!flag9)
						{
							nint num25 = (nint)typeof(UIInput);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v262 (Il2CppClass<UIInput>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						mDrawStart = 0;
						label.applyGradient = (byte)mAlignment != 0;
					}
					nint num26 = (nint)typeof(UIInput);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ S0_v227 (Il2CppClass<UIInput>)+BA]");
					object obj19 = (nint)0 & (nint)0x200;
					if (obj19 != null)
					{
						nint num27 = (nint)typeof(UIInput);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ S0_v249 (Il2CppClass<UIInput>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (mDrawStart == 0)
					{
						fontSize = (int)text6;
					}
					else
					{
						nint num28 = (nint)typeof(UIInput);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ S0_v236 (Il2CppClass<UIInput>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num29 = (nint)typeof(UIInput);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v242 (Il2CppClass<UIInput>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int length3 = text6.m_stringLength - mDrawStart;
						string text7 = text6.InternalSubString(mDrawStart, length3);
						fontSize = (int)text7;
					}
					goto IL_13be;
				}
			}
		}
		nint num30 = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v193 (Il2CppClass<UIInput>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num31 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v202 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mDrawStart = 0;
		label.applyGradient = (byte)mAlignment != 0;
		fontSize = (int)text6;
		goto IL_13be;
		IL_13be:
		label.fontSize = fontSize;
		if (num3 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			return;
		}
		nint num32 = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S1_v18 (Il2CppClass<UIInput>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num33 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S1_v186 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text8 = (string)(mSelectionStart - mDrawStart);
		string text9 = (string)(mSelectionEnd - mDrawStart);
		nint num34 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num35 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S1_v182 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mBlankTex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Texture2D texture2D = default;
			texture2D.SetPixelImpl(2, 2, 5, (Color)0);
			object obj24 = this + 164;
			obj24 = texture2D;
			int num36 = 0;
			while (num36 <= 1)
			{
				Rect rect = (Rect)0;
				while (rect <= (object)1)
				{
					Color black = Color.black;
					((UIWidget.Pivot*)(int)pivot)->value__ = ((PurchaseResult*)(int)purchaseResult)->value__;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (InAppPurchase.PurchaseResult)+8]");
					_ = 0;
					mBlankTex.ReadPixels(rect, num36, (int)pivot);
					Rect rect2 = (Rect)(rect + 1);
					rect = rect2;
				}
				int num37 = num36 + 1;
				num36 = num37;
			}
			((RenderTexture)(object)mBlankTex)._002Ector();
		}
		bool flag12 = (object)text8 == text9;
		if (!flag12)
		{
			nint num38 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S1_v135 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num39 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S1_v164 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(mHighlight != null))
			{
				UILabel uILabel6 = label;
				mHighlight.depth = (int)((UIWidget)uILabel6).mPivot;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				mHighlight.tag = (string)1;
			}
			else
			{
				Transform cachedTransform = label.cachedTransform;
				nint num40 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S0_v134 (Il2CppClass<NGUITools>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num41 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S0_v149 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj27 = this + 156;
				NullReferenceException ex = new NullReferenceException();
				obj27 = ex;
				UnityEngine.Object.DestroyImmediate(mHighlight, (byte)(int)"Input Highlight" != 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				UITexture uITexture = mHighlight;
				uITexture.fillGeometry = false;
				UILabel uILabel7 = label;
				mHighlight.depth = (int)((UIWidget)uILabel7).mPivot;
				Camera anchorCamera = label.anchorCamera;
				mHighlight.SetAnchor((GameObject)(object)anchorCamera);
			}
		}
		nint num42 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num43 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S1_v130 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mCaret != null)
		{
			Transform cachedTransform2 = label.cachedTransform;
			nint num44 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ S0_v107 (Il2CppClass<NGUITools>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num45 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ S0_v122 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj30 = this + 160;
			NullReferenceException ex2 = new NullReferenceException();
			obj30 = ex2;
			UnityEngine.Object.DestroyImmediate(mCaret, (byte)(int)"Input Caret" != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			UITexture uITexture2 = mCaret;
			uITexture2.fillGeometry = false;
			UILabel uILabel8 = label;
			mCaret.depth = (int)((UIWidget)uILabel8).mPivot;
			Camera anchorCamera2 = label.anchorCamera;
			mCaret.SetAnchor((GameObject)(object)anchorCamera2);
		}
		else
		{
			UILabel uILabel9 = label;
			mCaret.depth = (int)((UIWidget)uILabel9).mPivot;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			mCaret.tag = (string)1;
		}
		UITexture uITexture3 = mCaret;
		if (flag12)
		{
			object obj31 = this - -64;
			obj4 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ S1_v76+8]");
			_ = 0;
			object obj32 = this + 80;
			obj2 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ S1_v81+8]");
			_ = 0;
			((PurchaseResult*)(int)purchaseResult)->value__ = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			label(text8, text8, (string)(object)uITexture3.geometry, null, purchaseResult, (IPurchaseValidationResult)pivot);
			nint num46 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ S1_v95 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num47 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ S1_v102 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mHighlight).FindKernel((string)null) != 0)
			{
				mHighlight.tag = null;
			}
		}
		else
		{
			UITexture uITexture4 = mHighlight;
			object obj34 = this - -64;
			obj4 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ S1_v53+8]");
			_ = 0;
			object obj35 = this + 80;
			obj2 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ S1_v58+8]");
			_ = 0;
			((PurchaseResult*)(int)purchaseResult)->value__ = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			label(text8, text9, (string)(object)uITexture3.geometry, (string)(object)uITexture4.geometry, purchaseResult, (IPurchaseValidationResult)pivot);
			UITexture uITexture5 = mHighlight;
			bool hasTransformed = uITexture5.geometry.hasTransformed;
			mHighlight.tag = (string)hasTransformed;
		}
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		float num48 = unscaledDeltaTime + 0.5f;
		mNextBlink = num48;
		UILabel uILabel10 = label;
		mLastAlpha = uILabel10.finalAlpha;
	}

	public void RemoveFocus()
	{
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_02c7: Expected I, but got Obj
		//IL_02dd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0286: Expected I, but got Obj
		//IL_029c: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		nint num = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIInput>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(current != null))
		{
			return;
		}
		nint num5 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v11 (Il2CppClass<EventDelegate>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v29 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!Localization.LoadAndSelect((string)(object)onChange))
		{
			return;
		}
		nint num7 = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v19 (Il2CppClass<UIInput>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v30 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		current = this;
		nint num9 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v19 (Il2CppClass<EventDelegate>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v25 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Localization.dictionary = (Dictionary<string, string[]>)(object)onChange;
		current = null;
	}

	public void SaveValue()
	{
		cursorPosition = 0;
	}

	public void LoadValue()
	{
		//IL_000c: Expected I4, but got Obj
		OnSelect((byte)(int)mValue != 0);
	}

	public unsafe UIInput()
	{
		//IL_0041: Expected I4, but got Obj
		//IL_0041: Expected I4, but got Obj
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0084: Expected I4, but got Obj
		string text = savedAs;
		if (savedAs != null && text.m_stringLength != 0)
		{
			string text2 = mValue.Remove((int)"\\n", (int)"\n");
			object obj = this + 108;
			obj = "";
			int hashCode = ((LODParameters*)savedAs)->GetHashCode();
			bool flag = hashCode == 0;
			bool flag2 = (byte)(int)text2 != 0;
			if (!flag)
			{
				bool flag3 = PlayerPrefs.HasKey(savedAs);
				flag2 = flag3;
			}
			selected = flag2;
		}
	}

	static UIInput()
	{
		//IL_0698: Expected I, but got Obj
		//IL_06ae: Expected Obj, but got I
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Obj, but got Unknown
		//IL_0708: Expected I, but got Obj
		//IL_071e: Expected Obj, but got I
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected Obj, but got Unknown
		//IL_0763: Expected I, but got Obj
		//IL_0779: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01fb: Expected I, but got Obj
		//IL_0211: Expected Obj, but got I
		//IL_024f: Expected I, but got Obj
		//IL_0265: Expected Obj, but got I
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected Obj, but got Unknown
		//IL_07ce: Expected VT, but got Obj
		//IL_07dc: Expected I, but got Obj
		//IL_07f2: Expected Obj, but got I
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected Obj, but got Unknown
		//IL_0834: Expected I, but got Obj
		//IL_085f: Expected Obj, but got I
		//IL_0882: Expected I, but got Obj
		//IL_0898: Expected Obj, but got I
		//IL_08b0: Expected I, but got Obj
		//IL_08c6: Expected Obj, but got I
		//IL_08cf: Expected Obj, but got I4
		//IL_08dd: Expected I, but got Obj
		//IL_08f3: Expected Obj, but got I
		//IL_08fc: Expected Obj, but got I4
		//IL_0928: Expected I, but got Obj
		//IL_093e: Expected Obj, but got I
		//IL_0947: Expected Obj, but got I4
		//IL_0290: Expected I, but got Obj
		//IL_02dd: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BetterList<UICamera> list = default;
		UICamera.list = list;
		nint num = (nint)typeof(UICamera._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v17 (Il2CppClass<UICamera+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v307 (Il2CppClass<UICamera+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = UICamera._003C_003Ec._003C_003E9;
		nint num4 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v31 (Il2CppClass<UICamera>)+5C]");
		object obj4 = (nint)0 + (nint)4;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = UICamera._003C_003Ec._003C_003E9;
		nint num6 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45 (Il2CppClass<UICamera>)+5C]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		object obj9 = default;
		object obj8 = obj9 + 16;
		obj8 = UICamera._003C_003Ec._003C_003E9;
		nint num8 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v59 (Il2CppClass<UICamera>)+5C]");
		object obj10 = (nint)0 + (nint)12;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		object obj12 = default;
		object obj11 = obj12 + 16;
		obj11 = UICamera._003C_003Ec._003C_003E9;
		nint num10 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v73 (Il2CppClass<UICamera>)+5C]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		object obj15 = default;
		object obj14 = obj15 + 16;
		obj14 = UICamera._003C_003Ec._003C_003E9;
		nint num12 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v87 (Il2CppClass<UICamera>)+5C]");
		object obj16 = (nint)0 + (nint)24;
		obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		object obj18 = default;
		object obj17 = obj18 + 16;
		obj17 = UICamera._003C_003Ec._003C_003E9;
		nint num14 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v101 (Il2CppClass<UICamera>)+5C]");
		object obj19 = (nint)0 + (nint)28;
		obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num15 = 0;
		_ = 0;
		object obj21 = default;
		object obj20 = obj21 + 16;
		obj20 = UICamera._003C_003Ec._003C_003E9;
		nint num16 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v115 (Il2CppClass<UICamera>)+5C]");
		object obj22 = (nint)0 + (nint)32;
		obj22 = obj21;
		UICamera.showTooltips = true;
		UICamera.ignoreAllEvents = false;
		UICamera.ignoreControllerInput = false;
		UICamera.mDisableController = false;
		nint num17 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v131 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num18 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v303 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		object obj25 = default;
		object obj24 = obj25 + 8;
		obj24 = obj25;
		object obj26 = obj25 + 56;
		obj26 = obj24;
		UICamera.mLastPos = (Vector2)obj26;
		nint num19 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v140 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num20 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v299 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj28 = obj25 + 44;
		Vector3 one2 = Vector3.one;
		nint num21 = (nint)typeof(UICamera);
		obj26 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v145+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v147 (Il2CppClass<UICamera>)+5C]");
		object obj29 = (nint)0 + (nint)56;
		obj29 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v70+8]");
		_ = 0;
		nint num22 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v152 (Il2CppClass<UICamera>)+5C]");
		object obj30 = (nint)0 + (nint)68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num23 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v156 (Il2CppClass<UICamera>)+5C]");
		object obj31 = (nint)0 + (nint)136;
		obj31 = 0;
		nint num24 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v160 (Il2CppClass<UICamera>)+5C]");
		object obj32 = (nint)0 + (nint)140;
		obj32 = 0;
		UICamera.mLastScheme = UICamera.ControlScheme.Mouse;
		UICamera.currentTouchID = -100;
		UICamera.mCurrentKey = KeyCode.Alpha0;
		nint num25 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v173 (Il2CppClass<UICamera>)+5C]");
		object obj33 = (nint)0 + (nint)160;
		obj33 = 0;
		UICamera.mInputFocus = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		_ = 1;
		throw new ArrayTypeMismatchException();
	}
}
