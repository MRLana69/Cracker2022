using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListElementHelper : MonoBehaviour
{
	private UILabel _label;

	private Color _defaultColor;

	private Color _selectedColor;

	private ListContentElement _listContentElement;

	private ListContentElementReferences _references;

	private UIPanel _scrollViewPanel;

	private const int threshold = 50;

	public ListContentElement listContentElement
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopupInternal.ListElementHelper)+14]");
			return (ListContentElement)0;
		}
	}

	public void InitCell(ListContentElement lce, ListContentElementReferences references)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = lce;
		_label = (UILabel)(object)references;
	}

	private void Update()
	{
	}

	private unsafe void OnClick()
	{
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d2: Expected Obj, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01ef: Expected Obj, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected VT, but got Unknown
		//IL_021f: Expected F4, but got VT
		//IL_021a: Expected native int or pointer, but got VT
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0244: Expected VT, but got Obj
		//IL_0252: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02ed: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got F4
		//IL_0311: Expected Obj, but got F4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_034e: Expected I, but got Obj
		//IL_0364: Expected Obj, but got I
		//IL_03ab: Expected F4, but got Obj
		//IL_03a6: Expected native int or pointer, but got VT
		//IL_03c0: Expected F4, but got I
		//IL_03bb: Expected native int or pointer, but got VT
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03df: Expected VT, but got Obj
		//IL_040f: Expected F4, but got Obj
		//IL_040a: Expected native int or pointer, but got VT
		//IL_0424: Expected F4, but got I
		//IL_041f: Expected native int or pointer, but got VT
		//IL_0431: Expected Obj, but got VT
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0158: Expected F4, but got Obj
		//IL_0153: Expected native int or pointer, but got VT
		//IL_016d: Expected F4, but got I
		//IL_0168: Expected native int or pointer, but got VT
		//IL_0182: Expected I4, but got VT
		//IL_0182: Expected I4, but got Obj
		//IL_0182: Expected Ref, but got VT
		//IL_018f: Expected native int or pointer, but got VT
		//IL_01a1: Expected native int or pointer, but got VT
		//IL_01b5: Expected I4, but got VT
		//IL_0093: Expected I, but got Obj
		Matrix4x4 matrix4x = default;
		object obj = matrix4x + 96;
		obj = 0;
		_ = 0;
		object obj2 = matrix4x + 84;
		obj2 = 0;
		_ = 0;
		Vector3 vector = (Vector3)(matrix4x + 128);
		UIPanel scrollViewPanel = _scrollViewPanel;
		((Vector3*)(nint)vector)->x = (float)scrollViewPanel.mClipOffset;
		Transform transform = (Transform)(matrix4x + 112);
		GameObject gameObject = base.gameObject;
		transform.localPosition = (Vector3)gameObject;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v73 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (UnityEngine.Transform)+4]");
		float value = 0f - vector.y;
		float num3 = Math.Abs(value);
		float num5;
		if (num3 < 50f)
		{
			float num4 = num3 / 50f;
			num5 = 1f - num4;
		}
		else
		{
			num5 = 0f;
		}
		object obj4 = matrix4x + 72;
		obj4 = 0;
		_ = 0;
		obj4 = 1f;
		_ = 1f;
		_ = 1f;
		obj = 1.6f;
		_ = 1.6f;
		_ = 1.6f;
		object obj5 = matrix4x + 60;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v39 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v56 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v27+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v36+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj7 = matrix4x + 48;
		Vector3 vector3 = Vector3.LerpUnclamped((Vector3)transform, vector, num5);
		obj2 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v48+8]");
		_ = 0;
		GameObject gameObject2 = base.gameObject;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Transform)(object)gameObject2).parent = (Transform)vector;
		object obj8 = matrix4x + 32;
		object obj9 = this + 16;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S2_v13+8]");
		_ = 0;
		object obj10 = matrix4x + 16;
		object obj11 = this + 32;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S2_v19+8]");
		_ = 0;
		transform = (Transform)obj8;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v58+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v61+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		((Matrix4x4*)matrix4x)->set_Item((int)transform, (int)vector, num5);
		((Vector3*)(nint)vector)->x = matrix4x.m00;
		((Vector3*)(nint)vector)->z = matrix4x.m20;
		_label.rawPivot = (UIWidget.Pivot)vector;
	}

	public ListElementHelper()
	{
		GameObject gameObject = base.gameObject;
		Vector2 vector = ((CoinBoxSizer)(object)gameObject).CalculateDistanceToBounds((UIWidget)null);
	}
}
