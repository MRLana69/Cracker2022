using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Cpp2ILInjected;
using SYBO.Components.Json;

namespace SYBO.Components.Settings;

public class CachingRootFileJsonSettingsParser : ISettingsParser
{
	public delegate string FileTextByPathGetter(string path);

	private FileTextByPathGetter _getFileText;

	private Dictionary<Type, object> _cachedSettings;

	public CachingRootFileJsonSettingsParser(FileTextByPathGetter getFileText, Type rootSettingsType, string rootSettingsPath)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	object ISettingsParser.ReflectionReadSettings(Type settingsType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0029: Expected I4, but got Obj
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CryptoStream cryptoStream = default;
		cryptoStream.Write((byte[])(object)memoryStream, (int)settingsType, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 38;
		if (cryptoStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 38)
			{
				object obj9 = obj2 + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				goto IL_0242;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0242;
		IL_0242:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object result = default;
		return result;
	}

	private unsafe string GetFileText(string path)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a0: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		ref object reference = ref *(object*)null;
		if (!_cachedSettings.TryGetValue((Type)(object)path, out reference))
		{
			nint num = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(JsonClassInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection((Type)(object)path);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer = default;
			jsonCustomSerializer._002Ector();
			JsonFieldInfo[] jsonFields = nonCachedTypeReflection.GetJsonFields((BindingFlags)jsonCustomSerializer);
			reference = ref *(object*)jsonFields;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S4_v4+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S4_v5+48]");
			object obj4 = 0;
			object obj5 = obj4 & 0x7FF;
			object obj6 = obj5 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S5_v5 (should have been resolved before IL gen)");
		}
		return (string)reference;
	}

	private void LoadRootSettings(Type rootSettingsType, string rootSettingsPath)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Exception)this)._002Ector((SerializationInfo)(object)rootSettingsType, (StreamingContext)rootSettingsPath);
	}
}
