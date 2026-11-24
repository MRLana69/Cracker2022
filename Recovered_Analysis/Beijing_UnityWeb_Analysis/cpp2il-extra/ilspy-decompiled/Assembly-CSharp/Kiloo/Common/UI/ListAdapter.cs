using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Kiloo.Common.Backend;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;

namespace Kiloo.Common.UI;

public class ListAdapter<T> : AbstractListAdapter
{
	public List<T> dataList
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			//IL_0063: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v3+24]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.ListAdapter`1<T>)+8]");
			return (List<T>)0;
		}
		protected set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_024c: Expected Obj, but got I
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00ca: Expected Obj, but got I4
			//IL_006e: Expected Obj, but got I
			//IL_0186: Expected Obj, but got I
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected Obj, but got Unknown
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			nint num = default;
			object obj3 = num + 24;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj5 == null)
				{
					break;
				}
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v76+8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj9 = obj2 + 4;
			object obj10 = obj9 + 1;
			obj9 = obj10;
			object obj11 = obj10 << 2;
			object obj12 = obj2 + obj11;
			obj12 = 43;
			object obj13 = default;
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj14 = (nint)0 << 2;
				object obj15 = obj2 + obj14;
				if ((nint)obj15 == 43)
				{
					object obj16 = obj2 + 4;
					if ((nint)obj16 > -1)
					{
						object obj17 = obj16 + -1;
						obj16 = obj17;
					}
					return;
				}
			}
			object obj18 = default;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	public ListAdapter(List<T> list)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = list;
	}

	public unsafe virtual T GetItem(int index)
	{
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected I, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0330: Expected VT, but got I4
		//IL_0013: Expected Obj, but got I
		//IL_0029: Expected I, but got Obj
		//IL_003f: Expected Obj, but got I
		//IL_0224: Expected I, but got Obj
		//IL_023f: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_00b7: Expected I, but got Obj
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_02c9: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_014d: Expected I, but got Obj
		//IL_019a: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 8);
		object obj2 = obj + 4;
		if (this != null)
		{
			nint num2 = default;
			object obj3 = num2 + 24;
			object obj4 = obj3;
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v21 (Il2CppClass<System.Type>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v48 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = obj4;
			((IntPtr*)num)->m_value = (void*)(nint)obj2;
			Type type = Type.internal_from_handle((IntPtr)num);
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v13 (Il2CppClass<System.Enum>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v37 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((Enum)(object)type).InternalHasFlag((Enum)(object)this))
			{
				object obj7 = obj3;
				nint num7 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v34 (Il2CppClass<System.Type>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v44 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj = obj7;
				((IntPtr*)num)->m_value = (void*)(nint)obj;
				Type enumType = Type.internal_from_handle((IntPtr)num);
				nint num9 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v24 (Il2CppClass<System.Enum>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num10 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v33 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string name = Enum.GetName(enumType, this);
				object obj10 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			}
		}
		int num11 = default;
		return (T)num11;
	}

	public virtual void AddItem(T element)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S2_v2+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15 @ S3_v4 (should have been resolved before IL gen)");
	}

	public virtual void RemoveItem(T element)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v4+4]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v8+C]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S3_v6 (should have been resolved before IL gen)");
	}

	public virtual void RemoveItemAt(int index)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ea: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v4+4]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v8+10]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S2_v9 (should have been resolved before IL gen)");
		object obj12 = default;
		if ((nint)obj12 > 0)
		{
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v13+60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v14+4]");
			object obj15 = 0;
			object obj16 = obj15 & 0x3FFF;
			object obj17 = obj16 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S2_v14 (should have been resolved before IL gen)");
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v16+60]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v17+14]");
			object obj20 = 0;
			object obj21 = obj20 & 0x1FFF;
			object obj22 = obj21 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S3_v11 (should have been resolved before IL gen)");
		}
	}

	public virtual void Clear()
	{
	}

	public virtual void Insert(int index, T element)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected Obj, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected Obj, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Expected Obj, but got Unknown
		//IL_09d0: Expected Obj, but got I4
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected Obj, but got Unknown
		//IL_0a16: Expected Obj, but got I
		//IL_0a2e: Expected Obj, but got I
		//IL_0a3e: Expected Obj, but got I
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Expected Obj, but got Unknown
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Expected Obj, but got Unknown
		//IL_0a7c: Expected Obj, but got I
		//IL_0a8c: Expected Obj, but got I
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected Obj, but got Unknown
		//IL_07d0: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I4
		//IL_0ada: Expected Obj, but got I
		//IL_0aea: Expected Obj, but got I
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected Obj, but got Unknown
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_032d: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_0b57: Expected Obj, but got I8
		//IL_02d7: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I
		//IL_041f: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I
		//IL_036e: Expected I, but got Obj
		//IL_0590: Expected Obj, but got I
		//IL_05c1: Expected Obj, but got I
		//IL_05d1: Expected Obj, but got I
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
		//IL_0615: Expected Obj, but got I
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 40;
		object obj4 = element & 1;
		obj3 = obj4;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 8;
		object obj7 = obj2 + 16;
		obj7 = 0;
		object obj8 = obj2 + 32;
		obj8 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
		int totalLength = default;
		string text = string.ConcatArray((string[])(object)"Download: Complete, fromCache=", totalLength);
		nint num = default;
		object obj9 = num + 12;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v18+60]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v19+8]");
		object obj12 = 0;
		object obj13 = obj12 & 0x3FFF;
		object obj14 = obj13 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74 @ S2_v7 (should have been resolved before IL gen)");
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v9+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v10+10]");
		object obj17 = 0;
		object obj18 = obj17 & 0x3FFF;
		object obj19 = obj18 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v89 @ S3_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj20 = default;
		if (obj20 != null)
		{
			IResponse response = default;
			if (!ResponseExtensions.IsBson(response))
			{
				object obj21 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v202+60]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v203+28]");
				object obj23 = 0;
				object obj24 = obj23 & 0x3FFF;
				object obj25 = obj24 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v132 @ S2_v85 (should have been resolved before IL gen)");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			byte[] array = default;
			if (array != null && array.Length != 0)
			{
				bool totalLength2 = TrustedRoots.VerifyTrust((X509Certificate2)response);
				string text2 = string.ConcatArray((string[])(object)"Online Settings Downloaded:\n", totalLength2 ? 1 : 0);
				object obj26 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S1_v96+60]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S1_v97+8]");
				object obj28 = 0;
				object obj29 = obj28 & 0x3FFF;
				object obj30 = obj29 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v401 @ S2_v36 (should have been resolved before IL gen)");
				byte[] array2 = Checksum.ComputeMD5(array);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.ListAdapter`1<T>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S1_v101+18]");
				if (FileUtil.ArraysAreEqual(array2, (byte[])0))
				{
					object obj32 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S1_v198+60]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S1_v199+8]");
					object obj34 = 0;
					object obj35 = obj34 & 0x3FFF;
					object obj36 = obj35 + 80504;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v241 @ S2_v81 (should have been resolved before IL gen)");
					return;
				}
				object obj37 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v96+60]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S0_v97+38]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj40 = default;
				if (obj40 == null)
				{
					object obj41 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S0_v280+60]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v281+28]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v159 (Il2CppClass<System.DateTime>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num3 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S0_v275 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
				obj6 = systemTimeAsFileTime;
				obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4E5");
				object obj45 = default;
				obj7 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.ListAdapter`1<T>)+18]");
				if ((nint)0 == 0)
				{
					object obj46 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ S0_v227+60]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S0_v228+8]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					object obj49 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v174+60]");
					object obj50 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj51 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S1_v136+60]");
					object obj52 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ S1_v137+24]");
					object obj53 = 0;
					object obj54 = obj53 & 0x3FFF;
					object obj55 = obj54 + 80504;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v243 @ S2_v57 (should have been resolved before IL gen)");
					object obj57 = default;
					object obj56 = obj57 + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S0_v100+8]");
					obj56 = 0;
					object obj58 = obj57 + 24;
					obj58 = array2;
					obj2 = obj7;
					obj5 = obj2;
					object obj59 = this + 16;
					obj59 = obj57;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.ListAdapter`1<T>)+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					}
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj60 = default;
				object obj61 = default;
				if (obj60 != obj61)
				{
					object obj63 = default;
					object obj62 = obj63;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj64 = default;
					string text3 = (string)obj64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj65 = default;
					object obj62 = obj65;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			object obj66 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S1_v90+60]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S1_v91+28]");
			object obj68 = 0;
			object obj69 = obj68 & 0x3FFF;
			object obj70 = obj69 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v246 @ S2_v31 (should have been resolved before IL gen)");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.ListAdapter`1<T>)+1C]");
		IRequest request = KilooWebClient.CreateRequest((string)index, (Uri)0);
		if (request != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public virtual void AddMany(IEnumerable<T> list)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ea: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v4+4]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v8+10]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S2_v9 (should have been resolved before IL gen)");
		object obj12 = default;
		if ((nint)obj12 > 0)
		{
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v13+60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v14+4]");
			object obj15 = 0;
			object obj16 = obj15 & 0x3FFF;
			object obj17 = obj16 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S2_v14 (should have been resolved before IL gen)");
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v16+60]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v17+18]");
			object obj20 = 0;
			object obj21 = obj20 & 0x3FFF;
			object obj22 = obj21 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S3_v11 (should have been resolved before IL gen)");
		}
	}

	public override int GetCount()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.UI.ListAdapter`1<T>)+C]");
		return 0;
	}
}
