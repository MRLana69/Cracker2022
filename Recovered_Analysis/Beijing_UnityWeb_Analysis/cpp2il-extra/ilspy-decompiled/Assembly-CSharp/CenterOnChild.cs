using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.U2D;

public class CenterOnChild : MonoBehaviour
{
	private Action m_selectedObjectChanged;

	private Action m_selectedObjectReselected;

	private UIScrollView mDrag;

	private GameObject _centeredObject;

	private GameObject _selectedObject;

	[NonSerialized]
	public bool characterWasClicked = false;

	public GameObject selectedObject
	{
		get
		{
			//IL_0017: Expected Obj, but got I4
			string text = tag;
			return (GameObject)((GameObject)(object)text).activeInHierarchy;
		}
		private set
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_selectedObjectReselected;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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

	public event Action selectedObjectChanged
	{
		add
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_00bf: Expected Obj, but got I4
			//IL_00ce: Expected Obj, but got F4
			//IL_010d: Expected Obj, but got I4
			//IL_011c: Expected Obj, but got F4
			//IL_0042: Expected Obj, but got I4
			//IL_0051: Expected Obj, but got F4
			//IL_0090: Expected Obj, but got I4
			//IL_009f: Expected Obj, but got F4
			object obj = default;
			Transform transform = (Transform)(obj + 32);
			object obj2 = obj + 16;
			if (value != null)
			{
				obj2 = 0;
				_ = 0;
				obj2 = 0f;
				_ = 100f;
				_ = 0f;
				transform = (Transform)obj2;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
				obj = 0;
				_ = 0;
				obj = 0f;
				_ = 0f;
				_ = 180f;
				_ = 0f;
			}
			else
			{
				obj2 = 0;
				_ = 0;
				obj2 = 0f;
				_ = -20f;
				_ = 0f;
				transform = (Transform)obj2;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles2 = transform.eulerAngles;
				obj = 0;
				_ = 0;
				obj = 0f;
				_ = 0f;
				_ = 0f;
				_ = 0f;
			}
			transform = (Transform)obj;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_selectedObjectChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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

	public event Action selectedObjectReselected
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_selectedObjectChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_selectedObjectReselected;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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

	public void ClearCenterObject()
	{
		CancelInvoke();
	}

	private void OnEnable()
	{
		((CoinBoxSizer)this).updateAutomatically = false;
	}

	private void OnDragFinished()
	{
		CharacterFocusedFromClick();
	}

	private void OnSpringFinished()
	{
		if (isActiveAndEnabled)
		{
			CharacterFocusedFromClick();
		}
	}

	public void Recenter()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = _selectedObject;
	}

	public void CenterOnTransform(Transform target, bool instant = false)
	{
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I4
		//IL_0276: Expected I, but got Obj
		//IL_028c: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got F4
		//IL_00f0: Expected I, but got Obj
		//IL_013d: Expected I, but got Obj
		//IL_0153: Expected Obj, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_017e: Expected I, but got Obj
		//IL_01cb: Expected I, but got Obj
		//IL_01e1: Expected Obj, but got I
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_020c: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v83 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		float num3 = (float)(instant ? 1 : 0) * (float)Math.PI;
		float num4 = num3 * 2f;
		float num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+10]");
		float num6 = num5 / 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+18]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+18]");
				if ((nint)0 == 2)
				{
					nint num7 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v66 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v79 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+20]");
					object obj6 = default;
					object obj5 = obj6 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+20]");
					object obj8 = default;
					object obj7 = obj8 * 0;
					obj = obj5;
					_ = 0f;
				}
			}
			else
			{
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v48 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num10 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v61 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+20]");
				object obj11 = default;
				object obj10 = obj11 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+20]");
				object obj13 = default;
				object obj12 = obj13 * 0;
				obj = obj10;
				_ = 0f;
			}
		}
		else
		{
			nint num11 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num12 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v43 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+20]");
			object obj16 = default;
			object obj15 = obj16 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L1 (UnityEngine.Transform)+20]");
			object obj18 = default;
			object obj17 = obj18 * 0;
			obj = 0f;
		}
		CenterOnChild centerOnChild = (CenterOnChild)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
	}

	public bool CenterOnClosestChildAtPosition(Vector2 clickPositionOnScreen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got VT
		//IL_0077: Expected Obj, but got I4
		//IL_0080: Invalid comparison between VT and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0058: Expected I4, but got Obj
		//IL_0064: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = clickPositionOnScreen;
		obj2 = 0;
		if (clickPositionOnScreen < (object)10000)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			bool result = default;
			return result;
		}
		object obj3 = clickPositionOnScreen / 1000;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string[] values = default;
		string text = string.ConcatArray(values, (int)"K");
		return (byte)(int)text != 0;
	}

	public unsafe void CharacterFocusedFromClick()
	{
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_080b: Expected Obj, but got I4
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_0828: Expected Obj, but got I4
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0845: Expected Obj, but got I4
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		//IL_0862: Expected Obj, but got I4
		//IL_0876: Expected I, but got Obj
		//IL_088c: Expected Obj, but got I
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected VT, but got Unknown
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Expected VT, but got Unknown
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected Obj, but got Unknown
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected Obj, but got Unknown
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Expected Obj, but got Unknown
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected Obj, but got Unknown
		//IL_0e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Expected Obj, but got Unknown
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected Obj, but got Unknown
		//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected Obj, but got Unknown
		//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e44: Expected Obj, but got Unknown
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_01e9: Expected I, but got Obj
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_08d7: Expected I, but got Obj
		//IL_08ed: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0284: Expected VT, but got Obj
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_00f8: Expected I, but got Obj
		//IL_0327: Expected F4, but got Obj
		//IL_0322: Expected native int or pointer, but got VT
		//IL_033c: Expected F4, but got I
		//IL_0337: Expected native int or pointer, but got VT
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_03b4: Expected I, but got Obj
		//IL_03ca: Expected Obj, but got I
		//IL_098d: Expected F4, but got Obj
		//IL_0988: Expected native int or pointer, but got VT
		//IL_09a2: Expected F4, but got I
		//IL_099d: Expected native int or pointer, but got VT
		//IL_09d5: Expected F4, but got Obj
		//IL_09d0: Expected native int or pointer, but got VT
		//IL_09ea: Expected F4, but got I
		//IL_09e5: Expected native int or pointer, but got VT
		//IL_09f7: Expected F4, but got Obj
		//IL_09f2: Expected native int or pointer, but got VT
		//IL_0a0c: Expected F4, but got I
		//IL_0a07: Expected native int or pointer, but got VT
		//IL_0441: Expected native int or pointer, but got VT
		//IL_0453: Expected native int or pointer, but got VT
		//IL_0467: Expected I4, but got VT
		//IL_03f5: Expected I, but got Obj
		//IL_0591: Expected I, but got Obj
		//IL_05a7: Expected Obj, but got I
		//IL_04b9: Expected VT, but got I4
		//IL_0638: Expected I4, but got Obj
		//IL_05d2: Expected I, but got Obj
		//IL_04e9: Expected I, but got Obj
		//IL_04ff: Expected Obj, but got I
		//IL_064a: Expected VT, but got Obj
		//IL_0657: Expected F4, but got Obj
		//IL_0652: Expected native int or pointer, but got VT
		//IL_0669: Expected F4, but got I
		//IL_0664: Expected native int or pointer, but got VT
		//IL_067a: Expected Ref, but got VT
		//IL_0a4d: Expected F4, but got Obj
		//IL_0a48: Expected native int or pointer, but got VT
		//IL_0a5f: Expected F4, but got I
		//IL_0a5a: Expected native int or pointer, but got VT
		//IL_0a6c: Expected F4, but got Obj
		//IL_0a67: Expected native int or pointer, but got VT
		//IL_0a7e: Expected F4, but got I
		//IL_0a79: Expected native int or pointer, but got VT
		//IL_0a9c: Expected F4, but got Obj
		//IL_0a97: Expected native int or pointer, but got VT
		//IL_0aae: Expected F4, but got I
		//IL_0aa9: Expected native int or pointer, but got VT
		//IL_0b38: Expected I4, but got Obj
		//IL_068c: Expected F4, but got Obj
		//IL_0687: Expected native int or pointer, but got VT
		//IL_06a1: Expected F4, but got I
		//IL_069c: Expected native int or pointer, but got VT
		//IL_06b2: Expected Ref, but got VT
		//IL_06d2: Expected I, but got Obj
		//IL_06e8: Expected Obj, but got I
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected Obj, but got Unknown
		//IL_052a: Expected I, but got Obj
		//IL_0bd7: Expected F4, but got Obj
		//IL_0bd2: Expected native int or pointer, but got VT
		//IL_0be9: Expected F4, but got I
		//IL_0be4: Expected native int or pointer, but got VT
		//IL_0bf6: Expected F4, but got Obj
		//IL_0bf1: Expected native int or pointer, but got VT
		//IL_0c0b: Expected F4, but got I
		//IL_0c06: Expected native int or pointer, but got VT
		//IL_0e7d: Expected Obj, but got I4
		//IL_0713: Expected I, but got Obj
		//IL_0cb9: Expected VT, but got Obj
		//IL_0ce4: Expected I, but got Obj
		//IL_0cfa: Expected Obj, but got I
		//IL_075b: Expected Obj, but got F4
		//IL_0d24: Expected F4, but got Obj
		//IL_0d1f: Expected native int or pointer, but got VT
		//IL_0d36: Expected F4, but got I
		//IL_0d31: Expected native int or pointer, but got VT
		//IL_0d43: Expected F4, but got Obj
		//IL_0d3e: Expected native int or pointer, but got VT
		//IL_0d55: Expected F4, but got I
		//IL_0d50: Expected native int or pointer, but got VT
		//IL_0d73: Expected F4, but got Obj
		//IL_0d6e: Expected native int or pointer, but got VT
		//IL_0d85: Expected F4, but got I
		//IL_0d80: Expected native int or pointer, but got VT
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_0779: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 168;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 152;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 140;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 128;
		obj5 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v232 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 208);
		Vector3 vector2 = (Vector3)(obj2 + 196);
		Transform transform = (Transform)(obj2 + 112);
		Transform transform2 = (Transform)(obj2 + 96);
		Transform transform3 = (Transform)(obj2 + 80);
		object obj7 = obj2 - -64;
		object obj8 = obj2 + 48;
		object obj9 = obj2 + 36;
		object obj10 = obj2 + 24;
		object obj11 = obj2 + 12;
		object obj12 = obj2 + 184;
		if (mDrag != null)
		{
			string go = tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v215 (Il2CppClass<NGUITools>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v228 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj14 = this + 20;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>((GameObject)(object)go);
			obj14 = uIScrollView;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v225 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v239 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mDrag != null)
			{
				tag = null;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			object obj17 = default;
			object obj16 = obj17 + 16;
			obj16 = this;
			object obj18 = mDrag + 68;
			obj18 = obj17;
		}
		UIScrollView uIScrollView2 = mDrag;
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v215 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uIScrollView2.mPanel != null)
		{
			return;
		}
		UIScrollView uIScrollView3 = mDrag;
		Vector2 clipSoftness = uIScrollView3.mPanel.clipSoftness;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		UIScrollView uIScrollView4 = mDrag;
		Camera anchorCamera = uIScrollView4.mPanel.anchorCamera;
		transform2.localPosition = (Vector3)anchorCamera;
		obj3 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		transform3 = (Transform)obj;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj20 = obj3 + (object)transform3;
		obj3 = obj20;
		object obj21 = obj3 + 4;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38+4]");
		object obj23 = obj22 + 0;
		obj21 = obj23;
		Transform parentInternal = ((Transform)(object)anchorCamera).parentInternal;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = parentInternal.InverseTransformPoint(vector);
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v40+8]");
		_ = 0;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v40+8]");
		_ = 0;
		object obj24 = mDrag + 140;
		obj10 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v80+8]");
		_ = 0;
		UIScrollView uIScrollView5 = mDrag;
		nint num10 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v92 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v208 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v44+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj12;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v48+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		float num12 = uIScrollView5.momentumAmount * 0.1f;
		Vector3 vector6 = vector / num12;
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector7 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj11;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v46+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector3 one = Vector3.one;
		((Vector3*)(nint)vector)->x = vector2.x;
		((Vector3*)(nint)vector)->z = vector2.z;
		mDrag.UpdateScrollbars((byte)(int)vector != 0);
		GameObject gameObject = base.gameObject;
		int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
		float num13 = float.MaxValue;
		Sprite sprite = null;
		ComputeShader computeShader = null;
		while ((nint)sprite < siblingIndex)
		{
			bool flag = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite);
			transform.position = (Vector3)flag;
			transform2 = (Transform)obj4;
			Transform transform5 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			nint num14 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v180 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num15 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v204 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)transform2;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			Quaternion quaternion2 = Quaternion.FromToRotation(vector2, vector);
			((Vector3*)(nint)vector)->x = (float)transform3;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			float num16 = vector.x * vector.x;
			float num17 = vector.y * vector.y;
			float num18 = num16 + num17;
			float num19 = vector.z * vector.z;
			float num20 = num18 + num19;
			bool flag2 = num20 < num13;
			bool flag3 = !flag2;
			bool flag4 = (byte)(int)computeShader != 0;
			if (!flag3)
			{
				flag4 = flag;
			}
			Sprite sprite2 = (Sprite)(sprite + 1);
			if (flag2)
			{
				num13 = num20;
			}
			sprite = sprite2;
			computeShader = (ComputeShader)flag4;
		}
		nint num21 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S0_v120 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v172 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) == 0)
		{
			((CoinBoxSizer)this).updateAutomatically = false;
			return;
		}
		string text = ((Component)(object)computeShader).tag;
		((CoinBoxSizer)this).updateAutomatically = (byte)(int)text != 0;
		transform.position = (Vector3)computeShader;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		transform2.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)vector);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector9 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		transform3.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)vector);
		obj7 = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		nint num23 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S0_v138 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num24 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S0_v167 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform2;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		Quaternion quaternion3 = Quaternion.FromToRotation(vector2, vector);
		obj5 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v40+8]");
		_ = 0;
		if (!mDrag.canMoveVertically)
		{
			obj5 = 0f;
		}
		if (!mDrag.shouldMoveHorizontally)
		{
			_ = 0f;
		}
		_ = 0f;
		string go2 = mDrag.tag;
		transform.localPosition = (Vector3)anchorCamera;
		transform2 = (Transform)obj5;
		Transform transform6 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		nint num25 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ S1_v158 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num26 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ S1_v178 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Quaternion quaternion4 = Quaternion.FromToRotation(vector2, vector);
		((Vector3*)(nint)vector)->x = (float)transform3;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
		SpringPosition springPosition = SpringPosition.Begin((GameObject)(object)go2, vector, 8f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num27 = 0;
		_ = 0;
		object obj31 = default;
		object obj30 = obj31 + 16;
		obj30 = this;
		object obj32 = springPosition + 28;
		obj32 = obj31;
	}
}
