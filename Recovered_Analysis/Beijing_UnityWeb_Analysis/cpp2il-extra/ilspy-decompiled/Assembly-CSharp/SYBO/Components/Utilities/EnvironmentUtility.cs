using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using SYBO.Components.Base;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class EnvironmentUtility
{
	public const ActiveTargetPlatform ActiveTargetPlatform = ActiveTargetPlatform.Unknown;

	public const string ActiveTargetPlatformString = "unknown";

	public static bool IsMainThread => true;

	public static bool IsRunningUnitTests
	{
		get
		{
			//IL_001c: Expected Obj, but got I4
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			return ((string)currentManagedThreadId).EndsWith("-batchmode");
		}
	}

	public static string BuildNumber
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(BaseEnvironment);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Base.BaseEnvironment>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BaseEnvironment);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Components.Base.BaseEnvironment>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B2E1");
			string result = default;
			return result;
		}
	}

	public static string Workspace => FileUtility.ConvertToPathWithBackSlashes("BUILD_NUMBER");

	public static string Path => FileUtility.ConvertToPathWithBackSlashes("WORKSPACE");

	public static string GitCommit => FileUtility.ConvertToPathWithBackSlashes("PATH");

	public static string GitBranch => FileUtility.ConvertToPathWithBackSlashes("GIT_COMMIT");

	public static bool IsBatchMode()
	{
		int domainID = Thread.GetDomainID();
		int domainID2 = Thread.GetDomainID();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		bool result = default;
		return result;
	}

	public static bool HasEnvironmentVariable(string name)
	{
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		string assetName = ((AssetLoaderPathAttribute)(object)name).AssetName;
		if (assetName != null)
		{
			string assetName2 = ((AssetLoaderPathAttribute)(object)name).AssetName;
			string fullPath = ((AssetLoaderPathAttribute)(object)name).FullPath;
			nint num = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S2_v4 (Il2CppClass<System.IO.Path>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v9 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = System.IO.Path.SameRoot(assetName2, fullPath);
			return FileUtility.IsLocalPath((string)flag);
		}
		return false;
	}

	public static string GetEnvironmentVariable(string name)
	{
		//IL_0009: Expected I4, but got Obj
		//IL_005f: Expected Obj, but got I4
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)name);
		bool flag = folderPath == null || folderPath.m_stringLength == 0;
		return (string)((flag ? 1 : 0) ^ 1);
	}

	public static void SetEnvironmentVariable(string name, string value)
	{
		//IL_002c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Read-only");
		((PrefabsDict)(object)ex).Add((KeyValuePair<string, Transform>)0);
	}
}
