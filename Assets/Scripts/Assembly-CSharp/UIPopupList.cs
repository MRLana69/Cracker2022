using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class UIPopupList : UIWidgetContainer
{
	public enum Position
	{
		Auto,
		Above,
		Below
	}

	public enum OpenOn
	{
		ClickOrTap,
		RightClick,
		DoubleClick,
		Manual
	}

	public delegate void LegacyEvent(string val);

	private sealed class _003CUpdateTweenPosition_003Ed__82(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		private TweenPosition _003Ctp_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected Obj, but got Unknown
			//IL_00f9: Expected Obj, but got I4
			//IL_012f: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 - 16;
			UIPopupList uIPopupList = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool result = default;
					return result;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (!(uIPopupList.mHighlight != null) || !(uIPopupList.mHighlightedLabel != null))
				{
					goto IL_017d;
				}
				TweenPosition component = uIPopupList.mHighlight.GetComponent<TweenPosition>();
				_003Ctp_003E5__2 = component;
			}
			object obj3 = this + 20;
			if (!(_003Ctp_003E5__2 != null) || !((Behaviour)obj3).enabled)
			{
				obj3 = 0;
				goto IL_017d;
			}
			TweenPosition tweenPosition = _003Ctp_003E5__2;
			Vector3 highlightPosition = uIPopupList.GetHighlightPosition();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			tweenPosition.to = (Vector3)obj;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_017d:
			uIPopupList.mTweening = false;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CCloseIfUnselected_003Ed__98(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					UIPopupList uIPopupList = _003C_003E4__this;
					_003C_003E1__state = -1;
					GameObject selectedObject = UICamera.selectedObject;
					if (!(selectedObject != uIPopupList.mSelection))
					{
						goto IL_00b7;
					}
					if (!uIPopupList.isDraggable)
					{
						uIPopupList.CloseSelf();
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			goto IL_00b7;
			IL_00b7:
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public static UIPopupList current;

	private static GameObject mChild;

	private static float mFadeOutComplete;

	private const float animSpeed = 0.15f;

	public UIAtlas atlas;

	public UIFont bitmapFont;

	public Font trueTypeFont;

	public int fontSize = 16;

	public FontStyle fontStyle;

	public string backgroundSprite;

	public string highlightSprite;

	public Position position;

	public NGUIText.Alignment alignment = NGUIText.Alignment.Left;

	public List<string> items;

	public List<object> itemData;

	public Vector2 padding;

	public Color textColor;

	public Color backgroundColor;

	public Color highlightColor;

	public bool isAnimated;

	public bool isLocalized;

	public OpenOn openOn;

	public bool isDraggable;

	public List<EventDelegate> onChange;

	private string mSelectedItem;

	private UIPanel mPanel;

	private UISprite mBackground;

	private UISprite mHighlight;

	private UILabel mHighlightedLabel;

	private List<UILabel> mLabelList;

	private float mBgBorder;

	[NonSerialized]
	private GameObject mSelection;

	[NonSerialized]
	private int mOpenFrame;

	private GameObject eventReceiver;

	private string functionName;

	private float textScale;

	private UIFont font;

	private UILabel textLabel;

	private LegacyEvent mLegacyEvent;

	[NonSerialized]
	private bool mExecuting;

	private bool mUseDynamicFont;

	private bool mTweening;

	public GameObject source;

	public UnityEngine.Object ambigiousFont
	{
		get
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected Obj, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			object result = this + 20;
			if (trueTypeFont == null)
			{
				result = this + 16;
				if (bitmapFont == null)
				{
					result = this + 176;
				}
			}
			return (UnityEngine.Object)result;
		}
		set
		{
			bool flag = (object)value == null;
			UnityEngine.Object obj = null;
			if (!flag)
			{
				bool flag2 = (object)value.GetType() == typeof(Font);
				obj = value;
				if (!flag2)
				{
					obj = null;
				}
			}
			if ((object)obj != null)
			{
				bool flag3 = (object)value == null;
				UnityEngine.Object obj2 = null;
				if (!flag3)
				{
					bool flag4 = (object)value.GetType() == typeof(Font);
					obj2 = value;
					if (!flag4)
					{
						obj2 = null;
					}
				}
				trueTypeFont = (Font)obj2;
				if ((object)value == null)
				{
					bitmapFont = null;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				object obj3 = default;
				if (obj3 == null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				UIFont uIFont = default;
				bitmapFont = uIFont;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				trueTypeFont = null;
			}
			font = null;
		}
	}

	public LegacyEvent onSelectionChange
	{
		get
		{
			return mLegacyEvent;
		}
		set
		{
			mLegacyEvent = value;
		}
	}

	public static bool isOpen
	{
		get
		{
			bool flag = current != null;
			bool flag2 = !flag;
			bool result = false;
			if (!flag2)
			{
				bool flag3 = mChild == null;
				result = true;
				if (flag3)
				{
					float unscaledTime = Time.unscaledTime;
					bool flag4 = mFadeOutComplete > unscaledTime;
					result = flag4;
				}
			}
			return result;
		}
	}

	public string value
	{
		get
		{
			return mSelectedItem;
		}
		set
		{
			mSelectedItem = value;
			if (mSelectedItem != null)
			{
				TriggerCallbacks();
			}
		}
	}

	public object data
	{
		get
		{
			//IL_007e: Expected Obj, but got I
			List<string> list = items;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.List`1<System.String>>)+8C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S5_v4+4] (should have been resolved before IL gen)");
			int num3 = default;
			bool flag = num3 < 0;
			object result = null;
			if (!flag)
			{
				List<object> list2 = itemData;
				bool flag2 = num3 >= list2._size;
				result = null;
				if (!flag2)
				{
					object obj2 = itemData.get_Item(num3);
					result = obj2;
				}
			}
			return result;
		}
	}

	public bool isColliderEnabled
	{
		get
		{
			Collider component = GetComponent<Collider>();
			if (component != null)
			{
				return component.enabled;
			}
			Collider2D component2 = GetComponent<Collider2D>();
			if (component2 != null)
			{
				return component2.enabled;
			}
			return false;
		}
	}

	public string selection
	{
		get
		{
			return mSelectedItem;
		}
		set
		{
			this.value = value;
		}
	}

	private bool isValid
	{
		get
		{
			if (bitmapFont != null)
			{
				return true;
			}
			return trueTypeFont != null;
		}
	}

	private int activeFontSize
	{
		get
		{
			if (trueTypeFont != null || bitmapFont == null)
			{
				return fontSize;
			}
			return bitmapFont.defaultSize;
		}
	}

	private float activeFontScale
	{
		get
		{
			//IL_0057: Expected F4, but got I4
			bool flag = trueTypeFont == null;
			float result = 1f;
			if (flag)
			{
				bool flag2 = bitmapFont != null;
				result = 1f;
				if (flag2)
				{
					int defaultSize = bitmapFont.defaultSize;
					int num = fontSize / defaultSize;
					result = num;
				}
			}
			return result;
		}
	}

	public void Clear()
	{
		((List<T>)(object)items).Clear();
		((List<T>)(object)itemData).Clear();
	}

	public void AddItem(string text)
	{
		items.Add(text);
		itemData.Add(null);
	}

	public void AddItem(string text, object data)
	{
		items.Add(text);
		itemData.Add(data);
	}

	public void RemoveItem(string text)
	{
		//IL_004f: Expected Obj, but got I
		List<string> list = items;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.List`1<System.String>>)+8C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S5_v4+4] (should have been resolved before IL gen)");
		int num3 = default;
		if (num3 != -1)
		{
			items.RemoveAt(num3);
			itemData.RemoveAt(num3);
		}
	}

	public void RemoveItemByData(object data)
	{
		//IL_004f: Expected Obj, but got I
		List<object> list = itemData;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.List`1<System.Object>>)+8C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S5_v4+4] (should have been resolved before IL gen)");
		int num3 = default;
		if (num3 != -1)
		{
			items.RemoveAt(num3);
			itemData.RemoveAt(num3);
		}
	}

	protected void TriggerCallbacks()
	{
		//IL_00df: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		if (~(mExecuting ? 1u : 0u) == 0)
		{
			return;
		}
		mExecuting = true;
		current = this;
		LegacyEvent legacyEvent = mLegacyEvent;
		if (mLegacyEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		object obj;
		if (EventDelegate.IsValid(onChange))
		{
			EventDelegate.Execute(onChange);
		}
		else if (eventReceiver != null)
		{
			string text = functionName;
			if (functionName != null)
			{
				obj = 0;
				if (text._stringLength != 0)
				{
					goto IL_016b;
				}
			}
			obj = 1;
			goto IL_016b;
		}
		goto IL_0105;
		IL_0105:
		current = current;
		mExecuting = false;
		return;
		IL_016b:
		if (obj == null)
		{
			eventReceiver.SendMessage(functionName, mSelectedItem, SendMessageOptions.DontRequireReceiver);
		}
		goto IL_0105;
	}

	private void OnEnable()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00f4: Expected F8, but got I4
		//IL_02a4: Expected I4, but got F8
		//IL_028a: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01ee: Expected Obj, but got I4
		//IL_0161: Expected F8, but got I4
		if (EventDelegate.IsValid(onChange))
		{
			eventReceiver = null;
			functionName = null;
		}
		if (!(font != null))
		{
			goto IL_0244;
		}
		object obj = this + 176;
		if (((UIFont)obj).isDynamic)
		{
			Font dynamicFont = font.dynamicFont;
			trueTypeFont = dynamicFont;
			FontStyle dynamicFontStyle = font.dynamicFontStyle;
			fontStyle = dynamicFontStyle;
		}
		else
		{
			if (!(bitmapFont == null))
			{
				goto IL_0281;
			}
			object obj2 = this + 16;
			obj2 = obj;
		}
		mUseDynamicFont = true;
		goto IL_0281;
		IL_0281:
		obj = 0;
		goto IL_0244;
		IL_0244:
		if (textScale != 0f)
		{
			bool flag = bitmapFont != null;
			bool flag2 = !flag;
			double num = 16.0;
			if (!flag2)
			{
				int defaultSize = bitmapFont.defaultSize;
				float num2 = (float)defaultSize * textScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num4 = default;
				double num3 = Math.Abs(num4);
				if (!(num3 < 2147483648.0))
				{
					num4 = -2147483648.0;
				}
				num = num4;
			}
			textScale = 0f;
			fontSize = (int)num;
		}
		if (trueTypeFont == null && bitmapFont != null)
		{
			object obj3 = this + 16;
			if (((UIFont)obj3).isDynamic)
			{
				object obj4 = this + 20;
				Font dynamicFont2 = ((UIFont)obj3).dynamicFont;
				obj4 = dynamicFont2;
				obj3 = 0;
			}
		}
	}

	private void OnValidate()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0057: Expected Obj, but got I4
		bitmapFont = null;
		object obj = this + 16;
		trueTypeFont = null;
		object obj2 = this + 20;
		bool flag;
		if (trueTypeFont != null && (bitmapFont == null || !mUseDynamicFont))
		{
			obj = 0;
		}
		else if (bitmapFont != null)
		{
			if (bitmapFont.isDynamic)
			{
				Font dynamicFont = bitmapFont.dynamicFont;
				trueTypeFont = dynamicFont;
				FontStyle dynamicFontStyle = bitmapFont.dynamicFontStyle;
				fontStyle = dynamicFontStyle;
				int defaultSize = bitmapFont.defaultSize;
				fontSize = defaultSize;
				goto IL_017b;
			}
			obj = bitmapFont;
			flag = false;
			goto IL_0189;
		}
		obj2 = trueTypeFont;
		goto IL_017b;
		IL_0189:
		mUseDynamicFont = flag;
		return;
		IL_017b:
		flag = true;
		goto IL_0189;
	}

	private unsafe void Start()
	{
		//IL_0091: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		if (textLabel != null)
		{
			EventDelegate.Callback callback = default;
			callback._002Ector(textLabel, (nint)__ldftn(UILabel.SetCurrentSelection));
			EventDelegate eventDelegate = EventDelegate.Add(onChange, callback);
			textLabel = null;
		}
		if (!Application.isPlaying)
		{
			return;
		}
		string text = mSelectedItem;
		object obj;
		if (mSelectedItem != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0166;
			}
		}
		obj = 1;
		goto IL_0166;
		IL_01ac:
		object obj2;
		if (obj2 == null)
		{
			TriggerCallbacks();
		}
		return;
		IL_0166:
		if (obj != null)
		{
			List<string> list = items;
			if (list._size >= 1)
			{
				string text2 = items.get_Item(0);
				mSelectedItem = text2;
			}
		}
		string text3 = mSelectedItem;
		if (mSelectedItem != null)
		{
			obj2 = 0;
			if (text3._stringLength != 0)
			{
				goto IL_01ac;
			}
		}
		obj2 = 1;
		goto IL_01ac;
	}

	private void OnLocalize()
	{
		if (~(isLocalized ? 1u : 0u) == 0)
		{
			TriggerCallbacks();
		}
	}

	private unsafe void Highlight(UILabel lbl, bool instant)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_012d: Expected F4, but got I
		//IL_0128: Expected native int or pointer, but got VT
		//IL_0142: Expected F4, but got I
		//IL_013d: Expected native int or pointer, but got VT
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_ = 0;
		_ = 0;
		if (!(mHighlight != null))
		{
			return;
		}
		mHighlightedLabel = lbl;
		UISpriteData atlasSprite = mHighlight.GetAtlasSprite();
		if (atlasSprite == null)
		{
			return;
		}
		Vector3 highlightPosition = GetHighlightPosition();
		if (!instant && ~(isAnimated ? 1u : 0u) == 0)
		{
			GameObject go = mHighlight.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Vector3 pos = vector + 16;
			TweenPosition tweenPosition = TweenPosition.Begin(go, 0.1f, pos);
			tweenPosition.method = UITweener.Method.EaseOut;
			if (!mTweening)
			{
				mTweening = true;
				Coroutine coroutine = StartCoroutine("UpdateTweenPosition");
			}
		}
		else
		{
			Transform cachedTransform = mHighlight.cachedTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			cachedTransform.localPosition = vector;
		}
	}

	private unsafe Vector3 GetHighlightPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0196: Expected I, but got Obj
		//IL_01b4: Expected F4, but got VT
		//IL_01af: Expected native int or pointer, but got VT
		//IL_01c9: Expected F4, but got I
		//IL_01c4: Expected native int or pointer, but got VT
		//IL_0130: Expected native int or pointer, but got VT
		//IL_013d: Expected native int or pointer, but got VT
		//IL_014a: Expected native int or pointer, but got VT
		//IL_01dc: Expected I, but got Obj
		//IL_01fa: Expected F4, but got VT
		//IL_01f5: Expected native int or pointer, but got VT
		//IL_020f: Expected F4, but got I
		//IL_020a: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 vector = default;
		if (!(mHighlightedLabel == null) && !(mHighlight == null))
		{
			UISpriteData atlasSprite = mHighlight.GetAtlasSprite();
			if (atlasSprite != null)
			{
				float pixelSize = atlas.pixelSize;
				float num = (float)atlasSprite.borderLeft * pixelSize;
				float num2 = (float)atlasSprite.borderTop * pixelSize;
				Transform cachedTransform = mHighlightedLabel.cachedTransform;
				Vector3 localPosition = cachedTransform.localPosition;
				float num3 = 0f - num;
				float x = (float)obj + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				float y = 0f + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				float z = 0f + 1f;
				((Vector3*)(nint)vector)->z = z;
				((Vector3*)(nint)vector)->y = y;
				((Vector3*)(nint)vector)->x = x;
			}
			else
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v33 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num5 = 0;
				((Vector3*)(nint)vector)->x = (float)Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v34 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				((Vector3*)(nint)vector)->z = 0f;
			}
		}
		else
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num7 = 0;
			((Vector3*)(nint)vector)->x = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v10 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			((Vector3*)(nint)vector)->z = 0f;
		}
		return vector;
	}

	private IEnumerator UpdateTweenPosition()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void OnItemHover(GameObject go, bool isOver)
	{
		if (isOver)
		{
			UILabel component = go.GetComponent<UILabel>();
			Highlight(component, instant: false);
		}
	}

	private void OnItemPress(GameObject go, bool isPressed)
	{
		//IL_0189: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0122: Expected F4, but got I
		//IL_0122: Expected Obj, but got I
		if (!isPressed)
		{
			return;
		}
		UILabel component = go.GetComponent<UILabel>();
		Select(component, instant: true);
		UIEventListener component2 = go.GetComponent<UIEventListener>();
		object parameter = component2.parameter;
		bool flag = component2.parameter == null;
		string text = null;
		if (!flag)
		{
			bool flag2 = (object)parameter.GetType() == typeof(string);
			text = (string)component2.parameter;
			if (!flag2)
			{
				text = null;
			}
		}
		value = text;
		UIPlaySound[] components = GetComponents<UIPlaySound>();
		object obj = 0;
		while ((nint)obj < components.Length)
		{
			object obj2 = obj << 2;
			object obj3 = (object)components + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v18+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v19+10]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v19+C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v19+14]");
				AudioSource audioSource = NGUITools.PlaySound((AudioClip)num, 0f, 1f);
			}
			object obj5 = obj + 1;
			obj = obj5;
		}
		CloseSelf();
	}

	private void Select(UILabel lbl, bool instant)
	{
		Highlight(lbl, instant);
	}

	private void OnNavigate(KeyCode key)
	{
		//IL_0058: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected I4, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected I4, but got Unknown
		if (!enabled || !(current == this))
		{
			return;
		}
		List<UILabel> list = mLabelList;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S6_v4 (Il2CppRgctx<System.Collections.Generic.List`1<UILabel>>)+8C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S6_v5+4] (should have been resolved before IL gen)");
		object obj2 = default;
		bool flag = (nint)obj2 == -1;
		object obj3 = 0;
		if (!flag)
		{
			obj3 = obj2;
		}
		object obj4 = key - 273;
		UILabel lbl;
		if (key != KeyCode.UpArrow)
		{
			if ((nint)obj4 != 1)
			{
				return;
			}
			List<UILabel> list2 = mLabelList;
			object obj5 = obj3 + 1;
			if (list2._size <= (nint)obj5)
			{
				return;
			}
			int index = obj3 + 1;
			lbl = mLabelList.get_Item(index);
		}
		else
		{
			if ((nint)obj3 < 1)
			{
				return;
			}
			int index2 = obj3 - 1;
			lbl = mLabelList.get_Item(index2);
		}
		Select(lbl, instant: false);
	}

	private void OnKey(KeyCode key)
	{
		if (!enabled || !(current == this))
		{
			return;
		}
		UICamera uICamera = UICamera.current;
		if (key != uICamera.cancelKey0)
		{
			UICamera uICamera2 = UICamera.current;
			if (uICamera2.cancelKey1 != key)
			{
				return;
			}
		}
		OnSelect(isSelected: false);
	}

	private void OnDisable()
	{
		CloseSelf();
	}

	private void OnSelect(bool isSelected)
	{
		if (!isDraggable && !isSelected)
		{
			CloseSelf();
		}
	}

	public static void Close()
	{
		if (current != null)
		{
			current.CloseSelf();
			current = null;
		}
	}

	public unsafe void CloseSelf()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I
		//IL_0121: Expected F4, but got I
		//IL_011c: Expected native int or pointer, but got VT
		//IL_0143: Expected F4, but got I
		//IL_013e: Expected native int or pointer, but got VT
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 48);
		if (!(mChild != null) || !(current == this))
		{
			return;
		}
		StopCoroutine("CloseIfUnselected");
		mSelection = null;
		((List<T>)(object)mLabelList).Clear();
		float num5;
		if (~(isAnimated ? 1u : 0u) == 0)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S3_v5 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			object obj2 = 0;
			object obj6 = default;
			while (true)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v66+C]");
				if ((nint)obj3 >= 0)
				{
					break;
				}
				object obj4 = obj2 << 2;
				object obj5 = obj6 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v32+10]");
				Component component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v33 (UnityEngine.Component)+54]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v33 (UnityEngine.Component)+4C]");
				_ = 0;
				GameObject go = component.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
				((Color*)(nint)color)->b = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
				((Color*)(nint)color)->r = 0f;
				TweenColor tweenColor = TweenColor.Begin(go, 0.15f, color);
				tweenColor.method = UITweener.Method.EaseOut;
				object obj7 = obj2 + 1;
				obj2 = obj7;
			}
			nint num3 = 0;
			nint num4 = 0;
			IntPtr intPtr2 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ S3_v10 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			object obj8 = 0;
			object obj12 = default;
			while (true)
			{
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v76+C]");
				if ((nint)obj9 >= 0)
				{
					break;
				}
				object obj10 = obj8 << 2;
				object obj11 = obj12 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v91+10]");
				((Collider)0).enabled = false;
				object obj13 = obj8 + 1;
				obj8 = obj13;
			}
			UnityEngine.Object.Destroy(mChild, 0.15f);
			num5 = 0.15f;
		}
		else
		{
			UnityEngine.Object.Destroy(mChild);
			num5 = 0.1f;
		}
		float unscaledTime = Time.unscaledTime;
		float num6 = unscaledTime + num5;
		mFadeOutComplete = num6;
		mBackground = null;
		mHighlight = null;
		mChild = null;
		current = null;
	}

	private unsafe void AnimateColor(UIWidget widget)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		//IL_00ae: Expected F4, but got I
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_00da: Expected F4, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj + -64);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [widget @ L1 (UIWidget)+54]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [widget @ L1 (UIWidget)+50]");
		_ = 0;
		_ = widget.mColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
		_ = 0;
		Color color2 = color + 16;
		widget.color = color2;
		GameObject go = widget.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [widget @ L1 (UIWidget)+54]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [widget @ L1 (UIWidget)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
		((Color*)(nint)color)->b = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [widget @ L1 (UIWidget)+50]");
		_ = 0;
		_ = widget.mColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
		((Color*)(nint)color)->r = 0f;
		TweenColor tweenColor = TweenColor.Begin(go, 0.15f, color);
		tweenColor.method = UITweener.Method.EaseOut;
	}

	private unsafe void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected VT, but got Unknown
		//IL_00f0: Expected F4, but got I
		//IL_00eb: Expected native int or pointer, but got VT
		//IL_011f: Expected F4, but got I
		//IL_011a: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Transform cachedTransform = widget.cachedTransform;
		Vector3 localPosition = cachedTransform.localPosition;
		Transform cachedTransform2 = widget.cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		float num = bottom;
		if (!placeAbove)
		{
			num = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 localPosition2 = vector + 16;
		cachedTransform2.localPosition = localPosition2;
		GameObject go = widget.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		TweenPosition tweenPosition = TweenPosition.Begin(go, 0.15f, vector);
		tweenPosition.method = UITweener.Method.EaseOut;
	}

	private unsafe void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected VT, but got Unknown
		//IL_01ed: Expected I, but got Obj
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected VT, but got Unknown
		//IL_00fd: Expected Obj, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected VT, but got Unknown
		//IL_0187: Expected F4, but got I
		//IL_0182: Expected native int or pointer, but got VT
		//IL_01b6: Expected F4, but got I
		//IL_01b1: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		GameObject go = widget.gameObject;
		Transform cachedTransform = widget.cachedTransform;
		int num = activeFontSize;
		float num2 = activeFontScale;
		float num3 = (float)num * num2;
		float num4 = mBgBorder + mBgBorder;
		float num5 = num3 + num4;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		_ = 1065353216;
		float num6 = num5 / (float)widget.mHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 localScale = vector + 48;
		cachedTransform.localScale = localScale;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v22 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v23 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		_ = Vector3.oneVector;
		Vector3 scale = vector + 32;
		TweenScale tweenScale = TweenScale.Begin(go, 0.15f, scale);
		tweenScale.method = UITweener.Method.EaseOut;
		if (placeAbove)
		{
			Vector3 localPosition = cachedTransform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			object obj2 = -widget.mHeight;
			float num9 = (float)obj2 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Vector3 localPosition2 = vector + 16;
			cachedTransform.localPosition = localPosition2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			((Vector3*)(nint)vector)->x = 0f;
			TweenPosition tweenPosition = TweenPosition.Begin(go, 0.15f, vector);
			tweenPosition.method = UITweener.Method.EaseOut;
		}
	}

	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
		((UIPopupList)(object)widget).AnimateColor(widget);
		((UIPopupList)(object)widget).AnimatePosition(widget, placeAbove, bottom);
	}

	private void OnClick()
	{
		//IL_0042: Expected Obj, but got I4
		int frameCount = Time.frameCount;
		if (mOpenFrame == frameCount)
		{
			return;
		}
		if (mChild == null)
		{
			object obj = openOn - 1;
			if (openOn != OpenOn.RightClick)
			{
				if ((nint)obj == 1 || (nint)obj == 2)
				{
					return;
				}
			}
			else if (UICamera.currentTouchID != -2)
			{
				return;
			}
			Show();
		}
		else if (mHighlightedLabel != null)
		{
			GameObject go = mHighlightedLabel.gameObject;
			OnItemPress(go, isPressed: true);
		}
	}

	private void OnDoubleClick()
	{
		if (openOn == OpenOn.DoubleClick)
		{
			Show();
		}
	}

	private IEnumerator CloseIfUnselected()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public unsafe void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected VT, but got Unknown
		//IL_0561: Expected Ref, but got VT
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected VT, but got Unknown
		//IL_0581: Expected Ref, but got VT
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected VT, but got Unknown
		//IL_0603: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I
		//IL_0633: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I
		//IL_0663: Expected Obj, but got I
		//IL_0673: Expected Obj, but got I
		//IL_0683: Expected Obj, but got I
		//IL_17da: Expected I, but got Obj
		//IL_1820: Unknown result type (might be due to invalid IL or missing references)
		//IL_1825: Expected VT, but got Unknown
		//IL_1845: Expected I, but got Obj
		//IL_1871: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Expected VT, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected VT, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected VT, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected VT, but got Unknown
		//IL_0465: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		//IL_0495: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I
		//IL_04b5: Expected Obj, but got I
		//IL_04c5: Expected Obj, but got I
		//IL_04d5: Expected Obj, but got I
		//IL_04e5: Expected Obj, but got I
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected VT, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_0728: Expected I, but got Obj
		//IL_0744: Expected F4, but got I
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected VT, but got Unknown
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Expected VT, but got Unknown
		//IL_18a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ad: Expected Obj, but got Unknown
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected Obj, but got Unknown
		//IL_1a50: Expected Obj, but got F4
		//IL_1a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5d: Expected VT, but got Unknown
		//IL_1a82: Expected Obj, but got F4
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected I4, but got Unknown
		//IL_0e7a: Expected F8, but got I4
		//IL_1af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afc: Expected Obj, but got Unknown
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de4: Expected VT, but got Unknown
		//IL_18fc: Expected Obj, but got I
		//IL_1909: Expected I4, but got Obj
		//IL_1912: Unknown result type (might be due to invalid IL or missing references)
		//IL_1917: Expected VT, but got Unknown
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected VT, but got Unknown
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected Obj, but got Unknown
		//IL_0d25: Expected Obj, but got I
		//IL_0d44: Expected VT, but got I
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected VT, but got Unknown
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected Obj, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected Obj, but got Unknown
		//IL_0a03: Expected Obj, but got I4
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected VT, but got Unknown
		//IL_0d78: Expected Obj, but got I4
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Expected VT, but got Unknown
		//IL_0eb3: Expected I4, but got F8
		//IL_0efa: Expected I4, but got F8
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d: Expected Obj, but got Unknown
		//IL_0f4b: Expected Obj, but got I4
		//IL_0f6f: Expected Obj, but got I4
		//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Expected VT, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected VT, but got Unknown
		//IL_0c01: Expected Obj, but got I
		//IL_1bbe: Expected I4, but got F8
		//IL_0bc2: Expected Obj, but got I4
		//IL_1058: Expected VT, but got I8
		//IL_1080: Expected Obj, but got I
		//IL_108f: Expected Obj, but got VT
		//IL_109f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a4: Expected VT, but got Unknown
		//IL_0ba6: Expected Obj, but got I4
		//IL_11d3: Expected I4, but got F8
		//IL_121a: Expected I4, but got F8
		//IL_1574: Unknown result type (might be due to invalid IL or missing references)
		//IL_1579: Expected Obj, but got Unknown
		//IL_1328: Expected VT, but got Obj
		//IL_149b: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a0: Expected Obj, but got Unknown
		//IL_14f0: Expected F4, but got I
		//IL_14f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fe: Expected VT, but got Unknown
		//IL_136a: Expected VT, but got Obj
		//IL_12a9: Expected Obj, but got I
		//IL_12c8: Expected Obj, but got I
		//IL_12d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d6: Expected VT, but got Unknown
		//IL_15e6: Expected Obj, but got I
		//IL_1605: Expected Obj, but got I
		//IL_160e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1613: Expected VT, but got Unknown
		//IL_12fd: Invalid comparison between I and F4
		//IL_1652: Expected Obj, but got I
		//IL_167a: Unknown result type (might be due to invalid IL or missing references)
		//IL_167f: Expected VT, but got Unknown
		//IL_16da: Unknown result type (might be due to invalid IL or missing references)
		//IL_16df: Expected VT, but got Unknown
		//IL_1712: Expected VT, but got I
		//IL_1735: Unknown result type (might be due to invalid IL or missing references)
		//IL_173a: Expected VT, but got Unknown
		object obj = default;
		UIPopupList uIPopupList = (UIPopupList)(obj - 736);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Transform transform;
		object obj3;
		object obj4;
		object obj8;
		object obj9;
		if (enabled)
		{
			GameObject go = base.gameObject;
			if (NGUITools.GetActive(go) && mChild == null && atlas != null && isValid)
			{
				List<string> list = items;
				if (list._size >= 1)
				{
					((List<T>)(object)mLabelList).Clear();
					StopCoroutine("CloseIfUnselected");
					GameObject hoveredObject = UICamera.hoveredObject;
					bool flag = (object)hoveredObject == null;
					bool flag2 = !flag;
					GameObject selectedObject = hoveredObject;
					if (!flag2)
					{
						GameObject gameObject = base.gameObject;
						selectedObject = gameObject;
					}
					UICamera.selectedObject = selectedObject;
					GameObject selectedObject2 = UICamera.selectedObject;
					mSelection = selectedObject2;
					GameObject selectedObject3 = UICamera.selectedObject;
					source = selectedObject3;
					if (source == null)
					{
						return;
					}
					int frameCount = Time.frameCount;
					mOpenFrame = frameCount;
					if (mPanel == null)
					{
						Transform trans = base.transform;
						UIPanel uIPanel = UIPanel.Find(trans);
						mPanel = uIPanel;
						if (!(mPanel != null))
						{
							return;
						}
					}
					GameObject gameObject2 = default;
					gameObject2._002Ector("Drop-down List");
					mChild = gameObject2;
					GameObject gameObject3 = base.gameObject;
					int layer = gameObject3.layer;
					mChild.layer = layer;
					current = this;
					transform = mChild.transform;
					Transform cachedTransform = mPanel.cachedTransform;
					transform.parent = cachedTransform;
					object obj2;
					object obj5;
					object obj6;
					object obj7;
					object obj10;
					if (openOn == OpenOn.Manual)
					{
						GameObject gameObject4 = base.gameObject;
						if (mSelection != gameObject4)
						{
							Vector2 lastEventPosition = UICamera.lastEventPosition;
							Transform cachedTransform2 = mPanel.cachedTransform;
							Camera anchorCamera = mPanel.anchorCamera;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
							_ = 0;
							Vector3 vector = (Vector3)(uIPopupList + 344);
							Vector3 vector2 = anchorCamera.ScreenToWorldPoint(vector);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
							_ = 0;
							Vector3 vector3 = (Vector3)(uIPopupList + 328);
							Vector3 vector4 = cachedTransform2.InverseTransformPoint(vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+298]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+290]");
							_ = 0;
							Vector3 localPosition = (Vector3)(uIPopupList + 312);
							transform.localPosition = localPosition;
							Vector3 vector5 = transform.position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
							obj2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
							obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
							obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
							obj10 = 0;
							goto IL_17b8;
						}
					}
					Transform cachedTransform3 = mPanel.cachedTransform;
					Transform content = base.transform;
					Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(cachedTransform3, content, considerInactive: false, considerChildren: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+288]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
					_ = 0;
					Bounds bounds2 = (Bounds)(uIPopupList + 704);
					Vector3 min = ((Bounds*)bounds2)->min;
					Bounds bounds3 = (Bounds)(uIPopupList + 704);
					Vector3 max = ((Bounds*)bounds3)->max;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+270]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+268]");
					_ = 0;
					Vector3 localPosition2 = (Vector3)(uIPopupList + 360);
					transform.localPosition = localPosition2;
					Vector3 vector6 = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
					obj10 = 0;
					goto IL_17b8;
				}
			}
		}
		OnSelect(isSelected: false);
		return;
		IL_17b8:
		Coroutine coroutine = StartCoroutine("CloseIfUnselected");
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S0_v114 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S0_v115 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+260]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+258]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(uIPopupList + 296);
		transform.localRotation = localRotation;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S1_v60 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S1_v61 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		_ = Vector3.oneVector;
		Vector3 localScale = (Vector3)(uIPopupList + 280);
		transform.localScale = localScale;
		UISprite uISprite = NGUITools.AddSprite(mChild, atlas, backgroundSprite);
		mBackground = uISprite;
		mBackground.pivot = UIWidget.Pivot.TopLeft;
		GameObject go2 = mPanel.gameObject;
		int depth = NGUITools.CalculateNextDepth(go2);
		mBackground.depth = depth;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList)+58]");
		_ = 0;
		_ = backgroundColor;
		Color color = (Color)(uIPopupList + 264);
		mBackground.color = color;
		object obj11 = uIPopupList + 632;
		UISprite uISprite2 = mBackground;
		nint num5 = (nint)uISprite2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v691 @ S2_v30 (Il2CppClass<UISprite>)+1BC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
		mBgBorder = 0f;
		Transform cachedTransform4 = mBackground.cachedTransform;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+248]");
		_ = 0;
		Vector3 localPosition3 = (Vector3)(uIPopupList + 248);
		cachedTransform4.localPosition = localPosition3;
		UISprite uISprite3 = NGUITools.AddSprite(mChild, atlas, highlightSprite);
		mHighlight = uISprite3;
		mHighlight.pivot = UIWidget.Pivot.TopLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList)+68]");
		_ = 0;
		_ = highlightColor;
		Color color2 = (Color)(uIPopupList + 232);
		mHighlight.color = color2;
		UISpriteData atlasSprite = mHighlight.GetAtlasSprite();
		if (atlasSprite == null)
		{
			return;
		}
		int num6 = activeFontSize;
		float num7 = activeFontScale;
		float num8 = (float)num6 * num7;
		float num9 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList)+3C]");
		float num10 = num9 - 0f;
		List<UILabel> list2 = default;
		list2._002Ector();
		if (!items.Contains(mSelectedItem))
		{
			mSelectedItem = null;
		}
		object obj12 = this - -64;
		_ = 0;
		List<string> list3 = items;
		float num11 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+2DC]");
		int num12 = 0;
		UIEventListener.BoolDelegate boolDelegate = default;
		UIEventListener.BoolDelegate boolDelegate2 = default;
		object obj16 = default;
		while (num12 < list3._size)
		{
			string text = items.get_Item(num12);
			UILabel uILabel = NGUITools.AddWidget<UILabel>(mChild);
			int num13 = uIPopupList + 732;
			string text2 = ((int*)num13)->ToString();
			uILabel.name = text2;
			uILabel.pivot = UIWidget.Pivot.TopLeft;
			uILabel.bitmapFont = bitmapFont;
			uILabel.trueTypeFont = trueTypeFont;
			uILabel.fontSize = fontSize;
			uILabel.fontStyle = fontStyle;
			string text3 = ((~(isLocalized ? 1u : 0u) != 0) ? text : Localization.Get(text));
			uILabel.text = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ S0_v191+8]");
			uIPopupList.backgroundSprite = (string)0;
			uIPopupList.fontSize = (int)obj12;
			Color color3 = (Color)(uIPopupList + 24);
			uILabel.color = color3;
			Transform cachedTransform5 = uILabel.cachedTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			object obj13 = 0 + padding;
			Vector2 pivotOffset = uILabel.pivotOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			object obj14 = obj13 - 0;
			_ = -1082130432;
			uIPopupList.bitmapFont = (UIFont)(-1082130432);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+238]");
			((UnityEngine.Object)uIPopupList).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition4 = (Vector3)(uIPopupList + 8);
			cachedTransform5.localPosition = localPosition4;
			if (uILabel.mOverflow != UILabel.Overflow.ResizeFreely)
			{
				uILabel.mOverflow = UILabel.Overflow.ResizeFreely;
				((UIRect)uILabel).mChanged = true;
				uILabel.mShouldBeProcessed = true;
			}
			uILabel.alignment = alignment;
			list2.Add(uILabel);
			float num14 = num11 - num8;
			float num15 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList)+3C]");
			float num16 = num15 - 0f;
			Vector2 printedSize = uILabel.printedSize;
			GameObject go3 = uILabel.gameObject;
			UIEventListener uIEventListener = UIEventListener.Get(go3);
			boolDelegate._002Ector(this, (nint)__ldftn(UIPopupList.OnItemHover));
			uIEventListener.onHover = boolDelegate;
			boolDelegate2._002Ector(this, (nint)__ldftn(UIPopupList.OnItemPress));
			uIEventListener.onPress = boolDelegate2;
			uIEventListener.parameter = text;
			object obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			bool flag3 = (nint)obj15 > 0;
			if (mSelectedItem == text)
			{
				goto IL_0bc7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+2DC]");
			if ((nint)0 != 0)
			{
				goto IL_0bdb;
			}
			string text4 = mSelectedItem;
			object obj17;
			if (mSelectedItem != null)
			{
				obj17 = 0;
				if (text4._stringLength != 0)
				{
					goto IL_198a;
				}
			}
			obj17 = 1;
			goto IL_198a;
			IL_0bdb:
			obj16 = obj16;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
				obj16 = 0;
			}
			mLabelList.Add(uILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+2DC]");
			int num17 = (int)((nint)0 + (nint)1);
			num11 = num16;
			num12 = num17;
			continue;
			IL_198a:
			if (obj17 != null)
			{
				goto IL_0bc7;
			}
			goto IL_0bdb;
			IL_0bc7:
			Highlight(uILabel, instant: true);
			goto IL_0bdb;
		}
		object obj18 = obj8 - obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
		object obj19 = 0 + padding;
		object obj20 = obj19 + obj19;
		object obj21 = obj18 - obj20;
		bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
		object obj22 = obj16;
		if (!flag4)
		{
			obj22 = obj21;
		}
		float num18 = (float)obj22 * 0.5f;
		float num19 = 0f - num8;
		float num20 = num19 * 0.5f;
		object obj23 = num20 << 32;
		Color color4 = (Color)(num18 | obj23);
		float num21 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList)+3C]");
		float num22 = num21 + 0f;
		object obj24 = num22 << 32;
		object obj25 = obj22 | obj24;
		int num23 = 0;
		while (num23 < list2._size)
		{
			UILabel uILabel2 = list2.get_Item(num23);
			GameObject go4 = uILabel2.gameObject;
			NGUITools.AddWidgetCollider(go4);
			uILabel2.autoResizeBoxCollider = false;
			BoxCollider component = uILabel2.GetComponent<BoxCollider>();
			if (component != null)
			{
				Vector3 center = component.center;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
				_ = 0;
				object obj26 = uIPopupList - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+230]");
				obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+228]");
				uIPopupList.padding = (Vector2)0;
				Vector3 center2 = (Vector3)(uIPopupList + 56);
				component.center = center2;
				_ = 1065353216;
				uIPopupList.items = (List<string>)1065353216;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+218]");
				uIPopupList.position = Position.Auto;
				Vector3 size = (Vector3)(uIPopupList + 40);
				component.size = size;
			}
			else
			{
				BoxCollider2D component2 = uILabel2.GetComponent<BoxCollider2D>();
				uIPopupList.backgroundColor = color4;
				Vector2 offset = (Vector2)(uIPopupList + 80);
				component2.offset = offset;
				Vector2 size2 = (Vector2)(uIPopupList + 72);
				component2.size = size2;
			}
			int num24 = num23 + 1;
			num23 = num24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num26 = default;
		double num25 = Math.Abs(num26);
		if (!(num25 < 2147483648.0))
		{
			num26 = -2147483648.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
		object obj27 = 0 + padding;
		object obj28 = obj27 + obj27;
		object obj29 = obj22 + obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num28 = default;
		double num27 = Math.Abs(num28);
		int width = ((!(num27 < 2147483648.0)) ? int.MinValue : ((int)num28));
		mBackground.width = width;
		float num29 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
		float num30 = num29 - 0f;
		float num31 = 0f - num30;
		float num32 = num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
		float num33 = num32 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num35 = default;
		double num34 = Math.Abs(num35);
		int height = ((!(num34 < 2147483648.0)) ? int.MinValue : ((int)num35));
		mBackground.height = height;
		if (~(isDraggable ? 1u : 0u) == 0)
		{
			GameObject gameObject5 = mBackground.gameObject;
			BoxCollider boxCollider = gameObject5.AddComponent<BoxCollider>();
			UISprite uISprite4 = mBackground;
			object obj30 = ((UIWidget)uISprite4).mWidth + 30;
			_ = 1065353216;
			_ = 1065353216;
			object obj31 = ((UIWidget)uISprite4).mHeight + 30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1F8]");
			_ = 0;
			Vector3 size3 = (Vector3)(uIPopupList + 216);
			boxCollider.size = size3;
			Vector3 localCenter = mBackground.localCenter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			_ = 0;
			Vector3 center3 = (Vector3)(uIPopupList + 200);
			boxCollider.center = center3;
			GameObject gameObject6 = mBackground.gameObject;
			UIDragObject uIDragObject = gameObject6.AddComponent<UIDragObject>();
			Transform target = mChild.transform;
			uIDragObject.target = target;
			_ = 1065353216;
			uIDragObject.scale = (Vector3)4575657221408423936L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPopupList)+58]");
			_ = 0;
			_ = 1063675494;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1E0]");
			uIPopupList.source = (GameObject)0;
			uIPopupList.mLegacyEvent = (LegacyEvent)backgroundColor;
			_ = backgroundColor;
			Color color5 = (Color)(uIPopupList + 184);
			mBackground.color = color5;
		}
		int num36 = 0;
		while (num36 < list2._size)
		{
			UILabel uILabel3 = list2.get_Item(num36);
			if (uILabel3.mOverflow != UILabel.Overflow.ShrinkContent)
			{
				uILabel3.mOverflow = UILabel.Overflow.ShrinkContent;
				((UIRect)uILabel3).mChanged = true;
				uILabel3.mShouldBeProcessed = true;
			}
			uILabel3.width = (int)num26;
			int num37 = num36 + 1;
			num36 = num37;
		}
		float pixelSize = atlas.pixelSize;
		float num38 = pixelSize + pixelSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
		object obj32 = 0 + padding;
		object obj33 = obj32 + obj32;
		object obj34 = obj29 - obj33;
		float num39 = (float)atlasSprite.borderLeft * num38;
		float num40 = (float)obj34 + num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num42 = default;
		double num41 = Math.Abs(num42);
		int width2 = ((!(num41 < 2147483648.0)) ? int.MinValue : ((int)num42));
		mHighlight.width = width2;
		float num43 = (float)atlasSprite.borderTop * num38;
		float num44 = num8 + num43;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num46 = default;
		double num45 = Math.Abs(num46);
		int height2 = ((!(num45 < 2147483648.0)) ? int.MinValue : ((int)num46));
		mHighlight.height = height2;
		bool flag5 = position == Position.Above;
		bool flag6 = flag5;
		if (position == Position.Auto)
		{
			int layer2 = mSelection.layer;
			UICamera uICamera = UICamera.FindCameraForLayer(layer2);
			bool flag7 = uICamera != null;
			bool flag8 = !flag7;
			flag6 = flag5;
			if (!flag8)
			{
				Camera cachedCamera = uICamera.cachedCamera;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1D0]");
				uIPopupList.font = (UIFont)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1C8]");
				uIPopupList.functionName = (string)0;
				Vector3 vector7 = (Vector3)(uIPopupList + 168);
				Vector3 vector8 = cachedCamera.WorldToViewportPoint(vector7);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
				bool flag9 = 0f < 0.5f;
				flag6 = flag9;
			}
		}
		if (~(isAnimated ? 1u : 0u) == 0)
		{
			uIPopupList.AnimateColor(mBackground);
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			float timeScale = Time.timeScale;
			if (timeScale != 0f)
			{
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				float timeScale2 = Time.timeScale;
				if (timeScale2 < 0.1f)
				{
					goto IL_1436;
				}
			}
			float bottom = num30 + num8;
			uIPopupList.Animate(mHighlight, flag6, bottom);
			int num47 = 0;
			while (num47 < list2._size)
			{
				UILabel widget = list2.get_Item(num47);
				uIPopupList.Animate(widget, flag6, bottom);
				int num48 = num47 + 1;
				num47 = num48;
			}
			AnimateScale(mBackground, flag6, bottom);
		}
		goto IL_1436;
		IL_1436:
		if (flag6)
		{
			float num49 = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
			float num50 = num49 - 0f;
			UISprite uISprite5 = mBackground;
			float num51 = num50 + (float)((UIWidget)uISprite5).mHeight;
			UISprite uISprite6 = mBackground;
			object obj35 = obj3 + ((UIWidget)uISprite6).mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1C0]");
			uIPopupList.mOpenFrame = 0;
			float num52 = num51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
			float num53 = num52 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1B8]");
			uIPopupList.mBgBorder = 0f;
			Vector3 localPosition5 = (Vector3)(uIPopupList + 152);
			transform.localPosition = localPosition5;
			float num54 = num51;
			float num55 = num50;
			object obj36 = obj35;
		}
		else
		{
			float num56 = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+27C]");
			float num57 = num56 + 0f;
			UISprite uISprite7 = mBackground;
			float num58 = num57 - (float)((UIWidget)uISprite7).mHeight;
			UISprite uISprite8 = mBackground;
			object obj37 = obj3 + ((UIWidget)uISprite8).mWidth;
			float num54 = num57;
			float num55 = num58;
			object obj36 = obj37;
		}
		Transform cachedTransform6 = mPanel.cachedTransform;
		Transform parent = cachedTransform6.parent;
		if (parent != null)
		{
			Transform cachedTransform7 = mPanel.cachedTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1B0]");
			uIPopupList.mHighlightedLabel = (UILabel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1A8]");
			uIPopupList.mBackground = (UISprite)0;
			Vector3 vector9 = (Vector3)(uIPopupList + 136);
			Vector3 vector10 = cachedTransform7.TransformPoint(vector9);
			Transform cachedTransform8 = mPanel.cachedTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+1A0]");
			uIPopupList.mSelectedItem = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+198]");
			uIPopupList.isDraggable = false;
			Vector3 vector11 = (Vector3)(uIPopupList + 120);
			Vector3 vector12 = cachedTransform8.TransformPoint(vector11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+190]");
			uIPopupList.isAnimated = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			_ = 0;
			Vector3 vector13 = (Vector3)(uIPopupList + 104);
			Vector3 vector14 = parent.InverseTransformPoint(vector13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+180]");
			uIPopupList.highlightColor = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UIPopupList)+278]");
			_ = 0;
			Vector3 vector15 = (Vector3)(uIPopupList + 88);
			Vector3 vector16 = parent.InverseTransformPoint(vector15);
		}
	}

	public UIPopupList()
	{
		//IL_003c: Expected VT, but got I8
		//IL_0055: Expected VT, but got I8
		//IL_006e: Expected VT, but got I8
		//IL_007d: Expected VT, but got I8
		List<string> list = default;
		list._002Ector();
		items = list;
		List<object> list2 = default;
		list2._002Ector();
		itemData = list2;
		isAnimated = true;
		_ = 4575657222466868887L;
		highlightColor = (Color)4560115389389988322L;
		_ = 4575657222473777152L;
		backgroundColor = (Color)4575657222473777152L;
		_ = 4575657222473777152L;
		textColor = (Color)4575657222473777152L;
		padding = (Vector2)4647714816528482304L;
		List<EventDelegate> list3 = default;
		list3._002Ector();
		onChange = list3;
		List<UILabel> list4 = default;
		list4._002Ector();
		mLabelList = list4;
		functionName = "OnSelectionChange";
		base._002Ector();
	}
}
