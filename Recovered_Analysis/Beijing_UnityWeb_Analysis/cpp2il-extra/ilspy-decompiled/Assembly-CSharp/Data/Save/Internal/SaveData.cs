using System;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using UnityEngine;

namespace Data.Save.Internal;

public class SaveData<T> where T : DiskData, new()
{
	private const string SECRET = "";

	private string _path;

	private T _diskData;

	private IBsonSerializer _serializer;

	private byte[] _lastSaved;

	public T diskData => (T)(object)_path;

	public string debug_dataSerialized
	{
		get
		{
			return (string)(object)_diskData;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S2_v2+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v3+1C]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15 @ S3_v4 (should have been resolved before IL gen)");
		}
	}

	public SaveData(string path)
	{
		//IL_0047: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string msg = default;
		FlurryVideoAds.LogError(msg, (UnityEngine.Object)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		object obj3 = this + 12;
		object obj4 = default;
		obj3 = obj4;
	}

	public SaveData(string path, T diskData)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S3_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S3_v3+4C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v18 @ S4_v4 (should have been resolved before IL gen)");
	}

	public void Save()
	{
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_020f: Expected I, but got Obj
		//IL_0225: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v51 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(SaveManager._hasInited ? 1u : 0u) != 0)
		{
			nint num3 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v28 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v47 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveManager.OnAuthenticated();
			nint num5 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v34 (Il2CppClass<Utils>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v43 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			StringComparison stringComparison = Utils.stringComparison;
			string msg = string.ConcatArray((string[])(object)"SaveManager lazy initialized while not in editor - this should not happen! ", (int)stringComparison);
			SDebug.LogFormat(msg, null);
		}
		nint num7 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v16 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v21 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S3_v4 (should have been resolved before IL gen)");
	}

	private void SaveIfDirty()
	{
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		string path = _path;
		if (_path != null && path.m_stringLength != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4+C]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v24 @ S2_v5 (should have been resolved before IL gen)");
		}
	}

	public void Load()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		if (_lastSaved != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj3 = default;
			if (obj3 != null)
			{
				goto IL_0072;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
		goto IL_0072;
		IL_0072:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public void ChangeSavePath(string newSavePath)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = newSavePath;
		object obj2 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v7+8]");
		object obj5 = 0;
		object obj6 = obj5 & 0xFFF;
		object obj7 = obj6 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S2_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		object obj9 = this + 16;
		obj9 = text;
	}
}
