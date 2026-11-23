using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
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
		//IL_000d: Expected I, but got Obj
		DirectoryInfo directoryInfo = default;
		directoryInfo._002Ector(ASSET_BUNDLE_CACHE_PATH);
		nint num = (nint)directoryInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v4 (Il2CppClass<System.IO.DirectoryInfo>)+10C] (should have been resolved before IL gen)");
		object obj = default;
		if (obj == null)
		{
			directoryInfo.Create();
		}
		LoadCachedBundlesVersionInfo();
	}

	public unsafe static bool CacheAssetBundle(string bundleName, int version, byte[] bytes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_043b: Expected Obj, but got I
		//IL_0466: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04dc: Expected Obj, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected I4, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_05d0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			goto IL_0324;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool result;
		if ((nint)0 != 1)
		{
			object obj3 = default;
			if (obj3 == null)
			{
				goto IL_01ae;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0324;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj4 = default;
				bool flag = (nint)obj4 > 0;
				result = false;
				if (flag)
				{
					goto IL_0713;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
						goto IL_01ae;
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
		goto IL_0333;
		IL_01ae:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			goto IL_0324;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					RecordCachingInfo(bundleName, 0, CachingAction.Add);
					result = true;
					goto IL_0713;
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
		goto IL_0333;
		IL_0324:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0333;
		IL_0333:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag2 = obj5 == obj6;
		bool flag3 = !flag2;
		bool flag4 = default;
		result = flag4;
		bool flag6 = default;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj13 + obj;
						object obj15 = obj14 - 4;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S0_v83+5C]");
						object path = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						string text = Path.Combine((string)path, bundleName);
						bool flag5 = obj15 == null;
						string text2 = "Could not write file to disk at: ";
						string text3 = " Error writing file to disk: ";
						if (!flag5)
						{
							object obj17 = obj16;
							object obj18 = obj16 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v470 @ S1_v59+D4] (should have been resolved before IL gen)");
							text2 = "Could not write file to disk at: ";
							text3 = " Error writing file to disk: ";
						}
						string text4 = default;
						string msg = text2 + text + text3 + text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						LogError(msg);
						int num = obj + 12;
						string text5 = ((int*)num)->ToString();
						string text6 = bundleName + ";" + text5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj19 = -1;
						result = false;
						goto IL_0713;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj20 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					flag6 = (nint)0 != 1;
					if (flag6)
					{
						goto IL_06cc;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 == 1;
			bool flag8 = default;
			result = flag8;
			if (flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_06cc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0713;
		IL_0713:
		return result;
		IL_06cc:
		return flag6;
	}

	public static void StartBulkCaching()
	{
		_isPerformingBulkCaching = true;
	}

	public static void EndBulkCaching()
	{
		_isPerformingBulkCaching = false;
		SaveCachedBundlesVersionInfo();
	}

	private static void RecordCachingInfo(string bundleName, int version, CachingAction action)
	{
		//IL_0060: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0086: Expected I4, but got Obj
		//IL_010c: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0165: Expected I4, but got Obj
		//IL_00cf: Expected Obj, but got I
		CachingAction cachingAction = default;
		switch (cachingAction)
		{
		case CachingAction.Add:
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			CachingAction cachingAction2 = (CachingAction)(obj2 >> 31);
			if (cachingAction2 == CachingAction.Add)
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ S5_v10+4] (should have been resolved before IL gen)");
				cachingAction = cachingAction2;
			}
			else
			{
				LogError("Recording caching info for a bundle that is already cached. Overwriting info. This might cause verison mismatch.");
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S5_v5+4] (should have been resolved before IL gen)");
				cachingAction = cachingAction2;
			}
			break;
		}
		case CachingAction.Remove:
		{
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S3_v11 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S3_v12+4] (should have been resolved before IL gen)");
			object obj8 = default;
			object obj7 = obj8 ^ -1;
			CachingAction cachingAction3 = (CachingAction)(obj7 >> 31);
			if (cachingAction3 == CachingAction.Add)
			{
				LogError("Attempting to record caching info for removing a bundle that is not cached. Aborting.");
				cachingAction = cachingAction3;
			}
			else
			{
				bool flag = _cachedBundlesVersionInfo.Remove(bundleName);
				cachingAction = cachingAction3;
			}
			break;
		}
		case CachingAction.ClearCache:
			if (_cachedBundlesVersionInfo != null)
			{
				throw new IndexOutOfRangeException();
			}
			break;
		}
		if (~(_isPerformingBulkCaching ? 1u : 0u) != 0)
		{
			SaveCachedBundlesVersionInfo();
		}
	}

	public unsafe static AssetBundle LoadAssetBundle(string bundleName, int version)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		AssetBundle result;
		if (IsAssetBundleCached(bundleName, version))
		{
			string text = Path.Combine(ASSET_BUNDLE_CACHE_PATH, bundleName);
			string message = "path: " + text;
			Debug.Log(message);
			string path = Path.Combine(ASSET_BUNDLE_CACHE_PATH, bundleName);
			AssetBundle assetBundle = AssetBundle.LoadFromFile(path);
			bool flag = assetBundle == null;
			bool flag2 = !flag;
			result = assetBundle;
			if (!flag2)
			{
				int num = obj + 12;
				string text2 = ((int*)num)->ToString();
				string text3 = bundleName + ";" + text2;
				result = assetBundle;
			}
		}
		else
		{
			string msg = "Attemping to load bundle " + bundleName + " but it's not cached. Aborting.";
			LogError(msg);
			result = null;
		}
		return result;
	}

	public static int GetVersionForCachedBundle(string bundleName)
	{
		//IL_004b: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return _cachedBundlesVersionInfo.get_Item(bundleName);
		}
		return -1;
	}

	public static bool IsAssetBundleCached(string bundleName, int version)
	{
		//IL_00d0: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			string path = Path.Combine(ASSET_BUNDLE_CACHE_PATH, bundleName);
			if (!File.Exists(path))
			{
				LogError("Asset Bundle file was not found in the cache. Correcting cache info.");
				int versionForCachedBundle = GetVersionForCachedBundle(bundleName);
				RecordCachingInfo(bundleName, versionForCachedBundle, CachingAction.Remove);
				return false;
			}
			int num3 = _cachedBundlesVersionInfo.get_Item(bundleName);
			return num3 == version;
		}
		return false;
	}

	public static bool RemoveFromCache(string bundleName, int version)
	{
		bool flag = IsAssetBundleCached(bundleName, version);
		if (flag)
		{
			string path = Path.Combine(ASSET_BUNDLE_CACHE_PATH, bundleName);
			File.Delete(path);
			RecordCachingInfo(bundleName, version, CachingAction.Remove);
			return flag;
		}
		string msg = "Attempting to remove bundle " + bundleName + " but it's not cached.";
		LogError(msg);
		return flag;
	}

	public static void ClearCache()
	{
		//IL_0047: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		if (Directory.Exists(ASSET_BUNDLE_CACHE_PATH))
		{
			DirectoryInfo directoryInfo = default;
			directoryInfo._002Ector(ASSET_BUNDLE_CACHE_PATH);
			FileInfo[] files = directoryInfo.GetFiles();
			object obj = 0;
			while (files.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)files + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v43+10]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S1_v13+114] (should have been resolved before IL gen)");
				object obj6 = obj + 1;
				obj = obj6;
			}
			RecordCachingInfo(string.Empty, 0, CachingAction.ClearCache);
		}
		else
		{
			string message = "Directoy: " + ASSET_BUNDLE_CACHE_PATH + "does not exist. Aborting the clearing of Asset Bundle Cache";
			Debug.LogWarning(message);
		}
	}

	private static void LoadCachedBundlesVersionInfo()
	{
		//IL_0078: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		string path = Path.Combine(ASSET_BUNDLE_CACHE_PATH, "CachedBundlesVersionInfo");
		if (!File.Exists(path))
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
			Dictionary<string, int> cachedBundlesVersionInfo = default;
			_cachedBundlesVersionInfo = cachedBundlesVersionInfo;
		}
		else
		{
			StreamReader streamReader = File.OpenText(path);
			nint num3 = (nint)streamReader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S1_v7 (Il2CppClass<System.IO.StreamReader>)+11C] (should have been resolved before IL gen)");
			string serializedData = default;
			Dictionary<string, int> cachedBundlesVersionInfo2 = AssetBundleManager.ParseAssetBundleVersionData(serializedData);
			_cachedBundlesVersionInfo = cachedBundlesVersionInfo2;
			nint num4 = (nint)streamReader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ S1_v12 (Il2CppClass<System.IO.StreamReader>)+F4] (should have been resolved before IL gen)");
		}
	}

	private static void SaveCachedBundlesVersionInfo()
	{
		string path = Path.Combine(ASSET_BUNDLE_CACHE_PATH, "CachedBundlesVersionInfo");
		string contents = AssetBundleManager.SerializeAssetBundleVersionData(_cachedBundlesVersionInfo);
		File.WriteAllText(path, contents);
	}

	private static void Log(string msg)
	{
	}

	private static void LogWarning(string msg)
	{
	}

	private static void LogError(string msg)
	{
		string text = "[AssetBundleCache]: " + msg;
	}

	static AssetBundleCache()
	{
		string userDataPath = DeviceUtility.GetUserDataPath();
		string aSSET_BUNDLE_CACHE_PATH = Path.Combine(userDataPath, "AssetBundles");
		ASSET_BUNDLE_CACHE_PATH = aSSET_BUNDLE_CACHE_PATH;
		_isPerformingBulkCaching = false;
	}
}
