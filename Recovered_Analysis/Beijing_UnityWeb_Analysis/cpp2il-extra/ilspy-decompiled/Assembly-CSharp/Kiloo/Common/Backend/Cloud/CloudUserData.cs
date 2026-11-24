using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Backend.Cloud;

public class CloudUserData : ICloudUserData, IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	private readonly IDictionary<string, string> _dict;

	// C# has no syntax for parameterized property 'Item'.
	public string get_Item(string key)
	{
		//IL_002d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		bool flag = (nint)obj == 2;
		return (string)(object)((CloudServer2)this).UpdateItemsCoroutine(key, (IEnumerable<ICloudItem>)flag, (CloudServerRequestCompleteHandler)null);
	}

	public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
	{
		//IL_0015: Expected I4, but got Obj
		//IL_0015: Expected I4, but got Obj
		return (IEnumerator<KeyValuePair<string, string>>)(object)((string)this).Remove((int)",", (int)"\\,");
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		IEnumerator result = default;
		return result;
	}

	public CloudUserData()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[CloudServer] ", (int)this);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}

	public CloudUserData(IDictionary<string, string> dict)
	{
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0417: Expected I4, but got Obj
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_0459: Expected I, but got Obj
		//IL_046f: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0396: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 13;
		object obj3 = obj2 + 12;
		object obj4 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		stringBuilder.Length = (int)"[CloudServer] ";
		StringBuilder stringBuilder2 = stringBuilder.AppendLine((string)(object)this);
		StringBuilder stringBuilder3 = stringBuilder2.AppendLine(" Status: ");
		object obj5 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dict @ L1 (System.Collections.Generic.IDictionary`2<System.String, System.String>)+8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index = default;
		StringBuilder stringBuilder4 = stringBuilder3.FindChunkForIndex(index);
		StringBuilder stringBuilder5 = stringBuilder4.AppendLine(", Items: ");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dict @ L1 (System.Collections.Generic.IDictionary`2<System.String, System.String>)+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dict @ L1 (System.Collections.Generic.IDictionary`2<System.String, System.String>)+C]");
			object obj6 = (nint)0 + (nint)12;
			object obj7 = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dict @ L1 (System.Collections.Generic.IDictionary`2<System.String, System.String>)+C]");
				object obj8 = (nint)0 + (nint)16;
				object obj9 = obj7 << 2;
				object userData = obj8 + obj9;
				Dictionary<string, string> dictionary = CloudUserDataExtensions.ToDictionary((ICloudUserData)userData);
				if (dictionary != null)
				{
					Dictionary<string, string>.Entry[] entries = dictionary.entries;
				}
				else
				{
					Dictionary<string, string>.Entry[] entries = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj10 = default;
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Type type = default;
					object obj11 = ((IConvertible)"\"").ToType(type, (IFormatProvider)(object)"\"");
				}
				else
				{
					object obj11 = "null";
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj12 = default;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Type type2 = default;
					object obj13 = ((IConvertible)"\"").ToType(type2, (IFormatProvider)(object)"\"");
				}
				else
				{
					object obj13 = "null";
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				obj5 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
		}
		else
		{
			StringBuilder stringBuilder6 = stringBuilder5.AppendLine("null");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v21 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v26 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object message = default;
		Debug.LogError(message);
	}

	public void Add(string key, string value)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 12;
		obj2 = key;
		object obj3 = this + 8;
		obj3 = value;
	}
}
