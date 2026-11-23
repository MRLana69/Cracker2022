using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class CharacterMaterial : MonoBehaviour
{
	public enum CharacterMaterialShaderType
	{
		Default,
		Additive
	}

	private class CharacterMaterialPathInfo(CharacterMaterialShaderType shaderType, DeviceInfo.PerformanceLevel performanceLevel, string materialPath)
	{
		public CharacterMaterialShaderType ShaderType = shaderType;

		public DeviceInfo.PerformanceLevel PerformanceLevel = performanceLevel;

		public string MaterialPath = materialPath;
	}

	private static List<CharacterMaterialPathInfo> _materialPaths;

	public static void Request(string textureName, CharacterMaterialShaderType shaderType, bool forcePerformanceLevel, DeviceInfo.PerformanceLevel forcedLevel, Action<Material> onSucces)
	{
		DeviceInfo instance = DeviceInfo.Instance;
		DeviceInfo.PerformanceLevel performanceLevel = forcedLevel;
		if (!forcePerformanceLevel)
		{
			performanceLevel = instance.performanceLevel;
		}
		string materialPath = GetMaterialPath(shaderType, performanceLevel);
		RequestMaterial(textureName, materialPath, onSucces);
	}

	private static string GetMaterialPath(CharacterMaterialShaderType shaderType, DeviceInfo.PerformanceLevel performanceLevel)
	{
		throw new ArgumentException();
	}

	private static void RequestMaterial(string textureName, string materialPath, Action<Material> onSucces)
	{
		//IL_0035: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Material));
		UnityEngine.Object obj = Resources.Load(materialPath, typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Material mat = default;
		SetTexture(mat, textureName, onSucces);
	}

	private static void SetTexture(Material mat, string textureName, Action<Material> onSucces)
	{
		//IL_0020: Expected Obj, but got I
		//IL_002d: Expected VT, but got Obj
		Material material = default;
		material._002Ector(mat);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
		string text = (string)0 + "_low";
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		throw new ArgumentException();
	}

	static CharacterMaterial()
	{
		List<CharacterMaterialPathInfo> list = default;
		list._002Ector();
		CharacterMaterialPathInfo characterMaterialPathInfo = default;
		characterMaterialPathInfo.MaterialPath = "Materials/avatar_default_LOD0";
		characterMaterialPathInfo.PerformanceLevel = DeviceInfo.PerformanceLevel.Low;
		characterMaterialPathInfo.ShaderType = CharacterMaterialShaderType.Default;
		list.Add(characterMaterialPathInfo);
		CharacterMaterialPathInfo characterMaterialPathInfo2 = default;
		characterMaterialPathInfo2.MaterialPath = "Materials/avatar_default_LOD1";
		characterMaterialPathInfo2.PerformanceLevel = DeviceInfo.PerformanceLevel.Medium;
		characterMaterialPathInfo2.ShaderType = CharacterMaterialShaderType.Default;
		list.Add(characterMaterialPathInfo2);
		CharacterMaterialPathInfo characterMaterialPathInfo3 = default;
		characterMaterialPathInfo3.MaterialPath = "Materials/avatar_default_LOD2";
		characterMaterialPathInfo3.PerformanceLevel = DeviceInfo.PerformanceLevel.High;
		characterMaterialPathInfo3.ShaderType = CharacterMaterialShaderType.Default;
		list.Add(characterMaterialPathInfo3);
		CharacterMaterialPathInfo characterMaterialPathInfo4 = default;
		characterMaterialPathInfo4.MaterialPath = "Materials/avatar_additive_LOD0";
		characterMaterialPathInfo4.PerformanceLevel = DeviceInfo.PerformanceLevel.Low;
		characterMaterialPathInfo4.ShaderType = CharacterMaterialShaderType.Additive;
		list.Add(characterMaterialPathInfo4);
		CharacterMaterialPathInfo characterMaterialPathInfo5 = default;
		characterMaterialPathInfo5.MaterialPath = "Materials/avatar_additive_LOD1";
		characterMaterialPathInfo5.PerformanceLevel = DeviceInfo.PerformanceLevel.Medium;
		characterMaterialPathInfo5.ShaderType = CharacterMaterialShaderType.Additive;
		list.Add(characterMaterialPathInfo5);
		CharacterMaterialPathInfo characterMaterialPathInfo6 = default;
		characterMaterialPathInfo6.MaterialPath = "Materials/avatar_additive_LOD2";
		characterMaterialPathInfo6.PerformanceLevel = DeviceInfo.PerformanceLevel.High;
		characterMaterialPathInfo6.ShaderType = CharacterMaterialShaderType.Additive;
		list.Add(characterMaterialPathInfo6);
		_materialPaths = list;
	}
}
