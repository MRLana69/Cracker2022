using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class HoverboardBundle : MonoBehaviour
{
	[Serializable]
	public class CustomSet
	{
		public Hoverboard.BoardAbility ability;

		public GameObject baseModelPrefab;

		public GameObject modelPrefab;

		public GameObject VanityFxPrefab;

		public GameObject VanityMenuFxPrefab;

		public bool useDefaultmodel = true;

		public bool useSuperSneakers;

		public GameObject ExtraFXPrefab;

		public GameObject ExtraMenuFXPrefab;
	}

	private CustomSet[] customSets;

	private Hoverboards.BoardType boardType;

	private GameObject modelPrefab;

	private GameObject previewModelPrefab;

	private CharacterModel _charactermodel;

	public CustomSet[] CustomSets => customSets;

	public Hoverboards.BoardType BoardType => boardType;

	public CharacterModel Charactermodel
	{
		get
		{
			return _charactermodel;
		}
		set
		{
			_charactermodel = value;
		}
	}

	public void AddModel(bool isMenu)
	{
		//IL_0055: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		if (!(modelPrefab != null))
		{
			return;
		}
		GameObject gameObject = InstatiateAndParentModelPrefab(modelPrefab);
		if (isMenu)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S3_v5 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			object obj = 0;
			object obj5 = default;
			while (true)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v28+C]");
				if ((nint)obj2 >= 0)
				{
					break;
				}
				object obj3 = obj << 2;
				object obj4 = obj5 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v34+10]");
				GameObject gameObject2 = ((Component)0).gameObject;
				Layers instance = Layers.Instance;
				gameObject2.layer = instance._3DGUI;
				object obj6 = obj + 1;
				obj = obj6;
			}
		}
		if (_charactermodel != null)
		{
			CharacterModel charactermodel = _charactermodel;
			Renderer component = gameObject.GetComponent<Renderer>();
			charactermodel.currentHoverboadBasemodel = component;
		}
	}

	public void AddCustomPreviewModel()
	{
		if (previewModelPrefab != null)
		{
			GameObject gameObject = InstatiateAndParentModelPrefab(previewModelPrefab);
			Layers instance = Layers.Instance;
			gameObject.layer = instance._3DGUI;
			CharacterModel charactermodel = _charactermodel;
			Renderer component = gameObject.GetComponent<Renderer>();
			charactermodel.currentHoverboadBasemodel = component;
		}
		else
		{
			AddModel(isMenu: true);
		}
	}

	public void AddCustomBaseModel(int customSet, bool isMenu)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		int num = customSet << 2;
		object obj = customSets + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8+C]");
		if ((UnityEngine.Object)0 != null)
		{
			int num2 = customSet << 2;
			object obj3 = customSets + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v8+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+C]");
			GameObject gameObject = InstatiateAndParentModelPrefab((GameObject)0);
			nint num3 = 0;
			nint num4 = 0;
			IntPtr intPtr = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S3_v5 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			Component component = default;
			if (isMenu)
			{
				GameObject gameObject2 = component.gameObject;
				Layers instance = Layers.Instance;
				gameObject2.layer = instance._3DGUI;
			}
			if (_charactermodel != null)
			{
				CharacterModel charactermodel = _charactermodel;
				charactermodel.currentHoverboadBasemodel = (Renderer)component;
			}
		}
	}

	public void AddCustomSetModelAndEffect(int customSet, bool isMenu, bool addEffect)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_05fd: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_0504: Expected Obj, but got I
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_06ba: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_056f: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_047a: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<Renderer> list = default;
		list._002Ector();
		int num = customSet << 2;
		object obj3 = customSets + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15+10]");
		if ((UnityEngine.Object)0 != null)
		{
			int num2 = customSet << 2;
			object obj5 = customSets + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v97+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v98+10]");
			GameObject gameObject = InstatiateAndParentModelPrefab((GameObject)0);
			nint num3 = 0;
			nint num4 = 0;
			IntPtr intPtr = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S4_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		}
		object obj7 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj8 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		object obj15 = default;
		object obj16 = default;
		HoverboardBundle hoverboardBundle = default;
		bool flag2 = default;
		while (true)
		{
			_ = 0;
			object obj9 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj10 == null)
				{
					goto IL_03a2;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj11 != null)
							{
								CharacterModel charactermodel = _charactermodel;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_0313;
								}
							}
							if (!isMenu)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0313;
			IL_0313:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj12 != obj13;
			object obj14 = obj15;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_03a2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj14 = obj16;
			}
			_ = 0;
			object obj17 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			hoverboardBundle = (HoverboardBundle)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_03a2:
			object obj18 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37E7");
			if (flag2)
			{
				int num5 = customSet << 2;
				object obj19 = customSets + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v59+10]");
				bool flag3 = false;
				if (!isMenu)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v60 (System.Boolean)+18]");
				if ((UnityEngine.Object)0 != null)
				{
					int num6 = customSet << 2;
					object obj20 = customSets + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v44+10]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S1_v45+18]");
					GameObject gameObject2 = InstatiateAndParentModelPrefab((GameObject)0);
					Layers instance = Layers.Instance;
					gameObject2.layer = instance._3DGUI;
				}
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v60 (System.Boolean)+14]");
		if ((UnityEngine.Object)0 != null)
		{
			int num7 = customSet << 2;
			object obj22 = hoverboardBundle.customSets + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S1_v32+10]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S1_v33+14]");
			GameObject gameObject3 = ((HoverboardBundle)num8).InstatiateAndParentModelPrefab((GameObject)0);
		}
	}

	private unsafe GameObject InstatiateAndParentModelPrefab(GameObject prefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected VT, but got Unknown
		//IL_00e6: Expected I, but got Obj
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected VT, but got Unknown
		//IL_015e: Expected I, but got Obj
		//IL_0183: Expected F4, but got I
		//IL_017e: Expected native int or pointer, but got VT
		//IL_0191: Expected F4, but got VT
		//IL_018c: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		GameObject gameObject = UnityEngine.Object.Instantiate(prefab);
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		transform.parent = parent;
		Transform transform2 = gameObject.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform2.localPosition = localPosition;
		Transform transform3 = gameObject.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v34 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v35 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		transform3.localRotation = localRotation;
		Transform transform4 = gameObject.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v33 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v34 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		return gameObject;
	}
}
