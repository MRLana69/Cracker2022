using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

public class UITextList : MonoBehaviour
{
	public enum Style
	{
		Text,
		Chat
	}

	protected class Paragraph
	{
		public string text;

		public string[] lines;
	}

	public UILabel textLabel;

	public UIProgressBar scrollBar;

	public Style style;

	public int paragraphHistory = 100;

	protected char[] mSeparator;

	protected float mScroll;

	protected int mTotalLines;

	protected int mLastWidth;

	protected int mLastHeight;

	private BetterList<Paragraph> mParagraphs;

	private static Dictionary<string, BetterList<Paragraph>> mHistory;

	protected unsafe BetterList<Paragraph> paragraphs
	{
		get
		{
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected Ref, but got Unknown
			//IL_006d: Expected Obj, but got I
			ref BetterList<Paragraph> reference = ref *(BetterList<Paragraph>*)(this + 48);
			if (mParagraphs == null)
			{
				string key = name;
				if (!mHistory.TryGetValue(key, out reference))
				{
					BetterList<Paragraph> betterList = default;
					mParagraphs = betterList;
					string text = name;
					nint num = 0;
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, BetterList`1<UITextList+Paragraph>>>)+5C]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S5_v5+4] (should have been resolved before IL gen)");
				}
			}
			return reference;
		}
	}

	public bool isValid
	{
		get
		{
			if (textLabel != null)
			{
				UnityEngine.Object ambigiousFont = textLabel.ambigiousFont;
				return ambigiousFont != null;
			}
			return false;
		}
	}

	public float scrollValue
	{
		get
		{
			return mScroll;
		}
		set
		{
			if (!isValid)
			{
				return;
			}
			float num = Math.Min(value, 1f);
			bool flag = value < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			if (num2 != mScroll)
			{
				if (scrollBar != null)
				{
					scrollBar.value = num2;
					return;
				}
				mScroll = num2;
				UpdateVisibleText();
			}
		}
	}

	protected float lineHeight
	{
		get
		{
			//IL_0038: Expected I4, but got F4
			if (textLabel != null)
			{
				UILabel uILabel = textLabel;
				int num = ((~(uILabel.mUseFloatSpacing ? 1u : 0u) != 0) ? uILabel.mSpacingY : ((int)uILabel.mFloatSpacingY));
				return (float)uILabel.mFontSize + (float)num;
			}
			return 20f;
		}
	}

	protected int scrollHeight
	{
		get
		{
			//IL_0066: Expected F8, but got I4
			//IL_00e4: Invalid comparison between F8 and I4
			//IL_00f2: Expected I4, but got F8
			int result;
			if (isValid)
			{
				UILabel uILabel = textLabel;
				float num = lineHeight;
				float num2 = (float)((UIWidget)uILabel).mHeight / num;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				double num3 = Math.Abs((double)num2);
				double num4 = ((!(num3 < 2147483648.0)) ? (-2147483648.0) : ((double)num2));
				double num5 = (double)mTotalLines - num4;
				bool flag = num5 > 0.0;
				result = (int)num5;
				if (!flag)
				{
					result = 0;
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}

	public void Clear()
	{
		BetterList<Paragraph> betterList = paragraphs;
		betterList.size = 0;
		UpdateVisibleText();
	}

	private unsafe void Start()
	{
		if (textLabel == null)
		{
			UILabel componentInChildren = GetComponentInChildren<UILabel>();
			textLabel = componentInChildren;
		}
		if (scrollBar != null)
		{
			UIProgressBar uIProgressBar = scrollBar;
			EventDelegate.Callback callback = default;
			callback._002Ector(this, (nint)__ldftn(UITextList.OnScrollBar));
			EventDelegate eventDelegate = EventDelegate.Add(uIProgressBar.onChange, callback);
		}
		UILabel uILabel = textLabel;
		if (uILabel.mOverflow != UILabel.Overflow.ClampContent)
		{
			uILabel.mOverflow = UILabel.Overflow.ClampContent;
			((UIRect)uILabel).mChanged = true;
			uILabel.mShouldBeProcessed = true;
		}
		bool flag = style == Style.Chat;
		UIWidget.Pivot pivot = UIWidget.Pivot.BottomLeft;
		if (!flag)
		{
			pivot = UIWidget.Pivot.TopLeft;
		}
		textLabel.pivot = pivot;
		float num = 1f;
		if (!flag)
		{
			num = 0f;
		}
		scrollValue = num;
	}

	private void Update()
	{
		if (isValid)
		{
			UILabel uILabel = textLabel;
			if (((UIWidget)uILabel).mWidth != mLastWidth || ((UIWidget)uILabel).mHeight != mLastHeight)
			{
				Rebuild();
			}
		}
	}

	public void OnScroll(float val)
	{
		int num = scrollHeight;
		if (num != 0)
		{
			float num2 = lineHeight;
			float num3 = val * num2;
			float num4 = num3 / (float)num;
			float num5 = mScroll - num4;
			scrollValue = num5;
		}
	}

	public void OnDrag(Vector2 delta)
	{
		int num = scrollHeight;
		if (num != 0)
		{
			float num2 = lineHeight;
			float num3 = delta.y / num2;
			float num4 = num3 / (float)num;
			float num5 = mScroll + num4;
			scrollValue = num5;
		}
	}

	private void OnScrollBar()
	{
		float value = UIProgressBar.current.value;
		mScroll = value;
		UpdateVisibleText();
	}

	public void Add(string text)
	{
		Add(text, updateVisible: false);
	}

	protected void Add(string text, bool updateVisible)
	{
		BetterList<Paragraph> betterList = paragraphs;
		Paragraph paragraph;
		if (betterList.size < paragraphHistory)
		{
			Paragraph paragraph2 = default;
			paragraph = paragraph2;
		}
		else
		{
			BetterList<Paragraph> betterList2 = mParagraphs;
			Paragraph[] buffer = betterList2.buffer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B21B");
			paragraph = buffer[0];
		}
		paragraph.text = text;
		mParagraphs.Add(paragraph);
		Rebuild();
	}

	protected unsafe void Rebuild()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Ref, but got Unknown
		//IL_00dd: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!isValid)
		{
			return;
		}
		UILabel uILabel = textLabel;
		mLastWidth = ((UIWidget)uILabel).mWidth;
		mLastHeight = ((UIWidget)uILabel).mHeight;
		uILabel.UpdateNGUIText();
		NGUIText.rectHeight = 1000000;
		NGUIText.regionHeight = 1000000;
		mTotalLines = 0;
		object obj3 = 0;
		while (true)
		{
			BetterList<Paragraph> betterList = paragraphs;
			if (betterList.size <= (nint)obj3)
			{
				break;
			}
			BetterList<Paragraph> betterList2 = mParagraphs;
			object obj4 = obj3 << 2;
			object obj5 = (object)betterList2.buffer + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v63+10]");
			object obj6 = 0;
			ref string finalText = ref *(string*)(obj + 12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v64+8]");
			bool flag = NGUIText.WrapText((string)0, out finalText, keepCharCount: false, wrapLineColors: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string[] array = ((string)0).Split('\n');
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v64+C]");
			object obj7 = 0;
			int num = mTotalLines;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S2_v24+C]");
			int num2 = (int)((nint)num + (nint)0);
			mTotalLines = num2;
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		mTotalLines = 0;
		BetterList<Paragraph> betterList3 = mParagraphs;
		object obj9 = 0;
		while ((nint)obj9 < betterList3.size)
		{
			BetterList<Paragraph> betterList4 = mParagraphs;
			object obj10 = obj9 << 2;
			object obj11 = (object)betterList4.buffer + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v15+10]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S2_v16+C]");
			object obj13 = 0;
			int num3 = mTotalLines;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v17+C]");
			int num4 = (int)((nint)num3 + (nint)0);
			mTotalLines = num4;
			object obj14 = obj9 + 1;
			obj9 = obj14;
		}
		if (scrollBar != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			UnityEngine.Object obj15 = default;
			if (obj15 != null)
			{
				float barSize;
				if (mTotalLines != 0)
				{
					int num5 = scrollHeight;
					int num6 = num5 / mTotalLines;
					barSize = 1f - (float)num6;
				}
				else
				{
					barSize = 1f;
				}
				((UIScrollBar)obj15).barSize = barSize;
			}
		}
		UpdateVisibleText();
	}

	protected void UpdateVisibleText()
	{
		//IL_0083: Expected F8, but got I4
		//IL_0342: Invalid comparison between F8 and I4
		//IL_0091: Expected F8, but got I4
		//IL_00d0: Expected F8, but got I4
		//IL_0384: Invalid comparison between F8 and I4
		//IL_03c3: Expected Obj, but got I4
		//IL_03ec: Invalid comparison between F8 and I4
		//IL_00de: Expected F8, but got I4
		//IL_02a3: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_041f: Invalid comparison between F8 and I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Invalid comparison between F8 and I4
		//IL_0208: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		if (!isValid)
		{
			return;
		}
		if (mTotalLines == 0)
		{
			textLabel.text = string.Empty;
			return;
		}
		UILabel uILabel = textLabel;
		float num = lineHeight;
		float num2 = (float)((UIWidget)uILabel).mHeight / num;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num3 = Math.Abs((double)num2);
		double num4 = ((!(num3 < 2147483648.0)) ? (-2147483648.0) : ((double)num2));
		double num5 = (double)mTotalLines - num4;
		if (!(num5 > 0.0))
		{
			num5 = 0.0;
		}
		double num6 = (double)mScroll * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num8 = default;
		double num7 = Math.Abs(num8);
		if (!(num7 < 2147483648.0))
		{
			num8 = -2147483648.0;
		}
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		bool flag = num8 > 0.0;
		double num9 = num8;
		if (!flag)
		{
			num9 = 0.0;
		}
		BetterList<Paragraph> betterList = paragraphs;
		double num10 = num4;
		double num11 = num9;
		object obj = 0;
		while (!(num10 < 1.0) && (nint)obj < betterList.size)
		{
			BetterList<Paragraph> betterList2 = mParagraphs;
			object obj2 = obj << 2;
			object obj3 = (object)betterList2.buffer + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v55+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v56+C]");
			object obj5 = 0;
			object obj6 = 0;
			while (!(num10 < 1.0))
			{
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v57+C]");
				if ((nint)obj7 >= 0)
				{
					break;
				}
				object obj8 = obj6 << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v56+C]");
				object obj9 = 0 + obj8;
				if (!(num11 < 1.0))
				{
					double num12 = num11 - 1.0;
					num11 = num12;
				}
				else
				{
					object obj10 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
					if ((nint)obj10 >= 1)
					{
						StringBuilder stringBuilder2 = stringBuilder.Append("\n");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v70+10]");
					StringBuilder stringBuilder3 = stringBuilder.Append((string)0);
					double num13 = num10 - 1.0;
					num10 = num13;
				}
				object obj11 = obj6 + 1;
				obj6 = obj11;
			}
			object obj12 = obj + 1;
			obj = obj12;
		}
		nint num14 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ S2_v12 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string text = default;
		textLabel.text = text;
	}

	public UITextList()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = '\n';
		mSeparator = array;
		base._002Ector();
	}

	static UITextList()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, BetterList`1<UITextList+Paragraph>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, BetterList<Paragraph>> dictionary = default;
		mHistory = dictionary;
	}
}
