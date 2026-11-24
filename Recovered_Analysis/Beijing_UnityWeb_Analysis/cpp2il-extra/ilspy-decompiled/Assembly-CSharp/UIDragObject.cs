using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InAppPurchase;
using UnityEngine;
using UnityEngine.UI;

public class UIDragObject : MonoBehaviour
{
	public enum DragEffect
	{
		None,
		Momentum,
		MomentumAndSpring
	}

	public Transform target;

	public UIPanel panelRegion;

	public Vector3 scrollMomentum;

	public bool restrictWithinPanel;

	public UIRect contentRect;

	public DragEffect dragEffect;

	public float momentumAmount;

	protected Vector3 scale;

	private float scrollWheelFactor;

	private Plane mPlane;

	private Vector3 mTargetPos;

	private Vector3 mLastPos;

	private Vector3 mMomentum;

	private Vector3 mScroll;

	private Bounds mBounds;

	private int mTouchID;

	private bool mStarted;

	private bool mPressed;

	public unsafe Vector3 dragMovement
	{
		get
		{
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Expected VT, but got Unknown
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0434: Expected VT, but got Unknown
			//IL_043d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0442: Expected Obj, but got Unknown
			//IL_044b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0450: Expected Obj, but got Unknown
			//IL_0459: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Expected Obj, but got Unknown
			//IL_0467: Unknown result type (might be due to invalid IL or missing references)
			//IL_046c: Expected Obj, but got Unknown
			//IL_0475: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Expected Obj, but got Unknown
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Expected Obj, but got Unknown
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Expected Obj, but got Unknown
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a4: Expected Obj, but got Unknown
			//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b2: Expected Obj, but got Unknown
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c0: Expected Obj, but got Unknown
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Expected Obj, but got Unknown
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dc: Expected Obj, but got Unknown
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Expected Obj, but got Unknown
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Expected Obj, but got Unknown
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_0506: Expected Obj, but got Unknown
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Expected Obj, but got Unknown
			//IL_051d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Expected Obj, but got Unknown
			//IL_052b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Expected Obj, but got Unknown
			//IL_0034: Expected I, but got Obj
			//IL_004a: Expected Obj, but got I
			//IL_057f: Expected I, but got Obj
			//IL_0595: Expected Obj, but got I
			//IL_074e: Expected Obj, but got I
			//IL_0766: Expected I, but got Obj
			//IL_0075: Expected I, but got Obj
			//IL_05c2: Expected Obj, but got I
			//IL_05d0: Expected I, but got Obj
			//IL_05e6: Expected Obj, but got I
			//IL_00c2: Expected I, but got Obj
			//IL_0789: Expected F4, but got Obj
			//IL_0784: Expected native int or pointer, but got VT
			//IL_079e: Expected Obj, but got I
			//IL_07ab: Expected F4, but got Obj
			//IL_07a6: Expected native int or pointer, but got VT
			//IL_07b8: Expected F4, but got Obj
			//IL_07b3: Expected native int or pointer, but got VT
			//IL_07de: Expected VT, but got I
			//IL_0112: Expected Obj, but got I
			//IL_0124: Expected I, but got Obj
			//IL_013a: Expected Obj, but got I
			//IL_0206: Expected F4, but got Obj
			//IL_0201: Expected native int or pointer, but got VT
			//IL_0221: Expected I, but got Obj
			//IL_0237: Expected Obj, but got I
			//IL_01b2: Expected I, but got Obj
			//IL_0615: Expected F4, but got Obj
			//IL_0610: Expected native int or pointer, but got VT
			//IL_0633: Expected Obj, but got F4
			//IL_0640: Expected I, but got F4
			//IL_0652: Expected F4, but got Obj
			//IL_064d: Expected native int or pointer, but got VT
			//IL_0669: Expected F4, but got Obj
			//IL_0664: Expected native int or pointer, but got VT
			//IL_0694: Expected F4, but got Obj
			//IL_068f: Expected native int or pointer, but got VT
			//IL_06aa: Expected Obj, but got VT
			//IL_06be: Expected Obj, but got I
			//IL_06ce: Expected Obj, but got I
			//IL_06e3: Expected F4, but got Obj
			//IL_06de: Expected native int or pointer, but got VT
			//IL_0165: Expected I, but got Obj
			//IL_02b6: Expected F4, but got Obj
			//IL_02b1: Expected native int or pointer, but got VT
			//IL_02c3: Expected F4, but got Obj
			//IL_02be: Expected native int or pointer, but got VT
			//IL_02e9: Expected F4, but got Obj
			//IL_02e4: Expected native int or pointer, but got VT
			//IL_02f6: Expected F4, but got Obj
			//IL_02f1: Expected native int or pointer, but got VT
			//IL_030c: Expected I4, but got VT
			//IL_030c: Expected Obj, but got VT
			//IL_0262: Expected I, but got Obj
			//IL_031e: Expected F4, but got Obj
			//IL_0319: Expected native int or pointer, but got VT
			//IL_0369: Expected Obj, but got VT
			//IL_0398: Expected I, but got Obj
			//IL_03ae: Expected Obj, but got I
			//IL_0727: Expected F4, but got Obj
			//IL_0722: Expected native int or pointer, but got VT
			//IL_03d9: Expected I, but got Obj
			object obj = default;
			Vector2 vector = (Vector2)(obj + 180);
			Vector2 vector2 = (Vector2)(obj + 120);
			object obj2 = obj + 136;
			object obj3 = obj - -64;
			object obj4 = obj + 112;
			object obj5 = obj + 40;
			object obj6 = obj + 104;
			object obj7 = obj + 96;
			Transform transform = (Transform)(obj + 168);
			object obj8 = obj + 156;
			object obj9 = obj + 88;
			object obj10 = obj + 144;
			object obj11 = obj + 8;
			object obj12 = obj + 80;
			object obj13 = obj + 72;
			object obj14 = obj + 56;
			object obj15 = obj + 48;
			object obj16 = obj + 32;
			LayoutGroup layoutGroup = (LayoutGroup)(obj + 24);
			object obj17 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+5C]");
				if ((nint)0 == 0)
				{
					_ = 1;
					goto IL_0555;
				}
			}
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v55 (Il2CppClass<UICamera>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v157 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			currentTouch.clickNotification = UICamera.ClickNotification.BasedOnDelta;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v113 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+58]");
			int num5 = ((ComputeShader)0).FindKernel(null);
			bool flag = num5 == 0;
			nint num6 = (nint)this;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+58]");
				float pixelSizeAdjustment = UIRoot.GetPixelSizeAdjustment((GameObject)0);
				nint num7 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v145 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num8 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v153 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = this;
				((Vector2*)(nint)vector)->x = (float)obj2;
				Vector2 vector3 = vector / pixelSizeAdjustment;
				UIDragObject uIDragObject = (UIDragObject)vector2.x;
				num6 = (nint)vector2.x;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+10]");
			obj3 = 0;
			nint num9 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v68 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num10 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v137 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = obj3;
			((Vector2*)(nint)vector)->x = (float)obj4;
			Vector2 vector4 = (Vector3)vector;
			obj6 = num6;
			((Vector2*)(nint)vector2)->x = (float)obj6;
			((Vector2*)(nint)vector)->x = (float)obj7;
			Vector2 vector5 = vector2 + vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+2C]");
			transform.localPosition = (Vector3)0;
			obj9 = obj5;
			((Vector2*)(nint)vector)->x = (float)obj9;
			Vector3 vector6 = (Vector4)vector;
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v86 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v133 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector2*)(nint)vector2)->x = (float)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			((Vector2*)(nint)vector)->x = (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
			_ = 0;
			Vector3 vector7 = (Vector3)vector2 - (Vector3)vector;
			((Vector2*)(nint)vector)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			_ = 0;
			Vector3 eulerAngles = ((Transform)vector).eulerAngles;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+34]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+34]");
			obj = 0;
			obj12 = obj5;
			((Vector2*)(nint)vector)->x = (float)obj12;
			float num13 = 0.01f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+24]");
			float num14 = num13 * 0f;
			Vector2 vector8 = vector / num14;
			obj13 = obj;
			((Vector2*)(nint)vector2)->x = (float)obj13;
			((Vector2*)(nint)vector)->x = (float)obj14;
			Vector2 vector9 = vector2 - vector;
			obj15 = obj11;
			((Vector2*)(nint)vector2)->x = (float)obj15;
			((Vector2*)(nint)vector)->x = (float)obj16;
			layoutGroup.SetChildAlongAxis((RectTransform)vector2, (int)vector, 0.67f);
			((Vector2*)(nint)vector)->x = (float)layoutGroup;
			_ = vector.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+1C]");
			Vector3 vector10 = default;
			if ((nint)0 != 2)
			{
				Transform child = ((UIGrid)vector10).GetChild(1);
				if ((object)child != null)
				{
					nint num15 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v121 (Il2CppClass<UnityEngine.Vector2>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num16 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v129 (Il2CppClass<UnityEngine.Vector2>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector2 one = Vector2.one;
					((Vector2*)(nint)vector)->x = (float)obj17;
					_ = vector.x;
					_ = 0f;
				}
			}
			goto IL_0555;
			IL_0555:
			return vector10;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 48;
			UIDragObject uIDragObject = (UIDragObject)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	private void OnEnable()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v26 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		Vector2 up = Vector2.up;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		panelRegion = (UIPanel)obj4;
		_ = 2;
		restrictWithinPanel = true;
		contentRect = (UIRect)35f;
		Vector2 one = Vector2.one;
		obj4 = obj3;
		CancelInvoke();
	}

	private unsafe void OnDisable()
	{
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected VT, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got I4
		//IL_0581: Expected I, but got Obj
		//IL_0597: Expected Obj, but got I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_04da: Expected I, but got Obj
		//IL_04f0: Expected Obj, but got I
		//IL_00c1: Expected I, but got Obj
		//IL_0427: Expected F4, but got Obj
		//IL_0422: Expected native int or pointer, but got VT
		//IL_043c: Expected F4, but got I
		//IL_0437: Expected native int or pointer, but got VT
		//IL_045c: Expected F4, but got Obj
		//IL_0457: Expected native int or pointer, but got VT
		//IL_0471: Expected F4, but got I
		//IL_046c: Expected native int or pointer, but got VT
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0489: Expected Obj, but got F4
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_0074: Expected I, but got Obj
		//IL_02d8: Expected I, but got Obj
		//IL_02ee: Expected Obj, but got I
		//IL_0277: Expected I, but got Obj
		//IL_02c5: Expected VT, but got Obj
		//IL_02c5: Expected Obj, but got VT
		//IL_014f: Expected I, but got Obj
		//IL_0365: Expected Obj, but got F4
		//IL_037c: Expected F4, but got Obj
		//IL_0377: Expected native int or pointer, but got VT
		//IL_0391: Expected F4, but got I
		//IL_038c: Expected native int or pointer, but got VT
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a9: Expected Obj, but got F4
		//IL_0319: Expected I, but got Obj
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_0212: Expected I, but got Obj
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + 36);
		object obj2 = obj + 12;
		object obj3 = obj + 24;
		obj3 = 0;
		_ = 0;
		if (scrollWheelFactor != 0f)
		{
			object obj4 = this + 48;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v66+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v72 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v85 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = vector / scrollWheelFactor;
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			object obj6 = this + 20;
			obj6 = vector.x;
			_ = vector.z;
			scrollWheelFactor = 0f;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (contentRect != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)target).FindKernel((string)null) != 0 && Application.platform != RuntimePlatform.OSXEditor)
			{
				UIWidget component = target.GetComponent<UIWidget>();
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					object obj10 = this + 36;
					obj10 = component;
				}
			}
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			((Transform)vector).position = (Vector3)target;
		}
		else
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v36 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
		}
		obj3 = vector.x;
		_ = vector.z;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj13 = this + 80;
		obj13 = vector.x;
		_ = vector.z;
	}

	private void FindPanel()
	{
		mStarted = false;
	}

	private void UpdateBounds()
	{
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I4
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_011d: Expected I, but got Obj
		//IL_00c2: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 16;
		UIRoot.Constraint constraint;
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			GameObject gameObject = target.gameObject;
			Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
			nint num3 = (nint)typeof(UIPanel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v8 (Il2CppClass<UIPanel>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UIPanel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v13 (Il2CppClass<UIPanel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			constraint = ((UIRoot)(object)parentInternal).constraint;
		}
		else
		{
			constraint = UIRoot.Constraint.Fit;
		}
		obj2 = constraint;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (panelRegion != null)
		{
			restrictWithinPanel = false;
		}
	}

	private unsafe void OnPress(bool pressed)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		object obj = ((bool*)(pressed ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pressed @ L1 (System.Boolean)+8]");
		_ = 0;
		object obj2 = this + 48;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}

	private unsafe void OnDrag(Vector2 delta)
	{
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_076f: Expected Obj, but got I4
		//IL_0783: Expected I, but got Obj
		//IL_0799: Expected Obj, but got I
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected Obj, but got Unknown
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected VT, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected Obj, but got Unknown
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected VT, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I4
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_01b8: Expected I, but got Obj
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_0246: Expected I, but got Obj
		//IL_02a2: Invalid comparison between VT and I4
		//IL_042d: Expected I, but got Obj
		//IL_0443: Expected Obj, but got I
		//IL_02e8: Expected I, but got Obj
		//IL_02fe: Expected Obj, but got I
		//IL_046e: Expected I, but got Obj
		//IL_0565: Expected I, but got Obj
		//IL_057b: Expected Obj, but got I
		//IL_04bb: Expected I, but got Obj
		//IL_04d1: Expected Obj, but got I
		//IL_0329: Expected I, but got Obj
		//IL_08fa: Expected I, but got Obj
		//IL_0910: Expected Obj, but got I
		//IL_05a6: Expected I, but got Obj
		//IL_04fc: Expected I, but got Obj
		//IL_064b: Expected VT, but got Obj
		//IL_05f3: Expected I, but got Obj
		//IL_0670: Expected I, but got Obj
		//IL_0686: Expected Obj, but got I
		//IL_0634: Expected VT, but got Obj
		//IL_0971: Expected I, but got Obj
		//IL_0987: Expected Obj, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03cf: Expected I4, but got Obj
		//IL_09b1: Expected F4, but got Obj
		//IL_09ac: Expected native int or pointer, but got VT
		//IL_09c6: Expected F4, but got I
		//IL_09c1: Expected native int or pointer, but got VT
		//IL_09f4: Expected VT, but got Obj
		//IL_09f4: Expected Ref, but got VT
		//IL_0a02: Expected I, but got Obj
		//IL_0a18: Expected Obj, but got I
		//IL_0a35: Expected I, but got Obj
		//IL_06b1: Expected I, but got Obj
		//IL_0a59: Expected Obj, but got I
		//IL_0a77: Expected Obj, but got I4
		//IL_0a8a: Expected native int or pointer, but got VT
		//IL_0a9c: Expected native int or pointer, but got VT
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Expected Obj, but got Unknown
		//IL_06e4: Expected I, but got Obj
		//IL_0717: Expected I, but got Obj
		//IL_0725: Expected I, but got Obj
		//IL_0753: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 56;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v180 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 88);
		Vector3 vector = (Vector3)(obj2 + 72);
		object obj4 = obj2 + 40;
		Quaternion quaternion = (Quaternion)(obj2 + 28);
		object obj5 = obj2 + 16;
		if (UICamera.currentTouchID == -2)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v33 (Il2CppClass<UICamera>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v174 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -3)
		{
			return;
		}
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag = realtimeSinceStartup < 0.01f;
		bool flag2 = !flag;
		bool flag3 = realtimeSinceStartup == 0f;
		object obj7 = flag2 | flag3;
		if (obj7 == null || !isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v22 (Il2CppClass<NGUITools>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v138 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null)
		{
			return;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v134 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) == 0)
		{
			return;
		}
		bool flag4 = mPressed;
		if (delta == (Vector2)(object)0)
		{
			if (!flag4)
			{
				return;
			}
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v116 (Il2CppClass<UICamera>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v128 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mTouchID != UICamera.currentTouchID)
			{
				return;
			}
			mPressed = false;
			if (~(restrictWithinPanel ? 1u : 0u) == 0 && dragEffect == DragEffect.MomentumAndSpring)
			{
				AsyncCallback callback = (AsyncCallback)(this + 128);
				IAsyncResult asyncResult = ((InitDelegate)(object)panelRegion).BeginInvoke((byte)(int)target != 0, callback, (object)null);
				if (asyncResult != null)
				{
					CancelSpring();
				}
			}
		}
		else
		{
			if (flag4)
			{
				return;
			}
			nint num11 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v62 (Il2CppClass<UICamera>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num12 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v151 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mTouchID = UICamera.currentTouchID;
			mPressed = true;
			mStarted = false;
			CancelSpring();
			if (~(restrictWithinPanel ? 1u : 0u) == 0)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v105 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S1_v111 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (panelRegion != null)
				{
					UpdateBounds();
				}
			}
			if (~(restrictWithinPanel ? 1u : 0u) == 0)
			{
				LateUpdate();
			}
			this._002Ector();
			nint num15 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v78 (Il2CppClass<UICamera>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num16 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v140 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject = UICamera.currentCamera.gameObject;
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num18 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S1_v100 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)panelRegion).FindKernel((string)null) != 0)
			{
				Camera anchorCamera = panelRegion.anchorCamera;
				transform.rotation = (Quaternion)anchorCamera;
			}
			else
			{
				transform.rotation = (Quaternion)gameObject;
			}
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			nint num19 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v93 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num20 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v135 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 up = Vector3.up;
			nint num21 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v99 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num22 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v132 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector)->z = 0f;
			transform = (Transform)obj4;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			((Quaternion*)quaternion)->SetLookRotation(vector, (Vector3)transform);
			nint num23 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v109 (Il2CppClass<UICamera>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			bool flag5 = obj17 == null;
			nint num24 = (nint)typeof(UICamera);
			if (!flag5)
			{
				nint num25 = (nint)typeof(UICamera);
				num24 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v127 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num24 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ L1_v11 (Il2CppClass<UICamera>)+5C]");
			object obj18 = (nint)0 + (nint)56;
			obj5 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S1_v72+8]");
			_ = 0;
			obj2 = 0;
			_ = 0;
			((Vector3*)(nint)vector)->x = quaternion.x;
			((Vector3*)(nint)vector)->z = quaternion.z;
			transform = (Transform)obj5;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D0");
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			object obj19 = this - -64;
			obj19 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
		}
	}

	private unsafe void Move(Vector3 worldDelta)
	{
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected VT, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected VT, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected Obj, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected Obj, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected Obj, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected Obj, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected Obj, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_0868: Expected Obj, but got I4
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_088b: Expected Obj, but got F4
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected Obj, but got Unknown
		//IL_08a2: Expected Obj, but got I4
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08bf: Expected Obj, but got I4
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_08dc: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_010f: Expected I, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_09ae: Expected F4, but got VT
		//IL_09a9: Expected native int or pointer, but got VT
		//IL_09bc: Expected I, but got Obj
		//IL_09d2: Expected Obj, but got I
		//IL_0d25: Expected Obj, but got F4
		//IL_0d32: Expected F4, but got Obj
		//IL_0d2d: Expected native int or pointer, but got VT
		//IL_0d4c: Expected F4, but got Obj
		//IL_0d47: Expected native int or pointer, but got VT
		//IL_0d61: Expected F4, but got I
		//IL_0d5c: Expected native int or pointer, but got VT
		//IL_0d73: Expected Ref, but got VT
		//IL_0d9b: Expected Obj, but got F4
		//IL_0da8: Expected F4, but got Obj
		//IL_0da3: Expected native int or pointer, but got VT
		//IL_0dbd: Expected F4, but got I
		//IL_0db8: Expected native int or pointer, but got VT
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected Obj, but got Unknown
		//IL_022b: Expected I, but got Obj
		//IL_0278: Expected I, but got Obj
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_033e: Expected I, but got Obj
		//IL_0354: Expected Obj, but got I
		//IL_09fc: Expected F4, but got Obj
		//IL_09f7: Expected native int or pointer, but got VT
		//IL_0a0e: Expected F4, but got I
		//IL_0a09: Expected native int or pointer, but got VT
		//IL_0a1b: Expected F4, but got Obj
		//IL_0a16: Expected native int or pointer, but got VT
		//IL_0a30: Expected F4, but got I
		//IL_0a2b: Expected native int or pointer, but got VT
		//IL_0a63: Expected F4, but got Obj
		//IL_0a5e: Expected native int or pointer, but got VT
		//IL_0a78: Expected F4, but got I
		//IL_0a73: Expected native int or pointer, but got VT
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected Obj, but got Unknown
		//IL_0a90: Expected Obj, but got F4
		//IL_0acb: Expected F4, but got Obj
		//IL_0ac6: Expected native int or pointer, but got VT
		//IL_0ae0: Expected F4, but got I
		//IL_0adb: Expected native int or pointer, but got VT
		//IL_037f: Expected I, but got Obj
		//IL_04b0: Expected F4, but got Obj
		//IL_04ab: Expected native int or pointer, but got VT
		//IL_04c5: Expected F4, but got I
		//IL_04c0: Expected native int or pointer, but got VT
		//IL_04e5: Expected Obj, but got F4
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_051c: Expected F4, but got Obj
		//IL_0517: Expected native int or pointer, but got VT
		//IL_0531: Expected F4, but got I
		//IL_052c: Expected native int or pointer, but got VT
		//IL_03d7: Expected I, but got Obj
		//IL_03ed: Expected Obj, but got I
		//IL_054d: Expected F4, but got Obj
		//IL_0548: Expected native int or pointer, but got VT
		//IL_0562: Expected F4, but got I
		//IL_055d: Expected native int or pointer, but got VT
		//IL_0464: Expected F4, but got Obj
		//IL_045f: Expected native int or pointer, but got VT
		//IL_0479: Expected F4, but got I
		//IL_0474: Expected native int or pointer, but got VT
		//IL_0b1b: Expected Obj, but got F4
		//IL_0418: Expected I, but got Obj
		//IL_0df3: Expected VT, but got Obj
		//IL_0df3: Expected Obj, but got VT
		//IL_0e00: Expected Obj, but got F4
		//IL_0e17: Expected F4, but got Obj
		//IL_0e12: Expected native int or pointer, but got VT
		//IL_0e2c: Expected F4, but got I
		//IL_0e27: Expected native int or pointer, but got VT
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_05f7: Expected I, but got Obj
		//IL_060d: Expected Obj, but got I
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected Obj, but got Unknown
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_06d5: Expected VT, but got Obj
		//IL_0b56: Expected F4, but got Obj
		//IL_0b51: Expected native int or pointer, but got VT
		//IL_0b6b: Expected F4, but got I
		//IL_0b66: Expected native int or pointer, but got VT
		//IL_0b9b: Expected F4, but got Obj
		//IL_0b96: Expected native int or pointer, but got VT
		//IL_0bad: Expected F4, but got I
		//IL_0ba8: Expected native int or pointer, but got VT
		//IL_0bba: Expected F4, but got Obj
		//IL_0bb5: Expected native int or pointer, but got VT
		//IL_0bcf: Expected F4, but got I
		//IL_0bca: Expected native int or pointer, but got VT
		//IL_0bed: Expected F4, but got Obj
		//IL_0be8: Expected native int or pointer, but got VT
		//IL_0c02: Expected F4, but got I
		//IL_0bfd: Expected native int or pointer, but got VT
		//IL_0c0f: Expected F4, but got Obj
		//IL_0c0a: Expected native int or pointer, but got VT
		//IL_0c24: Expected F4, but got I
		//IL_0c1f: Expected native int or pointer, but got VT
		//IL_06fd: Expected I, but got Obj
		//IL_0713: Expected Obj, but got I
		//IL_066a: Expected F4, but got Obj
		//IL_0665: Expected native int or pointer, but got VT
		//IL_067f: Expected F4, but got I
		//IL_067a: Expected native int or pointer, but got VT
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_0697: Expected Obj, but got F4
		//IL_0638: Expected I, but got Obj
		//IL_0c4c: Expected F4, but got Obj
		//IL_0c47: Expected native int or pointer, but got VT
		//IL_0c5e: Expected F4, but got I
		//IL_0c59: Expected native int or pointer, but got VT
		//IL_0c6b: Expected F4, but got Obj
		//IL_0c66: Expected native int or pointer, but got VT
		//IL_0c80: Expected F4, but got I
		//IL_0c7b: Expected native int or pointer, but got VT
		//IL_0c9e: Expected F4, but got Obj
		//IL_0c99: Expected native int or pointer, but got VT
		//IL_0cb3: Expected F4, but got I
		//IL_0cae: Expected native int or pointer, but got VT
		//IL_0cc0: Expected F4, but got Obj
		//IL_0cbb: Expected native int or pointer, but got VT
		//IL_0cd5: Expected F4, but got I
		//IL_0cd0: Expected native int or pointer, but got VT
		//IL_0cf3: Expected F4, but got Obj
		//IL_0cee: Expected native int or pointer, but got VT
		//IL_0d08: Expected F4, but got I
		//IL_0d03: Expected native int or pointer, but got VT
		//IL_073e: Expected I, but got Obj
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_07b5: Expected Obj, but got I4
		//IL_07b5: Expected I4, but got Obj
		object obj = default;
		Vector4 vector = (Vector4)(obj + 176);
		Vector3 vector2 = (Vector3)(obj + 8);
		object obj2 = obj + 96;
		Camera camera = (Camera)(obj + 72);
		object obj3 = obj + 56;
		object obj4 = obj + 44;
		object obj5 = obj + 32;
		object obj6 = obj + 20;
		object obj7 = obj + 152;
		obj7 = 0;
		_ = 0;
		_ = 0;
		object obj8 = obj + 144;
		obj8 = 0f;
		object obj9 = obj + 132;
		obj9 = 0;
		_ = 0;
		object obj10 = obj + 120;
		obj10 = 0;
		_ = 0;
		object obj11 = obj + 108;
		obj11 = 0;
		_ = 0;
		if (~(mPressed ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v28 (Il2CppClass<UICamera>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v264 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mTouchID != UICamera.currentTouchID || !isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v38 (Il2CppClass<NGUITools>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v260 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v256 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num7 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v55 (Il2CppClass<UICamera>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num8 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v223 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		currentTouch.clickNotification = UICamera.ClickNotification.BasedOnDelta;
		UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
		((Vector3*)(nint)vector2)->x = (float)currentTouch2.pos;
		nint num9 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v68 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num10 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v219 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = vector2.x;
		((Vector4*)(nint)vector)->x = (float)obj;
		Vector3 vector3 = vector;
		((Vector4*)(nint)vector)->x = (float)obj2;
		Vector4 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector4*)(nint)vector4)->z = 0f;
		camera.ScreenToViewportPoint_Injected(ref *(Vector3*)UICamera.currentCamera, out *(Vector3*)vector);
		obj7 = camera;
		_ = ((UnityEngine.Object)camera).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (UnityEngine.Camera)+10]");
		_ = 0;
		obj8 = 0f;
		((Vector4*)(nint)vector)->x = (float)obj7;
		Vector4 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
		((Vector4*)(nint)vector5)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+10]");
		_ = 0;
		object obj17 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
		object obj18 = default;
		if (obj18 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F969");
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		camera = (Camera)obj2;
		Camera camera2 = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((UnityEngine.Object)camera2).m_CachedPtr = (IntPtr)0;
		object obj19 = this + 92;
		obj3 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S1_v92+8]");
		_ = 0;
		nint num11 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v215 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)camera;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
		((Vector4*)(nint)vector)->x = (float)obj3;
		Vector4 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector4*)(nint)vector6)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		((Vector4*)(nint)vector)->x = (float)obj9;
		Vector4 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v31+8]");
		((Vector4*)(nint)vector7)->z = 0f;
		object obj21 = this + 92;
		obj21 = vector.x;
		_ = vector.z;
		if (~(mStarted ? 1u : 0u) != 0)
		{
			mStarted = true;
			nint num13 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v204 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num14 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S0_v211 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			obj10 = vector.x;
			_ = vector.z;
		}
		((Vector4*)(nint)vector)->x = (float)obj10;
		Vector4 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v34+8]");
		((Vector4*)(nint)vector8)->z = 0f;
		if (vector.x == 0f)
		{
			((Vector4*)(nint)vector)->x = (float)obj10;
			Vector4 vector9 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v34+8]");
			((Vector4*)(nint)vector9)->z = 0f;
			if (vector.y == 0f)
			{
				goto IL_0b2a;
			}
		}
		((Vector4*)(nint)vector)->x = (float)obj10;
		Vector4 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v34+8]");
		((Vector4*)(nint)vector10)->z = 0f;
		Vector3 vector11 = target.TransformPoint(vector);
		obj10 = vector2.x;
		_ = vector2.z;
		object obj23 = this + 48;
		obj2 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S1_v226+8]");
		_ = 0;
		((Vector4*)(nint)vector)->x = (float)obj2;
		Vector4 vector12 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector4*)(nint)vector12)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11455");
		((Vector4*)(nint)vector)->x = (float)obj10;
		Vector4 vector13 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v34+8]");
		((Vector4*)(nint)vector13)->z = 0f;
		Vector3 vector14 = target.InverseTransformDirection(vector);
		obj10 = camera;
		_ = ((UnityEngine.Object)camera).m_CachedPtr;
		goto IL_0b2a;
		IL_0b2a:
		if (dragEffect != DragEffect.None)
		{
			object obj24 = this + 104;
			obj2 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S1_v169+8]");
			_ = 0;
			object obj25 = this + 104;
			camera = (Camera)obj25;
			Camera camera3 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S1_v174+8]");
			((UnityEngine.Object)camera3).m_CachedPtr = (IntPtr)0;
			obj3 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v34+8]");
			_ = 0;
			nint num15 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v152 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num16 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S0_v174 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector4*)(nint)vector)->x = (float)obj3;
			Vector4 vector15 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Vector4*)(nint)vector15)->z = 0f;
			float num17 = 0.01f * momentumAmount;
			Vector3 vector16 = (Vector3)vector / num17;
			((Vector3*)(nint)vector2)->x = (float)camera;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
			((Vector4*)(nint)vector)->x = (float)obj4;
			Vector4 vector17 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Vector4*)(nint)vector17)->z = 0f;
			Vector3 vector18 = vector2 - vector;
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Vector3 vector19 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector19)->z = 0f;
			((Vector4*)(nint)vector)->x = (float)obj5;
			Vector4 vector20 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((Vector4*)(nint)vector20)->z = 0f;
			Vector3 vector21 = Vector3.LerpUnclamped(vector2, vector, 0.67f);
			((Vector4*)(nint)vector)->x = (float)obj6;
			Vector4 vector22 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			((Vector4*)(nint)vector22)->z = 0f;
			object obj27 = this + 104;
			obj27 = vector.x;
			_ = vector.z;
		}
		((Transform)vector2).localPosition = (Vector3)target;
		obj11 = vector2.x;
		_ = vector2.z;
		((Vector4*)(nint)vector)->x = (float)obj10;
		Vector4 vector23 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v34+8]");
		((Vector4*)(nint)vector23)->z = 0f;
		((UIDragResize)this).OnDrag((Vector2)vector);
		if (~(restrictWithinPanel ? 1u : 0u) != 0)
		{
			return;
		}
		object obj28 = this + 128;
		object obj29 = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		((Transform)(object)camera).localPosition = (Vector3)target;
		obj3 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v37+8]");
		_ = 0;
		nint num18 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ S1_v144 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num19 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S1_v165 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)camera;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
		((Vector4*)(nint)vector)->x = (float)obj3;
		Vector4 vector24 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector4*)(nint)vector24)->z = 0f;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector2, vector);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Vector3 vector25 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector25)->z = 0f;
		((Vector4*)(nint)vector)->x = (float)obj4;
		Vector4 vector26 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((Vector4*)(nint)vector26)->z = 0f;
		Vector3 vector27 = vector2 - vector;
		((Vector4*)(nint)vector)->x = (float)obj5;
		Vector4 vector28 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
		((Vector4*)(nint)vector28)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
		if (dragEffect != DragEffect.MomentumAndSpring)
		{
			AsyncCallback callback = (AsyncCallback)(this + 128);
			IAsyncResult asyncResult = ((InitDelegate)(object)panelRegion).BeginInvoke((byte)(int)target != 0, callback, (object)1);
			if (asyncResult != null)
			{
				CancelSpring();
			}
		}
	}

	private void LateUpdate()
	{
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I4
		//IL_032d: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_036f: Expected VT, but got Obj
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I4
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_049c: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_021c: Expected I, but got Obj
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v133 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 136;
		object obj5 = obj2 + 112;
		object obj6 = obj2 + 36;
		object obj7 = obj2 + 24;
		bool flag = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)contentRect);
		Camera anchorCamera = panelRegion.anchorCamera;
		if (flag)
		{
			Matrix4x4 localToWorldMatrix = ((Transform)(object)anchorCamera).localToWorldMatrix;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj8 = 0;
			object obj10 = default;
			while ((nint)obj8 <= 3)
			{
				object obj9 = obj10 + 16;
				object obj11 = obj8 * 12;
				object obj12 = obj9 + obj11;
				obj5 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v112+8]");
				_ = 0;
				obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
				obj4 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v22+8]");
				_ = 0;
				object obj13 = obj10 + 16;
				object obj14 = obj8 * 12;
				object obj15 = obj13 + obj14;
				obj15 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+8]");
				_ = 0;
				object obj16 = obj8 + 1;
				obj8 = obj16;
			}
			object obj17 = obj10 + 16;
			obj6 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v64+8]");
			_ = 0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v52 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v84 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			obj2 = 0;
			_ = 0;
			_ = 0;
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v22+8]");
			_ = 0;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v24+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj19 = this + 128;
			obj19 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+10]");
			_ = 0;
			object obj20 = 1;
			while ((nint)obj20 <= 3)
			{
				object obj21 = obj10 + 16;
				object obj22 = obj20 * 12;
				object obj23 = obj21 + obj22;
				obj5 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v99+8]");
				_ = 0;
				obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20+8]");
				_ = 0;
				object obj24 = this + 128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
				object obj25 = obj20 + 1;
				obj20 = obj25;
			}
		}
		else
		{
			Vector2 vector = NGUIMath.ScreenToPixels((Vector2)anchorCamera, target);
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20+10]");
			_ = 0;
			object obj26 = this + 128;
			obj26 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18+10]");
			_ = 0;
		}
	}

	public unsafe void CancelMovement()
	{
		//IL_0418: Expected I, but got Obj
		//IL_042e: Expected Obj, but got I
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected VT, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected VT, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0458: Expected F4, but got Obj
		//IL_0453: Expected native int or pointer, but got VT
		//IL_046d: Expected F4, but got I
		//IL_0468: Expected native int or pointer, but got VT
		//IL_047a: Expected F4, but got Obj
		//IL_0475: Expected native int or pointer, but got VT
		//IL_048f: Expected F4, but got I
		//IL_048a: Expected native int or pointer, but got VT
		//IL_04ad: Expected F4, but got Obj
		//IL_04a8: Expected native int or pointer, but got VT
		//IL_04c2: Expected F4, but got I
		//IL_04bd: Expected native int or pointer, but got VT
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04da: Expected Obj, but got F4
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_051a: Expected F4, but got Obj
		//IL_0515: Expected native int or pointer, but got VT
		//IL_052f: Expected F4, but got I
		//IL_052a: Expected native int or pointer, but got VT
		//IL_053c: Expected F4, but got Obj
		//IL_0537: Expected native int or pointer, but got VT
		//IL_0551: Expected F4, but got I
		//IL_054c: Expected native int or pointer, but got VT
		//IL_0136: Expected F4, but got Obj
		//IL_0131: Expected native int or pointer, but got VT
		//IL_014b: Expected F4, but got I
		//IL_0146: Expected native int or pointer, but got VT
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got F4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_018b: Invalid comparison between Obj and F4
		//IL_00ea: Expected I, but got Obj
		//IL_0202: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Ref, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Ref, but got Unknown
		//IL_02bb: Expected native int or pointer, but got VT
		//IL_02cd: Expected native int or pointer, but got VT
		//IL_0243: Expected I, but got Obj
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Ref, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_05d9: Invalid comparison between Obj and F4
		//IL_0308: Expected I, but got Obj
		//IL_031e: Expected Obj, but got I
		//IL_0349: Expected I, but got Obj
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_03c3: Expected Obj, but got I4
		//IL_03c3: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Vector3 vector = (Vector3)(obj2 + 84);
		Vector3 vector2 = (Vector3)(obj2 + 72);
		object obj3 = obj2 + 60;
		object obj4 = obj2 + 48;
		object obj5 = obj2 + 36;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 12;
		if (target != null)
		{
			return;
		}
		float fixedDeltaTime = Time.fixedDeltaTime;
		object obj8 = this + 104;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v14+8]");
		_ = 0;
		object obj9 = this + 116;
		obj4 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v19+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v103 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj11 = this + 104;
		obj11 = vector.x;
		_ = vector.z;
		object obj12 = this + 116;
		obj6 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v43+8]");
		_ = 0;
		Vector3 one = Vector3.one;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v28+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Quaternion quaternion2 = NGUIMath.SpringLerp((Quaternion)vector2, (Quaternion)vector, 20f, fixedDeltaTime);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		object obj13 = this + 116;
		obj13 = vector.x;
		_ = vector.z;
		object obj14 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj15 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.0001f))
		{
			return;
		}
		if (~(mPressed ? 1u : 0u) == 0)
		{
			Vector2 vector9 = NGUIMath.SpringDampen(ref *(Vector2*)(this + 104), 9f, fixedDeltaTime);
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v106 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (panelRegion != null)
		{
			UpdateBounds();
		}
		Vector2 vector10 = NGUIMath.SpringDampen(ref *(Vector2*)(this + 104), 9f, fixedDeltaTime);
		((Vector3*)(nint)vector)->x = vector2.x;
		((Vector3*)(nint)vector)->z = vector2.z;
		((UIDragResize)this).OnDrag((Vector2)vector);
		if (~(restrictWithinPanel ? 1u : 0u) == 0)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v91 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S1_v101 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)panelRegion).FindKernel((string)null) != 0)
			{
				LateUpdate();
				AsyncCallback callback = (AsyncCallback)(this + 128);
				bool flag = dragEffect == DragEffect.None;
				IAsyncResult asyncResult = ((InitDelegate)(object)panelRegion).BeginInvoke((byte)(int)target != 0, callback, (object)flag);
				if (asyncResult != null)
				{
					CancelSpring();
				}
				else
				{
					this._002Ector();
				}
			}
		}
		Vector2 vector11 = NGUIMath.SpringDampen(ref *(Vector2*)(this + 104), 9f, fixedDeltaTime);
		object obj18 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj19 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.0001f))
		{
			CancelSpring();
		}
	}

	public void CancelSpring()
	{
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I4
		//IL_0399: Expected I, but got Obj
		//IL_03af: Expected Obj, but got I
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Obj, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0061: Expected VT, but got Obj
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_0196: Expected I, but got Obj
		//IL_03d5: Expected F4, but got Obj
		//IL_0407: Expected F4, but got I
		//IL_0436: Expected F4, but got I
		//IL_01e4: Expected VT, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02d1: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_0238: Expected I, but got Obj
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_0312: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v103 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 72);
		Transform transform2 = (Transform)(obj2 + 36);
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 12;
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			transform2.localPosition = (Vector3)target;
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			obj5 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v70 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v83 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption = GUILayout.Width((float)obj5);
			obj = gUILayoutOption;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v21+4]");
			GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			GUILayoutOption gUILayoutOption3 = GUILayout.Width(0f);
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0)
		{
			transform.position = (Vector3)target;
		}
		else
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v52 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v57 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
		}
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj10 = this + 80;
		obj10 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v47 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one2 = Vector3.one;
		transform = transform2;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj12 = this + 104;
		obj12 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 one3 = Vector3.one;
		transform = (Transform)obj5;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v19+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		object obj13 = this + 116;
		obj13 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
	}

	private void OnScroll(float delta)
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_01cd: Invalid comparison between I and F4
		//IL_00ec: Expected I, but got Obj
		if (!isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v31 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+54]");
		float num5 = ((0f < 0f) ? (-1f) : 1f);
		float num6 = ((delta < 0f) ? (-1f) : 1f);
		if (num5 != num6)
		{
			_ = 0f;
		}
		float num7 = delta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+18]");
		float num8 = num7 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+54]");
		float num9 = 0f + num8;
	}

	public UIDragObject()
	{
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		SpringPosition component = target.GetComponent<SpringPosition>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.tag = null;
		}
	}
}
