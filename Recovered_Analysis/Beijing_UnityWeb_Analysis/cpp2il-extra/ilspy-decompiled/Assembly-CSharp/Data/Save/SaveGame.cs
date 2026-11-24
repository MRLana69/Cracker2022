using System;
using Cpp2ILInjected;
using Data.Save.Internal;

namespace Data.Save;

public class SaveGame
{
	private const string DEBUG_SUFFIX = "_debug";

	private SaveData<LocalData> _local;

	private SaveData<CloudData> _cloud;

	private SaveData<LocalDebugData> _localDebug;

	public LocalData local
	{
		get
		{
			//IL_0024: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+94]");
			object obj = (nint)0 + (nint)16;
			object obj2 = (object)this << 2;
			return (LocalData)(object)(obj + obj2);
		}
	}

	public CloudData cloud
	{
		get
		{
			SaveData<LocalData> saveData = _local;
			return (CloudData)(object)saveData._diskData;
		}
	}

	public LocalDebugData localDebug
	{
		get
		{
			SaveData<CloudData> saveData = _cloud;
			return (LocalDebugData)(object)saveData._diskData;
		}
	}

	public SaveDataStrings debug_dataSerialized
	{
		get
		{
			SaveData<LocalDebugData> saveData = _localDebug;
			return (SaveDataStrings)(object)saveData._diskData;
		}
		set
		{
			//IL_0024: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+94]");
			object obj = (nint)0 + (nint)16;
			object obj2 = (object)this << 2;
			object obj3 = obj + obj2;
			obj3 = value;
		}
	}

	public SaveGame(string localPath, string cloudPath)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		obj = this;
		obj2 = localPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v3+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S4_v7+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S4_v8+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void Save()
	{
		((DataManager<>)this).OnSaveGameChanged();
	}

	public void Load()
	{
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		((SaveData<>)(object)_local).SaveIfDirty();
		_cloud.Save();
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v20 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			((SaveData<>)(object)_localDebug).SaveIfDirty();
		}
	}

	public void MigrateToCloud(string newCloudPath)
	{
		//IL_0043: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		int stringLength = newCloudPath.m_stringLength;
		bool flag;
		if (newCloudPath.m_stringLength != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Int32)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			((SaveData<>)(object)_local)._002Ector((string)newCloudPath.m_stringLength);
		}
		char firstChar = newCloudPath.m_firstChar;
		bool flag2;
		if (newCloudPath.m_firstChar != '\0')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v11 (System.Char)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (!flag2)
		{
			((SaveData<>)(object)_cloud)._002Ector((string)newCloudPath.m_firstChar);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newCloudPath @ L1 (System.String)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newCloudPath @ L1 (System.String)+10]");
		bool flag3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v16+8]");
			flag3 = (nint)0 == 0;
		}
		else
		{
			flag3 = true;
		}
		if (!flag3)
		{
			SaveData<LocalDebugData> saveData = _localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newCloudPath @ L1 (System.String)+10]");
			((SaveData<>)(object)saveData)._002Ector((string)0);
		}
	}
}
