using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens.BoardScreenInternal;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
	private Texture2D gradient;

	private SkinnedMeshRenderer outfitRenderer;

	private List<GameObject> specialAssets;

	private List<Material> customMaterials;

	private List<Material> headMaterials;

	private List<Material> cachedMaterials;

	private CharacterCustomizationBundle _characterCustomizationBundle;

	public SkinnedMeshRenderer OutfitRenderer => outfitRenderer;

	public CharacterCustomizationBundle.OutfitInfo OutfitInfo => (CharacterCustomizationBundle.OutfitInfo)(object)outfitRenderer;

	private void DeleteSpecialAssets()
	{
		CancelInvoke();
	}

	public void Customize(string name, int customizedVersion, SkinnedMeshRenderer model, SkinnedMeshRenderer outfitMesh, SkinnedMeshRenderer headMesh, CharacterRig characterRig, bool useSpecialAsset, bool deleteSpecialAsset, bool forceLOD0, bool asynchronous, Action onSuccess)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void BuildProp(CharacterCustomizationBundle.OutfitInfo outfitInfo, CharacterRig characterRig, bool useSpecialAsset, bool deleteSpecialAsset)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_0665: Expected Obj, but got I4
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0429: Expected Obj, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_04e8: Expected Obj, but got I
		//IL_0741: Expected I, but got Obj
		//IL_074e: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got I
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03dc: Expected Obj, but got I4
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
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
		object obj10;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v180+8]");
				if (0 == (nint)outfitInfo)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					object obj6 = obj4 + 4;
					object obj7 = obj6 + 1;
					obj6 = obj7;
					object obj8 = obj7 << 2;
					object obj9 = obj4 + obj8;
					obj9 = 160;
					obj10 = 0;
					break;
				}
				continue;
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 66;
			obj10 = 0;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 160)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 66)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_0702;
			}
		}
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0702;
		IL_0726:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HoverboardThemeButton.OnPressEvent onPressEvent = default;
		onPressEvent._002Ector(outfitInfo, (IntPtr)characterRig);
		((CharacterModelRequest.CharacterBundleRequest)(object)onPressEvent).OnBundleLoaded((AssetBundle)deleteSpecialAsset);
		((List<CharacterModelRequest.CharacterBundleRequest>)(object)headMaterials).Add((CharacterModelRequest.CharacterBundleRequest)(object)onPressEvent);
		return;
		IL_0702:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj23 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v114+8]");
				if (0 == (nint)outfitInfo)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					object obj24 = obj4 + 4;
					object obj25 = obj24 + 1;
					obj24 = obj25;
					object obj26 = obj25 << 2;
					object obj27 = obj4 + obj26;
					obj27 = 160;
					break;
				}
				continue;
			}
			object obj28 = obj4 + 4;
			object obj29 = obj28 + 1;
			obj28 = obj29;
			object obj30 = obj29 << 2;
			object obj31 = obj4 + obj30;
			obj31 = 132;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj32 = (nint)0 << 2;
			object obj33 = obj4 + obj32;
			if ((nint)obj33 == 160)
			{
				object obj34 = obj4 + 4;
				if ((nint)obj34 > -1)
				{
					object obj35 = obj34 + -1;
					obj34 = obj35;
				}
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj36 = (nint)0 << 2;
			object obj37 = obj4 + obj36;
			if ((nint)obj37 == 132)
			{
				object obj38 = obj4 + 4;
				if ((nint)obj38 > -1)
				{
					object obj39 = obj38 + -1;
					obj38 = obj39;
				}
				goto IL_0726;
			}
		}
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0726;
	}

	private void DestroyMaterials()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_034d: Expected Obj, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
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
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v85 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v94 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 51)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_042b;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_042b;
		IL_042b:
		throw new IndexOutOfRangeException();
	}

	private void OnDestroy()
	{
		//IL_0046: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_0255: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_0658: Expected Obj, but got I4
		//IL_0464: Expected I, but got Obj
		//IL_047a: Expected Obj, but got I
		//IL_06b5: Expected Obj, but got I4
		//IL_0175: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		//IL_0712: Expected Obj, but got I4
		//IL_0384: Expected I, but got Obj
		//IL_039a: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_0593: Expected I, but got Obj
		//IL_05a9: Expected Obj, but got I
		//IL_04a5: Expected I, but got Obj
		//IL_02e3: Expected I, but got Obj
		//IL_02f9: Expected Obj, but got I
		//IL_01b6: Expected I, but got Obj
		//IL_0682: Expected Obj, but got I4
		//IL_04f2: Expected I, but got Obj
		//IL_0508: Expected Obj, but got I
		//IL_03c5: Expected I, but got Obj
		//IL_06df: Expected Obj, but got I4
		//IL_0115: Expected I, but got Obj
		//IL_05d4: Expected I, but got Obj
		//IL_073c: Expected Obj, but got I4
		//IL_0324: Expected I, but got Obj
		//IL_0533: Expected I, but got Obj
		List<Material> list = cachedMaterials;
		if (list._size >= 1)
		{
			int num = 0;
			while (true)
			{
				Material material = cachedMaterials.get_Item(num);
				int renderQueue = material.renderQueue;
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v109 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v131 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)renderQueue).FindKernel(null) != 0)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v122 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v127 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UnityEngine.Object.DestroyImmediate((UnityEngine.Object)renderQueue);
				}
				Material obj3 = cachedMaterials.get_Item(num);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v75 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(obj3);
				int num8 = num + 1;
				num = num8;
			}
		}
		if (headMaterials != null)
		{
			int num9 = 0;
			while (true)
			{
				Material material2 = headMaterials.get_Item(num9);
				int renderQueue2 = material2.renderQueue;
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num11 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)renderQueue2).FindKernel(null) != 0)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num13 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v88 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UnityEngine.Object.DestroyImmediate((UnityEngine.Object)renderQueue2);
				}
				Material obj7 = headMaterials.get_Item(num9);
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num15 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S1_v50 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(obj7);
				int num16 = num9 + 1;
				num9 = num16;
			}
		}
		if (customMaterials == null)
		{
			return;
		}
		int num17 = 0;
		while (true)
		{
			Material material3 = customMaterials.get_Item(num17);
			int renderQueue3 = material3.renderQueue;
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num19 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)renderQueue3).FindKernel(null) != 0)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num21 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)renderQueue3);
			}
			Material obj11 = customMaterials.get_Item(num17);
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num23 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(obj11);
			int num24 = num17 + 1;
			num17 = num24;
		}
	}

	public CharacterCustomization()
	{
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		OnDestroy();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_characterCustomizationBundle).FindKernel((string)null) == 0)
		{
			return;
		}
		string obj2 = _characterCustomizationBundle.tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj2);
	}
}
