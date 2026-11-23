using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
	private struct FadeEntry
	{
		public int index;

		public string text;

		public float alpha;
	}

	public static TypewriterEffect current;

	public int charsPerSecond = 20;

	public float fadeInTime;

	public float delayOnPeriod;

	public float delayOnNewLine;

	public UIScrollView scrollView;

	public bool keepFullDimensions;

	public List<EventDelegate> onFinished;

	private UILabel mLabel;

	private string mFullText;

	private int mCurrentOffset;

	private float mNextChar;

	private bool mReset;

	private bool mActive;

	private BetterList<FadeEntry> mFade;

	public bool isActive => mActive;

	public void ResetToBeginning()
	{
		Finish();
		mReset = true;
		mCurrentOffset = 0;
		Update();
	}

	public void Finish()
	{
		if (~(mActive ? 1u : 0u) == 0)
		{
			mActive = false;
			if (~(mReset ? 1u : 0u) != 0)
			{
				string text = mFullText;
				mCurrentOffset = text._stringLength;
				BetterList<FadeEntry> betterList = mFade;
				_ = 0;
				mLabel.text = mFullText;
			}
			if (~(keepFullDimensions ? 1u : 0u) == 0 && scrollView != null)
			{
				scrollView.UpdatePosition();
			}
			current = this;
			EventDelegate.Execute(onFinished);
			current = null;
		}
	}

	private void OnEnable()
	{
		mReset = true;
	}

	private void OnDisable()
	{
		Finish();
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Ref, but got Unknown
		//IL_073d: Expected Obj, but got I4
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_093f: Expected Obj, but got I4
		//IL_07f4: Expected Obj, but got I
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected VT, but got Unknown
		//IL_0817: Expected F4, but got I
		//IL_0812: Expected native int or pointer, but got VT
		//IL_0824: Expected I4, but got Obj
		//IL_081f: Expected native int or pointer, but got VT
		//IL_0ad0: Expected I, but got Obj
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected Obj, but got Unknown
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_02c4: Expected Obj, but got I4
		//IL_0a08: Expected F4, but got I
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0a49: Expected Obj, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected VT, but got Unknown
		//IL_05a9: Expected F4, but got I
		//IL_05a4: Expected native int or pointer, but got VT
		//IL_05b9: Expected native int or pointer, but got VT
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		if (~(mActive ? 1u : 0u) != 0)
		{
			return;
		}
		if (~(mReset ? 1u : 0u) == 0)
		{
			mReset = false;
			mCurrentOffset = 0;
			UILabel component = GetComponent<UILabel>();
			mLabel = component;
			string processedText = mLabel.processedText;
			mFullText = processedText;
			BetterList<FadeEntry> betterList = mFade;
			_ = 0;
			if (~(keepFullDimensions ? 1u : 0u) == 0 && scrollView != null)
			{
				scrollView.UpdatePosition();
			}
		}
		string text = mFullText;
		object obj3;
		if (mFullText != null)
		{
			obj3 = 0;
			if (text._stringLength != 0)
			{
				goto IL_0b14;
			}
		}
		obj3 = 1;
		goto IL_0b14;
		IL_0b14:
		if (obj3 != null)
		{
			return;
		}
		ref int reference = ref *(int*)(this + 48);
		object obj4 = obj;
		string text3;
		int num;
		while (true)
		{
			string text2 = mFullText;
			bool flag = mCurrentOffset >= text2._stringLength;
			text3 = text2;
			num = mCurrentOffset;
			if (flag)
			{
				break;
			}
			float unscaledTime = Time.unscaledTime;
			float num6;
			int num7;
			if (!(mNextChar > unscaledTime))
			{
				int num2 = charsPerSecond;
				if (charsPerSecond <= 1)
				{
					num2 = 1;
				}
				charsPerSecond = num2;
				UILabel uILabel = mLabel;
				int num3;
				if (~(uILabel.mEncoding ? 1u : 0u) == 0)
				{
					while (NGUIText.ParseSymbol(mFullText, ref reference))
					{
					}
					num3 = reference;
				}
				else
				{
					num3 = mCurrentOffset;
				}
				int num4 = (mCurrentOffset = num3 + 1);
				string text4 = mFullText;
				if (text4._stringLength < num4)
				{
					text3 = text4;
					num = num4;
					break;
				}
				float num5 = 1f / (float)charsPerSecond;
				if (mCurrentOffset < text4._stringLength)
				{
					char c = text4.get_Chars(mCurrentOffset);
					if (c != '\n')
					{
						string text5 = mFullText;
						object obj5 = mCurrentOffset + 1;
						if (text5._stringLength != (nint)obj5)
						{
							int index = mCurrentOffset + 1;
							char c2 = mFullText.get_Chars(index);
							bool flag2 = c2 > ' ';
							num6 = num5;
							num7 = mCurrentOffset;
							if (flag2)
							{
								goto IL_0bcf;
							}
						}
						if (c != '!' && c != '?')
						{
							bool flag3 = c != '.';
							num6 = num5;
							num7 = mCurrentOffset;
							if (!flag3)
							{
								string text6 = mFullText;
								object obj6 = mCurrentOffset + 2;
								if (text6._stringLength > (nint)obj6)
								{
									int index2 = mCurrentOffset + 1;
									char c3 = mFullText.get_Chars(index2);
									if (c3 == '.')
									{
										int index3 = mCurrentOffset + 2;
										char c4 = mFullText.get_Chars(index3);
										if (c4 == '.')
										{
											float num8 = delayOnPeriod * 3f;
											float num9 = num5 + num8;
											int num10 = mCurrentOffset + 2;
											num6 = num9;
											num7 = num10;
											goto IL_0bcf;
										}
									}
								}
								float num11 = num5 + delayOnPeriod;
								num6 = num11;
								num7 = mCurrentOffset;
							}
						}
						else
						{
							float num12 = num5 + delayOnPeriod;
							num6 = num12;
							num7 = mCurrentOffset;
						}
						goto IL_0bcf;
					}
				}
				float num13 = num5 + delayOnNewLine;
				num6 = num13;
				num7 = mCurrentOffset;
				goto IL_0bcf;
			}
			text3 = mFullText;
			num = mCurrentOffset;
			break;
			IL_0bcf:
			float unscaledTime2 = mNextChar;
			if (mNextChar == 0f)
			{
				unscaledTime2 = Time.unscaledTime;
			}
			float num14 = unscaledTime2 + num6;
			mNextChar = num14;
			if (fadeInTime != 0f)
			{
				object obj7 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				_ = 0;
				int length = mCurrentOffset - num7;
				string text7 = mFullText.Substring(num7, length);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
				_ = 0;
				FadeEntry fadeEntry = (FadeEntry)(obj4 - 16);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				((FadeEntry*)(nint)fadeEntry)->alpha = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				((FadeEntry*)(nint)fadeEntry)->index = 0;
				mFade.Add(fadeEntry);
				object obj8 = fadeEntry + 16;
				obj4 = obj8;
			}
			else
			{
				string text8 = mFullText.Substring(0, mCurrentOffset);
				string text10;
				if (~(keepFullDimensions ? 1u : 0u) == 0)
				{
					string text9 = mFullText.Substring(mCurrentOffset);
					text10 = text8 + "[00]" + text9;
				}
				else
				{
					text10 = text8;
				}
				mLabel.text = text10;
				if (!keepFullDimensions && scrollView != null)
				{
					scrollView.UpdatePosition();
				}
			}
		}
		if (text3._stringLength <= num)
		{
			mLabel.text = text3;
			current = this;
			EventDelegate.Execute(onFinished);
			current = null;
			mActive = false;
			return;
		}
		BetterList<FadeEntry> betterList2 = mFade;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v33 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		int num15 = 0;
		while (true)
		{
			BetterList<FadeEntry> betterList3 = mFade;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v39 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
			if ((nint)0 <= (nint)num15)
			{
				break;
			}
			object obj9 = num15 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v39 (BetterList`1<TypewriterEffect+FadeEntry>)+8]");
			object obj10 = 0 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v53+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v53+10]");
			_ = 0;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			float num16 = unscaledDeltaTime / fadeInTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			float num17 = 0f + num16;
			if (num17 < 1f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				obj = 0;
				FadeEntry fadeEntry2 = (FadeEntry)(obj4 - 16);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((FadeEntry*)(nint)fadeEntry2)->alpha = 0f;
				((FadeEntry*)(nint)fadeEntry2)->index = (int)obj;
				mFade.set_Item(num15, fadeEntry2);
				int num18 = num15 + 1;
				num15 = num18;
			}
			else
			{
				mFade.RemoveAt(num15);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v39 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
		if ((nint)0 == 0)
		{
			string text11 = mFullText.Substring(0, mCurrentOffset);
			if (~(keepFullDimensions ? 1u : 0u) == 0)
			{
				string text12 = mFullText.Substring(mCurrentOffset);
				string text13 = text11 + "[00]" + text12;
				mLabel.text = text13;
			}
			else
			{
				mLabel.text = text11;
			}
			return;
		}
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj11 = 0;
		while (true)
		{
			BetterList<FadeEntry> betterList4 = mFade;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v50 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
			if (0 <= (nint)obj11)
			{
				break;
			}
			object obj12 = obj11 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v50 (BetterList`1<TypewriterEffect+FadeEntry>)+8]");
			object obj13 = 0 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S1_v31+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S1_v31+10]");
			_ = 0;
			if (obj11 == null)
			{
				string text14 = mFullText;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				string value = text14.Substring(0, 0);
				StringBuilder stringBuilder2 = stringBuilder.Append(value);
			}
			StringBuilder stringBuilder3 = stringBuilder.Append('[');
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			string value2 = NGUIText.EncodeAlpha(0f);
			StringBuilder stringBuilder4 = stringBuilder.Append(value2);
			StringBuilder stringBuilder5 = stringBuilder.Append(']');
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
			StringBuilder stringBuilder6 = stringBuilder.Append((string)0);
			object obj14 = obj11 + 1;
			obj11 = obj14;
		}
		if (~(keepFullDimensions ? 1u : 0u) == 0)
		{
			StringBuilder stringBuilder7 = stringBuilder.Append("[00]");
			string value3 = mFullText.Substring(mCurrentOffset);
			StringBuilder stringBuilder8 = stringBuilder.Append(value3);
		}
		nint num19 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v599 @ S2_v9 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string text15 = default;
		mLabel.text = text15;
	}

	public TypewriterEffect()
	{
		List<EventDelegate> list = default;
		list._002Ector();
		onFinished = list;
		mFullText = string.Empty;
		mReset = true;
		BetterList<FadeEntry> betterList = default;
		mFade = betterList;
		base._002Ector();
	}
}
