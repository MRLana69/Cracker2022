using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using SYBO.Components.Json.Internal;

namespace SYBO.Components.Json;

public class FileStringStorage : IStringStorage
{
	private string _path;

	unsafe bool IStringStorage.CanRead
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected Obj, but got Unknown
			//IL_023e: Expected Obj, but got I4
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected Obj, but got Unknown
			//IL_0261: Expected Obj, but got I4
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Expected Obj, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected Obj, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected Obj, but got Unknown
			//IL_0116: Expected Obj, but got I4
			//IL_0313: Expected I4, but got Obj
			//IL_017d: Expected Obj, but got I
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected Obj, but got Unknown
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonReflectionException ex = default;
			ex._002Ector();
			KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)_path)->Current;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj7 = obj5 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj5 + obj9;
			obj10 = 83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj5 + obj11;
				if ((nint)obj12 == 83)
				{
					object obj13 = obj5 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_030e;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_030e;
			IL_030e:
			return (byte)(int)ex != 0;
		}
	}

	public FileStringStorage(string path)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = path;
	}

	bool IStringStorage.Overwrite(string content)
	{
		//IL_0025: Expected I4, but got Obj
		object obj = ((List<object>)this).get_Item((int)content);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		bool flag2 = default;
		bool flag = !flag2;
		bool flag3 = !flag;
		bool result = flag2;
		if (!flag3)
		{
			bool flag4 = JsonParser.LastDecodeSuccessful();
			result = flag4;
		}
		return result;
	}

	string IStringStorage.Read()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object obj3 = JsonParser.DeserializeDom((string)(object)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 26;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj2 + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj2 + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
				goto IL_020f;
			}
		}
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_020f;
		IL_020f:
		string result = default;
		return result;
	}

	private Stream CreateStream()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0381: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_064b: Expected Obj, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object obj3 = JsonParser.DeserializeDom((string)(object)this);
		Stream result = default;
		object obj10 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj6 = default;
				object obj5 = obj6;
				object obj8 = default;
				object obj7 = obj8;
				Stream stream = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj9 = default;
				if (obj5 == obj9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					result = stream;
					object obj11 = default;
					obj10 = obj11;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
			}
			else
			{
				Stream stream = null;
				object obj12 = obj2 + 4;
				object obj13 = obj12 + 1;
				obj12 = obj13;
				object obj14 = obj13 << 2;
				object obj15 = obj2 + obj14;
				obj15 = 69;
				result = stream;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E4D3");
		}
		else
		{
			object obj16 = obj2 + 4;
			object obj17 = obj16 + 1;
			obj16 = obj17;
			object obj18 = obj17 << 2;
			object obj19 = obj2 + obj18;
			obj19 = 69;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj2 + obj20;
			if ((nint)obj21 == 75)
			{
				object obj22 = obj2 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0658;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj24 = (nint)0 << 2;
			object obj25 = obj2 + obj24;
			if ((nint)obj25 == 69)
			{
				object obj26 = obj2 + 4;
				if ((nint)obj26 > -1)
				{
					object obj27 = obj26 + -1;
					obj26 = obj27;
				}
				goto IL_065d;
			}
		}
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_065d;
		IL_065d:
		result = (Stream)(object)string.Empty;
		goto IL_0658;
		IL_0658:
		return result;
	}
}
