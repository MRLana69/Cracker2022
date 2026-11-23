using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Info;
using SYBO.Subway.Utilities;
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

	private const string MANIFESTS_WP_FOLDER = "wp";

	private const string MANIFESTS_EDITOR_FOLDER = "editor";

	private const string MANIFESTS_DEAULT_FOLDER = "editor";

	private static int DEFAULT_BUNDLES_VERSION = Globals.DEFAULT_BUNDLES_VERSION;

	private bool _initialized;

	private bool _eventsChanged;

	private string _versionInfoFilePath = string.Empty;

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
			bool flag = _instance == null;
			bool flag2 = !flag;
			AssetBundleVersionControl result = _instance;
			if (!flag2)
			{
				AssetBundleVersionControl assetBundleVersionControl = default;
				assetBundleVersionControl._002Ector();
				_instance = assetBundleVersionControl;
				result = assetBundleVersionControl;
			}
			return result;
		}
		private set
		{
		}
	}

	private AssetBundleVersionControl()
	{
		Initialize();
	}

	public unsafe void Initialize()
	{
		//IL_005c: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		string versionInfoFilePath = GetVersionInfoFilePath();
		_versionInfoFilePath = versionInfoFilePath;
		string userDataPath = DeviceUtility.GetUserDataPath();
		string path = Path.Combine(userDataPath, "AssetBundleVersion");
		DirectoryInfo directoryInfo = default;
		directoryInfo._002Ector(path);
		nint num = (nint)directoryInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S1_v9 (Il2CppClass<System.IO.DirectoryInfo>)+10C] (should have been resolved before IL gen)");
		object obj = default;
		if (obj == null)
		{
			directoryInfo.Create();
		}
		Dictionary<string, int> shippedBundlesData = ReadAssetBundleManifest(downloadables: false);
		_shippedBundlesData = shippedBundlesData;
		Dictionary<string, int> downloadableBundlesData = ReadAssetBundleManifest(downloadables: true);
		_downloadableBundlesData = downloadableBundlesData;
		string text = PlayerPrefs.GetString("lastSeenBundleVersionKey", string.Empty);
		if (HasAppBeenUpdated(text))
		{
			goto IL_0164;
		}
		object obj2;
		if (text != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_02f9;
			}
		}
		obj2 = 1;
		goto IL_02f9;
		IL_02f9:
		if (obj2 == null)
		{
			LoadAvailableBundlesData();
			goto IL_022b;
		}
		goto IL_0164;
		IL_022b:
		InitializeNeededBundles();
		OnlineSettings instance = OnlineSettings.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(AssetBundleVersionControl.OnOnlineSettingsDownloaded));
		instance.AddOnFinishedDownloadingOnlineSettingsHandler(action);
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(AssetBundleVersionControl.OnEventChanged));
		SSEventsManagerController.OnSSEventStartedHandler += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(AssetBundleVersionControl.OnEventChanged));
		SSEventsManagerController.OnSSEventFinishedHandler += action3;
		Action action4 = default;
		action4._002Ector(this, (nint)__ldftn(AssetBundleVersionControl.OnEventChanged));
		SSEventsManagerController.OnSSEventChangedHandler += action4;
		_initialized = true;
		return;
		IL_0164:
		PlayerInfo instance2 = PlayerInfo.Instance;
		OnlineSettings instance3 = OnlineSettings.instance;
		int value = instance3.GetValue("asset_bundles_version", DEFAULT_BUNDLES_VERSION);
		instance2._dirty = true;
		instance2._latestAvailableAssetBundlesVersion = value;
		PlayerInfo instance4 = PlayerInfo.Instance;
		instance4.SaveIfDirty();
		if (_shippedBundlesData == null || _downloadableBundlesData == null)
		{
			LogError("Unable to read manifests. Aborting initialization.");
			return;
		}
		CreateAvailableBundlesVersionInfo(_shippedBundlesData, _downloadableBundlesData);
		goto IL_022b;
	}

	private static string GetVersionInfoFilePath()
	{
		string userDataPath = DeviceUtility.GetUserDataPath();
		string path = Path.Combine(userDataPath, "AssetBundleVersion");
		return Path.Combine(path, "AssetBundleVersionInfo");
	}

	private void OnEventChanged()
	{
		_eventsChanged = true;
	}

	private bool IsFreshInstall(string lastSeenVersion)
	{
		bool result;
		if (lastSeenVersion != null)
		{
			result = false;
			if (lastSeenVersion._stringLength != 0)
			{
				goto IL_0047;
			}
		}
		result = true;
		goto IL_0047;
		IL_0047:
		return result;
	}

	private bool HasAppBeenUpdated(string lastSeenVersion)
	{
		string bundleVersion = DeviceUtility.GetBundleVersion();
		bool flag = lastSeenVersion.Equals(bundleVersion);
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	private void OnOnlineSettingsDownloaded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_01f6: Expected Obj, but got I
		//IL_0507: Expected I4, but got Obj
		object obj = default;
		AssetBundleVersionControl assetBundleVersionControl = (AssetBundleVersionControl)(obj + -64);
		_ = 0;
		_ = 0;
		_ = 0;
		assetBundleVersionControl.OnDownloadableAssetBundlesUpdated = null;
		OnlineSettings instance = OnlineSettings.instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		if (!instance.HasValue("asset_bundles_version"))
		{
			return;
		}
		int value = instance.GetValue("asset_bundles_version", instance2._latestAvailableAssetBundlesVersion);
		if (value > instance2._latestAvailableAssetBundlesVersion)
		{
			instance2._dirty = true;
			instance2._latestAvailableAssetBundlesVersion = value;
			instance2.SaveIfDirty();
		}
		if (!instance.HasValue("updated_bundles_list"))
		{
			return;
		}
		string value2 = instance.GetValue("updated_bundles_list", string.Empty);
		Dictionary<string, int> dictionary = assetBundleVersionControl.ParseUpdatedBundles(value2);
		if (dictionary == null || !Enumerable.Any(dictionary))
		{
			return;
		}
		object obj2 = assetBundleVersionControl + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		_ = assetBundleVersionControl._downloadableBundlesData;
		_ = assetBundleVersionControl._availableBundlesData;
		_ = assetBundleVersionControl._initialized;
		object obj3 = assetBundleVersionControl + 40;
		assetBundleVersionControl = (AssetBundleVersionControl)obj3;
		assetBundleVersionControl._initialized = false;
		assetBundleVersionControl._versionInfoFilePath = (string)(object)assetBundleVersionControl;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			_ = 0;
			object obj4 = assetBundleVersionControl + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_0547;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (AssetBundleVersionControl)+34]");
				assetBundleVersionControl = (AssetBundleVersionControl)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					assetBundleVersionControl.OnDownloadableAssetBundlesUpdated = (Action)(object)assetBundleVersionControl;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj6 == null)
							{
								continue;
							}
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (AssetBundleVersionControl)+24]");
										if (0 <= (nint)obj7)
										{
											continue;
										}
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													continue;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			assetBundleVersionControl._initialized = (byte)(int)obj12 != 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0547;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj13;
			break;
			IL_0547:
			object obj14 = assetBundleVersionControl + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @126E");
			SaveAvailableBundlesData();
			Action onDownloadableAssetBundlesUpdated = OnDownloadableAssetBundlesUpdated;
			if (OnDownloadableAssetBundlesUpdated != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v323.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			return;
		}
		_ = 0;
		object obj15 = assetBundleVersionControl + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	private Dictionary<string, int> ParseUpdatedBundles(string serializedUpdatedBundles)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		object obj;
		if (serializedUpdatedBundles != null)
		{
			obj = 0;
			if (serializedUpdatedBundles._stringLength != 0)
			{
				goto IL_014d;
			}
		}
		obj = 1;
		goto IL_014d;
		IL_014d:
		Dictionary<string, int> result = null;
		if (obj == null)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
			string[] array = serializedUpdatedBundles.Split(';');
			AssetBundleVersionControl assetBundleVersionControl = null;
			Dictionary<string, int> dictionary = default;
			while (true)
			{
				bool flag = (nint)assetBundleVersionControl >= array.Length;
				result = dictionary;
				if (flag)
				{
					break;
				}
				object obj2 = (object)assetBundleVersionControl << 2;
				object obj3 = (object)array + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v20+10]");
				string[] array2 = ((string)0).Split(':');
				if (array2.Length != 2)
				{
					assetBundleVersionControl.LogError("Updated bundle data formatting is wrong. Aborting bundle data update.");
				}
				else
				{
					int num3 = int.Parse(array2[1]);
					nint num4 = 0;
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S5_v7+4] (should have been resolved before IL gen)");
				}
				AssetBundleVersionControl assetBundleVersionControl2 = (AssetBundleVersionControl)(assetBundleVersionControl + 1);
				assetBundleVersionControl = assetBundleVersionControl2;
			}
		}
		return result;
	}

	private void CreateAvailableBundlesVersionInfo(Dictionary<string, int> shippedData, Dictionary<string, int> downloadableData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0659: Expected Obj, but got I
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected Obj, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_06b3: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		DeleteAvailableBundlesData();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S4_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S4_v4+4] (should have been resolved before IL gen)");
		Dictionary<string, int> availableBundlesData = default;
		_availableBundlesData = availableBundlesData;
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj5 = obj + 40;
		obj = obj5;
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj7 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj8 != null)
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
														if (0 <= (nint)obj9)
														{
															continue;
														}
														_ = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	continue;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											goto IL_04e6;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			goto IL_04e6;
			IL_04e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj10 == obj11;
			bool flag2 = !flag;
			object obj12 = obj13;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
		}
		object obj16 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @126E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		((AssetBundleVersionControl)0).SaveAvailableBundlesData();
	}

	private void InitializeNeededBundles()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (_neededBundles == null)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S4_v23 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
			Dictionary<string, int> neededBundles = default;
			_neededBundles = neededBundles;
		}
		throw new IndexOutOfRangeException();
	}

	private void AddNeededBundles(Dictionary<string, int> neededBundles, Characters.CharacterType character)
	{
		//IL_00da: Expected VT, but got Obj
		//IL_00e7: Expected Obj, but got VT
		//IL_00f4: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		string[] referencedAssetBundleNames = ((Factories)val).GetReferencedAssetBundleNames(character);
		object obj = 0;
		object obj6 = default;
		while (referencedAssetBundleNames.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)referencedAssetBundleNames + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v6+10]");
			int availableShippedVersionForBundle = GetAvailableShippedVersionForBundle((string)0);
			if (availableShippedVersionForBundle != -1)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S3_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S3_v7+4] (should have been resolved before IL gen)");
				object obj5 = obj6 ^ -1;
				object obj7 = obj5 >> 31;
				if (obj7 == null)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S5_v6+4] (should have been resolved before IL gen)");
				}
			}
			object obj9 = obj + 1;
			obj = obj9;
		}
	}

	public Dictionary<string, int> GetNeededBundles()
	{
		if (~(_eventsChanged ? 1u : 0u) == 0)
		{
			InitializeNeededBundles();
		}
		return _neededBundles;
	}

	public int GetLatestVersionForBundle(string bundleName)
	{
		//IL_0047: Expected Obj, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return _availableBundlesData.get_Item(bundleName);
		}
		return -1;
	}

	public int GetAvailableShippedVersionForBundle(string bundleName)
	{
		//IL_0047: Expected Obj, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return _shippedBundlesData.get_Item(bundleName);
		}
		return -1;
	}

	public bool IsBundleVersionShipped(string bundleName, int version)
	{
		//IL_0055: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			int num3 = _shippedBundlesData.get_Item(bundleName);
			return num3 == version;
		}
		return false;
	}

	public int GetCurrentlyAvailableBundleVersion()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance._latestAvailableAssetBundlesVersion;
	}

	private Dictionary<string, int> ReadAssetBundleManifest(bool downloadables)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected Obj, but got Unknown
		//IL_09f1: Expected Obj, but got I4
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected Obj, but got Unknown
		//IL_078a: Expected I, but got Obj
		//IL_07f8: Expected Obj, but got I
		//IL_0823: Expected Obj, but got I
		//IL_0848: Expected Obj, but got I
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected Obj, but got Unknown
		//IL_0b58: Expected Obj, but got I
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected I4, but got Unknown
		//IL_03fa: Expected Obj, but got I4
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected Obj, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected Obj, but got Unknown
		object obj = default;
		AssetBundleVersionControl assetBundleVersionControl = (AssetBundleVersionControl)(obj - 80);
		_ = 0;
		object obj2 = assetBundleVersionControl - -64;
		obj2 = 0;
		_ = 0;
		_ = 0;
		object obj3 = assetBundleVersionControl + 40;
		_ = 0;
		object filename = "DownloadableAssetBundlesManifest";
		if (!downloadables)
		{
			filename = "ShippedAssetBundlesManifest";
		}
		string manifestPath = assetBundleVersionControl.GetManifestPath((string)filename);
		Dictionary<string, int> result;
		if (manifestPath == string.Empty)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S4_v19 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
			Dictionary<string, int> dictionary = default;
			result = dictionary;
			goto IL_08d5;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj12;
		Dictionary<string, int> dictionary3;
		Dictionary<string, int> result2;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj4 = default;
					if (obj4 == null)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_0a28;
							}
						}
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj5 = default;
											Dictionary<string, int> dictionary2 = default;
											if (obj5 == null)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag = (nint)0 != 1;
												result = dictionary2;
												if (flag)
												{
													goto IL_08d5;
												}
											}
											else
											{
												_ = 0;
												object obj6 = assetBundleVersionControl + 16;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = assetBundleVersionControl.OnDownloadableAssetBundlesUpdated;
													object obj7 = assetBundleVersionControl - -64;
													obj7 = assetBundleVersionControl._downloadableBundlesData;
													_ = assetBundleVersionControl._availableBundlesData;
													bool initialized = (byte)(assetBundleVersionControl + 56) != 0;
													assetBundleVersionControl._initialized = initialized;
													assetBundleVersionControl._availableBundlesData = null;
													assetBundleVersionControl._shippedBundlesData = (Dictionary<string, int>)assetBundleVersionControl._initialized;
													object obj9 = default;
													object obj10 = default;
													object obj11 = default;
													Dictionary<string, int> dictionary4 = default;
													object availableBundlesData = default;
													object obj13 = default;
													Dictionary<string, int> dictionary5 = default;
													while (true)
													{
														_ = 0;
														object obj8 = assetBundleVersionControl + 56;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															if (obj9 == null)
															{
																goto IL_0676;
															}
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (AssetBundleVersionControl)+44]");
															assetBundleVersionControl._initialized = false;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = assetBundleVersionControl._initialized;
																_ = 0;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					continue;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			goto IL_05d7;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_05d7;
														IL_05d7:
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
														bool flag2 = obj10 != obj11;
														obj12 = obj10;
														dictionary3 = dictionary4;
														if (flag2)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
														assetBundleVersionControl._availableBundlesData = (Dictionary<string, int>)availableBundlesData;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															goto IL_0676;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														obj12 = obj13;
														dictionary3 = dictionary5;
														break;
														IL_0676:
														_ = 0;
														object obj14 = assetBundleVersionControl + 16;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag3 = (nint)0 != 1;
														result = dictionary2;
														if (!flag3)
														{
															goto IL_070a;
														}
														goto IL_08d5;
													}
													_ = 0;
													object obj15 = assetBundleVersionControl + 16;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														goto IL_099e;
													}
													result2 = dictionary3;
													goto IL_0ae3;
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
		}
		goto IL_070a;
		IL_08d5:
		return result;
		IL_0a28:
		string msg = "Unable to read " + manifestPath;
		assetBundleVersionControl.LogError(msg);
		result = null;
		goto IL_08d5;
		IL_070a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj16 = default;
		obj12 = obj16;
		Dictionary<string, int> dictionary6 = default;
		result2 = dictionary6;
		goto IL_0ae3;
		IL_0b0c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result2;
		IL_099e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_09c6;
		IL_0ae3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj17 = default;
		if (obj17 == obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Dictionary<string, int> dictionary7 = default;
				nint num3 = (nint)dictionary7;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj18 = default;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj19 = (nint)0 << 2;
						object obj20 = obj3 + obj19;
						obj20 = dictionary7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj21 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj22 = (nint)0 << 2;
						object obj23 = obj22 + obj3;
						object obj24 = obj23 - 4;
						object obj25 = obj24;
						bool flag4 = obj24 == null;
						string text = null;
						string text2 = "Exception caught attempting to load ";
						string text3 = ":";
						if (!flag4)
						{
							object obj26 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v581 @ S1_v63+D4] (should have been resolved before IL gen)");
							string text4 = default;
							text = text4;
							text2 = "Exception caught attempting to load ";
							text3 = ":";
						}
						string msg2 = text2 + manifestPath + text3 + text;
						assetBundleVersionControl.LogError(msg2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
						object obj27 = -1;
						goto IL_0a28;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj28 = dictionary7;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					dictionary3 = dictionary7;
					if (flag5)
					{
						goto IL_09c6;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			Dictionary<string, int> dictionary8 = default;
			dictionary3 = dictionary8;
			result2 = dictionary8;
			if (!flag6)
			{
				goto IL_099e;
			}
		}
		goto IL_0b0c;
		IL_09c6:
		result2 = dictionary3;
		goto IL_0b0c;
	}

	private string GetManifestPath(string filename)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		RuntimePlatform platform = Application.platform;
		object path;
		if (platform <= RuntimePlatform.Android)
		{
			if (platform != RuntimePlatform.OSXEditor)
			{
				object obj3 = platform - 7;
				if (platform == RuntimePlatform.WindowsEditor)
				{
					goto IL_019b;
				}
				bool flag = (nint)obj3 == 1;
				path = "ios";
				if (!flag)
				{
					if ((nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4)
					{
						goto IL_01a9;
					}
					path = "android";
				}
			}
			else
			{
				bool useManifestsForAssetBundlesInEditor = DebugSettings.UseManifestsForAssetBundlesInEditor;
				path = "android";
				if (!useManifestsForAssetBundlesInEditor)
				{
					return string.Empty;
				}
			}
			goto IL_0263;
		}
		object obj4 = platform - 17;
		if (platform == RuntimePlatform.WebGLPlayer)
		{
			goto IL_019b;
		}
		if ((nint)obj4 != 1 && (nint)obj4 != 2)
		{
			bool flag2 = (nint)obj4 == 3;
			path = "wp";
			if (flag2)
			{
				goto IL_0263;
			}
		}
		goto IL_01a9;
		IL_01a9:
		RuntimePlatform platform2 = Application.platform;
		_ = -1;
		obj = (Enum)(object)typeof(RuntimePlatform);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		string msg = "No manifest folder found for platform: " + text;
		((AssetBundleVersionControl)(object)obj).LogError(msg);
		return string.Empty;
		IL_019b:
		path = "";
		goto IL_0263;
		IL_0263:
		string path2 = Path.Combine("AssetBundleManifests/", (string)path);
		return Path.Combine(path2, filename);
	}

	private void LoadAvailableBundlesData()
	{
		//IL_002f: Expected I, but got Obj
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_006b: Expected I, but got Obj
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		if (!File.Exists(_versionInfoFilePath))
		{
			CreateAvailableBundlesVersionInfo(_shippedBundlesData, _downloadableBundlesData);
			return;
		}
		StreamReader streamReader = File.OpenText(_versionInfoFilePath);
		nint num = (nint)streamReader;
		object obj = streamReader + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v5 (Il2CppClass<System.IO.StreamReader>)+11C] (should have been resolved before IL gen)");
		string serializedData = default;
		Dictionary<string, int> availableBundlesData = AssetBundleManager.ParseAssetBundleVersionData(serializedData);
		_availableBundlesData = availableBundlesData;
		nint num2 = (nint)streamReader;
		object obj2 = streamReader + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S1_v11 (Il2CppClass<System.IO.StreamReader>)+F4] (should have been resolved before IL gen)");
	}

	private void SaveAvailableBundlesData()
	{
		string contents = AssetBundleManager.SerializeAssetBundleVersionData(_availableBundlesData);
		File.WriteAllText(_versionInfoFilePath, contents);
	}

	private void DeleteAvailableBundlesData()
	{
		if (File.Exists(_versionInfoFilePath))
		{
			File.Delete(_versionInfoFilePath);
		}
	}

	private void Log(string msg)
	{
	}

	private void LogWarning(string msg)
	{
	}

	private void LogError(string msg)
	{
		string text = "[AssetBundleVersionControl]: " + msg;
	}
}
