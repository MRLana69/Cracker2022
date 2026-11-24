using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace InAppPurchase;

[StructLayout((LayoutKind)0, Size = 16)]
public struct ProductRequestResultInfo
{
	public string productId;

	public string localizedPrice;

	public string title;

	public string description;

	public unsafe void Init(string productId, string localizedPrice, string title, string description)
	{
		//IL_0005: Expected Obj, but got Ref
		//IL_0015: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_061e: Expected Obj, but got I
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_05b9: Expected Obj, but got I
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05da: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_04c8: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04ad: Expected Obj, but got I4
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.ProductRequestResultInfo)+34]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.ProductRequestResultInfo)+34]");
		object obj4;
		object obj5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.ProductRequestResultInfo)+34]");
			object obj3 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
			obj4 = 0;
			obj5 = obj3;
		}
		else
		{
			obj5 = obj;
			obj4 = 1;
		}
		object obj6 = default;
		object obj26 = default;
		object obj18 = default;
		object obj24 = default;
		for (; obj6 != obj4; obj6 = obj26 + 1)
		{
			object obj7 = obj6 << 2;
			object obj8 = obj5 + obj7;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+14]");
			string text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (System.String)+28]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (System.String)+2A]");
			bool flag = (nint)0 == 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (System.String)+24]");
			object obj11 = (nint)0 & (nint)0x10;
			bool flag2 = obj11 == null;
			object obj12 = (flag2 ? 1 : 0) ^ 1;
			string text3;
			string text2;
			if (obj12 != null)
			{
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
					object obj13 = (nint)0 & (nint)0x7FF;
					text2 = (string)(obj13 + 121922);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v206 @ S5_v16 (System.String) (should have been resolved before IL gen)");
					text3 = (string)121922;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
					object obj14 = (nint)0 & (nint)0x3FF;
					text3 = (string)(obj14 + 123986);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v204 @ S6_v6 (System.String) (should have been resolved before IL gen)");
					text2 = text;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (System.String)+28]");
			bool flag3 = (nint)0 != -1;
			if (!flag)
			{
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+10]");
					bool flag4;
					if ((nint)0 != 0)
					{
						object obj15 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v94+9C]");
						object obj16 = (nint)0 & (nint)0x100;
						flag4 = obj16 != null;
					}
					else
					{
						flag4 = false;
					}
					if (!flag4 && this.description != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (System.String)+2B]");
						object obj17 = (nint)0 & (nint)3;
						bool flag5 = (nint)obj17 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag5)
						{
							if (obj18 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8961");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8962");
							}
						}
						else if (obj18 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
							text2 = description;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
				object obj19 = (nint)0 & (nint)0x7FF;
				text2 = (string)(obj19 + 121922);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v206 @ S5_v16 (System.String) (should have been resolved before IL gen)");
				text3 = (string)121922;
				continue;
			}
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+10]");
				bool flag6;
				if ((nint)0 != 0)
				{
					object obj20 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v66+9C]");
					object obj21 = (nint)0 & (nint)0x100;
					flag6 = obj21 != null;
				}
				else
				{
					flag6 = false;
				}
				if (!flag6 && this.description != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+10]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
						object obj22 = (nint)0 & (nint)0x7FF;
						text2 = (string)(obj22 + 121922);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v206 @ S5_v16 (System.String) (should have been resolved before IL gen)");
						text3 = (string)121922;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (System.String)+2B]");
					object obj23 = (nint)0 & (nint)3;
					bool flag7 = (nint)obj23 == 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
					if (flag7)
					{
						if (obj24 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8963");
							text2 = description;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8964");
							text2 = description;
						}
					}
					else if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
						text3 = description;
						text2 = title;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8966");
						text2 = description;
					}
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
			object obj25 = (nint)0 & (nint)0x3FF;
			text3 = (string)(obj25 + 123986);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v204 @ S6_v6 (System.String) (should have been resolved before IL gen)");
			text2 = text;
		}
	}
}
