using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Tickable;

namespace SYBO.Components.Utilities.IO;

public class PersistentDataPathUtility
{
	private string ParentPath__BackingField;

	public unsafe string ParentPath
	{
		get
		{
			//IL_0077: Expected I, but got Obj
			//IL_008d: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected I, but got Unknown
			//IL_00d3: Expected I, but got Obj
			//IL_0069: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v22 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object typeFromHandle = typeof(TypeListAttribute);
			nint num3 = (nint)(typeFromHandle + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
			Type attributeType = Type.internal_from_handle((IntPtr)num3);
			Attribute customAttribute = Attribute.GetCustomAttribute((Assembly)(object)this, attributeType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj2 = default;
			bool flag = obj2 != null;
			return (string)flag;
		}
		private set
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			_ = 1;
			object obj = this + 8;
			obj = value;
		}
	}

	public PersistentDataPathUtility()
	{
		//IL_000b: Expected Obj, but got I4
		ParentPath__BackingField = (string)1;
	}

	public PersistentDataPathUtility(string fullPath)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = fullPath;
	}

	public string GetStorageLocationDirectory(string subdirectory)
	{
		//IL_001a: Expected Obj, but got I
		//IL_001e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.IO.PersistentDataPathUtility)+14]");
		return (string)((List<ITickable>)0).Contains((ITickable)(object)subdirectory);
	}

	public string CreateStorageLocation(string subdirectory, string filename)
	{
		return null;
	}

	public bool DeleteStorageLocation(string subdirectory)
	{
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_009e: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I4
		//IL_00df: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Path.findExtension(subdirectory) != 0)
		{
			string paramName = $"The subdirectory must be a relative path. value={(object[])(object)subdirectory}";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentNullException ex = default;
			ex._002Ector(paramName);
			((PersistentDataPathUtility)(object)ex).GetStorageLocationDirectory((string)null);
		}
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v12 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot(ParentPath__BackingField, subdirectory);
		return FileUtility.IsLocalPath((string)flag);
	}
}
