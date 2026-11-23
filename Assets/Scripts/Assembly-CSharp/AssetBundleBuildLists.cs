using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class AssetBundleBuildLists : MonoBehaviour
{
	[Serializable]
	public class BuildListEntry
	{
		public string Name;

		public Characters.CharacterType CharacterType;

		public CharacterAssetsBundle CharacterAssets;

		public CharacterIdlesBundle CharacterIdles;

		public CharacterCustomizationBundle[] CharacterCustomizationAssets;

		public Texture2D[] CharacterTextures;

		public Texture2D[] CharacterTexturesHighres;

		public string[] GetAllAssetBundleNames()
		{
			List<string> list = default;
			list._002Ector();
			string name = CharacterAssets.name;
			((BuildListEntry)(object)list).TryAdd(name, list);
			string name2 = CharacterIdles.name;
			((BuildListEntry)(object)list).TryAdd(name2, list);
			((BuildListEntry)(object)list).TryAdd((UnityEngine.Object[])CharacterCustomizationAssets, list);
			((BuildListEntry)(object)list).TryAdd((UnityEngine.Object[])CharacterTextures, list);
			return list.ToArray();
		}

		private void TryAdd(UnityEngine.Object[] objs, List<string> list)
		{
			//IL_0036: Expected Obj, but got I
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			BuildListEntry buildListEntry = null;
			while (objs.Length > (nint)buildListEntry)
			{
				object obj = (object)buildListEntry << 2;
				object obj2 = (object)objs + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4+10]");
				string name = ((UnityEngine.Object)0).name;
				buildListEntry.TryAdd(name, list);
				BuildListEntry buildListEntry2 = (BuildListEntry)(buildListEntry + 1);
				buildListEntry = buildListEntry2;
			}
		}

		private void TryAdd(string bundleName, List<string> list)
		{
			string item = bundleName.ToLower();
			if (!list.Contains(item))
			{
				string item2 = bundleName.ToLower();
				list.Add(item2);
			}
		}
	}

	public BuildListEntry[] CharacterEntries;
}
