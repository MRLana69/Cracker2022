using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using UnityEngine;

public class CharacterMaterial : MonoBehaviour
{
	public enum CharacterMaterialShaderType
	{
		Default,
		Additive,
		Shine
	}

	private class CharacterMaterialPathInfo
	{
		public CharacterMaterialShaderType ShaderType;

		public DeviceInfo.PerformanceLevel PerformanceLevel;

		public string MaterialPath;

		public CharacterMaterialPathInfo(CharacterMaterialShaderType shaderType, DeviceInfo.PerformanceLevel performanceLevel, string materialPath)
		{
			//IL_001e: Expected Obj, but got I
			//IL_0045: Expected Obj, but got I4
			//IL_0045: Expected Obj, but got I4
			//IL_0045: Expected Obj, but got I
			OfferWallManager instance = OfferWallManager.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [shaderType @ L1 (CharacterMaterial+CharacterMaterialShaderType)+8]");
			bool availabilityForLocation = ((AdSystemManager)(object)instance).GetAvailabilityForLocation((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [shaderType @ L1 (CharacterMaterial+CharacterMaterialShaderType)+8]");
			((OfferWallPopup.OfferListAdapter)this)._002Ector((List<OfferWallCell>)0, (GameObject)availabilityForLocation, (GameObject)performanceLevel, (Action)(object)materialPath);
		}
	}

	private static List<CharacterMaterialPathInfo> _materialPaths;

	public static void Request(string textureName, CharacterMaterialShaderType shaderType, bool forcePerformanceLevel, DeviceInfo.PerformanceLevel forcedLevel, bool asynchronous, Action<Material> onSucces)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [textureName @ L0 (System.String)+50]");
		AudioClipInfo audioClipInfo = ((Dictionary<Character.StumbleType, AudioClipInfo>)0).get_Item((Character.StumbleType)shaderType);
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)audioClipInfo, false);
	}

	private static string GetMaterialPath(CharacterMaterialShaderType shaderType, DeviceInfo.PerformanceLevel performanceLevel)
	{
		//IL_0117: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		object obj3 = default;
		object obj8 = default;
		string text = default;
		string result = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [shaderType @ L0 (CharacterMaterial+CharacterMaterialShaderType)+10]");
			object obj = 0;
			object obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4+C]");
			if ((nint)obj2 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [shaderType @ L0 (CharacterMaterial+CharacterMaterialShaderType)+10]");
				object obj4 = (nint)0 + (nint)16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v25+C]");
				if ((nint)0 == (nint)performanceLevel)
				{
					break;
				}
				obj3 = obj8 + 1;
				continue;
			}
			object obj9 = performanceLevel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string msg = "Missing asset bundle mapping for " + text;
			SDebug.LogFormat(msg, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [shaderType @ L0 (CharacterMaterial+CharacterMaterialShaderType)+10]");
		object obj10 = (nint)0 + (nint)16;
		object obj11 = obj3 << 2;
		object obj12 = obj10 + obj11;
		bool flag = ((BubbleEvent._003CBlowBubbles_003Ed__4)obj12).MoveNext();
		return (string)flag;
	}

	private static void RequestMaterial(string textureName, string materialPath, bool asynchronous, Action<Material> onSucces)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009d: Expected VT, but got Obj
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = onSucces;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text = default;
		string bundle = textureName + "_" + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		string text2 = default;
		text2.m_stringLength = (int)num;
		_ = 0;
		object obj3 = text2 + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (T)+14]");
		((AssetBundleFactory<>)0).LoadAssetFromBundles((AssetBundle)(object)bundle, text2, (Action<T>)asynchronous);
	}

	private unsafe static void SetTexture(Material mat, string textureName, bool asynchronous, Action<Material> onSucces)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected I, but got Unknown
		//IL_0129: Expected I, but got Obj
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_00ff: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v22 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(Material);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type systemTypeInstance = Type.internal_from_handle((IntPtr)num3);
		UnityEngine.Object[] array = Resources.LoadAll(textureName, systemTypeInstance);
		nint num4 = (nint)typeof(CharacterMaterial);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v11 (Il2CppClass<CharacterMaterial>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(CharacterMaterial);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v18 (Il2CppClass<CharacterMaterial>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		CharacterModel characterModel = default;
		characterModel.StartCustomAnimation((UIModelController.ModelScreen)mat, asynchronous, (AnimationClip[])(object)onSucces);
	}

	public CharacterMaterial()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
