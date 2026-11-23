using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

namespace Proyecto26;

[Serializable]
public class ResponseHelper
{
	private UnityWebRequest Request__BackingField;

	public UnityWebRequest Request
	{
		get
		{
			return Request__BackingField;
		}
		private set
		{
			Request__BackingField = value;
		}
	}

	public long StatusCode => Request__BackingField.responseCode;

	public byte[] Data
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0285: Expected Obj, but got I
			//IL_01cf: Expected Obj, but got I
			//IL_01fa: Expected Obj, but got I
			//IL_021f: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			UnityWebRequest unityWebRequest = Request__BackingField;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			byte[] result;
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				byte[] array = default;
				result = array;
				if (flag)
				{
					goto IL_0328;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj4 = default;
			object obj5 = default;
			bool flag2 = obj4 != obj5;
			byte[] array2 = default;
			byte[] result2 = array2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj7 = default;
					object obj6 = obj7;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj8 = default;
						if (obj8 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
							object obj9 = (nint)0 << 2;
							object obj10 = obj3 + obj9;
							obj10 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
							object obj11 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
							object obj12 = -1;
							result = null;
							goto IL_0328;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj13 = obj7;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						result2 = (byte[])0;
						if (flag3)
						{
							goto IL_032d;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				byte[] array3 = default;
				result2 = array3;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					result2 = array3;
				}
			}
			goto IL_032d;
			IL_0328:
			return result;
			IL_032d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result2;
		}
	}

	public string Text
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_02a7: Expected Obj, but got I
			//IL_01cf: Expected Obj, but got I
			//IL_01fa: Expected Obj, but got I
			//IL_0228: Expected Obj, but got I
			//IL_023e: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			UnityWebRequest unityWebRequest = Request__BackingField;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			string result;
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				string text = default;
				result = text;
				if (flag)
				{
					goto IL_034a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj4 = default;
			object obj5 = default;
			bool flag2 = obj4 != obj5;
			string text2 = default;
			string result2 = text2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj7 = default;
					object obj6 = obj7;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj8 = default;
						if (obj8 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
							object obj9 = (nint)0 << 2;
							object obj10 = obj3 + obj9;
							obj10 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
							object obj11 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v80+5C]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
							object obj13 = -1;
							result = (string)obj12;
							goto IL_034a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj14 = obj7;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						result2 = (string)0;
						if (flag3)
						{
							goto IL_034f;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				string text3 = default;
				result2 = text3;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					result2 = text3;
				}
			}
			goto IL_034f;
			IL_034a:
			return result;
			IL_034f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result2;
		}
	}

	public string Error => Request__BackingField.error;

	public Dictionary<string, string> Headers => Request__BackingField.GetResponseHeaders();

	public ResponseHelper(UnityWebRequest request)
	{
		Request__BackingField = request;
	}

	public string GetHeader(string name)
	{
		return Request__BackingField.GetResponseHeader(name);
	}

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
