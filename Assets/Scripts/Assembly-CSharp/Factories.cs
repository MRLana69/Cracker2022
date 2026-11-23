using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Info;
using UnityEngine;

public class Factories : SingletonMonobehavior<Factories>
{
	[Serializable]
	private class AssetBundleMapping
	{
		public string CharacterTypeName;

		public Characters.CharacterType CharacterType;

		public string[] AssetBundleNames;

		public AssetBundleMapping()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			string[] assetBundleNames = default;
			AssetBundleNames = assetBundleNames;
		}
	}

	private AssetBundleMapping[] _assetBundleMappings;

	private Dictionary<byte, string[]> _runTimeAssetBundleMapping;

	public Action OnLateUpdate;

	public AssetBundleFactory<CharacterCustomizationBundle> CharacterCustomizationBundle
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public AssetBundleFactory<CharacterIdlesBundle> CharacterIdlesBundle
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public AssetBundleFactory<CharacterAssetsBundle> CharacterAssetsBundle
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public AssetBundleFactory<Material> MaterialFactory
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public AssetBundleFactory<Texture2D> TextureFactory
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	private void Awake()
	{
		throw new ArgumentException();
	}

	public string[] GetReferencedAssetBundleNames(Characters.CharacterType characterType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		byte key = (byte)(characterType & (Characters.CharacterType)0xFF);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Byte, System.String[]>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 == null)
		{
			object obj7 = 0;
			while (true)
			{
				AssetBundleMapping[] assetBundleMappings = _assetBundleMappings;
				if (assetBundleMappings.Length <= (nint)obj7)
				{
					break;
				}
				object obj8 = obj7 << 2;
				object obj9 = (object)assetBundleMappings + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v21+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v22+C]");
				if ((nint)characterType == (nint)0)
				{
					object obj11 = obj7 << 2;
					object obj12 = (object)_assetBundleMappings + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v46+10]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v47+10]");
					return (string[])0;
				}
				object obj14 = obj7 + 1;
				obj7 = obj14;
			}
			_ = -1;
			obj = (Enum)(object)typeof(Characters.CharacterType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string text2 = "Missing asset bundle mapping for " + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			string[] result = default;
			return result;
		}
		return _runTimeAssetBundleMapping.get_Item(key);
	}

	public Factories()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AssetBundleMapping[] assetBundleMappings = default;
		_assetBundleMappings = assetBundleMappings;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Byte, System.String[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<byte, string[]> runTimeAssetBundleMapping = default;
		_runTimeAssetBundleMapping = runTimeAssetBundleMapping;
		base._002Ector();
	}
}
