using System;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class CharacterCustomizationAssetsFactory : MonoBehaviour
{
	public unsafe static void GetAssetPrefab(string name, int customizedVersion, Action<CharacterCustomizationBundle> onSucces)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Expected VT, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		string text2 = name + "_" + text;
		throw new ArgumentException();
	}
}
