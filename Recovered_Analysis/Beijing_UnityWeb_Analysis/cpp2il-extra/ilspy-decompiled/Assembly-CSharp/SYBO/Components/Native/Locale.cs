using System;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Native;

public class Locale
{
	public static string GetISOThreeLetterLanguageCode()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00d9: Expected I4, but got Obj
		SingletonMonoBehaviourManager instance = SingletonMonoBehaviourManager.Instance;
		if ((object)instance == null)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SingletonMonoBehaviourManager instance2 = UnityEngine.Object.FindObjectOfType<SingletonMonoBehaviourManager>();
			SingletonMonoBehaviourManager._instance = instance2;
			SingletonMonoBehaviourManager instance3 = SingletonMonoBehaviourManager.Instance;
			if ((object)instance3 == null)
			{
				_0021_00210[] instance4 = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
				SingletonMonoBehaviourManager._instance = (SingletonMonoBehaviourManager)(object)instance4;
			}
			SingletonMonoBehaviourManager instance5 = SingletonMonoBehaviourManager.Instance;
			if ((object)instance5 == null)
			{
				string text = $"Instance.get({(object[])(object)SingletonMonoBehaviourManager._instance}) This cannot be null.";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Exception ex = default;
				ex.SetErrorCode((int)text);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		return (string)(object)SingletonMonoBehaviourManager._instance;
	}

	private static string _GetISOThreeLetterLanguageCode()
	{
		return Platform.GetPlatformVersion();
	}

	public Locale()
	{
		_ = 50;
		_ = 0.25f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
