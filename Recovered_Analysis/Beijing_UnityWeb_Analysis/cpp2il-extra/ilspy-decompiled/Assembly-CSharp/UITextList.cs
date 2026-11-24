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

		public Paragraph()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList+Paragraph)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList+Paragraph)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList+Paragraph)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && lines != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}
	}

	public UILabel textLabel;

	public UIProgressBar scrollBar;

	public Style style;

	public int paragraphHistory;

	protected char[] mSeparator;

	protected float mScroll;

	protected int mTotalLines;

	protected int mLastWidth;

	protected int mLastHeight;

	private BetterList<Paragraph> mParagraphs;

	private static Dictionary<string, BetterList<Paragraph>> mHistory;

	protected BetterList<Paragraph> paragraphs
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected I4, but got Unknown
			//IL_0052: Expected Obj, but got I4
			int num = mParagraphs | mLastHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+34]");
			int num2 = (int)((nint)num | (nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+38]");
			int num3 = (int)((nint)num2 | (nint)0);
			bool flag = num3 != 0;
			return (BetterList<Paragraph>)flag;
		}
	}

	public bool isValid
	{
		get
		{
			//IL_0221: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected Obj, but got Unknown
			//IL_0054: Expected I, but got Obj
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected Obj, but got Unknown
			//IL_00be: Expected I, but got Obj
			//IL_00d4: Expected Obj, but got I
			//IL_01cf: Expected Obj, but got I
			//IL_01df: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected Obj, but got Unknown
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Expected Obj, but got Unknown
			//IL_00ff: Expected I, but got Obj
			if (mParagraphs == null)
			{
				nint num = (nint)typeof(UITextList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<UITextList>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UITextList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v43 (Il2CppClass<UITextList>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
				object obj3 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
				object obj4 = default;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj5 = this + 48;
					object obj6 = default;
					obj5 = obj6;
					nint num3 = (nint)typeof(UITextList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29 (Il2CppClass<UITextList>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num4 = (nint)typeof(UITextList);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v37 (Il2CppClass<UITextList>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UnityEngine.Object obj8 = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S4_v3 (Il2CppMethodInfo)+C]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v4+60]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S4_v5+48]");
					object obj11 = 0;
					object obj12 = obj11 & 0x7FF;
					object obj13 = obj12 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S5_v5 (should have been resolved before IL gen)");
				}
			}
			return (byte)(int)mParagraphs != 0;
		}
	}

	public float scrollValue
	{
		get
		{
			//IL_0088: Expected I, but got Obj
			//IL_009e: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0063: Expected Obj, but got I
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+18C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+18C]");
				return ((UILabel)0).floatSpacingX;
			}
			return 1f;
		}
		set
		{
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01c0: Invalid comparison between I and F4
			//IL_00c4: Expected Obj, but got I
			//IL_0125: Invalid comparison between I and F4
			//IL_0163: Invalid comparison between I and F4
			//IL_00e7: Expected Obj, but got I
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3;
			if (value < 0f)
			{
				num3 = 0f;
			}
			else
			{
				num3 = ((!(value > 1f)) ? value : 1f);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+D4]");
			if (0f == num3)
			{
				return;
			}
			_ = -1;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+70]");
			object obj2 = 0;
			int num4 = 0;
			while (true)
			{
				int num5 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22+C]");
				if ((nint)num5 >= (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+70]");
				UIDrawCall uIDrawCall = ((List<UIDrawCall>)0).get_Item(num4);
				uIDrawCall.isDirty = true;
				int num6 = num4 + 1;
				num4 = num6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+D4]");
			if (0f > 0.001f)
			{
				bool flag = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITextList)+D4]");
				bool flag = 0f > 0.001f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	protected float lineHeight => mScroll;

	protected int scrollHeight
	{
		get
		{
			//IL_0111: Expected I, but got Obj
			//IL_0127: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0152: Expected I, but got Obj
			//IL_0168: Expected Obj, but got I
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)textLabel).FindKernel((string)null) != 0)
			{
				UILabel uILabel = textLabel;
				bool flag = (object)uILabel.mFont == null;
				bool flag2 = !flag;
				ComputeShader computeShader = (ComputeShader)(object)uILabel.mFont;
				if (!flag2)
				{
					computeShader = (ComputeShader)(object)uILabel.mTrueTypeFont;
				}
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return computeShader.FindKernel(null);
			}
			return 0;
		}
	}

	public void Clear()
	{
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0117: Expected I4, but got Obj
		//IL_0064: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		paragraphHistory = 1;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v28 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		Vector2 up = Vector2.up;
		object obj4 = obj3 + 24;
		obj4 = obj2;
		mSeparator = (char[])obj4;
		object obj5 = obj3 + 8;
		Vector2 up2 = Vector2.up;
		obj4 = obj5;
		mTotalLines = (int)obj4;
		Vector2 one = Vector2.one;
		obj4 = obj3;
		mLastHeight = (int)obj4;
		CancelInvoke();
	}

	private void Start()
	{
		bool flag = isValid;
		_ = 0;
		this._002Ector();
	}

	private unsafe void Update()
	{
		//IL_0255: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_02ac: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0082: Expected I, but got Obj
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0159: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v50 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (textLabel != null)
		{
			object obj2 = this + 12;
			UILabel componentInChildren = GetComponentInChildren<UILabel>();
			obj2 = componentInChildren;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)scrollBar).FindKernel((string)null) != 0)
		{
			UIProgressBar uIProgressBar = scrollBar;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			EventDelegate.Callback callback = default;
			((Delegate)callback).method_ptr = method_ptr;
			((Delegate)callback).method = (nint)__ldftn(UITextList.OnScrollBar);
			object obj4 = callback + 16;
			obj4 = this;
			nint num5 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v34 (Il2CppClass<EventDelegate>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v39 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = EventDelegate.Remove(uIProgressBar.onChange, callback);
		}
		UILabel uILabel = textLabel;
		if (uILabel.mOverflow != UILabel.Overflow.ClampContent)
		{
			uILabel.mOverflow = UILabel.Overflow.ClampContent;
			((UIRect)uILabel).mChanged = true;
			uILabel.mShouldBeProcessed = true;
		}
		if (style == Style.Chat)
		{
			textLabel.depth = 6;
			OnScroll(1f);
		}
		else
		{
			textLabel.depth = 0;
			OnScroll(0f);
		}
	}

	public void OnScroll(float val)
	{
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00dd: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3;
		if (val < 0f)
		{
			num3 = 0f;
		}
		else
		{
			num3 = ((!(val > 1f)) ? val : 1f);
		}
		if (scrollHeight == 0 || mScroll == num3)
		{
			return;
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)scrollBar).FindKernel((string)null) != 0)
		{
			scrollBar.alpha = num3;
			return;
		}
		mScroll = num3;
		this._002Ector();
	}

	public void OnDrag(Vector2 delta)
	{
		//IL_0012: Expected Obj, but got I
		//IL_0024: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+1C]");
		mSeparator = (char[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+20]");
		mScroll = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+24]");
		mTotalLines = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+28]");
		mLastWidth = 0;
	}

	private void OnScrollBar()
	{
		if (scrollHeight == 0)
		{
			return;
		}
		UILabel uILabel = textLabel;
		if (((UIWidget)uILabel).mWidth == mLastWidth)
		{
			UILabel uILabel2 = textLabel;
			if (((UIWidget)uILabel2).mHeight == mLastHeight)
			{
				return;
			}
		}
		UpdateVisibleText();
	}

	public void Add(string text)
	{
		Texture mainTexture = ((UITexture)this).mainTexture;
		if ((object)mainTexture != null)
		{
			float pixelSize = ((UITexture)this).pixelSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num = 0f / pixelSize;
			float num2 = num / (float)mainTexture;
			float val = mScroll + num2;
			OnScroll(val);
		}
	}

	protected unsafe void Add(string text, bool updateVisible)
	{
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01c4: Expected Obj, but got I4
		//IL_01e1: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected VT, but got Unknown
		//IL_034a: Expected VT, but got I4
		//IL_034a: Expected VT, but got Obj
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_036a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e1: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected VT, but got Unknown
		//IL_0270: Expected F4, but got Obj
		//IL_026b: Expected native int or pointer, but got VT
		//IL_0285: Expected F4, but got I
		//IL_0280: Expected native int or pointer, but got VT
		//IL_0292: Expected F4, but got Obj
		//IL_028d: Expected native int or pointer, but got VT
		//IL_02a7: Expected F4, but got I
		//IL_02a2: Expected native int or pointer, but got VT
		//IL_02c5: Expected F4, but got Obj
		//IL_02c0: Expected native int or pointer, but got VT
		//IL_02da: Expected F4, but got I
		//IL_02d5: Expected native int or pointer, but got VT
		//IL_02ec: Expected I4, but got VT
		//IL_02ec: Expected Ref, but got VT
		//IL_02f9: Expected Obj, but got F4
		//IL_0122: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		((UILabel)(object)text)._002Ector();
		nint num = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<UILabel>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v57 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v2 (Il2CppClass<NGUIText>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v18 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L1 (System.String)+1D0]");
		NGUIText.ReplaceLinks(ref *(string*)null, (string)(object)UILabel.mTempVerts, (string)(object)UILabel.mTempIndices);
		Vector3 vector = (Vector3)(obj2 + 60);
		Vector3 vector2 = ((UIPanel)(object)text).CalculateConstrainOffset((Vector2)UILabel.mTempVerts, (Vector2)0);
		object obj5 = obj2 + 24;
		object obj6 = (updateVisible ? 1u : 0u) << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
		object obj7 = obj2 + 12;
		object obj8 = (updateVisible ? 1u : 0u) << 1;
		object obj9 = obj8 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v50 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector3 = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector3)->x = (float)obj5;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v17+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v19+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector5 = vector3 - vector;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector2*)vector3)->set_Item((int)vector, 2f);
		obj = vector3.x;
		_ = vector3.z;
		throw new IndexOutOfRangeException();
	}

	protected void Rebuild()
	{
		float alpha = UIProgressBar.current.alpha;
		mScroll = alpha;
		this._002Ector();
	}

	protected unsafe void UpdateVisibleText()
	{
		//IL_0050: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_0091: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_02a7: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I4
		//IL_04a7: Expected Obj, but got I4
		//IL_04b0: Expected Obj, but got I4
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04d0: Expected Obj, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_01b6: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_015f: Expected I, but got Obj
		//IL_02e8: Expected I, but got Obj
		//IL_033f: Expected I, but got Obj
		//IL_0355: Expected Obj, but got I
		//IL_0380: Expected I, but got Obj
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected I4, but got Unknown
		ref int reference = ref *(int*)null;
		if (scrollHeight == 0)
		{
			return;
		}
		UILabel uILabel = textLabel;
		mLastWidth = ((UIWidget)uILabel).mWidth;
		UILabel uILabel2 = textLabel;
		mLastHeight = ((UIWidget)uILabel2).mHeight;
		textLabel._002Ector();
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v18 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v81 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.rectHeight = 1000000;
		NGUIText.regionHeight = 1000000;
		mTotalLines = 0;
		object obj3 = default;
		int num5 = default;
		object obj12 = default;
		while (true)
		{
			bool flag = isValid;
			object obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v19 (System.Boolean)+C]");
			if ((nint)obj2 >= 0)
			{
				break;
			}
			BetterList<Paragraph> betterList = mParagraphs;
			object obj4 = betterList.buffer + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			object obj7 = obj6;
			nint num3 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v60 (Il2CppClass<NGUIText>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v76 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v67+8]");
			bool flag2 = NGUIText.ReplaceLink(ref *(string*)null, ref reference, null, (string)1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj9 = num5 + 16;
			obj9 = 10;
			object obj10 = obj7 + 12;
			string text = ((string)reference).Substring(num5);
			obj10 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v67+C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v72+C]");
			int num6 = (int)((nint)0 + (nint)mTotalLines);
			mTotalLines = num6;
			obj3 = obj12 + 1;
		}
		mTotalLines = 0;
		BetterList<Paragraph> betterList2 = mParagraphs;
		object obj13 = 0;
		while ((nint)obj13 < betterList2.size)
		{
			BetterList<Paragraph> betterList3 = mParagraphs;
			object obj14 = betterList3.buffer + 16;
			object obj15 = obj13 << 2;
			object obj16 = obj14 + obj15;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v51+C]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v52+C]");
			int num7 = (int)((nint)0 + (nint)mTotalLines);
			mTotalLines = num7;
			object obj19 = obj13 + 1;
			obj13 = obj19;
		}
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)scrollBar).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ComputeShader computeShader = default;
			if (computeShader.FindKernel(null) != 0)
			{
				float delta;
				if (mTotalLines != 0)
				{
					Texture mainTexture = ((UITexture)this).mainTexture;
					int num12 = mainTexture / mTotalLines;
					delta = 1f - (float)num12;
				}
				else
				{
					delta = 1f;
				}
				((UIScrollView)(object)computeShader).Scroll(delta);
			}
		}
		this._002Ector();
	}

	public UITextList()
	{
		//IL_0064: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00a5: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I4
		//IL_0430: Expected Obj, but got I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got I
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got I4
		if (scrollHeight == 0)
		{
			return;
		}
		UILabel uILabel = textLabel;
		if (mTotalLines == 0)
		{
			uILabel.fontSize = (int)"";
			return;
		}
		float pixelSize = ((UITexture)this).pixelSize;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v51 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float f = (float)((UIWidget)uILabel).mHeight / pixelSize;
		int num3 = Mathf.RoundToInt(f);
		object obj2 = mTotalLines - num3;
		object obj3 = ((0 <= (nint)obj2) ? obj2 : ((object)0));
		float width = mScroll * (float)obj3;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		bool flag = isValid;
		bool flag2 = (nint)gUILayoutOption <= 0;
		bool flag3 = !flag2;
		GUILayoutOption gUILayoutOption2 = gUILayoutOption;
		int num4 = num3;
		if (!flag3)
		{
			gUILayoutOption2 = null;
			num4 = num3;
		}
		object obj5 = default;
		object obj19 = default;
		while (true)
		{
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v25 (System.Boolean)+C]");
			bool flag4 = (nint)obj4 < 0;
			bool flag5 = num4 > 0;
			object obj6 = flag4 & flag5;
			if (obj6 == null)
			{
				break;
			}
			BetterList<Paragraph> betterList = mParagraphs;
			object obj7 = betterList.buffer + 16;
			object obj8 = obj5 << 2;
			object obj9 = obj7 + obj8;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v40+C]");
			object obj11 = 0;
			object obj12 = 0;
			while (true)
			{
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v41+C]");
				bool flag6 = (nint)obj13 < 0;
				bool flag7 = num4 > 0;
				object obj14 = flag6 & flag7;
				if (obj14 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v40+C]");
				object obj15 = (nint)0 + (nint)16;
				object obj16 = obj12 << 2;
				object value = obj15 + obj16;
				if ((nint)gUILayoutOption2 < 1)
				{
					object obj17 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
					if ((nint)obj17 >= 1)
					{
						StringBuilder stringBuilder2 = stringBuilder.AppendLine("\n");
					}
					StringBuilder stringBuilder3 = stringBuilder.AppendLine((string)value);
					int num5 = num4 - 1;
					num4 = num5;
				}
				else
				{
					GUILayoutOption gUILayoutOption3 = (GUILayoutOption)(gUILayoutOption2 - 1);
					gUILayoutOption2 = gUILayoutOption3;
				}
				object obj18 = obj12 + 1;
				obj12 = obj18;
			}
			obj5 = obj19 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int fontSize = default;
		textLabel.fontSize = fontSize;
	}

	static UITextList()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		List<UIRoot> list = default;
		UIRoot.list = list;
	}
}
