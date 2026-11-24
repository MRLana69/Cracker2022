using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Ads;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Subway.Info;
using UI;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

public static class AssetBundleCache
{
	private enum CachingAction
	{
		Add,
		Remove,
		ClearCache
	}

	private static readonly string ASSET_BUNDLE_CACHE_PATH;

	private const string CACHED_VERSION_INFO_FILE_NAME = "CachedBundlesVersionInfo";

	private const string DEBUG_TAG = "[AssetBundleCache]: ";

	private static Dictionary<string, int> _cachedBundlesVersionInfo;

	private static bool _isPerformingBulkCaching;

	public static void Initialize()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_019a: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0229: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AdProviderInfo> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdProviderInfo adProviderInfo = default;
		object obj = adProviderInfo + 16;
		obj = "facebook";
		adProviderInfo.priority__BackingField = 4;
		adProviderInfo.weight__BackingField = 100f;
		list.Add(adProviderInfo);
		AdSettingsProvider._allInterstitialProviders = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AdProviderInfo> list2 = default;
		list2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdProviderInfo adProviderInfo2 = default;
		object obj2 = adProviderInfo2 + 16;
		obj2 = "flurry";
		adProviderInfo2.priority__BackingField = 5;
		adProviderInfo2.weight__BackingField = 100f;
		list2.Add(adProviderInfo2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdProviderInfo adProviderInfo3 = default;
		object obj3 = adProviderInfo3 + 16;
		obj3 = "facebook";
		adProviderInfo3.priority__BackingField = 8;
		adProviderInfo3.weight__BackingField = 100f;
		list2.Add(adProviderInfo3);
		nint num = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v36 (Il2CppClass<AdSettingsProvider>)+5C]");
		object obj4 = (nint)0 + (nint)4;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list3 = default;
		list3._002Ector();
		nint num2 = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v43 (Il2CppClass<AdSettingsProvider>)+5C]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list4 = default;
		list4._002Ector();
		nint num3 = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v50 (Il2CppClass<AdSettingsProvider>)+5C]");
		object obj6 = (nint)0 + (nint)12;
		obj6 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S3_v3+60]");
		object obj8 = 0;
		object obj9 = obj8;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v122 @ S4_v4 (should have been resolved before IL gen)");
		nint num5 = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v57 (Il2CppClass<AdSettingsProvider>)+5C]");
		object obj12 = (nint)0 + (nint)16;
		object obj13 = default;
		obj12 = obj13;
	}

	public unsafe static bool CacheAssetBundle(string bundleName, int version, byte[] bytes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0024: Expected I8, but got VT
		//IL_001f: Expected native int or pointer, but got VT
		//IL_002c: Expected Obj, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_005d: Expected Ref, but got VT
		//IL_006e: Expected Obj, but got I8
		//IL_008a: Invalid comparison between F8 and Obj
		object obj = default;
		DateTime dateTime = (DateTime)(obj + 16);
		DateTime utcNow = CDateTime.UtcNow;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)utcNow;
		obj = version;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 24);
		formatProvider = (IFormatProvider)obj;
		object obj2 = obj + 8;
		long num = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj2 = num;
		double num2 = (double)obj2 * 1E-07;
		return System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2) > System.Runtime.CompilerServices.Unsafe.As<byte[], UIntPtr>(ref bytes);
	}

	public static bool CacheEditorBundle(string bundleName, int version, string bundlePath)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected Obj, but got Unknown
		//IL_06b5: Expected I, but got Obj
		//IL_06cb: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0736: Expected I, but got Obj
		//IL_074c: Expected Obj, but got I
		//IL_0801: Expected I, but got Obj
		//IL_0817: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_021a: Expected I, but got Obj
		//IL_0267: Expected I, but got Obj
		//IL_00eb: Expected I, but got Obj
		//IL_0320: Expected I, but got Obj
		//IL_0336: Expected Obj, but got I
		//IL_077b: Expected Obj, but got I4
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_0361: Expected I, but got Obj
		//IL_01b4: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v242 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj5 = default;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v90 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v132 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj7 = default;
			if ((nint)obj7 > version)
			{
				goto IL_0685;
			}
			nint num5 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v107 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v122 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		nint num7 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v32 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v80 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		nint num9 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v40 (Il2CppClass<System.IO.Path>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num10 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v70 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num11 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v54 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v60 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AssetBundleManager)(object)bundleName).UnloadAssetBundle((string)version, false);
		goto IL_0685;
		IL_0685:
		return true;
	}

	public static void StartBulkCaching()
	{
		//IL_0124: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_0175: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00d7: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DirectoryInfo directoryInfo = default;
		directoryInfo.Delete((byte)(int)ASSET_BUNDLE_CACHE_PATH != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj2 = default;
		if (obj2 == null)
		{
			directoryInfo.Delete();
		}
		nint num3 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v26 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveCachedBundlesVersionInfo();
	}

	public static void EndBulkCaching()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_isPerformingBulkCaching = true;
	}

	private static void RecordCachingInfo(string bundleName, int version, CachingAction action)
	{
		((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)version, (int)action, (Action)(object)"AdSystem2.0_VideoAds Providers Show", (CharacterModelRequest)(object)"Video completes");
	}

	public static AssetBundle LoadAssetBundle(string bundleName, int version)
	{
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected Obj, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07a9: Expected Obj, but got I4
		//IL_0668: Expected I, but got Obj
		//IL_067e: Expected Obj, but got I
		//IL_002c: Expected Obj, but got I
		//IL_002c: Expected Obj, but got I
		//IL_0704: Expected I, but got Obj
		//IL_071a: Expected Obj, but got I
		//IL_06a9: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_0745: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I
		//IL_00a2: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_0400: Invalid comparison between Obj and F4
		//IL_041d: Invalid comparison between Obj and F4
		//IL_043e: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I
		//IL_01e4: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_020c: Expected I, but got Obj
		//IL_0222: Expected Obj, but got I
		//IL_0329: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_0351: Expected I, but got Obj
		//IL_0367: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		//IL_0542: Invalid comparison between Obj and F4
		//IL_055f: Invalid comparison between Obj and F4
		//IL_0580: Expected Obj, but got I4
		//IL_024d: Expected I, but got Obj
		//IL_0493: Expected I, but got Obj
		//IL_04a9: Expected Obj, but got I
		//IL_0392: Expected I, but got Obj
		//IL_06f1: Expected Obj, but got I4
		//IL_05d5: Expected I, but got Obj
		//IL_05eb: Expected Obj, but got I
		//IL_04d4: Expected I, but got Obj
		//IL_0616: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		CameraSettings cameraSettings = (CameraSettings)(obj2 + 8);
		cameraSettings = (CameraSettings)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+2C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bundleName @ L0 (System.String)+10]");
			RenderTexture renderTextureFor = ((RenderTextureManager)null).GetRenderTextureFor((GameObject)num, (AnimationClip)0, cameraSettings, true);
			if ((object)renderTextureFor == null)
			{
				string text = string.Format("text_{0}", (object[])(object)"Title");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v72+8]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				nint num2 = (nint)cameraSettings;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v76 (Il2CppClass<UI.CameraSettings>)+8]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				nint num3 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v161 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v170 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
				string format = default;
				object arg = default;
				string text2 = string.Format((IFormatProvider)(object)"total: {0} after: {1} - country:{2}", format, arg, unfilteredLocale);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+18]");
				RenderTexture renderTextureFor2 = ((RenderTextureManager)null).GetRenderTextureFor((GameObject)0, (AnimationClip)bundleName.m_firstChar, cameraSettings, false);
				if ((object)renderTextureFor2 == null)
				{
					string text3 = string.Format("text_{0}", (object[])(object)"Call To Action");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+18]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v60+8]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					nint num5 = (nint)cameraSettings;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v64 (Il2CppClass<UI.CameraSettings>)+8]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					nint num6 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v136 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num7 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v145 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string unfilteredLocale2 = DeviceUtility.GetUnfilteredLocale();
					string format2 = default;
					object arg2 = default;
					string text4 = string.Format((IFormatProvider)(object)"total: {0} after: {1} - country:{2}", format2, arg2, unfilteredLocale2);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+10]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bundleName @ L0 (System.String)+14]");
					RenderTexture renderTextureFor3 = ((RenderTextureManager)null).GetRenderTextureFor((GameObject)num8, (AnimationClip)0, cameraSettings, false);
					if ((object)renderTextureFor3 == null)
					{
						string text5 = string.Format("text_{0}", (object[])(object)"Body");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [version @ L1 (System.Int32)+10]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v48+8]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						nint num9 = (nint)cameraSettings;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v52 (Il2CppClass<UI.CameraSettings>)+8]");
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						nint num10 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v111 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num11 = (nint)typeof(DeviceUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v120 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string unfilteredLocale3 = DeviceUtility.GetUnfilteredLocale();
						string format3 = default;
						object arg3 = default;
						string text6 = string.Format((IFormatProvider)(object)"total: {0} after: {1} - country:{2}", format3, arg3, unfilteredLocale3);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj10 = default;
						object obj11 = default;
						object obj9 = obj10 / obj11;
						bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.1f);
						bool flag2 = !flag;
						bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.9f);
						bool flag4 = !flag3;
						object obj12 = flag2 | flag4;
						if (obj12 != null)
						{
							string text7 = string.Format("image_{0}", (object[])(object)"Icon");
							obj = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							nint num12 = (nint)typeof(DeviceUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v86 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
							object obj13 = (nint)0 & (nint)0x200;
							if (obj13 != null)
							{
								nint num13 = (nint)typeof(DeviceUtility);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v95 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string unfilteredLocale4 = DeviceUtility.GetUnfilteredLocale();
							string format4 = default;
							string text8 = string.Format((IFormatProvider)(object)"ratio: {0} - country:{1}", format4, unfilteredLocale4);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							object obj15 = default;
							object obj16 = default;
							object obj14 = obj15 / obj16;
							bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2f);
							bool flag6 = !flag5;
							bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.8f);
							bool flag8 = !flag7;
							object obj17 = flag6 | flag8;
							if (obj17 == null)
							{
								return (AssetBundle)1;
							}
							string text9 = string.Format("image_{0}", (object[])(object)"Cover");
							obj = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							nint num14 = (nint)typeof(DeviceUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v65 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
							object obj18 = (nint)0 & (nint)0x200;
							if (obj18 != null)
							{
								nint num15 = (nint)typeof(DeviceUtility);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v74 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string unfilteredLocale5 = DeviceUtility.GetUnfilteredLocale();
							string format5 = default;
							string text10 = string.Format((IFormatProvider)(object)"ratio: {0} - country:{1}", format5, unfilteredLocale5);
						}
					}
				}
			}
		}
		else
		{
			nint num16 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v27 (Il2CppClass<Flurry>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num17 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v31 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		nint num18 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v17 (Il2CppClass<Flurry>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num19 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v22 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return null;
	}

	public static AssetBundleCreateRequest LoadAssetBundleAsync(string bundleName, int version)
	{
		//IL_02e8: Expected I, but got Obj
		//IL_02fe: Expected Obj, but got I
		//IL_025a: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_029b: Expected I, but got Obj
		//IL_0329: Expected I, but got Obj
		//IL_033f: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		//IL_03fa: Expected I, but got Obj
		//IL_0410: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I4
		//IL_01b5: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got I
		//IL_01f6: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v8 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v45 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (RemoveFromCache(bundleName, version))
		{
			nint num3 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v12 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v47 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v27 (Il2CppClass<System.IO.Path>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v41 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(ASSET_BUNDLE_CACHE_PATH, bundleName);
			AssetBundle assetBundle = ((AssetBundleCreateRequest)flag).assetBundle;
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (assetBundle != null)
			{
				object obj5 = version;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text2 = default;
				string text = bundleName + ";" + text2;
				nint num9 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v36 (Il2CppClass<Flurry>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num10 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v39 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
			return (AssetBundleCreateRequest)(object)assetBundle;
		}
		object obj7 = ((IConvertible)"Attemping to load bundle ").ToType((Type)(object)bundleName, (IFormatProvider)(object)" but it's not cached. Aborting.");
		nint num11 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v16 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v21 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AssetBundleManager)obj7)._002Ector();
		return null;
	}

	public static int GetVersionForCachedBundle(string bundleName)
	{
		return 0;
	}

	public static bool IsAssetBundleCached(string bundleName, int version)
	{
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0193: Expected I, but got Obj
		//IL_0221: Expected I, but got Obj
		//IL_0237: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I4
		//IL_02c1: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (RemoveFromCache(bundleName, version))
		{
			nint num3 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v27 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v18 (Il2CppClass<System.IO.Path>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v24 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(ASSET_BUNDLE_CACHE_PATH, bundleName);
			AssetBundle assetBundle = AssetBundle.LoadFromFile((string)flag);
			return (byte)(int)assetBundle != 0;
		}
		object obj4 = ((IConvertible)"Attemping to load bundle ").ToType((Type)(object)bundleName, (IFormatProvider)(object)" but it's not cached. Aborting.");
		nint num7 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v7 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v12 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AssetBundleManager)obj4)._002Ector();
		return false;
	}

	public static bool RemoveFromCache(string bundleName, int version)
	{
		//IL_0223: Expected I, but got Obj
		//IL_0239: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0264: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I4
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_01ba: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v57 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			nint num4 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v18 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v51 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num6 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v8 (Il2CppClass<System.IO.Path>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v25 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(ASSET_BUNDLE_CACHE_PATH, bundleName);
			FileAttributes attributes = File.GetAttributes((string)flag);
			nint num8 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v15 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			bool flag2 = obj10 != null;
			if (attributes != 0)
			{
				if (flag2)
				{
					nint num9 = (nint)typeof(AssetBundleCache);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v45 (Il2CppClass<AssetBundleCache>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num10 = _cachedBundlesVersionInfo.get_Item(bundleName);
				return num10 == version;
			}
			if (flag2)
			{
				nint num11 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v34 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((AssetBundleManager)(object)"Asset Bundle file was not found in the cache. Correcting cache info.")._002Ector();
			string absolutePath = AssetBundleManager.GetAbsolutePath(bundleName);
			((AssetBundleManager)(object)bundleName).UnloadAssetBundle(absolutePath, true);
			return false;
		}
		return false;
	}

	public static void ClearCache()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_isPerformingBulkCaching = false;
		AssetBundleCache._002Ecctor();
	}

	private static void LoadCachedBundlesVersionInfo()
	{
		//IL_01e7: Expected I, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0232: Expected I4, but got Obj
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0199: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v53 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!Directory.IsRootDirectory(ASSET_BUNDLE_CACHE_PATH))
		{
			return;
		}
		nint num3 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v47 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DirectoryInfo directoryInfo = default;
		directoryInfo.Delete((byte)(int)ASSET_BUNDLE_CACHE_PATH != 0);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		object obj3 = directories + 12;
		object obj4 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			object obj5 = directories + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			object obj8 = obj4 + 1;
			obj4 = obj8;
		}
		nint num5 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v34 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v40 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AssetBundleManager)(object)"").UnloadAssetBundle((string)null, true);
	}

	private static void SaveCachedBundlesVersionInfo()
	{
		//IL_02d6: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got I
		//IL_03c4: Expected I, but got Obj
		//IL_03da: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_0251: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_03a9: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_026d: Expected I, but got Obj
		//IL_029d: Expected I, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0324: Expected I, but got Obj
		//IL_033a: Expected Obj, but got I
		//IL_0357: Expected I, but got Obj
		//IL_02c3: Expected I, but got Obj
		//IL_037b: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0157: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_01ad: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v51 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v32 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot(ASSET_BUNDLE_CACHE_PATH, "CachedBundlesVersionInfo");
		if (File.GetAttributes((string)flag) != 0)
		{
			byte[] array = File.ReadAllBytes((string)flag);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num5 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v19 (Il2CppClass<AssetBundleManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(AssetBundleManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v28 (Il2CppClass<AssetBundleManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AssetBundleManager assetBundleManager = default;
			string preCachedBundles = assetBundleManager.GetPreCachedBundles();
			nint num7 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v37 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag2 = obj4 == null;
			nint num8 = (nint)typeof(AssetBundleCache);
			if (!flag2)
			{
				nint num9 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v45 (Il2CppClass<AssetBundleCache>)+74]");
				bool flag3 = (nint)0 == 0;
				bool flag4 = !flag3;
				num8 = (nint)typeof(AssetBundleCache);
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num8 = (nint)typeof(AssetBundleCache);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ L0_v12 (Il2CppClass<AssetBundleCache>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = preCachedBundles;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S3_v4+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v77 @ S4_v5 (should have been resolved before IL gen)");
		nint num11 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v20 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		bool flag5 = obj11 == null;
		nint num12 = (nint)typeof(AssetBundleCache);
		if (!flag5)
		{
			nint num13 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v27 (Il2CppClass<AssetBundleCache>)+74]");
			bool flag6 = (nint)0 == 0;
			bool flag7 = !flag6;
			num12 = (nint)typeof(AssetBundleCache);
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num12 = (nint)typeof(AssetBundleCache);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ L0_v8 (Il2CppClass<AssetBundleCache>)+5C]");
		object obj12 = (nint)0 + (nint)4;
		object obj13 = default;
		obj12 = obj13;
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected Obj, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v21 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = DateTime.MinValue;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		object obj4 = msg + 40;
		obj4 = "";
		_ = 19;
	}

	private static void LogWarning(string msg)
	{
	}

	private static void LogError(string msg)
	{
	}

	static AssetBundleCache()
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0148: Expected I4, but got Obj
		//IL_0148: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v15 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot(ASSET_BUNDLE_CACHE_PATH, "CachedBundlesVersionInfo");
		nint num5 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v4 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v10 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, int> dictionary = AssetBundleManager.ParseAssetBundleVersionData((string)(object)_cachedBundlesVersionInfo);
		((FileStream)flag).WriteByte((byte)(int)dictionary);
	}
}
