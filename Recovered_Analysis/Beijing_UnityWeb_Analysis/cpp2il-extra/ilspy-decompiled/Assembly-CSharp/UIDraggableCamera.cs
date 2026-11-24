using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Monetization.FlurryPlugin;
using Kiloo.Monetization.FlurryPlugin.Internal;
using UnityEngine;

public class UIDraggableCamera : MonoBehaviour
{
	public Transform rootForBounds;

	public Vector2 scale;

	public float scrollWheelFactor;

	public UIDragObject.DragEffect dragEffect;

	public bool smoothDragStart;

	public float momentumAmount;

	private Camera mCam;

	private Transform mTrans;

	private bool mPressed;

	private Vector2 mMomentum;

	private Bounds mBounds;

	private float mScroll;

	private UIRoot mRoot;

	private bool mDragStarted;

	public Vector2 currentMomentum
	{
		get
		{
			//IL_0033: Expected VT, but got I4
			//IL_0033: Expected Obj, but got VT
			Vector2 vector = default;
			if ((object)this == null)
			{
				((UIDragDropItem)vector).OnDragDropMove((Vector2)0);
			}
			return vector;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector2)+34]");
			UIDraggableCamera uIDraggableCamera = (UIDraggableCamera)0;
		}
	}

	private void Start()
	{
		CancelInvoke();
	}

	private Vector3 CalculateConstrainOffset()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = this;
		Vector3 result = default;
		return result;
	}

	public bool ConstrainToBounds(bool immediate)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return FlurryVideoAdsIos._flurryadsplugin_ready((string)immediate);
	}

	public unsafe void Press(bool isPressed)
	{
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_0496: Expected Obj, but got I4
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04b3: Expected Obj, but got I4
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04d0: Expected Obj, but got I4
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04e7: Expected Obj, but got I4
		//IL_04fb: Expected I, but got Obj
		//IL_0511: Expected Obj, but got I
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected VT, but got Unknown
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected I4, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Obj, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected Obj, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected Obj, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected Obj, but got Unknown
		//IL_0732: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03fe: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_0099: Expected VT, but got I
		//IL_043f: Expected I, but got Obj
		//IL_00ce: Expected VT, but got I
		//IL_0103: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0138: Expected VT, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0182: Expected VT, but got I
		//IL_01b1: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01f9: Expected F4, but got Obj
		//IL_01f4: Expected native int or pointer, but got VT
		//IL_020e: Expected F4, but got I
		//IL_0209: Expected native int or pointer, but got VT
		//IL_0223: Expected Obj, but got I
		//IL_0249: Expected F4, but got Obj
		//IL_0244: Expected native int or pointer, but got VT
		//IL_025e: Expected F4, but got I
		//IL_0259: Expected native int or pointer, but got VT
		//IL_0273: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I4
		//IL_0351: Expected I, but got Obj
		//IL_0367: Expected Obj, but got I
		//IL_053b: Expected F4, but got Obj
		//IL_0536: Expected native int or pointer, but got VT
		//IL_0550: Expected F4, but got I
		//IL_054b: Expected native int or pointer, but got VT
		//IL_056a: Expected F4, but got Obj
		//IL_0565: Expected native int or pointer, but got VT
		//IL_057f: Expected F4, but got I
		//IL_057a: Expected native int or pointer, but got VT
		//IL_05c1: Expected I4, but got Obj
		//IL_05ce: Expected F4, but got Obj
		//IL_05c9: Expected native int or pointer, but got VT
		//IL_05e3: Expected I4, but got VT
		//IL_03de: Expected F4, but got Obj
		//IL_03d9: Expected native int or pointer, but got VT
		//IL_0392: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 244;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 232;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 56;
		obj4 = 0;
		object obj5 = obj2 + 216;
		obj5 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v181 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 280);
		bool flag = (byte)(obj2 + 272) != 0;
		Transform transform = (Transform)(obj2 + 264);
		Transform transform2 = (Transform)(obj2 + 256);
		Camera camera = (Camera)(obj2 + 200);
		Camera camera2 = (Camera)(obj2 + 184);
		Camera camera3 = (Camera)(obj2 + 168);
		Camera camera4 = (Camera)(obj2 + 152);
		object obj7 = obj2 + 136;
		object obj8 = obj2 + 124;
		object obj9 = obj2 + 112;
		object obj10 = obj2 + 100;
		object obj11 = obj2 + 40;
		object obj12 = obj2 + 88;
		object obj13 = obj2 + 76;
		object obj14 = obj2 - -64;
		object obj15 = obj2 + 48;
		object obj16 = obj2 + 32;
		object obj17 = obj2 + 24;
		object obj18 = obj2 + 16;
		object obj19 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+C]");
		if ((UnityEngine.Object)0 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+C]");
			if (((Transform)0).GetSiblingIndex() != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+28]");
				camera.rect = (Rect)0;
				obj5 = camera;
				_ = ((UnityEngine.Object)camera).m_CachedPtr;
				int height = Screen.height;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+28]");
				camera2.rect = (Rect)0;
				obj5 = camera2;
				_ = ((UnityEngine.Object)camera2).m_CachedPtr;
				int sleepTimeout = Screen.sleepTimeout;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+4]");
				object obj20 = (nint)0 * (nint)sleepTimeout;
				object obj21 = obj5 * height;
				obj = obj21;
				_ = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+28]");
				camera3.rect = (Rect)0;
				obj5 = camera3;
				_ = ((UnityEngine.Object)camera3).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
				object obj22 = 0 + obj5;
				int height2 = Screen.height;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+28]");
				camera4.rect = (Rect)0;
				obj5 = camera4;
				_ = ((UnityEngine.Object)camera4).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+C]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+4]");
				object obj23 = num3 + 0;
				int sleepTimeout2 = Screen.sleepTimeout;
				object obj24 = obj23 * sleepTimeout2;
				object obj25 = obj22 * height2;
				obj3 = obj25;
				_ = 0f;
				((Vector3*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+28]");
				Vector3 vector2 = ((Camera)0).ScreenToViewportPoint(vector);
				obj = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v43+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isPressed @ L1 (System.Boolean)+28]");
				Vector3 vector3 = ((Camera)0).ScreenToViewportPoint(vector);
				obj3 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v45+8]");
				_ = 0;
				object obj26 = (isPressed ? 1 : 0) + 60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
				object obj27 = (isPressed ? 1 : 0) + 60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
				obj11 = 0;
				obj11 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v49+4]");
				_ = 0;
				object obj28 = (isPressed ? 1 : 0) + 60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
				object obj29 = (isPressed ? 1 : 0) + 60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
				obj4 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v55+4]");
				_ = 0;
				obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				nint num4 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v157 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				if (obj30 != null)
				{
					nint num5 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v177 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v57+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 vector4 = (Vector2)vector;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 vector5 = (Vector2)vector;
				obj15 = obj11;
				obj16 = obj4;
				obj17 = obj2;
				transform2 = (Transform)obj15;
				transform = (Transform)obj16;
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj17 != 0;
				((Vector3*)(nint)vector)->x = (float)obj18;
				Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(transform2, transform, flag, (byte)(int)vector != 0);
				((Vector3*)(nint)vector)->x = (float)obj19;
				Vector3 vector6 = (Vector4)vector;
				return;
			}
		}
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v74 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v79 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
	}

	public void Drag(Vector2 delta)
	{
		//IL_0229: Invalid comparison between VT and I4
		//IL_0331: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0023: Expected I, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected I4, but got Unknown
		//IL_0083: Invalid comparison between VT and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_02a2: Expected VT, but got Obj
		//IL_02c5: Expected I, but got Obj
		//IL_02db: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_01d2: Expected I, but got Obj
		if (delta != (Vector2)(object)0)
		{
			mDragStarted = false;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 32;
		object obj4 = obj3 + 8;
		if (((ComputeShader)(object)rootForBounds).FindKernel((string)null) == 0)
		{
			return;
		}
		bool flag = (byte)(delta & 1) != 0;
		mPressed = flag;
		if (delta == (Vector2)(object)0)
		{
			if (dragEffect == UIDragObject.DragEffect.MomentumAndSpring)
			{
				Transform child = ((UIGrid)this).GetChild(0);
			}
			return;
		}
		Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(rootForBounds);
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20+10]");
		_ = 0;
		object obj5 = this + 60;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+10]");
		_ = 0;
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v37 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v59 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		obj2 = obj3;
		mMomentum = (Vector2)obj2;
		mScroll = 0f;
		SpringPosition component = GetComponent<SpringPosition>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
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

	public void Scroll(float delta)
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		if (!isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v23 (Il2CppClass<NGUITools>)+74]");
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
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)rootForBounds).FindKernel((string)null) != 0 && ((Behaviour)(object)rootForBounds).isActiveAndEnabled)
		{
			((UIDragObject)(object)rootForBounds).OnScroll(delta);
		}
	}

	private void Update()
	{
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_023d: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_02a2: Expected I4, but got Obj
		//IL_02b4: Expected I4, but got Obj
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_0186: Expected I, but got Obj
		object obj = this + 40;
		Camera component = GetComponent<Camera>();
		obj = component;
		object obj2 = this + 44;
		GameObject gameObject = base.gameObject;
		obj2 = gameObject;
		string go = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v27 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 88;
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>((GameObject)(object)go);
		obj4 = uIRoot;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(rootForBounds != null))
		{
			return;
		}
		string text = tag;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v22 (Il2CppClass<NGUITools>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v40 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Camera values = NGUITools.FindCameraForLayer((int)text);
		string format = string.ConcatArray((string[])(object)values, (int)" needs the 'Root For Bounds' parameter to be set");
		nint num7 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v30 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v36 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogErrorFormat(format, (object[])(object)this);
		tag = null;
	}

	public unsafe UIDraggableCamera()
	{
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected VT, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected VT, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got VT
		//IL_00c5: Expected Obj, but got VT
		//IL_00d3: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_0516: Expected F4, but got Obj
		//IL_0511: Expected native int or pointer, but got VT
		//IL_054e: Expected F4, but got Obj
		//IL_0549: Expected native int or pointer, but got VT
		//IL_055b: Expected F4, but got Obj
		//IL_0556: Expected native int or pointer, but got VT
		//IL_0579: Expected F4, but got Obj
		//IL_0574: Expected native int or pointer, but got VT
		//IL_0588: Expected VT, but got F4
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_017b: Invalid comparison between Obj and F4
		//IL_0114: Expected I, but got Obj
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected I4, but got Unknown
		//IL_0422: Expected Obj, but got VT
		//IL_005e: Expected I, but got Obj
		//IL_01a9: Expected VT, but got Obj
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected I4, but got Unknown
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_05ac: Expected F4, but got Obj
		//IL_05a7: Expected native int or pointer, but got VT
		//IL_05c7: Expected I, but got Obj
		//IL_05dd: Expected Obj, but got I
		//IL_0607: Expected F4, but got Obj
		//IL_0602: Expected native int or pointer, but got VT
		//IL_061e: Expected F4, but got Obj
		//IL_0619: Expected native int or pointer, but got VT
		//IL_0649: Expected F4, but got Obj
		//IL_0644: Expected native int or pointer, but got VT
		//IL_065f: Expected Obj, but got VT
		//IL_021e: Expected I, but got Obj
		//IL_02b7: Expected native int or pointer, but got VT
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got F4
		//IL_026b: Expected I, but got Obj
		//IL_0367: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_03a8: Expected I, but got Obj
		UICamera uICamera = default;
		Vector2 vector = (Vector2)(uICamera + 112);
		Vector2 vector2 = (Vector2)(uICamera + 88);
		Transform transform = (Transform)(uICamera + 8);
		object obj = uICamera + 56;
		object obj2 = uICamera + 48;
		object obj3 = uICamera + 40;
		object obj4 = uICamera + 32;
		object obj5 = uICamera + 76;
		object obj6 = uICamera + 24;
		object obj7 = uICamera - -64;
		float fixedDeltaTime = Time.fixedDeltaTime;
		if (~(mPressed ? 1u : 0u) == 0)
		{
			SpringPosition component = GetComponent<SpringPosition>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v125 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v133 (Il2CppClass<UnityEngine.Object>)+74]");
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
		else
		{
			transform = (Transform)mMomentum;
			uICamera = (UICamera)scale;
			nint num3 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v42 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v118 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = uICamera;
			((Vector2*)(nint)vector)->x = (float)obj;
			float num5 = mScroll * 20f;
			Vector2 vector3 = vector / num5;
			obj2 = transform;
			((Vector2*)(nint)vector2)->x = (float)obj2;
			((Vector2*)(nint)vector)->x = (float)obj3;
			Vector2 vector4 = vector2 - vector;
			((Vector2*)(nint)vector)->x = (float)obj4;
			mMomentum = (Vector2)vector.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B729");
			float num6 = default;
			mScroll = num6;
			object obj10 = this + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1143A");
			object obj11 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.01f))
			{
				transform.localPosition = (Vector3)mTrans;
				bool pressed = (byte)(this + 52) != 0;
				uICamera.ProcessPress(pressed, 9f, fixedDeltaTime);
				nint num7 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v64 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num8 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v114 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj6 = uICamera;
				((Vector2*)(nint)vector)->x = (float)obj6;
				Vector3 vector5 = (Vector4)vector;
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v72 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num10 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v110 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector2*)(nint)vector2)->x = (float)transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				((Vector2*)(nint)vector)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
				_ = 0;
				Vector3 vector6 = (Vector3)vector2 - (Vector3)vector;
				((Vector2*)(nint)vector)->x = (float)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
				_ = 0;
				Vector3 eulerAngles = ((Transform)vector).eulerAngles;
				Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(rootForBounds);
				((Vector2*)(nint)vector)->x = vector2.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector2)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector2)+10]");
				_ = 0;
				object obj14 = this + 60;
				obj14 = vector.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector2)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector2)+10]");
				_ = 0;
				bool index = dragEffect == UIDragObject.DragEffect.None;
				Transform child = ((UIGrid)this).GetChild(index ? 1 : 0);
				if ((object)child != null)
				{
					return;
				}
				SpringPosition component2 = GetComponent<SpringPosition>();
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v99 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v106 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
				{
					component2.tag = null;
				}
				return;
			}
		}
		mScroll = 0f;
		bool pressed2 = (byte)(this + 52) != 0;
		((UICamera)vector).ProcessPress(pressed2, 9f, fixedDeltaTime);
	}
}
