using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Native;
using SYBO.Components.Utilities.Attributes;
using SYBO.Components.Utilities.Tickable;
using SYBO.Components.Utilities.Validators;
using UnityEngine;

namespace SYBO.Components.Utilities.Scriptables;

public static class ScriptablesAccessor
{
	public static ScriptablesAccessorEvent OnUpdatedFields;

	public const BindingFlags PublicStaticFields = (BindingFlags)26;

	public static void UpdateFields(Type partialClass)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TickableScheduler tickableScheduler = default;
		tickableScheduler.OnEnable();
		object obj = partialClass + 16;
		obj = tickableScheduler;
		((Validator<>)(object)partialClass)._002Ector();
	}

	public static bool CanUpdateFields(Type partialClass)
	{
		//IL_0015: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [partialClass @ L0 (System.Type)+14]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+C]");
		return false;
	}

	private static void PopulateFieldsOfType(Type type, FieldInfo[] fields, Func<UnityEngine.Object, FieldInfo, bool> comparator)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_0072: Expected VT, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 + 24;
		obj = fields;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [fields @ L1 (System.Reflection.FieldInfo[])+8]");
		_ = 0;
		object obj3 = obj2 + 12;
		obj3 = fields;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [fields @ L1 (System.Reflection.FieldInfo[])+8]");
		_ = 0;
		obj2 = fields;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [fields @ L1 (System.Reflection.FieldInfo[])+8]");
		_ = 0;
		Type type2 = (Type)0;
		type._impl = (RuntimeTypeHandle)0;
		object obj4 = (object)comparator * obj;
		type2 = (Type)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+4]");
		object obj5 = comparator * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		RuntimeTypeHandle impl = (RuntimeTypeHandle)(comparator * 0);
		type._impl = impl;
	}

	private static void PopulateFieldOfType(Type type, FieldInfo field, UnityEngine.Object asset)
	{
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_01d0: Expected I4, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_013d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = asset;
		if ((object)field == null)
		{
			return;
		}
		object obj3 = field + 12;
		if (obj3 == null)
		{
			return;
		}
		UnityEngine.Object array = Resources.Load((string)(object)type);
		object obj4 = 0;
		object obj6 = default;
		Predicate<_0021_00210> predicate = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj5 = obj6 + 12;
			obj5 = obj2;
			object obj7 = obj6 + 8;
			object obj8 = field + 16;
			object obj9 = obj4 << 2;
			object obj10 = obj8 + obj9;
			obj7 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj11 = predicate + 16;
			obj11 = obj6;
			_0021_00210[] array2 = (_0021_00210[])(object)Array.FindAll<T>((T[])(object)array, (Predicate<T>)(object)predicate);
			nint num2 = (nint)typeof(ScriptablesAccessor);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v40 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num3 = (nint)typeof(ScriptablesAccessor);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v47 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v22+8]");
			((SectionHeaderAttribute)null)._002Ector((string)0, (int)array2);
			object obj13 = obj4 + 1;
			obj4 = obj13;
		}
	}

	static ScriptablesAccessor()
	{
		SingletonMonoBehaviourManager instance = SingletonMonoBehaviourManager.Instance;
		if ((object)instance == null)
		{
			string iSOThreeLetterLanguageCode = Locale.GetISOThreeLetterLanguageCode();
			SingletonMonoBehaviourManager._instance = (SingletonMonoBehaviourManager)(object)iSOThreeLetterLanguageCode;
		}
		SingletonMonoBehaviourManager._instance.LogSingletons();
	}
}
