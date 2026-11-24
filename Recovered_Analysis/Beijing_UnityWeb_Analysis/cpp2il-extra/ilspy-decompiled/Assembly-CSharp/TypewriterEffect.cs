using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using SYBO.Subway.Level;
using SYBO.Subway.Utilities;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
	[StructLayout((LayoutKind)0, Size = 12)]
	private struct FadeEntry
	{
		public int index;

		public string text;

		public float alpha;
	}

	public static TypewriterEffect current;

	public int charsPerSecond;

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

	public bool isActive
	{
		get
		{
			//IL_000a: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<AdType> list = default;
			list._002Ector();
			list.Add(AdType.Video);
			return (byte)(int)list != 0;
		}
	}

	public void ResetToBeginning()
	{
		CancelInvoke();
	}

	public void Finish()
	{
		OnEnable();
		mReset = true;
		mActive = true;
		mNextChar = 0f;
		mCurrentOffset = 0;
		this._002Ector();
	}

	private void OnEnable()
	{
		//IL_01a4: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_006e: Expected I4, but got Obj
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0138: Expected I, but got Obj
		//IL_00db: Expected I, but got Obj
		if (~(mActive ? 1u : 0u) != 0)
		{
			return;
		}
		mActive = false;
		if (~(mReset ? 1u : 0u) != 0)
		{
			string text = mFullText;
			mCurrentOffset = text.m_stringLength;
			BetterList<FadeEntry> betterList = mFade;
			_ = 0;
			mLabel.fontSize = (int)mFullText;
		}
		if (~(keepFullDimensions ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)scrollView).FindKernel((string)null) != 0)
			{
				scrollView.OnScrollBar();
			}
		}
		current = this;
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v8 (Il2CppClass<EventDelegate>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v14 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Localization.dictionary = (Dictionary<string, string[]>)(object)onFinished;
		current = null;
	}

	private void OnDisable()
	{
		mReset = true;
		mActive = true;
	}

	private void Update()
	{
		OnEnable();
	}

	public unsafe TypewriterEffect()
	{
		//IL_1147: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected VT, but got Unknown
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Expected Obj, but got Unknown
		//IL_1163: Expected Obj, but got I4
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Expected Obj, but got Unknown
		//IL_1180: Expected Obj, but got I4
		//IL_118f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Expected Obj, but got Unknown
		//IL_119d: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_01b8: Expected I, but got Obj
		//IL_01ce: Expected Obj, but got I
		//IL_0bcf: Expected I4, but got Obj
		//IL_0be3: Expected I, but got Obj
		//IL_0bf9: Expected Obj, but got I
		//IL_01f9: Expected I, but got Obj
		//IL_0c87: Expected Obj, but got I
		//IL_0c95: Expected Obj, but got I4
		//IL_0caf: Expected I4, but got Obj
		//IL_0caa: Expected native int or pointer, but got VT
		//IL_0cc4: Expected F4, but got I
		//IL_0cbf: Expected native int or pointer, but got VT
		//IL_0cd1: Expected Obj, but got I4
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected Obj, but got Unknown
		//IL_0d1a: Expected Obj, but got F4
		//IL_0d40: Invalid comparison between I and F4
		//IL_0c24: Expected I, but got Obj
		//IL_0ec3: Expected Obj, but got I4
		//IL_0d8b: Expected I4, but got Obj
		//IL_0d86: Expected native int or pointer, but got VT
		//IL_0da0: Expected F4, but got I
		//IL_0d9b: Expected native int or pointer, but got VT
		//IL_0e98: Expected I4, but got Obj
		//IL_0263: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0e56: Expected Obj, but got I4
		//IL_1296: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Expected I4, but got Unknown
		//IL_12aa: Expected I4, but got Obj
		//IL_0ee8: Expected Obj, but got I
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected Obj, but got Unknown
		//IL_0f10: Expected I4, but got Obj
		//IL_0f0b: Expected native int or pointer, but got VT
		//IL_0f25: Expected F4, but got I
		//IL_0f20: Expected native int or pointer, but got VT
		//IL_0f32: Expected Obj, but got I4
		//IL_0e84: Expected I4, but got Obj
		//IL_0947: Expected Obj, but got I4
		//IL_02a4: Expected I, but got Obj
		//IL_1101: Expected Obj, but got I4
		//IL_0fd9: Expected I4, but got Obj
		//IL_0fd4: Expected native int or pointer, but got VT
		//IL_0fee: Expected F4, but got I
		//IL_0fe9: Expected native int or pointer, but got VT
		//IL_0ffc: Expected I, but got Obj
		//IL_1012: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0f71: Expected I4, but got Obj
		//IL_0f6c: Expected native int or pointer, but got VT
		//IL_0f86: Expected F4, but got I
		//IL_0f81: Expected native int or pointer, but got VT
		//IL_10a6: Expected Obj, but got I
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected Obj, but got Unknown
		//IL_103d: Expected I, but got Obj
		//IL_036b: Expected Obj, but got I4
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected Obj, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected I4, but got Unknown
		//IL_0b06: Expected I4, but got Obj
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0b24: Expected I4, but got Obj
		//IL_0b1f: Expected native int or pointer, but got VT
		//IL_0b39: Expected F4, but got I
		//IL_0b34: Expected native int or pointer, but got VT
		//IL_07d4: Expected Obj, but got I4
		//IL_03aa: Expected Obj, but got I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03ec: Expected Obj, but got I4
		//IL_1347: Expected I4, but got Obj
		//IL_09f3: Expected Obj, but got I4
		//IL_07eb: Expected Obj, but got I4
		//IL_0a2e: Expected I, but got Obj
		//IL_0a44: Expected Obj, but got I
		//IL_0a6f: Expected I, but got Obj
		//IL_0800: Expected Obj, but got I4
		//IL_1309: Expected Obj, but got I4
		//IL_083c: Expected Obj, but got I4
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected Obj, but got Unknown
		//IL_0895: Expected Obj, but got I4
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_090f: Expected Obj, but got I4
		object obj = default;
		FadeEntry fadeEntry = (FadeEntry)(obj + 48);
		object obj2 = obj + 36;
		obj2 = 0;
		_ = 0;
		object obj3 = obj + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj + 12;
		obj4 = 0;
		_ = 0;
		if (~(mActive ? 1u : 0u) != 0)
		{
			return;
		}
		if (~(mReset ? 1u : 0u) == 0)
		{
			mCurrentOffset = 0;
			mReset = false;
			object obj5 = this + 40;
			UILabel component = GetComponent<UILabel>();
			obj5 = component;
			object obj6 = this + 44;
			bool isValid = mLabel.isValid;
			obj6 = isValid;
			BetterList<FadeEntry> betterList = mFade;
			_ = 0;
			if (~(keepFullDimensions ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v243 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v249 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)scrollView).FindKernel((string)null) != 0)
				{
					scrollView.OnScrollBar();
				}
			}
		}
		string text = mFullText;
		if (mFullText == null || text.m_stringLength == 0)
		{
			return;
		}
		string text2 = mFullText;
		while (mCurrentOffset < text2.m_stringLength)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			if (mNextChar > unscaledDeltaTime)
			{
				break;
			}
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v169 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v262 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((1 > charsPerSecond) ? 1 : charsPerSecond);
			charsPerSecond = num5;
			UILabel uILabel = mLabel;
			if (~(uILabel.mEncoding ? 1u : 0u) == 0)
			{
				int max;
				do
				{
					nint num6 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S1_v220 (Il2CppClass<NGUIText>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num7 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S1_v226 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					max = this + 48;
				}
				while (NGUITools.RandomRange((int)mFullText, max) != 0);
			}
			int num8 = mCurrentOffset + 1;
			mCurrentOffset = num8;
			if (mCurrentOffset > text2.m_stringLength)
			{
				break;
			}
			float num9 = 1f / (float)charsPerSecond;
			float num10;
			char[] array3;
			if (mCurrentOffset < text2.m_stringLength)
			{
				string[] array = mFullText.Split((char[])mCurrentOffset);
				object obj10 = array & 0xFFFF;
				if ((nint)obj10 != 10)
				{
					object obj11 = mCurrentOffset + 1;
					if ((nint)obj11 != text2.m_stringLength)
					{
						char[] separator = (char[])(mCurrentOffset + 1);
						string[] array2 = mFullText.Split(separator);
						object obj12 = array2 & 0xFFFF;
						bool flag = (nint)obj12 > 32;
						num10 = num9;
						array3 = (char[])mCurrentOffset;
						if (flag)
						{
							goto IL_12bc;
						}
					}
					object obj13 = (object)array << 16;
					object obj14 = obj13 >> 16;
					object obj15 = obj14 - 33;
					if ((nint)obj14 == 33)
					{
						goto IL_07b1;
					}
					if ((nint)obj15 != 1 && (nint)obj15 != 2 && (nint)obj15 != 3 && (nint)obj15 != 4 && (nint)obj15 != 5 && (nint)obj15 != 6 && (nint)obj15 != 7 && (nint)obj15 != 8 && (nint)obj15 != 9 && (nint)obj15 != 10 && (nint)obj15 != 11 && (nint)obj15 != 12)
					{
						if ((nint)obj15 == 13)
						{
							object obj16 = mCurrentOffset + 2;
							if ((nint)obj16 < text2.m_stringLength)
							{
								char[] separator2 = (char[])(mCurrentOffset + 1);
								string[] array4 = mFullText.Split(separator2);
								object obj17 = array4 & 0xFFFF;
								if ((nint)obj17 == 46)
								{
									char[] separator3 = (char[])(mCurrentOffset + 2);
									string[] array5 = mFullText.Split(separator3);
									object obj18 = array5 & 0xFFFF;
									if ((nint)obj18 == 46)
									{
										float num11 = delayOnPeriod * 3f;
										float num12 = num9 + num11;
										char[] array6 = (char[])(mCurrentOffset + 2);
										num10 = num12;
										array3 = array6;
										goto IL_12bc;
									}
								}
							}
							float num13 = num9 + delayOnPeriod;
							num10 = num13;
							array3 = (char[])mCurrentOffset;
							goto IL_12bc;
						}
						if ((nint)obj15 != 14 && (nint)obj15 != 15 && (nint)obj15 != 16 && (nint)obj15 != 17 && (nint)obj15 != 18 && (nint)obj15 != 19 && (nint)obj15 != 20 && (nint)obj15 != 21 && (nint)obj15 != 22 && (nint)obj15 != 23 && (nint)obj15 != 24 && (nint)obj15 != 25 && (nint)obj15 != 26 && (nint)obj15 != 27 && (nint)obj15 != 28 && (nint)obj15 != 29 && (nint)obj15 == 30)
						{
							goto IL_07b1;
						}
					}
					num10 = num9;
					array3 = (char[])mCurrentOffset;
					goto IL_12bc;
				}
			}
			float num14 = num9 + delayOnNewLine;
			num10 = num14;
			array3 = (char[])mCurrentOffset;
			goto IL_12bc;
			IL_07b1:
			float num15 = num9 + delayOnPeriod;
			num10 = num15;
			array3 = (char[])mCurrentOffset;
			goto IL_12bc;
			IL_12bc:
			if (mNextChar == 0f)
			{
				float unscaledDeltaTime2 = Time.unscaledDeltaTime;
				float num16 = unscaledDeltaTime2 + num10;
				mNextChar = num16;
			}
			else
			{
				float num17 = mNextChar + num10;
				mNextChar = num17;
			}
			if (fadeInTime == 0f)
			{
				bool flag2 = keepFullDimensions;
				string text3 = mFullText.InternalSubString(0, mCurrentOffset);
				bool flag3 = !flag2;
				string text4 = text3;
				if (!flag3)
				{
					string provider = mFullText.Trim((char[])mCurrentOffset);
					object obj19 = ((IConvertible)text3).ToType((Type)(object)"[00]", (IFormatProvider)(object)provider);
					text4 = (string)obj19;
				}
				mLabel.fontSize = (int)text4;
				if (~(keepFullDimensions ? 1u : 0u) == 0)
				{
					continue;
				}
				nint num18 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S1_v162 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num19 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ S1_v168 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)scrollView).FindKernel((string)null) != 0)
				{
					scrollView.OnScrollBar();
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				obj2 = array3;
				_ = 0f;
				object obj21 = obj2 + 4;
				int length = mCurrentOffset - array3;
				string text5 = mFullText.InternalSubString((int)array3, length);
				obj21 = text5;
				((FadeEntry*)(nint)fadeEntry)->index = (int)obj2;
				FadeEntry fadeEntry2 = fadeEntry;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((FadeEntry*)(nint)fadeEntry2)->alpha = 0f;
				mFade.Add(fadeEntry);
			}
		}
		if (mCurrentOffset >= text2.m_stringLength)
		{
			BetterList<FadeEntry> betterList2 = mFade;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v146 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
			if ((nint)0 == 0)
			{
				mLabel.fontSize = (int)mFullText;
				current = this;
				nint num20 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S1_v113 (Il2CppClass<EventDelegate>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num21 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v120 (Il2CppClass<EventDelegate>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Localization.dictionary = (Dictionary<string, string[]>)(object)onFinished;
				current = null;
				mActive = false;
				return;
			}
		}
		BetterList<FadeEntry> betterList3 = mFade;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v43 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		int num22 = 0;
		while (true)
		{
			BetterList<FadeEntry> betterList4 = mFade;
			BetterList<FadeEntry> betterList5 = mFade;
			int num23 = num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v21 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
			if ((nint)num23 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v48 (BetterList`1<TypewriterEffect+FadeEntry>)+8]");
			object obj23 = (nint)0 + (nint)16;
			object obj24 = num22 * 12;
			object obj25 = obj23 + obj24;
			((FadeEntry*)(nint)fadeEntry)->index = (int)obj25;
			FadeEntry fadeEntry3 = fadeEntry;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v86+8]");
			((FadeEntry*)(nint)fadeEntry3)->alpha = 0f;
			obj3 = fadeEntry.index;
			_ = fadeEntry.alpha;
			object obj26 = obj3 + 8;
			float fixedDeltaTime = Time.fixedDeltaTime;
			float num24 = fixedDeltaTime / fadeInTime;
			float num25 = (float)obj26 + num24;
			obj26 = num25;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			if (!(0f < 1f))
			{
				mFade.RemoveAt(num22);
				continue;
			}
			((FadeEntry*)(nint)fadeEntry)->index = (int)obj3;
			FadeEntry fadeEntry4 = fadeEntry;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
			((FadeEntry*)(nint)fadeEntry4)->alpha = 0f;
			mFade.set_Item(num22, fadeEntry);
			int num26 = num22 + 1;
			num22 = num26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v48 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
		if ((nint)0 == 0)
		{
			bool flag4 = keepFullDimensions;
			string text6 = mFullText.InternalSubString(0, mCurrentOffset);
			if (flag4)
			{
				string provider2 = mFullText.Trim((char[])mCurrentOffset);
				object obj27 = ((IConvertible)text6).ToType((Type)(object)"[00]", (IFormatProvider)(object)provider2);
				mLabel.fontSize = (int)obj27;
			}
			else
			{
				mLabel.fontSize = (int)text6;
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj28 = 0;
		while (true)
		{
			BetterList<FadeEntry> betterList6 = mFade;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S1_v26 (BetterList`1<TypewriterEffect+FadeEntry>)+C]");
			if ((nint)obj29 >= 0)
			{
				break;
			}
			BetterList<FadeEntry> betterList7 = mFade;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S1_v37 (BetterList`1<TypewriterEffect+FadeEntry>)+8]");
			object obj30 = (nint)0 + (nint)16;
			object obj31 = obj28 * 12;
			object obj32 = obj30 + obj31;
			((FadeEntry*)(nint)fadeEntry)->index = (int)obj32;
			FadeEntry fadeEntry5 = fadeEntry;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S1_v40+8]");
			((FadeEntry*)(nint)fadeEntry5)->alpha = 0f;
			obj4 = fadeEntry.index;
			_ = fadeEntry.alpha;
			if (obj28 == null)
			{
				((FadeEntry*)(nint)fadeEntry)->index = (int)obj4;
				FadeEntry fadeEntry6 = fadeEntry;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
				((FadeEntry*)(nint)fadeEntry6)->alpha = 0f;
				string value = mFullText.InternalSubString(0, fadeEntry.index);
				StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
			}
			StringBuilder stringBuilder3 = stringBuilder.Append(91);
			((FadeEntry*)(nint)fadeEntry)->index = (int)obj4;
			FadeEntry fadeEntry7 = fadeEntry;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
			((FadeEntry*)(nint)fadeEntry7)->alpha = 0f;
			nint num27 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v86 (Il2CppClass<NGUIText>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num28 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S0_v100 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EnvironmentKind environmentKindAt = DebugQueuedEnvironments.GetEnvironmentKindAt(fadeEntry.alpha);
			StringBuilder stringBuilder4 = stringBuilder.AppendLine((string)(object)environmentKindAt);
			StringBuilder stringBuilder5 = stringBuilder.Append(93);
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			StringBuilder stringBuilder6 = stringBuilder.AppendLine((string)0);
			object obj34 = obj28 + 1;
			obj28 = obj34;
		}
		if (~(keepFullDimensions ? 1u : 0u) == 0)
		{
			StringBuilder stringBuilder7 = stringBuilder.AppendLine("[00]");
			string value2 = mFullText.Trim((char[])mCurrentOffset);
			StringBuilder stringBuilder8 = stringBuilder.AppendLine(value2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int fontSize = default;
		mLabel.fontSize = fontSize;
	}
}
