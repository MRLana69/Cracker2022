using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UI.Breadcrumbs;
using UI.Screens.NotEnoughCurrencyPopupInternal;
using UnityEngine;

namespace UI.Footer;

public class FooterButton : MonoBehaviour
{
	public class FooterPayload
	{
		public Action clicked;

		public string iconName;

		public ButtonColorScheme colorScheme;

		public int width;

		public string title;

		public Breadcrumb.BreadcrumbEvent[] breadcrumbEvents;

		public Vector3 iconOffset;
	}

	private UIWidget _baseWidget;

	private Collider _collider;

	private UISprite _fill;

	private UISprite _overlay;

	private UISprite _icon;

	private UILabel _title;

	private Breadcrumb _breadcrumb;

	private FooterPayload _payload;

	public void Init(FooterPayload payload)
	{
		//IL_0071: Expected I4, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = ((Dictionary<UiElementType, GameObject>)(nint)((UnityEngine.Object)this).m_CachedPtr).get_Item((UiElementType)payload);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)gameObject).FindKernel((string)null) != 0)
		{
			gameObject.tag = null;
		}
	}

	public unsafe void SetSelectedState(bool selected)
	{
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_040e: Expected Obj, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0433: Expected Obj, but got I4
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0012: Expected VT, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0051: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected VT, but got Unknown
		//IL_0491: Expected F4, but got Obj
		//IL_048c: Expected native int or pointer, but got VT
		//IL_04a3: Expected F4, but got I
		//IL_049e: Expected native int or pointer, but got VT
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected VT, but got Unknown
		//IL_04be: Expected F4, but got Obj
		//IL_04b9: Expected native int or pointer, but got VT
		//IL_04d3: Expected F4, but got I
		//IL_04ce: Expected native int or pointer, but got VT
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_04ff: Expected F4, but got Obj
		//IL_04fa: Expected native int or pointer, but got VT
		//IL_0514: Expected F4, but got I
		//IL_050f: Expected native int or pointer, but got VT
		//IL_051d: Expected Obj, but got VT
		//IL_053f: Expected I4, but got Obj
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00ee: Expected F4, but got Obj
		//IL_00e9: Expected native int or pointer, but got VT
		//IL_0103: Expected F4, but got I
		//IL_00fe: Expected native int or pointer, but got VT
		//IL_012a: Expected Obj, but got F4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0195: Expected F4, but got Obj
		//IL_0190: Expected native int or pointer, but got VT
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01bd: Expected F4, but got Obj
		//IL_01b8: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got I
		//IL_01cd: Expected native int or pointer, but got VT
		//IL_01e1: Expected I4, but got VT
		//IL_0092: Expected I, but got Obj
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_021f: Expected F4, but got Obj
		//IL_021a: Expected native int or pointer, but got VT
		//IL_0239: Expected F4, but got Obj
		//IL_0234: Expected native int or pointer, but got VT
		//IL_024e: Expected F4, but got I
		//IL_0249: Expected native int or pointer, but got VT
		//IL_025d: Expected I4, but got VT
		//IL_02d0: Expected I4, but got Obj
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_031f: Expected I, but got Obj
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_0574: Expected F4, but got I4
		//IL_03b7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 88;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = this + 40;
		obj3 = selected;
		UISprite icon = _icon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [selected @ L1 (System.Boolean)+C]");
		icon.fillCenter = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Transform transform = (Transform)(obj2 + 76);
		GameObject gameObject = _icon.gameObject;
		transform.localPosition = (Vector3)gameObject;
		object obj4 = obj2 + 60;
		object obj5 = (selected ? 1 : 0) + 60;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v76 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 120);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj2 + 152);
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v21+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj7 = obj2 + 48;
		Vector3 vector3 = vector - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v35+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector2).eulerAngles;
		FooterPayload payload = _payload;
		_title.fontSize = (int)payload.title;
		object obj8 = _payload + 16;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v47+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v47+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v47+18]");
		_ = 0;
		obj = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v29 (UnityEngine.Vector3)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v29 (UnityEngine.Vector3)+18]");
		_ = 0;
		object obj9 = obj2 + 40;
		object obj10 = obj + 24;
		obj9 = obj10;
		object obj11 = obj2 + 72;
		obj11 = obj9;
		((Vector3*)(nint)vector2)->x = (float)obj11;
		object obj12 = obj2 + 24;
		Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)vector2);
		((Vector3*)(nint)vector2)->x = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v71+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		_fill.rawPivot = (UIWidget.Pivot)vector2;
		object obj13 = obj2 + 16;
		obj13 = obj;
		object obj14 = obj2 + 44;
		obj14 = obj13;
		((Vector3*)(nint)vector2)->x = (float)obj14;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)vector2);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		_overlay.rawPivot = (UIWidget.Pivot)vector2;
		FooterPayload payload2 = _payload;
		_baseWidget.height = payload2.width;
		string self = _baseWidget.tag;
		GameObject.Internal_CreateGameObject((GameObject)(object)self, "UpdateAnchors");
		OnPress(pressed: false);
		FooterPayload payload3 = _payload;
		_breadcrumb.SetupNormalBreadcrumb((int)payload3.breadcrumbEvents);
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v62 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v72 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			return;
		}
		GameObject gameObject2 = base.gameObject;
		nint num5 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v100 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num6 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v107 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.OffsetLocalPosZ((Transform)(object)gameObject2, IPhoneXSupport.OFFSET_BOTTOM);
	}

	public unsafe void OnClick()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)((UnityEngine.Object)this).m_CachedPtr)->Current;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj7 = obj5 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj5 + obj9;
		obj10 = 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj5 + obj11;
			if ((nint)obj12 == 60)
			{
				object obj13 = obj5 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private unsafe void OnPress(bool pressed)
	{
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected VT, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0030: Expected F4, but got Obj
		//IL_002b: Expected native int or pointer, but got VT
		//IL_0045: Expected F4, but got I
		//IL_0040: Expected native int or pointer, but got VT
		//IL_005a: Expected F4, but got I
		//IL_0055: Expected native int or pointer, but got VT
		//IL_006f: Expected F4, but got I
		//IL_006a: Expected native int or pointer, but got VT
		//IL_007c: Expected Obj, but got F4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got F4
		//IL_016d: Expected F4, but got Obj
		//IL_0168: Expected native int or pointer, but got VT
		//IL_0187: Expected F4, but got Obj
		//IL_0182: Expected native int or pointer, but got VT
		//IL_019c: Expected F4, but got I
		//IL_0197: Expected native int or pointer, but got VT
		//IL_01ab: Expected I4, but got VT
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = (byte)((pressed ? 1u : 0u) ^ 1u) != 0;
		_collider.isTrigger = flag;
		string text = _overlay.tag;
		((GameObject)(object)text).tag = (string)flag;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 56);
		object obj4 = _payload + 16;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x2 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v16+8]");
		((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
		Matrix4x4 matrix4x3 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v16+10]");
		((Matrix4x4*)(nint)matrix4x3)->m01 = 0f;
		Matrix4x4 matrix4x4 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v16+18]");
		((Matrix4x4*)(nint)matrix4x4)->m21 = 0f;
		obj3 = matrix4x.m00;
		_ = matrix4x.m20;
		_ = matrix4x.m01;
		_ = matrix4x.m21;
		object obj5 = obj3 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v32+4]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj6 = obj3 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v39+4]");
		if ((nint)0 != 0)
		{
			if (pressed)
			{
				object obj7 = obj3 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8453");
			}
			else
			{
				object obj8 = obj3 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8453");
			}
			obj = matrix4x.m00;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
			Matrix4x4 matrix4x6 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x6)->m20 = 0f;
			_fill.rawPivot = (UIWidget.Pivot)matrix4x;
		}
	}

	public FooterButton()
	{
		FooterPayload payload = _payload;
		TransformExtensions.Reset((Transform)(object)payload.clicked);
	}
}
