using System;
using Cpp2ILInjected;
using Kiloo.Plugins;
using UnityEngine;

namespace Kiloo.Google.Internal;

internal class GoogleSignInBridgeFactory
{
	public static bool isPlatformSupported
	{
		get
		{
			//IL_0083: Expected I, but got Obj
			//IL_0099: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AndroidGoogleSignInBridge androidGoogleSignInBridge = PluginUtil.CreateBridgeObject<AndroidGoogleSignInBridge>();
			((GoogleSignInBridge)androidGoogleSignInBridge).OnGoogleConnected();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector("Failed to initialize plugin. Check log and make sure Server_Client_Id is configured.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return false;
		}
	}

	public static IGoogleSignInBridge Create()
	{
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC87");
			IGoogleSignInBridge result = default;
			return result;
		}
		return null;
	}

	public GoogleSignInBridgeFactory()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
