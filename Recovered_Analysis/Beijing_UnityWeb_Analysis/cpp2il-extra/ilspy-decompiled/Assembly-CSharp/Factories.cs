using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Serialization;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using UI.DoubleCoinsVideo;
using UnityEngine;

public class Factories : SingletonMonoBehaviour<Factories>
{
	[Serializable]
	private class AssetBundleMapping
	{
		[Serializable]
		public class StringArray
		{
			public string[] Strings;
		}

		public string CharacterTypeName;

		public Characters.CharacterId characterId;

		public string[] DefaultAssetBundleNames;

		public StringArray[] OutfitAssetBundleNames;

		public string[] GetAllAssetBundleNames()
		{
			//IL_0017: Expected I4, but got Obj
			//IL_003d: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			UnityEngine.Object textureName = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)DefaultAssetBundleNames);
			System.Runtime.CompilerServices.Unsafe.Write(null, new CharacterCustomizationBundle.CharacterMaterialInfo((string)(object)textureName, (CharacterMaterial.CharacterMaterialShaderType)list));
			UnityEngine.Object textureName2 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)OutfitAssetBundleNames);
			System.Runtime.CompilerServices.Unsafe.Write(null, new CharacterCustomizationBundle.CharacterMaterialInfo((string)(object)textureName2, (CharacterMaterial.CharacterMaterialShaderType)list));
			return list.ToArray();
		}

		public string[] GetAssetBundleNamesForOutfit(int outfit, bool includeIdles)
		{
			//IL_0009: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I4
			//IL_001e: Expected Obj, but got I4
			//IL_0072: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			bool flag = ((DoubleCoinsVideoBanner._003CActivateStars_003Ed__14)outfit).MoveNext();
			object obj = flag;
			bool flag2 = ((DoubleCoinsVideoBanner._003CActivateStars_003Ed__14)includeIdles).MoveNext();
			if ((nint)obj < (flag2 ? 1 : 0))
			{
				return (string[])(-1);
			}
			bool flag3 = (nint)obj > (flag2 ? 1 : 0);
			return (string[])flag3;
		}

		public AssetBundleMapping()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = string.Empty;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<AnimationClip> list = default;
			list._002Ector();
			object obj2 = this + 20;
			obj2 = list;
		}
	}

	private AssetBundleMapping[] _assetBundleMappings;

	private AssetBundleFactory<CharacterCustomizationBundle> CharacterCustomizationBundle__BackingField;

	private AssetBundleFactory<CharacterIdlesBundle> CharacterIdlesBundle__BackingField;

	private AssetBundleFactory<CharacterAssetsBundle> CharacterAssetsBundle__BackingField;

	private AssetBundleFactory<Material> MaterialFactory__BackingField;

	private AssetBundleFactory<Texture2D> TextureFactory__BackingField;

	public Action OnLateUpdate;

	public AssetBundleFactory<CharacterCustomizationBundle> CharacterCustomizationBundle
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Factories)+C]");
			return (AssetBundleFactory<CharacterCustomizationBundle>)0;
		}
		private set
		{
			//IL_0015: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Factories)+C]");
			object obj = 0;
			bool flag = (string)(object)value != "FrontScreen";
		}
	}

	public AssetBundleFactory<CharacterIdlesBundle> CharacterIdlesBundle
	{
		get
		{
			return (AssetBundleFactory<CharacterIdlesBundle>)(object)CharacterCustomizationBundle__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public AssetBundleFactory<CharacterAssetsBundle> CharacterAssetsBundle
	{
		get
		{
			return (AssetBundleFactory<CharacterAssetsBundle>)(object)CharacterIdlesBundle__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
		}
	}

	public AssetBundleFactory<Material> MaterialFactory
	{
		get
		{
			return (AssetBundleFactory<Material>)(object)CharacterAssetsBundle__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 28;
			obj = value;
		}
	}

	public AssetBundleFactory<Texture2D> TextureFactory
	{
		get
		{
			return (AssetBundleFactory<Texture2D>)(object)MaterialFactory__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = value;
		}
	}

	protected override void SubclassInitialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private void LateUpdate()
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AssetBundleFactory<> assetBundleFactory = default;
		assetBundleFactory.HandleOnLateUpdate();
		object obj = this + 20;
		obj = assetBundleFactory;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AssetBundleFactory<> assetBundleFactory2 = default;
		assetBundleFactory2.HandleOnLateUpdate();
		object obj2 = this + 24;
		obj2 = assetBundleFactory2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AssetBundleFactory<> assetBundleFactory3 = default;
		assetBundleFactory3.HandleOnLateUpdate();
		object obj3 = this + 28;
		obj3 = assetBundleFactory3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AssetBundleFactory<> assetBundleFactory4 = default;
		assetBundleFactory4.HandleOnLateUpdate();
		object obj4 = this + 32;
		obj4 = assetBundleFactory4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AssetBundleFactory<> assetBundleFactory5 = default;
		assetBundleFactory5.HandleOnLateUpdate();
		object obj5 = this + 36;
		obj5 = assetBundleFactory5;
	}

	public bool IsAssetBundleInUse(string assetBundleName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got I4
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_02fb: Expected I4, but got Obj
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		List<AnimationClip> list = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v90+C]");
				if (0 == (nint)assetBundleName)
				{
					object obj6 = obj4 + 4;
					object obj7 = obj6 + 1;
					obj6 = obj7;
					object obj8 = obj7 << 2;
					object obj9 = obj4 + obj8;
					obj9 = 71;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v90+14]");
					list = (List<AnimationClip>)0;
					break;
				}
				continue;
			}
			object obj10 = obj4 + 4;
			object obj11 = obj10 + 1;
			obj10 = obj11;
			object obj12 = obj11 << 2;
			object obj13 = obj4 + obj12;
			obj13 = 65;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj4 + obj14;
			if ((nint)obj15 == 71)
			{
				object obj16 = obj4 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_02f6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj4 + obj18;
			if ((nint)obj19 == 65)
			{
				object obj20 = obj4 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_0396;
			}
		}
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0396;
		IL_02f6:
		return (byte)(int)list != 0;
		IL_0396:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AnimationClip> list2 = default;
		list2._002Ector();
		list = list2;
		goto IL_02f6;
	}

	public string[] GetReferencedAssetBundleNames(Characters.CharacterId characterId)
	{
		//IL_00f0: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		if (CharacterCustomizationBundle__BackingField.IsAssetBundleInUse((string)characterId))
		{
			return (string[])1;
		}
		if (CharacterIdlesBundle__BackingField.IsAssetBundleInUse((string)characterId))
		{
			return (string[])1;
		}
		if (CharacterAssetsBundle__BackingField.IsAssetBundleInUse((string)characterId))
		{
			return (string[])1;
		}
		if (MaterialFactory__BackingField.IsAssetBundleInUse((string)characterId))
		{
			return (string[])1;
		}
		bool flag = TextureFactory__BackingField.IsAssetBundleInUse((string)characterId);
		return (string[])flag;
	}

	public string[] GetReferencedAssetBundleNames(Characters.CharacterId characterId, int theme, bool includeIdles)
	{
		//IL_0394: Expected I, but got Obj
		//IL_03aa: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0221: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I4
		//IL_02b6: Expected I, but got Obj
		//IL_02cc: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_035b: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_01d4: Expected I, but got Obj
		//IL_0328: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		bool flag = default;
		IDictionary bundlePath = default;
		if (!flag)
		{
			nint num = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v21 (Il2CppClass<System.IO.Path>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v58 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = Path.SameRoot("AssetBundles", (string)characterId);
			TextAsset textAsset = Resources.Load<TextAsset>((string)flag2);
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)textAsset))
			{
				nint num5 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v41 (Il2CppClass<System.IO.Path>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v50 (Il2CppClass<System.IO.Path>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool totalLength = Path.SameRoot("AssetBundles", (string)characterId);
				string bundleName = string.ConcatArray((string[])(object)"Cannot load bundle from resources: ", totalLength ? 1 : 0);
				((AssetBundleManager)null).DebugRequestStatus(bundleName);
				return null;
			}
			string reader = textAsset.ToString();
			nint num7 = (nint)typeof(CompressionExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v14 (Il2CppClass<Kiloo.CompressionExtensions>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(CompressionExtensions);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v20 (Il2CppClass<Kiloo.CompressionExtensions>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bundlePath = BsonBinaryReaderExtensions.ReadBsonObject((BinaryReader)(object)reader, (byte)(int)"subway_bundles" != 0);
		}
		nint num9 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v9 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v15 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = AssetBundleCache.CacheEditorBundle((string)characterId, theme, (string)(object)bundlePath);
		return (string[])flag3;
	}

	public Factories()
	{
		if (OnLateUpdate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
