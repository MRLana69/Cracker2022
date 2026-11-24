using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using UI.Screens.BoardScreenInternal;
using UI.Screens.NotEnoughCurrencyPopupInternal;
using UnityEngine;

public class UIHoverboardThemeShifter : MonoBehaviour
{
	private const int MAX_NUMBER_OF_CUSTOM_THEMES = 3;

	private GameObject _defaultHoverboardThemeButton;

	private GameObject _customHoverboardThemeButton;

	private Transform _selectedMarker;

	private Vector3 _distanceBetweenButtons;

	private List<HoverboardThemeButton> _customButtons;

	private Action<int> m_OnClickedTheme;

	private Boards.BoardId _cachedBoard;

	private int _cachedThemeIndex;

	private List<HoverboardThemes.HoverboardTheme> _currentBoardThemes;

	private HoverboardThemes.HoverboardTheme[] _sortedThemes;

	private BoardManager.ScreenContext _context;

	public event Action<int> OnClickedTheme
	{
		add
		{
			//IL_0033: Expected Obj, but got I4
			if (value == null)
			{
				_customHoverboardThemeButton = (GameObject)1;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnClickedTheme;
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

	private void Awake()
	{
		CancelInvoke();
	}

	public void Init(BoardManager.ScreenContext context)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnClickedTheme;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)context);
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

	private HoverboardThemes.HoverboardTheme[] SortThemes(List<HoverboardThemes.HoverboardTheme> themes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [459268]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Outfit> list = default;
		list._002Ector();
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S3_v3+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v4+38]");
		object obj7 = 0;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S4_v4 (should have been resolved before IL gen)");
		Outfit outfit = ((List<Outfit>)(object)themes).get_Item(0);
		object obj10 = 0;
		Outfit outfit2 = outfit;
		object obj11 = default;
		if ((nint)obj11 < themes._size)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			int num2 = int.MaxValue;
			object obj12 = default;
			Outfit outfit3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj12 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (outfit3.uiPriority < num2)
				{
					num2 = outfit3.uiPriority;
					outfit2 = outfit3;
				}
			}
			object obj13 = obj4 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj4 + obj15;
			obj16 = 109;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj17 = (nint)0 << 2;
				object obj18 = obj4 + obj17;
				if ((nint)obj18 == 109)
				{
					object obj19 = obj4 + 4;
					if ((nint)obj19 > -1)
					{
						object obj20 = obj19 + -1;
						obj19 = obj20;
					}
					goto IL_0270;
				}
			}
			if (obj10 == null)
			{
				goto IL_0270;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return null;
		}
		HoverboardThemes.HoverboardTheme[] result = default;
		return result;
		IL_0270:
		throw new ArrayTypeMismatchException();
	}

	public void MakeCustomThemesAvailable(List<HoverboardThemes.HoverboardTheme> themes)
	{
		//IL_000a: Expected I4, but got Obj
		_context = (BoardManager.ScreenContext)themes;
	}

	private unsafe void OnDisable()
	{
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02ea: Expected VT, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0012: Expected VT, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected VT, but got Unknown
		//IL_0339: Expected F4, but got Obj
		//IL_0334: Expected native int or pointer, but got VT
		//IL_034e: Expected F4, but got I
		//IL_0349: Expected native int or pointer, but got VT
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected VT, but got Unknown
		//IL_0369: Expected F4, but got Obj
		//IL_0364: Expected native int or pointer, but got VT
		//IL_037e: Expected F4, but got I
		//IL_0379: Expected native int or pointer, but got VT
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_03aa: Expected F4, but got Obj
		//IL_03a5: Expected native int or pointer, but got VT
		//IL_03bf: Expected F4, but got I
		//IL_03ba: Expected native int or pointer, but got VT
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got F4
		//IL_00a4: Expected I, but got Obj
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01dd: Expected VT, but got I4
		//IL_01dd: Expected Obj, but got VT
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_020c: Expected VT, but got Obj
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_023b: Expected VT, but got Obj
		//IL_0244: Expected Obj, but got I4
		//IL_0257: Expected Obj, but got F4
		//IL_027b: Expected F4, but got Obj
		//IL_0276: Expected native int or pointer, but got VT
		//IL_0290: Expected F4, but got I
		//IL_028b: Expected native int or pointer, but got VT
		//IL_0299: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 96;
		obj = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 84);
		int layer = _defaultHoverboardThemeButton.layer;
		transform.localPosition = (Vector3)layer;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Transform transform2 = (Transform)(obj2 + 72);
		int layer2 = _customHoverboardThemeButton.layer;
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
		HoverboardThemeButton component = _customHoverboardThemeButton.GetComponent<HoverboardThemeButton>();
		_customButtons.Add(component);
		HoverboardThemeButton component2 = _defaultHoverboardThemeButton.GetComponent<HoverboardThemeButton>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		HoverboardThemeButton.OnPressEvent onPressEvent = default;
		((Delegate)onPressEvent).method_ptr = method_ptr;
		((Delegate)onPressEvent).method = (nint)__ldftn(UIHoverboardThemeShifter.ClickedTheme);
		object obj8 = onPressEvent + 16;
		obj8 = this;
		component2.OnPress -= onPressEvent;
		HoverboardThemeButton hoverboardThemeButton = _customButtons.get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		HoverboardThemeButton.OnPressEvent onPressEvent2 = default;
		((Delegate)onPressEvent2).method_ptr = method_ptr2;
		((Delegate)onPressEvent2).method = (nint)__ldftn(UIHoverboardThemeShifter.ClickedTheme);
		object obj9 = onPressEvent2 + 16;
		obj9 = this;
		hoverboardThemeButton.OnPress -= onPressEvent2;
		GameObject gameObject = _selectedMarker.gameObject;
		int layer3 = _defaultHoverboardThemeButton.layer;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v75 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		((Vector3*)(nint)vector3)->x = (float)obj2;
		Vector3 vector6 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 localPosition = ((Transform)vector3).localPosition;
	}

	private unsafe void SetActiveBubbles(HoverboardThemeButton btn, HoverboardThemes.HoverboardTheme ht, Boards.BoardId boardId, int index, int themeCount)
	{
		//IL_002d: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_008e: Expected I4, but got Obj
		//IL_009c: Expected Obj, but got I4
		int num = default;
		((int*)num)->m_value = ((Boards.BoardId*)(int)boardId)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L3 (Info.Boards+BoardId)+8]");
		_ = 0;
		byte[] array = (byte[])(num + 12);
		array = (byte[])((int*)index)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L4 (System.Int32)+8]");
		_ = 0;
		int num2 = num + 24;
		((int*)num2)->m_value = ((int*)themeCount)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [themeCount @ L5 (System.Int32)+8]");
		_ = 0;
		int bytes = ((ASCIIEncoding)null).GetBytes((char[])(object)btn, (int)ht, num, array, num2);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)bytes);
	}

	private void UpdateSelector(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected Obj, but got Unknown
		//IL_07ae: Expected Obj, but got I4
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_07e8: Expected Obj, but got I4
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got Unknown
		//IL_07fb: Expected Obj, but got I4
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I4
		//IL_0dff: Expected I, but got Obj
		//IL_0e15: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected Obj, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected Obj, but got Unknown
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected Obj, but got Unknown
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got Unknown
		//IL_0914: Expected Obj, but got VT
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected Obj, but got Unknown
		//IL_092b: Expected Obj, but got VT
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_0970: Expected I4, but got Obj
		//IL_0258: Expected Obj, but got I
		//IL_0279: Expected I, but got Obj
		//IL_0243: Expected Obj, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_0424: Expected I, but got Obj
		//IL_043a: Expected Obj, but got I
		//IL_04c1: Expected I, but got Obj
		//IL_0465: Expected I, but got Obj
		//IL_099f: Expected Obj, but got I4
		//IL_0505: Expected Obj, but got I4
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0388: Expected I4, but got Obj
		//IL_0396: Expected I, but got Obj
		//IL_03ac: Expected Obj, but got I
		//IL_09ca: Expected Obj, but got I
		//IL_09da: Expected Obj, but got I
		//IL_09ea: Expected Obj, but got I
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected Obj, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected Obj, but got Unknown
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected I4, but got Unknown
		//IL_0a44: Expected I4, but got Obj
		//IL_0a44: Expected I4, but got Obj
		//IL_0a54: Expected Obj, but got I
		//IL_0a64: Expected Obj, but got I
		//IL_0a7a: Expected Obj, but got I
		//IL_0a8a: Expected Obj, but got I
		//IL_0a9a: Expected Obj, but got I
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected Obj, but got Unknown
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected Obj, but got Unknown
		//IL_0aee: Expected Obj, but got I
		//IL_0538: Expected VT, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_0566: Expected I, but got Obj
		//IL_057c: Expected Obj, but got I
		//IL_03d7: Expected I, but got Obj
		//IL_0b8b: Expected F4, but got I4
		//IL_0b8b: Expected VT, but got Obj
		//IL_0bd3: Expected VT, but got Obj
		//IL_0bd3: Expected VT, but got Obj
		//IL_05a7: Expected I, but got Obj
		//IL_0636: Expected Obj, but got I4
		//IL_066c: Expected I4, but got Obj
		//IL_0c3b: Expected Obj, but got I
		//IL_0c4d: Expected Obj, but got I
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected Obj, but got Unknown
		//IL_0702: Expected I4, but got Obj
		//IL_0710: Expected I, but got Obj
		//IL_0726: Expected Obj, but got I
		//IL_0c78: Expected Obj, but got I
		//IL_0c88: Expected Obj, but got I
		//IL_0c98: Expected Obj, but got I
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected Obj, but got Unknown
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected Obj, but got Unknown
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected I4, but got Unknown
		//IL_0cf2: Expected I4, but got Obj
		//IL_0cf2: Expected I4, but got Obj
		//IL_0d02: Expected Obj, but got I
		//IL_0d12: Expected Obj, but got I
		//IL_0d28: Expected Obj, but got I
		//IL_0d38: Expected Obj, but got I
		//IL_0d48: Expected Obj, but got I
		//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Expected Obj, but got Unknown
		//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Expected Obj, but got Unknown
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Expected Obj, but got Unknown
		//IL_0751: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 128;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 56;
		obj4 = obj;
		_ = -1;
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		object obj5 = this + 52;
		obj5 = index;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
		if ((nint)0 >= (nint)1)
		{
			object obj6 = this + 56;
			CharacterModel activeCharacterModel = ((UIModelController)null).GetActiveCharacterModel((UIModelController.ModelScreen)index);
			obj6 = activeCharacterModel;
		}
		HoverboardThemeButton hoverboardThemeButton = (HoverboardThemeButton)(obj2 + 92);
		HoverboardThemeButton hoverboardThemeButton2 = (HoverboardThemeButton)(obj2 + 88);
		Transform transform = (Transform)(obj2 + 112);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
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
		obj11 = 98;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 98)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0dc5;
			}
		}
		nint num = default;
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0dc5;
		IL_0dc5:
		object obj16;
		if (index != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
			if ((nint)0 > (nint)3)
			{
				obj16 = 3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
				obj16 = 0;
			}
		}
		else
		{
			obj16 = 0;
		}
		HoverboardThemeButton component = _defaultHoverboardThemeButton.GetComponent<HoverboardThemeButton>();
		nint num2 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S2_v12 (Il2CppClass<GlobalColors>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S2_v98 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj18 = obj2 + 84;
		object obj19 = obj2 + 80;
		object obj20 = obj2 + 12;
		object obj21 = obj2 + 52;
		object obj22 = obj2 + 48;
		Transform transform2 = (Transform)(obj2 + 36);
		transform2 = (Transform)GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_FILL;
		object obj23 = obj2 + 24;
		obj23 = GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_ICON;
		hoverboardThemeButton = (HoverboardThemeButton)(object)transform2;
		hoverboardThemeButton2 = (HoverboardThemeButton)obj23;
		GameObject gameObject = (GameObject)(obj2 + 96);
		gameObject = (GameObject)(object)hoverboardThemeButton;
		transform = (Transform)(object)hoverboardThemeButton2;
		((UiElementsManager)(object)component).ActivateUiElement((UiElementType)string.Empty, gameObject, transform, (OnActivatedPrefab)null);
		OnActivatedPrefab onActivatedPrefab = null;
		int num4 = 0;
		object obj32 = default;
		nint num10 = default;
		string text5 = default;
		object obj48 = default;
		object obj54 = default;
		nint num22 = default;
		while (num4 < (nint)obj16)
		{
			List<HoverboardThemeButton> customButtons = _customButtons;
			if (customButtons._size > num4)
			{
				HoverboardThemeButton hoverboardThemeButton3 = _customButtons.get_Item(num4);
				if (_sortedThemes != null)
				{
					HoverboardThemes.HoverboardTheme[] sortedThemes = _sortedThemes;
					if (sortedThemes.Length > num4)
					{
						object obj24 = _sortedThemes + 16;
						int num5 = num4 << 2;
						object obj25 = obj24 + num5;
						UIModelController.ModelScreen modelScreen = (UIModelController.ModelScreen)obj25;
						nint num6 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v146 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
						object obj26 = (nint)0 & (nint)0x200;
						if (obj26 != null)
						{
							nint num7 = (nint)typeof(BoardManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v163 (Il2CppClass<Data.Managers.BoardManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int currentlyShownHoverboardTheme = BoardManager.GetCurrentlyShownHoverboardTheme(_context);
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S8_v11 (Il2CppMethodInfo)+C]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S8_v12+60]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S8_v13+8C]");
						object obj29 = 0;
						object obj30 = obj29 & 0x7FF;
						object obj31 = obj30 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v541 @ S9_v3 (should have been resolved before IL gen)");
						bool willAllowSignatureAnimation = (byte)(obj32 + 1) != 0;
						HoverboardThemes.HoverboardTheme[] sortedThemes2 = _sortedThemes;
						((UIModelController)this).ShowHoverboardMenuModel((Boards.BoardId)hoverboardThemeButton3, (UIModelController.ModelScreen)obj25, (byte)currentlyShownHoverboardTheme != 0, willAllowSignatureAnimation, (Hoverboard.BoardAbility)sortedThemes2.Length);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v142 (UIModelController+ModelScreen)+10]");
						transform2 = (Transform)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v142 (UIModelController+ModelScreen)+14]");
						obj23 = 0;
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ S4_v26 (Il2CppMethodInfo)+C]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S4_v27+60]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S4_v28+8C]");
						object obj35 = 0;
						object obj36 = obj35 & 0x7FF;
						object obj37 = obj36 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v585 @ S5_v25 (should have been resolved before IL gen)");
						obj18 = transform2;
						obj19 = obj23;
						gameObject = (GameObject)obj18;
						transform = (Transform)obj19;
						onActivatedPrefab = (OnActivatedPrefab)(num10 + 1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v142 (UIModelController+ModelScreen)+2C]");
						((UiElementsManager)(object)hoverboardThemeButton3).ActivateUiElement(UiElementType.FirstPurchaseBonusBanner, gameObject, transform, onActivatedPrefab);
					}
				}
				string text2 = hoverboardThemeButton3.tag;
				((GameObject)(object)text2).tag = (string)1;
			}
			else
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S1_v123 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameObject gameObject2 = UnityEngine.Object.Instantiate(_customHoverboardThemeButton);
				HoverboardThemeButton component2 = gameObject2.GetComponent<HoverboardThemeButton>();
				int num13 = ((ComputeShader)(object)component2).FindKernel((string)null);
				bool flag = num13 == 0;
				num = (nint)typeof(UnityEngine.Object);
				if (!flag)
				{
					GameObject gameObject3 = component2.gameObject;
					string text3 = tag;
					int layer = ((GameObject)(object)text3).layer;
					((Transform)(object)gameObject3).parentInternal = (Transform)layer;
					GameObject gameObject4 = component2.gameObject;
					int layer2 = _customHoverboardThemeButton.layer;
					transform2.localPosition = (Vector3)layer2;
					object obj39 = this + 24;
					obj23 = obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S2_v47+8]");
					_ = 0;
					nint num14 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S1_v64 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj40 = (nint)0 & (nint)0x200;
					if (obj40 != null)
					{
						nint num15 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S1_v119 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform = (Transform)obj23;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S2_v29+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Vector3 vector = (Vector3)transform / num4;
					gameObject = (GameObject)(object)transform2;
					((UnityEngine.Object)gameObject).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					transform = (Transform)obj20;
					Transform transform4 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S2_v21+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					Vector3 vector2 = (Vector3)gameObject - (Vector3)transform;
					transform = (Transform)obj2;
					Transform transform5 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles = transform.eulerAngles;
					GameObject gameObject5 = component2.gameObject;
					Vector3 forward = Vector3.forward;
					transform = (Transform)(object)gameObject;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)gameObject).m_CachedPtr;
					((Transform)(object)gameObject5).parent = transform;
					object obj41 = num4 + 1;
					transform = (Transform)obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					string text4 = text5 + "BoardThemeBtn";
					UnityEngine.Object.DestroyImmediate(component2, (byte)(int)text4 != 0);
					bool flag2 = _sortedThemes == null;
					onActivatedPrefab = null;
					if (!flag2)
					{
						HoverboardThemes.HoverboardTheme[] sortedThemes3 = _sortedThemes;
						bool flag3 = sortedThemes3.Length > num4;
						bool flag4 = !flag3;
						onActivatedPrefab = null;
						if (!flag4)
						{
							object obj42 = _sortedThemes + 16;
							int num16 = num4 << 2;
							object obj43 = obj42 + num16;
							UIModelController.ModelScreen modelScreen2 = (UIModelController.ModelScreen)obj43;
							nint num17 = (nint)typeof(BoardManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ S0_v105 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
							object obj44 = (nint)0 & (nint)0x200;
							if (obj44 != null)
							{
								nint num18 = (nint)typeof(BoardManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S0_v122 (Il2CppClass<Data.Managers.BoardManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int currentlyShownHoverboardTheme2 = BoardManager.GetCurrentlyShownHoverboardTheme(_context);
							nint num19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S8_v5 (Il2CppMethodInfo)+C]");
							object obj45 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S8_v6+60]");
							object obj46 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S8_v7+8C]");
							object obj29 = 0;
							object obj47 = obj29 & 0x7FF;
							object obj31 = obj47 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v541 @ S9_v3 (should have been resolved before IL gen)");
							bool willAllowSignatureAnimation2 = (byte)(obj48 + 1) != 0;
							HoverboardThemes.HoverboardTheme[] sortedThemes4 = _sortedThemes;
							((UIModelController)this).ShowHoverboardMenuModel((Boards.BoardId)component2, (UIModelController.ModelScreen)obj43, (byte)currentlyShownHoverboardTheme2 != 0, willAllowSignatureAnimation2, (Hoverboard.BoardAbility)sortedThemes4.Length);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S0_v101 (UIModelController+ModelScreen)+10]");
							transform2 = (Transform)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S0_v101 (UIModelController+ModelScreen)+14]");
							obj23 = 0;
							nint num20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ S4_v13 (Il2CppMethodInfo)+C]");
							object obj49 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ S4_v14+60]");
							object obj50 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S4_v15+8C]");
							object obj51 = 0;
							object obj52 = obj51 & 0x7FF;
							object obj53 = obj52 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v826 @ S5_v13 (should have been resolved before IL gen)");
							obj21 = transform2;
							obj22 = obj23;
							gameObject = (GameObject)obj21;
							transform = (Transform)obj22;
							onActivatedPrefab = (OnActivatedPrefab)(obj54 + 1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S0_v101 (UIModelController+ModelScreen)+2C]");
							((UiElementsManager)(object)component2).ActivateUiElement(UiElementType.FirstPurchaseBonusBanner, gameObject, transform, onActivatedPrefab);
						}
					}
					_customButtons.Add(component2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num21 = 0;
					_ = 0;
					object obj55 = num22 + 16;
					obj55 = this;
					component2.OnPress -= (HoverboardThemeButton.OnPressEvent)num22;
				}
			}
			int num23 = num4 + 1;
			num4 = num23;
		}
		ResetThemeSelection();
	}

	public void DisableThemeShifter()
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

	public void UpdateThemeStates()
	{
		string text = tag;
		((GameObject)(object)text).tag = null;
	}

	public void ClickedTheme(int index)
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_00e9: Expected VT, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0118: Expected VT, but got Obj
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0147: Expected VT, but got Obj
		//IL_00c8: Expected VT, but got Obj
		//IL_0155: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		object obj = default;
		Transform transform = (Transform)(obj + 36);
		GameObject gameObject = _selectedMarker.gameObject;
		if (index != 0)
		{
			List<HoverboardThemes.HoverboardTheme> currentBoardThemes = _currentBoardThemes;
			int num = index << 2;
			object obj2 = _sortedThemes + num;
			object obj3 = obj2 + 12;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S7_v3 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S7_v4+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S7_v5+8C]");
			object obj6 = 0;
			object obj7 = obj6 & 0x7FF;
			object obj8 = obj7 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S8_v5 (should have been resolved before IL gen)");
			int index2 = default;
			HoverboardThemeButton hoverboardThemeButton = _customButtons.get_Item(index2);
			GameObject gameObject2 = hoverboardThemeButton.gameObject;
			transform.position = (Vector3)gameObject2;
		}
		else
		{
			int layer = _defaultHoverboardThemeButton.layer;
			transform.position = (Vector3)layer;
		}
		Transform transform2 = (Transform)(obj + 24);
		GameObject gameObject3 = _selectedMarker.gameObject;
		transform2.position = (Vector3)gameObject3;
		Transform transform3 = (Transform)(obj + 12);
		GameObject gameObject4 = _selectedMarker.gameObject;
		transform3.position = (Vector3)gameObject4;
		obj = 0;
		_ = 0;
		obj = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v10 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Transform transform4 = (Transform)(obj + 48);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform4.localPosition;
	}

	public unsafe void ResetThemeSelection()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I4
		//IL_0226: Expected I, but got Obj
		//IL_0317: Expected Obj, but got I4
		//IL_0329: Expected I, but got Obj
		//IL_033f: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I4
		//IL_017c: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I4
		ref Notification reference = ref *(Notification*)null;
		while (true)
		{
			List<HoverboardThemeButton> customButtons = _customButtons;
			if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) >= (nint)customButtons._size)
			{
				break;
			}
			nint num = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v3 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v25 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool themeId = ((NotificationsObserver)_cachedBoard).DidAppStartFromNotificationAndroid(out reference);
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v9 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v21 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IAsyncResult result;
			if (BoardManager.IsThemeActive(_cachedBoard, themeId ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none))
			{
				nint num5 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18 (Il2CppClass<HoverboardThemes>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v25 (Il2CppClass<HoverboardThemes>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool themeId2 = ((NotificationsObserver)_cachedBoard).DidAppStartFromNotificationAndroid(out reference);
				nint num7 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v37 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v46 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				result = ((!BoardManager.HasThemeBeenSeen(_cachedBoard, themeId2 ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none)) ? ((IAsyncResult)1) : ((IAsyncResult)2));
			}
			else
			{
				nint num9 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v21 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v29 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				result = ((!BoardManager.HasAllThemesBeenSeen(_cachedBoard)) ? ((IAsyncResult)3) : null);
			}
			HoverboardThemeButton hoverboardThemeButton = _customButtons.get_Item((int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			((OnActivatedPrefab)(object)hoverboardThemeButton).EndInvoke(result);
			reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1);
		}
	}

	public UIHoverboardThemeShifter()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v16 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int currentlyShownHoverboardTheme = BoardManager.GetCurrentlyShownHoverboardTheme(_context);
		_cachedBoard = (Boards.BoardId)currentlyShownHoverboardTheme;
		_cachedThemeIndex = 0;
		ClickedTheme(0);
		ResetThemeSelection();
	}
}
