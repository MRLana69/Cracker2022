using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

public class UICharacterThemeShifter : MonoBehaviour
{
	private const int MAX_NUMBER_OF_CUSTOM_THEMES = 3;

	private GameObject _defaultCharacterThemeButton;

	private GameObject _customCharacterThemeButton;

	private Transform _selectedMarker;

	private Vector3 _distanceBetweenButtons;

	private List<CharacterThemeButton> _customButtons;

	private Action<int> m_OnThemeButtonPressed;

	private int _activeTheme;

	private Characters.CharacterId _cachedCharacter;

	private List<Outfit> _currentCharacterThemes;

	private Outfit[] _sortedOutfits;

	public event Action<int> OnThemeButtonPressed
	{
		add
		{
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnThemeButtonPressed;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public void InitValues(Characters.CharacterId charId, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 41;
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 41)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void Awake()
	{
		CancelInvoke();
	}

	private Outfit[] SortThemes(List<Outfit> themes)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		Outfit[] array = default;
		object obj = array + 16;
		obj = this;
		object obj2 = array + 20;
		obj2 = themes;
		return array;
	}

	public void MakeCustomThemesAvailable(List<Outfit> themes)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnThemeButtonPressed;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)themes);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 40;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private unsafe void OnDisable()
	{
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0292: Expected Obj, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02c2: Expected VT, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_0012: Expected VT, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected VT, but got Unknown
		//IL_0311: Expected F4, but got Obj
		//IL_030c: Expected native int or pointer, but got VT
		//IL_0326: Expected F4, but got I
		//IL_0321: Expected native int or pointer, but got VT
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected VT, but got Unknown
		//IL_0341: Expected F4, but got Obj
		//IL_033c: Expected native int or pointer, but got VT
		//IL_0356: Expected F4, but got I
		//IL_0351: Expected native int or pointer, but got VT
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0382: Expected F4, but got Obj
		//IL_037d: Expected native int or pointer, but got VT
		//IL_0397: Expected F4, but got I
		//IL_0392: Expected native int or pointer, but got VT
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03af: Expected Obj, but got F4
		//IL_00a4: Expected I, but got Obj
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_01b5: Expected VT, but got I4
		//IL_01b5: Expected Obj, but got VT
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01e4: Expected VT, but got Obj
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0213: Expected VT, but got Obj
		//IL_021c: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got F4
		//IL_0253: Expected F4, but got Obj
		//IL_024e: Expected native int or pointer, but got VT
		//IL_0268: Expected F4, but got I
		//IL_0263: Expected native int or pointer, but got VT
		//IL_0271: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 96;
		obj = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 84);
		int layer = _defaultCharacterThemeButton.layer;
		transform.localPosition = (Vector3)layer;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Transform transform2 = (Transform)(obj2 + 72);
		int layer2 = _customCharacterThemeButton.layer;
		transform2.localPosition = (Vector3)layer2;
		object obj3 = obj2 + 60;
		obj3 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj4 = obj2 + 48;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v53 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 108);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v18+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj2 + 120);
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj6 = obj2 + 36;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector3);
		((Vector3*)(nint)vector3)->x = (float)obj6;
		Vector3 vector5 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v35+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj7 = this + 24;
		obj7 = vector3.x;
		_ = vector3.z;
		CharacterThemeButton component = _customCharacterThemeButton.GetComponent<CharacterThemeButton>();
		_customButtons.Add(component);
		CharacterThemeButton component2 = _defaultCharacterThemeButton.GetComponent<CharacterThemeButton>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<int> action = default;
		object obj8 = action + 16;
		obj8 = this;
		component2.OnPress -= action;
		CharacterThemeButton characterThemeButton = _customButtons.get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<int> action2 = default;
		object obj9 = action2 + 16;
		obj9 = this;
		characterThemeButton.OnPress -= action2;
		GameObject gameObject = _selectedMarker.gameObject;
		int layer3 = _defaultCharacterThemeButton.layer;
		((Transform)vector).position = (Vector3)layer3;
		Transform transform3 = (Transform)(obj2 + 24);
		GameObject gameObject2 = _selectedMarker.gameObject;
		transform3.position = (Vector3)gameObject2;
		Transform transform4 = (Transform)(obj2 + 12);
		GameObject gameObject3 = _selectedMarker.gameObject;
		transform4.position = (Vector3)gameObject3;
		obj2 = 0;
		_ = 0;
		obj2 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v81 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		((Vector3*)(nint)vector3)->x = (float)obj2;
		Vector3 vector6 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 localPosition = ((Transform)vector3).localPosition;
	}

	private unsafe void SetActiveBubbles(CharacterThemeButton btn, Outfit ot, Characters.CharacterId id, int index)
	{
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0424: Expected Obj, but got I4
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_046d: Expected I, but got Obj
		//IL_0483: Expected Obj, but got I
		//IL_051a: Expected Obj, but got I
		//IL_04e4: Expected VT, but got Obj
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected VT, but got Unknown
		//IL_00a8: Expected I, but got Obj
		//IL_04c8: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0037: Expected I, but got Obj
		//IL_0529: Expected Obj, but got I4
		//IL_01ec: Expected VT, but got Obj
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0193: Expected I, but got Obj
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I4
		//IL_0557: Expected F4, but got Obj
		//IL_0552: Expected native int or pointer, but got VT
		//IL_0569: Expected F4, but got I
		//IL_0564: Expected native int or pointer, but got VT
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_05a1: Expected VT, but got Obj
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0303: Expected VT, but got Obj
		//IL_0310: Expected F4, but got Obj
		//IL_030b: Expected native int or pointer, but got VT
		//IL_0325: Expected F4, but got I
		//IL_0320: Expected native int or pointer, but got VT
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_035a: Expected VT, but got Obj
		//IL_0289: Expected I, but got Obj
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_0390: Expected VT, but got Obj
		//IL_039d: Expected F4, but got Obj
		//IL_0398: Expected native int or pointer, but got VT
		//IL_03af: Expected F4, but got I
		//IL_03aa: Expected native int or pointer, but got VT
		//IL_03d9: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 168;
		obj = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 216);
		transform = (Transform)(object)btn;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)btn).m_CachedPtr;
		Vector3 localPosition = transform.localPosition;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		Component component;
		if (index != 0)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v113 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v111 (System.Boolean)+38]");
			component = (Component)0;
		}
		else
		{
			if (!flag)
			{
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v103 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v101 (System.Boolean)+20]");
			component = (Component)0;
		}
		GameObject gameObject = component.gameObject;
		((Transform)(object)this).LookAt((Vector3)gameObject);
		Vector3 vector = (Vector3)(obj2 + 180);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CF5");
		Transform transform2 = (Transform)(obj2 + 156);
		object obj4 = vector + 12;
		transform2 = (Transform)obj4;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v20+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		transform = transform2;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		((Transform)(object)this).LookAt(transform);
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v88 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)id).FindKernel(null) != 0)
		{
			UIExtensions.CenterOnWidget((Transform)(object)this, (UIWidget)id, null);
		}
		transform2.localScale = (Vector3)this;
		object obj6 = obj2 + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CF5");
		object obj7 = obj2 + 108;
		object obj8 = obj6 + 24;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v37+8]");
		_ = 0;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v83 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		transform = (Transform)obj7;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v41+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj10 = obj2 + 96;
		Vector3 vector2 = Vector3.Cross(vector, (Vector3)transform);
		transform = (Transform)obj10;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v53+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		((Transform)(object)this).parent = transform;
		object obj11 = obj2 + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CF5");
		object obj12 = obj2 + 48;
		obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v58+8]");
		_ = 0;
		Transform transform6 = (Transform)(obj2 + 36);
		transform6.localScale = (Vector3)this;
		((Vector3*)(nint)vector)->x = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v60+8]");
		((Vector3*)(nint)vector)->z = 0f;
		transform = transform6;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform6).m_CachedPtr;
		object obj13 = obj2 + 24;
		Vector3 vector3 = Vector3.Cross(vector, (Vector3)transform);
		obj = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v69+8]");
		_ = 0;
		Transform transform7 = (Transform)(obj2 + 12);
		transform7.localPosition = (Vector3)this;
		((Vector3*)(nint)vector)->x = (float)transform7;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform7).m_CachedPtr;
		transform = (Transform)obj;
		Transform transform8 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
		Vector3 vector4 = vector - (Vector3)transform;
		transform = (Transform)obj2;
		Transform transform9 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	private unsafe void SelectButton(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected Obj, but got Unknown
		//IL_0833: Expected Obj, but got I4
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected Obj, but got Unknown
		//IL_0868: Expected Obj, but got I4
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected I, but got Unknown
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected I4, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected I4, but got Unknown
		//IL_0b51: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I4
		//IL_0b9d: Expected I, but got Obj
		//IL_0bb3: Expected Obj, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected Obj, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected Obj, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected Obj, but got Unknown
		//IL_091a: Expected Obj, but got VT
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected Obj, but got Unknown
		//IL_0931: Expected Obj, but got VT
		//IL_0939: Expected I, but got Obj
		//IL_0946: Expected I4, but got Obj
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected I4, but got Unknown
		//IL_0250: Expected Obj, but got I
		//IL_0271: Expected I, but got Obj
		//IL_023b: Expected Obj, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_0334: Expected I, but got Obj
		//IL_034a: Expected Obj, but got I
		//IL_0375: Expected I, but got Obj
		//IL_0319: Expected Obj, but got I4
		//IL_09a7: Expected I, but got Obj
		//IL_09bd: Expected Obj, but got I
		//IL_05ef: Expected I, but got Obj
		//IL_040f: Expected Obj, but got I4
		//IL_0442: Expected VT, but got I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_0470: Expected I, but got Obj
		//IL_0486: Expected Obj, but got I
		//IL_0a16: Expected I4, but got Obj
		//IL_0a30: Expected F4, but got I4
		//IL_0a30: Expected VT, but got I4
		//IL_0a41: Expected I4, but got Obj
		//IL_0a58: Expected I4, but got Obj
		//IL_0a72: Expected VT, but got I4
		//IL_0a72: Expected VT, but got I4
		//IL_0a83: Expected I4, but got Obj
		//IL_0a99: Expected Obj, but got I4
		//IL_04b1: Expected I, but got Obj
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected Obj, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got Unknown
		//IL_06b3: Expected I4, but got Obj
		//IL_06c9: Expected Obj, but got I
		//IL_06d9: Expected Obj, but got I
		//IL_06e9: Expected Obj, but got I
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected I4, but got Unknown
		//IL_0734: Expected I, but got Obj
		//IL_074a: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I4
		//IL_0ae0: Expected Obj, but got I4
		//IL_0b0b: Expected I4, but got Obj
		//IL_0b0b: Expected I4, but got Obj
		//IL_0580: Expected I4, but got Obj
		//IL_07c4: Expected Obj, but got I
		//IL_07d4: Expected Obj, but got I
		//IL_07f1: Expected I4, but got Obj
		//IL_07fe: Expected I4, but got Obj
		//IL_0775: Expected I, but got Obj
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 128;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 56;
		obj4 = obj;
		_ = -1;
		object obj5 = this + 52;
		obj5 = index;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
		if ((nint)0 >= (nint)1)
		{
			object obj6 = this + 56;
			HoverboardThemes.HoverboardTheme[] array = ((UIHoverboardThemeShifter)null).SortThemes((List<HoverboardThemes.HoverboardTheme>)index);
			obj6 = array;
		}
		nint num = (nint)(obj2 + 84);
		int num2 = obj2 + 80;
		Characters.CharacterId characterId = (Characters.CharacterId)(obj2 + 104);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = ((Characters.CharacterId*)(int)characterId)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v30 (SYBO.Subway.Info.Characters+CharacterId)+8]");
		_ = 0;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 86;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 86)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0b63;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0b63;
		IL_0b63:
		object obj17;
		if (index != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
			if ((nint)0 > (nint)3)
			{
				obj17 = 3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
				obj17 = 0;
			}
		}
		else
		{
			obj17 = 0;
		}
		CharacterThemeButton component = _defaultCharacterThemeButton.GetComponent<CharacterThemeButton>();
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v34 (Il2CppClass<GlobalColors>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v151 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj19 = obj2 + 12;
		object obj20 = obj2 + 52;
		object obj21 = obj2 + 48;
		Transform transform = (Transform)(obj2 + 36);
		transform = (Transform)GlobalColors.CHARACTERS_CUSTOMIZATION_BASE_SKIN_FILL;
		object obj22 = obj2 + 24;
		obj22 = GlobalColors.CHARACTERS_CUSTOMIZATION_BASE_SKIN_ICON;
		num = (nint)transform;
		((int*)num2)->m_value = (int)obj22;
		int num5 = obj2 + 88;
		((int*)num5)->m_value = (int)num;
		((Characters.CharacterId*)(int)characterId)->value__ = ((int*)num2)->m_value;
		((ScrollListCharacterUI)(object)component).Init2D(num5, characterId, false);
		int num6 = 0;
		string text4 = default;
		Action<int> action = default;
		object obj35 = default;
		while (num6 < (nint)obj17)
		{
			List<CharacterThemeButton> customButtons = _customButtons;
			CharacterThemeButton characterThemeButton2;
			if (customButtons._size > num6)
			{
				CharacterThemeButton characterThemeButton = _customButtons.get_Item(num6);
				string text = characterThemeButton.tag;
				((GameObject)(object)text).tag = (string)1;
				characterThemeButton2 = characterThemeButton;
			}
			else
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S1_v144 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameObject gameObject = UnityEngine.Object.Instantiate(_customCharacterThemeButton);
				CharacterThemeButton component2 = gameObject.GetComponent<CharacterThemeButton>();
				int num9 = ((ComputeShader)(object)component2).FindKernel((string)null);
				bool flag = num9 == 0;
				characterThemeButton2 = component2;
				if (!flag)
				{
					GameObject gameObject2 = component2.gameObject;
					string text2 = tag;
					int layer = ((GameObject)(object)text2).layer;
					((Transform)(object)gameObject2).parentInternal = (Transform)layer;
					GameObject gameObject3 = component2.gameObject;
					int layer2 = _customCharacterThemeButton.layer;
					transform.localPosition = (Vector3)layer2;
					object obj24 = this + 24;
					obj22 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S2_v55+8]");
					_ = 0;
					nint num10 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S1_v106 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num11 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S1_v140 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Characters.CharacterId*)(int)characterId)->value__ = (int)obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S1_v47+8]");
					_ = 0;
					Vector3 vector = (Vector3)characterId / num6;
					((int*)num5)->m_value = (int)transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					((Characters.CharacterId*)(int)characterId)->value__ = (int)obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S1_v39+8]");
					_ = 0;
					Vector3 vector2 = (Vector3)num5 - (Vector3)characterId;
					((Characters.CharacterId*)(int)characterId)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Vector3 eulerAngles = ((Transform)characterId).eulerAngles;
					GameObject gameObject4 = component2.gameObject;
					Vector3 forward = Vector3.forward;
					((Characters.CharacterId*)(int)characterId)->value__ = ((int*)num5)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v51 (System.Int32)+8]");
					_ = 0;
					((Transform)(object)gameObject4).parent = (Transform)characterId;
					int value__ = num6 + 1;
					((Characters.CharacterId*)(int)characterId)->value__ = value__;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					string text3 = text4 + "CharThemeBtn";
					UnityEngine.Object.DestroyImmediate(component2, (byte)(int)text3 != 0);
					_customButtons.Add(component2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num12 = 0;
					_ = 0;
					object obj26 = action + 16;
					obj26 = this;
					component2.OnPress -= action;
					characterThemeButton2 = component2;
				}
			}
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v64 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)characterThemeButton2).FindKernel((string)null) != 0 && _sortedOutfits != null)
			{
				Outfit[] sortedOutfits = _sortedOutfits;
				if (sortedOutfits.Length > num6)
				{
					object obj28 = _sortedOutfits + 16;
					int num15 = num6 << 2;
					object obj29 = obj28 + num15;
					int num16 = (int)obj29;
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ S4_v6 (Il2CppMethodInfo)+C]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S4_v7+60]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S4_v8+8C]");
					object obj32 = 0;
					object obj33 = obj32 & 0x7FF;
					object obj34 = obj33 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v515 @ S5_v6 (should have been resolved before IL gen)");
					int num18 = obj35 + 1;
					bool isInstanced = UIScreenController.IsInstanced;
					nint num19 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S0_v87 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					if (obj36 != null)
					{
						nint num20 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v100 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v84 (System.Boolean)+84]");
					bool flag2 = CharacterManager.IsCollectionComplete(Characters.CharacterId.slick);
					Transform transformToTrack = (Transform)((flag2 ? 1 : 0) ^ 1);
					((ScrollListCharacterUI)(object)characterThemeButton2).Init3D(transformToTrack);
					CharacterThemeButton characterThemeButton3 = characterThemeButton2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v84 (System.Boolean)+84]");
					((BMFont)(object)this).Trim((int)characterThemeButton3, (int)obj29, 0, num18);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S1_v67 (System.Int32)+8]");
					transform = (Transform)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S1_v67 (System.Int32)+C]");
					obj22 = 0;
					obj20 = transform;
					obj21 = obj22;
					((int*)num5)->m_value = (int)obj20;
					((Characters.CharacterId*)(int)characterId)->value__ = (int)obj21;
					((ScrollListCharacterUI)(object)characterThemeButton2).Init2D(num5, characterId, (byte)num18 != 0);
				}
			}
			int num21 = num6 + 1;
			num6 = num21;
		}
	}

	private void ThemeButtonPressed(int index)
	{
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0163: Expected VT, but got Obj
		//IL_0096: Expected VT, but got I4
		//IL_0184: Expected VT, but got Obj
		//IL_01a5: Expected VT, but got Obj
		//IL_01b3: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 48);
		Transform transform2 = (Transform)(obj2 + 36);
		Transform transform3 = (Transform)(obj2 + 24);
		Transform transform4 = (Transform)(obj2 + 12);
		bool flag = index == 0;
		if (((ComputeShader)(object)_selectedMarker).FindKernel((string)null) != 0)
		{
			GameObject gameObject = _selectedMarker.gameObject;
			if (flag)
			{
				int layer = _defaultCharacterThemeButton.layer;
				transform2.position = (Vector3)layer;
			}
			else
			{
				List<Outfit> currentCharacterThemes = _currentCharacterThemes;
				int num3 = index << 2;
				object obj3 = _sortedOutfits + num3;
				object obj4 = obj3 + 12;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S7_v4 (Il2CppMethodInfo)+C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S7_v5+60]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S7_v6+8C]");
				object obj7 = 0;
				object obj8 = obj7 & 0x7FF;
				object obj9 = obj8 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v144 @ S8_v6 (should have been resolved before IL gen)");
				int index2 = default;
				CharacterThemeButton characterThemeButton = _customButtons.get_Item(index2);
				GameObject gameObject2 = characterThemeButton.gameObject;
				transform2.position = (Vector3)gameObject2;
			}
			GameObject gameObject3 = _selectedMarker.gameObject;
			transform3.position = (Vector3)gameObject3;
			GameObject gameObject4 = _selectedMarker.gameObject;
			transform4.position = (Vector3)gameObject4;
			obj2 = 0;
			_ = 0;
			obj2 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform4).m_CachedPtr;
			transform = (Transform)obj2;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform.localPosition;
		}
	}

	public void UpdateUIForCharacter(Characters.CharacterId charId, int outfitIndex)
	{
		_cachedCharacter = charId;
		_activeTheme = outfitIndex;
	}

	public UICharacterThemeShifter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 57)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
