using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizationBundle : MonoBehaviour
{
	[Serializable]
	public struct CharacterMaterialInfo(string textureName, CharacterMaterial.CharacterMaterialShaderType shaderType)
	{
		public string TextureName = textureName;

		public CharacterMaterial.CharacterMaterialShaderType ShaderType = shaderType;
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
	}

	private OutfitInfo _outfit;

	public OutfitInfo Outfit => _outfit;

	public void SetOutfit(OutfitInfo Outfit)
	{
		_outfit = Outfit;
	}
}
