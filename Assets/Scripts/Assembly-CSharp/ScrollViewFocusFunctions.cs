using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public static class ScrollViewFocusFunctions
{
	private sealed class _003CLerpToScrollPositionCoroutine_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ScrollRect scrollView;

		public Vector2 targetNormalizedPos;

		public float speed;

		private Vector2 _003CinitialNormalizedPos_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0088: Expected VT, but got I
			//IL_012b: Expected Obj, but got VT
			//IL_01a7: Expected Obj, but got I
			//IL_01db: Expected Obj, but got F4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected VT, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected VT, but got Unknown
			object obj2 = default;
			object obj = obj2 - 48;
			float num2 = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					float unscaledDeltaTime = Time.unscaledDeltaTime;
					float num = speed * unscaledDeltaTime;
					num2 = (_003Ct_003E5__3 += num);
					if (num2 < 1f)
					{
						goto IL_011a;
					}
					_ = targetNormalizedPos;
					_ = targetNormalizedPos;
					Vector2 normalizedPosition = (Vector2)(obj + 16);
					scrollView.normalizedPosition = normalizedPosition;
				}
				goto IL_0226;
			}
			_003C_003E1__state = -1;
			Vector2 normalizedPosition2 = scrollView.normalizedPosition;
			_003Ct_003E5__3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_003CinitialNormalizedPos_003E5__2 = (Vector2)0;
			goto IL_011a;
			IL_011a:
			object obj3 = targetNormalizedPos - _003CinitialNormalizedPos_003E5__2;
			float num3 = 1f - num2;
			float num4 = 1f - num2;
			float num5 = num3 * num4;
			float num6 = 1f - num5;
			float num7 = (float)obj3 * num6;
			float num8 = (float)_003CinitialNormalizedPos_003E5__2 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollViewFocusFunctions+<LerpToScrollPositionCoroutine>d__4)+18]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollViewFocusFunctions+<LerpToScrollPositionCoroutine>d__4)+24]");
			object obj4 = num9 - 0;
			float num10 = (float)obj4 * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollViewFocusFunctions+<LerpToScrollPositionCoroutine>d__4)+24]");
			float num11 = 0f + num10;
			object obj5 = num11 << 32;
			object obj6 = num8 | obj5;
			Vector2 normalizedPosition3 = (Vector2)(obj + 8);
			scrollView.normalizedPosition = normalizedPosition3;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_0226;
			IL_0226:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CFocusAtPointCoroutine_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ScrollRect scrollView;

		public Vector2 focusPoint;

		public float speed;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected VT, but got Unknown
			//IL_00a9: Expected F4, but got I
			//IL_00a4: Expected native int or pointer, but got VT
			object obj = default;
			Vector2 vector = (Vector2)(obj - 32);
			int num;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				if (!flag)
				{
					goto IL_00ee;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_ = focusPoint;
				_ = focusPoint;
				Vector2 vector2 = vector + 8;
				Vector2 vector3 = CalculateFocusedScrollPosition(scrollView, vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
				((Vector2*)(nint)vector)->x = 0f;
				IEnumerator enumerator = LerpToScrollPositionCoroutine(scrollView, vector, speed);
				_003C_003E2__current = enumerator;
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_00ee;
			IL_00ee:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CFocusOnItemCoroutine_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ScrollRect scrollView;

		public RectTransform item;

		public float speed;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_008f: Expected F4, but got I
			//IL_008a: Expected native int or pointer, but got VT
			object obj = default;
			Vector2 vector = (Vector2)(obj - 16);
			int num;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				if (!flag)
				{
					goto IL_00d4;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				Vector2 vector2 = CalculateFocusedScrollPosition(scrollView, item);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
				((Vector2*)(nint)vector)->x = 0f;
				IEnumerator enumerator = LerpToScrollPositionCoroutine(scrollView, vector, speed);
				_003C_003E2__current = enumerator;
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_00d4;
			IL_00d4:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public unsafe static Vector2 CalculateFocusedScrollPosition(ScrollRect scrollView, Vector2 focusPoint)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02bc: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_009f: Expected native int or pointer, but got VT
		//IL_00c8: Expected native int or pointer, but got VT
		//IL_00f0: Expected F4, but got Obj
		//IL_02fb: Expected F4, but got I
		//IL_0311: Expected native int or pointer, but got VT
		//IL_031e: Expected native int or pointer, but got VT
		//IL_011f: Expected F4, but got Obj
		//IL_01de: Expected F4, but got I
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		Rect rect = scrollView.m_Content.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		obj = 0;
		Transform parent = scrollView.m_Content.parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		RectTransform rectTransform = default;
		Rect rect2 = rectTransform.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		obj = 0;
		Vector3 localScale = scrollView.m_Content.localScale;
		object obj3 = obj * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		object obj4 = num * 0;
		float num2 = (((Vector2*)(nint)focusPoint)->x = focusPoint.x * (float)obj);
		float num3 = focusPoint.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num4 = (((Vector2*)(nint)focusPoint)->y = num3 * 0f);
		Vector2 normalizedPosition = scrollView.normalizedPosition;
		bool flag = (byte)(~(scrollView.m_Horizontal ? 1u : 0u)) != 0;
		float x = (float)obj;
		if (!flag)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			bool flag3 = !flag2;
			x = (float)obj;
			if (!flag3)
			{
				float num5 = (float)obj * 0.5f;
				float num6 = num2 - num5;
				object obj5 = obj3 - obj;
				float num7 = num6 / (float)obj5;
				bool flag4 = num7 < 0f;
				x = 0f;
				if (!flag4)
				{
					float num8 = Math.Min(num7, 1f);
					x = num8;
				}
			}
		}
		bool flag5 = (byte)(~(scrollView.m_Vertical ? 1u : 0u)) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float y = 0f;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			bool flag6 = 0 < (nint)obj4;
			bool flag7 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			y = 0f;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				float num9 = 0f * 0.5f;
				float num10 = num4 - num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				object obj6 = obj4 - 0;
				float num11 = num10 / (float)obj6;
				bool flag8 = num11 < 0f;
				y = 0f;
				if (!flag8)
				{
					float num12 = Math.Min(num11, 1f);
					y = num12;
				}
			}
		}
		Vector2 vector = default;
		((Vector2*)(nint)vector)->y = y;
		((Vector2*)(nint)vector)->x = x;
		return vector;
	}

	public unsafe static Vector2 CalculateFocusedScrollPosition(ScrollRect scrollView, RectTransform item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected VT, but got Unknown
		//IL_006a: Expected Ref, but got VT
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected VT, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_017d: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01af: Expected Obj, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01df: Expected F4, but got Obj
		//IL_01ec: Expected native int or pointer, but got VT
		//IL_021c: Expected F4, but got I
		//IL_0217: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 112);
		_ = 0;
		_ = 0;
		Transform transform = item.transform;
		Rect rect = item.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		_ = 0;
		Rect rect2 = (Rect)(vector + 96);
		Vector2 center = ((Rect*)rect2)->center;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		_ = 0;
		Vector3 position = (Vector3)(vector + 24);
		Vector3 vector2 = transform.TransformPoint(position);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		_ = 0;
		Vector3 position2 = (Vector3)(vector + 8);
		Vector3 vector3 = scrollView.m_Content.InverseTransformPoint(position2);
		Rect rect3 = scrollView.m_Content.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+68]");
		_ = 0;
		Vector2 pivot = scrollView.m_Content.pivot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		object obj2 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		object obj3 = 0 + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+54]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+54]");
		object obj4 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+54]");
		object obj5 = 0 + obj4;
		object obj6 = obj5 << 32;
		float x = obj3 | obj6;
		((Vector2*)(nint)vector)->x = x;
		Vector2 vector4 = CalculateFocusedScrollPosition(scrollView, vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+50]");
		Vector2 vector5 = default;
		((Vector2*)(nint)vector5)->x = 0f;
		return vector5;
	}

	public unsafe static void FocusAtPoint(ScrollRect scrollView, Vector2 focusPoint)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected VT, but got Unknown
		//IL_0056: Expected F4, but got I
		//IL_0051: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 32);
		_ = focusPoint.x;
		_ = focusPoint.x;
		Vector2 focusPoint2 = vector + 8;
		Vector2 vector2 = CalculateFocusedScrollPosition(scrollView, focusPoint2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
		((Vector2*)(nint)vector)->x = 0f;
		scrollView.normalizedPosition = vector;
	}

	public unsafe static void FocusOnItem(ScrollRect scrollView, RectTransform item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0034: Expected F4, but got I
		//IL_002f: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		Vector2 vector2 = CalculateFocusedScrollPosition(scrollView, item);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
		((Vector2*)(nint)vector)->x = 0f;
		scrollView.normalizedPosition = vector;
	}

	private static IEnumerator LerpToScrollPositionCoroutine(ScrollRect scrollView, Vector2 targetNormalizedPos, float speed)
	{
		_ = 0;
		_ = targetNormalizedPos.x;
		IEnumerator result = default;
		return result;
	}

	public static IEnumerator FocusAtPointCoroutine(ScrollRect scrollView, Vector2 focusPoint, float speed)
	{
		_ = 0;
		_ = focusPoint.x;
		IEnumerator result = default;
		return result;
	}

	public static IEnumerator FocusOnItemCoroutine(ScrollRect scrollView, RectTransform item, float speed)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
