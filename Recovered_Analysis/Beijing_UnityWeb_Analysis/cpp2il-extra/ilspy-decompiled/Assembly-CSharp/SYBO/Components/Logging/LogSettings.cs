using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Logging.Ftp;
using UnityEngine.Events;
using UnityEngine.Profiling.Memory.Experimental;

namespace SYBO.Components.Logging;

[Serializable]
public class LogSettings
{
	public float MemoryBudget;

	public Dictionary<string, LogCategorySettings> Categories;

	public string LogsPathWin;

	public LogFTPSettings Ftp;

	[NonSerialized]
	public UnityEvent Changed;

	public bool ClearOnNewSceneLoaded;

	public int GetLogLevel(string categoryName)
	{
		//IL_0014: Expected I4, but got Obj
		//IL_0022: Expected I4, but got Obj
		LogCategory logCategory = ((List<LogCategory>)(object)Categories).get_Item((int)categoryName);
		return (int)logCategory.CategoryText;
	}

	public unsafe bool HasLogLevel(string categoryName)
	{
		ref LogCategorySettings reference = ref *(LogCategorySettings*)null;
		string[] fileList = ((FtpClient)this).GetFileList(categoryName);
		if (fileList != null)
		{
			if (Categories.TryGetValue(categoryName, out reference))
			{
				LogCategorySettings logCategorySettings = reference;
				return (byte)logCategorySettings.logLevel != 0;
			}
			return false;
		}
		return false;
	}

	public unsafe LogSettings()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected Ref, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_059c: Expected Obj, but got I4
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Ref, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected Obj, but got Unknown
		//IL_0648: Expected Obj, but got I
		//IL_0658: Expected Obj, but got I
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_06a6: Expected Obj, but got I
		//IL_06b6: Expected Obj, but got I
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_07ea: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_00fe: Expected I4, but got Obj
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0786: Expected I4, but got Obj
		//IL_0424: Expected Obj, but got I4
		Dictionary<, >.ValueCollection valueCollection = default;
		object obj = valueCollection - -64;
		ref LogCategorySettings reference = ref *(LogCategorySettings*)(valueCollection + 48);
		reference = ref *(LogCategorySettings*)null;
		object obj2 = valueCollection + 32;
		obj2 = 0;
		_ = 0;
		ref LogCategorySettings reference2 = ref *(LogCategorySettings*)(valueCollection + 24);
		reference2 = ref *(LogCategorySettings*)null;
		object obj3 = valueCollection + 16;
		obj3 = obj;
		_ = -1;
		object obj4 = this + 16;
		Dictionary<string, LogCategorySettings> categories = Categories;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = default;
		obj4 = obj5;
		LogFTPSettings ftp = Ftp;
		if (ftp.StoreLogsFtpUri != null)
		{
			Dictionary<string, LogCategorySettings> categories2 = Categories;
			string storeLogsFtpUri = Ftp.StoreLogsFtpUri;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v100 (System.String)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v100 (System.String)+1C]");
			if (categories2.entries == (object)(num - 0))
			{
				int num2 = 0;
				Dictionary<string, LogCategorySettings> categories3 = Categories;
				if (num2 >= (nint)categories3.entries)
				{
					return;
				}
				LogFTPSettings ftp2 = Ftp;
				LogCategory logCategory = ((List<LogCategory>)(object)Categories).get_Item(num2);
				if (((Dictionary<string, LogCategorySettings>)(object)ftp2.StoreLogsFtpUri).TryGetValue(logCategory.CategoryText, out reference))
				{
					string categoryText = ((LogManager)(object)((List<LogCategory>)(object)Categories).get_Item(num2)).GetCategoryText((int)reference);
					throw new ArrayTypeMismatchException();
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S3_v4 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S3_v5+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v116 @ S4_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S3_v9 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S3_v10+60]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = obj13 & 0x1FFF;
		object obj15 = obj14 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v152 @ S4_v9 (should have been resolved before IL gen)");
		LogFTPSettings ftp3 = Ftp;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE18");
		_00211 item = default;
		((ICollection<TValue>)valueCollection).Add((TValue)item);
		obj2 = valueCollection;
		_ = valueCollection.dictionary;
		object obj16 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj16 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj17 = (object)(obj3 + 4) + 1;
		object obj18 = obj17;
		object obj19 = obj3 + (object)(obj17 << 2);
		obj19 = 270;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19+4]");
			if ((nint)(obj3 + (object)((nint)0 << 2)) == 270)
			{
				object obj20 = obj3 + 4;
				if ((nint)obj20 > -1)
				{
					obj20 += -1;
				}
				goto IL_07d8;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_07d8;
		IL_07d8:
		int num5 = 0;
		object obj22 = 0;
		Dictionary<string, LogCategorySettings> categories4 = Categories;
		if (num5 < (nint)categories4.entries)
		{
			Dictionary<string, LogCategorySettings> dictionary = default;
			if (!dictionary.TryGetValue(((List<LogCategory>)(object)Categories).get_Item(num5).CategoryText, out reference2))
			{
				LogCategory logCategory2 = ((List<LogCategory>)(object)Categories).get_Item(num5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				string key = default;
				if (!dictionary.TryGetValue(key, out reference2))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj23 = default;
					reference2 = ref *(LogCategorySettings*)obj23;
					obj22 = 1;
				}
			}
			LogCategory logCategory3 = ((List<LogCategory>)(object)Categories).get_Item(num5);
			string categoryText2 = ((LogManager)(object)logCategory3).GetCategoryText((int)reference2);
			object obj24 = obj22 | (object)categoryText2;
			throw new ArrayTypeMismatchException();
		}
		object obj25 = Ftp + 12;
		object obj26 = default;
		obj25 = obj26;
		if (obj22 != null)
		{
			if (Ftp.Password != null)
			{
				((MetaData)(object)Ftp.Password)._002Ector();
			}
			else
			{
				((LogManager)this).ReflectionFindCategories();
			}
		}
	}
}
