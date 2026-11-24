using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace NaughtyAttributes;

public class DropdownList<T> : IDropdownList, IEnumerable<KeyValuePair<string, object>>, IEnumerable
{
	private List<KeyValuePair<string, object>> values;

	public DropdownList()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v3+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v4+54]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21 @ S2_v4 (should have been resolved before IL gen)");
		object obj9 = this + 8;
		object obj10 = default;
		obj9 = obj10;
	}

	public void Add(string displayName, T value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_0408: Expected Obj, but got I
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected VT, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected VT, but got Unknown
		//IL_019b: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01bc: Expected VT, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_031c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NaughtyAttributes.DropdownList`1<T>)+34]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NaughtyAttributes.DropdownList`1<T>)+34]");
		object obj3;
		object obj4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NaughtyAttributes.DropdownList`1<T>)+34]");
			object obj2 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
			obj3 = 0;
			obj4 = obj2;
		}
		else
		{
			obj4 = this;
			obj3 = 1;
		}
		object obj5 = default;
		object obj23 = default;
		object obj21 = default;
		for (; obj5 != obj3; obj5 = obj23 + 1)
		{
			object obj6 = obj5 << 2;
			object obj7 = obj4 + obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+14]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+28]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+24]");
			object obj11 = (nint)0 & (nint)0x10;
			bool flag = obj11 == null;
			object obj12 = (flag ? 1 : 0) ^ 1;
			T val;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+2A]");
				if ((nint)0 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
					object obj13 = (nint)0 & (nint)0x3FFF;
					object obj14 = obj13 + 97173;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S3_v17 (should have been resolved before IL gen)");
					val = (T)97173;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
					object obj15 = (nint)0 & (nint)0x1FFF;
					val = (T)(obj15 + 113696);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v164 @ S4_v6 (T) (should have been resolved before IL gen)");
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+28]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
				bool flag2;
				if ((nint)0 != 0)
				{
					object obj16 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v62+9C]");
					object obj17 = (nint)0 & (nint)0x100;
					flag2 = obj17 != null;
				}
				else
				{
					flag2 = false;
				}
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NaughtyAttributes.DropdownList`1<T>)+C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
							object obj18 = (nint)0 & (nint)0x3FFF;
							object obj19 = obj18 + 97173;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v165 @ S3_v12 (should have been resolved before IL gen)");
							val = (T)97173;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+2B]");
						object obj20 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj20 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
							}
						}
						else if (obj21 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
							val = value;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
						}
						continue;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
			object obj22 = (nint)0 & (nint)0x1FFF;
			val = (T)(obj22 + 113696);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v164 @ S4_v6 (T) (should have been resolved before IL gen)");
		}
	}

	public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0xFFF;
		object obj4 = obj3 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v11 @ S2_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		IEnumerator<KeyValuePair<string, object>> result = default;
		return result;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10B1B");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		IEnumerator result = default;
		return result;
	}

	public static explicit operator DropdownList<object>(DropdownList<T> target)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v3+4]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
		DropdownList<object> result = default;
		return result;
	}
}
