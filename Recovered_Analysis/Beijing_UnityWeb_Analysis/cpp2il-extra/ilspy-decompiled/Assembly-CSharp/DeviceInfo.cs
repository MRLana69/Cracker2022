using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.OnGUIWrappers;
using Kiloo.Common.Performance;
using Kiloo.Common.Plugins.DeviceUtility;
using Missions;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Info;
using SYBO.Subway.Managers;
using SYBO.Subway.Utilities;
using UnityEngine;
using UnityEngine.Networking;

public class DeviceInfo
{
	public enum FormFactor
	{
		iPhone,
		iPad,
		small,
		medium,
		large,
		iPhone5,
		iPhone6,
		iPhone6Plus,
		iPhoneUnknown
	}

	public enum PerformanceLevel
	{
		Low,
		Medium,
		High
	}

	private const int DEFAULT_ANDROID_PERFORMANCE_LEVEL_THRESHOLD_VALUE = 1000;

	private const int DEFAULT_KINDLE_PERFORMANCE_LEVEL_THRESHOLD_VALUE = 900;

	private static readonly string ShaderBackgroundBlendSrcPropName;

	private static readonly string ShaderBackgroundBlendDstPropName;

	public PerformanceLevel _performanceLevel;

	public string deviceModel;

	private float dpi__BackingField;

	private FormFactor formFactor__BackingField;

	private bool isHighres__BackingField;

	private int gpuScore__BackingField;

	private GPUCategory gpuCategory__BackingField;

	private static DeviceInfo _instance;

	public PerformanceLevel performanceLevel
	{
		get
		{
			//IL_1170: Expected Obj, but got I4
			//IL_1140: Unknown result type (might be due to invalid IL or missing references)
			//IL_1145: Expected Obj, but got Unknown
			//IL_1162: Expected Obj, but got I
			//IL_129d: Expected I4, but got Obj
			//IL_0043: Expected I, but got Obj
			//IL_0059: Expected Obj, but got I
			//IL_066f: Expected I, but got Obj
			//IL_0685: Expected Obj, but got I
			//IL_09c4: Expected I, but got Obj
			//IL_09da: Expected Obj, but got I
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_0084: Expected I, but got Obj
			//IL_0b10: Expected I, but got Obj
			//IL_0b26: Expected Obj, but got I
			//IL_0b43: Expected I, but got Obj
			//IL_0710: Expected I, but got Obj
			//IL_0726: Expected Obj, but got I
			//IL_06b0: Expected I, but got Obj
			//IL_0bf8: Expected I, but got Obj
			//IL_0c0e: Expected Obj, but got I
			//IL_13c5: Expected Obj, but got I
			//IL_0a05: Expected I, but got Obj
			//IL_0185: Expected I, but got Obj
			//IL_019b: Expected Obj, but got I
			//IL_0125: Expected I, but got Obj
			//IL_0d44: Expected I, but got Obj
			//IL_0d5a: Expected Obj, but got I
			//IL_0b5f: Expected I, but got Obj
			//IL_0b8f: Expected I, but got Obj
			//IL_0a52: Expected I, but got Obj
			//IL_0a68: Expected Obj, but got I
			//IL_07b1: Expected I, but got Obj
			//IL_07c7: Expected Obj, but got I
			//IL_0751: Expected I, but got Obj
			//IL_0e02: Expected I, but got Obj
			//IL_0e18: Expected Obj, but got I
			//IL_0c39: Expected I, but got Obj
			//IL_1364: Expected Obj, but got I
			//IL_1374: Expected Obj, but got I
			//IL_1384: Expected Obj, but got I
			//IL_138d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1392: Expected Obj, but got Unknown
			//IL_139b: Unknown result type (might be due to invalid IL or missing references)
			//IL_13a0: Expected Obj, but got Unknown
			//IL_0226: Expected I, but got Obj
			//IL_023c: Expected Obj, but got I
			//IL_01c6: Expected I, but got Obj
			//IL_0ec0: Expected I, but got Obj
			//IL_0ed6: Expected Obj, but got I
			//IL_0ef3: Expected I, but got Obj
			//IL_0d85: Expected I, but got Obj
			//IL_0c86: Expected I, but got Obj
			//IL_0c9c: Expected Obj, but got I
			//IL_0bb5: Expected I, but got Obj
			//IL_0a93: Expected I, but got Obj
			//IL_0852: Expected I, but got Obj
			//IL_0868: Expected Obj, but got I
			//IL_07f2: Expected I, but got Obj
			//IL_0fa8: Expected I, but got Obj
			//IL_0fbe: Expected Obj, but got I
			//IL_14c7: Expected Obj, but got I
			//IL_0e43: Expected I, but got Obj
			//IL_1430: Expected Obj, but got I
			//IL_1440: Expected Obj, but got I
			//IL_1450: Expected Obj, but got I
			//IL_1459: Unknown result type (might be due to invalid IL or missing references)
			//IL_145e: Expected Obj, but got Unknown
			//IL_1467: Unknown result type (might be due to invalid IL or missing references)
			//IL_146c: Expected Obj, but got Unknown
			//IL_02c7: Expected I, but got Obj
			//IL_02dd: Expected Obj, but got I
			//IL_0267: Expected I, but got Obj
			//IL_108b: Expected I, but got Obj
			//IL_10a1: Expected Obj, but got I
			//IL_10be: Expected I, but got Obj
			//IL_14fc: Expected Obj, but got I
			//IL_0f0f: Expected I, but got Obj
			//IL_0f3f: Expected I, but got Obj
			//IL_0cc7: Expected I, but got Obj
			//IL_08f3: Expected I, but got Obj
			//IL_0909: Expected Obj, but got I
			//IL_0893: Expected I, but got Obj
			//IL_152b: Expected Obj, but got I
			//IL_0fe9: Expected I, but got Obj
			//IL_0368: Expected I, but got Obj
			//IL_037e: Expected Obj, but got I
			//IL_0308: Expected I, but got Obj
			//IL_10da: Expected I, but got Obj
			//IL_110a: Expected I, but got Obj
			//IL_0f65: Expected I, but got Obj
			//IL_0934: Expected I, but got Obj
			//IL_0409: Expected I, but got Obj
			//IL_041f: Expected Obj, but got I
			//IL_03a9: Expected I, but got Obj
			//IL_1130: Expected I, but got Obj
			//IL_04aa: Expected I, but got Obj
			//IL_04c0: Expected Obj, but got I
			//IL_044a: Expected I, but got Obj
			//IL_0531: Expected I, but got Obj
			//IL_0547: Expected Obj, but got I
			//IL_04eb: Expected I, but got Obj
			//IL_05b8: Expected I, but got Obj
			//IL_05ce: Expected Obj, but got I
			//IL_0572: Expected I, but got Obj
			//IL_05f9: Expected I, but got Obj
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+4C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
				if ((nint)0 == 14)
				{
					nint num = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v268 (Il2CppClass<Globals>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v418 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_FLURRY ? 1u : 0u) == 0)
					{
						list.Add("Flurry");
					}
					nint num3 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v277 (Il2CppClass<Globals>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v411 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_INMOBI ? 1u : 0u) == 0)
					{
						list.Add("InMobi");
					}
					nint num5 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v286 (Il2CppClass<Globals>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num6 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v404 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_TAPJOY ? 1u : 0u) == 0)
					{
						list.Add("Tapjoy");
					}
					nint num7 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v295 (Il2CppClass<Globals>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num8 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v397 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_VUNGLE ? 1u : 0u) == 0)
					{
						list.Add("Vungle");
					}
					nint num9 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v304 (Il2CppClass<Globals>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num10 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v390 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_ADCOLONY ? 1u : 0u) == 0)
					{
						list.Add("AdColony");
					}
					nint num11 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S0_v313 (Il2CppClass<Globals>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num12 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ S0_v383 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST ? 1u : 0u) == 0)
					{
						list.Add("Chartboost");
					}
					nint num13 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ S0_v322 (Il2CppClass<Globals>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num14 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ S0_v376 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC ? 1u : 0u) == 0)
					{
						list.Add("Supersonic");
					}
					nint num15 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S0_v331 (Il2CppClass<Globals>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num16 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ S0_v370 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_FACEBOOK ? 1u : 0u) == 0)
					{
						list.Add("Facebook");
					}
					nint num17 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ S0_v340 (Il2CppClass<Globals>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num18 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ S0_v364 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_MOBVISTA ? 1u : 0u) == 0)
					{
						list.Add("MobVista");
					}
					nint num19 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ S0_v349 (Il2CppClass<Globals>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num20 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ S0_v358 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_YEAH_MOBI ? 1u : 0u) == 0)
					{
						list.Add("YeahMobi");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
					if ((nint)0 == 12)
					{
						nint num21 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v188 (Il2CppClass<Globals>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num22 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v261 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST ? 1u : 0u) == 0)
						{
							list.Add("Chartboost");
						}
						nint num23 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v197 (Il2CppClass<Globals>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num24 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v254 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_INMOBI ? 1u : 0u) == 0)
						{
							list.Add("InMobi");
						}
						nint num25 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v206 (Il2CppClass<Globals>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num26 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v247 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC ? 1u : 0u) == 0)
						{
							list.Add("Supersonic");
						}
						nint num27 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v215 (Il2CppClass<Globals>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num28 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v240 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK ? 1u : 0u) == 0)
						{
							list.Add("Facebook");
						}
						nint num29 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ S0_v224 (Il2CppClass<Globals>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num30 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S0_v233 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_YEAHMOBI ? 1u : 0u) == 0)
						{
							list.Add("YeahMobi");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
						if ((nint)0 == 37)
						{
							nint num31 = (nint)typeof(DebugSettingsPopup);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v156 (Il2CppClass<DebugSettingsPopup>)+BA]");
							object obj17 = (nint)0 & (nint)0x200;
							if (obj17 != null)
							{
								nint num32 = (nint)typeof(DebugSettingsPopup);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v181 (Il2CppClass<DebugSettingsPopup>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Dictionary<string, string>.KeyCollection keys = DebugSettingsPopup.completeAwardsTiersSelectedItems.Keys;
							if (keys != null)
							{
								nint num33 = (nint)typeof(DebugSettingsPopup);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v166 (Il2CppClass<DebugSettingsPopup>)+BA]");
								object obj18 = (nint)0 & (nint)0x200;
								if (obj18 != null)
								{
									nint num34 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v175 (Il2CppClass<DebugSettingsPopup>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Dictionary<string, string>.KeyCollection keys2 = DebugSettingsPopup.completeAwardsTiersSelectedItems.Keys;
								nint num35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S3_v8 (Il2CppMethodInfo)+C]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S3_v9+60]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S3_v10+38]");
								object obj21 = 0;
								object obj22 = obj21 & 0x1FFF;
								object obj23 = obj22 + 113696;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S4_v9 (should have been resolved before IL gen)");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
							if ((nint)0 == 38)
							{
								nint num36 = (nint)typeof(DebugSettingsPopup);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v144 (Il2CppClass<DebugSettingsPopup>)+BA]");
								object obj24 = (nint)0 & (nint)0x200;
								bool flag = obj24 == null;
								nint num37 = (nint)typeof(DebugSettingsPopup);
								if (!flag)
								{
									nint num38 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v149 (Il2CppClass<DebugSettingsPopup>)+74]");
									bool flag2 = (nint)0 == 0;
									bool flag3 = !flag2;
									num37 = (nint)typeof(DebugSettingsPopup);
									if (!flag3)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										num37 = (nint)typeof(DebugSettingsPopup);
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ L0_v26 (Il2CppClass<DebugSettingsPopup>)+5C]");
								object obj25 = (nint)0 + (nint)8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
								string item = default;
								list.Add(item);
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
								if ((nint)0 == 39)
								{
									nint num39 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v112 (Il2CppClass<DebugSettingsPopup>)+BA]");
									object obj26 = (nint)0 & (nint)0x200;
									if (obj26 != null)
									{
										nint num40 = (nint)typeof(DebugSettingsPopup);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v137 (Il2CppClass<DebugSettingsPopup>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									Dictionary<string, string>.KeyCollection keys3 = DebugSettingsPopup.almostCompleteAwardsTiersSelectedItems.Keys;
									if (keys3 != null)
									{
										nint num41 = (nint)typeof(DebugSettingsPopup);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v122 (Il2CppClass<DebugSettingsPopup>)+BA]");
										object obj27 = (nint)0 & (nint)0x200;
										if (obj27 != null)
										{
											nint num42 = (nint)typeof(DebugSettingsPopup);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ S0_v131 (Il2CppClass<DebugSettingsPopup>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										Dictionary<string, string>.KeyCollection keys4 = DebugSettingsPopup.almostCompleteAwardsTiersSelectedItems.Keys;
										nint num43 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S3_v3 (Il2CppMethodInfo)+C]");
										object obj28 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S3_v4+60]");
										object obj29 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ S3_v5+38]");
										object obj30 = 0;
										object obj31 = obj30 & 0x1FFF;
										object obj32 = obj31 + 113696;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S4_v5 (should have been resolved before IL gen)");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
									if ((nint)0 == 40)
									{
										nint num44 = (nint)typeof(DebugSettingsPopup);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v100 (Il2CppClass<DebugSettingsPopup>)+BA]");
										object obj33 = (nint)0 & (nint)0x200;
										if (obj33 != null)
										{
											nint num45 = (nint)typeof(DebugSettingsPopup);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v105 (Il2CppClass<DebugSettingsPopup>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										OverflowException item2 = new OverflowException();
										list.Add((string)(object)item2);
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
										if ((nint)0 == 41)
										{
											nint num46 = (nint)typeof(DebugSettingsPopup);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v88 (Il2CppClass<DebugSettingsPopup>)+BA]");
											object obj34 = (nint)0 & (nint)0x200;
											if (obj34 != null)
											{
												nint num47 = (nint)typeof(DebugSettingsPopup);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ S0_v93 (Il2CppClass<DebugSettingsPopup>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											OverflowException item3 = new OverflowException();
											list.Add((string)(object)item3);
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
											if ((nint)0 == 45)
											{
												nint num48 = (nint)typeof(DebugSettingsPopup);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v76 (Il2CppClass<DebugSettingsPopup>)+BA]");
												object obj35 = (nint)0 & (nint)0x200;
												bool flag4 = obj35 == null;
												nint num49 = (nint)typeof(DebugSettingsPopup);
												if (!flag4)
												{
													nint num50 = (nint)typeof(DebugSettingsPopup);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S0_v81 (Il2CppClass<DebugSettingsPopup>)+74]");
													bool flag5 = (nint)0 == 0;
													bool flag6 = !flag5;
													num49 = (nint)typeof(DebugSettingsPopup);
													if (!flag6)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														num49 = (nint)typeof(DebugSettingsPopup);
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ L0_v9 (Il2CppClass<DebugSettingsPopup>)+5C]");
												object obj36 = (nint)0 + (nint)16;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
												string item4 = default;
												list.Add(item4);
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
												if ((nint)0 == 46)
												{
													nint num51 = (nint)typeof(DeviceInfo);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S0_v62 (Il2CppClass<DeviceInfo>)+BA]");
													object obj37 = (nint)0 & (nint)0x200;
													if (obj37 != null)
													{
														nint num52 = (nint)typeof(DeviceInfo);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v71 (Il2CppClass<DeviceInfo>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S1_v29 (System.Int32)+8]");
													obj = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
													throw new NullReferenceException();
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
												if ((nint)0 == 51)
												{
													nint num53 = (nint)typeof(DebugSettingsPopup);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S0_v50 (Il2CppClass<DebugSettingsPopup>)+BA]");
													object obj38 = (nint)0 & (nint)0x200;
													bool flag7 = obj38 == null;
													nint num54 = (nint)typeof(DebugSettingsPopup);
													if (!flag7)
													{
														nint num55 = (nint)typeof(DebugSettingsPopup);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ S0_v55 (Il2CppClass<DebugSettingsPopup>)+74]");
														bool flag8 = (nint)0 == 0;
														bool flag9 = !flag8;
														num54 = (nint)typeof(DebugSettingsPopup);
														if (!flag9)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															num54 = (nint)typeof(DebugSettingsPopup);
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ L0_v4 (Il2CppClass<DebugSettingsPopup>)+5C]");
													object obj39 = (nint)0 + (nint)20;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
													string item5 = default;
													list.Add(item5);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				object obj40 = this - -64;
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+12C]");
				list.Add((string)0);
			}
			return (PerformanceLevel)list;
		}
	}

	public float dpi
	{
		get
		{
			//IL_00f1: Expected I4, but got F4
			//IL_01bf: Expected F4, but got I4
			//IL_002d: Expected I, but got Obj
			//IL_0043: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0158: Expected I4, but got F4
			//IL_018e: Expected I4, but got F4
			if (gpuScore__BackingField != 0)
			{
				float maxDelay = NetworkServer.maxDelay;
				float num = maxDelay - dpi__BackingField;
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num4 = ((!(0f > num)) ? num : 0f);
				float num5 = (float)(isHighres__BackingField ? 1 : 0) + num4;
				isHighres__BackingField = (byte)(int)num5 != 0;
				float num6 = (float)(isHighres__BackingField ? 1 : 0) * 1000f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				object obj2 = default;
				float num7 = 0.001f * (float)obj2;
				formFactor__BackingField = (FormFactor)num7;
				bool flag = (byte)((isHighres__BackingField ? 1u : 0u) - (uint)formFactor__BackingField) != 0;
				isHighres__BackingField = flag;
				dpi__BackingField = maxDelay;
			}
			else
			{
				gpuScore__BackingField = 1;
				float maxDelay2 = NetworkServer.maxDelay;
				dpi__BackingField = maxDelay2;
				formFactor__BackingField = FormFactor.iPhone;
			}
			return (float)formFactor__BackingField;
		}
		private set
		{
			//IL_000a: Expected I4, but got F4
			_performanceLevel = (PerformanceLevel)value;
		}
	}

	public unsafe FormFactor formFactor
	{
		get
		{
			return (FormFactor)_performanceLevel;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_29ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a04: Expected I, but got Unknown
			//IL_2a0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a12: Expected I4, but got Unknown
			//IL_2a29: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a2e: Expected I4, but got Unknown
			//IL_2a45: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a4a: Expected Obj, but got Unknown
			//IL_2a53: Expected Obj, but got I4
			//IL_2a5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a61: Expected Obj, but got Unknown
			//IL_2a6a: Expected Obj, but got I4
			//IL_2a79: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a7e: Expected Obj, but got Unknown
			//IL_2a87: Expected Obj, but got I4
			//IL_2a90: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a95: Expected Obj, but got Unknown
			//IL_2a9e: Expected Obj, but got F4
			//IL_2aa7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2aac: Expected Obj, but got Unknown
			//IL_2ab5: Expected Obj, but got I4
			//IL_2abe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ac3: Expected Obj, but got Unknown
			//IL_2acc: Expected Obj, but got I4
			//IL_2ad5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ada: Expected Obj, but got Unknown
			//IL_2ae3: Expected Obj, but got I4
			//IL_2aec: Unknown result type (might be due to invalid IL or missing references)
			//IL_2af1: Expected Obj, but got Unknown
			//IL_2b14: Expected Obj, but got I
			//IL_2621: Expected Obj, but got I4
			//IL_2249: Expected Obj, but got I4
			//IL_03e5: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			//IL_2714: Expected I4, but got Obj
			//IL_2714: Expected Obj, but got I
			//IL_2453: Expected Obj, but got I
			//IL_2478: Expected Obj, but got I4
			//IL_2478: Expected Obj, but got I
			//IL_0693: Expected I, but got Obj
			//IL_06a9: Expected Obj, but got I
			//IL_271f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2724: Expected Obj, but got Unknown
			//IL_2732: Expected I, but got Obj
			//IL_2748: Expected Obj, but got I
			//IL_2bbc: Expected I, but got Obj
			//IL_2bd7: Expected I, but got Obj
			//IL_2bed: Expected Obj, but got I
			//IL_0235: Expected Obj, but got I
			//IL_0249: Expected I, but got Obj
			//IL_025f: Expected Obj, but got I
			//IL_2f71: Expected I4, but got Obj
			//IL_2938: Unknown result type (might be due to invalid IL or missing references)
			//IL_293d: Expected Obj, but got Unknown
			//IL_06d4: Expected I, but got Obj
			//IL_2b7e: Expected I4, but got Obj
			//IL_2b7e: Expected Obj, but got I
			//IL_2b9c: Expected Obj, but got I4
			//IL_2b9c: Expected Obj, but got I
			//IL_2773: Expected I, but got Obj
			//IL_0776: Expected I4, but got Obj
			//IL_0776: Expected Obj, but got I
			//IL_077c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0781: Expected Obj, but got Unknown
			//IL_078f: Expected I, but got Obj
			//IL_07a5: Expected Obj, but got I
			//IL_07c2: Expected I, but got Obj
			//IL_0721: Expected I, but got Obj
			//IL_037f: Expected I4, but got Obj
			//IL_037f: Expected Obj, but got I
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Expected Obj, but got Unknown
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Expected Obj, but got Unknown
			//IL_02e2: Expected I4, but got Obj
			//IL_028a: Expected I, but got Obj
			//IL_29de: Expected I4, but got Obj
			//IL_2c49: Expected Obj, but got I
			//IL_03ae: Expected Obj, but got I
			//IL_2994: Expected Obj, but got I4
			//IL_29a0: Expected I4, but got Obj
			//IL_07de: Expected I, but got Obj
			//IL_080e: Expected I, but got Obj
			//IL_27c2: Expected Obj, but got I
			//IL_27e7: Expected Obj, but got I4
			//IL_27e7: Expected Obj, but got I
			//IL_0ba8: Expected I, but got Obj
			//IL_0bbe: Expected Obj, but got I
			//IL_2550: Expected I4, but got Obj
			//IL_2550: Expected Obj, but got I
			//IL_2556: Unknown result type (might be due to invalid IL or missing references)
			//IL_255b: Expected Obj, but got Unknown
			//IL_0834: Expected I, but got Obj
			//IL_2cba: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got I4
			//IL_0c3e: Expected I4, but got Obj
			//IL_0c3e: Expected Obj, but got I
			//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c49: Expected Obj, but got Unknown
			//IL_0c57: Expected I, but got Obj
			//IL_0c6d: Expected Obj, but got I
			//IL_0c8a: Expected I, but got Obj
			//IL_0be9: Expected I, but got Obj
			//IL_25fc: Expected I4, but got Obj
			//IL_2cd5: Expected Obj, but got I
			//IL_286a: Expected I4, but got Obj
			//IL_286a: Expected Obj, but got I
			//IL_25b2: Expected Obj, but got I4
			//IL_25be: Expected I4, but got Obj
			//IL_0ca6: Expected I, but got Obj
			//IL_0cd6: Expected I, but got Obj
			//IL_2875: Unknown result type (might be due to invalid IL or missing references)
			//IL_287a: Expected Obj, but got Unknown
			//IL_0cfc: Expected I, but got Obj
			//IL_0f13: Expected Obj, but got I
			//IL_0f39: Expected Obj, but got I
			//IL_0f49: Expected Obj, but got I
			//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f5f: Expected Obj, but got Unknown
			//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f6d: Expected Obj, but got Unknown
			//IL_0f85: Expected I, but got Obj
			//IL_0f9b: Expected Obj, but got I
			//IL_291b: Expected I4, but got Obj
			//IL_23a0: Expected I4, but got Obj
			//IL_23a0: Expected Obj, but got I
			//IL_28d1: Expected Obj, but got I4
			//IL_28dd: Expected I4, but got Obj
			//IL_23ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_23d3: Expected Obj, but got Unknown
			//IL_1012: Expected Obj, but got I
			//IL_0fc6: Expected I, but got Obj
			//IL_2434: Expected I4, but got Obj
			//IL_2ddd: Expected Obj, but got I4
			//IL_2405: Expected Obj, but got I
			//IL_103c: Expected Obj, but got I4
			//IL_176e: Expected Obj, but got I
			//IL_1794: Expected Obj, but got I
			//IL_17a4: Expected Obj, but got I
			//IL_17b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_17ba: Expected Obj, but got Unknown
			//IL_17c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c8: Expected Obj, but got Unknown
			//IL_17e0: Expected I, but got Obj
			//IL_17f6: Expected Obj, but got I
			//IL_2d90: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d95: Expected Obj, but got Unknown
			//IL_15ff: Expected I4, but got Obj
			//IL_15ff: Expected Obj, but got I
			//IL_1605: Unknown result type (might be due to invalid IL or missing references)
			//IL_160a: Expected Obj, but got Unknown
			//IL_1618: Expected I, but got Obj
			//IL_162e: Expected Obj, but got I
			//IL_105d: Expected Obj, but got I4
			//IL_186d: Expected Obj, but got I
			//IL_1821: Expected I, but got Obj
			//IL_1075: Expected Obj, but got I4
			//IL_1759: Expected I4, but got Obj
			//IL_1659: Expected I, but got Obj
			//IL_2ef1: Expected Obj, but got I4
			//IL_108d: Expected Obj, but got I4
			//IL_16a6: Expected I, but got Obj
			//IL_16bc: Expected Obj, but got I
			//IL_16d9: Expected I, but got Obj
			//IL_1897: Expected Obj, but got I4
			//IL_10ad: Expected Obj, but got I4
			//IL_2e51: Expected Obj, but got I
			//IL_2ea4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ea9: Expected Obj, but got Unknown
			//IL_10c5: Expected Obj, but got I4
			//IL_16f5: Expected I, but got Obj
			//IL_1725: Expected I, but got Obj
			//IL_18b8: Expected Obj, but got I4
			//IL_1f84: Expected Obj, but got I4
			//IL_1f84: Expected I4, but got Obj
			//IL_1f84: Expected Obj, but got I
			//IL_1f8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f8f: Expected Obj, but got Unknown
			//IL_1f98: Expected VT, but got Obj
			//IL_10dd: Expected Obj, but got I4
			//IL_18d0: Expected Obj, but got I4
			//IL_1fad: Expected Obj, but got I
			//IL_1fc3: Expected I4, but got Obj
			//IL_10fd: Expected Obj, but got I4
			//IL_174b: Expected I, but got Obj
			//IL_18e8: Expected Obj, but got I4
			//IL_2062: Expected Obj, but got I4
			//IL_2062: Expected I4, but got Obj
			//IL_2062: Expected Obj, but got I
			//IL_2068: Unknown result type (might be due to invalid IL or missing references)
			//IL_206d: Expected Obj, but got Unknown
			//IL_2076: Expected VT, but got Obj
			//IL_2f8b: Expected Obj, but got I
			//IL_2f91: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f96: Expected Obj, but got Unknown
			//IL_2fa4: Expected I, but got Obj
			//IL_2fba: Expected Obj, but got I
			//IL_1440: Expected Obj, but got I
			//IL_1115: Expected Obj, but got I4
			//IL_1908: Expected Obj, but got I4
			//IL_208b: Expected Obj, but got I
			//IL_20a1: Expected I4, but got Obj
			//IL_2e14: Expected Obj, but got I4
			//IL_1128: Expected I, but got Obj
			//IL_113e: Expected Obj, but got I
			//IL_1920: Expected Obj, but got I4
			//IL_1551: Expected Obj, but got I4
			//IL_14f8: Expected I, but got Obj
			//IL_1476: Unknown result type (might be due to invalid IL or missing references)
			//IL_147b: Expected Obj, but got Unknown
			//IL_2dc5: Expected Obj, but got I4
			//IL_1938: Expected Obj, but got I4
			//IL_1169: Expected I, but got Obj
			//IL_1958: Expected Obj, but got I4
			//IL_14ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b1: Expected Obj, but got Unknown
			//IL_1c9b: Expected Obj, but got I
			//IL_1970: Expected Obj, but got I4
			//IL_1192: Expected Obj, but got I4
			//IL_1983: Expected I, but got Obj
			//IL_1999: Expected Obj, but got I
			//IL_1cd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd6: Expected Obj, but got Unknown
			//IL_2ed9: Expected Obj, but got I4
			//IL_19c4: Expected I, but got Obj
			//IL_213c: Expected I4, but got Obj
			//IL_213c: Expected Obj, but got I
			//IL_2142: Unknown result type (might be due to invalid IL or missing references)
			//IL_2147: Expected Obj, but got Unknown
			//IL_2155: Expected I, but got Obj
			//IL_216b: Expected Obj, but got I
			//IL_2188: Expected I, but got Obj
			//IL_0e40: Expected Obj, but got I4
			//IL_0e40: Expected I4, but got Obj
			//IL_0e40: Expected Obj, but got I
			//IL_1d07: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d0c: Expected Obj, but got Unknown
			//IL_2f47: Expected Obj, but got I
			//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e50: Expected Obj, but got Unknown
			//IL_0e5e: Expected I, but got Obj
			//IL_0e74: Expected Obj, but got I
			//IL_1dfe: Expected Obj, but got I
			//IL_1e04: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e09: Expected Obj, but got Unknown
			//IL_1e17: Expected I, but got Obj
			//IL_1e2d: Expected Obj, but got I
			//IL_19ed: Expected Obj, but got I4
			//IL_21a4: Expected I, but got Obj
			//IL_21d4: Expected I, but got Obj
			//IL_2d45: Expected Obj, but got I
			//IL_2f28: Expected Obj, but got I4
			//IL_0e9f: Expected I, but got Obj
			//IL_1eb1: Expected Obj, but got I4
			//IL_1e58: Expected I, but got Obj
			//IL_21fa: Expected I, but got Obj
			//IL_0d4d: Expected I, but got Obj
			//IL_0d63: Expected Obj, but got I
			//IL_2d13: Expected I4, but got Obj
			//IL_2d13: Expected Obj, but got I
			//IL_2d19: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d1e: Expected Obj, but got Unknown
			//IL_0dda: Expected I4, but got Obj
			//IL_0d8e: Expected I, but got Obj
			//IL_0ad2: Expected I4, but got Obj
			//IL_0ad2: Expected Obj, but got I
			//IL_1368: Unknown result type (might be due to invalid IL or missing references)
			//IL_136d: Expected Obj, but got Unknown
			//IL_1376: Unknown result type (might be due to invalid IL or missing references)
			//IL_137b: Expected Obj, but got Unknown
			//IL_13a7: Expected Obj, but got I4
			//IL_0add: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae2: Expected Obj, but got Unknown
			//IL_0af0: Expected I, but got Obj
			//IL_0b06: Expected Obj, but got I
			//IL_0b23: Expected I, but got Obj
			//IL_2c7e: Expected Obj, but got I
			//IL_0898: Expected Obj, but got I4
			//IL_0b3f: Expected I, but got Obj
			//IL_0b6f: Expected I, but got Obj
			//IL_1bc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bc8: Expected Obj, but got Unknown
			//IL_1bd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bd6: Expected Obj, but got Unknown
			//IL_1c02: Expected Obj, but got I4
			//IL_0b95: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 96;
			nint num = (nint)(obj2 - -64);
			AwardTierType awardTierType = (AwardTierType)(obj2 + 81);
			((AwardTierType*)(int)awardTierType)->value__ = 0;
			AwardTierType awardTierType2 = (AwardTierType)(obj2 + 80);
			((AwardTierType*)(int)awardTierType2)->value__ = 0;
			object obj3 = obj2 + 56;
			obj3 = 0;
			object obj4 = obj2 + 40;
			obj4 = 0;
			_ = 0;
			object obj5 = obj2 + 32;
			obj5 = 0;
			object obj6 = obj2 + 28;
			obj6 = 0f;
			object obj7 = obj2 + 24;
			obj7 = 0;
			object obj8 = obj2 + 20;
			obj8 = 0;
			object obj9 = obj2 + 16;
			obj9 = 0;
			object obj10 = obj2 + 8;
			obj10 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
			object obj11 = 0;
			_ = 0;
			if (value > (FormFactor)19)
			{
				if (value > (FormFactor)53)
				{
					object obj12 = value - 58;
					if (value != (FormFactor)58)
					{
						if ((nint)obj12 != 1 && (nint)obj12 != 2 && (nint)obj12 == 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							List<string> list = default;
							list._002Ector();
							obj9 = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							throw new NullReferenceException();
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
						object obj13 = 0;
						_ = 1;
						nint num2 = (nint)typeof(DebugQueuedEnvironments);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v641 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num3 = (nint)typeof(DebugQueuedEnvironments);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S1_v655 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
						((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)DebugQueuedEnvironments.AvailableEnvironments, null);
						bool isEnabled = DemoVideoModeManager.IsEnabled;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
						((SelectPopupButton)0).OnSelectPopupClosed((Dictionary<string, string>)isEnabled);
						object obj15 = this - -64;
						((UILabel)obj15).fontSize = (int)string.Empty;
					}
				}
				else if (value == (FormFactor)20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					List<string> list2 = default;
					list2._002Ector();
					list2.Add("1");
					list2.Add("5");
					list2.Add("10");
					list2.Add("30");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
					((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list2, null);
					object obj16 = this - -64;
					bool flag = IOSViewController._GetIsSimulator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S2_v462 (System.Boolean)+5C]");
					object obj17 = (nint)0 / (nint)60;
					obj3 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					int fontSize = default;
					((UILabel)obj16).fontSize = fontSize;
				}
				else
				{
					object obj18 = value - 31;
					if (value == (FormFactor)31)
					{
						nint num4 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v166 (Il2CppClass<System.Type>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num5 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S1_v193 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = typeof(Characters.CharacterId);
						((IntPtr*)num)->m_value = (void*)(nint)obj2;
						Type enumType = Type.internal_from_handle((IntPtr)num);
						nint num6 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S2_v121 (Il2CppClass<System.Enum>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num7 = (nint)typeof(Enum);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S2_v140 (Il2CppClass<System.Enum>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string[] collection = Enum.InternalGetNames((System.RuntimeType)enumType);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						List<string> list3 = default;
						list3._002Ector((IEnumerable<string>)collection);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
						((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list3, null);
						object obj21 = this - -64;
						nint num8 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ S1_v181 (Il2CppClass<Globals>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						bool flag2 = obj22 == null;
						nint num9 = (nint)typeof(Globals);
						if (!flag2)
						{
							nint num10 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ S1_v187 (Il2CppClass<Globals>)+74]");
							bool flag3 = (nint)0 == 0;
							bool flag4 = !flag3;
							num9 = (nint)typeof(Globals);
							if (!flag4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num9 = (nint)typeof(Globals);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ L1_v20 (Il2CppClass<Globals>)+5C]");
						object obj23 = (nint)0 + (nint)120;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						throw new NullReferenceException();
					}
					if ((nint)obj18 != 1 && (nint)obj18 != 2)
					{
						if ((nint)obj18 == 3)
						{
							nint num11 = (nint)typeof(Boards);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S1_v198 (Il2CppClass<Info.Boards>)+BA]");
							object obj24 = (nint)0 & (nint)0x200;
							if (obj24 != null)
							{
								nint num12 = (nint)typeof(Boards);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S1_v222 (Il2CppClass<Info.Boards>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool isVideoAddsSupported = EarnCoinsData.isVideoAddsSupported;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							List<string> list4 = default;
							list4._002Ector((IEnumerable<string>)isVideoAddsSupported);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
							((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list4, null);
							object obj25 = this - -64;
							nint num13 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S1_v210 (Il2CppClass<Globals>)+BA]");
							object obj26 = (nint)0 & (nint)0x200;
							bool flag5 = obj26 == null;
							nint num14 = (nint)typeof(Globals);
							if (!flag5)
							{
								nint num15 = (nint)typeof(Globals);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ S1_v216 (Il2CppClass<Globals>)+74]");
								bool flag6 = (nint)0 == 0;
								bool flag7 = !flag6;
								num14 = (nint)typeof(Globals);
								if (!flag7)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num14 = (nint)typeof(Globals);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ L1_v27 (Il2CppClass<Globals>)+5C]");
							object obj27 = (nint)0 + (nint)124;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							throw new NullReferenceException();
						}
						if ((nint)obj18 != 4 && (nint)obj18 != 5)
						{
							if ((nint)obj18 == 6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
								object obj28 = 0;
								_ = 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								nint num16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S3_v91 (Il2CppMethodInfo)+C]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ S3_v92+60]");
								object obj30 = 0;
								object obj31 = obj30;
								object obj32 = obj31 & 0x1FFF;
								object obj33 = obj32 + 113696;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v692 @ S4_v8 (should have been resolved before IL gen)");
								nint num17 = (nint)typeof(AwardsManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S0_v111 (Il2CppClass<Missions.AwardsManager>)+BA]");
								object obj34 = (nint)0 & (nint)0x200;
								if (obj34 != null)
								{
									nint num18 = (nint)typeof(AwardsManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ S0_v252 (Il2CppClass<Missions.AwardsManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								MissionsManager instance = MissionsManager.Instance;
								int numberOfFinishedAwardsExactTier = ((AwardsManager)(object)instance).GetNumberOfFinishedAwardsExactTier(awardTierType2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
								obj4 = (object)((IntPtr*)num)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+8]");
								_ = 0;
								object obj36 = default;
								object obj37 = default;
								object obj38 = default;
								object obj35;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 98;
									bool flag8 = obj36 == null;
									obj35 = 99;
									if (flag8)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 86;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 87;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 88;
									obj5 = obj37;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 89;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 90;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
									obj35 = 90;
									obj5 = obj38;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 91;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 92;
									nint num19 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2178 @ S0_v227 (Il2CppClass<Strings>)+BA]");
									object obj39 = (nint)0 & (nint)0x200;
									if (obj39 != null)
									{
										nint num20 = (nint)typeof(Strings);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2199 @ S0_v245 (Il2CppClass<Strings>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
											obj35 = 92;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									obj35 = 97;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
								}
								object obj40 = obj35 - 86;
								if ((nint)obj35 != 86 && (nint)obj40 != 1 && (nint)obj40 != 2 && (nint)obj40 != 3 && (nint)obj40 != 4 && (nint)obj40 != 5 && (nint)obj40 != 6)
								{
									if ((nint)obj40 != 7 && (nint)obj40 != 8 && (nint)obj40 != 9 && (nint)obj40 != 10)
									{
										if ((nint)obj40 == 11 || (nint)obj40 == 12)
										{
											goto IL_13ac;
										}
										if ((nint)obj40 == 13)
										{
											object obj41 = obj10 + 4;
											object obj42 = obj41 + 1;
											obj41 = obj42;
											object obj43 = obj42 << 2;
											object obj44 = obj10 + obj43;
											obj44 = 1426;
										}
									}
									goto IL_1405;
								}
								goto IL_13ac;
							}
							if ((nint)obj18 != 7)
							{
								if ((nint)obj18 == 8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
									object obj45 = 0;
									_ = 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									nint num21 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ S3_v115 (Il2CppMethodInfo)+C]");
									object obj46 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ S3_v116+60]");
									object obj47 = 0;
									object obj48 = obj47;
									object obj49 = obj48 & 0x1FFF;
									object obj50 = obj49 + 113696;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v815 @ S4_v18 (should have been resolved before IL gen)");
									nint num22 = (nint)typeof(AwardsManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ S0_v267 (Il2CppClass<Missions.AwardsManager>)+BA]");
									object obj51 = (nint)0 & (nint)0x200;
									if (obj51 != null)
									{
										nint num23 = (nint)typeof(AwardsManager);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ S0_v430 (Il2CppClass<Missions.AwardsManager>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									MissionsManager instance2 = MissionsManager.Instance;
									int numberOfFinishedAwardsExactTier2 = ((AwardsManager)(object)instance2).GetNumberOfFinishedAwardsExactTier(awardTierType);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
									obj4 = (object)((IntPtr*)num)->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+8]");
									_ = 0;
									object obj53 = default;
									object obj54 = default;
									object obj55 = default;
									object obj52;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 58;
										bool flag9 = obj53 == null;
										obj52 = 59;
										if (flag9)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 46;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 47;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 48;
										obj5 = obj54;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 49;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 50;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
										obj52 = 50;
										obj5 = obj55;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 51;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 52;
										nint num24 = (nint)typeof(Strings);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2215 @ S0_v405 (Il2CppClass<Strings>)+BA]");
										object obj56 = (nint)0 & (nint)0x200;
										if (obj56 != null)
										{
											nint num25 = (nint)typeof(Strings);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2237 @ S0_v423 (Il2CppClass<Strings>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
												obj52 = 52;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										obj52 = 57;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
									}
									object obj57 = obj52 - 46;
									if ((nint)obj52 != 46 && (nint)obj57 != 1 && (nint)obj57 != 2 && (nint)obj57 != 3 && (nint)obj57 != 4 && (nint)obj57 != 5 && (nint)obj57 != 6)
									{
										if ((nint)obj57 != 7 && (nint)obj57 != 8 && (nint)obj57 != 9 && (nint)obj57 != 10)
										{
											if ((nint)obj57 == 11 || (nint)obj57 == 12)
											{
												goto IL_1c07;
											}
											if ((nint)obj57 == 13)
											{
												object obj58 = obj10 + 4;
												object obj59 = obj58 + 1;
												obj58 = obj59;
												object obj60 = obj59 << 2;
												object obj61 = obj10 + obj60;
												obj61 = 1100;
											}
										}
										goto IL_1c60;
									}
									goto IL_1c07;
								}
								if ((nint)obj18 != 9)
								{
									if ((nint)obj18 != 10)
									{
										if ((nint)obj18 != 11 && (nint)obj18 != 12 && (nint)obj18 != 13)
										{
											if ((nint)obj18 != 14)
											{
												if ((nint)obj18 == 15)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
													List<string> list5 = default;
													list5._002Ector();
													list5.Add("Low");
													list5.Add("Medium");
													list5.Add("High");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
													((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list5, (string)2);
													object obj62 = this - -64;
													nint num26 = (nint)typeof(DeviceInfo);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ S1_v539 (Il2CppClass<DeviceInfo>)+BA]");
													object obj63 = (nint)0 & (nint)0x200;
													if (obj63 != null)
													{
														nint num27 = (nint)typeof(DeviceInfo);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1735 @ S1_v546 (Il2CppClass<DeviceInfo>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ S2_v371 (System.Int32)+8]");
													obj7 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
													throw new NullReferenceException();
												}
												if ((nint)obj18 != 16 && (nint)obj18 != 17 && (nint)obj18 != 18)
												{
													if ((nint)obj18 != 19)
													{
														if ((nint)obj18 != 20)
														{
															if ((nint)obj18 != 21 && (nint)obj18 == 22)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																List<string> list6 = default;
																list6._002Ector();
																obj8 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
																throw new NullReferenceException();
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
															List<string> list7 = default;
															list7._002Ector();
															list7.Add("1");
															list7.Add("2");
															list7.Add("5");
															list7.Add("10");
															list7.Add("30");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
															((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list7, null);
															object obj64 = this - -64;
															nint num28 = (nint)typeof(DebugSettingsPopup);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2055 @ S1_v575 (Il2CppClass<DebugSettingsPopup>)+BA]");
															object obj65 = (nint)0 & (nint)0x200;
															bool flag10 = obj65 == null;
															nint num29 = (nint)typeof(DebugSettingsPopup);
															if (!flag10)
															{
																nint num30 = (nint)typeof(DebugSettingsPopup);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ S1_v583 (Il2CppClass<DebugSettingsPopup>)+74]");
																bool flag11 = (nint)0 == 0;
																bool flag12 = !flag11;
																num29 = (nint)typeof(DebugSettingsPopup);
																if (!flag12)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	num29 = (nint)typeof(DebugSettingsPopup);
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ L1_v96 (Il2CppClass<DebugSettingsPopup>)+5C]");
															object obj66 = (nint)0 + (nint)20;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
															int fontSize2 = default;
															((UILabel)obj64).fontSize = fontSize2;
														}
													}
													else
													{
														nint num31 = (nint)typeof(SubwayBenchmarkContainer);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1574 @ S1_v551 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
														object obj67 = (nint)0 & (nint)0x200;
														if (obj67 != null)
														{
															nint num32 = (nint)typeof(SubwayBenchmarkContainer);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ S1_v560 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														string selectedBenchmarkName = SubwayBenchmarkContainer.SelectedBenchmarkName;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
														((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)selectedBenchmarkName, null);
														object obj68 = this - -64;
														SubwayBenchmark selectedBenchmark = SubwayBenchmarkContainer.SelectedBenchmark;
														((UILabel)obj68).fontSize = (int)selectedBenchmark;
													}
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
												List<string> list8 = default;
												list8._002Ector();
												list8.Add("1");
												list8.Add("2");
												list8.Add("5");
												list8.Add("10");
												list8.Add("20");
												list8.Add("30");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
												((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list8, null);
												object obj69 = this - -64;
												nint num33 = (nint)typeof(DebugSettingsPopup);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ S1_v516 (Il2CppClass<DebugSettingsPopup>)+BA]");
												object obj70 = (nint)0 & (nint)0x200;
												bool flag13 = obj70 == null;
												nint num34 = (nint)typeof(DebugSettingsPopup);
												if (!flag13)
												{
													nint num35 = (nint)typeof(DebugSettingsPopup);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1872 @ S1_v524 (Il2CppClass<DebugSettingsPopup>)+74]");
													bool flag14 = (nint)0 == 0;
													bool flag15 = !flag14;
													num34 = (nint)typeof(DebugSettingsPopup);
													if (!flag15)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														num34 = (nint)typeof(DebugSettingsPopup);
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ L1_v88 (Il2CppClass<DebugSettingsPopup>)+5C]");
												object obj71 = (nint)0 + (nint)16;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
												int fontSize3 = default;
												((UILabel)obj69).fontSize = fontSize3;
											}
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										List<string> list9 = default;
										list9._002Ector();
										list9.Add("0.1");
										list9.Add("0.25");
										list9.Add("0.5");
										list9.Add("1");
										list9.Add("2");
										list9.Add("5");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
										((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list9, (string)3);
										object obj72 = this - -64;
										_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1595 @ S2_v337 (T)+10]");
										obj6 = 0;
										OverflowException ex = new OverflowException();
										((UILabel)obj72).fontSize = (int)ex;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									List<string> list10 = default;
									list10._002Ector();
									list10.Add("0.1");
									list10.Add("0.25");
									list10.Add("0.5");
									list10.Add("1");
									list10.Add("2");
									list10.Add("5");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
									((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list10, (string)3);
									object obj73 = this - -64;
									_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1531 @ S2_v316 (T)+14]");
									obj6 = 0;
									OverflowException ex2 = new OverflowException();
									((UILabel)obj73).fontSize = (int)ex2;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								List<string> list11 = default;
								list11._002Ector();
								list11.Add("1");
								list11.Add("2");
								list11.Add("3");
								list11.Add("4");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
								((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list11, null);
								object obj74 = this - -64;
								nint num36 = (nint)typeof(DebugSettingsPopup);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1133 @ S1_v330 (Il2CppClass<DebugSettingsPopup>)+BA]");
								object obj75 = (nint)0 & (nint)0x200;
								if (obj75 != null)
								{
									nint num37 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ S1_v355 (Il2CppClass<DebugSettingsPopup>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								int fontSize4 = default;
								if (DebugSettingsPopup.completeAwardsTiersSelectedTiers != 0)
								{
									nint num38 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1390 @ S1_v341 (Il2CppClass<DebugSettingsPopup>)+BA]");
									object obj76 = (nint)0 & (nint)0x200;
									bool flag16 = obj76 == null;
									nint num39 = (nint)typeof(DebugSettingsPopup);
									if (!flag16)
									{
										nint num40 = (nint)typeof(DebugSettingsPopup);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ S1_v349 (Il2CppClass<DebugSettingsPopup>)+74]");
										bool flag17 = (nint)0 == 0;
										bool flag18 = !flag17;
										num39 = (nint)typeof(DebugSettingsPopup);
										if (!flag18)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											num39 = (nint)typeof(DebugSettingsPopup);
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1473 @ L1_v59 (Il2CppClass<DebugSettingsPopup>)+5C]");
									object obj77 = (nint)0 + (nint)8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
								}
								else
								{
									fontSize4 = (int)"1";
								}
								((UILabel)obj74).fontSize = fontSize4;
							}
						}
					}
				}
			}
			else if (value > (FormFactor)12)
			{
				object obj78 = value - 14;
				if (value != (FormFactor)14)
				{
					if ((nint)obj78 != 1 && (nint)obj78 != 2 && (nint)obj78 != 3 && (nint)obj78 != 4 && (nint)obj78 == 5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						List<string> list12 = default;
						list12._002Ector();
						list12.Add("Default");
						list12.Add("10");
						list12.Add("20");
						list12.Add("30");
						list12.Add("40");
						list12.Add("50");
						list12.Add("60");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
						((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list12, null);
						bool flag19 = IOSViewController._GetIsSimulator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ S0_v80 (System.Boolean)+60]");
						bool flag20 = (nint)0 != 0;
						object obj79 = this - -64;
						if (flag20)
						{
							bool flag21 = IOSViewController._GetIsSimulator();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ S1_v156 (System.Boolean)+64]");
							obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
							int fontSize5 = default;
							((UILabel)obj79).fontSize = fontSize5;
						}
						else
						{
							((UILabel)obj79).fontSize = (int)"Default";
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
					object obj80 = 0;
					_ = 1;
					PerformanceLevel performanceLevel = this.performanceLevel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
					((SelectPopupButton)0).SetSelected((Dictionary<string, string>)performanceLevel);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					List<string> list13 = default;
					list13._002Ector();
					list13.Add("AdColony");
					list13.Add("Flurry");
					list13.Add("InMobi");
					list13.Add("Tapjoy");
					list13.Add("Vungle");
					list13.Add("Chartboost");
					list13.Add("Supersonic");
					list13.Add("Facebook");
					list13.Add("MobVista");
					list13.Add("YeahMobi");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
					((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list13, null);
					object obj81 = this - -64;
					PerformanceLevel performanceLevel2 = this.performanceLevel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ S1_v122 (DeviceInfo+PerformanceLevel)+C]");
					bool flag22 = (nint)0 == 1;
					PerformanceLevel performanceLevel3 = this.performanceLevel;
					int fontSize6;
					if (flag22)
					{
						string text = ((List<string>)performanceLevel3).get_Item(0);
						fontSize6 = (int)text;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1425 @ S2_v85 (DeviceInfo+PerformanceLevel)+C]");
						((IntPtr*)num)->m_value = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						object[] args = default;
						string text2 = $"{args} selected";
						fontSize6 = (int)text2;
					}
					((UILabel)obj81).fontSize = fontSize6;
				}
			}
			else
			{
				object obj82 = value - 8;
				if (value != FormFactor.iPhoneUnknown)
				{
					if ((nint)obj82 != 1 && (nint)obj82 != 2 && (nint)obj82 != 3 && (nint)obj82 == 4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
						object obj83 = 0;
						_ = 1;
						PerformanceLevel performanceLevel4 = this.performanceLevel;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
						((SelectPopupButton)0).SetSelected((Dictionary<string, string>)performanceLevel4);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						List<string> list14 = default;
						list14._002Ector();
						list14.Add("InMobi");
						list14.Add("Chartboost");
						list14.Add("Supersonic");
						list14.Add("Facebook");
						list14.Add("YeahMobi");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
						((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list14, null);
						object obj84 = this - -64;
						PerformanceLevel performanceLevel5 = this.performanceLevel;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ S1_v87 (DeviceInfo+PerformanceLevel)+C]");
						bool flag23 = (nint)0 == 1;
						PerformanceLevel performanceLevel6 = this.performanceLevel;
						int fontSize7;
						if (flag23)
						{
							string text3 = ((List<string>)performanceLevel6).get_Item(0);
							fontSize7 = (int)text3;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ S2_v47 (DeviceInfo+PerformanceLevel)+C]");
							((IntPtr*)num)->m_value = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							object[] args2 = default;
							string text4 = $"{args2} selected";
							fontSize7 = (int)text4;
						}
						((UILabel)obj84).fontSize = fontSize7;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					List<string> list15 = default;
					list15._002Ector();
					list15.Add("qa");
					list15.Add("testology");
					list15.Add("syboanalyticstesting");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
					((PurchaseHandler)0).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list15, null);
					object obj85 = this - -64;
					nint num41 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S1_v60 (Il2CppClass<Globals>)+BA]");
					object obj86 = (nint)0 & (nint)0x200;
					if (obj86 != null)
					{
						nint num42 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S1_v67 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((UILabel)obj85).fontSize = (int)Globals.ONLINESETTINGS_SET;
				}
			}
			goto IL_2b42;
			IL_1405:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v33+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v33+4]");
				object obj87 = (nint)0 << 2;
				object obj88 = obj10 + obj87;
				if ((nint)obj88 == 1426)
				{
					object obj89 = obj10 + 4;
					if ((nint)obj89 > -1)
					{
						object obj90 = obj89 + -1;
						obj89 = obj90;
					}
					goto IL_2f76;
				}
			}
			object obj91 = default;
			if (obj91 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_2f76;
			IL_2fd7:
			Dictionary<string, string> dictionary = default;
			bool flag24 = dictionary.Remove("COLLECT_OLD_TROPHY_ITEMS_MB");
			bool flag25 = dictionary.Remove("COLLECT_OLD_TROPHY_ITEMS_SMB");
			bool flag26 = dictionary.Remove("OWN_X_CHARACTERS");
			bool flag27 = dictionary.Remove("OWN_X_BOARDS");
			bool flag28 = dictionary.Remove("OWN_CHARACTERS_OUTFITS");
			bool flag29 = dictionary.Remove("SCORE_POINTS_SINGLE_RUN_NO_COINS");
			bool flag30 = dictionary.Remove("SCORE_POINTS_SINGLE_RUN_NO_JUMP_OR_ROLL");
			bool flag31 = dictionary.Remove("COLLECT_COINS_SINGLE_RUN");
			bool flag32 = dictionary.Remove("HAVE_SUPERSNICKERS_ACTIVE_X_MIN_IN_A_ROW");
			bool flag33 = dictionary.Remove("COMPLETE_MISSUINS_SINGLE_RUN");
			bool flag34 = dictionary.Remove("SCORE_POINTS_SINGLE_LANE");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
			((SelectPopupButton)0).SetSelected((List<string>)(object)dictionary);
			object obj92 = this - -64;
			nint num43 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2315 @ S1_v405 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj93 = (nint)0 & (nint)0x200;
			if (obj93 != null)
			{
				nint num44 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2325 @ S1_v412 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MissionsManager instance3 = MissionsManager.Instance;
			int numberOfFinishedAwardsExactTier3 = ((AwardsManager)(object)instance3).GetNumberOfFinishedAwardsExactTier(awardTierType);
			Award award = ((List<Award>)numberOfFinishedAwardsExactTier3).get_Item(0);
			AwardStaticData awardData = award._awardData;
			obj5 = awardData.id__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
			IL_2204:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			goto IL_2b42;
			IL_13ac:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj94 = default;
			object obj95 = default;
			bool flag35 = obj94 != obj95;
			object obj97 = default;
			object obj96 = obj97;
			if (!flag35)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				goto IL_1405;
			}
			goto IL_2204;
			IL_2f76:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+3C]");
			List<string> selected = default;
			((SelectPopupButton)0).SetSelected(selected);
			object obj98 = this - -64;
			nint num45 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1922 @ S1_v249 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj99 = (nint)0 & (nint)0x200;
			if (obj99 != null)
			{
				nint num46 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1976 @ S1_v256 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MissionsManager instance4 = MissionsManager.Instance;
			int numberOfFinishedAwardsExactTier4 = ((AwardsManager)(object)instance4).GetNumberOfFinishedAwardsExactTier(awardTierType2);
			Award award2 = ((List<Award>)numberOfFinishedAwardsExactTier4).get_Item(0);
			AwardStaticData awardData2 = award2._awardData;
			obj5 = awardData2.id__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
			IL_2b42:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+4C]");
			if ((nint)0 != 0)
			{
				object obj100 = this - -64;
				PerformanceLevel performanceLevel7 = this.performanceLevel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S1_v34 (DeviceInfo+PerformanceLevel)+C]");
				bool flag36 = (nint)0 == 1;
				PerformanceLevel performanceLevel8 = this.performanceLevel;
				int fontSize8;
				if (flag36)
				{
					string text5 = ((List<string>)performanceLevel8).get_Item(0);
					fontSize8 = (int)text5;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S2_v8 (DeviceInfo+PerformanceLevel)+C]");
					((IntPtr*)num)->m_value = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] args3 = default;
					string text6 = $"{args3} selected";
					fontSize8 = (int)text6;
				}
				((UILabel)obj100).fontSize = fontSize8;
			}
			return;
			IL_1c07:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj101 = default;
			bool flag37 = obj94 != obj101;
			object obj102 = default;
			obj96 = obj102;
			if (!flag37)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				goto IL_1c60;
			}
			goto IL_2204;
			IL_1c60:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v33+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v33+4]");
				object obj103 = (nint)0 << 2;
				object obj104 = obj10 + obj103;
				if ((nint)obj104 == 1100)
				{
					object obj105 = obj10 + 4;
					if ((nint)obj105 > -1)
					{
						object obj106 = obj105 + -1;
						obj105 = obj106;
					}
					goto IL_2fd7;
				}
			}
			object obj107 = default;
			if (obj107 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_2fd7;
		}
	}

	public bool isHighres
	{
		get
		{
			return (byte)formFactor__BackingField != 0;
		}
		private set
		{
			formFactor__BackingField = (value ? FormFactor.iPad : FormFactor.iPhone);
		}
	}

	public int gpuScore
	{
		get
		{
			return isHighres__BackingField ? 1 : 0;
		}
		private set
		{
			int num = value & 1;
			isHighres__BackingField = (byte)num != 0;
		}
	}

	public GPUCategory gpuCategory
	{
		get
		{
			return (GPUCategory)gpuScore__BackingField;
		}
		private set
		{
			gpuScore__BackingField = (int)value;
		}
	}

	public static DeviceInfo Instance
	{
		get
		{
			if (CountdownPopupManager._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				CountdownPopupManager instance = default;
				CountdownPopupManager._instance = instance;
			}
			return (DeviceInfo)(object)CountdownPopupManager._instance;
		}
	}

	private DeviceInfo()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private unsafe void SetDeviceInfoForUnknownIphone()
	{
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02c3: Expected Obj, but got I4
		//IL_02d1: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_03a0: Expected VT, but got I4
		//IL_03af: Expected VT, but got I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_016f: Expected Obj, but got F4
		//IL_03e5: Expected F4, but got I
		//IL_03e0: Expected native int or pointer, but got VT
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_0409: Expected I, but got Obj
		//IL_041f: Expected Obj, but got I
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_0182: Expected I, but got Obj
		//IL_0161: Expected Obj, but got F4
		//IL_010b: Expected I, but got Obj
		//IL_0153: Expected Obj, but got F4
		//IL_021a: Expected I, but got Obj
		//IL_029d: Expected I4, but got Obj
		//IL_02a7: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<DeviceInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v89 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Shader.SetGlobalVector(ShaderBackgroundBlendSrcPropName, (Vector4)5);
		Shader.SetGlobalVector(ShaderBackgroundBlendDstPropName, (Vector4)10);
		object obj4 = this + 12;
		string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
		obj4 = graphicsDeviceName;
		int sleepTimeout = Screen.sleepTimeout;
		bool flag = sleepTimeout > 480;
		isHighres__BackingField = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v76 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v85 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = ((!DeviceUtility.GetIOSOtherAudioPlaying()) ? ((object)1000f) : ((object)900f));
		}
		else
		{
			obj = 2.1474836E+09f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		Color color = default;
		((Color*)(nint)color)->b = num5;
		_ = 0;
		object obj6 = color + 16;
		obj6 = this;
		nint num6 = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v39 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v70 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = obj;
		GizmosColor gizmosColor = (GizmosColor)(obj2 + 8);
		gizmosColor = (GizmosColor)obj2;
		gizmosColor._002Ector(color);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7F26");
		int num8 = default;
		gpuScore__BackingField = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7F27");
		GPUCategory gPUCategory = default;
		gpuCategory__BackingField = gPUCategory;
		nint num9 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v50 (Il2CppClass<Globals>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v64 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			List<bool> hasLoggedWeeklyHuntPeriod = EventsSave.hasLoggedWeeklyHuntPeriod;
			if ((nint)hasLoggedWeeklyHuntPeriod > -1)
			{
				List<bool> hasLoggedWeeklyHuntPeriod2 = EventsSave.hasLoggedWeeklyHuntPeriod;
				_performanceLevel = (PerformanceLevel)hasLoggedWeeklyHuntPeriod2;
				((DebugSave)(-1))._002Ector();
			}
		}
	}

	private void SetDeviceInfoForUnknownIpad()
	{
		int sleepTimeout = Screen.sleepTimeout;
		if (sleepTimeout > 960)
		{
			_performanceLevel = PerformanceLevel.High;
		}
		else
		{
			_performanceLevel = PerformanceLevel.Low;
		}
		formFactor__BackingField = FormFactor.iPhoneUnknown;
		int sleepTimeout2 = Screen.sleepTimeout;
		bool flag = sleepTimeout2 > 480;
		isHighres__BackingField = flag;
		dpi__BackingField = 300f;
	}

	private void LogUnknownGPU(string gpuName)
	{
		//IL_000a: Expected I4, but got Obj
		gpuCategory__BackingField = (GPUCategory)gpuName;
	}

	public bool IsDeviceCapablePerformance(PerformanceLevel perfLevel)
	{
		//IL_0123: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00c6: Expected I4, but got Obj
		//IL_0016: Expected Obj, but got I
		//IL_0028: Expected I, but got Obj
		//IL_003e: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_0069: Expected I, but got Obj
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+68]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+C]");
			if ((nint)0 > (nint)perfLevel)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+24]");
			int layer = ((GameObject)0).layer;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+4C]");
			UISprite item = UnityEngine.Object.Instantiate((UISprite)0, (Transform)layer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+48]");
			Vector2 localSize = ((UIWidget)0).localSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+68]");
			((List<UISprite>)0).Add(item);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DeviceInfo)+68]");
		return (byte)(int)((List<UISprite>)0).get_Item((int)perfLevel) != 0;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC87");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"DeviceInfo: ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
