using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
	private Texture2D gradient;

	private SkinnedMeshRenderer outfitRenderer;

	private string currentCharacterName = string.Empty;

	private int currentCharacterVersion = -1;

	private List<GameObject> specialAssets;

	private List<Material> customMaterials;

	private List<Material> headMaterials;

	private List<Material> cachedMaterials;

	private CharacterCustomizationBundle _characterCustomizationBundle;

	public SkinnedMeshRenderer OutfitRenderer => outfitRenderer;

	public CharacterCustomizationBundle.OutfitInfo OutfitInfo
	{
		get
		{
			CharacterCustomizationBundle characterCustomizationBundle = _characterCustomizationBundle;
			return characterCustomizationBundle._outfit;
		}
	}

	private void DeleteSpecialAssets()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_018c;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 != obj8;
			object obj9 = obj10;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_018c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj11;
			break;
			IL_018c:
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EBE");
			((List<T>)(object)specialAssets).Clear();
			if (_characterCustomizationBundle != null)
			{
				GameObject obj13 = _characterCustomizationBundle.gameObject;
				UnityEngine.Object.Destroy(obj13);
				_characterCustomizationBundle = null;
			}
			return;
		}
		_ = 0;
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	public void Customize(string name, int customizedVersion, SkinnedMeshRenderer model, SkinnedMeshRenderer outfitMesh, SkinnedMeshRenderer headMesh, CharacterRig characterRig, bool useSpecialAsset, bool deleteSpecialAsset, bool forceLOD0)
	{
		if (name == currentCharacterName)
		{
			if (currentCharacterVersion != customizedVersion)
			{
				goto IL_0050;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+18]");
			if ((nint)0 != 0)
			{
				goto IL_0050;
			}
		}
		goto IL_005b;
		IL_005b:
		currentCharacterName = name;
		outfitRenderer = outfitMesh;
		currentCharacterVersion = customizedVersion;
		outfitRenderer.enabled = false;
		throw new ArgumentException();
		IL_0050:
		DeleteSpecialAssets();
		goto IL_005b;
	}

	private void DestroyMaterials()
	{
		List<Material> list = cachedMaterials;
		bool flag = list._size >= 1;
		bool flag2 = !flag;
		int num = 0;
		if (!flag2)
		{
			while (true)
			{
				List<Material> list2 = cachedMaterials;
				if (list2._size <= num)
				{
					break;
				}
				Material material = cachedMaterials.get_Item(num);
				Texture mainTexture = material.mainTexture;
				if (mainTexture != null)
				{
					UnityEngine.Object.Destroy(mainTexture);
				}
				Material obj = cachedMaterials.get_Item(num);
				UnityEngine.Object.Destroy(obj);
				int num2 = num + 1;
				num = num2;
			}
			((List<T>)(object)cachedMaterials).Clear();
		}
		if (headMaterials != null)
		{
			List<Material> list3 = headMaterials;
			int num3 = 0;
			while (list3._size > num3)
			{
				Material material2 = headMaterials.get_Item(num3);
				Texture mainTexture2 = material2.mainTexture;
				if (mainTexture2 != null)
				{
					UnityEngine.Object.Destroy(mainTexture2);
				}
				Material obj2 = headMaterials.get_Item(num3);
				UnityEngine.Object.Destroy(obj2);
				int num4 = num3 + 1;
				list3 = headMaterials;
				num3 = num4;
			}
			((List<T>)(object)headMaterials).Clear();
		}
		if (customMaterials == null)
		{
			return;
		}
		List<Material> list4 = customMaterials;
		int num5 = 0;
		while (list4._size > num5)
		{
			Material material3 = customMaterials.get_Item(num5);
			Texture mainTexture3 = material3.mainTexture;
			if (mainTexture3 != null)
			{
				UnityEngine.Object.Destroy(mainTexture3);
			}
			Material obj3 = customMaterials.get_Item(num5);
			UnityEngine.Object.Destroy(obj3);
			int num6 = num5 + 1;
			list4 = customMaterials;
			num5 = num6;
		}
		((List<T>)(object)customMaterials).Clear();
	}

	private void OnDestroy()
	{
		DestroyMaterials();
		if (_characterCustomizationBundle != null)
		{
			GameObject obj = _characterCustomizationBundle.gameObject;
			UnityEngine.Object.Destroy(obj);
		}
	}

	public CharacterCustomization()
	{
		List<GameObject> list = default;
		list._002Ector();
		specialAssets = list;
		List<Material> list2 = default;
		list2._002Ector();
		customMaterials = list2;
		List<Material> list3 = default;
		list3._002Ector();
		headMaterials = list3;
		List<Material> list4 = default;
		list4._002Ector();
		cachedMaterials = list4;
		base._002Ector();
	}
}
