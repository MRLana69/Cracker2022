using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterCustomizationBundle : MonoBehaviour
{
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 8)]
	public struct CharacterMaterialInfo
	{
		public string TextureName;

		public CharacterMaterial.CharacterMaterialShaderType ShaderType;

		public CharacterMaterialInfo(string textureName, CharacterMaterial.CharacterMaterialShaderType shaderType)
		{
			//IL_0046: Expected Obj, but got I4
			//IL_008d: Expected Obj, but got I4
			if (textureName != null && textureName.m_stringLength != 0)
			{
				string item = textureName.ToLowerInvariant();
				if (!((List<string>)shaderType).Contains(item))
				{
					string item2 = textureName.ToLowerInvariant();
					((List<string>)shaderType).Add(item2);
				}
			}
		}
	}

	[Serializable]
	public class OutfitInfo
	{
		public CharacterMaterialInfo MainMaterialInfo;

		public CharacterMaterialInfo[] ExtraMaterialInfo;

		public Mesh MainMesh;

		public Mesh ExtraMesh;

		public GameObject SpecialAsset;

		public string SpecialAssetsName;

		public List<string> ExcludedAnimationsNames;

		public AnimationEnumString HighscoreAnimationName;

		public OutfitInfo()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = string.Empty;
		}
	}

	[Serializable]
	public class AnimationEnumString
	{
		public const string ValueFieldName = "Value";

		public string Value;
	}

	private OutfitInfo _outfit;

	public OutfitInfo Outfit
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterCustomizationBundle)+1C]");
			return (OutfitInfo)0;
		}
	}

	public CharacterCustomizationBundle()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		_ = 1;
		_ = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 56;
		object obj2 = default;
		obj = obj2;
		CancelInvoke();
	}
}
