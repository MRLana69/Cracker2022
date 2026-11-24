using System;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

public class CharacterCustomizationProp : MonoBehaviour
{
	public virtual void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_0075: Expected VT, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = alternateSetup;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		string text = default;
		text.m_stringLength = (int)num;
		_ = 0;
		object obj3 = text + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (T)+1C]");
		((AssetBundleFactory<>)0).LoadAssetFromBundles((AssetBundle)(object)this, text, (Action<T>)(object)characterRig);
	}

	public CharacterCustomizationProp()
	{
		CancelInvoke();
	}
}
