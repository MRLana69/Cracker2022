using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class BMGlyph
{
	public int index = 16;

	public int x;

	public int y;

	public int width;

	public int height;

	public int offsetX;

	public int offsetY;

	public int advance;

	public int channel;

	public List<int> kerning;

	public int GetKerning(int previousChar)
	{
		//IL_0013: Expected I4, but got Obj
		return (int)ByteReader.ReadLine((byte[])(object)this, previousChar, 0);
	}

	public void SetKerning(int previousChar, int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0cfc: Expected I, but got Obj
		//IL_0d12: Expected Obj, but got I
		//IL_0d96: Expected Obj, but got I4
		//IL_0a7e: Expected I, but got Obj
		//IL_0a94: Expected Obj, but got I
		//IL_0067: Expected I, but got Obj
		//IL_0c52: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_0abf: Expected I, but got Obj
		//IL_0c7e: Expected Obj, but got I4
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Expected Obj, but got Unknown
		//IL_0ca6: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0ce9: Expected I4, but got Obj
		//IL_0ce9: Expected Obj, but got I4
		//IL_0bf5: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_0b53: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I4
		//IL_0326: Expected I, but got Obj
		//IL_0d85: Expected Obj, but got I4
		//IL_09c6: Expected Obj, but got I
		//IL_0411: Invalid comparison between Obj and F4
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected Obj, but got Unknown
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Expected Obj, but got Unknown
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		int num = default;
		int num2 = default;
		if (num == 0)
		{
			num2 = ((offsetX != 1) ? 1 : (-1));
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v214 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)height).FindKernel(null) != 0)
		{
			((Component)this).tag = (string)1;
			((Component)height).tag = null;
			bool flag;
			if (previousChar != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousChar @ L1 (System.Int32)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				if (!((Animation)height).Play())
				{
					IEnumerator enumerator = ((Animation)height).GetEnumerator();
				}
			}
			else
			{
				AnimationState animationState = ((Animation)height).get_Item((string)previousChar);
				if ((object)animationState == null)
				{
					AnimationState animationState2 = ((Animation)height).CrossFadeQueued((string)previousChar);
				}
			}
			int stateCount = ((Animation)height).GetStateCount();
			object obj4 = default;
			object obj5 = default;
			float value = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj4 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				bool flag2;
				if (previousChar != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previousChar @ L1 (System.Int32)+8]");
					flag2 = (nint)0 == 0;
				}
				else
				{
					flag2 = true;
				}
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj5 == null)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S0_v136 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v172 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				float num7 = Math.Abs(value);
				float num8 = num7 * (float)num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
				object obj7 = num2 - -1;
				if (num2 != -1)
				{
					if ((nint)obj7 != 1 && (nint)obj7 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						if (obj8 == obj9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					if (obj10 == (object)0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
					}
				}
			}
			object obj11 = 49;
			object obj12 = obj11 - 18;
			if ((nint)obj11 != 18)
			{
				if ((nint)obj12 != 1 && (nint)obj12 != 2 && (nint)obj12 != 3)
				{
					if ((nint)obj12 == 4 || (nint)obj12 == 5)
					{
						goto IL_090f;
					}
					if ((nint)obj12 != 6 && (nint)obj12 != 7 && (nint)obj12 != 8 && (nint)obj12 != 9)
					{
						if ((nint)obj12 == 10)
						{
							goto IL_090f;
						}
						if ((nint)obj12 != 11 && (nint)obj12 != 12)
						{
							if ((nint)obj12 == 13)
							{
								goto IL_090f;
							}
							if ((nint)obj12 != 14 && (nint)obj12 != 15)
							{
								if ((nint)obj12 == 16)
								{
									goto IL_090f;
								}
								if ((nint)obj12 != 17 && (nint)obj12 != 18)
								{
									if ((nint)obj12 == 19)
									{
										goto IL_090f;
									}
									if ((nint)obj12 != 20 && (nint)obj12 != 21 && (nint)obj12 != 22)
									{
										if ((nint)obj12 == 23 || (nint)obj12 == 24)
										{
											goto IL_090f;
										}
										if ((nint)obj12 != 25 && (nint)obj12 != 26 && (nint)obj12 != 27 && (nint)obj12 != 28)
										{
											if ((nint)obj12 == 29 || (nint)obj12 == 30)
											{
												goto IL_090f;
											}
											if ((nint)obj12 == 31)
											{
												object obj13 = obj2 + 4;
												object obj14 = obj13 + 1;
												obj13 = obj14;
												object obj15 = obj14 << 2;
												object obj16 = obj2 + obj15;
												obj16 = 273;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_0d3e;
			}
			goto IL_090f;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)channel).FindKernel(null) != 0)
		{
			if (((Behaviour)this).isActiveAndEnabled && ((BMFont)this).isValid && (string)(object)kerning != (string)previousChar)
			{
				offsetX = num2;
				return;
			}
			((Component)this).tag = (string)1;
			advance = 1;
			offsetX = num2;
			object obj18 = this + 44;
			obj18 = previousChar;
			float normalizedTime = ((num2 != 1) ? 1f : 0f);
			((Animator)channel).Play((int)kerning, 0, normalizedTime);
		}
		return;
		IL_0d65:
		offsetX = num2;
		advance = 1;
		Animation.INTERNAL_CALL_Sample((Animation)height);
		return;
		IL_0d3e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj2 + obj20;
			if ((nint)obj21 == 273)
			{
				object obj22 = obj2 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0d65;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0d65;
		IL_090f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj25 = default;
		object obj26 = default;
		if (obj25 == obj26)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0d3e;
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
		//IL_002c: Expected Obj, but got I4
		//IL_0062: Expected VT, but got I4
		if (((BMFont)this).charSize == 0)
		{
			return;
		}
		int num = offsetX;
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11 (System.Int32)+C]");
			if ((nint)num3 < (nint)0)
			{
				BMGlyph bMGlyph = ((List<BMGlyph>)offsetX).get_Item(num2);
				if (bMGlyph != null)
				{
					Rect rect = NGUIMath.ConvertToPixels((Rect)xMin, yMin, xMax, (byte)yMax != 0);
				}
				int num4 = num2 + 1;
				num2 = num4;
				continue;
			}
			break;
		}
	}

	public BMGlyph()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 28;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S3_v3+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S4_v4 (should have been resolved before IL gen)");
		object obj8 = this + 32;
		object obj9 = default;
		obj8 = obj9;
	}
}
