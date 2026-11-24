using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Settings;

public static class SettingsHelper
{
	public static FieldInfo[] GetAllSerializedFieldsStatic(Type settingsType)
	{
		//IL_00d1: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(SettingsEngine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SettingsEngine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string path = string.Format(SettingsEngine._resourceLoadPath, (object[])(object)settingsType);
		TextAsset textAsset = Resources.Load<TextAsset>(path);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)textAsset).FindKernel((string)null) != 0)
		{
			return (FieldInfo[])(object)textAsset.bytes;
		}
		return null;
	}

	public static bool ShouldSerializeField(FieldInfo field)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		FieldInfo[] fieldsForTree = ReflectionWrapper.GetFieldsForTree((Type)(object)field, (BindingFlags)56);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = fieldsForTree + 12;
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)obj);
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = fieldsForTree + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			string[] callstackPrefixes = ((SettingsLogCategory)obj5).GetCallstackPrefixes();
			if (callstackPrefixes != null)
			{
				((List<T>)(object)list).AddRange((IEnumerable<T>)obj5);
			}
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
		bool result = default;
		return result;
	}
}
