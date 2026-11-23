using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public static class fsVersionManager
{
	private static readonly Dictionary<Type, fsOption<fsVersionedType>> _cache;

	public unsafe static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected VT, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected VT, but got Unknown
		//IL_0184: Expected I4, but got VT
		//IL_017f: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 48;
		List<fsVersionedType> list = default;
		list._002Ector();
		ref List<fsVersionedType> reference = ref *(List<fsVersionedType>*)list;
		_ = targetVersion.ModelType;
		_ = targetVersion.Ancestors;
		fsVersionedType current = (fsVersionedType)(obj + 24);
		if (!GetVersionImportPathRecursive(path, currentVersion, current))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		_ = targetVersion.ModelType;
		_ = targetVersion.Ancestors;
		fsVersionedType item = (fsVersionedType)(obj + 8);
		path.Add(item);
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		return fsResult2;
	}

	private unsafe static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01b1: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0135: Expected native int or pointer, but got VT
		//IL_0169: Expected Obj, but got I
		//IL_0164: Expected native int or pointer, but got VT
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected VT, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		object obj = default;
		fsVersionedType fsVersionedType2 = (fsVersionedType)(obj - 80);
		fsVersionedType[] ancestors = current.Ancestors;
		object obj2 = 0;
		bool flag;
		while (true)
		{
			flag = (nint)obj2 < ancestors.Length;
			if (!flag)
			{
				break;
			}
			object obj3 = fsVersionedType2 - -64;
			object obj4 = obj2 * 12;
			object obj5 = (object)ancestors + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v10+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v10+10]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+44]");
			if (!((string)0 == currentVersion))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+30]");
				_ = 0;
				fsVersionedType current2 = (fsVersionedType)(fsVersionedType2 + 16);
				if (!GetVersionImportPathRecursive(path, currentVersion, current2))
				{
					object obj6 = obj2 + 1;
					obj2 = obj6;
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+48]");
			System.Runtime.CompilerServices.Unsafe.Write(&((fsVersionedType*)(nint)fsVersionedType2)->ModelType, (Type)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+44]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+20]");
			System.Runtime.CompilerServices.Unsafe.Write(&((fsVersionedType*)(nint)fsVersionedType2)->Ancestors, (fsVersionedType[])0);
			path.Add(fsVersionedType2);
			break;
		}
		return flag;
	}

	public unsafe static fsOption<fsVersionedType> GetVersionedType(Type type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Ref, but got Unknown
		//IL_046b: Expected VT, but got I
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected VT, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected VT, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03b6: Expected Obj, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected VT, but got Unknown
		//IL_022a: Expected Obj, but got I
		//IL_019f: Expected I, but got Obj
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0424: Expected Obj, but got I
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_0526: Expected VT, but got Obj
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 192;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (_cache.TryGetValue(type, out *(fsOption<fsVersionedType>*)(obj + 176)))
		{
			goto IL_045b;
		}
		fsObjectAttribute attribute = fsPortableReflection.GetAttribute<fsObjectAttribute>(type);
		if (attribute == null)
		{
			goto IL_0592;
		}
		string versionString = attribute.VersionString;
		object obj3;
		if (attribute.VersionString != null)
		{
			obj3 = 0;
			if (versionString._stringLength != 0)
			{
				goto IL_05d1;
			}
		}
		obj3 = 1;
		goto IL_05d1;
		IL_0606:
		object obj4;
		string text4;
		if (obj4 != null)
		{
			bool flag = (object)type == null;
			string text = "fsObject attribute on ";
			string text2 = null;
			if (!flag)
			{
				nint num = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v323 @ S1_v110 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
				text = "fsObject attribute on ";
				string text3 = default;
				text2 = text3;
			}
			text4 = text + text2 + " contains a PreviousModels specifier - it must also include a VersionString modifier";
			goto IL_04eb;
		}
		object obj6;
		object obj5 = obj6;
		bool flag2 = obj6 == null;
		string text5 = null;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v136+C]");
			text5 = (string)0;
		}
		goto IL_05ee;
		IL_04eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Exception ex = default;
		ex._002Ector(text4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (fsOption<fsVersionedType>)text4;
		IL_047d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ValueType valueType = obj + 120;
		_ = -1;
		object obj7 = default;
		valueType = (ValueType)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		string text6 = valueType.ToString();
		text4 = "Unable to create versioned type for ancestor " + text6 + "; please add an [fsObject(VersionString=\"...\")] attribute";
		goto IL_04eb;
		IL_0592:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		fsOption<fsVersionedType> value = (fsOption<fsVersionedType>)(obj + 8);
		_cache.set_Item(type, value);
		goto IL_045b;
		IL_05d1:
		if (obj3 != null)
		{
			if (attribute.PreviousModels == null)
			{
				goto IL_0592;
			}
			object obj8 = attribute + 8;
			obj6 = obj8;
		}
		else
		{
			object obj9 = attribute + 8;
			obj6 = obj9;
			if (attribute.PreviousModels == null)
			{
				obj6 = obj9;
				text5 = null;
				goto IL_05ee;
			}
		}
		string versionString2 = attribute.VersionString;
		if (attribute.VersionString != null)
		{
			obj4 = 0;
			if (versionString2._stringLength != 0)
			{
				goto IL_0606;
			}
		}
		obj4 = 1;
		goto IL_0606;
		IL_045b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		fsOption<fsVersionedType> result = (fsOption<fsVersionedType>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		return result;
		IL_05ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj10 = 0;
		object obj17 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v49+C]");
			if (0 <= (nint)obj10)
			{
				break;
			}
			object obj11 = obj10 << 2;
			object obj12 = obj6 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v89+10]");
			fsOption<fsVersionedType> versionedType = GetVersionedType((Type)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
			if ((nint)0 != 0)
			{
				object obj13 = obj + 120;
				object obj14 = obj + 160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @297E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				object obj15 = obj10 * 12;
				object obj16 = obj17 + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				object obj18 = obj10 + 1;
				obj10 = obj18;
				continue;
			}
			goto IL_047d;
		}
		object obj19 = obj + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = attribute.VersionString;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsVersionedType type2 = (fsVersionedType)(obj + 72);
		VerifyUniqueVersionStrings(type2);
		object obj20 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsVersionedType type3 = (fsVersionedType)(obj + 56);
		VerifyConstructors(type3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		object obj21 = obj - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		obj21 = 0;
		object obj22 = obj + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @732C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		goto IL_0592;
	}

	private static void VerifyConstructors(fsVersionedType type)
	{
		//IL_0192: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I
		ConstructorInfo[] declaredConstructors = fsPortableReflection.GetDeclaredConstructors(type.ModelType);
		fsVersionedType[] ancestors = type.Ancestors;
		object obj = 0;
		object obj9 = default;
		object obj10 = default;
		object obj13 = default;
		fsMissingVersionConstructorException ex = default;
		while (ancestors.Length > (nint)obj)
		{
			object obj2 = obj * 12;
			object obj3 = (object)ancestors + obj2;
			object obj4 = 0;
			object obj14;
			while (true)
			{
				if (declaredConstructors.Length > (nint)obj4)
				{
					object obj5 = obj4 << 2;
					object obj6 = (object)declaredConstructors + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v34+10]");
					object obj7 = 0;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S1_v17+13C] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v36+C]");
					bool flag = (nint)0 == 1;
					bool flag2 = !flag;
					obj9 = obj10;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v36+10]");
						object obj11 = 0;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S1_v23+114] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v19+18]");
						bool flag3 = obj13 == null;
						obj9 = obj13;
						obj14 = obj13;
						if (flag3)
						{
							break;
						}
					}
					object obj15 = obj4 + 1;
					obj4 = obj15;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Type modelType = type.ModelType;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v19+18]");
				ex._002Ector(modelType, (Type)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				obj14 = obj9;
				break;
			}
			object obj16 = obj + 1;
			obj9 = obj14;
			obj = obj16;
		}
	}

	private unsafe static void VerifyUniqueVersionStrings(fsVersionedType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected VT, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_012b: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I
		//IL_0188: Expected native int or pointer, but got VT
		//IL_01a2: Expected Obj, but got I
		//IL_019d: Expected native int or pointer, but got VT
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		object obj = default;
		fsVersionedType fsVersionedType2 = (fsVersionedType)(obj - 48);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Type>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Queue`1<FullSerializer.Internal.fsVersionedType>>>)+4] (should have been resolved before IL gen)");
		_ = type.ModelType;
		_ = type.Ancestors;
		fsVersionedType item = (fsVersionedType)(fsVersionedType2 + 16);
		Queue<fsVersionedType> queue = default;
		queue.Enqueue(item);
		object obj6 = default;
		Dictionary<string, Type> dictionary = default;
		fsDuplicateVersionNameException ex = default;
		Type typeA = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v12 (System.Collections.Generic.Queue`1<FullSerializer.Internal.fsVersionedType>)+14]");
			if ((nint)0 <= (nint)0)
			{
				break;
			}
			object obj2 = fsVersionedType2 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94A9");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+20]");
			object obj3 = 0;
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S3_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Type>>)+54]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S3_v10+4] (should have been resolved before IL gen)");
			object obj5 = obj6 ^ -1;
			object obj7 = obj5 >> 31;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+24]");
				Type type2 = dictionary.get_Item((string)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+28]");
				if ((object)type2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E2");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+28]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+24]");
					ex._002Ector(typeA, (Type)num7, (string)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
					break;
				}
			}
			nint num8 = 0;
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Type>>)+5C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ S5_v5+4] (should have been resolved before IL gen)");
			object obj9 = 0;
			while (true)
			{
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v29+C]");
				if ((nint)obj10 >= 0)
				{
					break;
				}
				object obj11 = obj9 * 12;
				object obj12 = obj3 + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v31+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v31+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+28]");
				System.Runtime.CompilerServices.Unsafe.Write(&((fsVersionedType*)(nint)fsVersionedType2)->ModelType, (Type)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsVersionedType)+20]");
				System.Runtime.CompilerServices.Unsafe.Write(&((fsVersionedType*)(nint)fsVersionedType2)->Ancestors, (fsVersionedType[])0);
				queue.Enqueue(fsVersionedType2);
				object obj13 = obj9 + 1;
				obj9 = obj13;
			}
		}
	}

	static fsVersionManager()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.Internal.fsOption`1<FullSerializer.Internal.fsVersionedType>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, fsOption<fsVersionedType>> cache = default;
		_cache = cache;
	}
}
