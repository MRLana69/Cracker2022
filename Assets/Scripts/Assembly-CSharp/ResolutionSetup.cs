using System;
using Cpp2ILInjected;
using UnityEngine;

public class ResolutionSetup : MonoBehaviour
{
	private UIAtlas menuAtlas;

	private UIAtlas countriesAtlas;

	private UIAtlas _lowResMenuAtlas;

	private UIAtlas _lowResCountriesAtlas;

	private UIAtlas _highResMenuAtlas;

	private UIAtlas _highResCountriesAtlas;

	private const string PATH_TO_ATLASES = "Prefabs/Atalses/";

	private const string HIGH_RES_MENU_ATLAS_NAME = "HighResAtlas";

	private const string HIGH_RES_COUNTRIES_ATLAS_NAME = "HighResCountriesAtlas";

	private const string LOW_RES_MENU_ATLAS_NAME = "LowResAtlas";

	private const string LOW_RES_COUNTRIES_ATLAS_NAME = "LowResCountriesAtlas";

	private UIAtlas _editorMenuAtlase;

	private UIAtlas _editorCountriesAtlase;

	private void Awake()
	{
		UIAtlas uIAtlas = menuAtlas;
		_editorMenuAtlase = uIAtlas.mReplacement;
		UIAtlas uIAtlas2 = countriesAtlas;
		_editorCountriesAtlase = uIAtlas2.mReplacement;
		SetupMenuAtlasReference();
		SetupCountriesAtlasReference();
	}

	private unsafe void SetupCountriesAtlasReference()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Ref, but got Unknown
		DeviceInfo instance = DeviceInfo.Instance;
		LoadAtlas("HighResCountriesAtlas", ref *(UIAtlas*)(this + 32));
		SetAtlasReferenceTo(countriesAtlas, _highResCountriesAtlas);
	}

	private unsafe void SetupMenuAtlasReference()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Ref, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Ref, but got Unknown
		//IL_00ae: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		DeviceInfo instance = DeviceInfo.Instance;
		object atlasName = "HighResAtlas";
		if (!instance.isHighres__BackingField)
		{
			atlasName = "LowResAtlas";
		}
		ref UIAtlas cachedAtlas = ref *(UIAtlas*)(this + 28);
		ref UIAtlas reference = ref *(UIAtlas*)(this + 20);
		if (!instance.isHighres__BackingField)
		{
			cachedAtlas = ref reference;
		}
		LoadAtlas((string)atlasName, ref cachedAtlas);
		object obj = 28;
		if (!instance.isHighres__BackingField)
		{
			obj = 20;
		}
		object newAtlas = (object)this + obj;
		SetAtlasReferenceTo(menuAtlas, (UIAtlas)newAtlas);
	}

	private unsafe void LoadAtlas(string atlasName, ref UIAtlas cachedAtlas)
	{
		//IL_002b: Expected VT, but got Obj
		if (cachedAtlas == null)
		{
			string path = "Prefabs/Atalses/" + atlasName;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(UIAtlas));
			UnityEngine.Object obj = Resources.Load(path, typeFromHandle);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			object obj2 = default;
			ref UIAtlas reference = ref *(UIAtlas*)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		}
	}

	private void SetAtlasReferenceTo(UIAtlas referenceAtlas, UIAtlas newAtlas)
	{
		if (referenceAtlas != null && newAtlas != null)
		{
			referenceAtlas.replacement = newAtlas;
		}
	}

	private void OnDisable()
	{
		if (menuAtlas != null && countriesAtlas != null)
		{
			menuAtlas.replacement = _editorMenuAtlase;
			countriesAtlas.replacement = _editorCountriesAtlase;
		}
	}
}
