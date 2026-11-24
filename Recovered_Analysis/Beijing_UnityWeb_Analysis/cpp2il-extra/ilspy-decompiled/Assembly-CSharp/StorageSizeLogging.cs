using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

public static class StorageSizeLogging
{
	private static long _currentSize;

	private const string DATA_MAIN = "Data";

	private const string CACHE_MAIN = "Cache";

	private const string ASSETBUNDLES_MAIN = "AssetBundles";

	private static Dictionary<string, string> _androidProviderPathsDictionary;

	private static Dictionary<string, string> _iOSProviderPathsDictionary;

	private static string _userDataPath;

	private static string _userExternalDataPath;

	private static string _userCachePath;

	private static string _userTemporaryPath;

	private static string _assetBundlesPath;

	private const string STORAGE_SIZE_LOGGING_ENABLED_KEY = "storage_logging_enabled";

	private const bool DEFAULT_STORAGE_SIZE_LOGGING_SETTING = false;

	private static int _dataSize;

	private static int _cacheSize;

	private static int _assetBundlesSize;

	private static bool _hasFlurryLoggedInSession;

	private static List<int> _buckets;

	public static int DataSize
	{
		get
		{
			//IL_049f: Expected I, but got Obj
			//IL_04b5: Expected Obj, but got I
			//IL_0620: Expected I, but got Obj
			//IL_0636: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0452: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_0534: Expected I, but got Obj
			//IL_054a: Expected Obj, but got I
			//IL_0405: Expected I, but got Obj
			//IL_0264: Expected I, but got Obj
			//IL_027a: Expected Obj, but got I
			//IL_0297: Expected I, but got Obj
			//IL_034d: Expected I, but got Obj
			//IL_0363: Expected Obj, but got I
			//IL_0380: Expected I, but got Obj
			//IL_05ae: Expected Obj, but got I
			//IL_0145: Expected I, but got Obj
			//IL_015b: Expected Obj, but got I
			//IL_0178: Expected I, but got Obj
			//IL_05d2: Expected Obj, but got I
			//IL_02b3: Expected I, but got Obj
			//IL_02e3: Expected I, but got Obj
			//IL_0518: Expected Obj, but got I
			//IL_039c: Expected I, but got Obj
			//IL_03cc: Expected I, but got Obj
			//IL_0194: Expected I, but got Obj
			//IL_01c4: Expected I, but got Obj
			//IL_0309: Expected I, but got Obj
			//IL_03f2: Expected I, but got Obj
			//IL_01ea: Expected I, but got Obj
			nint num = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v123 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(IPhoneXSupport._hasCheckedOnce ? 1u : 0u) != 0)
			{
				nint num3 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v31 (Il2CppClass<IPhoneXSupport>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(IPhoneXSupport);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v117 (Il2CppClass<IPhoneXSupport>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				IPhoneXSupport._isiPhoneXDevice = false;
				string dataPath = Application.dataPath;
				if ((nint)dataPath != 7)
				{
					string dataPath2 = Application.dataPath;
					if (dataPath2 != null)
					{
						string dataPath3 = Application.dataPath;
						if ((nint)dataPath3 == 8)
						{
							nint num5 = (nint)typeof(IPhoneXSupport);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v104 (Il2CppClass<IPhoneXSupport>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							bool flag = obj3 == null;
							nint num6 = (nint)typeof(IPhoneXSupport);
							if (!flag)
							{
								nint num7 = (nint)typeof(IPhoneXSupport);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v111 (Il2CppClass<IPhoneXSupport>)+74]");
								bool flag2 = (nint)0 == 0;
								bool flag3 = !flag2;
								num6 = (nint)typeof(IPhoneXSupport);
								if (!flag3)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num6 = (nint)typeof(IPhoneXSupport);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ L0_v21 (Il2CppClass<IPhoneXSupport>)+5C]");
							OffsetAnimation offsetAnimation = (OffsetAnimation)((nint)0 + (nint)8);
							offsetAnimation.Start();
						}
						goto IL_0526;
					}
				}
				int sleepTimeout = Screen.sleepTimeout;
				if (sleepTimeout == 2436)
				{
					int height = Screen.height;
					if (height == 1125)
					{
						nint num8 = (nint)typeof(IPhoneXSupport);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v83 (Il2CppClass<IPhoneXSupport>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						bool flag4 = obj4 == null;
						nint num9 = (nint)typeof(IPhoneXSupport);
						if (!flag4)
						{
							nint num10 = (nint)typeof(IPhoneXSupport);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v90 (Il2CppClass<IPhoneXSupport>)+74]");
							bool flag5 = (nint)0 == 0;
							bool flag6 = !flag5;
							num9 = (nint)typeof(IPhoneXSupport);
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num9 = (nint)typeof(IPhoneXSupport);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ L0_v17 (Il2CppClass<IPhoneXSupport>)+5C]");
						OffsetAnimation offsetAnimation2 = (OffsetAnimation)((nint)0 + (nint)8);
						offsetAnimation2.Start();
						goto IL_0526;
					}
				}
				int sleepTimeout2 = Screen.sleepTimeout;
				if (sleepTimeout2 == 2688)
				{
					int height2 = Screen.height;
					if (height2 == 1242)
					{
						nint num11 = (nint)typeof(IPhoneXSupport);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v66 (Il2CppClass<IPhoneXSupport>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						bool flag7 = obj5 == null;
						nint num12 = (nint)typeof(IPhoneXSupport);
						if (!flag7)
						{
							nint num13 = (nint)typeof(IPhoneXSupport);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v73 (Il2CppClass<IPhoneXSupport>)+74]");
							bool flag8 = (nint)0 == 0;
							bool flag9 = !flag8;
							num12 = (nint)typeof(IPhoneXSupport);
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num12 = (nint)typeof(IPhoneXSupport);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ L0_v14 (Il2CppClass<IPhoneXSupport>)+5C]");
						OffsetAnimation offsetAnimation3 = (OffsetAnimation)((nint)0 + (nint)8);
						offsetAnimation3.Start();
					}
				}
				goto IL_0526;
			}
			goto IL_0612;
			IL_0612:
			nint num14 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v16 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num15 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v24 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return IPhoneXSupport._isiPhoneXDevice ? 1 : 0;
			IL_0526:
			nint num16 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v42 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num17 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v48 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IPhoneXSupport._hasCheckedOnce = true;
			goto IL_0612;
		}
	}

	public static int CacheSize
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return _dataSize;
		}
	}

	public static int AssetBundlesSize
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return _cacheSize;
		}
	}

	private static bool _isStorageLoggingEnabled
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return _hasFlurryLoggedInSession;
		}
	}

	public static bool HasFlurryLoggedInSession()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)_assetBundlesSize != 0;
	}

	public static void RegisterStorageUsage()
	{
	}

	private static void InitDevicePaths()
	{
		//IL_049c: Expected I, but got Obj
		//IL_04b2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0556: Expected I, but got Obj
		//IL_056c: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_044f: Expected I, but got Obj
		//IL_0322: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_05b2: Expected I4, but got Obj
		//IL_0363: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_03ec: Expected I4, but got Obj
		//IL_021d: Expected I4, but got Obj
		//IL_01d5: Expected I, but got Obj
		//IL_0432: Expected I4, but got Obj
		//IL_0271: Expected I4, but got Obj
		//IL_02b7: Expected I4, but got Obj
		nint num = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v148 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Utils.GetXorRandomValueForThisSession() == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v144 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		StorageSizeLogging._002Ecctor();
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			nint num5 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v87 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v140 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!DeviceUtility.GetIOSOtherAudioPlaying())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<string> list = default;
				list._002Ector();
				nint num7 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v97 (Il2CppClass<StorageSizeLogging>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(StorageSizeLogging);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v134 (Il2CppClass<StorageSizeLogging>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				list.Add(_userDataPath);
				list.Add(_userExternalDataPath);
				Attribute customAttribute = Utils.GetCustomAttribute((Type)(object)"Data", (Type)(object)list);
				_dataSize = (int)customAttribute;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<string> list2 = default;
				list2._002Ector();
				list2.Add(_userCachePath);
				list2.Add(_userTemporaryPath);
				Attribute customAttribute2 = Utils.GetCustomAttribute((Type)(object)"Cache", (Type)(object)list2);
				_cacheSize = (int)customAttribute2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<string> list3 = default;
				list3._002Ector();
				list3.Add(_assetBundlesPath);
				Attribute customAttribute3 = Utils.GetCustomAttribute((Type)(object)"AssetBundles", (Type)(object)list3);
				_assetBundlesSize = (int)customAttribute3;
				VerifyPathAndAddFileSizes((string)(object)_androidProviderPathsDictionary);
				goto IL_0548;
			}
		}
		string dataPath2 = Application.dataPath;
		if ((nint)dataPath2 == 8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list4 = default;
			list4._002Ector();
			nint num9 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v44 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v80 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			list4.Add(_userDataPath);
			Attribute customAttribute4 = Utils.GetCustomAttribute((Type)(object)"Data", (Type)(object)list4);
			_dataSize = (int)customAttribute4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list5 = default;
			list5._002Ector();
			list5.Add(_userCachePath);
			list5.Add(_userTemporaryPath);
			Attribute customAttribute5 = Utils.GetCustomAttribute((Type)(object)"Cache", (Type)(object)list5);
			_cacheSize = (int)customAttribute5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list6 = default;
			list6._002Ector();
			list6.Add(_assetBundlesPath);
			Attribute customAttribute6 = Utils.GetCustomAttribute((Type)(object)"AssetBundles", (Type)(object)list6);
			_assetBundlesSize = (int)customAttribute6;
			VerifyPathAndAddFileSizes((string)(object)_iOSProviderPathsDictionary);
		}
		goto IL_0548;
		IL_0548:
		nint num11 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v24 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v30 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_hasFlurryLoggedInSession = true;
	}

	private static int LogOverallUsage(string generalLocation, List<string> paths)
	{
		//IL_000e: Expected I, but got Obj
		//IL_014a: Expected Obj, but got VT
		//IL_0169: Expected I4, but got VT
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_00ed: Expected VT, but got Obj
		_0021_00210 componentInChildren = default;
		Transform parentInternal = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			while (true)
			{
				int num2 = ((ComputeShader)componentInChildren).FindKernel(null);
				_0021_00210 val = componentInChildren;
				if (num2 == 0)
				{
					parentInternal = parentInternal.parentInternal;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
					{
						componentInChildren = (_0021_00210)((Component)parentInternal).GetComponentInChildren<T>();
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							break;
						}
						continue;
					}
					val = (_0021_00210)null;
				}
				return (int)val;
			}
		}
	}

	private static void LogProviderUsage(Dictionary<string, string> providerDictionary)
	{
	}

	private static string GetAppropiateBucketSize(long size)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private static void VerifyPathAndAddFileSizes(string directoryPath)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0332: Expected Obj, but got I4
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I4
		//IL_0055: Expected I, but got Obj
		//IL_006b: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I
		//IL_03a8: Expected I8, but got I4
		//IL_0096: Expected I, but got Obj
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_011f: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			nint num = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v82 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v127 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			_currentSize = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			long num3 = _currentSize >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D7");
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v116 (Il2CppClass<Flurry>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v120 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
		}
		object obj9 = obj5 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj5 + obj11;
		obj12 = 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj5 + obj13;
			if ((nint)obj14 == 88)
			{
				object obj15 = obj5 + 4;
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

	private static void WalkDirectoryTree(DirectoryInfo directoryInfo)
	{
		//IL_001c: Expected I4, but got Obj
		//IL_002f: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		if (!Directory.IsRootDirectory((string)(object)directoryInfo))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DirectoryInfo directoryInfo2 = default;
		directoryInfo2.Delete((byte)(int)directoryInfo != 0);
		nint num = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((TakeScreenshot)(object)directoryInfo2).Start();
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		_ = context.m_CachedPtr;
		object obj = msg + 24;
		obj = context;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}

	static StorageSizeLogging()
	{
		//IL_0ae0: Expected I, but got Obj
		//IL_0af6: Expected Obj, but got I
		//IL_0e5e: Expected I, but got Obj
		//IL_0e74: Expected Obj, but got I
		//IL_0e91: Expected I, but got Obj
		//IL_0b29: Expected Obj, but got I
		//IL_0b48: Expected I, but got Obj
		//IL_0b5e: Expected Obj, but got I
		//IL_0b75: Expected I4, but got Obj
		//IL_0b87: Expected I, but got Obj
		//IL_0b9d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_00b6: Expected I, but got Obj
		//IL_0644: Expected I, but got Obj
		//IL_065a: Expected Obj, but got I
		//IL_0d03: Expected I, but got Obj
		//IL_0d19: Expected Obj, but got I
		//IL_0d36: Expected I, but got Obj
		//IL_012a: Expected I, but got Obj
		//IL_0d5a: Expected Obj, but got I
		//IL_0d82: Expected Obj, but got I
		//IL_0d92: Expected Obj, but got I
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Expected Obj, but got Unknown
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected Obj, but got Unknown
		//IL_0dcf: Expected I4, but got Obj
		//IL_0de9: Expected Obj, but got I
		//IL_0df9: Expected Obj, but got I
		//IL_0e09: Expected Obj, but got I
		//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e17: Expected Obj, but got Unknown
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Expected Obj, but got Unknown
		//IL_0e3e: Expected I4, but got Obj
		//IL_0685: Expected I, but got Obj
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_0743: Expected Obj, but got I
		//IL_0753: Expected Obj, but got I
		//IL_0763: Expected Obj, but got I
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected Obj, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_0798: Expected I4, but got Obj
		//IL_07b2: Expected Obj, but got I
		//IL_07c2: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got I
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected Obj, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected Obj, but got Unknown
		//IL_0807: Expected I4, but got Obj
		//IL_06d2: Expected I, but got Obj
		//IL_0702: Expected I, but got Obj
		//IL_0be1: Expected I, but got Obj
		//IL_0bf7: Expected Obj, but got I
		//IL_0c14: Expected I, but got Obj
		//IL_0826: Expected Obj, but got I
		//IL_0836: Expected Obj, but got I
		//IL_0846: Expected Obj, but got I
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected Obj, but got Unknown
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got Unknown
		//IL_087b: Expected I4, but got Obj
		//IL_0895: Expected Obj, but got I
		//IL_08a5: Expected Obj, but got I
		//IL_08b5: Expected Obj, but got I
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Expected Obj, but got Unknown
		//IL_08ea: Expected I4, but got Obj
		//IL_0c38: Expected Obj, but got I
		//IL_0c40: Expected Obj, but got I4
		//IL_0c57: Expected I, but got Obj
		//IL_0c6d: Expected Obj, but got I
		//IL_0c95: Expected Obj, but got I
		//IL_0ca5: Expected Obj, but got I
		//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbb: Expected Obj, but got Unknown
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Expected Obj, but got Unknown
		//IL_0ce2: Expected I4, but got Obj
		//IL_01b8: Expected I, but got Obj
		//IL_0909: Expected Obj, but got I
		//IL_0919: Expected Obj, but got I
		//IL_0929: Expected Obj, but got I
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected Obj, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected Obj, but got Unknown
		//IL_095e: Expected I4, but got Obj
		//IL_0978: Expected Obj, but got I
		//IL_0988: Expected Obj, but got I
		//IL_0998: Expected Obj, but got I
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected Obj, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected Obj, but got Unknown
		//IL_09cd: Expected I4, but got Obj
		//IL_0728: Expected I, but got Obj
		//IL_0276: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02cb: Expected I4, but got Obj
		//IL_02e5: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_033a: Expected I4, but got Obj
		//IL_0205: Expected I, but got Obj
		//IL_0235: Expected I, but got Obj
		//IL_09ec: Expected Obj, but got I
		//IL_09fc: Expected Obj, but got I
		//IL_0a0c: Expected Obj, but got I
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected Obj, but got Unknown
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Expected Obj, but got Unknown
		//IL_0a41: Expected I4, but got Obj
		//IL_0a5b: Expected Obj, but got I
		//IL_0a6b: Expected Obj, but got I
		//IL_0a7b: Expected Obj, but got I
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected Obj, but got Unknown
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected Obj, but got Unknown
		//IL_0aaf: Expected I, but got Obj
		//IL_0ac5: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_03ae: Expected I4, but got Obj
		//IL_03c8: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_041d: Expected I4, but got Obj
		//IL_043c: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_0491: Expected I4, but got Obj
		//IL_04ab: Expected Obj, but got I
		//IL_04bb: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_0500: Expected I4, but got Obj
		//IL_025b: Expected I, but got Obj
		//IL_051f: Expected Obj, but got I
		//IL_052f: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_0574: Expected I4, but got Obj
		//IL_058e: Expected Obj, but got I
		//IL_059e: Expected Obj, but got I
		//IL_05ae: Expected Obj, but got I
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05e2: Expected I, but got Obj
		//IL_05f8: Expected Obj, but got I
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v249 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		nint num3 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		nint num4 = (nint)typeof(StorageSizeLogging);
		if (!flag)
		{
			nint num5 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v243 (Il2CppClass<StorageSizeLogging>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(StorageSizeLogging);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(StorageSizeLogging);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ L0_v3 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj3 = (nint)0 + (nint)16;
		obj3 = cachePath;
		string deviceIdentifier = DeviceUtility.GetDeviceIdentifier();
		nint num6 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj4 = (nint)0 + (nint)24;
		obj4 = deviceIdentifier;
		string text = string.ConcatArray((string[])(object)_userDataPath, (int)"/AssetBundles/");
		nint num7 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v32 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj5 = (nint)0 + (nint)32;
		obj5 = text;
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			nint num8 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v139 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num9 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v239 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!DeviceUtility.GetIOSOtherAudioPlaying())
			{
				nint num10 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v146 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num11 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v235 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int androidApiLevel = DeviceUtility.GetAndroidApiLevel();
				nint num12 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v153 (Il2CppClass<StorageSizeLogging>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				bool flag4 = obj8 == null;
				nint num13 = (nint)typeof(StorageSizeLogging);
				if (!flag4)
				{
					nint num14 = (nint)typeof(StorageSizeLogging);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v229 (Il2CppClass<StorageSizeLogging>)+74]");
					bool flag5 = (nint)0 == 0;
					bool flag6 = !flag5;
					num13 = (nint)typeof(StorageSizeLogging);
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num13 = (nint)typeof(StorageSizeLogging);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ L0_v16 (Il2CppClass<StorageSizeLogging>)+5C]");
				object obj9 = (nint)0 + (nint)20;
				obj9 = androidApiLevel;
				string absoluteURL = Application.absoluteURL;
				nint num15 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v163 (Il2CppClass<StorageSizeLogging>)+5C]");
				object obj10 = (nint)0 + (nint)28;
				obj10 = absoluteURL;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S3_v17 (Il2CppMethodInfo)+C]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S3_v18+60]");
				object obj12 = 0;
				object obj13 = obj12;
				object obj14 = obj13 & 0x1FFF;
				object obj15 = obj14 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v297 @ S4_v54 (should have been resolved before IL gen)");
				string text2 = string.ConcatArray((string[])(object)_userDataPath, (int)"/adc/");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S4_v56 (Il2CppMethodInfo)+C]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S4_v57+60]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S4_v58+48]");
				object obj18 = 0;
				object obj19 = obj18 & 0x7FF;
				object obj20 = obj19 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v350 @ S5_v45 (should have been resolved before IL gen)");
				string text3 = string.ConcatArray((string[])(object)_userDataPath, (int)"/adc3/");
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S4_v61 (Il2CppMethodInfo)+C]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S4_v62+60]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S4_v63+48]");
				object obj23 = 0;
				object obj24 = obj23 & 0x7FF;
				object obj25 = obj24 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v404 @ S5_v49 (should have been resolved before IL gen)");
				string text4 = string.ConcatArray((string[])(object)_userCachePath, (int)"/.chartboost/");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S4_v66 (Il2CppMethodInfo)+C]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S4_v67+60]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S4_v68+48]");
				object obj28 = 0;
				object obj29 = obj28 & 0x7FF;
				object obj30 = obj29 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v458 @ S5_v53 (should have been resolved before IL gen)");
				string text5 = string.ConcatArray((string[])(object)_userTemporaryPath, (int)"/.fcaches/");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S4_v71 (Il2CppMethodInfo)+C]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S4_v72+60]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S4_v73+48]");
				object obj33 = 0;
				object obj34 = obj33 & 0x7FF;
				object obj35 = obj34 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v512 @ S5_v57 (should have been resolved before IL gen)");
				string text6 = string.ConcatArray((string[])(object)_userCachePath, (int)"/im_cached_content/");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S4_v76 (Il2CppMethodInfo)+C]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S4_v77+60]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S4_v78+48]");
				object obj38 = 0;
				object obj39 = obj38 & 0x7FF;
				object obj40 = obj39 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v566 @ S5_v61 (should have been resolved before IL gen)");
				string text7 = string.ConcatArray((string[])(object)_userTemporaryPath, (int)"/supersonicads/");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ S4_v81 (Il2CppMethodInfo)+C]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S4_v82+60]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S4_v83+48]");
				object obj43 = 0;
				object obj44 = obj43 & 0x7FF;
				object obj45 = obj44 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v620 @ S5_v65 (should have been resolved before IL gen)");
				string text8 = string.ConcatArray((string[])(object)_userDataPath, (int)"/Tapjoy/");
				nint num23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ S4_v86 (Il2CppMethodInfo)+C]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S4_v87+60]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S4_v88+48]");
				object obj48 = 0;
				object obj49 = obj48 & 0x7FF;
				object obj50 = obj49 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v674 @ S5_v69 (should have been resolved before IL gen)");
				string text9 = string.ConcatArray((string[])(object)_userExternalDataPath, (int)"/.vungle/");
				nint num24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ S4_v91 (Il2CppMethodInfo)+C]");
				object obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ S4_v92+60]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ S4_v93+48]");
				object obj53 = 0;
				object obj54 = obj53 & 0x7FF;
				object obj55 = obj54 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v120 @ S5_v73 (should have been resolved before IL gen)");
				nint num25 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S0_v226 (Il2CppClass<StorageSizeLogging>)+5C]");
				object obj56 = (nint)0 + (nint)8;
				object obj57 = default;
				obj56 = obj57;
				return;
			}
		}
		string dataPath2 = Application.dataPath;
		if ((nint)dataPath2 != 8)
		{
			return;
		}
		nint num26 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v44 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj58 = (nint)0 & (nint)0x200;
		if (obj58 != null)
		{
			nint num27 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v134 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text10 = DeviceUtility.GetiOSBuildNumber();
		nint num28 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v51 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj59 = (nint)0 & (nint)0x200;
		bool flag7 = obj59 == null;
		nint num29 = (nint)typeof(StorageSizeLogging);
		if (!flag7)
		{
			nint num30 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v128 (Il2CppClass<StorageSizeLogging>)+74]");
			bool flag8 = (nint)0 == 0;
			bool flag9 = !flag8;
			num29 = (nint)typeof(StorageSizeLogging);
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num29 = (nint)typeof(StorageSizeLogging);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ L0_v10 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj60 = (nint)0 + (nint)28;
		obj60 = text10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S3_v4+60]");
		object obj62 = 0;
		object obj63 = obj62;
		object obj64 = obj63 & 0x1FFF;
		object obj65 = obj64 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v235 @ S4_v5 (should have been resolved before IL gen)");
		string text11 = string.ConcatArray((string[])(object)_userCachePath, (int)"/adc/");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S4_v8+60]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S4_v9+48]");
		object obj68 = 0;
		object obj69 = obj68 & 0x7FF;
		object obj70 = obj69 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v273 @ S5_v7 (should have been resolved before IL gen)");
		string text12 = string.ConcatArray((string[])(object)_userCachePath, (int)"/adc3/");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S4_v13+60]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S4_v14+48]");
		object obj73 = 0;
		object obj74 = obj73 & 0x7FF;
		object obj75 = obj74 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v323 @ S5_v11 (should have been resolved before IL gen)");
		string text13 = string.ConcatArray((string[])(object)_userCachePath, (int)"/CBPrefetchCacheFolder/");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S4_v17 (Il2CppMethodInfo)+C]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S4_v18+60]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S4_v19+48]");
		object obj78 = 0;
		object obj79 = obj78 & 0x7FF;
		object obj80 = obj79 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v377 @ S5_v15 (should have been resolved before IL gen)");
		string text14 = string.ConcatArray((string[])(object)_userCachePath, (int)"/audience_network/");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S4_v22 (Il2CppMethodInfo)+C]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S4_v23+60]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S4_v24+48]");
		object obj83 = 0;
		object obj84 = obj83 & 0x7FF;
		object obj85 = obj84 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v431 @ S5_v19 (should have been resolved before IL gen)");
		string text15 = string.ConcatArray((string[])(object)_userCachePath, (int)"/FlurryFiles/");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S4_v27 (Il2CppMethodInfo)+C]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S4_v28+60]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S4_v29+48]");
		object obj88 = 0;
		object obj89 = obj88 & 0x7FF;
		object obj90 = obj89 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v485 @ S5_v23 (should have been resolved before IL gen)");
		string text16 = string.ConcatArray((string[])(object)_userCachePath, (int)"/.inmobi_6.0.0/");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S4_v32 (Il2CppMethodInfo)+C]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S4_v33+60]");
		object obj92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S4_v34+48]");
		object obj93 = 0;
		object obj94 = obj93 & 0x7FF;
		object obj95 = obj94 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v539 @ S5_v27 (should have been resolved before IL gen)");
		string text17 = string.ConcatArray((string[])(object)_userCachePath, (int)"/SSACache_5.40/");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ S4_v37 (Il2CppMethodInfo)+C]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S4_v38+60]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S4_v39+48]");
		object obj98 = 0;
		object obj99 = obj98 & 0x7FF;
		object obj100 = obj99 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v593 @ S5_v31 (should have been resolved before IL gen)");
		string text18 = string.ConcatArray((string[])(object)_userCachePath, (int)"/TapjoyAssets/");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ S4_v42 (Il2CppMethodInfo)+C]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ S4_v43+60]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ S4_v44+48]");
		object obj103 = 0;
		object obj104 = obj103 & 0x7FF;
		object obj105 = obj104 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v647 @ S5_v35 (should have been resolved before IL gen)");
		string text19 = string.ConcatArray((string[])(object)_userCachePath, (int)"/vungle/");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S4_v47 (Il2CppMethodInfo)+C]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S4_v48+60]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S4_v49+48]");
		object obj108 = 0;
		object obj109 = obj108 & 0x7FF;
		object obj110 = obj109 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v121 @ S5_v39 (should have been resolved before IL gen)");
		nint num41 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ S0_v125 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj111 = (nint)0 + (nint)12;
		object obj112 = default;
		obj111 = obj112;
	}
}
