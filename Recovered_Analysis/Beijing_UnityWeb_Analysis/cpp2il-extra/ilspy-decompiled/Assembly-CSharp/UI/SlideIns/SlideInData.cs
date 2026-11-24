using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Kiloo;
using Kiloo.Common.Extensions;
using UI.VideoAdPrizes;
using UnityEngine;

namespace UI.SlideIns;

public class SlideInData : ScriptableObject
{
	public enum SlideInType
	{
		TopRunTimer,
		Mission,
		MissionSet,
		Letters,
		LettersCompleteMysteryBox,
		LettersCompleteCoins,
		Unlock,
		ErrorMessage,
		WeeklyHunt,
		OfferWall,
		VideoPayout,
		Brag,
		Awards,
		Facebook,
		CharacterEventWord,
		CharacterEventWordReward,
		RemoveAds,
		Gift,
		FirstPurchaseBonus,
		CloudSave,
		CloudSaveMessage
	}

	private List<UISlideIn> _slideInPrefabs;

	private AudioClipInfo _slideInSound;

	private AudioClipInfo _slideInFanfare;

	private static SlideInData _instance;

	public static SlideInData instance
	{
		get
		{
			if (VideoAdPrizeManager._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				VideoAdPrizeManager videoAdPrizeManager = default;
				videoAdPrizeManager.SetVideoAdPrizeIndexes();
				VideoAdPrizeManager._instance = videoAdPrizeManager;
			}
			return (SlideInData)(object)VideoAdPrizeManager._instance;
		}
	}

	public T InstantiateSlideIn<T>(Transform parent) where T : UISlideIn
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02dd: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = default;
		object obj3 = num + 24;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v8+4]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S2_v4 (should have been resolved before IL gen)");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj10 = default;
		object obj12 = default;
		object obj17 = default;
		object obj18 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj10 != null)
			{
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj15;
				if (obj12 == parent)
				{
					object obj13 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v93+14]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj15 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					obj15 = 0;
				}
				object obj16 = obj15 & 1;
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					if (obj17 == obj18)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					}
					break;
				}
				continue;
			}
			object obj19 = obj2 + 4;
			object obj20 = obj19 + 1;
			obj19 = obj20;
			object obj21 = obj20 << 2;
			object obj22 = obj2 + obj21;
			obj22 = 76;
			break;
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj24 = (nint)0 << 2;
			object obj25 = obj2 + obj24;
			if ((nint)obj25 == 76)
			{
				object obj26 = obj2 + 4;
				if ((nint)obj26 > -1)
				{
					object obj27 = obj26 + -1;
					obj26 = obj27;
				}
				goto IL_037f;
			}
		}
		object obj28 = default;
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_037f;
		IL_037f:
		T result = default;
		return result;
	}

	public AudioClipInfo GetSlideInSound(SlideIn slideIn)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_0288: Expected I4, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<VideoAdPrize> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 60)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_027b;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_027b;
		IL_027b:
		Kiloo.Common.Extensions.CollectionExtensions.Shuffle(list, (int)slideIn);
		return (AudioClipInfo)(object)list;
	}

	private void OnValidate()
	{
	}

	private unsafe T GetPrefab<T>() where T : UISlideIn
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Ref, but got Unknown
		//IL_0086: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected I, but got Unknown
		//IL_00f2: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = default;
		ref object reference = ref *(object*)(obj + 4);
		reference = ref *(object*)null;
		nint num = default;
		object obj2 = num + 24;
		object obj3 = obj2;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<System.Type>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v24 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = obj3;
		nint num4 = (nint)(obj + 8);
		((IntPtr*)num4)->m_value = (void*)(nint)obj;
		Type key = Type.internal_from_handle((IntPtr)num4);
		bool flag = ((Dictionary<Type, object>)(nint)((UnityEngine.Object)this).m_CachedPtr).TryGetValue(key, out reference);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		T result = default;
		return result;
	}

	public SlideInData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c1: Expected Obj, but got I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_034f: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0139: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v74 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v100 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 == null)
			{
				continue;
			}
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v83 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v93 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj9 = obj4 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj4 + obj11;
		obj12 = 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj4 + obj13;
			if ((nint)obj14 == 64)
			{
				object obj15 = obj4 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				return;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	unsafe static SlideInData()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got VT
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected I4, but got Unknown
		//IL_00bf: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v20 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = today;
		bool flag = (byte)(obj2 + 8) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
		UserSave.cloudSaveEnabled = flag;
	}
}
