using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class ResolutionSetup : MonoBehaviour
{
	private UIAtlas menuAtlas;

	private UIAtlas countriesAtlas;

	private UIAtlas _lowResMenuAtlas;

	private UIAtlas _highResMenuAtlas;

	private UIAtlas _highResCountriesAtlas;

	private const string PATH_TO_ATLASES = "Prefabs/Atlases/";

	private const string HIGH_RES_MENU_ATLAS_NAME = "HighResAtlas";

	private const string HIGH_RES_COUNTRIES_ATLAS_NAME = "HighResCountriesAtlas";

	private const string LOW_RES_MENU_ATLAS_NAME = "LowResAtlas";

	private UIAtlas _editorMenuAtlase;

	private UIAtlas _editorCountriesAtlase;

	private void Awake()
	{
		CancelInvoke();
	}

	private void SetupCountriesAtlasReference()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		object obj = this + 32;
		UIAtlas uIAtlas = menuAtlas;
		obj = uIAtlas.mReplacement;
		object obj2 = this + 36;
		UIAtlas uIAtlas2 = countriesAtlas;
		obj2 = uIAtlas2.mReplacement;
		OnDisable();
		SetupMenuAtlasReference();
	}

	private void SetupMenuAtlasReference()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0031: Expected I4, but got Obj
		UIAtlas newAtlas = (UIAtlas)(this + 28);
		((ResolutionSetup)null).SetAtlasReferenceTo((UIAtlas)(object)"HighResCountriesAtlas", newAtlas);
		((AdSystemTesterCell)null).OnCacheStateChanged((string)(object)countriesAtlas, (byte)(int)_highResCountriesAtlas != 0);
	}

	private unsafe void LoadAtlas(string atlasName, ref UIAtlas cachedAtlas)
	{
		//IL_000f: Expected I4, but got Obj
		//IL_0018: Expected Obj, but got Ref
		((UIWidget)(object)menuAtlas).height = (int)atlasName;
		Color color = ((UIWidget)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cachedAtlas)).color;
	}

	private unsafe void SetAtlasReferenceTo(UIAtlas referenceAtlas, UIAtlas newAtlas)
	{
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected I, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0166: Expected I, but got Obj
		//IL_00b3: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 4);
		if (!(newAtlas != null))
		{
			return;
		}
		string path = string.ConcatArray((string[])(object)"Prefabs/Atlases/", (int)referenceAtlas);
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v19 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v28 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(UIAtlas);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type systemTypeInstance = Type.internal_from_handle((IntPtr)num3);
		UnityEngine.Object[] array = Resources.LoadAll(path, systemTypeInstance);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj4 = default;
		UIAtlas uIAtlas = (UIAtlas)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
	}

	private void OnDisable()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_003b: Expected I4, but got Obj
		string dataPath = Application.dataPath;
		UIAtlas newAtlas = (UIAtlas)(this + 24);
		((ResolutionSetup)null).SetAtlasReferenceTo((UIAtlas)(object)"HighResAtlas", newAtlas);
		((AdSystemTesterCell)null).OnCacheStateChanged((string)(object)menuAtlas, (byte)(int)_highResMenuAtlas != 0);
	}

	public ResolutionSetup()
	{
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f1: Expected I4, but got Obj
		//IL_0102: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)menuAtlas).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)countriesAtlas).FindKernel((string)null) != 0)
		{
			((UIColorPicker)(object)menuAtlas).OnPress((byte)(int)_editorMenuAtlase != 0);
			((UIColorPicker)(object)countriesAtlas).OnPress((byte)(int)_editorCountriesAtlase != 0);
		}
	}
}
