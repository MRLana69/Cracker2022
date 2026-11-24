using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Utilities;

public class AssetLoaderPathAttribute : Attribute
{
	public const string ErrorDirectoryDoesNotExist = "The specified path is deemed invalid. Please ensure that the direcotry exists. Specified path: {0}";

	public const string ErrorDirectoryResources = "The specified directory path does not end with '.../Resources'. Specified path: {0}";

	public const string ErrorDirectoryAssets = "The specified directory path does not start with 'Assets/'. Specified path: {0}";

	public const string FileExtension = ".asset";

	private string _directory;

	private string _assetName;

	public string Directory
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string result = default;
			return result;
		}
	}

	public string AssetName
	{
		get
		{
			string fullSystemPathTo = ((AssetLoaderPathAttribute)null).GetFullSystemPathTo(_directory);
			if (fullSystemPathTo != null)
			{
				return _directory;
			}
			return null;
		}
	}

	public string AssetNameWithFileExtension => _assetName;

	public string FullPath => string.Format((IFormatProvider)(object)"{0}{1}", _assetName, ".asset");

	public AssetLoaderPathAttribute(string directoryPath, string assetName)
	{
		//IL_01d2: Expected Obj, but got I4
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_0072: Expected I4, but got Obj
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		object obj = 0;
		string directory = Directory;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v37 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AssetLoaderPathAttribute)(object)directory)?._002Ector(directoryPath, assetName);
		FieldInfo[] fieldsForTree = ReflectionWrapper.GetFieldsForTree((Type)(object)this, (BindingFlags)directoryPath);
		object obj3 = fieldsForTree + 12;
		object obj4 = 0;
		object obj8 = default;
		object obj14 = default;
		object obj15 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			object obj5 = fieldsForTree + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			obj = obj8;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v9 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S2_v10+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S2_v11+44]");
			object obj11 = 0;
			object obj12 = obj11 & 0x1FFF;
			object obj13 = obj12 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v120 @ S3_v9 (should have been resolved before IL gen)");
			if ((nint)obj14 <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				obj = obj15;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v7 (Il2CppMethodInfo)+C]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v8+60]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S4_v9+48]");
				object obj18 = 0;
				object obj19 = obj18 & 0x7FF;
				object obj20 = obj19 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S5_v2 (should have been resolved before IL gen)");
			}
			object obj21 = obj4 + 1;
			obj4 = obj21;
		}
	}

	private bool ValidateDirectoryPath(string directoryPath)
	{
		//IL_010f: Expected I4, but got Obj
		//IL_0020: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		if (ReflectionWrapper.IsAbstract((Type)(object)directoryPath))
		{
			bool flag = ReflectionWrapper.IsPrimitive((Type)(object)directoryPath);
			object obj = (flag ? 1 : 0) + 12;
			object obj2 = 0;
			object obj6 = default;
			ArgumentNullException ex = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = (flag ? 1 : 0) + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				if (obj6 == null)
				{
					object obj7 = obj2 + 1;
					obj2 = obj7;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ex._002Ector("Closed generic interface types are not supported by GetInterface.");
				ReflectionWrapper.GetInterface((Type)(object)ex, null);
				break;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string name = default;
		return (byte)(int)((Type)(object)this).GetProperty(name) != 0;
	}

	private string GetFullSystemPathTo(string assetFolderRelativePath)
	{
		//IL_00da: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_0013: Expected I4, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I4
		//IL_008d: Expected I, but got Obj
		string text = assetFolderRelativePath.ToLower((CultureInfo)(object)"Assets/");
		if (text != null)
		{
			if (assetFolderRelativePath.EndsWith((char)(int)"/Resources"))
			{
				return (string)1;
			}
			nint num = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Log.Utilities.LogErrorFormat("The specified directory path does not end with '.../Resources'. Specified path: {0}", (object[])(object)assetFolderRelativePath);
			return null;
		}
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log.Utilities.LogErrorFormat("The specified directory path does not start with 'Assets/'. Specified path: {0}", (object[])(object)assetFolderRelativePath);
		return null;
	}
}
