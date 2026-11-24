using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Generic.Layout;

public class VerticalLayout : Layout
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public UILabel l;

		public _003C_003Ec__DisplayClass1_0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0027: Expected I4, but got Obj
			//IL_0027: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Generic.Layout.VerticalLayout+<>c__DisplayClass1_0)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+8]");
			((UIWidget)0).height = (int)l;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1_1
	{
		public int maxHeight;

		public _003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals1;

		internal void _003CAlign_Internal_003Eb__0()
		{
		}
	}

	public VerticalAlignment alignment;

	protected override void Align_Internal()
	{
		adjustWidgetPosition = true;
		CancelInvoke();
	}

	public unsafe VerticalLayout()
	{
		//IL_07d0: Expected Obj, but got I4
		//IL_07e4: Expected I, but got Obj
		//IL_07fa: Expected Obj, but got I
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_084f: Expected I, but got Obj
		//IL_0865: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0110: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_0414: Expected F4, but got Obj
		//IL_0437: Expected F4, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_0237: Expected Obj, but got I
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected Obj, but got Unknown
		//IL_046d: Expected F4, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_029a: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I
		//IL_08ee: Expected I, but got Obj
		//IL_0904: Expected Obj, but got I
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_04de: Expected I, but got Obj
		//IL_0329: Expected F4, but got I
		//IL_0336: Expected Obj, but got I4
		//IL_052b: Expected I, but got Obj
		//IL_0541: Expected Obj, but got I
		//IL_056c: Expected I, but got Obj
		//IL_05d9: Expected VT, but got Obj
		//IL_0600: Expected Obj, but got I4
		//IL_070b: Expected I, but got Obj
		//IL_0721: Expected Obj, but got I
		//IL_074c: Expected I, but got Obj
		//IL_0666: Expected I, but got Obj
		//IL_067c: Expected Obj, but got I
		//IL_06a7: Expected I, but got Obj
		object obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v140 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj + 12);
		if (this != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v134 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_panel != null)
		{
			object obj4 = this + 44;
			UIPanel componentInParent = GetComponentInParent<UIPanel>();
			obj4 = componentInParent;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v127 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_panel).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		_calculatedHeight = 0f;
		Transform t;
		if (~(_snapToLabelContent ? 1u : 0u) == 0)
		{
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v38 (Il2CppMethodInfo)+18]");
			object obj6 = 0;
			object obj7 = obj6;
			object obj8 = obj7 & 0x1FFF;
			object obj9 = obj8 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v191 @ S3_v10 (should have been resolved before IL gen)");
			object obj11 = default;
			object obj10 = obj11 + 12;
			Delegate obj12 = null;
			object obj13 = default;
			object obj15 = default;
			object obj21 = default;
			Delegate obj25 = default;
			Delegate obj28 = default;
			object obj29 = default;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
				t = (Transform)(object)obj12;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj14 = obj15 + 8;
				object obj16 = obj11 + 16;
				object obj17 = obj13 << 2;
				object obj18 = obj16 + obj17;
				obj14 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v106+8]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v109+164]");
				if ((nint)0 != 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj20 = obj21 + 12;
					obj20 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v117+C]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v105+8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v106+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v117+C]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S1_v109+8]");
					Vector2 localSize = ((UILabel)0).localSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (UnityEngine.Transform)+4]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v117+8]");
					if (num8 < 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (UnityEngine.Transform)+4]");
						int num9 = NumberExtensions.FloorToInt(0f);
						Color color = ((UIWidget)num9).color;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					obj25.method_ptr = method_ptr;
					obj25.method = (nint)__ldftn(_003C_003Ec__DisplayClass1_1._003CAlign_Internal_003Eb__0);
					object obj26 = obj25 + 16;
					obj26 = obj21;
					Delegate obj27 = obj12.CombineImpl(obj25);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
					obj12 = obj28;
				}
				obj13 = obj29 + 1;
			}
		}
		else
		{
			t = null;
		}
		if (alignment != VerticalAlignment.Center)
		{
			if (alignment != VerticalAlignment.Up)
			{
				if (alignment == VerticalAlignment.Down)
				{
					GameObject gameObject = base.gameObject;
					float sizeDeltaToProduceSize = ((AspectRatioFitter)(object)gameObject).GetSizeDeltaToProduceSize((float)padding, 1);
					_calculatedHeight = sizeDeltaToProduceSize;
				}
			}
			else
			{
				GameObject gameObject2 = base.gameObject;
				float sizeDeltaToProduceSize2 = ((AspectRatioFitter)(object)gameObject2).GetSizeDeltaToProduceSize((float)padding, 0);
				_calculatedHeight = sizeDeltaToProduceSize2;
			}
		}
		else
		{
			GameObject gameObject3 = base.gameObject;
			ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
			_calculatedHeight = (float)ex;
		}
		TransformExtensions.Reset(t);
		if (~(autosizeWidget ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag2 = (object)targetWidget == null;
		bool flag3 = !flag2;
		UIWidget uIWidget = targetWidget;
		if (!flag3)
		{
			UIWidget component = GetComponent<UIWidget>();
			uIWidget = component;
		}
		nint num10 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v87 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIWidget).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num12 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v58 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num13 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v83 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num14 = _calculatedHeight + autosizeWidgetMargin;
		if (!(num14 > autosizeWidgetMinWidth))
		{
			num14 = autosizeWidgetMinWidth;
		}
		_calculatedHeight = num14;
		GUILayoutOption gUILayoutOption = GUILayout.Width(_calculatedHeight);
		Color color2 = ((UIWidget)(object)gUILayoutOption).color;
		if (~(adjustWidgetPosition ? 1u : 0u) != 0)
		{
			return;
		}
		GameObject gameObject4 = uIWidget.gameObject;
		transform.localPosition = (Vector3)gameObject4;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj32 = alignment - 1;
		if (alignment != VerticalAlignment.Up)
		{
			if ((nint)obj32 == 1)
			{
				float num15 = _calculatedHeight * -0.5f;
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num17 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag4 = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)targetWidget);
			}
		}
		else
		{
			float num18 = _calculatedHeight * 0.5f;
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag5 = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)targetWidget);
		}
		GameObject gameObject5 = uIWidget.gameObject;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}
}
