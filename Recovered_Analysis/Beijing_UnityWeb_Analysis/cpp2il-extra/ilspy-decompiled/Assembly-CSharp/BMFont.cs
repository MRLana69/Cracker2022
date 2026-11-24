using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationOrTween;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using SYBO.Subway.Info;
using UI.Screens.BoardScreenInternal;
using UI.VideoAdPrizes;
using UnityEngine;

[Serializable]
public class BMFont
{
	private int mSize;

	private int mBase;

	private int mWidth;

	private int mHeight;

	private string mSpriteName;

	private List<BMGlyph> mSaved;

	private Dictionary<int, BMGlyph> mDict;

	public bool isValid
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_09cb: Expected I, but got Obj
			//IL_09e1: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0a10: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_01f4: Expected Obj, but got I4
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Expected Obj, but got Unknown
			//IL_0389: Invalid comparison between Obj and F4
			//IL_035e: Expected Obj, but got I4
			//IL_087e: Expected Obj, but got I
			//IL_03b1: Expected Obj, but got I4
			//IL_091a: Expected Obj, but got I
			//IL_031e: Expected Obj, but got I4
			//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c1: Expected Obj, but got Unknown
			//IL_0958: Unknown result type (might be due to invalid IL or missing references)
			//IL_095d: Expected Obj, but got Unknown
			//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f7: Expected Obj, but got Unknown
			//IL_098e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0993: Expected Obj, but got Unknown
			//IL_0669: Unknown result type (might be due to invalid IL or missing references)
			//IL_066e: Expected Obj, but got Unknown
			//IL_0677: Unknown result type (might be due to invalid IL or missing references)
			//IL_067c: Expected Obj, but got Unknown
			//IL_06a8: Expected Obj, but got I4
			//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c9: Expected Obj, but got Unknown
			//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d7: Expected Obj, but got Unknown
			//IL_0703: Expected Obj, but got I4
			//IL_071a: Unknown result type (might be due to invalid IL or missing references)
			//IL_071f: Expected Obj, but got Unknown
			//IL_0728: Unknown result type (might be due to invalid IL or missing references)
			//IL_072d: Expected Obj, but got Unknown
			//IL_0759: Expected Obj, but got I4
			//IL_0775: Unknown result type (might be due to invalid IL or missing references)
			//IL_077a: Expected Obj, but got Unknown
			//IL_0783: Unknown result type (might be due to invalid IL or missing references)
			//IL_0788: Expected Obj, but got Unknown
			//IL_07b4: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v182 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)mSpriteName != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v102 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v114 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BMFont)+28]");
				bool result;
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					bool flag = (nint)mSaved == -1;
					float fillAmount = ((UIBasicSprite)this).fillAmount;
					if (flag)
					{
						if (fillAmount == 0f)
						{
							return false;
						}
					}
					else if (fillAmount == 1f)
					{
						return false;
					}
					result = true;
				}
				else
				{
					result = false;
				}
				return result;
			}
			int stateCount = ((Animation)(object)mSpriteName).GetStateCount();
			object obj5 = default;
			object obj6;
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj5 == null)
				{
					obj6 = 43;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj7 == null)
				{
					continue;
				}
				if ((nint)mSaved == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
					{
						obj6 = 31;
						break;
					}
					continue;
				}
				if ((nint)mSaved != -1)
				{
					obj6 = 37;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
				{
					continue;
				}
				obj6 = 36;
				break;
			}
			object obj11 = obj6 - 22;
			bool result2 = default;
			if ((nint)obj6 != 22 && (nint)obj11 != 1 && (nint)obj11 != 2)
			{
				if ((nint)obj11 != 3 && (nint)obj11 != 4 && (nint)obj11 != 5 && (nint)obj11 != 6)
				{
					if ((nint)obj11 == 7 || (nint)obj11 == 8)
					{
						goto IL_07b9;
					}
					if ((nint)obj11 != 9)
					{
						if ((nint)obj11 != 10 && (nint)obj11 != 11 && (nint)obj11 != 12)
						{
							if ((nint)obj11 == 13)
							{
								goto IL_07b9;
							}
							if ((nint)obj11 != 14)
							{
								if ((nint)obj11 != 15)
								{
									if ((nint)obj11 != 16 && (nint)obj11 != 17)
									{
										if ((nint)obj11 == 18)
										{
											goto IL_07b9;
										}
										if ((nint)obj11 != 19 && (nint)obj11 != 20 && (nint)obj11 == 21)
										{
											object obj12 = obj2 + 4;
											object obj13 = obj12 + 1;
											obj12 = obj13;
											object obj14 = obj13 << 2;
											object obj15 = obj2 + obj14;
											obj15 = 200;
										}
									}
								}
								else
								{
									object obj16 = obj2 + 4;
									object obj17 = obj16 + 1;
									obj16 = obj17;
									object obj18 = obj17 << 2;
									object obj19 = obj2 + obj18;
									obj19 = 202;
									result2 = true;
								}
							}
							else
							{
								object obj20 = obj2 + 4;
								object obj21 = obj20 + 1;
								obj20 = obj21;
								object obj22 = obj21 << 2;
								object obj23 = obj2 + obj22;
								obj23 = 202;
								result2 = true;
							}
						}
					}
					else
					{
						object obj24 = obj2 + 4;
						object obj25 = obj24 + 1;
						obj24 = obj25;
						object obj26 = obj25 << 2;
						object obj27 = obj2 + obj26;
						obj27 = 202;
						result2 = true;
					}
				}
				goto IL_0a4e;
			}
			goto IL_07b9;
			IL_0a31:
			bool result3 = default;
			return result3;
			IL_0a4e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj28 = default;
			if (obj28 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj29 = (nint)0 << 2;
				object obj30 = obj2 + obj29;
				if ((nint)obj30 == 202)
				{
					object obj31 = obj2 + 4;
					if ((nint)obj31 > -1)
					{
						object obj32 = obj31 + -1;
						obj31 = obj32;
					}
					return result2;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj33 = (nint)0 << 2;
				object obj34 = obj2 + obj33;
				if ((nint)obj34 == 200)
				{
					object obj35 = obj2 + 4;
					if ((nint)obj35 > -1)
					{
						object obj36 = obj35 + -1;
						obj35 = obj36;
					}
					goto IL_0a31;
				}
			}
			object obj37 = default;
			if (obj37 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0a31;
			IL_07b9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj38 = default;
			object obj39 = default;
			if (obj38 == obj39)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			goto IL_0a4e;
		}
	}

	public int charSize
	{
		get
		{
			List<BMGlyph> list = mSaved;
			return (list._size > 0) ? 1 : 0;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public int baseOffset
	{
		get
		{
			return mSize;
		}
		set
		{
			mSize = value;
		}
	}

	public int texWidth
	{
		get
		{
			return mBase;
		}
		set
		{
			mBase = value;
		}
	}

	public int texHeight
	{
		get
		{
			return mWidth;
		}
		set
		{
			mWidth = value;
		}
	}

	public int glyphCount => mHeight;

	public string spriteName
	{
		get
		{
			//IL_001c: Expected Obj, but got I4
			if (charSize != 0)
			{
				List<BMGlyph> list = mSaved;
				return (string)list._size;
			}
			return null;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			mHeight = (int)value;
		}
	}

	public List<BMGlyph> glyphs => (List<BMGlyph>)(object)mSpriteName;

	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		//IL_0018: Expected Obj, but got I4
		return (BMGlyph)(object)ActiveAnimation.Play((Animator)(object)this, (string)index, createIfMissing ? Direction.Forward : Direction.Toggle, EnableCondition.DoNothing, DisableCondition.DoNotDisable);
	}

	public BMGlyph GetGlyph(int index)
	{
		return (BMGlyph)(object)ActiveAnimation.Play((Animator)(object)this, null, (Direction)index, EnableCondition.DoNothing, DisableCondition.DoNotDisable);
	}

	public void Clear()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj = this + 12;
		obj = list;
		object obj2 = this + 44;
		obj2 = "";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
		//IL_0101: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		bool enableNewBuble;
		bool enableGiftBuble;
		if (!CharacterStickerManager.IsThemeUnlockedForCharacter((Characters.CharacterId)xMax, yMax))
		{
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v19 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v33 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.lastPurchasedBundle == InAppData.BundleTier.None)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [yMin @ L2 (System.Int32)+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [yMin @ L2 (System.Int32)+1C]");
					if ((nint)0 != 0)
					{
						enableNewBuble = true;
						enableGiftBuble = false;
						goto IL_01da;
					}
				}
			}
		}
		string titleForVideoAdPrize = ((CoinEarnerVideoAds)xMax).GetTitleForVideoAdPrize((VideoAdPrizeType)yMax);
		if (titleForVideoAdPrize != null)
		{
			enableNewBuble = false;
			enableGiftBuble = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [yMin @ L2 (System.Int32)+1C]");
			if ((nint)0 != 0)
			{
				enableNewBuble = false;
				enableGiftBuble = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BMFont)+2C]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [xMin @ L1 (System.Int32)+20]");
				enableGiftBuble = num3 != 0;
				enableNewBuble = false;
			}
		}
		goto IL_01da;
		IL_01da:
		((HoverboardThemeButton)xMin).SetActiveBubbles(enableGiftBuble, enableNewBuble);
	}

	public BMFont()
	{
		((Dictionary<TKey, TValue>)(object)mDict).Resize();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}
}
