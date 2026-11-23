using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class UISliderColors : MonoBehaviour
{
	public Image sprite;

	public Color[] colors;

	private UIProgressBar mBar;

	private UIBasicSprite mSprite;

	private void Start()
	{
		UIProgressBar component = GetComponent<UIProgressBar>();
		mBar = component;
		UIBasicSprite component2 = GetComponent<UIBasicSprite>();
		mSprite = component2;
		Update();
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I4
		//IL_00b0: Expected F8, but got I4
		//IL_0350: Invalid comparison between F8 and I4
		//IL_02b1: Expected F4, but got I
		//IL_02c1: Expected F4, but got I
		//IL_02d1: Expected F4, but got I
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_0488: Expected I, but got Obj
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_04d9: Expected Obj, but got I
		//IL_00d9: Invalid comparison between I4 and F8
		//IL_01c0: Expected Obj, but got F8
		//IL_0207: Expected Obj, but got F8
		//IL_024d: Expected Obj, but got I
		//IL_03a7: Expected Obj, but got I
		//IL_03ea: Expected Obj, but got I
		//IL_010f: Invalid comparison between I4 and F8
		//IL_0178: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got F8
		object obj2 = default;
		object obj = obj2 + -64;
		if (!(sprite != null))
		{
			return;
		}
		Color[] array = colors;
		if (array.Length == 0)
		{
			return;
		}
		float num;
		if (mBar != null)
		{
			num = mBar.value;
		}
		else
		{
			UIBasicSprite uIBasicSprite = mSprite;
			num = uIBasicSprite.mFillAmount;
		}
		Color[] array2 = colors;
		object obj3 = array2.Length - 1;
		float num2 = num * (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num3 = Math.Abs((double)num2);
		double num4 = ((!(num3 < 2147483648.0)) ? (-2147483648.0) : ((double)num2));
		Color[] array3 = colors;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v15 (UnityEngine.Color[])+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v15 (UnityEngine.Color[])+10]");
		_ = 0;
		float num18;
		float num19;
		float num20;
		if (!(num4 < 0.0))
		{
			Color[] array4 = colors;
			double num5 = num4 + 1.0;
			if ((double)array4.Length > num5)
			{
				object obj4 = num4 << 4;
				object obj5 = (object)colors + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v38+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v38+10]");
				_ = 0;
				double num6 = num4 + 1.0;
				object obj6 = num6 << 4;
				object obj7 = (object)colors + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v44+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v44+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				object obj8 = num7 - 0;
				float num8 = num2 - (float)num4;
				float num9 = Math.Min(num8, 1f);
				bool flag = num8 < 0f;
				float num10 = 0f;
				if (!flag)
				{
					num10 = num9;
				}
				float num11 = (float)obj8 * num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				float num12 = 0f + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				object obj9 = num13 - 0;
				float num14 = (float)obj9 * num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				float num15 = 0f + num14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				object obj10 = num16 - 0;
				float num17 = (float)obj10 * num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				num18 = 0f + num17;
				num19 = num15;
				num20 = num12;
				goto IL_0468;
			}
			Color[] array5 = colors;
			if ((double)array5.Length > num4)
			{
				object obj11 = num4 << 4;
				object obj12 = (object)array5 + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v71+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v71+10]");
				_ = 0;
			}
			else
			{
				object obj13 = array5.Length - 1;
				object obj14 = obj13 << 4;
				object obj15 = (object)array5 + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S1_v66+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S1_v66+10]");
				_ = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
		num18 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		num19 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		num20 = 0f;
		goto IL_0468;
		IL_0468:
		object obj16 = obj + 48;
		Image image = sprite;
		nint num21 = (nint)image;
		object obj17 = image + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ S2_v7 (Il2CppClass<UnityEngine.UI.Image>)+16C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
	}

	public UISliderColors()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I8
		object obj2 = default;
		object obj = obj2 - 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 1065353216;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		_ = 4575657222423478401L;
		_ = 4575657222423478401L;
		_ = 4570005646807662592L;
		_ = 4570005646807662592L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		obj = 4575657221408423936L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Color[] array = default;
		colors = array;
		base._002Ector();
	}
}
