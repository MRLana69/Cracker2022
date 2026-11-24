using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Migration;
using Data.Save;
using Info;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using SYBO.Common.Utilities.Flags;
using SYBO.Subway.Info;
using UnityEngine;

public class AssetBundleVersionControl
{
	private const string VERSION_INFO_SAVE_PATH = "AssetBundleVersion";

	private const string VERSION_INFO_FILE_NAME = "AssetBundleVersionInfo";

	private const string ASSET_BUNDLE_MANIFESTS_RESOURCES_PATH = "AssetBundleManifests/";

	public const string DOWNLOADABLE_BUNDLE_DATA_FILENAME = "DownloadableAssetBundlesManifest";

	public const string SHIPPED_BUNDLE_DATA_FILENAME = "ShippedAssetBundlesManifest";

	private const string DEBUG_TAG = "[AssetBundleVersionControl]: ";

	private const string ONLINE_SETTINGS_BUNDLES_VERSION_KEY = "asset_bundles_version";

	private const string ONLINE_SETTINGS_UPDATED_ASSET_BUNDLES = "updated_bundles_list";

	private const char UPDATED_BUNDLE_SEPARATOR = ';';

	private const char UPDATED_BUNDLE_VALUE_SEPARATOR = ':';

	private const string MANIFESTS_IOS_FOLDER = "ios";

	private const string MANIFESTS_ANDROID_FOLDER = "android";

	private const string MANIFESTS_EDITOR_FOLDER = "editor";

	private const string MANIFESTS_DEAULT_FOLDER = "editor";

	private static int DEFAULT_BUNDLES_VERSION;

	private static readonly IJsonSerializer _jsonConverter;

	private bool _initialized;

	private string _versionInfoFilePath;

	private Dictionary<string, int> _availableBundlesData;

	private Dictionary<string, int> _shippedBundlesData;

	private Dictionary<string, int> _downloadableBundlesData;

	private Dictionary<string, int> _neededBundles;

	public Action OnDownloadableAssetBundlesUpdated;

	private static AssetBundleVersionControl _instance;

	public static AssetBundleVersionControl Instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (AssetBundleVersionControl)(object)DeviceUtility.GetCachePath();
		}
		private set
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj = value + 12;
			obj = string.Empty;
			value.OnOnlineSettingsDownloaded();
		}
	}

	private AssetBundleVersionControl()
	{
		//IL_0036: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+2C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+38]");
			CoroutineUtil.StopCoroutine((Coroutine)0);
			_ = 0;
		}
	}

	public void Initialize()
	{
	}

	private static string GetVersionInfoFilePath()
	{
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_011d: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleVersionControl);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleVersionControl>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleVersionControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<AssetBundleVersionControl>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _instance == null;
		bool flag2 = !flag;
		string result = (string)(object)_instance;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AssetBundleVersionControl assetBundleVersionControl = default;
			Instance = assetBundleVersionControl;
			nint num3 = (nint)typeof(AssetBundleVersionControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<AssetBundleVersionControl>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag3 = obj2 == null;
			nint num4 = (nint)typeof(AssetBundleVersionControl);
			if (!flag3)
			{
				nint num5 = (nint)typeof(AssetBundleVersionControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v28 (Il2CppClass<AssetBundleVersionControl>)+74]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				num4 = (nint)typeof(AssetBundleVersionControl);
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(AssetBundleVersionControl);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ L0_v6 (Il2CppClass<AssetBundleVersionControl>)+5C]");
			object obj3 = (nint)0 + (nint)8;
			obj3 = assetBundleVersionControl;
			result = (string)(object)assetBundleVersionControl;
		}
		return result;
	}

	private bool IsFreshInstall(string lastSeenVersion)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string root = PathHandling.AbsoluteToRelativePath("..\\..\\AssetBundles");
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v10 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot(root, "Temp");
		return Path.SameRoot((string)flag, lastSeenVersion);
	}

	private bool HasAppBeenUpdated(string lastSeenVersion)
	{
		if (lastSeenVersion != null)
		{
			return lastSeenVersion.m_stringLength == 0;
		}
		return true;
	}

	private unsafe void OnOnlineSettingsDownloaded()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		//IL_059d: Expected I, but got Obj
		//IL_05b3: Expected Obj, but got I
		//IL_05e7: Expected I, but got Obj
		//IL_05fd: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I4
		//IL_01c0: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_0201: Expected I, but got Obj
		//IL_06b8: Expected I, but got Obj
		//IL_06ce: Expected Obj, but got I
		//IL_024e: Expected I, but got Obj
		//IL_0264: Expected Obj, but got I
		//IL_0710: Expected I, but got Obj
		//IL_0726: Expected Obj, but got I
		//IL_034f: Expected I, but got Obj
		//IL_074c: Expected Obj, but got I4
		//IL_075a: Expected I, but got Obj
		//IL_0770: Expected Obj, but got I
		//IL_039c: Expected I, but got Obj
		//IL_028f: Expected I, but got Obj
		//IL_03e9: Expected I, but got Obj
		//IL_07bc: Expected I4, but got Obj
		//IL_0436: Expected I, but got Obj
		//IL_04bf: Expected I, but got Obj
		//IL_04d5: Expected Obj, but got I
		//IL_04a6: Expected I4, but got Obj
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_0500: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(AssetBundleVersionControl);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<AssetBundleVersionControl>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleVersionControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v112 (Il2CppClass<AssetBundleVersionControl>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		CharacterModelPreviewFactory instance = CharacterModelPreviewFactory.Instance;
		obj2 = instance;
		nint num3 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v17 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v108 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AssetBundleVersionControl instance2 = Instance;
		nint num5 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v9 (Il2CppClass<System.IO.Path>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v71 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool recursive = Path.SameRoot((string)(object)instance2, "AssetBundleVersion");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DirectoryInfo directoryInfo = default;
		directoryInfo.Delete(recursive);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj5 = default;
		if (obj5 == null)
		{
			directoryInfo.Delete();
		}
		object obj6 = this + 20;
		string manifestPath = GetManifestPath(null);
		obj6 = manifestPath;
		object obj7 = this + 24;
		string manifestPath2 = GetManifestPath((string)1);
		obj7 = manifestPath2;
		nint num7 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v36 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v103 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PlayerInfoData serializedUpdatedBundles = PlayerInfoMigrator.LoadPlayerInfoData();
		Dictionary<string, int> dictionary = ((AssetBundleVersionControl)null).ParseUpdatedBundles((string)(object)serializedUpdatedBundles);
		if (dictionary == null)
		{
			nint num9 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v87 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num10 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v99 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PlayerInfoData playerInfoData = PlayerInfoMigrator.LoadPlayerInfoData();
			if (playerInfoData != null && playerInfoData.mainPlayerInfoData != null)
			{
				SaveAvailableBundlesData();
				goto IL_04ab;
			}
		}
		nint num11 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v58 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num12 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v82 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		nint num13 = (nint)typeof(AssetBundleVersionControl);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v41 (Il2CppClass<AssetBundleVersionControl>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num14 = (nint)typeof(AssetBundleVersionControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v62 (Il2CppClass<AssetBundleVersionControl>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue("asset_bundles_version", (uint)DEFAULT_BUNDLES_VERSION);
		nint num15 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v48 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num16 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v58 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UserSave.characterOutfitsSeen = (Dictionary<Characters.CharacterId, HashSet<int>>)value;
		nint num17 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v66 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num18 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v78 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
		if (_shippedBundlesData != null && _downloadableBundlesData != null)
		{
			AddNeededBundles(_shippedBundlesData, (Characters.CharacterId)_downloadableBundlesData);
			goto IL_04ab;
		}
		((AudioStateLoop)null).OnPauseChange((byte)(int)"Unable to read manifests. Aborting initialization." != 0);
		return;
		IL_04ab:
		LoadAvailableBundlesData();
		nint num19 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v45 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num20 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v52 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(AssetBundleVersionControl.OnOnlineSettingsDownloaded);
		object obj15 = action + 16;
		obj15 = this;
		((OnlineSettings)(object)saveDataPath2).RemoveOnFinishedDownloadingOnlineSettingsHandler(action);
		_initialized = true;
	}

	private Dictionary<string, int> ParseUpdatedBundles(string serializedUpdatedBundles)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		bool flag = string.Equals(serializedUpdatedBundles, bundleIdentifier);
		return (Dictionary<string, int>)((flag ? 1 : 0) ^ 1);
	}

	private void CreateAvailableBundlesVersionInfo(Dictionary<string, int> shippedData, Dictionary<string, int> downloadableData)
	{
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_001a: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+28]");
			int num2 = ((Dictionary<string, int>)0).get_Item((string)(object)shippedData);
			if (num2 <= (nint)downloadableData)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+28]");
				bool flag = ((Dictionary<string, int>)0).Remove((string)(object)shippedData);
			}
		}
	}

	private void InitializeNeededBundles()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected Obj, but got Unknown
		//IL_08be: Expected Obj, but got I4
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected Obj, but got Unknown
		//IL_08e1: Expected Obj, but got I4
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_090b: Expected I, but got Obj
		//IL_0921: Expected Obj, but got I
		//IL_09d1: Expected I4, but got Obj
		//IL_09d1: Expected I4, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_095a: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_01b1: Expected I4, but got Obj
		//IL_01b1: Expected I4, but got Obj
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_01e5: Expected I4, but got Obj
		//IL_01f3: Expected Obj, but got I4
		//IL_0975: Expected Obj, but got I4
		//IL_0164: Expected I, but got Obj
		//IL_0222: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_07ee: Expected Obj, but got I
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0787: Expected Obj, but got I4
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
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v197 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)"asset_bundles_version");
		if (outfitForCharacter == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v31 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v193 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, HashSet<int>> characterOutfitsSeen = UserSave.characterOutfitsSeen;
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue("asset_bundles_version", (uint)(int)characterOutfitsSeen);
		Dictionary<Characters.CharacterId, HashSet<int>> characterOutfitsSeen2 = UserSave.characterOutfitsSeen;
		if ((int)value > (nint)characterOutfitsSeen2)
		{
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v184 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v189 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UserSave.characterOutfitsSeen = (Dictionary<Characters.CharacterId, HashSet<int>>)value;
		}
		Outfit outfitForCharacter2 = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)"updated_bundles_list");
		if (outfitForCharacter2 == null)
		{
			return;
		}
		bool value2 = ((OnlineSettings)(object)saveDataPath).GetValue("updated_bundles_list", (byte)(int)"" != 0);
		int latestVersionForBundle = ((AssetBundleVersionControl)null).GetLatestVersionForBundle((string)value2);
		if (latestVersionForBundle == 0 || !Enumerable.Any((IEnumerable<KeyValuePair<string, int>>)latestVersionForBundle))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				}
			}
		}
		object obj13 = 43;
		object obj14 = obj13 - 23;
		object obj21;
		object obj22 = default;
		if ((nint)obj13 != 23 && (nint)obj14 != 1 && (nint)obj14 != 2)
		{
			if ((nint)obj14 == 3 || (nint)obj14 == 4 || (nint)obj14 == 5 || (nint)obj14 == 6 || (nint)obj14 == 7)
			{
				goto IL_0a01;
			}
			if ((nint)obj14 != 8)
			{
				if ((nint)obj14 != 9)
				{
					if ((nint)obj14 != 10)
					{
						if ((nint)obj14 == 11 || (nint)obj14 == 12 || (nint)obj14 == 13 || (nint)obj14 == 14 || (nint)obj14 == 15 || (nint)obj14 == 16)
						{
							goto IL_0a01;
						}
						if ((nint)obj14 != 17)
						{
							if ((nint)obj14 != 18)
							{
								if ((nint)obj14 != 19)
								{
									if ((nint)obj14 == 20)
									{
										object obj15 = obj5 + 4;
										object obj16 = obj15 + 1;
										obj15 = obj16;
										object obj17 = obj16 << 2;
										object obj18 = obj5 + obj17;
										obj18 = 222;
									}
									goto IL_0a01;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj20 = default;
								object obj19 = obj20;
								obj21 = obj22;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj23 = default;
								object obj19 = obj23;
								obj21 = obj22;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj24 = default;
							object obj19 = obj24;
							obj21 = obj22;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj25 = default;
						object obj19 = obj25;
						obj21 = obj22;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj26 = default;
					object obj19 = obj26;
					obj21 = obj22;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj27 = default;
				object obj19 = obj27;
				obj21 = obj22;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj28 = default;
			object obj19 = obj28;
			obj21 = obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj29 = default;
		if (obj21 == obj29)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0a01;
		IL_0a01:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj30 = (nint)0 << 2;
			object obj31 = obj5 + obj30;
			if ((nint)obj31 == 222)
			{
				object obj32 = obj5 + 4;
				if ((nint)obj32 > -1)
				{
					object obj33 = obj32 + -1;
					obj32 = obj33;
				}
				goto IL_0a26;
			}
		}
		object obj34 = default;
		if (obj34 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0a26;
		IL_0a26:
		DeleteAvailableBundlesData();
		if (OnDownloadableAssetBundlesUpdated != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void AddNeededBundles(Dictionary<string, int> neededBundles, Characters.CharacterId character)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected Obj, but got Unknown
		//IL_08c8: Expected Obj, but got I4
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected Obj, but got Unknown
		//IL_08eb: Expected Obj, but got I4
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected Obj, but got Unknown
		//IL_092d: Expected Obj, but got I
		//IL_093d: Expected Obj, but got I
		//IL_094d: Expected Obj, but got I
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected Obj, but got Unknown
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected Obj, but got Unknown
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_0807: Expected Obj, but got I
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_07a0: Expected Obj, but got I4
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
		((AudioClipInfo)this)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S3_v3+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S3_v4+10]");
		object obj8 = 0;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v66 @ S4_v4 (should have been resolved before IL gen)");
		object obj11 = this + 16;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		object obj16 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj13 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
		}
		object obj17 = 38;
		object obj18 = obj17 - 8;
		object obj25;
		object obj26 = default;
		if ((nint)obj17 != 8 && (nint)obj18 != 1 && (nint)obj18 != 2)
		{
			if ((nint)obj18 == 3 || (nint)obj18 == 4 || (nint)obj18 == 5 || (nint)obj18 == 6 || (nint)obj18 == 7 || (nint)obj18 == 8 || (nint)obj18 == 9 || (nint)obj18 == 10)
			{
				goto IL_09e9;
			}
			if ((nint)obj18 != 11)
			{
				if ((nint)obj18 != 12)
				{
					if ((nint)obj18 != 13)
					{
						if ((nint)obj18 != 14)
						{
							if ((nint)obj18 != 15)
							{
								if ((nint)obj18 == 16 || (nint)obj18 == 17 || (nint)obj18 == 18)
								{
									goto IL_09e9;
								}
								if ((nint)obj18 != 19)
								{
									if ((nint)obj18 != 20)
									{
										if ((nint)obj18 == 21 || (nint)obj18 == 22 || (nint)obj18 == 23 || (nint)obj18 == 24 || (nint)obj18 == 25 || (nint)obj18 == 26)
										{
											goto IL_09e9;
										}
										if ((nint)obj18 != 27)
										{
											if ((nint)obj18 != 28)
											{
												if ((nint)obj18 != 29)
												{
													if ((nint)obj18 == 30)
													{
														object obj19 = obj5 + 4;
														object obj20 = obj19 + 1;
														obj19 = obj20;
														object obj21 = obj20 << 2;
														object obj22 = obj5 + obj21;
														obj22 = 188;
													}
													goto IL_09e9;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj24 = default;
												object obj23 = obj24;
												obj25 = obj26;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj27 = default;
												object obj23 = obj27;
												obj25 = obj26;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj28 = default;
											object obj23 = obj28;
											obj25 = obj26;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj29 = default;
										object obj23 = obj29;
										obj25 = obj26;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj30 = default;
									object obj23 = obj30;
									obj25 = obj26;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj31 = default;
								object obj23 = obj31;
								obj25 = obj26;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj32 = default;
							object obj23 = obj32;
							obj25 = obj26;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj33 = default;
						object obj23 = obj33;
						obj25 = obj26;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj34 = default;
					object obj23 = obj34;
					obj25 = obj26;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj35 = default;
				object obj23 = obj35;
				obj25 = obj26;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj36 = default;
			object obj23 = obj36;
			obj25 = obj26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj37 = default;
		if (obj25 == obj37)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_09e9;
		IL_09e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj38 = (nint)0 << 2;
			object obj39 = obj5 + obj38;
			if ((nint)obj39 == 188)
			{
				object obj40 = obj5 + 4;
				if ((nint)obj40 > -1)
				{
					object obj41 = obj40 + -1;
					obj40 = obj41;
				}
				goto IL_0a0e;
			}
		}
		object obj42 = default;
		if (obj42 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0a0e;
		IL_0a0e:
		DeleteAvailableBundlesData();
	}

	public Dictionary<string, int> GetNeededBundles()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+48]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+4C]");
		if (num == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+48]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			return (Dictionary<string, int>)(object)("Complete(" + text + ")");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+4C]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleVersionControl)+48]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text3 = default;
		return (Dictionary<string, int>)(object)(text2 + "/" + text3);
	}

	public unsafe int GetLatestVersionForBundle(string bundleName)
	{
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_0217: Expected I4, but got Obj
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I4
		int result;
		if (bundleName != null && bundleName.m_stringLength != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v4+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100 @ S4_v7 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num2 = default;
			object obj6 = num2 + 16;
			obj6 = 59;
			string text = bundleName.Substring(num2);
			object obj7 = text + 12;
			object obj8 = 0;
			object obj9 = 113696;
			int num3 = default;
			int num4 = default;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
				result = num3;
				if (flag)
				{
					break;
				}
				object obj10 = text + 16;
				object obj11 = obj8 << 2;
				object obj12 = obj10 + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj13 = num4 + 16;
				obj13 = 58;
				string text2 = ((string)obj12).Substring(num4);
				if (text2.m_firstChar == '\u0002')
				{
					object obj14 = text2 + 16;
					object obj15 = text2 + 20;
					TypeCode typeCode = ((int*)obj15)->GetTypeCode();
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S4_v9 (Il2CppMethodInfo)+C]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S4_v10+60]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S4_v11+48]");
					obj5 = 0;
					object obj18 = obj5 & 0x7FF;
					obj9 = obj18 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v99 @ S5_v5 (should have been resolved before IL gen)");
					obj3 = 2;
				}
				else
				{
					((AudioStateLoop)null).OnPauseChange((byte)(int)"Updated bundle data formatting is wrong. Aborting bundle data update." != 0);
				}
				object obj19 = obj8 + 1;
				obj8 = obj19;
			}
		}
		else
		{
			result = 0;
		}
		return result;
	}

	public int GetAvailableShippedVersionForBundle(string bundleName)
	{
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
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
			return _availableBundlesData.get_Item(bundleName);
		}
		return -1;
	}

	public bool IsBundleVersionShipped(string bundleName, int version)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = bundleName;
		return flag;
	}

	public int GetCurrentlyAvailableBundleVersion()
	{
		//IL_000d: Expected I4, but got Obj
		LoadAvailableBundlesData();
		return (int)_neededBundles;
	}

	private Dictionary<string, int> ReadAssetBundleManifest(bool downloadables)
	{
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0014: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
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
			int num2 = _shippedBundlesData.get_Item((string)downloadables);
			return (Dictionary<string, int>)num2;
		}
		return (Dictionary<string, int>)(-1);
	}

	private string GetManifestPath(string filename)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_07bc: Expected Obj, but got I4
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected Obj, but got Unknown
		//IL_07df: Expected Obj, but got I4
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected Obj, but got Unknown
		//IL_002a: Expected I4, but got Obj
		//IL_001c: Expected I4, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0788: Expected I4, but got Obj
		//IL_0796: Expected I4, but got Obj
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
		int frames = ((filename == null) ? ((int)"ShippedAssetBundlesManifest") : ((int)"DownloadableAssetBundlesManifest"));
		IEnumerator enumerator = ((AudioStateLoop)null).ResumeSoundAfterFrames(frames);
		if ((string)(object)enumerator != string.Empty)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S3_v23 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S3_v24+60]");
			object obj7 = 0;
			object obj8 = obj7;
			object obj9 = obj8 & 0x1FFF;
			object obj10 = obj9 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v94 @ S4_v14 (should have been resolved before IL gen)");
			string result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj15 = default;
		if (obj11 == obj15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj17 = default;
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj19 = default;
			object obj18 = obj19;
		}
		else
		{
			object obj18 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		string text = string.ConcatArray((string[])(object)"Unable to read ", (int)enumerator);
		((AudioStateLoop)null).OnPauseChange((byte)(int)text != 0);
		return null;
	}

	private unsafe void LoadAvailableBundlesData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected Obj, but got Unknown
		//IL_07df: Expected Obj, but got I4
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_0802: Expected Obj, but got I4
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected Ref, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_0830: Expected Obj, but got I4
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 56;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		ref bool reference = ref *(bool*)(obj2 + 76);
		reference = ref *(bool*)null;
		object obj5 = obj2 + 40;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		if (_neededBundles == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S3_v23 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S3_v24+60]");
			object obj8 = 0;
			object obj9 = obj8;
			object obj10 = obj9 & 0x1FFF;
			object obj11 = obj10 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v72 @ S4_v22 (should have been resolved before IL gen)");
			object obj12 = this + 28;
			object obj13 = default;
			obj12 = obj13;
		}
		throw new IndexOutOfRangeException();
	}

	private void SaveAvailableBundlesData()
	{
		//IL_00c3: Expected I4, but got Obj
		//IL_0031: Expected I, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0072: Expected I, but got Obj
		if (File.GetAttributes(_versionInfoFilePath) != 0)
		{
			byte[] array = File.ReadAllBytes(_versionInfoFilePath);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v13 (Il2CppClass<AssetBundleManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AssetBundleManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v20 (Il2CppClass<AssetBundleManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 16;
			AssetBundleManager assetBundleManager = default;
			string preCachedBundles = assetBundleManager.GetPreCachedBundles();
			obj2 = preCachedBundles;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		else
		{
			AddNeededBundles(_shippedBundlesData, (Characters.CharacterId)_downloadableBundlesData);
		}
	}

	private void DeleteAvailableBundlesData()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v8 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, int> dictionary = AssetBundleManager.ParseAssetBundleVersionData((string)(object)_availableBundlesData);
		((FileStream)(object)_versionInfoFilePath).WriteByte((byte)(int)dictionary);
	}

	private unsafe void Log(string msg)
	{
		//IL_000e: Expected Obj, but got Ref
		//IL_0767: Expected Obj, but got Ref
		//IL_0770: Expected Obj, but got I4
		//IL_0784: Expected Obj, but got Ref
		//IL_078d: Expected Obj, but got I4
		//IL_07a1: Expected Obj, but got Ref
		//IL_07aa: Expected Obj, but got I4
		//IL_07c4: Expected Obj, but got Ref
		//IL_07cd: Expected Obj, but got I4
		//IL_07db: Expected Obj, but got Ref
		//IL_07e4: Expected Obj, but got I4
		//IL_07f8: Expected Obj, but got Ref
		//IL_082b: Expected I4, but got Obj
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got Unknown
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected Obj, but got Unknown
		//IL_0886: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I4
		//IL_099a: Expected I4, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected Obj, but got Unknown
		//IL_08f0: Expected Obj, but got I4
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_09d9: Expected I4, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0429: Expected Obj, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0a25: Expected I4, but got Obj
		//IL_04b6: Expected Obj, but got I
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_0603: Expected Obj, but got I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_06a4: Expected Obj, but got I
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		ref _0021_00210 reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 112));
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 96));
		obj2 = 0;
		_ = 0;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 80));
		obj3 = 0;
		_ = 0;
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 56));
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 24));
		obj5 = 0;
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 40));
		obj6 = 0;
		_ = 0;
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32));
		obj7 = obj;
		_ = -1;
		object values = ((IConvertible)"REQUESTED: ").ToType((Type)(object)msg, (IFormatProvider)(object)"\n");
		string text = string.ConcatArray((string[])values, (int)"LOADED:\n");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
		_0021_00210 flag = default;
		FlagsHelper.Set<T>(ref System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (T)flag);
		obj2 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		string values2 = text;
		object obj8 = default;
		string text2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			values2 = text2;
		}
		object obj9 = obj7 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj7 + obj11;
		obj12 = 99;
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj7 + obj14;
			if ((nint)obj15 == 99)
			{
				object obj16 = obj7 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_098c;
			}
		}
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_098c;
		IL_098c:
		string text3 = string.ConcatArray((string[])(object)values2, (int)"LOADING:\n");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		string values3 = text3;
		object obj18 = default;
		string text4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj18 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			values3 = text4;
		}
		object obj19 = obj7 + 4;
		object obj20 = obj19 + 1;
		obj19 = obj20;
		object obj21 = obj20 << 2;
		object obj22 = obj7 + obj21;
		obj22 = 178;
		object obj23 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+4]");
			object obj24 = (nint)0 << 2;
			object obj25 = obj7 + obj24;
			if ((nint)obj25 == 178)
			{
				object obj26 = obj7 + 4;
				if ((nint)obj26 > -1)
				{
					object obj27 = obj26 + -1;
					obj26 = obj27;
				}
				goto IL_09cb;
			}
		}
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_09cb;
		IL_0a17:
		string values4;
		string text5 = string.ConcatArray((string[])(object)values4, (int)"UNLOADING:\n");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
		_0021_00210 flag2 = default;
		FlagsHelper.Set<T>(ref System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (T)flag2);
		obj6 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		object obj28 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj28 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		}
		object obj29 = obj7 + 4;
		object obj30 = obj29 + 1;
		obj29 = obj30;
		object obj31 = obj30 << 2;
		object obj32 = obj7 + obj31;
		obj32 = 348;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+4]");
			object obj33 = (nint)0 << 2;
			object obj34 = obj7 + obj33;
			if ((nint)obj34 == 348)
			{
				object obj35 = obj7 + 4;
				if ((nint)obj35 > -1)
				{
					object obj36 = obj35 + -1;
					obj35 = obj36;
				}
				return;
			}
		}
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		return;
		IL_09cb:
		string text6 = string.ConcatArray((string[])(object)values3, (int)"PENDING:\n");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77DB");
		obj4 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+10]");
		_ = 0;
		values4 = text6;
		object obj37 = default;
		string text7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj37 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj5 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			values4 = text7;
		}
		object obj38 = obj7 + 4;
		object obj39 = obj38 + 1;
		obj38 = obj39;
		object obj40 = obj39 << 2;
		object obj41 = obj7 + obj40;
		obj41 = 263;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27+4]");
			object obj42 = (nint)0 << 2;
			object obj43 = obj7 + obj42;
			if ((nint)obj43 == 263)
			{
				object obj44 = obj7 + 4;
				if ((nint)obj44 > -1)
				{
					object obj45 = obj44 + -1;
					obj44 = obj45;
				}
				goto IL_0a17;
			}
		}
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0a17;
	}

	private void LogWarning(string msg)
	{
	}

	private void LogError(string msg)
	{
	}

	static AssetBundleVersionControl()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_004a: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		AssetBundleManager._assetBundleBaseServerUrl = "http://subway.azureedge.net/subway/";
		nint num = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<AssetBundleManager>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = "ios";
		nint num2 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<AssetBundleManager>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		obj2 = "android";
		nint num3 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppClass<AssetBundleManager>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = "generated";
		AssetBundleManager._requestDownloadTimeout = 30f;
		AssetBundleManager._requestMaxBackoffTime = 300f;
		AssetBundleManager._downloadAttemptRestTime = 10f;
		AssetBundleManager._usingBundleExtension = true;
		nint num4 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v33 (Il2CppClass<AssetBundleManager>)+5C]");
		object obj4 = (nint)0 + (nint)32;
		obj4 = ".bytes";
	}
}
