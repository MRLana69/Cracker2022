using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class AssetBundleBuildLists : MonoBehaviour
{
	[Serializable]
	public class BuildListEntry
	{
		public string Name;

		public Characters.CharacterId characterId;

		public CharacterAssetsBundle CharacterAssets;

		public CharacterIdlesBundle CharacterIdles;

		public CharacterCustomizationBundle[] CharacterCustomizationAssets;

		public Texture2D[] CharacterTextures;

		public Texture2D[] CharacterTexturesHighres;

		public string[] GetDefaultAssetBundleNames()
		{
			//IL_0007: Expected Obj, but got I4
			return (string[])characterId;
		}

		public string[] GetOutfitAssetBundleNames(int outfit)
		{
			//IL_002a: Expected Obj, but got I4
			string name = Name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [outfit @ L1 (System.Int32)+8]");
			bool flag = (nint)0 == (int)name.m_firstChar;
			return (string[])flag;
		}

		private void TryAdd(UnityEngine.Object[] objs, List<string> list)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			Name = (string)(object)list;
			CharacterIdles = (CharacterIdlesBundle)(object)list;
			object obj = this + 16;
			obj = objs;
		}

		private void TryAdd(string bundleName, List<string> list)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			//IL_0064: Expected I4, but got Obj
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			object obj = bundleName + 12;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = bundleName + 16;
				object obj4 = obj2 << 2;
				object original = obj3 + obj4;
				UnityEngine.Object textureName = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
				System.Runtime.CompilerServices.Unsafe.Write(null, new CharacterCustomizationBundle.CharacterMaterialInfo((string)(object)textureName, (CharacterMaterial.CharacterMaterialShaderType)list));
				object obj5 = obj2 + 1;
				obj2 = obj5;
			}
		}

		public BuildListEntry()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public BuildListEntry[] CharacterEntries;

	private string characterAssetsPath;

	private string characterCustomizationAssetsPath;

	private int characterCustomizationsCount;

	private string characterIdlesPath;

	private string characterIdlesPostfix;

	private string characterTexturesPath;

	private List<string> characterTexturePostfixs;

	private string characterTextureLowPostfix;

	public AssetBundleBuildLists()
	{
		CancelInvoke();
	}
}
