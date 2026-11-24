using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Utilities;

[Serializable]
[StructLayout((LayoutKind)0, Size = 12)]
public struct Vector3i
{
	public int x;

	public int y;

	public int z;

	public static Vector3i zero
	{
		get
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected Obj, but got Unknown
			//IL_003d: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			Vector3i vector3i = default;
			object obj = vector3i + 12;
			object obj2 = default;
			obj = obj2;
			ScriptableObject.CreateScriptableObject((ScriptableObject)vector3i);
			return vector3i;
		}
	}

	public unsafe static Vector3i one
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0033: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			Vector3i vector3i = default;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->y = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			return vector3i;
		}
	}

	public unsafe static Vector3i forward
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0033: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			Vector3i vector3i = default;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			((Vector3i*)(nint)vector3i)->x = 1;
			((Vector3i*)(nint)vector3i)->y = 1;
			((Vector3i*)(nint)vector3i)->z = 1;
			return vector3i;
		}
	}

	public unsafe static Vector3i back
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0033: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			Vector3i vector3i = default;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->y = 0;
			((Vector3i*)(nint)vector3i)->z = 1;
			return vector3i;
		}
	}

	public unsafe static Vector3i up
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0033: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			Vector3i vector3i = default;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->y = 0;
			((Vector3i*)(nint)vector3i)->z = -1;
			return vector3i;
		}
	}

	public unsafe static Vector3i down
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0033: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			Vector3i vector3i = default;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->y = 1;
			((Vector3i*)(nint)vector3i)->z = 0;
			return vector3i;
		}
	}

	public unsafe static Vector3i right
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0033: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			Vector3i vector3i = default;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->y = -1;
			((Vector3i*)(nint)vector3i)->z = 0;
			return vector3i;
		}
	}

	public unsafe static Vector3i left
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0033: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			Vector3i vector3i = default;
			((Vector3i*)(nint)vector3i)->x = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			((Vector3i*)(nint)vector3i)->x = 1;
			((Vector3i*)(nint)vector3i)->y = 0;
			((Vector3i*)(nint)vector3i)->z = 0;
			return vector3i;
		}
	}

	public Vector3i(int x, int y, int z)
	{
		throw new ArrayTypeMismatchException();
	}

	public unsafe Vector3 AsVector3()
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0129: Expected F4, but got Ref
		//IL_0124: Expected native int or pointer, but got VT
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_0181: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_011a: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = vector + 12;
		obj2 = "Utilities";
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		nint num4 = (nint)typeof(Log);
		if (!flag)
		{
			nint num5 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Log);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Log);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
		object obj4 = (nint)0 + (nint)52;
		obj4 = vector;
		return vector;
	}

	public static implicit operator Vector3(Vector3i v3i)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = v3i + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8641");
		Vector3 result = default;
		return result;
	}

	public static Vector3i operator +(Vector3i a, Vector3i b)
	{
		//IL_000f: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		Uri uri = UriExtensions.Append(null, (string[])b);
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S4_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S4_v5+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S5_v4 (should have been resolved before IL gen)");
		Vector3i result = default;
		return result;
	}

	public unsafe static Vector3i operator -(Vector3i a, Vector3i b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00d9: Expected native int or pointer, but got VT
		//IL_00e7: Expected native int or pointer, but got VT
		//IL_00f9: Expected I4, but got Obj
		//IL_0101: Expected native int or pointer, but got VT
		//IL_012b: Expected native int or pointer, but got VT
		//IL_0155: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 60;
		obj = a.x;
		_ = a.z;
		object obj3 = obj2 + 48;
		obj3 = b.x;
		_ = b.z;
		object obj4 = obj2 + 36;
		obj4 = a.x;
		_ = a.z;
		object obj5 = obj2 + 24;
		obj5 = b.x;
		_ = b.z;
		object obj6 = obj2 + 12;
		obj6 = a.x;
		_ = a.z;
		obj2 = b.x;
		_ = b.z;
		Vector3i vector3i = default;
		((Vector3i*)(nint)vector3i)->x = 0;
		((Vector3i*)(nint)vector3i)->z = 0;
		int num = (int)(obj3 + obj);
		((Vector3i*)(nint)vector3i)->x = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15+4]");
		int num3 = (int)(num2 + 0);
		((Vector3i*)(nint)vector3i)->y = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v25+8]");
		int num5 = (int)(num4 + 0);
		((Vector3i*)(nint)vector3i)->z = num5;
		return vector3i;
	}

	public override string ToString()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public unsafe override bool Equals(object obj)
	{
		//IL_00eb: Expected Obj, but got Ref
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_0154: Expected I4, but got Obj
		//IL_01db: Expected VT, but got Obj
		//IL_01f6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00e5: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I4
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		string localPath = ((Uri)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)).LocalPath;
		nint num = (nint)typeof(UriExtensions._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<SYBO.Components.Utilities.UriExtensions+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UriExtensions._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v50 (Il2CppClass<SYBO.Components.Utilities.UriExtensions+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UriExtensions._003C_003Ec._003C_003E9__0_0 == null;
		bool flag2 = !flag;
		bool add = (byte)(int)UriExtensions._003C_003Ec._003C_003E9__0_0 != 0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(UriExtensions._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v24 (Il2CppClass<SYBO.Components.Utilities.UriExtensions+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UriExtensions._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v44 (Il2CppClass<SYBO.Components.Utilities.UriExtensions+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			bool flag3 = default;
			object obj4 = (flag3 ? 1 : 0) + 16;
			obj4 = UriExtensions._003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(UriExtensions._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v41 (Il2CppClass<SYBO.Components.Utilities.UriExtensions+<>c>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = flag3;
			add = flag3;
		}
		bool flag4 = ((System.Linq.Set<TElement>)obj).Find((TElement)localPath, add);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)flag4);
		return (byte)(int)uri != 0;
	}

	public bool Equals(Vector3i other)
	{
		//IL_000e: Expected I4, but got Obj
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe override int GetHashCode()
	{
		//IL_000b: Expected Obj, but got Ref
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8646");
		int result = default;
		return result;
	}

	public unsafe static Vector3i operator *(Vector3i a, int scale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_00e2: Expected native int or pointer, but got VT
		//IL_00f0: Expected native int or pointer, but got VT
		//IL_0102: Expected I4, but got Obj
		//IL_010a: Expected native int or pointer, but got VT
		//IL_0134: Expected native int or pointer, but got VT
		//IL_015e: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 60;
		obj = a.x;
		_ = a.z;
		object obj3 = obj2 + 48;
		obj3 = ((int*)scale)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [scale @ L2 (System.Int32)+8]");
		_ = 0;
		object obj4 = obj2 + 36;
		obj4 = a.x;
		_ = a.z;
		object obj5 = obj2 + 24;
		obj5 = ((int*)scale)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [scale @ L2 (System.Int32)+8]");
		_ = 0;
		object obj6 = obj2 + 12;
		obj6 = a.x;
		_ = a.z;
		obj2 = ((int*)scale)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [scale @ L2 (System.Int32)+8]");
		_ = 0;
		Vector3i vector3i = default;
		((Vector3i*)(nint)vector3i)->x = 0;
		((Vector3i*)(nint)vector3i)->z = 0;
		int num = obj - obj3;
		((Vector3i*)(nint)vector3i)->x = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15+4]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20+4]");
		int num3 = (int)(num2 - 0);
		((Vector3i*)(nint)vector3i)->y = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v25+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		int num5 = (int)(num4 - 0);
		((Vector3i*)(nint)vector3i)->z = num5;
		return vector3i;
	}

	public static bool operator ==(Vector3i a, Vector3i b)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		object obj = b.x;
		_ = b.z;
		object obj2 = a + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8649");
		bool result = default;
		return result;
	}

	public static bool operator !=(Vector3i a, Vector3i b)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = b.x;
		_ = b.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8649");
		bool result = default;
		return result;
	}

	public static int Manhatten(Vector3i a, Vector3i b)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		object obj = a.x;
		_ = a.z;
		object obj2 = obj + 12;
		obj2 = b.x;
		_ = b.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8656");
		object obj3 = default;
		return obj3 ^ 1;
	}
}
