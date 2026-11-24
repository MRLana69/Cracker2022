using System;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Ads;

public class AdEventListenerAdapter : IAdEventListener
{
	public unsafe virtual void WillShowAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_15b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b7: Expected Obj, but got Unknown
		//IL_15c0: Expected Obj, but got I4
		//IL_15d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15da: Expected Obj, but got Unknown
		//IL_15e3: Expected Obj, but got I4
		//IL_15ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f1: Expected Obj, but got Unknown
		//IL_161f: Expected Obj, but got I
		//IL_162f: Expected Obj, but got I
		//IL_1640: Unknown result type (might be due to invalid IL or missing references)
		//IL_1645: Expected Obj, but got Unknown
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1653: Expected Obj, but got Unknown
		//IL_1663: Unknown result type (might be due to invalid IL or missing references)
		//IL_1668: Expected Obj, but got Unknown
		//IL_167e: Expected I, but got Obj
		//IL_1694: Expected Obj, but got I
		//IL_16ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bf: Expected Obj, but got Unknown
		//IL_16c8: Expected Obj, but got VT
		//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d6: Expected Obj, but got Unknown
		//IL_16ec: Expected Obj, but got VT
		//IL_1712: Unknown result type (might be due to invalid IL or missing references)
		//IL_1717: Expected Obj, but got Unknown
		//IL_1725: Unknown result type (might be due to invalid IL or missing references)
		//IL_172a: Expected Obj, but got Unknown
		//IL_1732: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0171: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_1778: Unknown result type (might be due to invalid IL or missing references)
		//IL_177d: Expected Obj, but got Unknown
		//IL_1786: Unknown result type (might be due to invalid IL or missing references)
		//IL_178b: Expected Obj, but got Unknown
		//IL_1794: Expected Obj, but got I4
		//IL_17c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ce: Expected Obj, but got Unknown
		//IL_17d7: Expected Obj, but got I4
		//IL_0307: Expected I, but got Obj
		//IL_0394: Expected Obj, but got I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected Obj, but got Unknown
		//IL_0470: Expected Obj, but got I4
		//IL_0be3: Expected Obj, but got I
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected Obj, but got Unknown
		//IL_05ef: Expected Obj, but got I
		//IL_0ccc: Expected Obj, but got I4
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected Obj, but got Unknown
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Obj, but got Unknown
		//IL_0deb: Expected Obj, but got I
		//IL_14f4: Expected Obj, but got I
		//IL_152a: Unknown result type (might be due to invalid IL or missing references)
		//IL_152f: Expected Obj, but got Unknown
		//IL_1560: Unknown result type (might be due to invalid IL or missing references)
		//IL_1565: Expected Obj, but got Unknown
		//IL_0e92: Expected I, but got Obj
		//IL_0ea8: Expected Obj, but got I
		//IL_1836: Expected Obj, but got I4
		//IL_0ed3: Expected I, but got Obj
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Expected Obj, but got Unknown
		//IL_0aee: Expected Obj, but got I4
		//IL_0af7: Expected Obj, but got I4
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_1406: Expected Obj, but got Unknown
		//IL_140f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1414: Expected Obj, but got Unknown
		//IL_1440: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 56;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S4_v4 (should have been resolved before IL gen)");
		object obj11 = this + 16;
		object obj12 = default;
		obj11 = obj12;
		nint num2 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v26 (Il2CppClass<System.DateTime>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v459 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj14 = obj2 + 8;
		obj14 = DateTime.MinValue;
		object obj15 = obj2 + 24;
		obj15 = obj14;
		obj2 = DateTime.MinValue;
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<IAdEventListener> list = default;
		list._002Ector();
		object obj16 = this + 44;
		obj16 = list;
		object obj17 = this + 8;
		obj17 = adType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AdLocation> list2 = default;
		int capacity = default;
		list2._002Ector(capacity);
		object obj18 = this + 12;
		obj18 = list2;
		nint num4 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v53 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v455 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue("video_ads_cache_pool_size", 2u);
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		uint value2 = ((OnlineSettings)(object)saveDataPath2).GetValue("interstitial_ads_cache_pool_size", 1u);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S3_v9 (Il2CppMethodInfo)+C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S3_v10+60]");
		object obj21 = 0;
		nint num7 = (nint)obj21;
		object obj22 = num7 & 0x1FFF;
		object obj23 = obj22 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v194 @ S4_v8 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdController.CacheList cacheList = default;
		cacheList.Add((AdLocation)value);
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S4_v10 (Il2CppMethodInfo)+C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S4_v11+60]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S4_v12+48]");
		object obj26 = 0;
		object obj27 = obj26 & 0x7FF;
		object obj28 = obj27 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v217 @ S5_v8 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdController.CacheList cacheList2 = default;
		cacheList2.Add((AdLocation)value2);
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S4_v15 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S4_v16+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S4_v17+48]");
		AdType adType2 = AdType.Interstitial;
		int num10 = ((AdType*)(int)adType2)->value__ & 0x7FF;
		object obj31 = num10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v775 @ S5_v18 (should have been resolved before IL gen)");
		object obj32 = this + 48;
		object obj33 = default;
		obj32 = obj33;
		object obj34 = this + 40;
		obj34 = adLocationID;
		_ = 1;
		nint num11 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v82 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num12 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v451 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj36 = obj2 + 52;
		object obj37 = obj2 + 48;
		AbstractAdProvider.MapAbstractAdProviders((IAdSettingsProvider)adType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&AbstractAdProvider.HandleAdConstantsChanged);
		object obj38 = action + 16;
		obj38 = 0;
		AdConstants.constantsChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj39 = default;
		object obj40 = default;
		object obj41 = default;
		object obj42 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj39 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj40 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				obj31 = 0;
				adType2 = AdType.Interstitial;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ S0_v400+C]");
			if ((nint)obj42 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ S0_v366+24]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ S0_v417+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			adType2 = AdType.Interstitial;
		}
		object obj44 = 50;
		object obj45 = obj44 - 16;
		object obj50;
		if ((nint)obj44 != 16 && (nint)obj45 != 1)
		{
			if ((nint)obj45 != 2 && (nint)obj45 != 3)
			{
				if ((nint)obj45 == 4)
				{
					goto IL_0b01;
				}
				if ((nint)obj45 != 5 && (nint)obj45 != 6 && (nint)obj45 != 7 && (nint)obj45 != 8 && (nint)obj45 != 9 && (nint)obj45 != 10 && (nint)obj45 != 11 && (nint)obj45 != 12 && (nint)obj45 != 13 && (nint)obj45 != 14 && (nint)obj45 != 15)
				{
					if ((nint)obj45 == 16 || (nint)obj45 == 17 || (nint)obj45 == 18 || (nint)obj45 == 19 || (nint)obj45 == 20 || (nint)obj45 == 21 || (nint)obj45 == 22 || (nint)obj45 == 23 || (nint)obj45 == 24)
					{
						goto IL_0b01;
					}
					if ((nint)obj45 != 25 && (nint)obj45 != 26 && (nint)obj45 != 27 && (nint)obj45 != 28 && (nint)obj45 != 29 && (nint)obj45 != 30)
					{
						if ((nint)obj45 == 31 || (nint)obj45 == 32 || (nint)obj45 == 33)
						{
							goto IL_0b01;
						}
						if ((nint)obj45 == 34)
						{
							object obj46 = obj5 + 4;
							object obj47 = obj46 + 1;
							obj46 = obj47;
							object obj48 = obj47 << 2;
							object obj49 = obj5 + obj48;
							obj49 = 403;
							obj50 = 0;
							goto IL_0b7c;
						}
					}
				}
			}
			goto IL_159e;
		}
		goto IL_0b01;
		IL_18c9:
		string info = ((AdController)this).GetInfo();
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)info);
		return;
		IL_159e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return;
		IL_1889:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v33+10]");
		_ = 0;
		object obj51 = default;
		object obj52 = default;
		object obj53 = default;
		object obj54 = default;
		AdType adType4 = default;
		AdType adType3;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj51 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ S1_v138+C]");
			if ((nint)obj52 >= 0)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj15 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ S0_v238+C]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj37 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			nint num13 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ S0_v277 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj55 = (nint)0 & (nint)0x200;
			if (obj55 != null)
			{
				nint num14 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ S0_v286 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			adType3 = adType4;
			obj31 = 0;
		}
		object obj56 = 99;
		object obj57 = obj56 - 66;
		AdType adType5;
		object obj58;
		object obj59 = default;
		object obj64 = default;
		if ((nint)obj56 != 66 && (nint)obj57 != 1 && (nint)obj57 != 2 && (nint)obj57 != 3)
		{
			if ((nint)obj57 == 4 || (nint)obj57 == 5 || (nint)obj57 == 6 || (nint)obj57 == 7 || (nint)obj57 == 8 || (nint)obj57 == 9 || (nint)obj57 == 10 || (nint)obj57 == 11 || (nint)obj57 == 12 || (nint)obj57 == 13 || (nint)obj57 == 14 || (nint)obj57 == 15)
			{
				goto IL_14b9;
			}
			if ((nint)obj57 != 16)
			{
				if ((nint)obj57 != 17)
				{
					if ((nint)obj57 != 18)
					{
						if ((nint)obj57 != 19)
						{
							if ((nint)obj57 != 20)
							{
								if ((nint)obj57 != 21)
								{
									if ((nint)obj57 != 22 && (nint)obj57 != 23)
									{
										if ((nint)obj57 != 24 && (nint)obj57 != 25 && (nint)obj57 != 26 && (nint)obj57 != 27 && (nint)obj57 != 28 && (nint)obj57 != 29 && (nint)obj57 != 30 && (nint)obj57 != 31)
										{
											if ((nint)obj57 == 32)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												AdType adType6 = default;
												adType5 = adType6;
												obj58 = obj59;
												goto IL_1841;
											}
											if ((nint)obj57 == 33)
											{
												object obj60 = obj5 + 4;
												object obj61 = obj60 + 1;
												obj60 = obj61;
												object obj62 = obj61 << 2;
												object obj63 = obj5 + obj62;
												obj63 = 539;
												obj64 = obj50;
											}
										}
										goto IL_14b9;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									AdType adType7 = default;
									adType5 = adType7;
									obj58 = obj59;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									AdType adType8 = default;
									adType5 = adType8;
									obj58 = obj59;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								AdType adType9 = default;
								adType5 = adType9;
								obj58 = obj59;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							AdType adType10 = default;
							adType5 = adType10;
							obj58 = obj59;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						AdType adType11 = default;
						adType5 = adType11;
						obj58 = obj59;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					AdType adType12 = default;
					adType5 = adType12;
					obj58 = obj59;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				AdType adType13 = default;
				adType5 = adType13;
				obj58 = obj59;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			AdType adType14 = default;
			adType5 = adType14;
			obj58 = obj59;
		}
		goto IL_1841;
		IL_1841:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj65 = default;
		if (obj58 != obj65)
		{
			adType3 = adType5;
			goto IL_159e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		object obj66 = default;
		obj64 = obj66;
		goto IL_14b9;
		IL_14b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj67 = (nint)0 << 2;
			object obj68 = obj5 + obj67;
			if ((nint)obj68 == 539)
			{
				object obj69 = obj5 + 4;
				if ((nint)obj69 > -1)
				{
					object obj70 = obj69 + -1;
					obj69 = obj70;
				}
				goto IL_18c9;
			}
		}
		if (obj64 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_18c9;
		IL_0b01:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj71 = default;
		AdType adType15 = default;
		if (obj59 == obj71)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			adType3 = adType15;
			object obj72 = default;
			obj50 = obj72;
			goto IL_0b7c;
		}
		adType3 = adType15;
		goto IL_159e;
		IL_0b7c:
		object obj73 = default;
		if (obj73 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj74 = (nint)0 << 2;
			object obj75 = obj5 + obj74;
			if ((nint)obj75 == 403)
			{
				object obj76 = obj5 + 4;
				if ((nint)obj76 > -1)
				{
					object obj77 = obj76 + -1;
					obj76 = obj77;
				}
				goto IL_1889;
			}
		}
		if (obj50 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_1889;
	}

	public virtual void ShowedAd(AdType adType, string providerID, string adLocationID)
	{
	}

	public virtual void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached)
	{
		//IL_000a: Expected I4, but got Obj
		((AdController)this).allowReCacheOnFail = (byte)(int)providerID != 0;
	}

	public virtual void DismissedAd(AdType adType, string providerID, string adLocationID)
	{
	}

	public virtual void StartedCachingAd(AdType adType, string providerID, string adLocationID)
	{
	}

	public virtual void FinishedWatchingVideo(string providerID, string adLocationID)
	{
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_001f: Expected VT, but got I
		//IL_001f: Expected I4, but got Obj
		//IL_001f: Expected I4, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdEventListenerAdapter)+8]");
			Texture2D texture2D = ((DebugAdGUI)this).MakeTexture((int)providerID, (int)adLocationID, (Color)0);
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v6 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v7+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v8+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S5_v7 (should have been resolved before IL gen)");
		}
	}

	public virtual void FailedToCacheAd(AdType adType, string providerID, string adLocationID)
	{
	}

	public virtual void FailedToShowAd(AdType adType, string providerID, string adLocationID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	public virtual void FailedToInitAdProvider(string providerID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6f: Expected Obj, but got Unknown
		//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7d: Expected Obj, but got Unknown
		//IL_0e86: Expected Obj, but got I4
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea0: Expected Obj, but got Unknown
		//IL_0ea9: Expected Obj, but got I4
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb7: Expected Obj, but got Unknown
		//IL_0ec0: Expected Obj, but got I4
		//IL_0ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Expected Obj, but got Unknown
		//IL_0f26: Expected Obj, but got I4
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d06: Expected Obj, but got Unknown
		//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d14: Expected Obj, but got Unknown
		//IL_0d40: Expected Obj, but got I4
		//IL_0db7: Expected Obj, but got I
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df2: Expected Obj, but got Unknown
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I
		//IL_0171: Expected I, but got Obj
		//IL_0187: Expected Obj, but got I
		//IL_01b2: Expected I, but got Obj
		//IL_0b76: Expected Obj, but got I
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got I4
		//IL_0bc6: Expected Obj, but got I
		//IL_0c5b: Expected Obj, but got I4
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected Obj, but got Unknown
		//IL_02de: Expected Obj, but got I
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected Obj, but got Unknown
		//IL_0341: Expected I, but got Obj
		//IL_0357: Expected Obj, but got I
		//IL_0382: Expected I, but got Obj
		//IL_03c3: Expected I, but got Obj
		//IL_03d9: Expected Obj, but got I
		//IL_0404: Expected I, but got Obj
		//IL_0440: Expected Obj, but got I4
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected Obj, but got Unknown
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected Obj, but got Unknown
		//IL_0a2f: Expected Obj, but got I4
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Expected Obj, but got Unknown
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a67: Expected Obj, but got Unknown
		//IL_0a93: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 72;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		object obj6 = obj2 + 56;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 48;
		obj7 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		bool flag = providerID == null;
		object obj8 = 0;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj15 = default;
		object obj17 = default;
		object obj18 = default;
		object obj20 = default;
		object obj21 = default;
		object obj23 = default;
		object obj31 = default;
		object obj40 = default;
		object obj49 = default;
		object obj51 = default;
		object obj52 = default;
		object obj53 = default;
		object obj54 = default;
		object obj55 = default;
		object obj56 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj11;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj10 == null)
					{
						obj11 = 59;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					bool flag2 = obj12 == providerID;
					object obj13 = flag | flag2;
					if (obj13 == null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v198+24]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					if (obj15 == null)
					{
						continue;
					}
					nint num = (nint)typeof(DebugSettingsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S0_v215 (Il2CppClass<DebugSettingsPopup>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num2 = (nint)typeof(DebugSettingsPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S0_v306 (Il2CppClass<DebugSettingsPopup>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj18 != null)
						{
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj19 = obj20 - -64;
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj21 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v198+24]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj23 == null)
					{
						nint num3 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ S0_v257 (Il2CppClass<Globals>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num4 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ S0_v283 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						if (!Globals.DEBUG_VIDEOADS_PROVIDERS)
						{
							nint num5 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ S0_v265 (Il2CppClass<Globals>)+BA]");
							object obj25 = (nint)0 & (nint)0x200;
							if (obj25 != null)
							{
								nint num6 = (nint)typeof(Globals);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ S0_v274 (Il2CppClass<Globals>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
								}
							}
							if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS ? 1u : 0u) != 0)
							{
								obj11 = 48;
								break;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				object obj26 = obj11 - 14;
				if ((nint)obj11 != 14)
				{
					if ((nint)obj26 != 1 && (nint)obj26 != 2)
					{
						if ((nint)obj26 == 3)
						{
							goto IL_0aa0;
						}
						if ((nint)obj26 != 4 && (nint)obj26 != 5 && (nint)obj26 != 6)
						{
							if ((nint)obj26 == 7)
							{
								goto IL_0aa0;
							}
							if ((nint)obj26 != 8 && (nint)obj26 != 9)
							{
								if ((nint)obj26 == 10)
								{
									goto IL_0aa0;
								}
								if ((nint)obj26 != 11 && (nint)obj26 != 12)
								{
									if ((nint)obj26 == 13)
									{
										goto IL_0aa0;
									}
									if ((nint)obj26 != 14 && (nint)obj26 != 15 && (nint)obj26 != 16)
									{
										if ((nint)obj26 == 17 || (nint)obj26 == 18)
										{
											goto IL_0aa0;
										}
										if ((nint)obj26 != 19 && (nint)obj26 != 20 && (nint)obj26 != 21)
										{
											if ((nint)obj26 == 22 || (nint)obj26 == 23)
											{
												goto IL_0aa0;
											}
											if ((nint)obj26 != 24 && (nint)obj26 != 25 && (nint)obj26 != 26 && (nint)obj26 != 27 && (nint)obj26 != 28 && (nint)obj26 != 29 && (nint)obj26 != 30 && (nint)obj26 != 31 && (nint)obj26 != 32 && (nint)obj26 != 33)
											{
												if ((nint)obj26 != 34)
												{
													if ((nint)obj26 != 35 && (nint)obj26 != 36 && (nint)obj26 != 37 && (nint)obj26 != 38 && (nint)obj26 != 39)
													{
														if ((nint)obj26 == 40 || (nint)obj26 == 41 || (nint)obj26 == 42)
														{
															goto IL_0aa0;
														}
														if ((nint)obj26 != 43 && (nint)obj26 != 44 && (nint)obj26 == 45)
														{
															object obj27 = obj7 + 4;
															object obj28 = obj27 + 1;
															obj27 = obj28;
															object obj29 = obj28 << 2;
															object obj30 = obj7 + obj29;
															obj30 = 231;
															obj31 = obj8;
														}
													}
												}
												else
												{
													object obj32 = obj7 + 4;
													object obj33 = obj32 + 1;
													obj32 = obj33;
													object obj34 = obj33 << 2;
													object obj35 = obj7 + obj34;
													obj35 = 259;
													obj31 = obj8;
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_0b1e;
				}
				goto IL_0aa0;
			}
			object obj36 = obj7 + 4;
			object obj37 = obj36 + 1;
			obj36 = obj37;
			object obj38 = obj37 << 2;
			object obj39 = obj7 + obj38;
			obj39 = 259;
			obj40 = obj8;
			break;
			IL_103f:
			object obj41;
			obj8 = obj41;
			continue;
			IL_0b1e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
				object obj42 = (nint)0 << 2;
				object obj43 = obj7 + obj42;
				if ((nint)obj43 == 259)
				{
					obj40 = obj31;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
				object obj44 = (nint)0 << 2;
				object obj45 = obj7 + obj44;
				if ((nint)obj45 == 231)
				{
					object obj46 = obj7 + 4;
					if ((nint)obj46 > -1)
					{
						object obj47 = obj46 + -1;
						obj46 = obj47;
					}
					obj41 = obj31;
					goto IL_103f;
				}
			}
			if (obj31 == null)
			{
				obj41 = 0;
				goto IL_103f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj48 = obj49;
			object obj50 = obj51;
			goto IL_0f85;
			IL_0f85:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			if (obj50 == obj52)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				obj40 = obj53;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			break;
			IL_0aa0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			if (obj51 != obj54)
			{
				obj48 = obj55;
				obj50 = obj51;
				goto IL_0f85;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			obj31 = obj56;
			goto IL_0b1e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+4]");
			object obj57 = (nint)0 << 2;
			object obj58 = obj7 + obj57;
			if ((nint)obj58 == 259)
			{
				object obj59 = obj7 + 4;
				if ((nint)obj59 > -1)
				{
					object obj60 = obj59 + -1;
					obj59 = obj60;
				}
				return;
			}
		}
		if (obj40 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public virtual void CachingTimedOut(AdType adType, string providerID, string adLocationID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	public virtual void ClickedAd(AdType adType, string providerID, string adLocationID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	public virtual void ReachedDailyInterstitialLimit(int limit)
	{
	}

	public virtual void ReachedHourlyInterstitialLimit(int limit)
	{
	}

	public virtual void ReachedNewUserInterstitialLimit(int limit)
	{
	}

	public virtual void ReachedTimeBetweenAdsInterstitialLimit(int limit)
	{
	}

	public virtual void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID)
	{
	}

	public virtual void PriorityListWrapped(string waterfallID)
	{
	}

	protected virtual void AdFailed(AdType adType, string providerID, string adLocationID)
	{
	}

	public AdEventListenerAdapter()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
	}
}
