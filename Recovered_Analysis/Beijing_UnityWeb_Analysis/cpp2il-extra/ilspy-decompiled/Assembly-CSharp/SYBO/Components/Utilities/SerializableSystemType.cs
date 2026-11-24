using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Validators;
using UnityEngine;

namespace SYBO.Components.Utilities;

[Serializable]
public class SerializableSystemType : ISerializationCallbackReceiver
{
	private string _assemblyQualifiedName;

	private Type _systemType;

	public Type SystemType
	{
		get
		{
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected Obj, but got Unknown
			//IL_00d2: Expected Obj, but got I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0039: Expected I, but got Obj
			//IL_004f: Expected Obj, but got I
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected Obj, but got Unknown
			//IL_010f: Expected Obj, but got I4
			//IL_007a: Expected I, but got Obj
			object obj = this + 12;
			object obj2 = 0;
			Type type = (Type)(object)"";
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = this + 16;
				object obj4 = obj2 << 2;
				object path = obj3 + obj4;
				nint num = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v19 (Il2CppClass<System.IO.Path>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num2 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27 (Il2CppClass<System.IO.Path>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = Path.SameRoot((string)(object)type, (string)path);
				object obj6 = obj2 + 1;
				obj2 = obj6;
				type = (Type)flag;
			}
			return type;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public SerializableSystemType(Type systemType)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string[] array = ((string)this).Split((char[])(object)systemType, StringSplitOptions.RemoveEmptyEntries);
		if (array != null)
		{
			nint num = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<System.IO.Path>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string temp_path = Path.get_temp_path();
			string directorySeparatorCharAsString = Path.DirectorySeparatorCharAsString;
			bool flag = Path.SameRoot(temp_path, directorySeparatorCharAsString);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E624");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E624");
	}

	public override bool Equals(object obj)
	{
		//IL_0027: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
		bool flag = default;
		object obj2 = (flag ? 1 : 0) + 24;
		obj2 = this;
		object obj3 = (flag ? 1 : 0) + 32;
		obj3 = obj;
		return flag;
	}

	public bool Equals(SerializableSystemType otherSystemType)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		SerializableSystemType serializableSystemType = default;
		if ((object)serializableSystemType != null)
		{
			return this == serializableSystemType;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0007: Expected I4, but got Obj
		return (int)_systemType;
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F5BB");
		object obj = this + 16;
		object obj2 = default;
		obj = obj2;
		((Validator<>)this)._002Ector();
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		if (_assemblyQualifiedName != null)
		{
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v19 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @85AC");
			object obj3 = default;
			obj2 = obj3;
		}
		else
		{
			object obj4 = this + 12;
			obj4 = 0;
		}
	}

	public static bool operator ==(SerializableSystemType a, SerializableSystemType b)
	{
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v20 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((object)b._systemType == null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v8 (Il2CppClass<System.Type>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v12 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((object)a._systemType == null)
			{
				return true;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		bool result = default;
		return result;
	}

	public static bool operator !=(SerializableSystemType a, SerializableSystemType b)
	{
		//IL_0060: Expected Obj, but got I4
		if ((object)a == b)
		{
			return true;
		}
		bool flag = (object)a == null;
		bool flag2 = (object)b == null;
		object obj = flag | flag2;
		if (obj != null)
		{
			return false;
		}
		return a == b;
	}
}
